using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAPIHackato.Models;

namespace WebAPIHackato.Data
{
    public class SkinData
    {
        public static bool nuevoSkin (Skin oSkin)
        {
            using(SqlConnection oConexion=new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd =new SqlCommand("usp_registrar",oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreSkin", oSkin.NombreSkin);
                cmd.Parameters.AddWithValue("@Tipo", oSkin.Tipo);
                cmd.Parameters.AddWithValue("@Precio", oSkin.Precio);
                cmd.Parameters.AddWithValue("@Color", oSkin.Color);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

        }

        public static bool actualizarSkin(Skin oSkin)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_actualizar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSkin", oSkin.IdSkin);
                cmd.Parameters.AddWithValue("@NombreSkin", oSkin.NombreSkin);
                cmd.Parameters.AddWithValue("@Tipo", oSkin.Tipo);
                cmd.Parameters.AddWithValue("@Precio", oSkin.Precio);
                cmd.Parameters.AddWithValue("@Color", oSkin.Color);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

        }

        public static List<Skin> listSkin()
        {
            List<Skin> oListSkin = new List<Skin>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_list", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListSkin.Add(new Skin()
                            {
                                IdSkin = Convert.ToInt32(dr["IdUsuario"]),
                                NombreSkin = dr["NombreSkin"].ToString(),
                                Tipo = dr["Tipo"].ToString(),
                                Precio = dr["Precio"].ToString(),
                                Color = dr["Color"].ToString(),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"].ToString())
                            });
                        }
                    }
                    return oListSkin;
                }


                catch (Exception ex)
                {
                    return oListSkin;
                }
            }
        }
}