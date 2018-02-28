create database ArticulosDB;

create table Articulos
(
	ArticuloID int primary key identity(1,1),
	Descipcion varchar(100),
	precio decimal
)
