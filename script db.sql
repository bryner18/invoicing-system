USE [master]
GO
/****** Object:  Database [Ferreteria]    Script Date: 1/10/2020 11:36:41 AM ******/
CREATE DATABASE [Ferreteria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ferreteria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Ferreteria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ferreteria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Ferreteria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Ferreteria] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ferreteria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ferreteria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ferreteria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ferreteria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ferreteria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ferreteria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ferreteria] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Ferreteria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ferreteria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ferreteria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ferreteria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ferreteria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ferreteria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ferreteria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ferreteria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ferreteria] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Ferreteria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ferreteria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ferreteria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ferreteria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ferreteria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ferreteria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ferreteria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ferreteria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ferreteria] SET  MULTI_USER 
GO
ALTER DATABASE [Ferreteria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ferreteria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ferreteria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ferreteria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ferreteria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ferreteria] SET QUERY_STORE = OFF
GO
USE [Ferreteria]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Ferreteria]
GO
/****** Object:  Table [dbo].[ARTICULO]    Script Date: 1/10/2020 11:36:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULO](
	[id_art] [int] IDENTITY(1,1) NOT NULL,
	[nom_art] [varchar](30) NOT NULL,
	[cant_art] [int] NOT NULL,
	[prec_art] [money] NOT NULL,
	[desc_art] [varchar](100) NOT NULL,
	[prov_art] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 1/10/2020 11:36:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[id_cli] [int] IDENTITY(1,1) NOT NULL,
	[nom_cli] [varchar](30) NOT NULL,
	[ape_cli] [varchar](30) NOT NULL,
	[tel_cli] [varchar](18) NOT NULL,
	[ced_cli] [varchar](13) NOT NULL,
	[dir_cli] [varchar](45) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_FACTURA]    Script Date: 1/10/2020 11:36:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_FACTURA](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_fact] [int] NOT NULL,
	[id_art] [int] NOT NULL,
	[prec_art] [decimal](18, 2) NOT NULL,
	[cant_art] [int] NOT NULL,
	[id_cliente] [int] NULL,
	[fecha] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA]    Script Date: 1/10/2020 11:36:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[monto_total] [decimal](18, 2) NOT NULL,
	[fecha] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura1]    Script Date: 1/10/2020 11:36:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura1](
	[id_factura] [int] NOT NULL,
	[cli_aten] [varchar](30) NOT NULL,
	[monto_total] [decimal](18, 2) NULL,
	[fecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDOR]    Script Date: 1/10/2020 11:36:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[id_prov] [int] NOT NULL,
	[nom_prov] [varchar](30) NOT NULL,
	[tel_prov] [varchar](18) NOT NULL,
	[sec_prov] [varchar](30) NOT NULL,
	[raz_prov] [varchar](30) NOT NULL,
	[dir_prov] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_prov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] NOT NULL,
	[nom_usuario] [varchar](30) NOT NULL,
	[pass_usuario] [varchar](20) NOT NULL,
	[tipo_usuario] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ModificarCliente]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ModificarCliente]
@id_cli as int,
@tel_cli as varchar(18),
@dir_cli as varchar(45)
as
update CLIENTE set tel_cli = @tel_cli, dir_cli = @dir_cli
where id_cli = @id_cli
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoAlmacen]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoAlmacen]
@prov_art as varchar(30)
as 
select * from ARTICULO where prov_art = @prov_art
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoAlmacen2]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoAlmacen2]
@cant_art as int,
@prov_art as int
as
select * from ARTICULO where @prov_art = prov_art and cant_art <= @cant_art
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoAlmacenCantidad]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoAlmacenCantidad]
@cant1 as int,
@cant2 as int
as
select * from ARTICULO where cant_art between @cant1 and @cant2
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoAlmacenGeneralizado]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoAlmacenGeneralizado]
as
select * from ARTICULO
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoAlmacenPrecio]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoAlmacenPrecio]
@preciomin as money,
@preciomax as money
as
select * from ARTICULO where prec_art between @preciomin and @preciomax
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoAlmacenProveedor]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoAlmacenProveedor]
@id_proveedor as int
as
select * from ARTICULO where prov_art = @id_proveedor
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoArticulo]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoArticulo]
@nombreart as varchar(30)
as
select * from ARTICULO where nom_art = @nombreart
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoFactura]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoFactura]
@fecha1 as datetime,
@fecha2 as datetime
as
select * from FACTURA where fecha between @fecha1 and @fecha2
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoFacturaCodigo]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoFacturaCodigo]
@id_fact int
as
select id_fact, id_cliente, id_art, prec_art, cant_art, fecha from DETALLE_FACTURA where id_fact = @id_fact
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoFacturaCodigoCliente]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoFacturaCodigoCliente]
@id_cliente int
as
select id_fact, id_cliente, id_art, prec_art, cant_art, fecha from DETALLE_FACTURA where id_cliente = @id_cliente
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoFacturaFecha]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoFacturaFecha]
@fecha1 as date,
@fecha2 as date
as
select id_fact, id_cliente, id_art, prec_art, cant_art, fecha from DETALLE_FACTURA where fecha between @fecha1 and @fecha2
GO
/****** Object:  StoredProcedure [dbo].[ReporteEspecificoFacturaGeneralizado]    Script Date: 1/10/2020 11:36:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteEspecificoFacturaGeneralizado]
as
select id_fact, id_cliente, id_art, prec_art, cant_art, fecha from DETALLE_FACTURA
GO
USE [master]
GO
ALTER DATABASE [Ferreteria] SET  READ_WRITE 
GO
