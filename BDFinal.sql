create database LibrosProyecto
use LibrosProyecto

create table usuario(
idUsario int identity primary key,
userName varchar(50),
pswrd varchar(50),
nombreDelUsuario varchar(30)
)

insert into usuario values ('Dereck27','Dereck1234','Dereck Hidalgo')

create table editorial(
idEditorial int identity primary key,
nombreEditorial varchar(50),
direccionEditorial varchar(100),
descripcion varchar(100),
telefono varchar(30),
)
create table autor(
idAutor int identity primary key,
nombreAutor varchar(30),
apellidoAutor varchar(30),
estado varchar(10),
edad int,
pais varchar(30)
)
create table libros(
idLibros int identity primary key,
nombreLibro varchar(100),
fechaPublicacion datetime,
precioLibro decimal,
idEditorial int,
idAutor int,
)
create table factura(
idFactura int identity primary key,
nombreCliente varchar(30),
fechaFactura datetime,
descripcion varchar(200)
)

create table facturaDetalle(
idFactDetalle int identity primary key,
idLibros int,
)

