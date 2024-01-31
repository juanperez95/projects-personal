create database asociacion;

use asociacion;

set language spanish;

create table acudiente(
	nombre varchar(50),
	documento int primary key not null,
	telefono varchar(11),
	celular varchar(11),
	direccion varchar(50),
	correo varchar(60)
);


create table jardin(
	idJardin int not null primary key,
	nombreJardin varchar(50),
	direccion varchar(60),
	estado varchar(50)
);


create table madre_comunitaria(
	idMadre int not null primary key,
	nombres varchar(50),
	telefono varchar(50),
	direccionResidencia varchar(50),
	fechaNacimiento date
);


create table child(
	registro int not null primary key,
	nombres varchar(50),
	fechaNacimiento date,
	tipoSangre varchar(20),
	ciudadNacimiento varchar(50),
	idAcudiente int foreign key references acudiente(documento),
	telefono varchar(11),
	direccion varchar(60),
	eps varchar(60),
	idJardin int foreign key references jardin(idJardin),
);


create table asistencia(
	idChild int foreign key references child(registro),
	fecha date,
	descripcion varchar(50)
);



create table avance_academico(
	idChild int foreign key references child(registro),
	yearEscolar varchar(5),
	nivel varchar(50),
	notas varchar(20),
	descripcion text,
	fechaEntregaNotas date
);

/*select * from madre_comunitaria;
select * from acudiente;
select * from child;
select * from jardin;
select * from asistencia;
select * from avance_academico;*/

select registro from child where idAcudiente = 15;
select * from avance_academico where idChild = 14;

--drop database asociacion;



