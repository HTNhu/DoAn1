USE [master]
GO
/****** Object:  Database [PTUD_DHKTPM12A_DOAN_NHOM04]    Script Date: 27/10/2018 10:50:58 CH ******/
CREATE DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanXeMay', FILENAME = N'D:\desk\QuanLyBanXeMay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanXeMay_log', FILENAME = N'D:\desk\QuanLyBanXeMay_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PTUD_DHKTPM12A_DOAN_NHOM04].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET ARITHABORT OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET  MULTI_USER 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [PTUD_DHKTPM12A_DOAN_NHOM04]
GO
/****** Object:  Table [dbo].[CT_HoaDon]    Script Date: 27/10/2018 10:50:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HoaDon](
	[MaHoaDon] [nchar](10) NOT NULL,
	[MaHopDong] [nchar](10) NOT NULL,
	[MaXe] [nchar](10) NOT NULL,
	[TenXe] [nvarchar](30) NULL,
	[Gia] [money] NULL,
	[TienTT] [money] NULL,
 CONSTRAINT [PK_HopDong_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC,
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PhieuSua]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuSua](
	[MaPhieuSua] [nchar](10) NULL,
	[MaLK] [nchar](5) NULL,
	[TenLK] [nvarchar](30) NULL,
	[SoLuong] [int] NULL,
	[GiaTien] [money] NULL,
	[MaCTPS] [nchar](10) NOT NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_CT_PhieuSua] PRIMARY KEY CLUSTERED 
(
	[MaCTPS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[MaNV] [nchar](10) NOT NULL,
	[TienThanhToan] [money] NULL,
	[TongTien] [money] NULL,
	[KhuyenMai] [float] NOT NULL,
	[TenNV] [nchar](30) NULL,
	[SdtKH] [nchar](12) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHopDong] [nchar](10) NOT NULL,
	[TenXe] [nvarchar](30) NULL,
	[Gia] [money] NULL,
	[HanBH] [date] NULL,
	[HinhThucTT] [int] NOT NULL,
	[NgayLap] [date] NULL,
	[TenKH] [nvarchar](30) NULL,
	[TinhTrang] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaKH] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](30) NULL,
 CONSTRAINT [PK_HopDong] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nchar](12) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LinhKien]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LinhKien](
	[MaLK] [nchar](5) NOT NULL,
	[TenLK] [nvarchar](30) NULL,
	[Loai] [nvarchar](30) NULL,
	[GiaTien] [money] NULL,
 CONSTRAINT [PK_LinhKien] PRIMARY KEY CLUSTERED 
(
	[MaLK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](30) NULL,
	[SDT] [nchar](12) NULL,
	[CaLam] [nchar](10) NULL,
	[ChucVu] [nchar](2) NULL,
	[DiaChi] [nvarchar](30) NULL,
	[CMND] [nchar](12) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuSuaBH]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuSuaBH](
	[MaPhieuSua] [nchar](10) NOT NULL,
	[LoiDoKhachHaySP] [bit] NULL,
	[MaHopDong] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[TenNV] [nvarchar](30) NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_phieusuabh] PRIMARY KEY CLUSTERED 
(
	[MaPhieuSua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuTraGop]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTraGop](
	[MaHopDong] [nchar](10) NOT NULL,
	[LanTra] [int] NOT NULL,
	[NgayTra] [date] NULL,
	[NhanVienNhan] [nvarchar](30) NULL,
	[SoTienTG] [money] NULL,
	[TenNguoiTra] [nvarchar](30) NULL,
	[MaNV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_phieutragop] PRIMARY KEY CLUSTERED 
(
	[MaHopDong] ASC,
	[LanTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaNV] [nchar](10) NOT NULL,
	[TenTK] [nvarchar](30) NULL,
	[MatKhau] [nvarchar](30) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [nchar](10) NOT NULL,
	[LoaiXe] [nvarchar](30) NULL,
	[MauXe] [nvarchar](30) NULL,
	[GiaXe] [money] NULL,
	[NuocSX] [nvarchar](30) NULL,
	[SoKhung] [nvarchar](30) NULL,
	[SoSuon] [nvarchar](30) NULL,
	[SoPK] [nvarchar](30) NULL,
	[TinhTrang] [bit] NULL,
	[TenXe] [nvarchar](30) NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH001  ', N'HDX-001   ', N'XE006     ', N'Kawashaki1000', 120000000.0000, 40000000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH002  ', N'HDX-002   ', N'XE002     ', N'dream', 30000000.0000, 15000000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH003  ', N'HDX-006   ', N'XE008     ', N'Grande', 38000000.0000, 38000000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH004  ', N'HDX-007   ', N'XE009     ', N'Cup', 23000000.0000, 23000000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH005  ', N'HDX-008   ', N'XE001     ', N'vision', 45000000.0000, 45000000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH006  ', N'HDX-009   ', N'XE004     ', N'wave', 43000000.0000, 43000000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH010  ', N'HDX-013   ', N'XE005     ', N'Jupiter', 28000000.0000, 28000000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH011  ', N'HDX-014   ', N'XE007     ', N'Ducati', 300000000.0000, 150000000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH012  ', N'HDX-015   ', N'XE003     ', N'Sh', 35000000.0000, 17500000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH013  ', N'HDX-016   ', N'XE010     ', N'Cub', 15000000.0000, 7500000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH014  ', N'HDX-017   ', N'XE011     ', N'Jupiter', 30000000.0000, 15000000.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH015  ', N'HDX-018   ', N'XE012     ', N'Cub', 22000000.0000, 7333333.0000)
INSERT [dbo].[CT_HoaDon] ([MaHoaDon], [MaHopDong], [MaXe], [TenXe], [Gia], [TienTT]) VALUES (N'HD-BH016  ', N'HDX-020   ', N'XE021     ', N'vision', 39000000.0000, 13000000.0000)
INSERT [dbo].[CT_PhieuSua] ([MaPhieuSua], [MaLK], [TenLK], [SoLuong], [GiaTien], [MaCTPS], [ThanhTien]) VALUES (N'PS001     ', N'LK001', N'Bo xe', 1, 450.0000, N'CTPS001   ', 450.0000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH001  ', CAST(N'2018-10-15' AS Date), N'KH008     ', N'Thái Lâm', N'NV005     ', 120000000.0000, 120000000.0000, 0, N' Hồ Tuấn Anh                  ', NULL)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH002  ', CAST(N'2018-10-15' AS Date), N'KH012     ', N'Ngô Sang Thái', N'NV004     ', 30000000.0000, 30000000.0000, 0, N' Hoàng Hữu Cương              ', N'XE002       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH003  ', CAST(N'2018-10-16' AS Date), N'KH009     ', N'Lê Thị Hồng', N'NV001     ', 38000000.0000, 38000000.0000, 0, N' Hồ Trần Như                  ', N'XE008       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH004  ', CAST(N'2018-10-16' AS Date), N'KH004     ', N'Trương Thị Mỹ Tân', N'NV001     ', 23000000.0000, 23000000.0000, 0, N' Hồ Trần Như                  ', N'XE009       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH005  ', CAST(N'2018-10-16' AS Date), N'KH002     ', N'Hồ Văn Tâm', N'NV001     ', 45000000.0000, 45000000.0000, 0, N' Hồ Trần Như                  ', N'XE001       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH006  ', CAST(N'2018-10-16' AS Date), N'KH002     ', N'Hồ Văn Tâm', N'NV001     ', 43000000.0000, 43000000.0000, 0, N' Hồ Trần Như                  ', N'XE004       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH007  ', CAST(N'2018-10-17' AS Date), N'KH008     ', N'Thái Lâm', N'NV001     ', 35000000.0000, 35000000.0000, 0, N' Hồ Trần Như                  ', N'XE003       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH008  ', CAST(N'2018-10-17' AS Date), N'KH010     ', N'Le Đạt', N'NV001     ', 300000000.0000, 300000000.0000, 0, N' Hồ Trần Như                  ', N'XE007       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH009  ', CAST(N'2018-10-17' AS Date), N'KH007     ', N'Hà Đình Kiên', N'NV001     ', 28000000.0000, 28000000.0000, 0, N' Hồ Trần Như                  ', N'XE005       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH010  ', CAST(N'2018-10-17' AS Date), N'KH005     ', N'Hồ Tuấn Kiệt', N'NV001     ', 28000000.0000, 28000000.0000, 0, N' Hồ Trần Như                  ', N'XE005       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH011  ', CAST(N'2018-10-17' AS Date), N'KH014     ', N'Nguyễn Lai Lai', N'NV001     ', 300000000.0000, 300000000.0000, 0, N' Hồ Trần Như                  ', N'XE007       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH012  ', CAST(N'2018-10-17' AS Date), N'KH004     ', N'Trương Thị Mỹ Tân', N'NV001     ', 35000000.0000, 35000000.0000, 0, N' Hồ Trần Như                  ', N'XE003       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH013  ', CAST(N'2018-10-24' AS Date), N'KH004     ', N'Trương Thị Mỹ Tân', N'NV001     ', 15000000.0000, 15000000.0000, 0, N' Hồ Trần Như                  ', N'XE010       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH014  ', CAST(N'2018-10-24' AS Date), N'KH017     ', N'Trunght', N'NV001     ', 30000000.0000, 30000000.0000, 0, N' Hồ Trần Như                  ', N'XE011       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH015  ', CAST(N'2018-10-24' AS Date), N'KH017     ', N'Trunght', N'NV001     ', 22000000.0000, 22000000.0000, 0, N' Hồ Trần Như                  ', N'XE012       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaKH], [TenKH], [MaNV], [TienThanhToan], [TongTien], [KhuyenMai], [TenNV], [SdtKH]) VALUES (N'HD-BH016  ', CAST(N'2018-10-27' AS Date), N'KH002     ', N'Hồ Văn Tâm', N'NV004     ', 39000000.0000, 39000000.0000, 0, N' Hoàng Hữu Cương              ', N'            ')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-001   ', N'Kawashaki1000', 120000000.0000, CAST(N'2019-03-30' AS Date), 3, CAST(N'2018-10-15' AS Date), N'Thái Lâm', N'Đã thanh toán lần 2', N'4 An DươngVuong', N'KH008     ', N' Hồ Tuấn Anh')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-002   ', N'dream', 30000000.0000, CAST(N'2019-02-13' AS Date), 2, CAST(N'2018-10-15' AS Date), N'Ngô Sang Thái', N'Đã hoàn thành', N'150 Nguyễn Thị Đặng quận 12', N'KH012     ', N' Hoàng Hữu Cương')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-003   ', N'wave', 43000000.0000, CAST(N'2018-10-25' AS Date), 1, CAST(N'2018-10-16' AS Date), N'Lê Thị Mỹ Duyên', N'Đã hủy', N'21 Dương Thị Mười quận 12', N'KH003     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-004   ', N'wave', 43000000.0000, CAST(N'2018-10-17' AS Date), 1, CAST(N'2018-10-16' AS Date), N'Lê Thị Mỹ Duyên', N'Đã hủy', N'21 Dương Thị Mười quận 12', N'KH003     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-005   ', N'wave', 43000000.0000, CAST(N'2018-10-17' AS Date), 2, CAST(N'2018-10-16' AS Date), N'Lê Thị Mỹ Duyên', N'Đã hủy', N'21 Dương Thị Mười quận 12', N'KH003     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-006   ', N'Grande', 38000000.0000, CAST(N'2018-10-26' AS Date), 1, CAST(N'2018-10-16' AS Date), N'Lê Thị Hồng', N'Đã hoàn thành', N'4 Quang Traung', N'KH009     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-007   ', N'Cup', 23000000.0000, CAST(N'2018-10-17' AS Date), 1, CAST(N'2018-10-16' AS Date), N'Trương Thị Mỹ Tân', N'Đã hoàn thành', N'221 Dương Quảng Hàm quận Gò Vấp', N'KH004     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-008   ', N'vision', 45000000.0000, CAST(N'2018-10-17' AS Date), 1, CAST(N'2018-10-16' AS Date), N'Hồ Văn Tâm', N'Đã hủy', N'32 Quang Trung quận Gò Vấp', N'KH002     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-009   ', N'wave', 43000000.0000, CAST(N'2018-10-17' AS Date), 1, CAST(N'2018-10-16' AS Date), N'Hồ Văn Tâm', N'Đã hoàn thành', N'32 Quang Trung quận Gò Vấp', N'KH002     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-010   ', N'Sh', 35000000.0000, CAST(N'2019-10-17' AS Date), 3, CAST(N'2018-10-17' AS Date), N'Thái Lâm', N'Đã thanh toán lần 1', N'4 An DươngVuong', N'KH008     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-011   ', N'Ducati', 300000000.0000, CAST(N'2019-10-17' AS Date), 2, CAST(N'2018-10-17' AS Date), N'Le Đạt', N'Đã thanh toán lần 1', N'ry reyt reyre', N'KH010     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-012   ', N'Jupiter', 28000000.0000, CAST(N'2019-10-17' AS Date), 2, CAST(N'2018-10-17' AS Date), N'Hà Đình Kiên', N'Đã thanh toán lần 1', N'43 Nguyễn Thái Sơn', N'KH007     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-013   ', N'Jupiter', 28000000.0000, CAST(N'2019-10-17' AS Date), 1, CAST(N'2018-10-17' AS Date), N'Hồ Tuấn Kiệt', N'Đã hoàn thành', N'1/23 Nguyễn Đình Chiểu quận Phú Nhuận', N'KH005     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-014   ', N'Ducati', 300000000.0000, CAST(N'2019-10-17' AS Date), 2, CAST(N'2018-10-17' AS Date), N'Nguyễn Lai Lai', N'Đã thanh toán lần 1', N'13 Lê Lai', N'KH014     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-015   ', N'Sh', 35000000.0000, CAST(N'2019-10-17' AS Date), 2, CAST(N'2018-10-17' AS Date), N'Trương Thị Mỹ Tân', N'Đã hoàn thành', N'221 Dương Quảng Hàm quận Gò Vấp', N'KH004     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-016   ', N'Cub', 15000000.0000, CAST(N'2019-10-24' AS Date), 2, CAST(N'2018-10-24' AS Date), N'Trương Thị Mỹ Tân', N'Đã thanh toán lần 1', N'221 Dương Quảng Hàm quận Gò Vấp', N'KH004     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-017   ', N'Jupiter', 30000000.0000, CAST(N'2019-10-24' AS Date), 2, CAST(N'2018-10-24' AS Date), N'Trunght', N'Đã thanh toán lần 1', N'150 Nguyễn Thị Đặng quận 12', N'KH017     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-018   ', N'Cub', 22000000.0000, CAST(N'2019-10-24' AS Date), 3, CAST(N'2018-10-24' AS Date), N'Trunght', N'Đã hoàn thành', N'q12', N'KH017     ', N' Hồ Trần Như')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-019   ', N'jupiter', 27000000.0000, CAST(N'2019-10-27' AS Date), 3, CAST(N'2018-10-27' AS Date), N'Lê Thị Mỹ Duyên', N'Đã hủy', N'21 Dương Thị Mười quận 12', N'KH003     ', N' Hoàng Hữu Cương')
INSERT [dbo].[HopDong] ([MaHopDong], [TenXe], [Gia], [HanBH], [HinhThucTT], [NgayLap], [TenKH], [TinhTrang], [DiaChi], [MaKH], [TenNV]) VALUES (N'HDX-020   ', N'vision', 39000000.0000, CAST(N'2019-10-27' AS Date), 3, CAST(N'2018-10-27' AS Date), N'Hồ Văn Tâm', N'Đã thanh toán lần 1', N'32 Quang Trung quận Gò Vấp', N'KH002     ', N' Hoàng Hữu Cương')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH001     ', N'Trần Thị Hoa', N'150 Nguyễn Thị Đặng quận 12', N'0906575662  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH002     ', N'Hồ Văn Tâm', N'32 Quang Trung quận Gò Vấp', N'0938787523  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH003     ', N'Lê Thị Mỹ Duyên', N'21 Dương Thị Mười quận 12', N'0903984455  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH004     ', N'Trương Thị Mỹ Tân', N'221 Dương Quảng Hàm quận Gò Vấp', N'0364953556  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH005     ', N'Hồ Tuấn Kiệt', N'1/23 Nguyễn Đình Chiểu quận Phú Nhuận', N'0353243243  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH006     ', N'Nguyễn Thu Thảo', N'32 DaKao', N'0994354354  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH007     ', N'Hà Đình Kiên', N'43 Nguyễn Thái Sơn', N'0364556167  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH008     ', N'Thái Lâm', N'4 An DươngVuong', N'0938559833  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH009     ', N'Lê Thị Hồng', N'4 Quang Traung', N'0123456745  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH010     ', N'Le Đạt', N'45/9 Xóm Chiếu', N'0932222312  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH011     ', N'Phạm Ngọc Ý', N'4 Lê Văn Khương', N'0977723434  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH012     ', N'Ngô Sang Thái', N'45/76 Dương Quảng Hàm', N'0342425666  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH013     ', N'Hồ Thúy Nga', N'23 Quang Trung', N'0995345677  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH014     ', N'Nguyễn Lai Lai', N'13 Lê Lai', N'0957733455  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH015     ', N'Lai Giang', N'3 Quang Trung', N'0995656346  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH016     ', N'Diễm My', N'54 Nguyễn Thị MinhKhai', N'0997868686  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH017     ', N'Trunght', N'q12', N'0334638903  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [SDT]) VALUES (N'KH018     ', N' ty tyu', N'6 tyuty', N'0990908989  ')
INSERT [dbo].[LinhKien] ([MaLK], [TenLK], [Loai], [GiaTien]) VALUES (N'LK001', N'bô xe', N'sym', 540000.0000)
INSERT [dbo].[LinhKien] ([MaLK], [TenLK], [Loai], [GiaTien]) VALUES (N'LK002', N'yên xe', N'yamaha', 200000.0000)
INSERT [dbo].[LinhKien] ([MaLK], [TenLK], [Loai], [GiaTien]) VALUES (N'LK003', N'kèn xe', N'suzuki', 120000.0000)
INSERT [dbo].[LinhKien] ([MaLK], [TenLK], [Loai], [GiaTien]) VALUES (N'LK004', N'gương chiếu hậu', N'yamaha', 80000.0000)
INSERT [dbo].[LinhKien] ([MaLK], [TenLK], [Loai], [GiaTien]) VALUES (N'LK005', N'giỏ xe', N'sym', 100000.0000)
INSERT [dbo].[LinhKien] ([MaLK], [TenLK], [Loai], [GiaTien]) VALUES (N'LK006', N'mâm xe', N'suzuki', 250000.0000)
INSERT [dbo].[LinhKien] ([MaLK], [TenLK], [Loai], [GiaTien]) VALUES (N'LK007', N'vỏ xe', N'yamaha', 150000.0000)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [CaLam], [ChucVu], [DiaChi], [CMND], [TinhTrang]) VALUES (N'NV001     ', N'Hồ Trần Như', N'0355983234  ', N'Ca Chiều  ', N'bh', N'150 Nguyễn Thị Đặng quận ', N'004654656564', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [CaLam], [ChucVu], [DiaChi], [CMND], [TinhTrang]) VALUES (N'NV002     ', N'Thái Thành An', N'0983843845  ', N'Ca sáng   ', N'ql', N'34 Nguyễn Thị Minh Khai', N'092843284354', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [CaLam], [ChucVu], [DiaChi], [CMND], [TinhTrang]) VALUES (N'NV003     ', N'Lê Thành Kỷ', N'0981075901  ', N'Ca Chiều  ', N'kt', N'43 Hồ Văn Huê', N'934838438434', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [CaLam], [ChucVu], [DiaChi], [CMND], [TinhTrang]) VALUES (N'NV004     ', N'Hoàng Hữu Cương', N'0938123133  ', N'Ca Chiều  ', N'bh', N'77 Nguyễn Văn Bảo', N'056878785787', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [CaLam], [ChucVu], [DiaChi], [CMND], [TinhTrang]) VALUES (N'NV005     ', N'Hồ Tuấn Anh', N'0932458112  ', N'Ca Chiều  ', N'bh', N'7 Quang Trung', N'009349344345', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [CaLam], [ChucVu], [DiaChi], [CMND], [TinhTrang]) VALUES (N'NV006     ', N'Trần Quang Phúc', N'0354395452  ', N'Ca Sáng   ', N'kt', N'4398/9 Dươn Quảng Hàm', N'007657658686', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [CaLam], [ChucVu], [DiaChi], [CMND], [TinhTrang]) VALUES (N'NV007     ', N'Ngô Thái Sang', N'0909823432  ', N'Ca Chiều  ', N'bh', N'98 Huỳnh Tấn Phát', N'009435334245', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [CaLam], [ChucVu], [DiaChi], [CMND], [TinhTrang]) VALUES (N'NV008     ', N'Mỹ Yến', N'0879797866  ', N'Ca Sáng   ', N'bh', N'34 Phú Thọ', N'124215435675', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [CaLam], [ChucVu], [DiaChi], [CMND], [TinhTrang]) VALUES (N'NV009     ', N'Ngô Hải My', N'0945645645  ', N'Ca Sáng   ', N'bh', N'23 Ngô Gia Tự', N'005469345354', 1)
INSERT [dbo].[PhieuSuaBH] ([MaPhieuSua], [LoiDoKhachHaySP], [MaHopDong], [MaNV], [NgayLap], [TenNV], [TongTien]) VALUES (N'PS001     ', 1, N'HDX-001   ', N'NV001     ', CAST(N'2018-09-10' AS Date), N'Như Hồ', 300.0000)
INSERT [dbo].[PhieuTraGop] ([MaHopDong], [LanTra], [NgayTra], [NhanVienNhan], [SoTienTG], [TenNguoiTra], [MaNV]) VALUES (N'HDX-001   ', 2, CAST(N'2018-10-15' AS Date), N' Hồ Trần Như', 40000000.0000, N'Thái Lâm', N'NV001     ')
INSERT [dbo].[PhieuTraGop] ([MaHopDong], [LanTra], [NgayTra], [NhanVienNhan], [SoTienTG], [TenNguoiTra], [MaNV]) VALUES (N'HDX-002   ', 2, CAST(N'2019-01-15' AS Date), N' Hoàng Hữu Cương', 15000000.0000, N'Tuyết Diễm', N'NV004     ')
INSERT [dbo].[PhieuTraGop] ([MaHopDong], [LanTra], [NgayTra], [NhanVienNhan], [SoTienTG], [TenNguoiTra], [MaNV]) VALUES (N'HDX-015   ', 2, CAST(N'2018-10-23' AS Date), N' Hồ Trần Như', 17500000.0000, N'Van Trang', N'NV001     ')
INSERT [dbo].[PhieuTraGop] ([MaHopDong], [LanTra], [NgayTra], [NhanVienNhan], [SoTienTG], [TenNguoiTra], [MaNV]) VALUES (N'HDX-018   ', 2, CAST(N'2019-01-24' AS Date), N' Hồ Trần Như', 7333333.0000, N'TrungHT', N'NV001     ')
INSERT [dbo].[PhieuTraGop] ([MaHopDong], [LanTra], [NgayTra], [NhanVienNhan], [SoTienTG], [TenNguoiTra], [MaNV]) VALUES (N'HDX-018   ', 3, CAST(N'2019-01-24' AS Date), N' Hồ Trần Như', 7333333.0000, N'TRUNGHT', N'NV001     ')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenTK], [MatKhau]) VALUES (N'NV001     ', N'hotrannhu', N'nhunhu98')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenTK], [MatKhau]) VALUES (N'NV002     ', N'thaithanhan', N'anan98')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenTK], [MatKhau]) VALUES (N'NV003     ', N'lethanhky', N'kyky98')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenTK], [MatKhau]) VALUES (N'NV004     ', N'cuonghoang', N'cuong98')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenTK], [MatKhau]) VALUES (N'NV005     ', N'anhhotuan', N'anhho98')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenTK], [MatKhau]) VALUES (N'NV006     ', N'phuctran', N'phuc98')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenTK], [MatKhau]) VALUES (N'NV007     ', N'sangngo', N'sang98')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenTK], [MatKhau]) VALUES (N'NV008     ', N'yenyen123', N'yen12345')
INSERT [dbo].[TaiKhoan] ([MaNV], [TenTK], [MatKhau]) VALUES (N'NV009     ', N'myngo123', N'1234567')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE001     ', N'Tay ga', N'Trắng', 45000000.0000, N'Nhật Bản', N'VN102836', N'SS093923', N'125cc', 0, N'vision')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE002     ', N'Số', N'Trắng', 30000000.0000, N'Thái Lan', N'VN100234', N'SS023434', N'125cc', 0, N'dream')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE003     ', N'Tay côn', N'Trắng', 35000000.0000, N'Nhật Bản', N'VN103244', N'SS034387', N'150cc', 0, N'Sh')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE004     ', N'Tay ga', N'Trắng', 43000000.0000, N'Thái Lan', N'VN102133', N'SS085645', N'125cc', 0, N'wave')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE005     ', N'Số', N'Xanh', 28000000.0000, N'Nhật Bản', N'VN100234', N'SS012487', N'125cc', 0, N'Jupiter')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE006     ', N'PKL', N'Đỏ', 120000000.0000, N'Việt Nam', N'VN109283', N'SS093423', N'200cc', 0, N'Kawashaki1000')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE007     ', N'PKL', N'Đỏ', 300000000.0000, N'Việt Nam', N'VN103234', N'SS043428', N'250cc', 0, N'Ducati')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE008     ', N'Tay ga', N'Xanh', 38000000.0000, N'Việt Nam', N'VN108732', N'SS009453', N'150cc', 0, N'Grande')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE009     ', N'Số', N'Vàng', 23000000.0000, N'Nhật Bản', N'VN106762', N'SS035455', N'50cc', 0, N'Cup')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE010     ', N'Số', N'Cam', 15000000.0000, N'Nhật Bản', N'VN998654', N'13223456', N'125cc', 0, N'Cub')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE011     ', N'Số', N'Trắng', 30000000.0000, N'Nhật Bản', N'VN954654', N'SS095965', N'125cc', 0, N'Jupiter')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE012     ', N'Số', N'Cam', 22000000.0000, N'Nhật Bản', N'VN985656', N'SS095964', N'50cc', 0, N'Cub')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE013     ', N'Tay ga', N'Trắng', 35000000.0000, N'Thái Lan', N'VN958656', N'SS948654', N'125cc', 1, N'Lead')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE014     ', N'Tay ga', N'Trắng', 55000000.0000, N'Nhật Bản', N'VN959675', N'SS956566', N'150cc', 1, N'SH')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE015     ', N'Tay ga', N'Xanh Dương', 42000000.0000, N'Trung Quốc', N'VN059756', N'SS905657', N'125cc', 1, N'Vision')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE016     ', N'Tay ga', N'Đen', 45000000.0000, N'Nhật Bản', N'VN084543', N'SS043853', N'125cc', 1, N'Janus')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE017     ', N'Tay ga', N'Trắng', 48000000.0000, N'Nhật Bản', N'VN998654', N'SS099565', N'50cc', 1, N'Airblade')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE018     ', N'Tay ga', N'Trắng', 45000000.0000, N'Nhật Bản', N'Vn995695', N'SS059695', N'125cc', 1, N'janus')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE019     ', N'Tay ga', N'Xanh Dương', 45000000.0000, N'Nhật Bản', N'Vn894645', N'Vn969575', N'125cc', 1, N'janus')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE020     ', N'Tay ga', N'Trắng', 45000000.0000, N'Nhật Bản', N'Vn984544', N'SS958646', N'125cc', 1, N'janus')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE021     ', N'Tay ga', N'Trắng', 39000000.0000, N'Nhật Bản', N'VN954968', N'SS657567', N'125cc', 0, N'vision')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE022     ', N'Số', N'Đen', 27000000.0000, N'Nhật Bản', N'VN099565', N'SS964346', N'125cc', 1, N'jupiter')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE023     ', N'Số', N'Đen', 45000000.0000, N'Nhật Bản', N'VN934953', N'SS095965', N'125cc', 1, N'jupiter')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE024     ', N'Tay ga', N'Trắng', 39000000.0000, N'Nhật Bản', N'VN954656', N'SS945435', N'125cc', 1, N'Airblade')
INSERT [dbo].[Xe] ([MaXe], [LoaiXe], [MauXe], [GiaXe], [NuocSX], [SoKhung], [SoSuon], [SoPK], [TinhTrang], [TenXe]) VALUES (N'XE025     ', N'Tay ga', N'Đen', 39000000.0000, N'Nhật Bản', N'VN945966', N'SS094634', N'125cc', 1, N'AirBlade')
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__CT_HoaDo__272520CCC771968C]    Script Date: 27/10/2018 10:50:59 CH ******/
ALTER TABLE [dbo].[CT_HoaDon] ADD  CONSTRAINT [UQ__CT_HoaDo__272520CCC771968C] UNIQUE NONCLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TaiKhoan__2725D70B1E8A4917]    Script Date: 27/10/2018 10:50:59 CH ******/
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [UQ__TaiKhoan__2725D70B1E8A4917] UNIQUE NONCLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CT_HoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CT_HoaDon] CHECK CONSTRAINT [FK_CT_HoaDon_HoaDon]
GO
ALTER TABLE [dbo].[CT_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CT_HoaDon_HopDong] FOREIGN KEY([MaHopDong])
REFERENCES [dbo].[HopDong] ([MaHopDong])
GO
ALTER TABLE [dbo].[CT_HoaDon] CHECK CONSTRAINT [FK_CT_HoaDon_HopDong]
GO
ALTER TABLE [dbo].[CT_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CT_HoaDon_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[CT_HoaDon] CHECK CONSTRAINT [FK_CT_HoaDon_Xe]
GO
ALTER TABLE [dbo].[CT_PhieuSua]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuSua_LinhKien] FOREIGN KEY([MaLK])
REFERENCES [dbo].[LinhKien] ([MaLK])
GO
ALTER TABLE [dbo].[CT_PhieuSua] CHECK CONSTRAINT [FK_CT_PhieuSua_LinhKien]
GO
ALTER TABLE [dbo].[CT_PhieuSua]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuSua_PhieuSuaBH] FOREIGN KEY([MaPhieuSua])
REFERENCES [dbo].[PhieuSuaBH] ([MaPhieuSua])
GO
ALTER TABLE [dbo].[CT_PhieuSua] CHECK CONSTRAINT [FK_CT_PhieuSua_PhieuSuaBH]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK_HopDong_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK_HopDong_KhachHang]
GO
ALTER TABLE [dbo].[PhieuSuaBH]  WITH CHECK ADD  CONSTRAINT [FK_PhieuSuaBH_HopDong] FOREIGN KEY([MaHopDong])
REFERENCES [dbo].[HopDong] ([MaHopDong])
GO
ALTER TABLE [dbo].[PhieuSuaBH] CHECK CONSTRAINT [FK_PhieuSuaBH_HopDong]
GO
ALTER TABLE [dbo].[PhieuSuaBH]  WITH CHECK ADD  CONSTRAINT [FK_PhieuSuaBH_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuSuaBH] CHECK CONSTRAINT [FK_PhieuSuaBH_NhanVien]
GO
ALTER TABLE [dbo].[PhieuTraGop]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraGop_HopDong] FOREIGN KEY([MaHopDong])
REFERENCES [dbo].[HopDong] ([MaHopDong])
GO
ALTER TABLE [dbo].[PhieuTraGop] CHECK CONSTRAINT [FK_PhieuTraGop_HopDong]
GO
ALTER TABLE [dbo].[PhieuTraGop]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTraGop_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuTraGop] CHECK CONSTRAINT [FK_PhieuTraGop_NhanVien]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [ck_chucvu] CHECK  (([chucvu]='KT' OR [chucvu]='QL' OR [chucvu]='BH'))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [ck_chucvu]
GO
/****** Object:  StoredProcedure [dbo].[TK_NVBanxe]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TK_NVBanxe]

AS
select TenNV,COUNT(tenNV) AS SOCHIEC from HopDong

group by TenNV


GO
/****** Object:  StoredProcedure [dbo].[TK_NVTheoNgay]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[TK_NVTheoNgay]
@ngaybd date, @ngaykt date
AS
select TenNV,COUNT(tenNV) AS SOCHIEC from HopDong
where NgayLap between @ngaybd and @ngaykt
group by TenNV


GO
/****** Object:  StoredProcedure [dbo].[TK_TTTheoNgay]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[TK_TTTheoNgay]
@ngaybd date, @ngaykt date
AS
select TinhTrang,COUNT(*) AS SoHopDong from HopDong
where NgayLap between @ngaybd and @ngaykt
group by TinhTrang


GO
/****** Object:  StoredProcedure [dbo].[TK_TTHopDong]    Script Date: 27/10/2018 10:50:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TK_TTHopDong]
--@ngaybd date, @ngaykt date
AS
select TinhTrang,COUNT(*) AS SoHopdong from HopDong
--where NgayLap between @ngaybd and @ngaykt
group by TinhTrang


GO
USE [master]
GO
ALTER DATABASE [PTUD_DHKTPM12A_DOAN_NHOM04] SET  READ_WRITE 
GO
