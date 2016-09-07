USE [Biblioteca]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 07/09/2016 11:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autores](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [date] NULL,
	[Nacionalidad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Editorial]    Script Date: 07/09/2016 11:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Editorial](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](50) NULL,
 CONSTRAINT [PK_Editorial] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Generos]    Script Date: 07/09/2016 11:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](50) NULL,
 CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Libro_has_Autores]    Script Date: 07/09/2016 11:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro_has_Autores](
	[idAutor] [int] NOT NULL,
	[idLibro] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Libro_has_Autores] PRIMARY KEY CLUSTERED 
(
	[idAutor] ASC,
	[idLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Libros]    Script Date: 07/09/2016 11:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[ISBN] [nchar](10) NOT NULL,
	[Titulo] [nchar](50) NULL,
	[idGenero] [int] NOT NULL,
	[idEditorial] [int] NOT NULL,
	[Edicion] [int] NULL,
 CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Autores] ON 

GO
INSERT [dbo].[Autores] ([Codigo], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (3, N'Garcia Marquez', N'Gabriel', CAST(N'1940-08-30' AS Date), N'Argentina')
GO
INSERT [dbo].[Autores] ([Codigo], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (5, N'Alpedo', N'Jorge', CAST(N'1989-09-07' AS Date), N'Chile')
GO
INSERT [dbo].[Autores] ([Codigo], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (6, N'Pepe', N'Pistolas', CAST(N'1968-09-07' AS Date), N'Argentina')
GO
INSERT [dbo].[Autores] ([Codigo], [Apellido], [Nombre], [FechaNacimiento], [Nacionalidad]) VALUES (7, N'Juan', N'Narizvitali', CAST(N'1997-09-07' AS Date), N'Argentina')
GO
SET IDENTITY_INSERT [dbo].[Autores] OFF
GO
SET IDENTITY_INSERT [dbo].[Generos] ON 

GO
INSERT [dbo].[Generos] ([ID], [Descripcion]) VALUES (1, N'Ficcion                                           ')
GO
SET IDENTITY_INSERT [dbo].[Generos] OFF
GO
ALTER TABLE [dbo].[Libro_has_Autores]  WITH CHECK ADD  CONSTRAINT [FK_Libro_has_Autores_Autores] FOREIGN KEY([idAutor])
REFERENCES [dbo].[Autores] ([Codigo])
GO
ALTER TABLE [dbo].[Libro_has_Autores] CHECK CONSTRAINT [FK_Libro_has_Autores_Autores]
GO
ALTER TABLE [dbo].[Libro_has_Autores]  WITH CHECK ADD  CONSTRAINT [FK_Libro_has_Autores_Libros] FOREIGN KEY([idLibro])
REFERENCES [dbo].[Libros] ([ISBN])
GO
ALTER TABLE [dbo].[Libro_has_Autores] CHECK CONSTRAINT [FK_Libro_has_Autores_Libros]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Editorial] FOREIGN KEY([idEditorial])
REFERENCES [dbo].[Editorial] ([ID])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Editorial]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Generos] FOREIGN KEY([idGenero])
REFERENCES [dbo].[Generos] ([ID])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Generos]
GO
/****** Object:  StoredProcedure [dbo].[procAlta]    Script Date: 07/09/2016 11:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[procAlta]
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

GO
/****** Object:  StoredProcedure [dbo].[procEliminarAutor]    Script Date: 07/09/2016 11:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procEliminarAutor]
(
	/*Parametros*/
	@Codigo int
)
as
/*Cuerpo principal del procedure*/
DELETE Autores
WHERE
	Autores.Codigo = @Codigo;
GO
/****** Object:  StoredProcedure [dbo].[procModificaAutor]    Script Date: 07/09/2016 11:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Descripcion : Modificar datos de Autores
Fecha de Creacion : 24/08/2016
Autor : Tecnica 29 
Ultima Actualizacion : 24/08/2016*/
create procedure [dbo].[procModificaAutor]
(
	/*Parametros */
	@Codigo int,
	@Apellido nvarchar(50),
	@Nombre nvarchar(50),
	@FechaNacimiento date = NULL,
	@Nacionalidad nvarchar(50) =NULL
)
as
/* cuerpo principal del sp*/
update Autores
set Apellido=@Apellido,
	Nombre=@Nombre,
	FechaNacimiento=@FechaNacimiento,
	Nacionalidad=@Nacionalidad
where Codigo=@Codigo


GO
/****** Object:  StoredProcedure [dbo].[procVerTodo]    Script Date: 07/09/2016 11:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procVerTodo]
(
	/*Parametros*/
	@Tabla nvarchar(100)
)
as
/*Cuerpo principal del procedure*/
declare @Sentencia nvarchar(200)
set @Sentencia = 'Select * from ' + @Tabla
execute(@Sentencia)

GO
