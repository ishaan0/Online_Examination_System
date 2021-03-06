USE [OnlineExamination]
GO
/****** Object:  Table [dbo].[Exam_Master]    Script Date: 26-Sep-19 11:56:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam_Master](
	[Teacher_Id] [nvarchar](50) NOT NULL,
	[Course_Code] [nvarchar](50) NOT NULL,
	[Total_Students] [nvarchar](50) NOT NULL,
	[Total_Marks] [nvarchar](50) NOT NULL,
	[Exam_Date] [nvarchar](50) NOT NULL,
	[Exam_Time] [nvarchar](50) NOT NULL,
	[Exam_Duration] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Master]    Script Date: 26-Sep-19 11:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Master](
	[Student_Id] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Teacher_Id] [nvarchar](50) NOT NULL,
	[Course_Code] [nvarchar](50) NOT NULL,
	[Marks] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_Master]    Script Date: 26-Sep-19 11:56:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Master](
	[User_Id] [nvarchar](50) NOT NULL,
	[User_Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User_Master] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
