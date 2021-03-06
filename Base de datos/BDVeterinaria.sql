USE [master]
GO
/****** Object:  Database [BDVeterinaria]    Script Date: 30/6/2021 21:51:56 ******/
CREATE DATABASE [BDVeterinaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDVeterinaria', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BDVeterinaria.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDVeterinaria_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BDVeterinaria_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BDVeterinaria] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDVeterinaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDVeterinaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDVeterinaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDVeterinaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDVeterinaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDVeterinaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDVeterinaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDVeterinaria] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BDVeterinaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDVeterinaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDVeterinaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDVeterinaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDVeterinaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDVeterinaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDVeterinaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDVeterinaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDVeterinaria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDVeterinaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDVeterinaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDVeterinaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDVeterinaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDVeterinaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDVeterinaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDVeterinaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDVeterinaria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDVeterinaria] SET  MULTI_USER 
GO
ALTER DATABASE [BDVeterinaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDVeterinaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDVeterinaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDVeterinaria] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BDVeterinaria]
GO
/****** Object:  Table [dbo].[Consulta]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consulta](
	[IDConsulta] [int] IDENTITY(1,1) NOT NULL,
	[IDProfesional] [int] NULL,
	[IDMascota] [int] NULL,
	[Fecha] [datetime] NULL,
	[Peso] [nvarchar](50) NULL,
	[Observación] [nvarchar](50) NULL,
 CONSTRAINT [PK_Consulta] PRIMARY KEY CLUSTERED 
(
	[IDConsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleConsulta]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleConsulta](
	[IDDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IDConsulta] [int] NULL,
	[IDTipoConsulta] [int] NULL,
	[Diagnostico] [nvarchar](50) NULL,
	[Tratamiento] [nvarchar](50) NULL,
	[Dosis] [nvarchar](50) NULL,
	[NumeroLote] [int] NULL,
	[FechaVto] [datetime] NULL,
 CONSTRAINT [PK_DetalleConsulta] PRIMARY KEY CLUSTERED 
(
	[IDDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dueño]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dueño](
	[IDDueño] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Domicilio] [nvarchar](50) NULL,
	[Telefono] [bigint] NULL,
	[IDLocalidad] [int] NULL,
	[DNI] [int] NULL,
	[Correo] [nvarchar](50) NULL,
	[Observaciones] [nvarchar](50) NULL,
 CONSTRAINT [PK_Dueño] PRIMARY KEY CLUSTERED 
(
	[IDDueño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[IDLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[IDProvincia] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[IDLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mascota](
	[IDMascota] [int] IDENTITY(1,1) NOT NULL,
	[IDDueño] [int] NULL,
	[IDTipo] [int] NULL,
	[IDRaza] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
	[FechaNacimiento] [datetime] NULL,
	[FechaBaja] [datetime] NULL,
	[Motivo] [nvarchar](50) NULL,
	[Foto] [varbinary](max) NULL,
 CONSTRAINT [PK_Mascota] PRIMARY KEY CLUSTERED 
(
	[IDMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[IDPais] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[IDPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profesional]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesional](
	[IDProfesional] [int] IDENTITY(1,1) NOT NULL,
	[IDLocalidad] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [bigint] NULL,
 CONSTRAINT [PK_Profesional] PRIMARY KEY CLUSTERED 
(
	[IDProfesional] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[IDProvincia] [int] IDENTITY(1,1) NOT NULL,
	[IDPais] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[IDProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Raza]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raza](
	[IDRaza] [int] IDENTITY(1,1) NOT NULL,
	[IDTipo] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Raza] PRIMARY KEY CLUSTERED 
(
	[IDRaza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [nvarchar](128) NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
 CONSTRAINT [PK_sysdiagrams] PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[IDTipo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tipo] PRIMARY KEY CLUSTERED 
(
	[IDTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoConsulta]    Script Date: 30/6/2021 21:51:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoConsulta](
	[IDTipoConsulta] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Vacuna] [nvarchar](50) NULL,
 CONSTRAINT [PK_TipoConsulta] PRIMARY KEY CLUSTERED 
(
	[IDTipoConsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Localidad] ON 

INSERT [dbo].[Localidad] ([IDLocalidad], [IDProvincia], [Nombre]) VALUES (1, 1, N'Villa Maria')
SET IDENTITY_INSERT [dbo].[Localidad] OFF
SET IDENTITY_INSERT [dbo].[Pais] ON 

INSERT [dbo].[Pais] ([IDPais], [Nombre]) VALUES (1, N'Argentina')
SET IDENTITY_INSERT [dbo].[Pais] OFF
SET IDENTITY_INSERT [dbo].[Provincia] ON 

INSERT [dbo].[Provincia] ([IDProvincia], [IDPais], [Nombre]) VALUES (1, 1, N'Cordoba')
SET IDENTITY_INSERT [dbo].[Provincia] OFF
/****** Object:  Index [IX_FK_Consulta_Mascota]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Consulta_Mascota] ON [dbo].[Consulta]
(
	[IDMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Consulta_Profesional]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Consulta_Profesional] ON [dbo].[Consulta]
(
	[IDProfesional] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_DetalleConsulta_Consulta]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_DetalleConsulta_Consulta] ON [dbo].[DetalleConsulta]
(
	[IDConsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_DetalleConsulta_TipoConsulta]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_DetalleConsulta_TipoConsulta] ON [dbo].[DetalleConsulta]
(
	[IDTipoConsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Dueño_Localidad]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Dueño_Localidad] ON [dbo].[Dueño]
(
	[IDLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Localidad_Provincia]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Localidad_Provincia] ON [dbo].[Localidad]
(
	[IDProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Mascota_Dueño]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Mascota_Dueño] ON [dbo].[Mascota]
(
	[IDDueño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Mascota_Raza]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Mascota_Raza] ON [dbo].[Mascota]
(
	[IDRaza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Mascota_Tipo]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Mascota_Tipo] ON [dbo].[Mascota]
(
	[IDTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Profesional_Localidad]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Profesional_Localidad] ON [dbo].[Profesional]
(
	[IDLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Provincia_Pais]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Provincia_Pais] ON [dbo].[Provincia]
(
	[IDPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Raza_Tipo]    Script Date: 30/6/2021 21:51:56 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Raza_Tipo] ON [dbo].[Raza]
(
	[IDTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Consulta]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Mascota] FOREIGN KEY([IDMascota])
REFERENCES [dbo].[Mascota] ([IDMascota])
GO
ALTER TABLE [dbo].[Consulta] CHECK CONSTRAINT [FK_Consulta_Mascota]
GO
ALTER TABLE [dbo].[Consulta]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Profesional] FOREIGN KEY([IDProfesional])
REFERENCES [dbo].[Profesional] ([IDProfesional])
GO
ALTER TABLE [dbo].[Consulta] CHECK CONSTRAINT [FK_Consulta_Profesional]
GO
ALTER TABLE [dbo].[DetalleConsulta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleConsulta_Consulta] FOREIGN KEY([IDConsulta])
REFERENCES [dbo].[Consulta] ([IDConsulta])
GO
ALTER TABLE [dbo].[DetalleConsulta] CHECK CONSTRAINT [FK_DetalleConsulta_Consulta]
GO
ALTER TABLE [dbo].[DetalleConsulta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleConsulta_TipoConsulta] FOREIGN KEY([IDTipoConsulta])
REFERENCES [dbo].[TipoConsulta] ([IDTipoConsulta])
GO
ALTER TABLE [dbo].[DetalleConsulta] CHECK CONSTRAINT [FK_DetalleConsulta_TipoConsulta]
GO
ALTER TABLE [dbo].[Dueño]  WITH CHECK ADD  CONSTRAINT [FK_Dueño_Localidad] FOREIGN KEY([IDLocalidad])
REFERENCES [dbo].[Localidad] ([IDLocalidad])
GO
ALTER TABLE [dbo].[Dueño] CHECK CONSTRAINT [FK_Dueño_Localidad]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Localidad_Provincia] FOREIGN KEY([IDProvincia])
REFERENCES [dbo].[Provincia] ([IDProvincia])
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Localidad_Provincia]
GO
ALTER TABLE [dbo].[Mascota]  WITH CHECK ADD  CONSTRAINT [FK_Mascota_Dueño] FOREIGN KEY([IDDueño])
REFERENCES [dbo].[Dueño] ([IDDueño])
GO
ALTER TABLE [dbo].[Mascota] CHECK CONSTRAINT [FK_Mascota_Dueño]
GO
ALTER TABLE [dbo].[Mascota]  WITH CHECK ADD  CONSTRAINT [FK_Mascota_Raza] FOREIGN KEY([IDRaza])
REFERENCES [dbo].[Raza] ([IDRaza])
GO
ALTER TABLE [dbo].[Mascota] CHECK CONSTRAINT [FK_Mascota_Raza]
GO
ALTER TABLE [dbo].[Mascota]  WITH CHECK ADD  CONSTRAINT [FK_Mascota_Tipo] FOREIGN KEY([IDTipo])
REFERENCES [dbo].[Tipo] ([IDTipo])
GO
ALTER TABLE [dbo].[Mascota] CHECK CONSTRAINT [FK_Mascota_Tipo]
GO
ALTER TABLE [dbo].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_Localidad] FOREIGN KEY([IDLocalidad])
REFERENCES [dbo].[Localidad] ([IDLocalidad])
GO
ALTER TABLE [dbo].[Profesional] CHECK CONSTRAINT [FK_Profesional_Localidad]
GO
ALTER TABLE [dbo].[Provincia]  WITH CHECK ADD  CONSTRAINT [FK_Provincia_Pais] FOREIGN KEY([IDPais])
REFERENCES [dbo].[Pais] ([IDPais])
GO
ALTER TABLE [dbo].[Provincia] CHECK CONSTRAINT [FK_Provincia_Pais]
GO
ALTER TABLE [dbo].[Raza]  WITH CHECK ADD  CONSTRAINT [FK_Raza_Tipo] FOREIGN KEY([IDTipo])
REFERENCES [dbo].[Tipo] ([IDTipo])
GO
ALTER TABLE [dbo].[Raza] CHECK CONSTRAINT [FK_Raza_Tipo]
GO
USE [master]
GO
ALTER DATABASE [BDVeterinaria] SET  READ_WRITE 
GO
