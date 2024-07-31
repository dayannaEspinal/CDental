--INTEGRANTES DEL EQUIPO CIODENTAL:
-- JAIME BELLORIN
-- NERY GONZALES
-- WILSON FERRERA
USE [master]
GO
/****** Object:  Database [CioDental1]    Script Date: 17/04/2024 21:57:15 ******/
CREATE DATABASE [CioDental1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CioDental1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CioDental1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CioDental1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CioDental1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CioDental1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CioDental1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CioDental1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CioDental1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CioDental1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CioDental1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CioDental1] SET ARITHABORT OFF 
GO
ALTER DATABASE [CioDental1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CioDental1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CioDental1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CioDental1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CioDental1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CioDental1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CioDental1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CioDental1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CioDental1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CioDental1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CioDental1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CioDental1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CioDental1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CioDental1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CioDental1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CioDental1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CioDental1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CioDental1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CioDental1] SET  MULTI_USER 
GO
ALTER DATABASE [CioDental1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CioDental1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CioDental1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CioDental1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CioDental1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CioDental1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CioDental1] SET QUERY_STORE = OFF
GO
USE [CioDental1]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 17/04/2024 21:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdPro] [int] NOT NULL,
	[NomPro] [nvarchar](50) NOT NULL,
	[DesPro] [nvarchar](100) NULL,
	[FecVen] [date] NULL,
	[PrePro] [int] NOT NULL,
	[StockPro] [int] NOT NULL,
	[IdMar] [int] NOT NULL,
 CONSTRAINT [PK__Producto__2ACD4C7EEA4CD033] PRIMARY KEY CLUSTERED 
(
	[IdPro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComprasDetalles]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprasDetalles](
	[IdComDet] [int] NOT NULL,
	[IdCom] [int] NOT NULL,
	[IdPro] [int] NOT NULL,
	[CantPro] [int] NOT NULL,
	[PrePro] [int] NOT NULL,
 CONSTRAINT [PK_ComprasDetalles_1] PRIMARY KEY CLUSTERED 
(
	[IdComDet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComprasEncabezdo]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprasEncabezdo](
	[IdCom] [int] NOT NULL,
	[NroFac] [nvarchar](15) NULL,
	[FecCom] [date] NOT NULL,
	[IdConProv] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tratamientos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tratamientos](
	[IdTra] [int] NOT NULL,
	[DesTra] [nvarchar](100) NOT NULL,
	[CosTra] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaEncabezado]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaEncabezado](
	[IdFac] [int] NOT NULL,
	[FecFac] [date] NOT NULL,
	[HorFac] [time](7) NOT NULL,
	[IdCit] [int] NOT NULL,
	[NomUsr] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK__FacturaE__0FE27A022F361FBE] PRIMARY KEY CLUSTERED 
(
	[IdFac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaDetalle]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaDetalle](
	[IdFacDet] [int] NOT NULL,
	[IdFac] [int] NOT NULL,
	[IdTra] [int] NULL,
	[PrecTra] [int] NULL,
	[IdPro] [int] NULL,
	[CantPro] [int] NULL,
	[PrecPro] [int] NULL,
 CONSTRAINT [PK_FacturaDetalle_1] PRIMARY KEY CLUSTERED 
(
	[IdFacDet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaEstadoCuenta]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaEstadoCuenta] AS
SELECT 'Compra' AS Tipo, 
       FecCom AS Fecha, 
       'Se compro un producto: ' + Productos.NomPro AS Descripcion, 
       Productos.PrePro AS Precio, 
       CantPro AS Cantidad,
       Productos.PrePro * CantPro AS Total
FROM ComprasDetalles
INNER JOIN ComprasEncabezdo ON ComprasDetalles.IdCom = ComprasEncabezdo.IdCom
INNER JOIN Productos ON ComprasDetalles.IdPro = Productos.IdPro

UNION ALL

SELECT 'Factura' AS Tipo, 
       FecFac AS Fecha, 
       'Se realizó un tratamiento: ' + Tratamientos.DesTra AS Descripcion, 
       PrecTra AS Precio, 
       CantPro AS Cantidad,
       PrecTra * CantPro AS Total
FROM FacturaDetalle
INNER JOIN FacturaEncabezado ON FacturaDetalle.IdFac = FacturaEncabezado.IdFac
INNER JOIN Tratamientos ON FacturaDetalle.IdTra = Tratamientos.IdTra
WHERE FacturaDetalle.IdPro IS NULL

UNION ALL

SELECT 'Factura' AS Tipo, 
       FecFac AS Fecha, 
       'Se vendió un producto: ' + Productos.NomPro AS Descripcion, 
       PrecPro AS Precio, 
       CantPro AS Cantidad,
       PrecPro * CantPro AS Total
FROM FacturaDetalle
INNER JOIN FacturaEncabezado ON FacturaDetalle.IdFac = FacturaEncabezado.IdFac
INNER JOIN Productos ON FacturaDetalle.IdPro = Productos.IdPro
WHERE FacturaDetalle.IdTra IS NULL

UNION ALL

SELECT 'Factura' AS Tipo, 
       FecFac AS Fecha, 
       'Se realizó un tratamiento y se vendió un producto: ' + Tratamientos.DesTra + ' - ' + Productos.NomPro AS Descripcion, 
       PrecTra + PrecPro AS Precio, 
       CantPro AS Cantidad,
       (PrecTra + PrecPro) * CantPro AS Total
FROM FacturaDetalle
INNER JOIN FacturaEncabezado ON FacturaDetalle.IdFac = FacturaEncabezado.IdFac
INNER JOIN Tratamientos ON FacturaDetalle.IdTra = Tratamientos.IdTra
INNER JOIN Productos ON FacturaDetalle.IdPro = Productos.IdPro
WHERE FacturaDetalle.IdTra IS NOT NULL AND FacturaDetalle.IdPro IS NOT NULL
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[IdBit] [int] IDENTITY(1,1) NOT NULL,
	[FecBit] [date] NOT NULL,
	[HrBit] [time](7) NOT NULL,
	[DecBit] [nvarchar](225) NOT NULL,
	[IdUsr] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK__Bitacora__0EE92D997CBA2987] PRIMARY KEY CLUSTERED 
(
	[IdBit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[IdCit] [int] NOT NULL,
	[IdPac] [int] NOT NULL,
	[FecCit] [date] NOT NULL,
	[HorCit] [time](7) NOT NULL,
	[EstCit] [bit] NOT NULL,
 CONSTRAINT [PK__Citas__0FA7C154AE0B1D50] PRIMARY KEY CLUSTERED 
(
	[IdCit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactoProveedor]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactoProveedor](
	[IdConProv] [int] NOT NULL,
	[NombConProv] [nvarchar](50) NOT NULL,
	[NumConProv] [int] NOT NULL,
	[EmlConProv] [nvarchar](80) NOT NULL,
	[EstConProv] [bit] NOT NULL,
	[IdProv] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdConProv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[IdMar] [int] NOT NULL,
	[NomMar] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[IdPac] [int] NOT NULL,
	[NomPac] [nvarchar](40) NOT NULL,
	[ApePac] [nvarchar](40) NOT NULL,
	[GenPac] [nvarchar](20) NOT NULL,
	[FecNac] [date] NOT NULL,
	[DirPac] [nvarchar](100) NOT NULL,
	[TelPac] [int] NOT NULL,
	[EmlPac] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK__Paciente__2ACE3A079782848D] PRIMARY KEY CLUSTERED 
(
	[IdPac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[IdProv] [int] NOT NULL,
	[NomProv] [nvarchar](30) NOT NULL,
	[NumProv] [int] NOT NULL,
	[DirProv] [nvarchar](100) NOT NULL,
	[EmlProv] [nvarchar](80) NOT NULL,
	[RTNProv] [nvarchar](15) NULL,
	[EstProv] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[NomUsr] [nvarchar](30) NOT NULL,
	[ConUsr] [nvarchar](70) NOT NULL,
	[EstUsr] [bit] NOT NULL,
	[RolUsr] [nvarchar](30) NULL,
 CONSTRAINT [PK__Usuarios__4B332B06D344AD56] PRIMARY KEY CLUSTERED 
(
	[NomUsr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (1, 2, CAST(N'2024-02-29' AS Date), CAST(N'10:30:00' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (2, 2, CAST(N'2024-04-07' AS Date), CAST(N'16:36:16' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (3, 1, CAST(N'2024-02-28' AS Date), CAST(N'22:50:50' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (4, 2, CAST(N'2024-04-17' AS Date), CAST(N'15:54:13' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (5, 1, CAST(N'2024-03-01' AS Date), CAST(N'15:46:26' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (7, 2, CAST(N'2024-03-01' AS Date), CAST(N'19:57:18' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (8, 2, CAST(N'2024-03-02' AS Date), CAST(N'11:00:00' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (9, 2, CAST(N'2024-03-02' AS Date), CAST(N'21:23:58' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (10, 1, CAST(N'2024-03-02' AS Date), CAST(N'21:30:11' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (11, 1, CAST(N'2024-03-02' AS Date), CAST(N'21:36:11' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (12, 1, CAST(N'2024-03-07' AS Date), CAST(N'15:15:03' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (13, 2, CAST(N'2024-03-07' AS Date), CAST(N'15:15:53' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (14, 2, CAST(N'2024-03-07' AS Date), CAST(N'15:16:30' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (15, 1, CAST(N'2024-03-07' AS Date), CAST(N'15:22:49' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (16, 2, CAST(N'2024-03-07' AS Date), CAST(N'21:49:19' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (17, 2, CAST(N'2024-03-08' AS Date), CAST(N'23:15:06' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (18, 1, CAST(N'2024-03-08' AS Date), CAST(N'23:15:59' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (19, 2, CAST(N'2024-03-23' AS Date), CAST(N'16:56:26' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (20, 1, CAST(N'2024-03-24' AS Date), CAST(N'15:58:39' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (21, 1, CAST(N'2024-03-24' AS Date), CAST(N'15:58:51' AS Time), 0)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (22, 2, CAST(N'2024-03-26' AS Date), CAST(N'11:10:08' AS Time), 0)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (23, 3, CAST(N'2024-03-27' AS Date), CAST(N'22:37:08' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (24, 4, CAST(N'2024-03-27' AS Date), CAST(N'22:43:32' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (25, 5, CAST(N'2024-03-23' AS Date), CAST(N'23:24:42' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (26, 6, CAST(N'2024-04-06' AS Date), CAST(N'17:45:35' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (27, 7, CAST(N'2024-04-06' AS Date), CAST(N'11:00:00' AS Time), 1)
GO
INSERT [dbo].[Citas] ([IdCit], [IdPac], [FecCit], [HorCit], [EstCit]) VALUES (28, 8, CAST(N'2024-04-17' AS Date), CAST(N'15:53:37' AS Time), 1)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (1, 1, 1, 1, 45)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (2, 1, 3, 1, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (3, 14, 5, 1, 40)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (4, 14, 4, 1, 350)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (5, 14, 6, 1, 60)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (6, 15, 8, 1, 530)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (7, 15, 7, 1, 450)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (8, 15, 5, 1, 40)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (9, 16, 4, 1, 350)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (10, 16, 2, 1, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (11, 16, 5, 1, 40)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (12, 17, 5, 1, 40)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (13, 17, 7, 1, 450)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (14, 17, 8, 1, 530)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (15, 18, 3, 1, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (16, 18, 6, 1, 60)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (17, 19, 3, 1, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (18, 19, 6, 1, 60)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (19, 20, 7, 1, 450)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (20, 20, 6, 1, 60)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (21, 21, 3, 1, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (22, 21, 5, 1, 40)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (23, 22, 1, 11, 75)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (24, 22, 2, 8, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (25, 22, 3, 6, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (26, 22, 4, 2, 350)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (27, 22, 4, 2, 350)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (28, 22, 1, 1, 75)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (29, 22, 2, 4, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (30, 22, 1, 4, 75)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (31, 23, 1, 5, 75)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (32, 24, 2, 9, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (33, 24, 3, 7, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (34, 24, 5, 5, 40)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (35, 25, 9, 22, 55)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (36, 26, 1, 2, 75)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (37, 26, 2, 2, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (38, 26, 5, 1, 40)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (39, 27, 9, 2, 55)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (40, 27, 3, 3, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (41, 27, 1, 2, 75)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (42, 28, 1, 3, 75)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (43, 28, 9, 3, 55)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (44, 28, 7, 1, 450)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (45, 30, 8, 1, 530)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (46, 30, 2, 1, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (47, 31, 2, 2, 35)
GO
INSERT [dbo].[ComprasDetalles] ([IdComDet], [IdCom], [IdPro], [CantPro], [PrePro]) VALUES (48, 32, 3, 1, 35)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (1, N' 4567 ', CAST(N'2024-03-01' AS Date), 2)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (2, N' 99999 ', CAST(N'2024-03-03' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (3, N' 6785 ', CAST(N'2024-03-07' AS Date), 2)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (4, N' 1234 ', CAST(N'2024-03-07' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (5, N' 789 ', CAST(N'2024-03-07' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (6, N' 4502 ', CAST(N'2024-03-07' AS Date), 3)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (7, N' 9022 ', CAST(N'2024-03-07' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (8, N' 8654 ', CAST(N'2024-03-07' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (9, N' 8080 ', CAST(N'2024-03-07' AS Date), 2)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (10, N' 777 ', CAST(N'2024-03-07' AS Date), 2)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (11, N' 7676 ', CAST(N'2024-03-07' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (12, N' 86787 ', CAST(N'2024-04-04' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (13, N' 6789 ', CAST(N'2024-04-04' AS Date), 3)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (14, N' 55489 ', CAST(N'2024-04-04' AS Date), 5)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (15, N' 983637 ', CAST(N'2024-04-05' AS Date), 4)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (16, N' 83873 ', CAST(N'2024-04-05' AS Date), 3)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (17, N' 8888 ', CAST(N'2024-04-05' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (18, N' 6799 ', CAST(N'2024-04-05' AS Date), 3)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (19, N' 939393 ', CAST(N'2024-04-06' AS Date), 4)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (20, N' 20300 ', CAST(N'2024-04-06' AS Date), 2)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (21, N' 29390 ', CAST(N'2024-04-07' AS Date), 5)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (22, N' 99383 ', CAST(N'2024-04-12' AS Date), 3)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (23, N' 858494 ', CAST(N'2024-04-12' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (24, N' 8930 ', CAST(N'2024-04-12' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (25, N' 8499 ', CAST(N'2024-04-12' AS Date), 5)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (26, N' 994747 ', CAST(N'2024-04-12' AS Date), 2)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (27, N' 28339 ', CAST(N'2024-04-13' AS Date), 4)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (28, N' 1389 ', CAST(N'2024-04-17' AS Date), 5)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (29, N' 123 ', CAST(N'2024-04-17' AS Date), 10)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (30, N' 849939 ', CAST(N'2024-04-17' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (31, N' 99993 ', CAST(N'2024-04-17' AS Date), 1)
GO
INSERT [dbo].[ComprasEncabezdo] ([IdCom], [NroFac], [FecCom], [IdConProv]) VALUES (32, N' 93993 ', CAST(N'2024-04-17' AS Date), 1)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (1, N' José Reyes ', 97880202, N' reyesj@gmail.com ', 1, 2)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (2, N' Gloria Trujillo  ', 97240022, N' trujilloglo@gmail.com  ', 1, 3)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (3, N' Jesus Cuz  ', 33096745, N' salgadoje@gmail.com   ', 1, 1)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (4, N' Fabio Gónzalez ', 32670949, N' gonzalezfab@gmail.com ', 1, 1)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (5, N' Pamela Sevilla ', 94502367, N' sevillapa@gmail.com ', 1, 2)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (6, N' Salome Flores   ', 32994939, N' sam@gmail.com     ', 1, 2)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (7, N' Sergio Ramos     ', 96426272, N' se@gmail.com     ', 1, 4)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (8, N' Sahory Baquedano   ', 93837388, N' sa@gmail.com    ', 1, 2)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (9, N' Marcos Sevilla  ', 94024593, N' semarcos@gmail.com  ', 0, 7)
GO
INSERT [dbo].[ContactoProveedor] ([IdConProv], [NombConProv], [NumConProv], [EmlConProv], [EstConProv], [IdProv]) VALUES (10, N' Odent ', 12343463, N' odent@gmail.com ', 1, 10)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (1, 1, 1, 20, 1, NULL, 20)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (2, 1, 1, 30, 1, NULL, 30)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (3, 6, 2, 4000, 3, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (4, 7, 1, 700, 1, NULL, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (5, 8, 2, 4000, 1, NULL, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (6, 10, 1, 700, 4, NULL, 350)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (7, 10, 2, 4000, 2, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (8, 2, 2, 4000, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (9, 18, 3, 26500, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (10, 19, NULL, NULL, 5, NULL, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (11, 20, 2, 4000, 6, NULL, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (12, 20, 4, 3300, 5, NULL, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (13, 20, 2, 4000, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (14, 20, NULL, NULL, 3, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (15, 21, 4, 3300, 5, NULL, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (16, 22, 1, 700, 2, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (17, 22, 4, 3300, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (18, 23, 1, 700, 1, NULL, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (19, 23, 4, 3300, 3, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (20, 24, 4, 3300, 6, NULL, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (21, 25, 4, 3300, 6, NULL, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (22, 26, 4, 3300, 1, NULL, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (23, 29, 2, 4000, 6, NULL, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (24, 31, 1, 700, 2, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (25, 32, 2, 4000, 6, NULL, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (26, 33, 2, 4000, 2, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (27, 34, 2, 4000, 5, NULL, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (28, 34, 3, 26500, 6, NULL, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (29, 35, 2, 4000, 3, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (30, 36, 4, 3300, 5, NULL, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (31, 36, 2, 4000, 6, NULL, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (32, 36, 3, 26500, 1, NULL, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (33, 39, 1, 700, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (34, 40, 3, 26500, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (35, 40, NULL, NULL, 3, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (36, 42, 1, 700, 5, NULL, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (37, 42, 2, 4000, 3, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (38, 43, 3, 26500, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (39, 43, NULL, NULL, 6, NULL, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (40, 44, 1, 700, 1, NULL, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (41, 44, 3, 26500, 4, NULL, 350)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (42, 45, 2, 4000, 8, NULL, 530)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (43, 45, 4, 3300, 7, NULL, 450)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (44, 46, 1, 700, 6, NULL, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (45, 47, 1, 700, 2, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (46, 47, 2, 4000, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (47, 48, 3, 26500, 1, NULL, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (48, 48, NULL, NULL, 3, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (49, 49, 3, 26500, 2, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (50, 49, 4, 3300, 5, NULL, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (51, 49, 2, 4000, 2, NULL, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (52, 50, 1, 700, 1, NULL, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (53, 50, 4, 3300, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (54, 51, 1, 700, 1, 1, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (55, 52, 2, 4000, 9, 1, 55)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (56, 53, 1, 700, 9, 2, 55)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (57, 53, 2, 4000, 3, 2, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (58, 54, 2, 4000, 1, 2, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (59, 54, 1, 700, 3, 1, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (60, 55, 1, 700, 1, 2, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (61, 56, 2, 4000, 9, 1, 55)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (62, 56, 4, 3300, 3, 1, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (63, 57, 4, 3300, 9, 2, 55)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (64, 57, 1, 700, NULL, 0, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (65, 57, NULL, NULL, 3, 2, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (66, 58, 1, 700, 1, 2, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (67, 58, 4, 3300, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (68, 58, NULL, NULL, 3, 2, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (69, 59, 2, 4000, 1, 2, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (70, 59, 4, 3300, 9, 1, 55)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (71, 60, 1, 700, 1, 2, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (72, 60, 4, 3300, 3, 1, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (73, 61, 4, 3300, 5, 2, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (74, 61, 2, 4000, 2, 1, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (75, 62, 4, 3300, 1, 1, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (76, 63, 2, 4000, 1, 1, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (77, 64, 3, 26500, 5, 2, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (78, 65, 1, 700, 1, 1, 75)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (79, 65, 4, 3300, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (80, 66, 2, 4000, 5, 2, 40)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (81, 66, 1, 700, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (82, 67, 4, 3300, 9, 2, 55)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (83, 67, 1, 700, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (84, 68, 4, 3300, 2, 3, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (85, 68, 1, 700, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (86, 68, NULL, NULL, 6, 1, 60)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (87, 70, 1, 700, 3, 1, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (88, 70, 2, 4000, NULL, NULL, NULL)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (89, 71, 3, 26500, 2, 2, 35)
GO
INSERT [dbo].[FacturaDetalle] ([IdFacDet], [IdFac], [IdTra], [PrecTra], [IdPro], [CantPro], [PrecPro]) VALUES (90, 72, 3, 26500, 1, 1, 75)
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (1, CAST(N'2024-03-04' AS Date), CAST(N'09:30:00' AS Time), 2, N' Celia ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (2, CAST(N'2024-03-04' AS Date), CAST(N'15:25:17' AS Time), 5, N' Libny12 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (3, CAST(N'2024-03-04' AS Date), CAST(N'11:30:00' AS Time), 3, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (4, CAST(N'2024-03-07' AS Date), CAST(N'23:43:54' AS Time), 2, N' Grecia ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (5, CAST(N'2024-03-07' AS Date), CAST(N'23:50:55' AS Time), 1, N' Celia ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (6, CAST(N'2024-03-20' AS Date), CAST(N'13:25:48' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (7, CAST(N'2024-03-28' AS Date), CAST(N'21:54:51' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (8, CAST(N'2024-03-28' AS Date), CAST(N'22:10:17' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (9, CAST(N'2024-03-29' AS Date), CAST(N'21:51:57' AS Time), 23, N'Wilson19')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (10, CAST(N'2024-03-30' AS Date), CAST(N'12:58:51' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (11, CAST(N'2024-03-30' AS Date), CAST(N'14:00:56' AS Time), 19, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (12, CAST(N'2024-03-30' AS Date), CAST(N'14:04:55' AS Time), 13, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (13, CAST(N'2024-03-30' AS Date), CAST(N'14:20:11' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (14, CAST(N'2024-03-30' AS Date), CAST(N'14:51:01' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (15, CAST(N'2024-03-30' AS Date), CAST(N'14:55:59' AS Time), 23, N' Celia ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (16, CAST(N'2024-03-30' AS Date), CAST(N'15:04:26' AS Time), 13, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (17, CAST(N'2024-03-30' AS Date), CAST(N'15:06:40' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (18, CAST(N'2024-03-30' AS Date), CAST(N'15:10:25' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (19, CAST(N'2024-03-30' AS Date), CAST(N'15:11:13' AS Time), 10, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (20, CAST(N'2024-03-30' AS Date), CAST(N'15:24:45' AS Time), 9, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (21, CAST(N'2024-03-30' AS Date), CAST(N'15:32:54' AS Time), 17, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (22, CAST(N'2024-04-02' AS Date), CAST(N'15:26:42' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (23, CAST(N'2024-04-03' AS Date), CAST(N'15:34:44' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (24, CAST(N'2024-04-03' AS Date), CAST(N'16:06:03' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (25, CAST(N'2024-04-03' AS Date), CAST(N'16:07:12' AS Time), 24, N' Celia ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (26, CAST(N'2024-04-03' AS Date), CAST(N'16:14:54' AS Time), 11, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (27, CAST(N'2024-04-03' AS Date), CAST(N'16:39:52' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (28, CAST(N'2024-04-03' AS Date), CAST(N'16:48:56' AS Time), 5, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (29, CAST(N'2024-04-03' AS Date), CAST(N'19:53:05' AS Time), 13, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (30, CAST(N'2024-04-03' AS Date), CAST(N'20:39:51' AS Time), 7, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (31, CAST(N'2024-04-03' AS Date), CAST(N'20:46:59' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (32, CAST(N'2024-04-03' AS Date), CAST(N'20:53:49' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (33, CAST(N'2024-04-03' AS Date), CAST(N'22:23:04' AS Time), 4, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (34, CAST(N'2024-04-03' AS Date), CAST(N'22:33:26' AS Time), 5, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (35, CAST(N'2024-04-03' AS Date), CAST(N'23:13:42' AS Time), 9, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (36, CAST(N'2024-04-03' AS Date), CAST(N'23:21:32' AS Time), 17, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (37, CAST(N'2024-04-03' AS Date), CAST(N'23:30:13' AS Time), 20, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (38, CAST(N'2024-04-03' AS Date), CAST(N'23:35:39' AS Time), 7, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (39, CAST(N'2024-04-03' AS Date), CAST(N'23:41:13' AS Time), 13, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (40, CAST(N'2024-04-03' AS Date), CAST(N'23:42:26' AS Time), 17, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (41, CAST(N'2024-04-05' AS Date), CAST(N'10:53:14' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (42, CAST(N'2024-04-05' AS Date), CAST(N'10:59:39' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (43, CAST(N'2024-04-05' AS Date), CAST(N'11:03:49' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (44, CAST(N'2024-04-05' AS Date), CAST(N'15:31:51' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (45, CAST(N'2024-04-06' AS Date), CAST(N'17:18:57' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (46, CAST(N'2024-04-06' AS Date), CAST(N'17:22:50' AS Time), 11, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (47, CAST(N'2024-04-06' AS Date), CAST(N'17:42:46' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (48, CAST(N'2024-04-06' AS Date), CAST(N'23:33:32' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (49, CAST(N'2024-04-06' AS Date), CAST(N'23:43:15' AS Time), 2, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (50, CAST(N'2024-04-07' AS Date), CAST(N'12:38:50' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (51, CAST(N'2024-04-12' AS Date), CAST(N'12:39:05' AS Time), 4, N' Celia ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (52, CAST(N'2024-04-12' AS Date), CAST(N'12:55:32' AS Time), 24, N' Celia ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (53, CAST(N'2024-04-13' AS Date), CAST(N'12:34:58' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (54, CAST(N'2024-04-13' AS Date), CAST(N'22:46:24' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (55, CAST(N'2024-04-14' AS Date), CAST(N'12:51:27' AS Time), 2, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (56, CAST(N'2024-04-14' AS Date), CAST(N'12:52:06' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (57, CAST(N'2024-04-14' AS Date), CAST(N'22:03:13' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (58, CAST(N'2024-04-14' AS Date), CAST(N'22:24:23' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (59, CAST(N'2024-04-14' AS Date), CAST(N'22:28:48' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (60, CAST(N'2024-04-16' AS Date), CAST(N'00:10:40' AS Time), 27, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (61, CAST(N'2024-04-16' AS Date), CAST(N'00:12:21' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (62, CAST(N'2024-04-16' AS Date), CAST(N'00:24:15' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (63, CAST(N'2024-04-16' AS Date), CAST(N'00:29:58' AS Time), 24, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (64, CAST(N'2024-04-16' AS Date), CAST(N'00:38:16' AS Time), 7, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (65, CAST(N'2024-04-16' AS Date), CAST(N'00:41:16' AS Time), 1, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (66, CAST(N'2024-04-16' AS Date), CAST(N'00:43:39' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (67, CAST(N'2024-04-16' AS Date), CAST(N'00:51:27' AS Time), 26, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (68, CAST(N'2024-04-17' AS Date), CAST(N'15:12:21' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (69, CAST(N'2024-04-17' AS Date), CAST(N'16:11:56' AS Time), 20, N' Celia ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (70, CAST(N'2024-04-17' AS Date), CAST(N'21:11:18' AS Time), 23, N' Wilson19 ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (71, CAST(N'2024-04-17' AS Date), CAST(N'21:18:52' AS Time), 24, N' Celia ')
GO
INSERT [dbo].[FacturaEncabezado] ([IdFac], [FecFac], [HorFac], [IdCit], [NomUsr]) VALUES (72, CAST(N'2024-04-17' AS Date), CAST(N'21:27:20' AS Time), 1, N' Wilson19 ')
GO
INSERT [dbo].[Marcas] ([IdMar], [NomMar]) VALUES (1, N' Lucky ')
GO
INSERT [dbo].[Marcas] ([IdMar], [NomMar]) VALUES (2, N'VITA')
GO
INSERT [dbo].[Marcas] ([IdMar], [NomMar]) VALUES (3, N'NSK')
GO
INSERT [dbo].[Marcas] ([IdMar], [NomMar]) VALUES (4, N' CLINAK ')
GO
INSERT [dbo].[Marcas] ([IdMar], [NomMar]) VALUES (5, N' DENTALHN ')
GO
INSERT [dbo].[Marcas] ([IdMar], [NomMar]) VALUES (6, N' Colgate ')
GO
INSERT [dbo].[Pacientes] ([IdPac], [NomPac], [ApePac], [GenPac], [FecNac], [DirPac], [TelPac], [EmlPac]) VALUES (1, N'Nery ', N'Gonzales ', N' Masculino ', CAST(N'2002-05-13' AS Date), N' Danlí, El Paraíso, Honduras ', 96096634, N' gonzalesne@gmail.com ')
GO
INSERT [dbo].[Pacientes] ([IdPac], [NomPac], [ApePac], [GenPac], [FecNac], [DirPac], [TelPac], [EmlPac]) VALUES (2, N'Jessy  ', N'Sevilla  ', N' Masculino ', CAST(N'2006-08-04' AS Date), N'Danlí, El Paraíso   ', 32456789, N'    juana9@gmail.com    ')
GO
INSERT [dbo].[Pacientes] ([IdPac], [NomPac], [ApePac], [GenPac], [FecNac], [DirPac], [TelPac], [EmlPac]) VALUES (3, N'Maria   ', N'Martinez ', N' Femenino ', CAST(N'2000-07-14' AS Date), N'  Jacaleapa, El Paraíso  ', 33497052, N'  medinama7@gmail.com  ')
GO
INSERT [dbo].[Pacientes] ([IdPac], [NomPac], [ApePac], [GenPac], [FecNac], [DirPac], [TelPac], [EmlPac]) VALUES (4, N'Alberto  ', N'Trujillo ', N' Masculino ', CAST(N'2024-03-24' AS Date), N'  Cantarranas  ', 3288778, N'  al@gmail.com  ')
GO
INSERT [dbo].[Pacientes] ([IdPac], [NomPac], [ApePac], [GenPac], [FecNac], [DirPac], [TelPac], [EmlPac]) VALUES (5, N'Noé ', N'Paz ', N' Masculino ', CAST(N'2009-02-27' AS Date), N' Oropolí, El Paraíso ', 83883992, N' paz@gmail.com ')
GO
INSERT [dbo].[Pacientes] ([IdPac], [NomPac], [ApePac], [GenPac], [FecNac], [DirPac], [TelPac], [EmlPac]) VALUES (6, N'Yamileth ', N'Lozano ', N' Femenino ', CAST(N'1899-11-16' AS Date), N' Danlí, El Paraíso ', 94027333, N' yalozano@gmail.com ')
GO
INSERT [dbo].[Pacientes] ([IdPac], [NomPac], [ApePac], [GenPac], [FecNac], [DirPac], [TelPac], [EmlPac]) VALUES (7, N' Maria ', N' Hernandez ', N' Femenino ', CAST(N'1999-10-12' AS Date), N' El Paraíso, El Paraíso ', 32889373, N' maher@gmail.com ')
GO
INSERT [dbo].[Pacientes] ([IdPac], [NomPac], [ApePac], [GenPac], [FecNac], [DirPac], [TelPac], [EmlPac]) VALUES (8, N' Raul     ', N' Mejia  ', N' Masculino ', CAST(N'1989-07-15' AS Date), N' Danlí, El Paraíso    ', 97230422, N' ra@gmail.com    ')
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (1, N' Enjuague ', N' Elimina bacterias ', CAST(N'2024-11-14' AS Date), 75, 8, 1)
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (2, N' Pasta dental ', N' Elimina caries ', CAST(N'2024-12-12' AS Date), 35, 11, 3)
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (3, N'  Cepillo  ', N'  Para quitar suciedad ', NULL, 35, 4, 1)
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (4, N'  Pinza  ', N'      ', NULL, 350, 2, 3)
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (5, N' Hilo Dental ', N'  ', NULL, 40, 7, 4)
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (6, N' Mascarillas ', N'  ', CAST(N'2024-07-19' AS Date), 60, 8, 5)
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (7, N' Cera ortodóntica ', N'  ', CAST(N'2024-04-18' AS Date), 450, 3, 4)
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (8, N'  Protector bocal  ', N'  Uso para deportistas  ', CAST(N'2024-04-21' AS Date), 530, 5, 5)
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (9, N' Pasta dental ', N'  ', CAST(N'2024-04-24' AS Date), 55, 18, 6)
GO
INSERT [dbo].[Productos] ([IdPro], [NomPro], [DesPro], [FecVen], [PrePro], [StockPro], [IdMar]) VALUES (10, N' Protesis ', N'  ', CAST(N'2024-04-17' AS Date), 45000, 0, 1)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (1, N' Sirona ', 32457706, N' Roatán, Honduras ', N' siro@gmail.com ', N' 45880945 ', 1)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (2, N' CERET ', 32457809, N' Tegucigalpa D.C. ', N' ceret@gmail.com ', N' 492746 ', 1)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (3, N' ITEL ', 32009652, N' La Ceiba, Atlántida ', N' itel@gmail.com ', N' 349720 ', 1)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (4, N' AATT ', 94560022, N' Comayagua, Comayagua ', N' aatt@gmail.com ', N' 67904 ', 1)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (5, N'  Farmacia Kielsa  ', 32560977, N'  Tegucigalpa D.C  ', N'  kielsa@gmail.com  ', N' 951 ', 1)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (6, N'  Farmacia El Ahorro  ', 9853637, N'  Danlí  ', N'  fh@gmail.com  ', N'    ', 1)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (7, N'  Farmacia Siman  ', 38494003, N'   Yuscaran   ', N'   ca@gmail.com   ', N'   383929   ', 0)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (8, N'  RuralHN       ', 884882727, N'  Tegucigalpa       ', N'  ru@gmail.com       ', N'  3748339     ', 1)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (9, N'  Farmacia Kielsa  ', 93873737, N'  Danlí, El Paraíso  ', N'  ki@gmail.com  ', N' 33333 ', 1)
GO
INSERT [dbo].[Proveedores] ([IdProv], [NomProv], [NumProv], [DirProv], [EmlProv], [RTNProv], [EstProv]) VALUES (10, N' Odent ', 45363443, N' Tegucigalpa ', N' odent2@gmail.co ', N' 00012000123 ', 1)
GO
INSERT [dbo].[Tratamientos] ([IdTra], [DesTra], [CosTra]) VALUES (1, N'  Limpieza dental  ', 700)
GO
INSERT [dbo].[Tratamientos] ([IdTra], [DesTra], [CosTra]) VALUES (2, N'  Blanqueamiento dental  ', 4000)
GO
INSERT [dbo].[Tratamientos] ([IdTra], [DesTra], [CosTra]) VALUES (3, N'   Ortodoncia   ', 26500)
GO
INSERT [dbo].[Tratamientos] ([IdTra], [DesTra], [CosTra]) VALUES (4, N'  Extracción de muela  ', 3300)
GO
INSERT [dbo].[Usuarios] ([NomUsr], [ConUsr], [EstUsr], [RolUsr]) VALUES (N'Alan', N'carranza', 1, N'Colaborador')
GO
INSERT [dbo].[Usuarios] ([NomUsr], [ConUsr], [EstUsr], [RolUsr]) VALUES (N'Ricardo', N'sosa', 0, N'Colaborador')
GO
INSERT [dbo].[Usuarios] ([NomUsr], [ConUsr], [EstUsr], [RolUsr]) VALUES (N'Jasson', N'mendoza', 1, N'Colaborador')
GO
INSERT [dbo].[Usuarios] ([NomUsr], [ConUsr], [EstUsr], [RolUsr]) VALUES (N'German', N'martinez', 1, N'Colaborador')
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK__Bitacora__IdUsr__5165187F] FOREIGN KEY([IdUsr])
REFERENCES [dbo].[Usuarios] ([NomUsr])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK__Bitacora__IdUsr__5165187F]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK__Citas__IdPac__5535A963] FOREIGN KEY([IdPac])
REFERENCES [dbo].[Pacientes] ([IdPac])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK__Citas__IdPac__5535A963]
GO
ALTER TABLE [dbo].[ComprasDetalles]  WITH CHECK ADD  CONSTRAINT [FK__ComprasDe__IdCom__59063A47] FOREIGN KEY([IdCom])
REFERENCES [dbo].[ComprasEncabezdo] ([IdCom])
GO
ALTER TABLE [dbo].[ComprasDetalles] CHECK CONSTRAINT [FK__ComprasDe__IdCom__59063A47]
GO
ALTER TABLE [dbo].[ComprasDetalles]  WITH CHECK ADD  CONSTRAINT [FK__ComprasDe__IdPro__5CD6CB2B] FOREIGN KEY([IdPro])
REFERENCES [dbo].[Productos] ([IdPro])
GO
ALTER TABLE [dbo].[ComprasDetalles] CHECK CONSTRAINT [FK__ComprasDe__IdPro__5CD6CB2B]
GO
ALTER TABLE [dbo].[ComprasEncabezdo]  WITH CHECK ADD  CONSTRAINT [FK_ComprasEncabezdo_ContactoProveedor] FOREIGN KEY([IdConProv])
REFERENCES [dbo].[ContactoProveedor] ([IdConProv])
GO
ALTER TABLE [dbo].[ComprasEncabezdo] CHECK CONSTRAINT [FK_ComprasEncabezdo_ContactoProveedor]
GO
ALTER TABLE [dbo].[ContactoProveedor]  WITH CHECK ADD FOREIGN KEY([IdProv])
REFERENCES [dbo].[Proveedores] ([IdProv])
GO
ALTER TABLE [dbo].[FacturaDetalle]  WITH CHECK ADD  CONSTRAINT [FK__FacturaDe__IdFac__68487DD7] FOREIGN KEY([IdFac])
REFERENCES [dbo].[FacturaEncabezado] ([IdFac])
GO
ALTER TABLE [dbo].[FacturaDetalle] CHECK CONSTRAINT [FK__FacturaDe__IdFac__68487DD7]
GO
ALTER TABLE [dbo].[FacturaDetalle]  WITH CHECK ADD  CONSTRAINT [FK__FacturaDe__IdPro__6C190EBB] FOREIGN KEY([IdPro])
REFERENCES [dbo].[Productos] ([IdPro])
GO
ALTER TABLE [dbo].[FacturaDetalle] CHECK CONSTRAINT [FK__FacturaDe__IdPro__6C190EBB]
GO
ALTER TABLE [dbo].[FacturaDetalle]  WITH CHECK ADD  CONSTRAINT [FK__FacturaDe__IdTra__6FE99F9F] FOREIGN KEY([IdTra])
REFERENCES [dbo].[Tratamientos] ([IdTra])
GO
ALTER TABLE [dbo].[FacturaDetalle] CHECK CONSTRAINT [FK__FacturaDe__IdTra__6FE99F9F]
GO
ALTER TABLE [dbo].[FacturaEncabezado]  WITH CHECK ADD  CONSTRAINT [FK__FacturaEn__IdCit__73BA3083] FOREIGN KEY([IdCit])
REFERENCES [dbo].[Citas] ([IdCit])
GO
ALTER TABLE [dbo].[FacturaEncabezado] CHECK CONSTRAINT [FK__FacturaEn__IdCit__73BA3083]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK__Productos__IdMar__7C4F7684] FOREIGN KEY([IdMar])
REFERENCES [dbo].[Marcas] ([IdMar])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK__Productos__IdMar__7C4F7684]
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_Citas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_Citas]
@IdCit int,
@IdPac int,
@FecCit date,
@HorCit time,
@EstCit bit
AS 
BEGIN 
	UPDATE Citas SET IdPac=@IdPac,	FecCit=@FecCit, HorCit=@HorCit, EstCit=@EstCit 
	WHERE IdCit=@IdCit
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_ComprasDetalles]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_ComprasDetalles]
@IdComDet int,
@IdCom int,
@IdPro int,
@CantPro int,
@PrePro int
AS 
BEGIN 
	UPDATE ComprasDetalles SET IdCom=@IdCom, IdPro=@IdPro, CantPro=@CantPro, PrePro=@PrePro
	WHERE IdComDet=@IdComDet
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_ComprasEncabezado]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_ComprasEncabezado]
@IdCom int,
@NroFac nvarchar(15),
@FecCom date,
@IdConProv int
AS 
BEGIN 
	UPDATE ComprasEncabezdo SET NroFac=@NroFac, FecCom=@FecCom, IdConProv=@IdConProv
	WHERE IdCom=@IdCom
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_ContactoProveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_ContactoProveedores]
@IdConProv int,
@NombConProv nvarchar(50),
@NumConProv int,
@EmlConProv nvarchar(80),
@EstConProv bit,
@IdProv int
AS 
BEGIN
	UPDATE ContactoProveedor SET NombConProv=@NombConProv, NumConProv=@NumConProv, EmlConProv=@EmlConProv, EstConProv=@EstConProv, IdProv=@IdProv
	WHERE IdConProv=@IdConProv
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_FacturaDetalle]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_FacturaDetalle] 
@IdFacDet int,
@IdFac int, 
@IdTra int, 
@PrecTra int,
@IdPro int,
@CantPro int,
@PrecPro int 
AS
BEGIN
	UPDATE FacturaDetalle SET IdFac=@IdFac, IdTra=@IdTra, PrecTra=@PrecTra, IdPro=@IdPro, CantPro=@CantPro, PrecPro=@PrecPro
	WHERE IdFacDet=@IdFacDet
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_FacturaEncabezado]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_FacturaEncabezado]
@IdFac int,
@FecFac date,
@HorFac time,
@IdCit int,
@NomUsr nvarchar(30)
AS 
BEGIN 
	UPDATE FacturaEncabezado SET FecFac=@FecFac, HorFac=@HorFac, IdCit=@IdCit, NomUsr=@NomUsr
	WHERE IdFac=@IdFac
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_Marcas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_Marcas]
@IdMar int,
@NomMar nvarchar(30)
AS 
BEGIN 
	UPDATE Marcas SET  NomMar=@NomMar
	WHERE IdMar=@IdMar
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_Pacientes]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_Pacientes]
@IdPac INT,
@NomPac nvarchar(40),
@ApePac nvarchar(40),
@GenPac nvarchar(20),
@FecNac date,
@DirPac nvarchar(100),
@TelPac int,
@EmlPac nvarchar(80)
AS
BEGIN 
	UPDATE Pacientes SET NomPac=@NomPac, ApePac=@ApePac, GenPac=@GenPac, FecNac=@FecNac, DirPac=@DirPac, TelPac=@TelPac, EmlPac=@EmlPac
	WHERE IdPac=@IdPac
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_Productos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_Productos]
@IdPro int,
@NomPro nvarchar(50),
@DesPro nvarchar(100),
@FecVen date,
@PrePro int, 
@StockPro int,
@IdMar int
AS 
BEGIN 
	UPDATE Productos SET  NomPro=@NomPro, DesPro=@DesPro, FecVen=@FecVen, PrePro=@PrePro, StockPro=@StockPro, IdMar=@IdMar
	WHERE IdPro=@IdPro
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_Proveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_Proveedores]
@IdProv int,
@NomProv nvarchar(30),
@NumProv int,
@DirProv nvarchar(100),
@EmlProv nvarchar(80),
@RTNProv nvarchar(15),
@EstProv bit
AS 
BEGIN 
	UPDATE Proveedores SET NomProv=@NomProv, NumProv=@NumProv, DirProv=@DirProv, EmlProv=@EmlProv, RTNProv=@RTNProv, EstProv=@EstProv
	WHERE IdProv=@IdProv	
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_Tratamientos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_Tratamientos] 
@IdTra int,
@DesTra nvarchar(100),
@CosTra int
AS 
BEGIN 
	UPDATE Tratamientos SET DesTra=@DesTra,	CosTra=@CosTra
	WHERE IdTra=@IdTra
END
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_Usuarios]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Actualizar_Usuarios]
@NomUsr nvarchar(30),
@ConUsr nvarchar(70),
@EstUsr bit,
@RolUsr nvarchar(30)
AS 
BEGIN
	UPDATE Usuarios SET ConUsr=@ConUsr,	EstUsr=@EstUsr, RolUsr=@RolUsr
	WHERE NomUsr=@NomUsr
END
GO
/****** Object:  StoredProcedure [dbo].[AumentarStockProducto]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AumentarStockProducto] 
@IdPro int, 
@Cant int
AS
BEGIN 
	UPDATE Productos
	SET StockPro = StockPro + @Cant
	WHERE IdPro = @IdPro

	UPDATE Productos
	SET StockPro = 0
	WHERE IdPro = @IdPro AND StockPro < 0
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarCitasPorNombrePaciente]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarCitasPorNombrePaciente]
    @NomPac NVARCHAR(40)
AS
BEGIN
    SELECT C.*
    FROM Citas C
    INNER JOIN Pacientes P ON C.IdPac = P.IdPac
    WHERE P.NomPac LIKE '%' + @NomPac + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[Desactivar_Citas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Desactivar_Citas]
@IdCit int,
@IdPac int,
@FecCit date,
@HorCit time,
@EstCit bit
AS 
BEGIN 
	UPDATE Citas SET IdPac=@IdPac,	FecCit=@FecCit, HorCit=@HorCit, EstCit=@EstCit 
	WHERE IdCit=@IdCit
END
GO
/****** Object:  StoredProcedure [dbo].[Desactivar_ContactoProveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Desactivar_ContactoProveedores]
@IdConProv int,
@NombConProv nvarchar(50),
@NumConProv int,
@EmlConProv nvarchar(80),
@EstConProv bit,
@IdProv int
AS 
BEGIN
	UPDATE ContactoProveedor SET NombConProv=@NombConProv, NumConProv=@NumConProv, EmlConProv=@EmlConProv, EstConProv=@EstConProv, IdProv=@IdProv
	WHERE IdConProv=@IdConProv
END
GO
/****** Object:  StoredProcedure [dbo].[Desactivar_Proveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Desactivar_Proveedores]
@IdProv int,
@NomProv nvarchar(30),
@NumProv int,
@DirProv nvarchar(100),
@EmlProv nvarchar(80),
@RTNProv nvarchar(15),
@EstProv bit
AS 
BEGIN 
	UPDATE Proveedores SET NomProv=@NomProv, NumProv=@NumProv, DirProv=@DirProv, EmlProv=@EmlProv, RTNProv=@RTNProv, EstProv=@EstProv
	WHERE IdProv=@IdProv	
END
GO
/****** Object:  StoredProcedure [dbo].[Desactivar_Usuarios]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Desactivar_Usuarios]
@NomUsr nvarchar(30),
@ConUsr nvarchar(70),
@EstUsr bit,
@RolUsr nvarchar(30)
AS 
BEGIN
	UPDATE Usuarios SET ConUsr=@ConUsr,	EstUsr=@EstUsr, RolUsr=@RolUsr
	WHERE NomUsr=@NomUsr
END
GO
/****** Object:  StoredProcedure [dbo].[DisminuirStockProducto]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DisminuirStockProducto] 
@IdPro int, 
@Cant int
AS
BEGIN 
	UPDATE Productos
	SET StockPro = StockPro - @Cant
	WHERE IdPro = @IdPro

	UPDATE Productos
	SET StockPro = 0
	WHERE IdPro = @IdPro AND StockPro < 0
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Citas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_Citas]
	@IdCit int
AS
BEGIN
	DELETE Citas 
	WHERE IdCit=@IdCit
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_ComprasDetalles]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_ComprasDetalles]
	@IdComDet INT
AS
BEGIN
	DELETE ComprasDetalles
	WHERE IdComDet=@IdComDet
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_ComprasEncabezado]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_ComprasEncabezado]
	@IdCom INT
AS
BEGIN
	DELETE ComprasEncabezdo
	WHERE IdCom=@IdCom
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_ContactoProveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_ContactoProveedores]
	@IdConProv INT
AS
BEGIN
	DELETE ContactoProveedor
	WHERE IdConProv=@IdConProv
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_FacturaEncabezado]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_FacturaEncabezado]
	@IdFac INT
AS
BEGIN
	DELETE FacturaEncabezado
	WHERE IdFac=@IdFac
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Marcas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_Marcas]
	@IdMar int
AS
BEGIN
	DELETE Marcas
	WHERE IdMar=@IdMar
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Pacientes]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_Pacientes]
	@IdPac INT 
AS
BEGIN 
	DELETE Pacientes
	WHERE IdPac=@IdPac
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_ProcedimientoRealizadoDetalle]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_ProcedimientoRealizadoDetalle]
	@IdProcDet int
AS
BEGIN
	DELETE ProcedimientosRealizadoDetalle 
	WHERE IdProcDet=@IdProcDet
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_ProcedimientoRealizadoEncabezado]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_ProcedimientoRealizadoEncabezado]
	@IdProc int
AS
BEGIN
	DELETE ProcedimientosRealizadosEncabezado 
	WHERE IdProc=@IdProc
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Productos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_Productos]
	@IdPro int
AS
BEGIN
	DELETE Productos
	WHERE IdPro=@IdPro 
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Proveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_Proveedores]
	@IdProv INT
AS
BEGIN
	DELETE Proveedores 
	WHERE IdProv=@IdProv
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Tratamientos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_Tratamientos]
	@IdTra int
AS
BEGIN
	DELETE Tratamientos 
	WHERE IdTra=@IdTra
END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Usuarios]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Eliminar_Usuarios]
	@NomUsr NVARCHAR (30)
AS
BEGIN
	DELETE Usuarios 
	WHERE NomUsr=@NomUsr
END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Bitacoras]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_Bitacoras]

@FecBit date,
@HrBit time(7),
@DecBit nvarchar(225),
@IdUsr nvarchar(30)
AS 
BEGIN 

	INSERT INTO Bitacora VALUES (@FecBit, @HrBit, @DecBit, @IdUsr )
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Citas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_Citas]
@IdCit int,
@IdPac int,
@FecCit date,
@HorCit time,
@EstCit bit
AS 
BEGIN 

	INSERT INTO Citas VALUES (@IdCit, @IdPac, @FecCit, @HorCit, @EstCit)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_ComprasDetalles]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_ComprasDetalles]
@IdComDet int,
@IdCom int,
@IdPro int,
@CantPro int,
@PrePro int
AS 
BEGIN 
	INSERT INTO ComprasDetalles VALUES (@IdComDet, @IdCom, @IdPro, @CantPro, @PrePro)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_ComprasEncabezado]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_ComprasEncabezado]
@IdCom int,
@NroFac nvarchar(15),
@FecCom date,
@IdConProv int
AS 
BEGIN 
	INSERT INTO ComprasEncabezdo VALUES (@IdCom, @NroFac, @FecCom, @IdConProv)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_ContactoProveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_ContactoProveedores]
@IdConProv int,
@NombConProv nvarchar(50),
@NumConProv int,
@EmlConProv nvarchar(80),
@EstConProv bit,
@IdProv int

AS 
BEGIN 
	INSERT INTO ContactoProveedor VALUES (@IdConProv, @NombConProv, @NumConProv, @EmlConProv, @EstConProv, @IdProv)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_FacturaDetalle]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_FacturaDetalle] 
@IdFacDet int,
@IdFac int, 
@IdTra int, 
@PrecTra int,
@IdPro int,
@CantPro int,
@PrecPro int 
AS
BEGIN
	INSERT INTO FacturaDetalle VALUES (@IdFacDet, @IdFac, @IdTra, @PrecTra, @IdPro, @CantPro, @PrecPro)
	END 
GO
/****** Object:  StoredProcedure [dbo].[Insertar_FacturaEncabezado]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_FacturaEncabezado]
@IdFac int,
@FecFac date,
@HorFac time,
@IdCit int,
@NomUsr nvarchar(30)
AS 
BEGIN 
	INSERT INTO FacturaEncabezado VALUES (@IdFac, @FecFac, @HorFac, @IdCit, @NomUsr)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Marcas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_Marcas]
@IdMar int,
@NomMar nvarchar(30)
AS 
BEGIN 

	INSERT INTO Marcas VALUES (@IdMar, @NomMar)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Pacientes]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_Pacientes] 
@IdPac INT,
@NomPac nvarchar(40),
@ApePac nvarchar(40),
@GenPac nvarchar(20),
@FecNac date,
@DirPac nvarchar(100),
@TelPac int,
@EmlPac nvarchar(80)
AS 
BEGIN 
	INSERT INTO Pacientes VALUES (@IdPac, @NomPac, @ApePac, @GenPac, @FecNac, @DirPac, @TelPac, @EmlPac)
	END 
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Productos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_Productos]
@IdPro int,
@NomPro nvarchar(50),
@DesPro nvarchar(100),
@FecVen date,
@PrePro int, 
@StockPro int,
@IdMar int
AS 
BEGIN 
	INSERT INTO Productos VALUES (@IdPro, @NomPro, @DesPro, @FecVen, @PrePro, @StockPro, @IdMar)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Proveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_Proveedores]
@IdProv int,
@NomProv nvarchar(30),
@NumProv int,
@DirProv nvarchar(100),
@EmlProv nvarchar(80),
@RTNProv nvarchar(15),
@EstProv bit
AS 
BEGIN 
	INSERT INTO Proveedores VALUES (@IdProv, @NomProv, @NumProv, @DirProv, @EmlProv, @RTNProv, @EstProv)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Tratamientos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_Tratamientos]
@IdTra int,
@DesTra nvarchar(100),
@CosTra int
AS 
BEGIN 
	INSERT INTO Tratamientos VALUES (@IdTra, @DesTra, @CosTra)
	END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Usuarios]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insertar_Usuarios]
@NomUsr nvarchar(30),
@ConUsr nvarchar(70),
@EstUsr bit,
@RolUsr nvarchar(30)
AS 
BEGIN 
	INSERT INTO Usuarios VALUES (@NomUsr, @ConUsr, @EstUsr, @RolUsr)
	END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEstadoCuenta]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerEstadoCuenta]
AS
BEGIN

    DECLARE @TotalFacturas DECIMAL(10, 2);
    DECLARE @TotalCompras DECIMAL(10, 2);
    DECLARE @SaldoActual DECIMAL(10, 2);

    
    SELECT @TotalFacturas = ISNULL(SUM(Total), 0) 
    FROM VistaEstadoCuenta
    WHERE Tipo = 'Factura';

    
    SELECT @TotalCompras = ISNULL(SUM(Total), 0) 
    FROM VistaEstadoCuenta
    WHERE Tipo = 'Compra';

    
    SET @SaldoActual = @TotalFacturas - @TotalCompras;

    
    WITH Totales AS (
        SELECT 
            @TotalFacturas AS TotalFacturas,
            @TotalCompras AS TotalCompras,
            @SaldoActual AS SaldoActual
    )

    
    SELECT 
        Tipo, 
        Fecha, 
        Descripcion, 
        Precio, 
        Cantidad, 
        Total,
        TotalFacturas,
        TotalCompras,
        SaldoActual
    FROM VistaEstadoCuenta
    CROSS JOIN Totales
    ORDER BY Fecha DESC;

END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerTop5ProductosMasVendidos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerTop5ProductosMasVendidos]
AS
BEGIN
    SELECT TOP 5 IdPro, 
             NomPro, 
             PrePro,
             TotalVentas,
             TotalVentaPorProducto,
             (SELECT SUM(TotalVentaPorProducto) FROM (
                 SELECT TOP 5 COUNT(*) * p.PrePro AS TotalVentaPorProducto
                 FROM FacturaDetalle fd 
                 INNER JOIN Productos p ON fd.IdPro = p.IdPro
                 GROUP BY fd.IdPro, p.NomPro, p.PrePro
                 ORDER BY COUNT(*) DESC
             ) AS Subquery) AS TotalVentasTotal
FROM (
    SELECT fd.IdPro, 
             p.NomPro, 
             p.PrePro,
             COUNT(*) AS TotalVentas,
             COUNT(*) * p.PrePro AS TotalVentaPorProducto
    FROM FacturaDetalle fd
    INNER JOIN Productos p ON fd.IdPro = p.IdPro
    GROUP BY fd.IdPro, p.NomPro, p.PrePro
) AS Subquery
ORDER BY TotalVentas DESC
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteObtenerComprasPorOpcion]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteObtenerComprasPorOpcion]
    @Opcion INT = NULL,       
    @FechaInicio DATE = NULL,
    @FechaFin DATE = NULL
AS
BEGIN
    DECLARE @FechaConsultaInicio DATE
    DECLARE @FechaConsultaFin DATE

    IF @Opcion = 1      -- Hoy
    BEGIN
        SET @FechaConsultaInicio = CAST(GETDATE() AS DATE)
        SET @FechaConsultaFin = @FechaConsultaInicio
    END
    ELSE IF @Opcion = 2 -- Ayer
    BEGIN
        SET @FechaConsultaInicio = CAST(DATEADD(DAY, -1, GETDATE()) AS DATE)
        SET @FechaConsultaFin = @FechaConsultaInicio
    END
    ELSE IF @Opcion = 3 -- Semana
    BEGIN
        SET @FechaConsultaInicio = CAST(DATEADD(DAY, -DATEDIFF(DAY, 0, GETDATE()) % 7, GETDATE()) AS DATE)
        SET @FechaConsultaFin = CAST(GETDATE() AS DATE)
    END
    ELSE IF @Opcion = 4 -- Mes
    BEGIN
        SET @FechaConsultaInicio = DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
        SET @FechaConsultaFin = DATEADD(DAY, -1, DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) + 1, 0))
    END
    ELSE IF @Opcion = 5 -- Año
    BEGIN
        SET @FechaConsultaInicio = DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0)
        SET @FechaConsultaFin = DATEADD(DAY, -1, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()) + 1, 0))
    END
    ELSE IF @Opcion = 6 -- Rango
    BEGIN
        SET @FechaConsultaInicio = @FechaInicio
        SET @FechaConsultaFin = @FechaFin
    END

    SELECT 
        C.IdCom,
        C.NroFac,
        C.FecCom,
        C.IdConProv,
        CP.NombConProv,
        CD.IdPro,
        P.NomPro,
        CD.CantPro,
        CD.PrePro
    FROM 
        ComprasEncabezdo C
    INNER JOIN 
        ContactoProveedor CP ON C.IdConProv = CP.IdConProv
    INNER JOIN 
	ComprasDetalles CD ON C.IdCom = CD.IdCom
	INNER JOIN
        Productos P ON CD.IdPrO = P.IdPro
    WHERE 
        (
            (@Opcion = 6 AND C.FecCom BETWEEN @FechaConsultaInicio AND @FechaConsultaFin)
            OR 
            CONVERT(DATE, C.FecCom) BETWEEN @FechaConsultaInicio AND @FechaConsultaFin
        )
    ORDER BY 
        C.FecCom DESC
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteObtenerDetallesCompra]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteObtenerDetallesCompra]
    @IdCom INT
AS
BEGIN
    SELECT 
        C.IdCom, 
        C.NroFac, 
        C.FecCom, 
        C.IdConProv, 
        CP.NombConProv, 
        FD.IdPro, 
        Pr.NomPro, 
        FD.CantPro, 
        FD.PrePro 
    FROM 
        ComprasEncabezdo C
    INNER JOIN 
        ContactoProveedor CP ON C.IdConProv = CP.IdConProv
    LEFT JOIN 
        ComprasDetalles FD ON C.IdCom = FD.IdCom
    LEFT JOIN 
        Productos Pr ON FD.IdPro = Pr.IdPro
    WHERE 
        C.IdCom = @IdCom
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteObtenerDetallesFactura]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteObtenerDetallesFactura]
    @IdFac INT
AS
BEGIN
    SELECT 
        FE.IdFac, 
        FE.FecFac, 
        CONVERT(VARCHAR(8), FE.HorFac, 108) AS HorFac, 
		C.IdCit,
        C.IdPac, 
        P.NomPac, 
        P.ApePac, 
        FE.NomUsr, 
        NULLIF(FD.IdTra, 0) AS IdTra, 
        NULLIF(ISNULL(T.DesTra, ''), '') AS DesTra, 
        NULLIF(T.CosTra, 0) AS CosTra, 
        NULLIF(FD.IdPro, 0) AS IdPro, 
        NULLIF(ISNULL(Pr.NomPro, ''), '') AS NomPro, 
        NULLIF(FD.CantPro, 0) AS CantPro, 
        NULLIF(FD.PrecPro, 0) AS PrecPro
    FROM 
        FacturaEncabezado FE
    INNER JOIN 
        Citas C ON FE.IdCit = C.IdCit
    INNER JOIN
        Pacientes P ON C.IdPac = P.IdPac
    LEFT JOIN 
        FacturaDetalle FD ON FE.IdFac = FD.IdFac
    LEFT JOIN 
        Tratamientos T ON FD.IdTra = T.IdTra
    LEFT JOIN 
        Productos Pr ON FD.IdPro = Pr.IdPro
    WHERE 
        FE.IdFac = @IdFac
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteObtenerFacturasPorOpcion]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteObtenerFacturasPorOpcion]
    @Opcion INT = NULL,       
    @FechaInicio DATE = NULL,
    @FechaFin DATE = NULL
AS
BEGIN
    DECLARE @FechaConsultaInicio DATE
    DECLARE @FechaConsultaFin DATE

    IF @Opcion = 1      -- Hoy
    BEGIN
        SET @FechaConsultaInicio = CAST(GETDATE() AS DATE)
        SET @FechaConsultaFin = @FechaConsultaInicio
    END
    ELSE IF @Opcion = 2 -- Ayer
    BEGIN
        SET @FechaConsultaInicio = CAST(DATEADD(DAY, -1, GETDATE()) AS DATE)
        SET @FechaConsultaFin = @FechaConsultaInicio
    END
    ELSE IF @Opcion = 3 -- Semana
    BEGIN
        SET @FechaConsultaInicio = CAST(DATEADD(DAY, -DATEDIFF(DAY, 0, GETDATE()) % 7, GETDATE()) AS DATE)
        SET @FechaConsultaFin = CAST(GETDATE() AS DATE)
    END
    ELSE IF @Opcion = 4 -- Mes
    BEGIN
        SET @FechaConsultaInicio = DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
        SET @FechaConsultaFin = DATEADD(DAY, -1, DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) + 1, 0))
    END
    ELSE IF @Opcion = 5 -- Año
    BEGIN
        SET @FechaConsultaInicio = DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0)
        SET @FechaConsultaFin = DATEADD(DAY, -1, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()) + 1, 0))
    END
    ELSE IF @Opcion = 6 -- Rango
    BEGIN
        SET @FechaConsultaInicio = @FechaInicio
        SET @FechaConsultaFin = @FechaFin
    END

    SELECT 
        FE.IdFac, 
        FE.FecFac, 
        CONVERT(VARCHAR(8), FE.HorFac, 108) AS HorFac, 
		C.IdCit,
        C.IdPac, 
        P.NomPac, 
        P.ApePac, 
        FE.NomUsr,
        NULLIF(FD.IdTra, 0) AS IdTra, 
        NULLIF(ISNULL(T.DesTra, ''), '') AS DesTra, 
        NULLIF(T.CosTra, 0) AS CosTra, 
        NULLIF(FD.IdPro, 0) AS IdPro, 
        NULLIF(ISNULL(Pr.NomPro, ''), '') AS NomPro, 
        NULLIF(FD.CantPro, 0) AS CantPro, 
        NULLIF(FD.PrecPro, 0) AS PrecPro
    FROM 
        FacturaEncabezado FE
    INNER JOIN 
        Citas C ON FE.IdCit = C.IdCit
    INNER JOIN
        Pacientes P ON C.IdPac = P.IdPac
    LEFT JOIN 
        FacturaDetalle FD ON FE.IdFac = FD.IdFac
    LEFT JOIN 
        Tratamientos T ON FD.IdTra = T.IdTra
    LEFT JOIN 
        Productos Pr ON FD.IdPro = Pr.IdPro
    WHERE 
        (
            (@Opcion = 6 AND FE.FecFac BETWEEN @FechaConsultaInicio AND @FechaConsultaFin)
            OR 
            CONVERT(DATE, FE.FecFac) BETWEEN @FechaConsultaInicio AND @FechaConsultaFin
        )
    ORDER BY 
        FE.FecFac DESC, FE.HorFac DESC
END


GO
/****** Object:  StoredProcedure [dbo].[ReporteObtenerProductosMenorStock]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteObtenerProductosMenorStock]
AS
BEGIN
    SELECT 
        P.IdPro,
        P.NomPro,
        P.DesPro,
        P.FecVen,
        P.PrePro,
        P.StockPro,
        M.IdMar,
        M.NomMar
    FROM 
        Productos P
    INNER JOIN 
        Marcas M ON P.IdMar = M.IdMar
    WHERE 
        P.StockPro <= 5
    ORDER BY 
        P.StockPro ASC, 
        P.NomPro ASC
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteObtenerProductosPorVencer]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteObtenerProductosPorVencer]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        P.IdPro,
        P.NomPro,
        P.DesPro,
        FORMAT(P.FecVen, 'dddd dd \de MMMM yyyy') AS FecVenFormat,
        P.PrePro,
        P.StockPro,
        M.IdMar,
        M.NomMar
    FROM 
        Productos P
    INNER JOIN 
        Marcas M ON P.IdMar = M.IdMar
    WHERE 
        P.FecVen BETWEEN GETDATE() AND DATEADD(DAY, 30, GETDATE())
    ORDER BY 
        P.FecVen;
        
    SET NOCOUNT OFF
END

GO
/****** Object:  StoredProcedure [dbo].[ReporteObtenerTop7PacientesConMasCitas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteObtenerTop7PacientesConMasCitas]
AS
BEGIN
    SELECT TOP 7
        P.IdPac,
        P.NomPac,
        P.ApePac,
        COUNT(DISTINCT FacturaEncabezado.IdFac) AS NumCitas
    FROM 
        FacturaEncabezado 
    INNER JOIN
        Citas C ON FacturaEncabezado.IdCit = C.IdCit
    INNER JOIN 
        Pacientes P ON C.IdPac = P.IdPac
    GROUP BY 
        P.IdPac,
        P.NomPac,
        P.ApePac
    ORDER BY 
        NumCitas DESC
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteTop5ProductosMenosVendidos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteTop5ProductosMenosVendidos]
AS
BEGIN
    WITH Bottom5Productos AS (
        SELECT TOP 5 
            FD.IdPro,
            T.NomPro,
            T.PrePro,
            COUNT(*) AS TotalVentas,
            SUM(FD.PrecPro) AS VentasPorPrecio
        FROM 
            FacturaDetalle FD
        JOIN 
            Productos T ON FD.IdPro = T.IdPro
        GROUP BY 
            FD.IdPro, T.NomPro, T.PrePro
        ORDER BY 
            TotalVentas ASC 
    )
    SELECT IdPro, NomPro, PrePro, TotalVentas, VentasPorPrecio
    FROM Bottom5Productos
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteTop5Tratamientos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteTop5Tratamientos]
AS
BEGIN
    WITH Top5Tratamientos AS (
        SELECT TOP 5 
            FD.IdTra,
            T.DesTra,
            T.CosTra,
            COUNT(*) AS TotalVentas,
            SUM(FD.PrecTra) AS VentasPorPrecio
        FROM 
            FacturaDetalle FD
        JOIN 
            Tratamientos T ON FD.IdTra = T.IdTra
        GROUP BY 
            FD.IdTra, T.DesTra, T.CosTra
        ORDER BY 
            TotalVentas DESC
    )

    SELECT IdTra, DesTra, CosTra, TotalVentas, VentasPorPrecio,
           (SELECT SUM(VentasPorPrecio) FROM Top5Tratamientos) AS SumaTotalVentasPorPrecio
    FROM Top5Tratamientos
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteTop5TratamientosMenosAplicados]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteTop5TratamientosMenosAplicados]
AS
BEGIN
    WITH Bottom5Tratamientos AS (
        SELECT TOP 5 
            FD.IdTra,
            T.DesTra,
            T.CosTra,
            COUNT(*) AS TotalVentas,
            SUM(FD.PrecTra) AS VentasPorPrecio
        FROM 
            FacturaDetalle FD
        JOIN 
            Tratamientos T ON FD.IdTra = T.IdTra
        GROUP BY 
            FD.IdTra, T.DesTra, T.CosTra
        ORDER BY 
            TotalVentas ASC 
    )

    SELECT IdTra, DesTra, CosTra, TotalVentas, VentasPorPrecio,
           (SELECT SUM(VentasPorPrecio) FROM Bottom5Tratamientos) AS SumaTotalVentasPorPrecio
    FROM Bottom5Tratamientos
END
GO
/****** Object:  StoredProcedure [dbo].[ReporteTopDiasCitasAtendidas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteTopDiasCitasAtendidas]
AS
BEGIN
    SELECT 
        DATENAME(dw, FecFac) AS Dia,
        COUNT(*) AS CitasAtendidas
    FROM 
        FacturaEncabezado
    GROUP BY 
        DATENAME(dw, FecFac)
    ORDER BY 
        COUNT(*) DESC
    OFFSET 0 ROWS FETCH NEXT 7 ROWS ONLY
END
GO
/****** Object:  StoredProcedure [dbo].[TopHorasConMasPacientesAtendidos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TopHorasConMasPacientesAtendidos]
AS
BEGIN
    SELECT 
        CASE 
            WHEN DATEPART(HOUR, HorFac) < 12 THEN 
                FORMAT(CONVERT(datetime, CONVERT(varchar, DATEPART(HOUR, HorFac)) + ':00'), 'hh:mm tt') + ' A.M'
            ELSE 
                FORMAT(CONVERT(datetime, CONVERT(varchar, DATEPART(HOUR, HorFac)) + ':00'), 'hh:mm tt') + ' P.M'
        END AS Hora,
        COUNT(*) AS PacientesAtendidos
    FROM 
        FacturaEncabezado
    GROUP BY 
        DATEPART(HOUR, HorFac)
    ORDER BY 
        COUNT(*) DESC
    OFFSET 0 ROWS FETCH NEXT 7 ROWS ONLY
END
GO
/****** Object:  StoredProcedure [dbo].[VisCita]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisCita] 
AS
SELECT c.IdCit, c.IdPac, p.NomPac, p.ApePac, c.FecCit, c.HorCit, c.EstCit 
FROM dbo.Citas c
INNER JOIN Pacientes p ON c.IdPac = p.IdPac
GO
/****** Object:  StoredProcedure [dbo].[VisContactoProveedor]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VisContactoProveedor]
AS
SELECT c.IdConProv, c.NombConProv, c.NumConProv, c.EmlConProv, c.EstConProv, c.IdProv, p.NomProv
FROM dbo.ContactoProveedor c
INNER JOIN Proveedores p ON c.IdProv = p.IdProv
GO
/****** Object:  StoredProcedure [dbo].[VisProducto]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VisProducto]
AS
SELECT p.IdPro, p.NomPro, p.DesPro, p.FecVen, p.PrePro, p.StockPro, p.IdMar, m.NomMar 
FROM dbo.Productos p
INNER JOIN Marcas m ON p.IdMar = m.IdMar
GO
/****** Object:  StoredProcedure [dbo].[VistaBitacoras]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaBitacoras]
AS
SELECT * FROM Bitacora
GO
/****** Object:  StoredProcedure [dbo].[VistaCitas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaCitas]
AS
SELECT * FROM Citas
GO
/****** Object:  StoredProcedure [dbo].[VistaCitas_PorNombrePaciente]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaCitas_PorNombrePaciente]
@nombrePaciente NVARCHAR(40)
AS
BEGIN
SELECT Citas.IdCit, Citas.IdPac, Citas.FecCit, Citas.HorCit, Citas.EstCit
                                FROM Citas
                                INNER JOIN Pacientes ON Citas.IdPac = Pacientes.IdPac
                                WHERE Pacientes.NomPac LIKE '%" + @nombrePaciente + "%'
								END
GO
/****** Object:  StoredProcedure [dbo].[VistaCompra]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaCompra]
AS
BEGIN
    SELECT 
        ComprasEncabezdo.IdCom,
        ComprasEncabezdo.NroFac,
        ComprasEncabezdo.FecCom,
        ComprasEncabezdo.IdConProv,
        ComprasDetalles.IdComDet,
        ComprasDetalles.IdPro,
        ComprasDetalles.CantPro,
        ComprasDetalles.PrePro
    FROM 
        ComprasEncabezdo
    JOIN 
        ComprasDetalles ON ComprasEncabezdo.IdCom = ComprasDetalles.IdCom
END
GO
/****** Object:  StoredProcedure [dbo].[VistaContactoProveedor]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaContactoProveedor]
AS
SELECT * FROM ContactoProveedor
GO
/****** Object:  StoredProcedure [dbo].[VistaFactura]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaFactura]
AS
BEGIN
    SELECT 
        FacturaEncabezado.IdFac,
        FacturaEncabezado.FecFac,
        FacturaEncabezado.HorFac,
        FacturaEncabezado.IdCit,
        FacturaEncabezado.NomUsr,
        FacturaDetalle.IdFacDet,
        FacturaDetalle.IdPro,
        FacturaDetalle.IdTra,
        FacturaDetalle.PrecPro,
        FacturaDetalle.PrecTra
    FROM 
        FacturaEncabezado 
    JOIN 
        FacturaDetalle ON FacturaEncabezado.IdFac = FacturaDetalle.IdFac
END
GO
/****** Object:  StoredProcedure [dbo].[VistaMarcas]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaMarcas]
AS
SELECT * FROM Marcas
GO
/****** Object:  StoredProcedure [dbo].[VistaPacientes]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaPacientes] 
AS 
SELECT * FROM Pacientes
GO
/****** Object:  StoredProcedure [dbo].[VistaProductos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaProductos]
AS 
SELECT * FROM Productos
GO
/****** Object:  StoredProcedure [dbo].[VistaProveedores]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaProveedores]
AS 
SELECT * FROM Proveedores
GO
/****** Object:  StoredProcedure [dbo].[VistaTratamientos]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaTratamientos]
AS
SELECT * FROM Tratamientos
GO
/****** Object:  StoredProcedure [dbo].[VistaUsuario]    Script Date: 17/04/2024 21:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VistaUsuario]
AS
SELECT * FROM Usuarios
GO
USE [master]
GO
ALTER DATABASE [CioDental1] SET  READ_WRITE 
GO
