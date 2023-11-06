use master
go
IF NOT EXISTS(SELECT name FROM master.dbo.sysdatabases WHERE NAME = 'DBHACKATO')
CREATE DATABASE DBHACKATO

GO 

USE DBHACKATO

GO

if not exists (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'UsuarioSkin')
create table UsuarioSkin(
IdSkin int NOT NULL,
IdUsuario int NOT NULL,
FOREIGN KEY (IdSkin) REFERENCES SKIN(IdSkin),
FOREIGN KEY (IdUsuario) REFERENCES USUARIO(IdUsuario),



)

go

select * from dbo.SKIN