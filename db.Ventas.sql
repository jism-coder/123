USE [Ventas]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 12/02/2022 12:54:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[PK_Productos] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](500) NULL,
	[Estatus] [nvarchar](500) NULL,
	[Precio] [nvarchar](500) NULL,
	[Cantidad] [nvarchar](500) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[PK_Productos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Totales]    Script Date: 12/02/2022 12:54:58 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Totales](
	[PK_Totales] [int] IDENTITY(1,1) NOT NULL,
	[PK_Usuarios] [int] NULL,
	[PK_Ventas] [int] NULL,
	[PK_Producto] [int] NULL,
 CONSTRAINT [PK_Totales] PRIMARY KEY CLUSTERED 
(
	[PK_Totales] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/02/2022 12:54:58 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[PK_Usuarios] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido_Paterno] [nvarchar](50) NULL,
	[Apellido_Materno] [nvarchar](50) NULL,
	[Direccion] [nvarchar](200) NULL,
	[Telefono] [numeric](18, 0) NULL,
	[RFC] [nvarchar](11) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[PK_Usuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 12/02/2022 12:54:58 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[PK_Ventas] [int] IDENTITY(1,1) NOT NULL,
	[FormaPago] [nvarchar](200) NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[PK_Ventas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
