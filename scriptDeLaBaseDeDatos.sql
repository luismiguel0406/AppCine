-- crear actores --
create procedure AddActor

@NameAutor varchar(50),
@birthDate date,
@gender varchar(20),
@photo image,
@details varchar(200)
as 
insert into actores 
values(@NameAutor,@birthDate,@gender,@photo,@details)

--seleccionar actores
create procedure Actors
as 
select * from actores 

--editar actores

create procedure editActor
@idActor int,
@NameAutor varchar(50),
@birthDate date,
@gender varchar(20),
@photo image,
@details varchar(200)
as
update actores set NombreCompleto = @NameAutor,FechaNacimiento = @birthDate, Sexo = @gender,Foto = @photo, Detalles = @details
where id_actor = @idActor

--eliminar actores

create procedure DeleteActor
@idActor int
as
delete from actores where id_actor = @idActor

--*************PELICULAS*************************--

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