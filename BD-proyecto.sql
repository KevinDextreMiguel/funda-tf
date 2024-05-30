USE [TF]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 2/12/2023 11:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Numero_telefono] [varchar](100) NOT NULL,
	[Correo_electronico] [varchar](100) NOT NULL,
	[Contrasenia] [varchar](50) NOT NULL,
	[Distrito] [varchar](100) NOT NULL,
 CONSTRAINT [Cliente_pk] PRIMARY KEY CLUSTERED 
(
	[ID_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Pedido]    Script Date: 2/12/2023 11:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Pedido](
	[ID_de_pedido] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Total] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 2/12/2023 11:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[ID_del_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Telefono] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Contrasenia] [varchar](50) NOT NULL,
 CONSTRAINT [Empleado_pk] PRIMARY KEY CLUSTERED 
(
	[ID_del_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagoEmpleado]    Script Date: 2/12/2023 11:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagoEmpleado](
	[ID_Empleado] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[PagoHora] [float] NOT NULL,
	[CantHora] [int] NOT NULL,
	[TipoPago] [varchar](50) NOT NULL,
	[Total] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 2/12/2023 11:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[ID_de_pedido] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_de_pedido] [date] NOT NULL,
	[Estado_pedido] [varchar](100) NOT NULL,
	[Cliente_ID_cliente] [int] NOT NULL,
	[Empleado_ID_del_Empleado] [int] NULL,
	[Total] [float] NOT NULL,
 CONSTRAINT [Pedido_pk] PRIMARY KEY CLUSTERED 
(
	[ID_de_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 2/12/2023 11:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_producto] [varchar](100) NOT NULL,
	[Precio_producto] [float] NOT NULL,
	[Descripcion_producto] [varchar](200) NOT NULL,
	[Categorias_Productos_ID_Categoria] [int] NOT NULL,
 CONSTRAINT [Producto_pk] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoxProveedor]    Script Date: 2/12/2023 11:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoxProveedor](
	[ID_del_Pedido_a_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_pedido] [date] NOT NULL,
	[Fecha_entrega] [date] NOT NULL,
	[Proveedor_ID_Proovedor] [int] NOT NULL,
	[Producto_ID_Producto] [int] NOT NULL,
 CONSTRAINT [ProductoxProveedor_pk] PRIMARY KEY CLUSTERED 
(
	[ID_del_Pedido_a_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 2/12/2023 11:32:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID_Proovedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_proveedor] [varchar](100) NOT NULL,
	[Direccion_proveedor] [varchar](100) NOT NULL,
	[Numero_telefono_proveedor] [varchar](100) NOT NULL,
	[Correo_electronico_proveedor] [varchar](100) NOT NULL,
 CONSTRAINT [Proveedor_pk] PRIMARY KEY CLUSTERED 
(
	[ID_Proovedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (10, N'Kevin', N'Dextre', 23, N'987654321', N'kevin@gmail.com', N'1234', N'Los Olivos')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (15, N'Juan', N'Pérez', 18, N'987654321', N'Juan@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (16, N'María', N'García', 19, N'987654321', N'María@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (17, N'Carlos', N'Rodríguez', 20, N'987654321', N'Carlos@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (18, N'Ana', N'López', 21, N'987654321', N'Ana@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (19, N'Pedro', N'González', 22, N'987654321', N'Pedro@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (20, N'Laura', N'Martínez', 23, N'987654321', N'Laura@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (21, N'Luis', N'Sánchez', 24, N'987654321', N'Luis@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (22, N'Carmen', N'Ramírez', 25, N'987654321', N'Carme@gmail.comn', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (23, N'Jorge', N'Gómez', 26, N'987654321', N'Jorge@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (24, N'Raquel', N'Torres', 27, N'987654321', N'Raquel@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (25, N'Sergio', N'Vargas', 28, N'987654321', N'Sergio@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (26, N'Patricia', N'Jiménez', 29, N'987654321', N'Patricia@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (27, N'Miguel', N'Castro', 30, N'987654321', N'Miguel@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (28, N'Isabel', N'Morales', 31, N'987654321', N'Isabel@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (29, N'Alejandro', N'Silva', 32, N'987654321', N'Alejandro@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (30, N'Marta', N'Ortega', 33, N'987654321', N'Marta@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (31, N'Daniel', N'Méndez', 34, N'987654321', N'Daniel@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (32, N'Carolina', N'Aguilar', 35, N'987654321', N'Carolina@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (33, N'Pablo', N'Delgado', 36, N'987654321', N'Pablo@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (34, N'Sofía', N'Paredes', 37, N'987654321', N'Sofía@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (35, N'Oscar', N'Ríos', 38, N'987654321', N'Oscar@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (36, N'Gabriela', N'Mendoza', 39, N'987654321', N'Gabriela@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (37, N'Eduardo', N'Castro', 40, N'987654321', N'Eduardo@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (38, N'Andrea', N'Navarro', 41, N'987654321', N'Andrea@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (39, N'Fernando', N'Velasco', 42, N'987654321', N'Fernando@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (40, N'Paula', N'Rivas', 43, N'987654321', N'Paula@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (41, N'Alejandro', N'Peña', 44, N'987654321', N'Alejandro@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (42, N'Daniela', N'Cordero', 45, N'987654321', N'Daniela@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (43, N'Manuel', N'Contreras', 46, N'987654321', N'Manuel@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (44, N'Teresa', N'Ponce', 47, N'987654321', N'Teresa@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (45, N'Raúl', N'Morales', 48, N'987654321', N'Raúl@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (46, N'Beatriz', N'Santos', 49, N'987654321', N'Beatriz@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (47, N'Mario', N'Juárez', 50, N'987654321', N'Mario@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (48, N'Rosario', N'Núñez', 51, N'987654321', N'Rosario@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (49, N'José', N'León', 52, N'987654321', N'José@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (50, N'Ana María', N'Cervantes', 53, N'987654321', N'AnaMaria@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (51, N'Luis', N'Rangel', 54, N'987654321', N'Luis@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (52, N'Laura', N'Soto', 55, N'987654321', N'Laura@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (53, N'Carlos', N'Hernández', 56, N'987654321', N'Carlos@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (54, N'Patricia', N'Cárdenas', 57, N'987654321', N'Patricia@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (55, N'Javier', N'Ibarra', 58, N'987654321', N'Javier@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (56, N'Fernanda', N'Delgado', 59, N'987654321', N'Fernanda@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (57, N'Eduardo', N'Sánchez', 60, N'987654321', N'Eduardo@gmail.com', N'1234', N'Puente Piedra')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (58, N'Mariana', N'Miranda', 61, N'987654321', N'Mariana@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (59, N'Alejandro', N'Guzmán', 62, N'987654321', N'Alejandro@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (60, N'Alejandra', N'Valencia', 23, N'987654321', N'Alejandra@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (61, N'Miguel', N'Franco', 24, N'987654321', N'Miguel@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (62, N'Gabriela', N'Vargas', 25, N'987654321', N'Gabriela@gmail.com', N'1234', N'Huachipa')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (63, N'Manuel', N'Villarreal', 27, N'987654321', N'Manuel@gmail.com', N'1234', N'Pueblo Libre')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (64, N'Valeria', N'Cordero', 62, N'987654321', N'Valeria@gmail.com', N'1234', N'Breña')
INSERT [dbo].[Cliente] ([ID_cliente], [Nombre], [Apellido], [Edad], [Numero_telefono], [Correo_electronico], [Contrasenia], [Distrito]) VALUES (65, N'a', N'a', 2, N'aa', N'a', N'a', N'a')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (1, 3, 4, 81.61)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (2, 4, 2, 24.7)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (3, 5, 3, 56.91)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (4, 6, 3, 56.91)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (5, 3, 4, 81.61)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (8, 4, 4, 81.61)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (10, 5, 3, 56.91)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (11, 6, 1, 13.75)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (12, 3, 2, 21.25)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (13, 4, 2, 30.87)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (14, 5, 1, 12.5)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (15, 6, 2, 23.75)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (16, 3, 1, 17.5)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (17, 4, 2, 35)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (18, 5, 3, 35)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (19, 6, 1, 15)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (20, 3, 1, 17.5)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (21, 4, 1, 18.75)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (22, 5, 1, 18.75)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (23, 6, 1, 13.75)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (24, 3, 2, 21.25)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (25, 4, 1, 13.75)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (26, 5, 2, 26.25)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (27, 6, 2, 31.25)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (28, 3, 1, 15)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (29, 4, 2, 21.25)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (30, 5, 3, 32.5)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (31, 6, 2, 26.25)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (32, 3, 1, 17.5)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (33, 4, 1, 15)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (34, 5, 2, 28.75)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (35, 6, 2, 27.5)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (36, 3, 1, 15)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (37, 4, 1, 13.75)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (38, 5, 3, 32.5)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (39, 6, 3, 35)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (41, 6, 1, 15)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (42, 6, 1, 13.75)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (43, 4, 3, 32.5)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (44, 4, 3, 35)
INSERT [dbo].[Detalle_Pedido] ([ID_de_pedido], [ID_Producto], [Cantidad], [Total]) VALUES (45, 6, 2, 27.5)
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (12, N'Ana Karen', N'Cordero', N'987654321', N'AnaKaren@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (13, N'Francisco', N'Ibarra', N'987654321', N'Francisco@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (14, N'Carolina', N'Delgado', N'987654321', N'Carolina@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (15, N'Luis', N'Mendoza', N'987654321', N'Luis@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (16, N'Daniela', N'Navarro', N'987654321', N'Daniela@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (17, N'Juan', N'Velasco', N'987654321', N'Juan@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (18, N'Valentina', N'Rivas', N'987654321', N'Valentina@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (19, N'Eduardo', N'Peña', N'987654321', N'Eduardo@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (20, N'Mariana', N'Cordero', N'987654321', N'Mariana@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (21, N'Alejandro', N'Contreras', N'987654321', N'Alejandro@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (22, N'Renata', N'Ponce', N'987654321', N'Renata@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (23, N'Raúl', N'Morales', N'987654321', N'Raul@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (24, N'Jimena', N'Santos', N'987654321', N'Jimena@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (25, N'Mario', N'Juárez', N'987654321', N'Mario@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (26, N'Gabriela', N'Núñez', N'987654321', N'Gabriela@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (27, N'José', N'León', N'987654321', N'Jose@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (28, N'Ana Paula', N'Cervantes', N'987654321', N'AnaPaula@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (29, N'Luis', N'Rangel', N'987654321', N'Luis@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (30, N'Laura', N'Soto', N'987654321', N'Laura@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (31, N'Carlos', N'Hernández', N'987654321', N'Carlos@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (32, N'Patricia', N'Cárdenas', N'987654321', N'Patricia@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (33, N'Javier', N'Ibarra', N'987654321', N'Javier@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (34, N'Fernanda', N'Delgado', N'987654321', N'Fernanda@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (35, N'Eduardo', N'Sánchez', N'987654321', N'Eduardo@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (36, N'Mariana', N'Miranda', N'987654321', N'Mariana@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (37, N'Alejandro', N'Guzmán', N'987654321', N'Alejandro@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (38, N'Alejandra', N'Valencia', N'987654321', N'Alejandra@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (39, N'Miguel', N'Franco', N'987654321', N'Miguel@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (40, N'Gabriela', N'Vargas', N'987654321', N'Gabriela@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (41, N'Manuel', N'Villarreal', N'987654321', N'Manuel@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (42, N'Valeria', N'Cordero', N'987654321', N'Valeria@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (43, N'Pablo', N'Gómez', N'987654321', N'Pablo@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (44, N'Fernanda', N'Castillo', N'987654321', N'Fernanda@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (45, N'Juan Carlos', N'Huerta', N'987654321', N'Juan Carlos@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (46, N'Sofía', N'Díaz', N'987654321', N'Sofia@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (47, N'Antonio', N'Guerra', N'987654321', N'Antonio@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (48, N'Andrea', N'Silva', N'987654321', N'Andrea@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (49, N'José Luis', N'Cervantes', N'987654321', N'JoseLuis@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (50, N'María', N'Ríos', N'987654321', N'Maria@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (51, N'Javier', N'Peña', N'987654321', N'Javier@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (52, N'Ana Karen', N'Cordero', N'987654321', N'AnaKaren@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (53, N'Francisco', N'Ibarra', N'987654321', N'Francisco@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (54, N'Carolina', N'Delgado', N'987654321', N'Carolina@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (55, N'Luis', N'Mendoza', N'987654321', N'Luis@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (56, N'Daniela', N'Navarro', N'987654321', N'Daniela@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (57, N'Juan', N'Velasco', N'987654321', N'Juan@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (58, N'Valentina', N'Rivas', N'987654321', N'Valentina@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (59, N'Eduardo', N'Peña', N'987654321', N'Eduardo@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (60, N'Mariana', N'Cordero', N'987654321', N'Mariana@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (61, N'Alejandro', N'Contrera', N'987654321', N'Alejandro@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (62, N'Renata', N'Ponce', N'987654321', N'Renata@gmail.com', N'1234')
INSERT [dbo].[Empleado] ([ID_del_Empleado], [Nombre], [Apellido], [Telefono], [Email], [Contrasenia]) VALUES (65, N'Kevin', N'Dextre', N'987654321', N'kevin@gmail.com', N'1234')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
INSERT [dbo].[PagoEmpleado] ([ID_Empleado], [fecha], [PagoHora], [CantHora], [TipoPago], [Total]) VALUES (12, CAST(N'2023-09-11' AS Date), 6, 3, N'Comsion', 18)
INSERT [dbo].[PagoEmpleado] ([ID_Empleado], [fecha], [PagoHora], [CantHora], [TipoPago], [Total]) VALUES (65, CAST(N'2023-11-26' AS Date), 10, 288, N'Venta', 2880)
GO
SET IDENTITY_INSERT [dbo].[Pedido] ON 

INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (1, CAST(N'2023-11-23' AS Date), N'Pendiente', 10, NULL, 81.61)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (2, CAST(N'2023-11-23' AS Date), N'Pendiente', 15, NULL, 24.7)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (3, CAST(N'2023-11-23' AS Date), N'Pendiente', 15, NULL, 56.91)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (4, CAST(N'2023-11-23' AS Date), N'Pendiente', 10, NULL, 56.91)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (5, CAST(N'2023-11-23' AS Date), N'Pendiente', 10, NULL, 81.61)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (8, CAST(N'2023-11-23' AS Date), N'Pendiente', 10, NULL, 81.61)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (10, CAST(N'2023-11-23' AS Date), N'Pendiente', 20, NULL, 56.91)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (11, CAST(N'2023-11-24' AS Date), N'Pendiente', 20, NULL, 13.75)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (12, CAST(N'2023-11-25' AS Date), N'Pendiente', 21, NULL, 21.25)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (13, CAST(N'2023-11-26' AS Date), N'Pendiente', 22, NULL, 30.87)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (14, CAST(N'2023-11-27' AS Date), N'Pendiente', 26, NULL, 12.5)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (15, CAST(N'2023-11-28' AS Date), N'Pendiente', 26, NULL, 23.75)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (16, CAST(N'2023-11-29' AS Date), N'Pendiente', 26, NULL, 17.5)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (17, CAST(N'2023-11-30' AS Date), N'Pendiente', 26, NULL, 35)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (18, CAST(N'2023-12-01' AS Date), N'Pendiente', 27, NULL, 35)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (19, CAST(N'2023-12-02' AS Date), N'Pendiente', 28, NULL, 15)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (20, CAST(N'2023-12-03' AS Date), N'Pendiente', 20, NULL, 17.5)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (21, CAST(N'2023-12-04' AS Date), N'Pendiente', 30, NULL, 18.75)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (22, CAST(N'2023-12-05' AS Date), N'Pendiente', 31, NULL, 18.75)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (23, CAST(N'2023-12-06' AS Date), N'Pendiente', 32, NULL, 13.75)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (24, CAST(N'2023-12-07' AS Date), N'Pendiente', 33, NULL, 21.25)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (25, CAST(N'2023-12-08' AS Date), N'Pendiente', 26, NULL, 13.75)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (26, CAST(N'2023-12-09' AS Date), N'Pendiente', 35, NULL, 26.25)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (27, CAST(N'2023-12-10' AS Date), N'Pendiente', 36, NULL, 31.25)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (28, CAST(N'2023-12-11' AS Date), N'Pendiente', 37, NULL, 15)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (29, CAST(N'2023-12-12' AS Date), N'Pendiente', 20, NULL, 21.25)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (30, CAST(N'2023-12-13' AS Date), N'Pendiente', 39, NULL, 32.5)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (31, CAST(N'2023-12-14' AS Date), N'Pendiente', 40, NULL, 26.25)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (32, CAST(N'2023-12-15' AS Date), N'Pendiente', 41, NULL, 17.5)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (33, CAST(N'2023-12-16' AS Date), N'Pendiente', 42, NULL, 15)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (34, CAST(N'2023-12-17' AS Date), N'Pendiente', 26, NULL, 28.75)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (35, CAST(N'2023-12-18' AS Date), N'Pendiente', 44, NULL, 27.5)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (36, CAST(N'2023-12-19' AS Date), N'Pendiente', 20, NULL, 15)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (37, CAST(N'2023-12-20' AS Date), N'Pendiente', 46, NULL, 13.75)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (38, CAST(N'2023-12-21' AS Date), N'Pendiente', 47, NULL, 32.5)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (39, CAST(N'2023-12-22' AS Date), N'Pendiente', 26, NULL, 35)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (41, CAST(N'2023-12-31' AS Date), N'Pendiente', 57, NULL, 36.89)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (42, CAST(N'2024-01-05' AS Date), N'Pendiente', 58, NULL, 67.78)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (43, CAST(N'2024-01-06' AS Date), N'Pendiente', 59, NULL, 28.9)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (44, CAST(N'2024-01-07' AS Date), N'Pendiente', 60, NULL, 67.45)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (45, CAST(N'2024-01-08' AS Date), N'Pendiente', 61, NULL, 29.98)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (46, CAST(N'2023-11-23' AS Date), N'Pendiente', 10, NULL, 71.39)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (47, CAST(N'2023-11-23' AS Date), N'Pendiente', 10, NULL, 30.09)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (48, CAST(N'2023-11-23' AS Date), N'Pendiente', 10, NULL, 22.490000000000002)
INSERT [dbo].[Pedido] ([ID_de_pedido], [Fecha_de_pedido], [Estado_pedido], [Cliente_ID_cliente], [Empleado_ID_del_Empleado], [Total]) VALUES (49, CAST(N'2023-11-24' AS Date), N'Pendiente', 10, NULL, 68.88)
SET IDENTITY_INSERT [dbo].[Pedido] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ID_Producto], [Nombre_producto], [Precio_producto], [Descripcion_producto], [Categorias_Productos_ID_Categoria]) VALUES (3, N'1 pollo', 38.79, N'1 pollo + gaseosa', 0)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre_producto], [Precio_producto], [Descripcion_producto], [Categorias_Productos_ID_Categoria]) VALUES (4, N'1/2 pollo', 20.2, N'1/2 + ensalada', 0)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre_producto], [Precio_producto], [Descripcion_producto], [Categorias_Productos_ID_Categoria]) VALUES (5, N'1/4 de pollo', 12.6, N'1/4 de pollo + gasesoa', 0)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre_producto], [Precio_producto], [Descripcion_producto], [Categorias_Productos_ID_Categoria]) VALUES (6, N'1/8 de pollo', 9.89, N'1/8 de pollo + gaseosa', 0)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
ALTER TABLE [dbo].[Detalle_Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Pedido_Pedido] FOREIGN KEY([ID_de_pedido])
REFERENCES [dbo].[Pedido] ([ID_de_pedido])
GO
ALTER TABLE [dbo].[Detalle_Pedido] CHECK CONSTRAINT [FK_Detalle_Pedido_Pedido]
GO
ALTER TABLE [dbo].[Detalle_Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Pedido_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[Detalle_Pedido] CHECK CONSTRAINT [FK_Detalle_Pedido_Producto]
GO
ALTER TABLE [dbo].[PagoEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_PagoEmpleado_Empleado] FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[Empleado] ([ID_del_Empleado])
GO
ALTER TABLE [dbo].[PagoEmpleado] CHECK CONSTRAINT [FK_PagoEmpleado_Empleado]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [Pedido_Cliente] FOREIGN KEY([Cliente_ID_cliente])
REFERENCES [dbo].[Cliente] ([ID_cliente])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [Pedido_Cliente]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [Pedido_Empleado] FOREIGN KEY([Empleado_ID_del_Empleado])
REFERENCES [dbo].[Empleado] ([ID_del_Empleado])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [Pedido_Empleado]
GO
ALTER TABLE [dbo].[ProductoxProveedor]  WITH CHECK ADD  CONSTRAINT [PedidoxProveedor_Producto] FOREIGN KEY([Producto_ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[ProductoxProveedor] CHECK CONSTRAINT [PedidoxProveedor_Producto]
GO
ALTER TABLE [dbo].[ProductoxProveedor]  WITH CHECK ADD  CONSTRAINT [PedidoxProveedor_Proveedor] FOREIGN KEY([Proveedor_ID_Proovedor])
REFERENCES [dbo].[Proveedor] ([ID_Proovedor])
GO
ALTER TABLE [dbo].[ProductoxProveedor] CHECK CONSTRAINT [PedidoxProveedor_Proveedor]
GO
