CREATE DATABASE COMPUTADORABD

CREATE TABLE COMPUTADORA (
IDCOMPUTADORA INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
DESCRIPCION NVARCHAR (50) NOT NULL,
PRECIO NVARCHAR (50) NULL,
FECHAFABRICACION NVARCHAR (20) NULL,

PRIMARY KEY (IDCOMPUTADORA),
);
				
SELECT * FROM COMPUTADORA


insert into COMPUTADORA values('hp','sexual','15000','2022-12-27 10:15:00');
