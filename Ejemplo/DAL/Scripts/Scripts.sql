create database PersonaDb
go
use PersonaDb
go
create table Personas
(
Id int primary key identity,
Nombre varchar(30),
Telefono varchar(13),
Cedula varchar(13),
Direccion varchar(max)
);
insert into Personas(Nombre,Telefono,Cedula,Direccion) values('Walder','8092344343','40228460586','Liberdad');
Select * from Personas;
