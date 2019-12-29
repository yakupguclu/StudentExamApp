USE [OgrenciSinav]
GO
/****** Object:  StoredProcedure [dbo].[LoginKontrol]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  StoredProcedure [dbo].[OgrenciDetayEkle]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciDetayEkle]
@ogrid int,
@cozulensorusayisi int,
@puan int,
@tarih DateTime
as
insert into OgrenciDetay (OgrenciID,CozulenSoruSayisi,Puan,Tarih) values(9,@cozulensorusayisi,@puan,@tarih)
GO
/****** Object:  StoredProcedure [dbo].[OgrenciEkle]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  StoredProcedure [dbo].[OgrenciGuncelle]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  StoredProcedure [dbo].[OgrenciListele]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciListele]
as
SELECT OgrenciID,Ad,Soyad,TCKN FROM Ogrenci
GO
/****** Object:  StoredProcedure [dbo].[OgrenciSil]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciSil]
@id int
as
DELETE Ogrenci where OgrenciID=@id
GO
/****** Object:  StoredProcedure [dbo].[OrtalamaPuan]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OrtalamaPuan]
as
SELECT AVG(Puan) as Genel FROM OgrenciDetay 
GO
/****** Object:  StoredProcedure [dbo].[SoruDetayEkle]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruDetayEkle]

@soruid int,
@verilencevap nvarchar(2),
@konuid int
as
insert into SoruDetay (OgrenciID,DersID,SoruID,VerilenCevap,KonuID) values(9,1,@soruid,@verilencevap,@konuid)
GO
/****** Object:  StoredProcedure [dbo].[SoruEkle]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  StoredProcedure [dbo].[SoruGetir]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruGetir]
as
Select TOP 13 * from Soru  WHERE AsamaNo=0 Order By NEWID() 
GO
/****** Object:  StoredProcedure [dbo].[SoruGetirTamamla]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruGetirTamamla]
as
SELECT TOP 7 * FROM Soru WHERE AsamaNo=1 Order By NEWID()
GO
/****** Object:  StoredProcedure [dbo].[SoruGuncelle]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  StoredProcedure [dbo].[SoruListele]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruListele]
as
SELECT SoruID,Metin,SoruResim,SikA,SikB,SikC,SikD,DogruCevap,k.Konu FROM Soru s
	inner join Konu k on s.KonuID=k.KonuID
GO
/****** Object:  StoredProcedure [dbo].[SoruSil]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoruSil]
@soruid int
as
DELETE Soru where SoruID=@soruid
GO
/****** Object:  StoredProcedure [dbo].[ToplamSoru]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ToplamSoru]
as
SELECT SUM(CozulenSoruSayisi) as Genel FROM OgrenciDetay
GO
/****** Object:  Table [dbo].[Brans]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  Table [dbo].[Ders]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  Table [dbo].[Konu]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  Table [dbo].[Not]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[OgrenciID] [int] IDENTITY(1,172802) NOT NULL,
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
/****** Object:  Table [dbo].[OgrenciDetay]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciDetay](
	[OgrenciID] [int] NULL,
	[CozulenSoruSayisi] [int] NULL,
	[Puan] [int] NULL,
	[Tarih] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ogretmen]    Script Date: 29.12.2019 22:27:51 ******/
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
/****** Object:  Table [dbo].[Soru]    Script Date: 29.12.2019 22:27:51 ******/
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
	[AsamaNo] [int] NULL,
 CONSTRAINT [PK_Soru] PRIMARY KEY CLUSTERED 
(
	[SoruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SoruDetay]    Script Date: 29.12.2019 22:27:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SoruDetay](
	[OgrenciID] [int] NULL,
	[DersID] [int] NULL,
	[SoruID] [int] NOT NULL,
	[VerilenCevap] [char](1) NULL,
	[KonuID] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
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
SET IDENTITY_INSERT [dbo].[Konu] OFF
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([OgrenciID], [Ad], [Soyad], [TCKN]) VALUES (9, N'Fatih', N'Arıcılık', N'11111111111')
INSERT [dbo].[Ogrenci] ([OgrenciID], [Ad], [Soyad], [TCKN]) VALUES (10, N'Ali Atakan', N'Akman', N'22222222222')
INSERT [dbo].[Ogrenci] ([OgrenciID], [Ad], [Soyad], [TCKN]) VALUES (172802065, N'Yakup', N'Güçlü', N'22262498982')
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
INSERT [dbo].[OgrenciDetay] ([OgrenciID], [CozulenSoruSayisi], [Puan], [Tarih]) VALUES (9, 21, 55, CAST(0x0000AB3200000000 AS DateTime))
INSERT [dbo].[OgrenciDetay] ([OgrenciID], [CozulenSoruSayisi], [Puan], [Tarih]) VALUES (9, 21, 25, CAST(0x0000AB3200000000 AS DateTime))
INSERT [dbo].[OgrenciDetay] ([OgrenciID], [CozulenSoruSayisi], [Puan], [Tarih]) VALUES (9, 21, 55, CAST(0x0000AB3200000000 AS DateTime))
INSERT [dbo].[OgrenciDetay] ([OgrenciID], [CozulenSoruSayisi], [Puan], [Tarih]) VALUES (9, 21, 65, CAST(0x0000AB3200000000 AS DateTime))
INSERT [dbo].[OgrenciDetay] ([OgrenciID], [CozulenSoruSayisi], [Puan], [Tarih]) VALUES (9, 21, 65, CAST(0x0000AB3200000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Ogretmen] ON 

INSERT [dbo].[Ogretmen] ([OgretmenID], [Ad], [Soyad], [BransID], [DersID]) VALUES (1001, N'Muharrem', N'DURSUN', 401, NULL)
INSERT [dbo].[Ogretmen] ([OgretmenID], [Ad], [Soyad], [BransID], [DersID]) VALUES (1002, N'Atakan', N'ÇELENK', 401, NULL)
INSERT [dbo].[Ogretmen] ([OgretmenID], [Ad], [Soyad], [BransID], [DersID]) VALUES (1003, N'Numan', N'AŞKIN', 401, NULL)
SET IDENTITY_INSERT [dbo].[Ogretmen] OFF
SET IDENTITY_INSERT [dbo].[Soru] ON 

INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10224, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 10, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10227, N'İşleminin sonucu kaçtır ?', N'D', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\sorumetin.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\sikA.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\sikB.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\sikC.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\sikD.jpg', 6, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10228, N'A ve B sıfırdan farklı rakamlar olmak üzere , olduğuna göre, toplamı kaçtır?', N'C', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru2.soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru2a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru2b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru2c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru2d.jpg', 6, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10229, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 9, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10231, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 7, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10232, N'İşleminin Sonucu Kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\sikB.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\sikA.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 6, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10233, N'İşleminin Sonucu Kaçtır ?', N'C', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\sorumetin.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', 3, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10234, N'İşleminin Sonucu Kaçtır ?', N'C', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', 2, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10235, N'İşleminin Sonucu Kaçtır ?', N'D', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru2b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', 2, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10236, N'İşleminin Sonucu Kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru2.soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru2b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', 6, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10237, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 6, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10238, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 6, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10239, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 6, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10240, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 6, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10241, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 6, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10242, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 6, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10243, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 6, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10244, N'İşleminin Sonucu Kaçtır ?', N'B', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru1d.jpg', 6, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10273, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 4, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10274, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 4, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10275, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 4, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10276, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 4, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10277, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 4, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10278, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 6, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10279, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 6, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10280, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 6, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10281, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 6, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10282, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 4, 1)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10283, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 2, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10284, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 2, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10285, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 2, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10286, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 2, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10287, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 7, 0)
INSERT [dbo].[Soru] ([SoruID], [Metin], [DogruCevap], [SoruResim], [SikA], [SikB], [SikC], [SikD], [KonuID], [AsamaNo]) VALUES (10288, N'olduğuna göre, 2^(x+y)  ifadesinin değeri kaçtır ?', N'A', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3soru.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3a.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3b.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3c.jpg', N'D:\Yakup\Ders Notları\Yazılım Sınama(Testi)\Proje\OgrenciSinav.WinForm\Sorular\soru3d.jpg', 7, 0)
SET IDENTITY_INSERT [dbo].[Soru] OFF
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10277, N'A', 0)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10236, N'B', 1)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10237, N'C', 2)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10285, N'D', 3)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10287, N'C', 4)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10278, N'C', 5)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10275, N'A', 6)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10274, N'A', 7)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10283, N'A', 8)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10231, N'A', 1)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10284, N'A', 2)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10273, N'B', 3)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10243, N'D', 4)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10241, N'C', 5)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10281, N'C', 6)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10238, N'C', 4)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10242, N'C', 1)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10232, N'C', 2)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10282, N'C', 5)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10239, N'C', 1)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10285, N'A', 2)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10287, N'A', 4)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10278, N'A', 6)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10244, N'A', 5)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10286, N'A', 1)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10228, N'A', 5)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10276, N'A', 3)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10288, N'A', 4)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10236, N'A', 1)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10227, N'A', 2)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10277, N'A', 5)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10243, N'A', 3)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10283, N'A', 1)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10229, N'A', 4)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10242, N'A', 2)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10238, N'A', 3)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10281, N'A', 1)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10234, N'A', 6)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10280, N'A', 8)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10232, N'A', 9)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10228, N'A', 6)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10236, N'A', 6)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10285, N'A', 2)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10288, N'A', 7)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10273, N'A', 4)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10287, N'A', 7)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10244, N'A', 6)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10237, N'A', 6)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10284, N'A', 2)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10233, N'A', 3)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10224, N'A', 10)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10276, N'A', 4)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10235, N'A', 2)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10241, N'A', 0)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10240, N'A', 0)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10242, N'A', 0)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10232, N'A', 0)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10280, N'A', 0)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10229, N'A', 0)
INSERT [dbo].[SoruDetay] ([OgrenciID], [DersID], [SoruID], [VerilenCevap], [KonuID]) VALUES (9, 1, 10281, N'A', 0)
ALTER TABLE [dbo].[Soru] ADD  CONSTRAINT [DF_Soru_AsamaNo]  DEFAULT ((0)) FOR [AsamaNo]
GO
ALTER TABLE [dbo].[SoruDetay] ADD  CONSTRAINT [DF_SoruDetay_DersID]  DEFAULT ((1)) FOR [DersID]
GO
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
ALTER TABLE [dbo].[OgrenciDetay]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDetay_Ogrenci1] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenci] ([OgrenciID])
GO
ALTER TABLE [dbo].[OgrenciDetay] CHECK CONSTRAINT [FK_OgrenciDetay_Ogrenci1]
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
ALTER TABLE [dbo].[SoruDetay]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDetay_Ders] FOREIGN KEY([DersID])
REFERENCES [dbo].[Ders] ([DersID])
GO
ALTER TABLE [dbo].[SoruDetay] CHECK CONSTRAINT [FK_OgrenciDetay_Ders]
GO
ALTER TABLE [dbo].[SoruDetay]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDetay_Ogrenci] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenci] ([OgrenciID])
GO
ALTER TABLE [dbo].[SoruDetay] CHECK CONSTRAINT [FK_OgrenciDetay_Ogrenci]
GO
ALTER TABLE [dbo].[SoruDetay]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDetay_Soru1] FOREIGN KEY([SoruID])
REFERENCES [dbo].[Soru] ([SoruID])
GO
ALTER TABLE [dbo].[SoruDetay] CHECK CONSTRAINT [FK_OgrenciDetay_Soru1]
GO
