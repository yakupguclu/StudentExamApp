USE [OgrenciSinav]
GO
/****** Object:  StoredProcedure [dbo].[LoginKontrol]    Script Date: 24.12.2019 23:15:23 ******/
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
/****** Object:  StoredProcedure [dbo].[OgrenciEkle]    Script Date: 24.12.2019 23:15:23 ******/
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
/****** Object:  StoredProcedure [dbo].[OgrenciGuncelle]    Script Date: 24.12.2019 23:15:23 ******/
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
/****** Object:  StoredProcedure [dbo].[OgrenciListele]    Script Date: 24.12.2019 23:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciListele]
as
SELECT OgrenciID,Ad,Soyad,TCKN FROM Ogrenci
GO
/****** Object:  StoredProcedure [dbo].[OgrenciSil]    Script Date: 24.12.2019 23:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciSil]
@id int
as
DELETE Ogrenci where OgrenciID=@id
GO
/****** Object:  StoredProcedure [dbo].[SoruEkle]    Script Date: 24.12.2019 23:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruEkle]
@sresim nvarchar(100),
@sika nvarchar(100),
@sikb nvarchar(100),
@sikc nvarchar(100),
@sikd nvarchar(100),
@cevap nvarchar(50),
@metin nvarchar(200),
@konuid int
as
insert into Soru (SoruResim,SikA,SikB,SikC,SikD,DogruCevap,Metin,KonuID) values (@sresim,@sika,@sikb,@sikc,@sikd,@cevap,@metin,@konuid)
GO
/****** Object:  StoredProcedure [dbo].[SoruGetir]    Script Date: 24.12.2019 23:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruGetir]
as
Select TOP 10 * from Soru Order By NEWID()
GO
/****** Object:  StoredProcedure [dbo].[SoruGuncelle]    Script Date: 24.12.2019 23:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruGuncelle]
@sresim nvarchar(100),
@sika nvarchar(100),
@sikb nvarchar(100),
@sikc nvarchar(100),
@sikd nvarchar(100),
@cevap nvarchar(50),
@metin nvarchar(200),
@konuid int,
@soruid int
AS
UPDATE Soru set SoruResim=@sresim,SikA=@sika,SikB=@sikb,SikC=@sikc,SikD=@sikd,DogruCevap=@cevap,Metin=@metin,KonuID=@konuid where SoruID=@soruid
GO
/****** Object:  StoredProcedure [dbo].[SoruListele]    Script Date: 24.12.2019 23:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruListele]
as
SELECT SoruID,Metin,SoruResim,SikA,SikB,SikC,SikD,DogruCevap,k.Konu FROM Soru s
	inner join Konu k on s.KonuID=k.KonuID
GO
/****** Object:  StoredProcedure [dbo].[SoruSil]    Script Date: 24.12.2019 23:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruSil]
@soruid int
as
DELETE Soru where SoruID=@soruid
GO
/****** Object:  Table [dbo].[Brans]    Script Date: 24.12.2019 23:15:23 ******/
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
/****** Object:  Table [dbo].[Ders]    Script Date: 24.12.2019 23:15:23 ******/
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
/****** Object:  Table [dbo].[Konu]    Script Date: 24.12.2019 23:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Konu](
	[KonuID] [int] IDENTITY(0,1) NOT NULL,
	[Konu] [nvarchar](50) NULL,
 CONSTRAINT [PK_Konu] PRIMARY KEY CLUSTERED 
(
	[KonuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Not]    Script Date: 24.12.2019 23:15:23 ******/
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
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 24.12.2019 23:15:23 ******/
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
/****** Object:  Table [dbo].[OgrenciDetay]    Script Date: 24.12.2019 23:15:23 ******/
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
/****** Object:  Table [dbo].[Ogretmen]    Script Date: 24.12.2019 23:15:23 ******/
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
/****** Object:  Table [dbo].[Soru]    Script Date: 24.12.2019 23:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Soru](
	[SoruID] [int] IDENTITY(10200,1) NOT NULL,
	[Metin] [nvarchar](200) NULL,
	[DogruCevap] [nvarchar](100) NULL,
	[SoruResim] [nvarchar](100) NULL,
	[SikA] [nvarchar](100) NULL,
	[SikB] [nvarchar](100) NULL,
	[SikC] [nvarchar](100) NULL,
	[SikD] [nvarchar](100) NULL,
	[KonuID] [int] NULL,
 CONSTRAINT [PK_Soru] PRIMARY KEY CLUSTERED 
(
	[SoruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

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
SET IDENTITY_INSERT [dbo].[Konu] ON 

INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (0, N'Mutlak Değer')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (1, N'Mantık')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (2, N'Modüler Aritmetik')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (3, N'Problemler')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (4, N'Ardışık Sayılar')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (5, N'Çarpanları Ayırma')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (6, N'Sayılar')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (7, N'Bölme ve Bölünebilme')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (8, N'OBEB-OKEK')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (9, N'Oran Orantı')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (10, N'Denklemler')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (11, N'Fonksiyonlar')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (12, N'Permütasyon')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (13, N'Kombinasyon')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (14, N'Olasılık')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (15, N'Binom')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (16, N'Parabol')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (17, N'Polinom')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (18, N'İstatistik')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (19, N'Kümeler')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (20, N'2. Derece Denklemler')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (21, N'Köklü Sayılar')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (22, N'Üslü Sayılar')
INSERT [dbo].[Konu] ([KonuID], [Konu]) VALUES (23, N'Üçgenler')
SET IDENTITY_INSERT [dbo].[Konu] OFF
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

INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10200, NULL, NULL, N'C:\Users\Yakup\Desktop\deneme.jpg', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10201, NULL, N'a', N'C:\Users\Yakup\Desktop\sorumetin.jpg', N'C:\Users\Yakup\Desktop\sikA.jpg', N'C:\Users\Yakup\Desktop\sikB.jpg', N'C:\Users\Yakup\Desktop\sikC.jpg', N'C:\Users\Yakup\Desktop\sikD.jpg', NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10202, NULL, N'a', N'C:\Users\Yakup\Desktop\sorumetin.jpg', N'C:\Users\Yakup\Desktop\sikA.jpg', N'C:\Users\Yakup\Desktop\sikB.jpg', N'C:\Users\Yakup\Desktop\sikC.jpg', N'C:\Users\Yakup\Desktop\sikD.jpg', NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10203, NULL, N'a', N'C:\Users\Yakup\Desktop\sorumetin.jpg', N'C:\Users\Yakup\Desktop\sikA.jpg', N'C:\Users\Yakup\Desktop\sikB.jpg', N'C:\Users\Yakup\Desktop\sikC.jpg', N'C:\Users\Yakup\Desktop\sikD.jpg', NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10204, N'a', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10206, N'aa', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10207, N'aa', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10208, N'aaaaaaa', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10209, N'aaaaaaasd', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10210, N'sda', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10211, N'ASDDD', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10212, N'gggg', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10213, N'dsd', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10214, NULL, NULL, N'asdas', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10215, NULL, NULL, N'fasf', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10216, N'aa', N'', N'', N'dd', N'f', N'd', N'e', NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10217, N'aa', N'sd', N'dfs', N'dd', N'f', N'd', N'e', NULL)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10218, N'asd', N'a', N'asd', N'asd', N'asd', N'gdsg', N'sadasd', 4)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID]) VALUES (10220, N'', N'', N'C:\Users\Yakup\Desktop\sikC.jpg', N'C:\Users\Yakup\Desktop\sikD.jpg', N'C:\Users\Yakup\Desktop\sikA.jpg', N'C:\Users\Yakup\Desktop\sorumetin.jpg', N'C:\Users\Yakup\Desktop\sikB.jpg', 3)
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
ALTER TABLE [dbo].[Soru]  WITH CHECK ADD  CONSTRAINT [FK_Soru_Konu] FOREIGN KEY([KonuID])
REFERENCES [dbo].[Konu] ([KonuID])
GO
ALTER TABLE [dbo].[Soru] CHECK CONSTRAINT [FK_Soru_Konu]
GO
