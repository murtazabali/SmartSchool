USE [master]
GO
/****** Object:  Database [SMS]    Script Date: 1/5/2017 4:25:41 PM ******/
CREATE DATABASE [SMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SMS.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SMS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SMS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SMS] SET  MULTI_USER 
GO
ALTER DATABASE [SMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SMS]
GO
/****** Object:  StoredProcedure [dbo].[reading_stdid]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reading_stdid]
AS
SELECT * FROM dbo.student

GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Fee]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_Insert_Fee]
	@stdid int,
	@month varchar(50),
	@duedate date,
	@paydate date,
	@scholarship int,
	@paidfees int,
	@balance int,
	@totalfees int
as
	insert into fees values(@stdid,@month,@duedate,@paydate,@scholarship,@paidfees,@balance,@totalfees);



GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_NewAddmission]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_Insert_NewAddmission]
	@firstname varchar(50),
	@lastname varchar(50),
	@gender varchar(50),
	@dob date,
	@placeofbirth varchar(50),
	@mothertongue varchar(50),
	@nationality varchar(50),
	@contact decimal(12,0),
	@address varchar(100),
	@dateofjoining date,
	@lastschoolattend varchar(50),
	@bform decimal(13,0),
	@class int,
	@section varchar(50),
	@picture image
As
	insert into student values (@firstname,@lastname,@gender,@dob,@placeofbirth,@mothertongue,
								@nationality,@contact,@address,@dateofjoining,@lastschoolattend,
								@bform,@class,@section,@picture);



GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Salary]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Insert_Salary]
	@staffid int,
	@month varchar(50),
	@basicsalary int,
	@bonus int,
	@totalsalary int
as
	insert into salary values (@staffid,@month,@basicsalary,@bonus,@totalsalary);



GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Staff]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Insert_Staff]
	@staffid int,
	@firstname varchar(50),
	@lastname varchar(50),
	@gender varchar(50),
	@dob datetime,
	@placeofbirth varchar(50),
	@mothertongue varchar(50),
	@nationality varchar(50),
	@contact decimal(12,0),
	@address varchar(200),
	@dateofjoin datetime,
	@cnic decimal(13,0),
	@lastworked varchar(100),
	@previousexp varchar(100),	
	@designation varchar(50),
	@desgid int,
	@subjectname varchar(50),
	@subjectid int,
	@picture image
AS
	Insert into staffs values(@staffid,@firstname,@lastname,@gender,@dob,@placeofbirth,@mothertongue,
							@nationality,@contact,@address,@dateofjoin,@cnic,@lastworked,@previousexp,
							@designation,@desgid,@subjectname,@subjectid,@picture);



GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Subject]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_Insert_Subject]
	@subjectid int,
	@code varchar(50),
	@subjectname varchar(50)
AS
	insert into subject values (@subjectid,@code,@subjectname);



GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_User]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_Insert_User]
	@username varchar(50),
	@password varchar(50),
	@deptid int
AS
	insert into Users values (@username,@password,@deptid);



GO
/****** Object:  StoredProcedure [dbo].[SP_Read_Depid]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_Read_Depid]
@deptName varchar(50)
AS
	Select deptid from dept where deptname = @deptName



GO
/****** Object:  Table [dbo].[dept]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dept](
	[deptid] [int] NOT NULL,
	[deptname] [varchar](50) NOT NULL,
	[location] [varchar](100) NOT NULL,
 CONSTRAINT [PK_dept] PRIMARY KEY CLUSTERED 
(
	[deptid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[designation]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[designation](
	[DesgId] [int] NOT NULL,
	[Desgname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_designation] PRIMARY KEY CLUSTERED 
(
	[DesgId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fees]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fees](
	[fid] [int] IDENTITY(1,1) NOT NULL,
	[stdid] [int] NOT NULL,
	[month] [varchar](50) NOT NULL,
	[duedate] [date] NOT NULL,
	[paydate] [date] NOT NULL,
	[scholarship] [int] NULL,
	[paidfees] [int] NOT NULL,
	[balance] [int] NULL,
	[totalfees] [int] NOT NULL,
 CONSTRAINT [PK_fees] PRIMARY KEY CLUSTERED 
(
	[fid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[salary]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[salary](
	[salid] [int] IDENTITY(1,1) NOT NULL,
	[staffid] [int] NOT NULL,
	[month] [varchar](50) NOT NULL,
	[basicsalary] [int] NOT NULL,
	[bonus] [int] NULL,
	[totalsalary] [int] NOT NULL,
 CONSTRAINT [PK_salary] PRIMARY KEY CLUSTERED 
(
	[salid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[Day] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Time] [nvarchar](50) NOT NULL,
	[Class] [nvarchar](50) NOT NULL,
	[RoomNo] [nvarchar](50) NOT NULL,
	[Subject] [nvarchar](50) NOT NULL,
	[Teacher] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[staffs]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[staffs](
	[staffid] [int] NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[dob] [datetime] NOT NULL,
	[placeofbirth] [varchar](50) NOT NULL,
	[mothertongue] [varchar](50) NOT NULL,
	[nationality] [varchar](50) NOT NULL,
	[contact] [decimal](12, 0) NOT NULL,
	[address] [varchar](200) NOT NULL,
	[dateofjoin] [datetime] NOT NULL,
	[cnic] [decimal](13, 0) NOT NULL,
	[lastworked] [varchar](100) NULL,
	[previousexp] [varchar](100) NULL,
	[designation] [varchar](50) NOT NULL,
	[desgid] [int] NOT NULL,
	[subjectname] [varchar](50) NULL,
	[subjectid] [int] NULL,
	[picture] [image] NULL,
 CONSTRAINT [PK_staffs] PRIMARY KEY CLUSTERED 
(
	[staffid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student](
	[stdid] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[placeofbirth] [varchar](50) NOT NULL,
	[mothertongue] [varchar](50) NOT NULL,
	[nationality] [varchar](50) NOT NULL,
	[contact] [decimal](12, 0) NOT NULL,
	[address] [varchar](100) NOT NULL,
	[dateofjoining] [date] NOT NULL,
	[lastschoolattend] [varchar](50) NULL,
	[bform] [decimal](13, 0) NOT NULL,
	[class] [int] NOT NULL,
	[section] [varchar](50) NOT NULL,
	[picture] [image] NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[stdid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[subject]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subject](
	[subjectid] [int] NOT NULL,
	[code] [varchar](50) NOT NULL,
	[subjectname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_subject] PRIMARY KEY CLUSTERED 
(
	[subjectid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/5/2017 4:25:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[deptid] [int] NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[staffs]  WITH CHECK ADD  CONSTRAINT [FK_staffs_designation] FOREIGN KEY([desgid])
REFERENCES [dbo].[designation] ([DesgId])
GO
ALTER TABLE [dbo].[staffs] CHECK CONSTRAINT [FK_staffs_designation]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_user_dept] FOREIGN KEY([deptid])
REFERENCES [dbo].[dept] ([deptid])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_user_dept]
GO
USE [master]
GO
ALTER DATABASE [SMS] SET  READ_WRITE 
GO
