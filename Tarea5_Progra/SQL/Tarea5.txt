create database EncuestasUH

use EncuestasUH


create table Persona
(
	cedula varchar (15) primary key,
	nombre varchar (50) not null,
	Genero char(1) constraint chk_Genero Check( Genero = 'F' or Genero = 'M'),
	Fecha date constraint Def_fecha Default Getdate()
)

create table Respuestas
(
	id int identity (1,1),
	cedulaR varchar(15),
	r1 char(1),
	r2 char(1),
	r3 char(1),
	constraint PK_id Primary key(id),
	constraint FK_cedula Foreign key(cedulaR) references Persona(cedula) 
)

select respuestas.id, respuestas.cedulaR, Persona.nombre, respuestas.r1, respuestas.r2, respuestas.r3 from Respuestas
inner join Persona on respuestas.cedulaR= persona.cedula