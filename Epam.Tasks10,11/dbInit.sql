USE [master]
GO
/****** Object:  Database [UsersAndAwards]    Script Date: 14.02.2019 9:08:28 ******/
CREATE DATABASE [UsersAndAwards]
 CONTAINMENT = NONE
 ALTER DATABASE [UsersAndAwards] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UsersAndAwards].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UsersAndAwards] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ARITHABORT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UsersAndAwards] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UsersAndAwards] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UsersAndAwards] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UsersAndAwards] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UsersAndAwards] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UsersAndAwards] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UsersAndAwards] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UsersAndAwards] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UsersAndAwards] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UsersAndAwards] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UsersAndAwards] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UsersAndAwards] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UsersAndAwards] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UsersAndAwards] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UsersAndAwards] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UsersAndAwards] SET  MULTI_USER 
GO
ALTER DATABASE [UsersAndAwards] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UsersAndAwards] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UsersAndAwards] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UsersAndAwards] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UsersAndAwards] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UsersAndAwards] SET QUERY_STORE = OFF
GO
USE [UsersAndAwards]
GO
/****** Object:  Table [dbo].[Awards]    Script Date: 14.02.2019 9:08:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Awards](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Awards] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14.02.2019 9:08:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NULL,
	[date_of_birth] [date] NOT NULL,
	[image] [varbinary](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersAwards]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersAwards](
	[user_id] [int] NOT NULL,
	[award_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UsersAwards]  WITH CHECK ADD  CONSTRAINT [FK_UsersAwards_Awards] FOREIGN KEY([award_id])
REFERENCES [dbo].[Awards] ([id])
GO
ALTER TABLE [dbo].[UsersAwards] CHECK CONSTRAINT [FK_UsersAwards_Awards]
GO
ALTER TABLE [dbo].[UsersAwards]  WITH CHECK ADD  CONSTRAINT [FK_UsersAwards_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[UsersAwards] CHECK CONSTRAINT [FK_UsersAwards_Users]
GO
/****** Object:  StoredProcedure [dbo].[AddAward]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddAward]
@title NVARCHAR(50)
AS
BEGIN
	INSERT INTO Awards (Title)
	VALUES (@title)
END
GO
/****** Object:  StoredProcedure [dbo].[AddAwardToUser]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddAwardToUser]
@user_id INT,
@award_id INT
AS
BEGIN
	INSERT INTO UsersAwards (user_id, award_id)
	VALUES (@user_id, @award_id)
END
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddUser]
@first_name NVARCHAR(50),
@last_name NVARCHAR(50),
@date_of_birth DATE NULL
AS
BEGIN
	INSERT INTO Users (first_name, last_name, date_of_birth)
	VALUES (@first_name, @last_name, @date_of_birth)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteAward]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteAward]
@id INT
AS
BEGIN
	SET NOCOUNT ON;

DELETE FROM Awards 
  WHERE Awards.id=@id 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteUser]
@id INT
AS
BEGIN
	SET NOCOUNT ON;

DELETE FROM Users 
  WHERE Users.id=@id 
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllAwards]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllAwards]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT   id
	        ,title
			FROM Awards 
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllUsers]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT   Users.id
	        ,Users.first_name
	        ,Users.last_name
			,Users.date_of_birth
			FROM Users 
END
GO
/****** Object:  StoredProcedure [dbo].[GetAward]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAward]
@id INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT   id
	        ,title
			FROM Awards 
			WHERE @id = id
END
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetUser]
@id INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT   id
	        ,first_name
			,last_name
			,date_of_birth
			FROM Users 
			WHERE @id = id
END
GO
/****** Object:  StoredProcedure [dbo].[GetUsersAwards]    Script Date: 14.02.2019 9:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetUsersAwards]
@user_id INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT   id
	        ,title
			FROM Awards JOIN UsersAwards ui ON Awards.id = ui.award_id 
			WHERE ui.user_id = @user_id
END
GO
USE [master]
GO
ALTER DATABASE [UsersAndAwards] SET  READ_WRITE 
GO
