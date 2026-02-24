CREATE DATABASE BD_TEST

----------------------------------------------------

Table Creation

CREATE TABLE USUARIO ( id int IDENTITY(1,1) PRIMARY KEY NOT NULL, usuario varchar(50) NOT NULL, contrasena varchar(50) NOT NULL, intentos int NOT NULL, nivelSeg decimal(18,0) NOT NULL, fechaReg date );

Store Procedures Creation

SP_INSERTAR_USUARIO

CREATE PROCEDURE SP_INSERTAR_USUARIO @usuario varchar(50) ,@contrasena varchar(250) ,@intentos int ,@nivelSeg decimal(18,0) ,@fechaReg date AS BEGIN SET NOCOUNT ON; INSERT INTO [dbo].[USUARIO] ([usuario] ,[contrasena] ,[intentos] ,[nivelSeg] ,[fechaReg]) VALUES (@usuario ,@contrasena ,@intentos ,@nivelSeg ,@fechaReg) END

SP_SELECCIONAR_USUARIO

CREATE PROCEDURE SP_SELECCIONAR_USUARIO @id int AS BEGIN SET NOCOUNT ON; SELECT usuario ,contrasena ,intentos ,nivelSeg ,fechaReg FROM [dbo].[USUARIO] WHERE id = @id END

SP_ACTUALIZAR_USUARIO

CREATE PROCEDURE SP_ACTUALIZAR_USUARIO @usuario varchar(50) ,@contrasena varchar(250) ,@intentos int ,@nivelSeg decimal(18,0) ,@fechaReg date ,@id int AS BEGIN SET NOCOUNT ON; UPDATE USUARIO SET usuario = @usuario ,contrasena = @contrasena ,intentos = @intentos ,nivelSeg = @nivelSeg ,fechaReg = @fechaReg WHERE id = @id END

SP_ELIMINAR_USUARIO

CREATE PROCEDURE SP_ELIMINAR_USUARIO @id int AS BEGIN SET NOCOUNT ON; DELETE FROM USUARIO WHERE id = @id END

SP_SELECCIONAR_ALL_USUARIO

CREATE PROCEDURE SP_SELECCIONAR_ALL_USUARIO AS SELECT * FROM USUARIO

----------------------------------------------------

Table Creation

CREATE TABLE PRODUCTO ( Id INT PRIMARY KEY IDENTITY(1,1), nombre VARCHAR(100) NOT NULL, cantidad INT NOT NULL );

Store Procedures Creation

SP_INSERTAR_PRODUCTO

CREATE PROCEDURE SP_INSERTAR_PRODUCTO @nombre VARCHAR(100), @cantidad INT AS BEGIN INSERT INTO PRODUCTO (nombre, cantidad) VALUES (@nombre, @cantidad); END

SP_SELECCIONAR_ALL_PRODUCTO

CREATE PROCEDURE SP_SELECCIONAR_ALL_PRODUCTO AS BEGIN SELECT * FROM PRODUCTO; END

SP_ACTUALIZAR_PRODUCTO

CREATE PROCEDURE SP_ACTUALIZAR_PRODUCTO @nombre VARCHAR(100), @cantidad INT, @id INT AS BEGIN UPDATE PRODUCTO  SET nombre = @nombre,  cantidad = @cantidad  WHERE Id = @id; END

SP_ELIMINAR_PRODUCTO

CREATE PROCEDURE SP_ELIMINAR_PRODUCTO @id INT AS BEGIN DELETE FROM PRODUCTO WHERE Id = @id; END

