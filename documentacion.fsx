
-- crear actores
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

