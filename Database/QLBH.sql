USE [QLBH_Win]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GioHang](
	[MaGioHang] [int] NOT NULL,
	[MaSp] [int] NULL,
	[MaKh] [int] NULL,
	[SoLuong] [int] NULL,
	[DiaChiIp] [varchar](255) NULL,
 CONSTRAINT [PK_GioHang] PRIMARY KEY CLUSTERED 
(
	[MaGioHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kh]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kh](
	[MaKh] [int] IDENTITY(1,1) NOT NULL,
	[TenKh] [nvarchar](255) NULL,
	[Email] [varchar](255) NULL,
	[MatKhau] [varchar](255) NULL,
 CONSTRAINT [PK_KH] PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ncc]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ncc](
	[MaNcc] [int] NOT NULL,
	[TenNcc] [nvarchar](255) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nv]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nv](
	[MaNv] [int] NOT NULL,
	[TenNv] [nvarchar](255) NULL,
	[Mk] [varchar](255) NULL,
 CONSTRAINT [PK_NV] PRIMARY KEY CLUSTERED 
(
	[MaNv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phieu]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieu](
	[MaPhieu] [int] NOT NULL,
	[MaKh] [int] NULL,
	[MaNv] [int] NULL,
	[NgayTao] [datetime] NULL,
 CONSTRAINT [PK_Phieu] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuGiao]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiao](
	[MaPhieuGiao] [int] NOT NULL,
 CONSTRAINT [PK_PhieuGiao] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuHd]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuHd](
	[MaPhieuHd] [int] NOT NULL,
 CONSTRAINT [PK_PhieuHD] PRIMARY KEY CLUSTERED 
(
	[MaPhieuHd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuHdChiTiet]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuHdChiTiet](
	[MaPhieuHd] [int] NOT NULL,
	[MaSp] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_PhieuHDChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaPhieuHd] ASC,
	[MaSp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPn] [int] NOT NULL,
 CONSTRAINT [PK_PhN] PRIMARY KEY CLUSTERED 
(
	[MaPn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhapChiTiet]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapChiTiet](
	[MaPhieuNhap] [int] NOT NULL,
	[MaSp] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_PhieuNhapChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sp]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sp](
	[MaSp] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiSp] [int] NULL,
	[MaNcc] [int] NULL,
	[TenSp] [nvarchar](255) NULL,
	[HinhSp] [nvarchar](255) NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_SP] PRIMARY KEY CLUSTERED 
(
	[MaSp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SpLoai]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpLoai](
	[MaLoaiSp] [int] IDENTITY(1,1) NOT NULL,
	[MaNhomSp] [int] NULL,
	[TenLoaiSp] [nchar](10) NULL,
 CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SpNhom]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpNhom](
	[MaNhomSp] [int] IDENTITY(1,1) NOT NULL,
	[TenNhomSp] [nvarchar](255) NULL,
 CONSTRAINT [PK_SPNhom] PRIMARY KEY CLUSTERED 
(
	[MaNhomSp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Test]    Script Date: 3/9/2019 10:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[C1] [int] NOT NULL,
	[C2] [nvarchar](255) NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[C1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Kh] ON 

INSERT [dbo].[Kh] ([MaKh], [TenKh], [Email], [MatKhau]) VALUES (1, N'1', N'1', N'1')
SET IDENTITY_INSERT [dbo].[Kh] OFF
INSERT [dbo].[Ncc] ([MaNcc], [TenNcc]) VALUES (1, N'ASUS')
INSERT [dbo].[Ncc] ([MaNcc], [TenNcc]) VALUES (2, N'DELL')
INSERT [dbo].[Ncc] ([MaNcc], [TenNcc]) VALUES (3, N'APPLE')
INSERT [dbo].[Nv] ([MaNv], [TenNv], [Mk]) VALUES (1, N'1', N'1')
INSERT [dbo].[Nv] ([MaNv], [TenNv], [Mk]) VALUES (2, N'2', N'2')
INSERT [dbo].[Nv] ([MaNv], [TenNv], [Mk]) VALUES (3, N'3', N'3')
SET IDENTITY_INSERT [dbo].[Sp] ON 

INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (2, 13, 1, N'Phím 1', NULL, 10000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (3, 14, 1, N'Phím 2', NULL, 20000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (4, 13, 1, N'Phím 1', NULL, 20000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (5, 14, 1, N'Phím 2', NULL, 20000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (6, 13, 1, N'Phím 1', NULL, 20000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (7, 14, 1, N'Phím 2', NULL, 30000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (8, 13, 1, N'Phím 1', NULL, 40000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (9, 14, 1, N'Phím 2', NULL, 50000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (10, 13, 1, N'Phím 1', NULL, 10000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (11, 14, 1, N'Phím 2', NULL, 20000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (12, 13, 1, N'Phím 1', NULL, 20000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (13, 14, 1, N'Phím 2', NULL, 20000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (14, 13, 1, N'Phím 1', NULL, 20000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (15, 14, 1, N'Phím 2', NULL, 30000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (16, 13, 1, N'Phím 1', NULL, 40000)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia]) VALUES (17, 14, 1, N'Phím 2', NULL, 50000)
SET IDENTITY_INSERT [dbo].[Sp] OFF
SET IDENTITY_INSERT [dbo].[SpLoai] ON 

INSERT [dbo].[SpLoai] ([MaLoaiSp], [MaNhomSp], [TenLoaiSp]) VALUES (13, 8, N'Phím cơ   ')
INSERT [dbo].[SpLoai] ([MaLoaiSp], [MaNhomSp], [TenLoaiSp]) VALUES (14, 8, N'Thường    ')
INSERT [dbo].[SpLoai] ([MaLoaiSp], [MaNhomSp], [TenLoaiSp]) VALUES (15, 9, N'Có dây    ')
INSERT [dbo].[SpLoai] ([MaLoaiSp], [MaNhomSp], [TenLoaiSp]) VALUES (16, 9, N'Không dây ')
INSERT [dbo].[SpLoai] ([MaLoaiSp], [MaNhomSp], [TenLoaiSp]) VALUES (22, 10, N'LCD       ')
INSERT [dbo].[SpLoai] ([MaLoaiSp], [MaNhomSp], [TenLoaiSp]) VALUES (23, 10, N'HD        ')
SET IDENTITY_INSERT [dbo].[SpLoai] OFF
SET IDENTITY_INSERT [dbo].[SpNhom] ON 

INSERT [dbo].[SpNhom] ([MaNhomSp], [TenNhomSp]) VALUES (8, N'Bàn phím')
INSERT [dbo].[SpNhom] ([MaNhomSp], [TenNhomSp]) VALUES (9, N'Chuột')
INSERT [dbo].[SpNhom] ([MaNhomSp], [TenNhomSp]) VALUES (10, N'Màn hình')
SET IDENTITY_INSERT [dbo].[SpNhom] OFF
INSERT [dbo].[Test] ([C1], [C2]) VALUES (1, N'1')
INSERT [dbo].[Test] ([C1], [C2]) VALUES (2, N'2')
INSERT [dbo].[Test] ([C1], [C2]) VALUES (3, N'3')
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_Kh] FOREIGN KEY([MaKh])
REFERENCES [dbo].[Kh] ([MaKh])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_Kh]
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_Sp] FOREIGN KEY([MaSp])
REFERENCES [dbo].[Sp] ([MaSp])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_Sp]
GO
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_KH] FOREIGN KEY([MaKh])
REFERENCES [dbo].[Kh] ([MaKh])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_KH]
GO
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_NV] FOREIGN KEY([MaNv])
REFERENCES [dbo].[Nv] ([MaNv])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_NV]
GO
ALTER TABLE [dbo].[Phieu]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_NV1] FOREIGN KEY([MaNv])
REFERENCES [dbo].[Nv] ([MaNv])
GO
ALTER TABLE [dbo].[Phieu] CHECK CONSTRAINT [FK_Phieu_NV1]
GO
ALTER TABLE [dbo].[PhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiao_Phieu] FOREIGN KEY([MaPhieuGiao])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuGiao] CHECK CONSTRAINT [FK_PhieuGiao_Phieu]
GO
ALTER TABLE [dbo].[PhieuHd]  WITH CHECK ADD  CONSTRAINT [FK_PhieuHD_Phieu] FOREIGN KEY([MaPhieuHd])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuHd] CHECK CONSTRAINT [FK_PhieuHD_Phieu]
GO
ALTER TABLE [dbo].[PhieuHdChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuHDChiTiet_PhieuHD] FOREIGN KEY([MaPhieuHd])
REFERENCES [dbo].[PhieuHd] ([MaPhieuHd])
GO
ALTER TABLE [dbo].[PhieuHdChiTiet] CHECK CONSTRAINT [FK_PhieuHDChiTiet_PhieuHD]
GO
ALTER TABLE [dbo].[PhieuHdChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuHDChiTiet_SP] FOREIGN KEY([MaSp])
REFERENCES [dbo].[Sp] ([MaSp])
GO
ALTER TABLE [dbo].[PhieuHdChiTiet] CHECK CONSTRAINT [FK_PhieuHDChiTiet_SP]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_Phieu] FOREIGN KEY([MaPn])
REFERENCES [dbo].[Phieu] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_Phieu]
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPn])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap]
GO
ALTER TABLE [dbo].[Sp]  WITH CHECK ADD  CONSTRAINT [FK_SP_NCC] FOREIGN KEY([MaNcc])
REFERENCES [dbo].[Ncc] ([MaNcc])
GO
ALTER TABLE [dbo].[Sp] CHECK CONSTRAINT [FK_SP_NCC]
GO
ALTER TABLE [dbo].[Sp]  WITH CHECK ADD  CONSTRAINT [FK_SP_SPLoai] FOREIGN KEY([MaLoaiSp])
REFERENCES [dbo].[SpLoai] ([MaLoaiSp])
GO
ALTER TABLE [dbo].[Sp] CHECK CONSTRAINT [FK_SP_SPLoai]
GO
ALTER TABLE [dbo].[SpLoai]  WITH CHECK ADD  CONSTRAINT [FK_SPLoai_SPNhom] FOREIGN KEY([MaNhomSp])
REFERENCES [dbo].[SpNhom] ([MaNhomSp])
GO
ALTER TABLE [dbo].[SpLoai] CHECK CONSTRAINT [FK_SPLoai_SPNhom]
GO
