

--*******PASO 1 CREAR BASE DE DATOS EL BACK UP ESTA EN UN ARCHIVO APARTE***********--
CREATE DATABASE cinedb

USE cinedb

GO
-- tabla actores

    CREATE TABLE actores (
    [id_actor] [INT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[NombreCompleto] [varchar](100) NOT NULL,
	[FechaNacimiento] [date]  NULL,  
	[Sexo] [varchar](20) NULL,
	[Foto] [image] NULL,
	[Detalles][varchar](max)NULL
	
)

--tabla peliculas

    CREATE TABLE peliculas (
	[id_pelicula] [INT] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Titulo] [varchar](50) NOT NULL,
	[Genero] [varchar](20) NULL,
	[FechaDeEstreno] [date] NULL,
	[Foto] [image] NULL,
	[Actores] [varchar] (200) NULL
	
	
)
--***PASO 2 PROCEDIMIENTOS ALMACENADOS*****----

--Nombre de la base de datos : cinedb

-- crear actores --
create procedure AddActor

@Name varchar(50),
@birthDay date,
@gender varchar(20),
@photo image,
@details varchar(200)
as 
insert into actores 
values(@Name,@birthDay,@gender,@photo,@details)

--seleccionar actores
create procedure Actors
as 
select * from actores 

--editar actores

create procedure editActor
@idActor int,
@Name varchar(50),
@birthDay date,
@gender varchar(20),
@photo image,
@details varchar(200)
as
update actores set NombreCompleto = @Name, FechaNacimiento = @birthDay, Sexo = @gender,Foto = @photo, Detalles = @details
where id_actor = @idActor

--eliminar actores

create procedure DeleteActor
@idActor int
as
delete from actores where id_actor = @idActor

--obtener foto actor--

create procedure getPhotoActor
@idActor int
as select Foto from actores where id_actor = @idActor

--*************PELICULAS*************************--

--agregar peliculas--

create procedure AddMovie 
@title varchar(50),
@genres varchar (50),
@releaseDate date,
@photo image,
@actors varchar(200)
as
insert into peliculas 
values (@title,@genres,@releaseDate,@photo,@actors)


--seleccionar peliculas--
 
create procedure Movies
as
select * from peliculas

--editar peliculas--

create procedure editMovie
@idMovie int,
@title varchar(50),
@genre varchar(50),
@releaseDate date,
@photo image,
@actors varchar(200)
as
update peliculas set Titulo = @title, Genero = @genre, FechaDeEstreno = @releaseDate, Foto = @photo
where id_pelicula = @idMovie

-- eliminar pelicula --

create procedure DeleteMovie
@idMovie int
as
delete from peliculas where id_pelicula = @idMovie

-- obtener foto--
create procedure getPhotoMovie
@idMovie int
as
select Foto from peliculas 
where id_pelicula = @idMovie