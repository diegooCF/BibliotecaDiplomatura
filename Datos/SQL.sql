
CREATE PROCEDURE procAlta
(
	/*Parametros*/
	@Tabla nvarchar(100),
	@Descripcion nvarchar(50)
)
as
/*Cuerpo principal del procedure*/
declare @Sentencia nvarchar(100)
set @Sentencia = 'Insert into '+ @Tabla + '(Descripcion) Values ('''+@Descripcion+''')'
execute(@Sentencia)
}

execute procAlta 'Generos','Ficcion'

select * from Generos