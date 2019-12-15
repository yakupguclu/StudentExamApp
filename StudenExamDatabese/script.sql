USE [OgrenciSinav]
GO
/****** Object:  StoredProcedure [dbo].[LoginKontrol]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginKontrol]
@id nvarchar(30),
@p nvarchar(30) 
as
SELECT * FROM Ogrenci WHERE OgrenciID=@id and TCKN=@p
GO
/****** Object:  StoredProcedure [dbo].[OgrenciEkle]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciEkle]
@ad nvarchar(50),
@soyad nvarchar(50),
@tckn int
as
INSERT INTO Ogrenci(Ad,Soyad,TCKN) values(@ad,@soyad,@tckn) 
GO
/****** Object:  StoredProcedure [dbo].[OgrenciGuncelle]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciGuncelle]
@ad nvarchar(50),
@soyad nvarchar(50),
@tckn int,
@id int
as
UPDATE Ogrenci SET Ad=@ad,Soyad=@soyad,TCKN=@tckn where OgrenciID=@id
GO
/****** Object:  StoredProcedure [dbo].[OgrenciListele]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciListele]
as
SELECT OgrenciID,Ad,Soyad,TCKN FROM Ogrenci
GO
/****** Object:  StoredProcedure [dbo].[OgrenciSil]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciSil]
@id int
as
DELETE Ogrenci where OgrenciID=@id
GO
/****** Object:  StoredProcedure [dbo].[SoruGetir]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruGetir]
as
Select TOP 10 * from Soru Order By NEWID()
GO
/****** Object:  Table [dbo].[Brans]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brans](
	[BransID] [int] IDENTITY(401,1) NOT NULL,
	[Brans] [nvarchar](30) NULL,
 CONSTRAINT [PK_Brans] PRIMARY KEY CLUSTERED 
(
	[BransID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ders]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ders](
	[DersID] [int] NOT NULL,
	[DersAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ders] PRIMARY KEY CLUSTERED 
(
	[DersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Not]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Not](
	[Notu] [smallint] NULL,
	[DersID] [int] NULL,
	[OgrenciID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[OgrenciID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](40) NULL,
	[Soyad] [nvarchar](50) NULL,
	[TCKN] [char](11) NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[OgrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OgrenciDetay]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OgrenciDetay](
	[OgrenciID] [int] NOT NULL,
	[DersID] [int] NULL,
	[OgretmenID] [int] NULL,
	[SoruID] [int] NULL,
	[Cevap] [char](1) NULL,
	[Tarih] [datetime] NULL,
	[Puan] [smallint] NULL,
	[DogruCevap] [char](1) NULL,
 CONSTRAINT [PK_OgrenciDetay] PRIMARY KEY CLUSTERED 
(
	[OgrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ogretmen]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogretmen](
	[OgretmenID] [int] IDENTITY(1001,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[BransID] [int] NULL,
	[DersID] [int] NULL,
 CONSTRAINT [PK_Ogretmen] PRIMARY KEY CLUSTERED 
(
	[OgretmenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Soru]    Script Date: 15.12.2019 23:04:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Soru](
	[SoruID] [int] IDENTITY(10200,1) NOT NULL,
	[Metin] [text] NULL,
	[SikA] [nvarchar](100) NULL,
	[SikB] [nvarchar](100) NULL,
	[SikC] [nvarchar](100) NULL,
	[SikD] [nvarchar](100) NULL,
	[DogruCevap] [nvarchar](100) NULL,
	[Resim] [image] NULL,
 CONSTRAINT [PK_Soru] PRIMARY KEY CLUSTERED 
(
	[SoruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Brans] ON 

INSERT [dbo].[Brans] ([BransID], [Brans]) VALUES (401, N'Matematik')
INSERT [dbo].[Brans] ([BransID], [Brans]) VALUES (402, N'Türk Dili')
INSERT [dbo].[Brans] ([BransID], [Brans]) VALUES (403, N'İngilizce')
INSERT [dbo].[Brans] ([BransID], [Brans]) VALUES (404, N'Edebiyat')
INSERT [dbo].[Brans] ([BransID], [Brans]) VALUES (405, N'Kimya')
INSERT [dbo].[Brans] ([BransID], [Brans]) VALUES (406, N'Fizik')
INSERT [dbo].[Brans] ([BransID], [Brans]) VALUES (407, N'Biyoloji')
SET IDENTITY_INSERT [dbo].[Brans] OFF
INSERT [dbo].[Ders] ([DersID], [DersAdi]) VALUES (1, N'Matematik')
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([OgrenciID], [Ad], [Soyad], [TCKN]) VALUES (1, N'Yakup', N'Güçlü', N'22262498982')
INSERT [dbo].[Ogrenci] ([OgrenciID], [Ad], [Soyad], [TCKN]) VALUES (9, N'Fatih', N'Arıcılık', N'11111111111')
INSERT [dbo].[Ogrenci] ([OgrenciID], [Ad], [Soyad], [TCKN]) VALUES (10, N'Ali Atakan', N'Akman', N'22222222222')
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
SET IDENTITY_INSERT [dbo].[Ogretmen] ON 

INSERT [dbo].[Ogretmen] ([OgretmenID], [Ad], [Soyad], [BransID], [DersID]) VALUES (1001, N'Muharrem', N'DURSUN', 401, NULL)
INSERT [dbo].[Ogretmen] ([OgretmenID], [Ad], [Soyad], [BransID], [DersID]) VALUES (1002, N'Atakan', N'ÇELENK', 401, NULL)
INSERT [dbo].[Ogretmen] ([OgretmenID], [Ad], [Soyad], [BransID], [DersID]) VALUES (1003, N'Numan', N'AŞKIN', 401, NULL)
SET IDENTITY_INSERT [dbo].[Ogretmen] OFF
SET IDENTITY_INSERT [dbo].[Soru] ON 

INSERT [dbo].[Soru] ([SoruID], [Metin], [SikA], [SikB], [SikC], [SikD], [DogruCevap], [Resim]) VALUES (10200, N'3x3', N'6', N'7', N'8', N'9', N'9', NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [SikA], [SikB], [SikC], [SikD], [DogruCevap], [Resim]) VALUES (10201, N'(6+6*3+2)', N'23', N'26', N'27', N'21', N'26', NULL)
SET IDENTITY_INSERT [dbo].[Soru] OFF
ALTER TABLE [dbo].[Not]  WITH CHECK ADD  CONSTRAINT [FK_Not_Ders] FOREIGN KEY([DersID])
REFERENCES [dbo].[Ders] ([DersID])
GO
ALTER TABLE [dbo].[Not] CHECK CONSTRAINT [FK_Not_Ders]
GO
ALTER TABLE [dbo].[Not]  WITH CHECK ADD  CONSTRAINT [FK_Not_Ogrenci] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenci] ([OgrenciID])
GO
ALTER TABLE [dbo].[Not] CHECK CONSTRAINT [FK_Not_Ogrenci]
GO
ALTER TABLE [dbo].[OgrenciDetay]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDetay_Ogrenci] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenci] ([OgrenciID])
GO
ALTER TABLE [dbo].[OgrenciDetay] CHECK CONSTRAINT [FK_OgrenciDetay_Ogrenci]
GO
ALTER TABLE [dbo].[OgrenciDetay]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDetay_Ogretmen] FOREIGN KEY([OgretmenID])
REFERENCES [dbo].[Ogretmen] ([OgretmenID])
GO
ALTER TABLE [dbo].[OgrenciDetay] CHECK CONSTRAINT [FK_OgrenciDetay_Ogretmen]
GO
ALTER TABLE [dbo].[OgrenciDetay]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDetay_Soru1] FOREIGN KEY([SoruID])
REFERENCES [dbo].[Soru] ([SoruID])
GO
ALTER TABLE [dbo].[OgrenciDetay] CHECK CONSTRAINT [FK_OgrenciDetay_Soru1]
GO
ALTER TABLE [dbo].[Ogretmen]  WITH CHECK ADD  CONSTRAINT [FK_Ogretmen_Brans1] FOREIGN KEY([BransID])
REFERENCES [dbo].[Brans] ([BransID])
GO
ALTER TABLE [dbo].[Ogretmen] CHECK CONSTRAINT [FK_Ogretmen_Brans1]
GO
ALTER TABLE [dbo].[Ogretmen]  WITH CHECK ADD  CONSTRAINT [FK_Ogretmen_Ders] FOREIGN KEY([DersID])
REFERENCES [dbo].[Ders] ([DersID])
GO
ALTER TABLE [dbo].[Ogretmen] CHECK CONSTRAINT [FK_Ogretmen_Ders]
GO
