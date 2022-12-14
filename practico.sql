USE [practico]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 12-09-2022 21:54:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[codigo] [int] NOT NULL,
	[nombre] [varchar](150) NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[direcciones]    Script Date: 12-09-2022 21:54:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[direcciones](
	[codigo] [int] NOT NULL,
	[calle] [varchar](250) NULL,
	[region] [varchar](150) NULL,
	[numero] [int] NULL,
	[ciudad] [varchar](150) NULL,
	[rut_proveedor] [varchar](15) NULL,
 CONSTRAINT [PK_direcciones] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[producto_proveedor]    Script Date: 12-09-2022 21:54:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producto_proveedor](
	[codigo_producto] [int] NOT NULL,
	[rut_proveedor] [varchar](15) NOT NULL,
 CONSTRAINT [PK_producto_proveedor] PRIMARY KEY CLUSTERED 
(
	[codigo_producto] ASC,
	[rut_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[productos]    Script Date: 12-09-2022 21:54:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productos](
	[codigo] [int] NOT NULL,
	[nombre] [varchar](250) NULL,
	[descripcion] [varchar](550) NULL,
	[precio] [int] NULL,
	[codigo_categoria] [int] NULL,
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 12-09-2022 21:54:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedor](
	[rut] [varchar](15) NOT NULL,
	[razonsocial] [varchar](250) NULL,
	[giro] [int] NULL,
	[telefono] [varchar](20) NULL,
	[mail] [varchar](250) NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vendedores]    Script Date: 12-09-2022 21:54:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vendedores](
	[codigo] [int] NOT NULL,
	[nombre] [varchar](250) NULL,
	[apellido] [varchar](250) NULL,
	[mail] [varchar](250) NULL,
	[telefono] [varchar](20) NULL,
	[rut_proveedor] [varchar](15) NULL,
 CONSTRAINT [PK_vendedores] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[direcciones]  WITH CHECK ADD  CONSTRAINT [FK_direcciones_proveedor] FOREIGN KEY([rut_proveedor])
REFERENCES [dbo].[proveedor] ([rut])
GO
ALTER TABLE [dbo].[direcciones] CHECK CONSTRAINT [FK_direcciones_proveedor]
GO
ALTER TABLE [dbo].[producto_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_producto_proveedor_productos] FOREIGN KEY([codigo_producto])
REFERENCES [dbo].[productos] ([codigo])
GO
ALTER TABLE [dbo].[producto_proveedor] CHECK CONSTRAINT [FK_producto_proveedor_productos]
GO
ALTER TABLE [dbo].[producto_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_producto_proveedor_proveedor] FOREIGN KEY([rut_proveedor])
REFERENCES [dbo].[proveedor] ([rut])
GO
ALTER TABLE [dbo].[producto_proveedor] CHECK CONSTRAINT [FK_producto_proveedor_proveedor]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_productos_categoria] FOREIGN KEY([codigo_categoria])
REFERENCES [dbo].[categoria] ([codigo])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_productos_categoria]
GO
ALTER TABLE [dbo].[vendedores]  WITH CHECK ADD  CONSTRAINT [FK_vendedores_proveedor] FOREIGN KEY([rut_proveedor])
REFERENCES [dbo].[proveedor] ([rut])
GO
ALTER TABLE [dbo].[vendedores] CHECK CONSTRAINT [FK_vendedores_proveedor]
GO
