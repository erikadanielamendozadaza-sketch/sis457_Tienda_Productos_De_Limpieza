CREATE DATABASE LabProLimp;
USE master
GO

CREATE LOGIN usrprolimp WITH PASSWORD = '123456',
	CHECK_POLICY = ON,
	CHECK_EXPIRATION = OFF,
	DEFAULT_DATABASE = LabProLimp
GO
USE LabProLimp
GO
CREATE USER usrprolimp FOR LOGIN usrprolimp
GO
ALTER ROLE db_owner ADD MEMBER usrprolimp
GO

DROP TABLE IF EXISTS DetalleCompra;
DROP TABLE IF EXISTS DetalleVenta;
DROP TABLE IF EXISTS Compra;
DROP TABLE IF EXISTS Venta;
DROP TABLE IF EXISTS Producto;
DROP TABLE IF EXISTS Empleado;
DROP TABLE IF EXISTS Proveedor;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS UnidadMedida;


CREATE TABLE UnidadMedida(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	DESCRIPCION VARCHAR(20) NOT NULL UNIQUE
);



CREATE TABLE Cliente(
	id INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	nombre VARCHAR (50) NOT NULL,
	apellido VARCHAR (50) NOT NULL,
	cedulaIdentidad VARCHAR (10) NOT NULL,
	telefono BIGINT NOT NULL,
	direccion VARCHAR (250) NULL
	);

CREATE TABLE Proveedor(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	nombreEmpresa VARCHAR (50) NOT NULL,
	contacto VARCHAR (50) NOT NULL,
	telefono BIGINT NOT NULL,
	direccion VARCHAR (250) NULL,
	email VARCHAR (30) NOT NULL
);

 CREATE TABLE Empleado(
	id INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	nombre VARCHAR(30) NOT NULL,
	apellido VARCHAR(30) NULL,
	usuario VARCHAR(50) NOT NULL UNIQUE,
	contraseña VARCHAR (100) NOT NULL,
	telefono BIGINT NOT NULL
 );

 CREATE TABLE Producto(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idunidadMedida INT NOT NULL,
	idproveedor INT NOT NULL,
	nombre VARCHAR (20) NOT NULL,
	descripcion VARCHAR (100)  NOT NULL,
	categoria VARCHAR (20) NOT NULL,
	precioUnitario DECIMAL NOT NULL CHECK (precioUnitario>0),
	stock INT NOT NULL,
	fechaVencimiento DATE NOT NULL,
	CONSTRAINT fk_Producto_UnidadMedida FOREIGN KEY (idunidadMedida) REFERENCES UnidadMedida(id),
	CONSTRAINT fk_Producto_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
);

CREATE TABLE Venta(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idcliente INT NOT NULL,
	idempleado INT NOT NULL,
	fecha DATE NOT NULL DEFAULT GETDATE(),
	total DECIMAL NOT NULL CHECK (total>0),
	CONSTRAINT fk_Venta_Cliente FOREIGN KEY (idcliente) REFERENCES Cliente(id),
	CONSTRAINT fk_Venta_Empleado FOREIGN KEY (idempleado) REFERENCES Empleado(id)
);

CREATE TABLE Compra(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idproveedor INT NOT NULL,
	idempleado INT NOT NULL,
	fecha DATE NOT NULL DEFAULT GETDATE(),
	total DECIMAL NOT NULL,
	CONSTRAINT fk_Compra_Proveedor FOREIGN KEY (idproveedor) REFERENCES Proveedor(id),
	CONSTRAINT fk_Compra_Empleado FOREIGN KEY (idempleado) REFERENCES Empleado(id)
);

CREATE TABLE DetalleVenta(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idventa INT NOT NULL,
	idproducto INT NOT NULL,
	cantidad DECIMAL NOT NULL,
	precioUnitario DECIMAL NOT NULL CHECK (precioUnitario>0),
	subtotal DECIMAL NOT NULL,
	CONSTRAINT fk_DetalleVenta_Venta FOREIGN KEY (idventa) REFERENCES Venta(id),
	CONSTRAINT fk_DetalleVenta_Producto FOREIGN KEY (idproducto) REFERENCES Producto(id)
);

CREATE TABLE DetalleCompra(
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	idcompra INT NOT NULL,
	idproducto INT NOT NULL,
	cantidadC DECIMAL NOT NULL CHECK (cantidadC>0),
	precioUnitarioC DECIMAL NOT NULL CHECK (precioUnitarioC>0),
	subtotalCompra DECIMAL NOT NULL CHECK (subtotalCompra>0),
	CONSTRAINT fk_DetalleCompra_Compra FOREIGN KEY (idcompra) REFERENCES Compra(id),
	CONSTRAINT fk_DetalleCompra_Producto FOREIGN KEY (idproducto) REFERENCES Producto(id)
);