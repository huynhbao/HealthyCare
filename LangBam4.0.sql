USE [master]
GO
/****** Object:  Database [LangBam4.0]    Script Date: 3/3/2021 10:08:06 PM ******/
CREATE DATABASE [LangBam4.0]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'onlinePT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\onlinePT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'onlinePT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\onlinePT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LangBam4.0] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LangBam4.0].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LangBam4.0] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LangBam4.0] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LangBam4.0] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LangBam4.0] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LangBam4.0] SET ARITHABORT OFF 
GO
ALTER DATABASE [LangBam4.0] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LangBam4.0] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LangBam4.0] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LangBam4.0] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LangBam4.0] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LangBam4.0] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LangBam4.0] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LangBam4.0] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LangBam4.0] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LangBam4.0] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LangBam4.0] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LangBam4.0] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LangBam4.0] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LangBam4.0] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LangBam4.0] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LangBam4.0] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LangBam4.0] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LangBam4.0] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LangBam4.0] SET  MULTI_USER 
GO
ALTER DATABASE [LangBam4.0] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LangBam4.0] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LangBam4.0] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LangBam4.0] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LangBam4.0] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LangBam4.0] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LangBam4.0] SET QUERY_STORE = OFF
GO
USE [LangBam4.0]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 3/3/2021 10:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[idBooking] [varchar](10) NOT NULL,
	[idDiseases] [varchar](10) NOT NULL,
	[bookingDate] [varchar](50) NOT NULL,
	[idUser] [varchar](10) NOT NULL,
 CONSTRAINT [PK__Orders__C8AAF6FF07020F21] PRIMARY KEY CLUSTERED 
(
	[idBooking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingSchedule]    Script Date: 3/3/2021 10:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingSchedule](
	[idSchedule] [varchar](10) NOT NULL,
	[idBooking] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diseases]    Script Date: 3/3/2021 10:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diseases](
	[idDiseases] [varchar](10) NOT NULL,
	[nameSubject] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Subjects__A324CF9E0AD2A005] PRIMARY KEY CLUSTERED 
(
	[idDiseases] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiseasestInfomation]    Script Date: 3/3/2021 10:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiseasestInfomation](
	[idDiseasestInfo] [varchar](10) NOT NULL,
	[idUser] [varchar](10) NOT NULL,
	[idDiseases] [varchar](10) NOT NULL,
 CONSTRAINT [PK_SubjectInfomation] PRIMARY KEY CLUSTERED 
(
	[idDiseasestInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 3/3/2021 10:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[idFeedback] [varchar](10) NOT NULL,
	[comment] [nvarchar](50) NOT NULL,
	[idUser] [varchar](10) NOT NULL,
	[idBooking] [varchar](10) NOT NULL,
 CONSTRAINT [PK__Feedback__0E3142BCBF0FB282] PRIMARY KEY CLUSTERED 
(
	[idFeedback] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 3/3/2021 10:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[idGender] [varchar](10) NOT NULL,
	[name] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED 
(
	[idGender] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/3/2021 10:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[idRole] [varchar](10) NOT NULL,
	[nameRole] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shedules]    Script Date: 3/3/2021 10:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shedules](
	[idSchedule] [varchar](10) NOT NULL,
	[startTime] [varchar](50) NOT NULL,
	[endTime] [varchar](50) NOT NULL,
	[idUsers] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Shedules] PRIMARY KEY CLUSTERED 
(
	[idSchedule] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/3/2021 10:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[idUser] [varchar](10) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[sdt] [nvarchar](50) NOT NULL,
	[idGender] [varchar](10) NOT NULL,
	[idRole] [varchar](10) NOT NULL,
	[height] [nchar](10) NULL,
	[weight] [nchar](10) NULL,
	[ibm] [varchar](10) NOT NULL,
 CONSTRAINT [PK__Users__3717C9827F60ED59] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B1', N'S1', N'20-12-2020', N'U2')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B10', N'S3', N'20-12-2020', N'U11')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B11', N'S1', N'20-12-2020', N'U3')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B2', N'S2', N'20-12-2020', N'U3')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B3', N'S2', N'21-12-2020', N'U7')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B4', N'S1', N'22-12-2020', N'U8')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B5', N'S1', N'23-12-2020', N'U7')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B6', N'S2', N'22-12-2020', N'U9')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B7', N'S1', N'21-12-2020', N'U5')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B8', N'S2', N'20-12-2020', N'U11')
INSERT [dbo].[Booking] ([idBooking], [idDiseases], [bookingDate], [idUser]) VALUES (N'B9', N'S3', N'20-12-2020', N'U2')
GO
INSERT [dbo].[BookingSchedule] ([idSchedule], [idBooking]) VALUES (N'SC1', N'B1')
INSERT [dbo].[BookingSchedule] ([idSchedule], [idBooking]) VALUES (N'SC1', N'B2')
INSERT [dbo].[BookingSchedule] ([idSchedule], [idBooking]) VALUES (N'SC3', N'B3')
INSERT [dbo].[BookingSchedule] ([idSchedule], [idBooking]) VALUES (N'SC4', N'B1')
INSERT [dbo].[BookingSchedule] ([idSchedule], [idBooking]) VALUES (N'SC2', N'B4')
INSERT [dbo].[BookingSchedule] ([idSchedule], [idBooking]) VALUES (N'SC6', N'B6')
INSERT [dbo].[BookingSchedule] ([idSchedule], [idBooking]) VALUES (N'SC7', N'B5')
INSERT [dbo].[BookingSchedule] ([idSchedule], [idBooking]) VALUES (N'SC5', N'B7')
INSERT [dbo].[BookingSchedule] ([idSchedule], [idBooking]) VALUES (N'SC6', N'B5')
GO
INSERT [dbo].[Diseases] ([idDiseases], [nameSubject]) VALUES (N'S1', N'Yoga')
INSERT [dbo].[Diseases] ([idDiseases], [nameSubject]) VALUES (N'S2', N'Gym')
INSERT [dbo].[Diseases] ([idDiseases], [nameSubject]) VALUES (N'S3', N'CARDO')
GO
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI1', N'U1', N'S1')
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI10', N'U12', N'S2')
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI2', N'U1', N'S2')
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI3', N'U1', N'S3')
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI4', N'U4', N'S1')
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI5', N'U4', N'S2')
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI6', N'U4', N'S3')
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI7', N'U10', N'S1')
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI8', N'U10', N'S2')
INSERT [dbo].[DiseasestInfomation] ([idDiseasestInfo], [idUser], [idDiseases]) VALUES (N'SI9', N'U12', N'S3')
GO
INSERT [dbo].[Feedback] ([idFeedback], [comment], [idUser], [idBooking]) VALUES (N'F1', N'Good', N'U9', N'B2')
INSERT [dbo].[Feedback] ([idFeedback], [comment], [idUser], [idBooking]) VALUES (N'F2', N'Normal', N'U2', N'B1')
INSERT [dbo].[Feedback] ([idFeedback], [comment], [idUser], [idBooking]) VALUES (N'F3', N'Nice', N'U2', N'B2')
INSERT [dbo].[Feedback] ([idFeedback], [comment], [idUser], [idBooking]) VALUES (N'F4', N'Normal', N'U5', N'B2')
INSERT [dbo].[Feedback] ([idFeedback], [comment], [idUser], [idBooking]) VALUES (N'F6', N'Good', N'U11', N'B1')
INSERT [dbo].[Feedback] ([idFeedback], [comment], [idUser], [idBooking]) VALUES (N'F7', N'Bad', N'U3', N'B1')
INSERT [dbo].[Feedback] ([idFeedback], [comment], [idUser], [idBooking]) VALUES (N'F8', N'Good', N'U7', N'B2')
INSERT [dbo].[Feedback] ([idFeedback], [comment], [idUser], [idBooking]) VALUES (N'F9', N'Bad', N'U8', N'B1')
GO
INSERT [dbo].[Genders] ([idGender], [name]) VALUES (N'G1', N'Male')
INSERT [dbo].[Genders] ([idGender], [name]) VALUES (N'G2', N'Female')
INSERT [dbo].[Genders] ([idGender], [name]) VALUES (N'G3', N'Other')
GO
INSERT [dbo].[Roles] ([idRole], [nameRole]) VALUES (N'R1', N'PT')
INSERT [dbo].[Roles] ([idRole], [nameRole]) VALUES (N'R2', N'Customer')
GO
INSERT [dbo].[Shedules] ([idSchedule], [startTime], [endTime], [idUsers]) VALUES (N'SC1', N'7h30', N'9h', N'U1')
INSERT [dbo].[Shedules] ([idSchedule], [startTime], [endTime], [idUsers]) VALUES (N'SC2', N'6h', N'7h30', N'U4')
INSERT [dbo].[Shedules] ([idSchedule], [startTime], [endTime], [idUsers]) VALUES (N'SC3', N'6h', N'7h30', N'U4')
INSERT [dbo].[Shedules] ([idSchedule], [startTime], [endTime], [idUsers]) VALUES (N'SC4', N'4h30', N'6h', N'U10')
INSERT [dbo].[Shedules] ([idSchedule], [startTime], [endTime], [idUsers]) VALUES (N'SC5', N'7h30', N'9h', N'U12')
INSERT [dbo].[Shedules] ([idSchedule], [startTime], [endTime], [idUsers]) VALUES (N'SC6', N'4h30', N'6h', N'U12')
INSERT [dbo].[Shedules] ([idSchedule], [startTime], [endTime], [idUsers]) VALUES (N'SC7', N'4h30', N'6h', N'U10')
GO
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U1', N'Nguyễn Văn Khoa', N'Quận 1', N'a.com', N'12345678', N'G1', N'R1', N'160       ', N'70        ', N'78')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U10', N'Nguyễn Thị Trúc', N'Quận 4', N'i.com', N'55555555', N'G1', N'R1', N'165       ', N'80        ', N'70')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U11', N'Hồ Tuấn Ngọc ', N'Quận 2', N'j.com', N'12345678', N'G1', N'R2', N'160       ', N'70        ', N'70')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U12', N'Trần Hoa', N'Quận 2', N'k.com', N'12398764', N'G1', N'R1', N'150       ', N'73        ', N'70')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U13', N'Nguyễn Vân', N'Quận 2', N't.com', N'22245622', N'G2', N'R2', N'170       ', N'84        ', N'70')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U2', N'Trần Cẩm Tiên', N'Quận 2', N'b.com', N'12398764', N'G2', N'R2', N'150       ', N'73        ', N'90')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U3', N'Nguyễn Minh Tâm', N'Quận 3', N'c.com', N'22222222', N'G1', N'R2', N'165       ', N'80        ', N'75')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U4', N'Trần Huy', N'Quận 1', N'd.com', N'98765432', N'G1', N'R1', N'160       ', N'70        ', N'70')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U5', N'Nguyễn Thị Trúc Ly', N'Quận 4', N'e.com', N'55555555', N'G2', N'R2', N'165       ', N'80        ', N'70')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U7', N'Hồ Ngọc Tuấn', N'Quận 2', N'f.com', N'12345678', N'G1', N'R2', N'160       ', N'70        ', N'70')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U8', N'Trần Thị Hoa', N'Quận 2', N'g.com', N'12398764', N'G2', N'R2', N'150       ', N'73        ', N'70')
INSERT [dbo].[Users] ([idUser], [name], [address], [email], [sdt], [idGender], [idRole], [height], [weight], [ibm]) VALUES (N'U9', N'Nguyễn Ngọc Vân', N'Quận 2', N'h.com', N'22245622', N'G2', N'R2', N'170       ', N'84        ', N'70')
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Users] FOREIGN KEY([idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Users]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Subjects] FOREIGN KEY([idDiseases])
REFERENCES [dbo].[Diseases] ([idDiseases])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Orders_Subjects]
GO
ALTER TABLE [dbo].[BookingSchedule]  WITH CHECK ADD  CONSTRAINT [FK_DetailShedule_Booking] FOREIGN KEY([idBooking])
REFERENCES [dbo].[Booking] ([idBooking])
GO
ALTER TABLE [dbo].[BookingSchedule] CHECK CONSTRAINT [FK_DetailShedule_Booking]
GO
ALTER TABLE [dbo].[BookingSchedule]  WITH CHECK ADD  CONSTRAINT [FK_DetailShedule_Shedules] FOREIGN KEY([idSchedule])
REFERENCES [dbo].[Shedules] ([idSchedule])
GO
ALTER TABLE [dbo].[BookingSchedule] CHECK CONSTRAINT [FK_DetailShedule_Shedules]
GO
ALTER TABLE [dbo].[DiseasestInfomation]  WITH CHECK ADD  CONSTRAINT [FK_SubjectInfomation_Subjects] FOREIGN KEY([idDiseases])
REFERENCES [dbo].[Diseases] ([idDiseases])
GO
ALTER TABLE [dbo].[DiseasestInfomation] CHECK CONSTRAINT [FK_SubjectInfomation_Subjects]
GO
ALTER TABLE [dbo].[DiseasestInfomation]  WITH CHECK ADD  CONSTRAINT [FK_SubjectInfomation_Users] FOREIGN KEY([idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[DiseasestInfomation] CHECK CONSTRAINT [FK_SubjectInfomation_Users]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Booking] FOREIGN KEY([idBooking])
REFERENCES [dbo].[Booking] ([idBooking])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Booking]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Users] FOREIGN KEY([idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Users]
GO
ALTER TABLE [dbo].[Shedules]  WITH CHECK ADD  CONSTRAINT [FK_Shedules_Users] FOREIGN KEY([idUsers])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[Shedules] CHECK CONSTRAINT [FK_Shedules_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Genders] FOREIGN KEY([idGender])
REFERENCES [dbo].[Genders] ([idGender])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Genders]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([idRole])
REFERENCES [dbo].[Roles] ([idRole])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [LangBam4.0] SET  READ_WRITE 
GO
