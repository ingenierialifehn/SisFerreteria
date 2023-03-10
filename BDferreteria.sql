USE [master]
GO
/****** Object:  Database [BDferreteria]    Script Date: 10/03/2023 01:46:08 p. m. ******/
CREATE DATABASE [BDferreteria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDferreteria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDferreteria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDferreteria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDferreteria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BDferreteria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDferreteria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDferreteria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDferreteria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDferreteria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDferreteria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDferreteria] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDferreteria] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BDferreteria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDferreteria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDferreteria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDferreteria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDferreteria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDferreteria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDferreteria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDferreteria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDferreteria] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDferreteria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDferreteria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDferreteria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDferreteria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDferreteria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDferreteria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDferreteria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDferreteria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDferreteria] SET  MULTI_USER 
GO
ALTER DATABASE [BDferreteria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDferreteria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDferreteria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDferreteria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDferreteria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDferreteria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BDferreteria] SET QUERY_STORE = OFF
GO
USE [BDferreteria]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 10/03/2023 01:46:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[codigo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cliente] [varchar](50) NULL,
	[correo_cliente] [varchar](50) NULL,
	[telefono_cliente] [varchar](8) NULL,
	[identidad_cliente] [varchar](50) NULL,
	[rtn_cliente] [varchar](50) NULL,
	[libre_impuesto_cliente] [bit] NULL,
	[estado_cliente] [bit] NULL,
 CONSTRAINT [PK__cliente__4D182E8D4BB7F1EE] PRIMARY KEY CLUSTERED 
(
	[codigo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[correlativo]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[correlativo](
	[codigo_correlativo] [int] IDENTITY(1,1) NOT NULL,
	[numero_correlativo_inicial] [varchar](50) NULL,
	[numero_correlativo_final] [varchar](50) NULL,
	[comentario_correlativo] [varchar](200) NULL,
	[estado_correlativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_correlativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_factura]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_factura](
	[codigo_detalle_factura] [int] IDENTITY(1,1) NOT NULL,
	[codigo_factura_detalle_factura] [int] NULL,
	[cantidad_detalle_factura] [int] NULL,
	[codigo_producto_detalle_factura] [int] NULL,
	[descripcion_produto__detalle_factura] [varchar](200) NULL,
	[precio_unitario_factura_detalle_factura] [decimal](18, 0) NULL,
	[ventas_exentas_factura_detalle_factura] [decimal](18, 0) NULL,
	[ventas_exonerada_factura_detalle_factura] [decimal](18, 0) NULL,
	[ventas_afectas_factura_detalle_factura] [decimal](18, 0) NULL,
	[sub_total_ventas_exentas_factura_detalle_factura] [decimal](18, 0) NULL,
	[sub_total_ventas_exonerada_factura_detalle_factura] [decimal](18, 0) NULL,
	[sub_total_ventas_afectas_factura_detalle_factura] [decimal](18, 0) NULL,
	[descuentos_sub_total_ventas_factura_detalle_factura] [decimal](18, 0) NULL,
	[total_ventas_afectas_factura_detalle_factura] [decimal](18, 0) NULL,
	[isv_ventas_afectas_factura_detalle_factura] [decimal](18, 0) NULL,
	[total_ventas_factura_detalle_factura] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_detalle_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[codigo_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empleado] [varchar](50) NULL,
	[correo_empleado] [varchar](50) NULL,
	[telefono_empleado] [int] NULL,
	[sexo_empleado] [int] NULL,
	[tipo_empleado] [int] NULL,
	[estado_empleado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[codigo_factura] [int] IDENTITY(1,1) NOT NULL,
	[codigo_correlativo_factura] [int] NULL,
	[codigo_cliente_factura] [int] NULL,
	[codigo_sucursal_factura] [int] NULL,
	[fecha_factura] [date] NULL,
	[direccion_factura] [varchar](200) NULL,
	[docIdentidad] [varchar](50) NULL,
	[telefono_factura] [varchar](50) NULL,
	[rtn_factura] [varchar](15) NULL,
	[asesor_venta_factura] [int] NULL,
	[condicion_pago_factura] [varchar](20) NULL,
	[total_venta_letras_factura] [varchar](500) NULL,
	[codigo_transportista_factura] [int] NULL,
 CONSTRAINT [PK__factura__E6BAED2C84C4A4C3] PRIMARY KEY CLUSTERED 
(
	[codigo_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[codigo_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NULL,
	[nombre_producto] [varchar](50) NULL,
	[unidad_medida_producto] [int] NULL,
	[cantidad_producto] [int] NULL,
	[isv_003_producto] [decimal](18, 0) NULL,
	[isv_005_producto] [decimal](18, 0) NULL,
	[estado_producto] [bit] NULL,
	[precio_producto] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sexo]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sexo](
	[codigo_sexo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_sexo] [varchar](50) NULL,
	[estado_sexo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_sexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sucursales]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sucursales](
	[codigo_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[nombre_sucursal] [varchar](50) NULL,
	[direccion_sucursal] [varchar](50) NULL,
	[estado_sucursal] [bit] NULL,
 CONSTRAINT [PK__sucursal__2F19A22C4D06EA9A] PRIMARY KEY CLUSTERED 
(
	[codigo_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_empleado]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_empleado](
	[codigo_Tipo_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_Tipo_Empleado] [varchar](50) NULL,
	[estado_Tipo_Empleado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_Tipo_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transportista]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transportista](
	[codigo_transportista] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empresa_transportista] [varchar](50) NULL,
	[telefono_empresa_transportista] [int] NULL,
	[correo_empresa_transportista] [varchar](50) NULL,
	[nombre_transportista] [varchar](50) NULL,
	[telefono_transportista] [int] NULL,
	[estado_transportista] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_transportista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unidad_medida]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unidad_medida](
	[codigo_unidad_medida] [int] IDENTITY(1,1) NOT NULL,
	[nombre_unidad_medida] [varchar](50) NULL,
	[descripcion_unidad_medida] [varchar](100) NULL,
	[estado_unidad_medida] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_unidad_medida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 10/03/2023 01:46:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[codigo_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](15) NULL,
	[contrasena_usuario] [varchar](100) NULL,
	[codigo_empleado_usuario] [int] NULL,
	[estado_usuario] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [FK__detalle_f__codig__5441852A] FOREIGN KEY([codigo_factura_detalle_factura])
REFERENCES [dbo].[factura] ([codigo_factura])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [FK__detalle_f__codig__5441852A]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD FOREIGN KEY([codigo_producto_detalle_factura])
REFERENCES [dbo].[productos] ([codigo_producto])
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([sexo_empleado])
REFERENCES [dbo].[sexo] ([codigo_sexo])
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([tipo_empleado])
REFERENCES [dbo].[tipo_empleado] ([codigo_Tipo_Empleado])
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK__factura__asesor___4E88ABD4] FOREIGN KEY([asesor_venta_factura])
REFERENCES [dbo].[empleado] ([codigo_empleado])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK__factura__asesor___4E88ABD4]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK__factura__codigo___4D94879B] FOREIGN KEY([codigo_cliente_factura])
REFERENCES [dbo].[cliente] ([codigo_cliente])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK__factura__codigo___4D94879B]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK__factura__codigo___4F7CD00D] FOREIGN KEY([codigo_transportista_factura])
REFERENCES [dbo].[transportista] ([codigo_transportista])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK__factura__codigo___4F7CD00D]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK__factura__codigo___5070F446] FOREIGN KEY([codigo_correlativo_factura])
REFERENCES [dbo].[correlativo] ([codigo_correlativo])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK__factura__codigo___5070F446]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK__factura__codigo___5165187F] FOREIGN KEY([codigo_sucursal_factura])
REFERENCES [dbo].[sucursales] ([codigo_sucursal])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK__factura__codigo___5165187F]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD FOREIGN KEY([unidad_medida_producto])
REFERENCES [dbo].[unidad_medida] ([codigo_unidad_medida])
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD FOREIGN KEY([codigo_empleado_usuario])
REFERENCES [dbo].[empleado] ([codigo_empleado])
GO
USE [master]
GO
ALTER DATABASE [BDferreteria] SET  READ_WRITE 
GO
