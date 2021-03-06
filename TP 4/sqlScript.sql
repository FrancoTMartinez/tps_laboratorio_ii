USE [TP4_Final_FrancoTobiasMartinez_2E]
GO
/****** Object:  Table [dbo].[TableAdministradores]    Script Date: 11/11/2021 5:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableAdministradores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TableAdministradores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableCanales]    Script Date: 11/11/2021 5:00:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableCanales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TableCanal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablePersonas]    Script Date: 11/11/2021 5:00:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablePersonas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[IDCanal] [int] NOT NULL,
	[Edad] [int] NOT NULL,
	[Genero] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TablePersonas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TableAdministradores] ON 
GO
INSERT [dbo].[TableAdministradores] ([ID], [DNI], [Usuario], [Password]) VALUES (1, N'42416954', N'admin', N'admin')
GO
SET IDENTITY_INSERT [dbo].[TableAdministradores] OFF
GO
SET IDENTITY_INSERT [dbo].[TableCanales] ON 
GO
INSERT [dbo].[TableCanales] ([ID], [Nombre]) VALUES (1, N'Telefe')
GO
INSERT [dbo].[TableCanales] ([ID], [Nombre]) VALUES (2, N'El trece')
GO
INSERT [dbo].[TableCanales] ([ID], [Nombre]) VALUES (3, N'America')
GO
INSERT [dbo].[TableCanales] ([ID], [Nombre]) VALUES (4, N'Canal 9')
GO
INSERT [dbo].[TableCanales] ([ID], [Nombre]) VALUES (5, N'Tv Publica')
GO
INSERT [dbo].[TableCanales] ([ID], [Nombre]) VALUES (6, N'Ninguno')
GO
SET IDENTITY_INSERT [dbo].[TableCanales] OFF
GO
SET IDENTITY_INSERT [dbo].[TablePersonas] ON 

INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (2, N'42416954', N'Franco', N'Martinez', 1, 21, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (4, N'18687978', N'Eladio', N'Martinez', 2, 53, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (5, N'22750836', N'Norma', N'Ester', 4, 49, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (6, N'22416954', N'Juan Cruz', N'Perco', 5, 22, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (7, N'48687978', N'Franco', N'Guimmarra', 3, 21, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (8, N'52750836', N'Loana', N'Rubio', 6, 35, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (9, N'62416954', N'Marcelo', N'Rubio', 1, 55, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (10, N'78687978', N'Mariela', N'Rubio', 6, 47, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (11, N'82750836', N'Milena', N'Rubio', 4, 17, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (12, N'92416954', N'Alext', N'Tudisca', 1, 34, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (13, N'10687978', N'Fernando', N'Oviedo', 6, 60, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (14, N'11750836', N'Claudio', N'Tudisca', 1, 55, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (15, N'14141414', N'Julieta', N'Cabral', 5, 21, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (16, N'15151515', N'Nayla', N'Tudisca', 2, 55, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (17, N'16161616', N'Norma', N'Ester', 4, 47, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (18, N'17171717', N'Cruz Juan', N'Perco', 1, 22, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (19, N'18181818', N'Federico', N'Guimmarra', 3, 21, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (20, N'19191919', N'Clara', N'Rubio', 6, 35, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (21, N'12121212', N'Daniel', N'Rubio', 1, 55, N'no binario')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (22, N'13131313', N'Daniela', N'Rubio', 6, 47, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (23, N'21212121', N'Maitena', N'Rubio', 4, 17, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (24, N'21222222', N'Oscar', N'Tudisca', 1, 34, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (25, N'23232323', N'Tito', N'Oviedo', 6, 60, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (26, N'24242424', N'Silvina', N'Tudisca', 1, 55, N'no binario')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (27, N'26262626', N'Gustavo', N'Martinez', 5, 21, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (28, N'25252525', N'Ramiro', N'Martinez', 2, 53, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (29, N'27272727', N'Romina', N'Ester', 4, 49, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (30, N'28282828', N'Juan Cruz', N'Perco', 1, 22, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (31, N'29292929', N'Tomas', N'Guimmarra', 3, 21, N'no binario')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (32, N'30303030', N'Lily', N'Rubio', 6, 35, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (33, N'31313131', N'Alejandr', N'Rubio', 1, 55, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (34, N'32323232', N'Alejandra', N'Rubio', 6, 47, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (35, N'34343434', N'Belen', N'Rubio', 2, 17, N'femenino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (36, N'36363636', N'Braian', N'Tudisca', 2, 34, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (37, N'37373737', N'L-Gante', N'Oviedo', 6, 60, N'masculino')
INSERT [dbo].[TablePersonas] ([ID], [DNI], [Nombre], [Apellido], [IDCanal], [Edad], [Genero]) VALUES (38, N'38383838', N'Jimmy', N'Tudisca', 1, 55, N'masculino')
SET IDENTITY_INSERT [dbo].[TablePersonas] OFF
GO
ALTER TABLE [dbo].[TableCanales]  WITH CHECK ADD  CONSTRAINT [FK_TableCanales_TableCanales] FOREIGN KEY([ID])
REFERENCES [dbo].[TableCanales] ([ID])
GO
ALTER TABLE [dbo].[TableCanales] CHECK CONSTRAINT [FK_TableCanales_TableCanales]
GO
ALTER TABLE [dbo].[TablePersonas]  WITH CHECK ADD  CONSTRAINT [FK_TablePersonas_TableCanales] FOREIGN KEY([IDCanal])
REFERENCES [dbo].[TableCanales] ([ID])
GO
ALTER TABLE [dbo].[TablePersonas] CHECK CONSTRAINT [FK_TablePersonas_TableCanales]
GO


