USE [QLBH_Win]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 3/19/2019 1:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GioHang](
	[MaGioHang] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Kh]    Script Date: 3/19/2019 1:39:30 PM ******/
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
/****** Object:  Table [dbo].[Ncc]    Script Date: 3/19/2019 1:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ncc](
	[MaNcc] [int] IDENTITY(1,1) NOT NULL,
	[TenNcc] [nvarchar](255) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nv]    Script Date: 3/19/2019 1:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nv](
	[MaNv] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[PhieuGiao]    Script Date: 3/19/2019 1:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiao](
	[MaPhieuGiao] [int] IDENTITY(1,1) NOT NULL,
	[MaNv] [int] NULL,
	[MaKh] [int] NULL,
	[MaPhieuHd] [int] NULL,
	[DiaChiGiao] [nvarchar](255) NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_PhieuGiao] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuGiaoChiTiet]    Script Date: 3/19/2019 1:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiaoChiTiet](
	[MaPhieuGiao] [int] NOT NULL,
	[MaSp] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_PhieuGiaoChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGiao] ASC,
	[MaSp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuHd]    Script Date: 3/19/2019 1:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuHd](
	[MaPhieuHd] [int] IDENTITY(1,1) NOT NULL,
	[MaKh] [int] NULL,
	[MaNv] [int] NULL,
	[NgayTaoHd] [datetime] NULL,
 CONSTRAINT [PK_PhieuHD] PRIMARY KEY CLUSTERED 
(
	[MaPhieuHd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuHdChiTiet]    Script Date: 3/19/2019 1:39:30 PM ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 3/19/2019 1:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPn] [int] IDENTITY(1,1) NOT NULL,
	[MaNv] [int] NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_PhN] PRIMARY KEY CLUSTERED 
(
	[MaPn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhapChiTiet]    Script Date: 3/19/2019 1:39:30 PM ******/
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
/****** Object:  Table [dbo].[Sp]    Script Date: 3/19/2019 1:39:30 PM ******/
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
	[SoLuongTonKho] [int] NULL,
 CONSTRAINT [PK_SP] PRIMARY KEY CLUSTERED 
(
	[MaSp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SpLoai]    Script Date: 3/19/2019 1:39:30 PM ******/
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
/****** Object:  Table [dbo].[SpNhom]    Script Date: 3/19/2019 1:39:30 PM ******/
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
SET IDENTITY_INSERT [dbo].[GioHang] ON 

INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (1, 2, NULL, 1, N'192.168.0.101')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (2, 10, NULL, 1, N'192.168.0.101')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (3, 10, NULL, 1, N'192.168.0.101')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (4, 10, NULL, 1, N'192.168.0.101')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (5, 10, NULL, 1, N'192.168.0.101')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (6, 10, NULL, 1, N'192.168.0.101')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (7, 10, NULL, 1, N'192.168.0.101')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (8, 10, NULL, 1, N'192.168.8.100')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (9, 3, NULL, 1, N'192.168.8.100')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (10, 9, NULL, 1, N'192.168.8.100')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (11, 2, NULL, 1, N'192.168.1.14')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (12, 2, NULL, 1, N'192.168.0.14')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (13, 5, NULL, 1, N'192.168.0.14')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (14, 4, NULL, 1, N'192.168.0.14')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (15, 2, NULL, 1, N'192.168.8.101')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (16, 4, NULL, 1, N'192.168.8.101')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (24, 3, NULL, 2, N'192.168.1.139')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (29, 2, 1, 9, NULL)
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (30, 3, 1, 1, NULL)
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (32, 2, 6, 1, NULL)
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (33, 9, NULL, 1, N'169.254.62.187')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (34, 12, NULL, 8, N'192.168.93.1')
INSERT [dbo].[GioHang] ([MaGioHang], [MaSp], [MaKh], [SoLuong], [DiaChiIp]) VALUES (35, 2, NULL, 1, N'192.168.0.16')
SET IDENTITY_INSERT [dbo].[GioHang] OFF
SET IDENTITY_INSERT [dbo].[Kh] ON 

INSERT [dbo].[Kh] ([MaKh], [TenKh], [Email], [MatKhau]) VALUES (1, N'1', N'1@1.1', N'c4ca4238a0b923820dcc509a6f75849b')
INSERT [dbo].[Kh] ([MaKh], [TenKh], [Email], [MatKhau]) VALUES (4, N'DoanHien', N',admin@admin.com', N',123')
INSERT [dbo].[Kh] ([MaKh], [TenKh], [Email], [MatKhau]) VALUES (5, N'', N'2', N'c81e728d9d4c2f636f067f89cc14862c')
INSERT [dbo].[Kh] ([MaKh], [TenKh], [Email], [MatKhau]) VALUES (6, N'3', N'3', N'eccbc87e4b5ce2fe28308fd9f2a7baf3')
SET IDENTITY_INSERT [dbo].[Kh] OFF
SET IDENTITY_INSERT [dbo].[Ncc] ON 

INSERT [dbo].[Ncc] ([MaNcc], [TenNcc]) VALUES (1, N'ASUS')
INSERT [dbo].[Ncc] ([MaNcc], [TenNcc]) VALUES (2, N'DELL')
INSERT [dbo].[Ncc] ([MaNcc], [TenNcc]) VALUES (3, N'APPLE')
SET IDENTITY_INSERT [dbo].[Ncc] OFF
SET IDENTITY_INSERT [dbo].[Nv] ON 

INSERT [dbo].[Nv] ([MaNv], [TenNv], [Mk]) VALUES (1, N'1', N'1')
INSERT [dbo].[Nv] ([MaNv], [TenNv], [Mk]) VALUES (2, N'2', N'2')
INSERT [dbo].[Nv] ([MaNv], [TenNv], [Mk]) VALUES (3, N'3', N'3')
SET IDENTITY_INSERT [dbo].[Nv] OFF
SET IDENTITY_INSERT [dbo].[PhieuGiao] ON 

INSERT [dbo].[PhieuGiao] ([MaPhieuGiao], [MaNv], [MaKh], [MaPhieuHd], [DiaChiGiao], [NgayLap]) VALUES (1, NULL, NULL, 1, N'113A', NULL)
SET IDENTITY_INSERT [dbo].[PhieuGiao] OFF
INSERT [dbo].[PhieuGiaoChiTiet] ([MaPhieuGiao], [MaSp], [SoLuong]) VALUES (1, 2, 50)
SET IDENTITY_INSERT [dbo].[PhieuHd] ON 

INSERT [dbo].[PhieuHd] ([MaPhieuHd], [MaKh], [MaNv], [NgayTaoHd]) VALUES (1, 1, NULL, CAST(0x000003E700000000 AS DateTime))
INSERT [dbo].[PhieuHd] ([MaPhieuHd], [MaKh], [MaNv], [NgayTaoHd]) VALUES (2, NULL, 1, NULL)
INSERT [dbo].[PhieuHd] ([MaPhieuHd], [MaKh], [MaNv], [NgayTaoHd]) VALUES (3, NULL, 1, NULL)
INSERT [dbo].[PhieuHd] ([MaPhieuHd], [MaKh], [MaNv], [NgayTaoHd]) VALUES (4, NULL, 1, NULL)
INSERT [dbo].[PhieuHd] ([MaPhieuHd], [MaKh], [MaNv], [NgayTaoHd]) VALUES (5, NULL, 1, NULL)
INSERT [dbo].[PhieuHd] ([MaPhieuHd], [MaKh], [MaNv], [NgayTaoHd]) VALUES (6, NULL, 1, NULL)
INSERT [dbo].[PhieuHd] ([MaPhieuHd], [MaKh], [MaNv], [NgayTaoHd]) VALUES (7, NULL, 1, NULL)
INSERT [dbo].[PhieuHd] ([MaPhieuHd], [MaKh], [MaNv], [NgayTaoHd]) VALUES (8, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[PhieuHd] OFF
INSERT [dbo].[PhieuHdChiTiet] ([MaPhieuHd], [MaSp], [SoLuong], [ThanhTien]) VALUES (2, 2, 2, 20000)
INSERT [dbo].[PhieuHdChiTiet] ([MaPhieuHd], [MaSp], [SoLuong], [ThanhTien]) VALUES (3, 2, 1, 10000)
INSERT [dbo].[PhieuHdChiTiet] ([MaPhieuHd], [MaSp], [SoLuong], [ThanhTien]) VALUES (4, 2, 1, 10000)
INSERT [dbo].[PhieuHdChiTiet] ([MaPhieuHd], [MaSp], [SoLuong], [ThanhTien]) VALUES (5, 2, 2, 20000)
INSERT [dbo].[PhieuHdChiTiet] ([MaPhieuHd], [MaSp], [SoLuong], [ThanhTien]) VALUES (6, 2, 12, 120000)
INSERT [dbo].[PhieuHdChiTiet] ([MaPhieuHd], [MaSp], [SoLuong], [ThanhTien]) VALUES (7, 2, 1, 10000)
INSERT [dbo].[PhieuHdChiTiet] ([MaPhieuHd], [MaSp], [SoLuong], [ThanhTien]) VALUES (8, 2, 2, 20000)
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([MaPn], [MaNv], [NgayLap]) VALUES (1, 1, NULL)
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
INSERT [dbo].[PhieuNhapChiTiet] ([MaPhieuNhap], [MaSp], [SoLuong]) VALUES (1, 2, 100)
SET IDENTITY_INSERT [dbo].[Sp] ON 

INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (2, 13, 1, N'Phím cơ 1', N'1.jpg', 10000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (3, 14, 1, N'Phím thường 1', N'1.jpg', 20000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (4, 13, 1, N'Phím cơ 2', N'1.jpg', 20000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (5, 14, 1, N'Phím thường 2', N'1.jpg', 20000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (6, 13, 1, N'Phím cơ 3', N'1.jpg', 20000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (7, 14, 1, N'Phím thường 3', N'1.jpg', 30000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (8, 13, 1, N'Phím 1', N'1.jpg', 40000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (9, 14, 1, N'Phím thường 4', N'1.jpg', 50000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (10, 13, 1, N'Phím cơ 5', N'1.jpg', 10000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (11, 14, 1, N'Phím thường 5', N'1.jpg', 20000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (12, 13, 1, N'Phím cơ 6', N'1.jpg', 20000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (13, 14, 1, N'Phím thường 6', N'1.jpg', 20000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (14, 13, 1, N'Phím cơ 7', N'1.jpg', 20000, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (15, 14, 1, N'Phím thường 7', N'1.jpg', 1, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (18, 13, 1, N'Test 1', NULL, 2, NULL)
INSERT [dbo].[Sp] ([MaSp], [MaLoaiSp], [MaNcc], [TenSp], [HinhSp], [DonGia], [SoLuongTonKho]) VALUES (19, 13, 1, N'Phim test', NULL, 2000, NULL)
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
ALTER TABLE [dbo].[PhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiao_Kh] FOREIGN KEY([MaKh])
REFERENCES [dbo].[Kh] ([MaKh])
GO
ALTER TABLE [dbo].[PhieuGiao] CHECK CONSTRAINT [FK_PhieuGiao_Kh]
GO
ALTER TABLE [dbo].[PhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiao_Nv] FOREIGN KEY([MaNv])
REFERENCES [dbo].[Nv] ([MaNv])
GO
ALTER TABLE [dbo].[PhieuGiao] CHECK CONSTRAINT [FK_PhieuGiao_Nv]
GO
ALTER TABLE [dbo].[PhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiao_PhieuHd] FOREIGN KEY([MaPhieuHd])
REFERENCES [dbo].[PhieuHd] ([MaPhieuHd])
GO
ALTER TABLE [dbo].[PhieuGiao] CHECK CONSTRAINT [FK_PhieuGiao_PhieuHd]
GO
ALTER TABLE [dbo].[PhieuGiao]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiao_PhieuHd1] FOREIGN KEY([MaPhieuHd])
REFERENCES [dbo].[PhieuHd] ([MaPhieuHd])
GO
ALTER TABLE [dbo].[PhieuGiao] CHECK CONSTRAINT [FK_PhieuGiao_PhieuHd1]
GO
ALTER TABLE [dbo].[PhieuGiaoChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoChiTiet_PhieuGiao] FOREIGN KEY([MaPhieuGiao])
REFERENCES [dbo].[PhieuGiao] ([MaPhieuGiao])
GO
ALTER TABLE [dbo].[PhieuGiaoChiTiet] CHECK CONSTRAINT [FK_PhieuGiaoChiTiet_PhieuGiao]
GO
ALTER TABLE [dbo].[PhieuGiaoChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoChiTiet_Sp] FOREIGN KEY([MaSp])
REFERENCES [dbo].[Sp] ([MaSp])
GO
ALTER TABLE [dbo].[PhieuGiaoChiTiet] CHECK CONSTRAINT [FK_PhieuGiaoChiTiet_Sp]
GO
ALTER TABLE [dbo].[PhieuHd]  WITH CHECK ADD  CONSTRAINT [FK_PhieuHd_Kh] FOREIGN KEY([MaKh])
REFERENCES [dbo].[Kh] ([MaKh])
GO
ALTER TABLE [dbo].[PhieuHd] CHECK CONSTRAINT [FK_PhieuHd_Kh]
GO
ALTER TABLE [dbo].[PhieuHd]  WITH CHECK ADD  CONSTRAINT [FK_PhieuHd_Nv] FOREIGN KEY([MaNv])
REFERENCES [dbo].[Nv] ([MaNv])
GO
ALTER TABLE [dbo].[PhieuHd] CHECK CONSTRAINT [FK_PhieuHd_Nv]
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
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_Nv] FOREIGN KEY([MaNv])
REFERENCES [dbo].[Nv] ([MaNv])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_Nv]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_Nv1] FOREIGN KEY([MaNv])
REFERENCES [dbo].[Nv] ([MaNv])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_Nv1]
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPn])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_PhieuNhap]
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapChiTiet_Sp] FOREIGN KEY([MaSp])
REFERENCES [dbo].[Sp] ([MaSp])
GO
ALTER TABLE [dbo].[PhieuNhapChiTiet] CHECK CONSTRAINT [FK_PhieuNhapChiTiet_Sp]
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
