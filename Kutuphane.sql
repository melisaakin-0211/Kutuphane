Create Database Kutuphane
GO 
USE [Kutuphane]
GO
/****** Object:  Table [dbo].[Alisveris]    Script Date: 26.06.2026 15:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alisveris](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KitapID] [int] NULL,
	[KullaniciID] [int] NULL,
	[AlisZamani] [datetime] NULL,
	[TeslimZamani] [datetime] NULL,
	[Aciklama] [nvarchar](max) NULL,
	[KayitTarihi] [datetime] NULL,
	[KayitYapan] [nvarchar](50) NULL,
	[DegisiklikTarihi] [datetime] NULL,
	[DegisiklikYapan] [nvarchar](50) NULL,
 CONSTRAINT [PK_Alışveriş] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitap]    Script Date: 26.06.2026 15:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[SubTitle] [nvarchar](50) NULL,
	[YayinEviID] [int] NULL,
	[YazarID] [int] NULL,
	[Tur] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kitap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 26.06.2026 15:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NULL,
	[Role] [nvarchar](100) NULL,
 CONSTRAINT [PK_Kullanıcı] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YayinEvi]    Script Date: 26.06.2026 15:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YayinEvi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NULL,
 CONSTRAINT [PK_YayınEvi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yazar]    Script Date: 26.06.2026 15:58:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yazar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NULL,
	[DogumTarihi] [datetime] NULL,
	[Aciklama] [nvarchar](max) NULL,
 CONSTRAINT [PK_YazarBilgi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alisveris]  WITH CHECK ADD  CONSTRAINT [FK_Alisveris_Kitap] FOREIGN KEY([KitapID])
REFERENCES [dbo].[Kitap] ([ID])
GO
ALTER TABLE [dbo].[Alisveris] CHECK CONSTRAINT [FK_Alisveris_Kitap]
GO
ALTER TABLE [dbo].[Alisveris]  WITH CHECK ADD  CONSTRAINT [FK_Alisveris_Kullanici] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[Kullanici] ([ID])
GO
ALTER TABLE [dbo].[Alisveris] CHECK CONSTRAINT [FK_Alisveris_Kullanici]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_YayinEvi] FOREIGN KEY([YayinEviID])
REFERENCES [dbo].[YayinEvi] ([ID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_YayinEvi]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Yazar] FOREIGN KEY([YazarID])
REFERENCES [dbo].[Yazar] ([ID])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Yazar]
GO
