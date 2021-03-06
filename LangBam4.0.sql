USE [master]
GO
/****** Object:  Database [LangBam4.0]    Script Date: 13/03/2021 19:06:33 PM ******/
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
/****** Object:  Table [dbo].[Booking]    Script Date: 13/03/2021 19:06:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[idBooking] [int] IDENTITY(1,1) NOT NULL,
	[idBookingInformation] [varchar](10) NOT NULL,
	[idUser] [varchar](20) NOT NULL,
	[bookingDate] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Orders__C8AAF6FF07020F21] PRIMARY KEY CLUSTERED 
(
	[idBooking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingInformation]    Script Date: 13/03/2021 19:06:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingInformation](
	[idBookingInformation] [int] IDENTITY(1,1) NOT NULL,
	[idBooking] [int] NOT NULL,
	[idDoctor] [varchar](20) NOT NULL,
	[status] [bit] NOT NULL,
	[description] [varchar](500) NOT NULL,
 CONSTRAINT [PK_BookingInformation] PRIMARY KEY CLUSTERED 
(
	[idBookingInformation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingSchedule]    Script Date: 13/03/2021 19:06:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingSchedule](
	[idSchedule] [int] NOT NULL,
	[idBooking] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Certificate]    Script Date: 13/03/2021 19:06:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificate](
	[idCertificate] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Certificate] PRIMARY KEY CLUSTERED 
(
	[idCertificate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 13/03/2021 19:06:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[idFeedback] [int] IDENTITY(1,1) NOT NULL,
	[comment] [nvarchar](50) NOT NULL,
	[idUser] [varchar](20) NOT NULL,
	[idBooking] [int] NOT NULL,
 CONSTRAINT [PK__Feedback__0E3142BCBF0FB282] PRIMARY KEY CLUSTERED 
(
	[idFeedback] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 13/03/2021 19:06:34 PM ******/
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
/****** Object:  Table [dbo].[Shedules]    Script Date: 13/03/2021 19:06:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shedules](
	[idSchedule] [int] IDENTITY(1,1) NOT NULL,
	[startTime] [varchar](50) NOT NULL,
	[endTime] [varchar](50) NOT NULL,
	[idUsers] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Shedules] PRIMARY KEY CLUSTERED 
(
	[idSchedule] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13/03/2021 19:06:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[idUser] [varchar](20) NOT NULL,
	[password] [varchar](50) NULL,
	[fullName] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[gender] [bit] NOT NULL,
	[idCertificate] [int] NULL,
	[idRole] [varchar](10) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK__Users__3717C9827F60ED59] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Certificate] ON 

INSERT [dbo].[Certificate] ([idCertificate], [name]) VALUES (5, N'1111')
INSERT [dbo].[Certificate] ([idCertificate], [name]) VALUES (6, N'1111')
INSERT [dbo].[Certificate] ([idCertificate], [name]) VALUES (7, N'a')
INSERT [dbo].[Certificate] ([idCertificate], [name]) VALUES (8, N'a')
INSERT [dbo].[Certificate] ([idCertificate], [name]) VALUES (9, N'3')
SET IDENTITY_INSERT [dbo].[Certificate] OFF
GO
INSERT [dbo].[Roles] ([idRole], [nameRole]) VALUES (N'1', N'Admin')
INSERT [dbo].[Roles] ([idRole], [nameRole]) VALUES (N'2', N'Doctor')
INSERT [dbo].[Roles] ([idRole], [nameRole]) VALUES (N'3', N'User')
GO
INSERT [dbo].[Users] ([idUser], [password], [fullName], [address], [email], [phone], [gender], [idCertificate], [idRole], [status]) VALUES (N'1', N'1', N'Nguyễn Văn A', N'a', N'1', N'1', 1, 6, N'2', 1)
INSERT [dbo].[Users] ([idUser], [password], [fullName], [address], [email], [phone], [gender], [idCertificate], [idRole], [status]) VALUES (N'3', N'3', N'Nguyễn Văn B', N'3', N'3', N'3', 1, 9, N'2', 1)
INSERT [dbo].[Users] ([idUser], [password], [fullName], [address], [email], [phone], [gender], [idCertificate], [idRole], [status]) VALUES (N'a', N'1', N'aaaa', N'aaaa', N'a@gmail.com', N'01234567', 0, NULL, N'3', 1)
INSERT [dbo].[Users] ([idUser], [password], [fullName], [address], [email], [phone], [gender], [idCertificate], [idRole], [status]) VALUES (N'raze', N'1', N'a', N'11', N'11', N'11', 1, NULL, N'1', 1)
INSERT [dbo].[Users] ([idUser], [password], [fullName], [address], [email], [phone], [gender], [idCertificate], [idRole], [status]) VALUES (N'sage', N'2', N'11', N'1', N'1', N'1', 0, NULL, N'1', 1)
GO
ALTER TABLE [dbo].[BookingInformation] ADD  CONSTRAINT [DF_BookingInformation_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Users] FOREIGN KEY([idUser])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Users]
GO
ALTER TABLE [dbo].[BookingInformation]  WITH CHECK ADD  CONSTRAINT [FK_BookingInformation_Booking] FOREIGN KEY([idBooking])
REFERENCES [dbo].[Booking] ([idBooking])
GO
ALTER TABLE [dbo].[BookingInformation] CHECK CONSTRAINT [FK_BookingInformation_Booking]
GO
ALTER TABLE [dbo].[BookingInformation]  WITH CHECK ADD  CONSTRAINT [FK_BookingInformation_Users] FOREIGN KEY([idDoctor])
REFERENCES [dbo].[Users] ([idUser])
GO
ALTER TABLE [dbo].[BookingInformation] CHECK CONSTRAINT [FK_BookingInformation_Users]
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
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Certificate] FOREIGN KEY([idCertificate])
REFERENCES [dbo].[Certificate] ([idCertificate])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Certificate]
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
