USE [Haiku]
GO

/****** Object:  Table [dbo].[Haikus]    Script Date: 2/11/2018 7:53:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Haikus](
	[ID] [int] NOT NULL,
	[FirstVerse] [varchar](500) NULL,
	[SecondVerse] [varchar](500) NULL,
	[ThirdVerse] [varchar](500) NULL,
	[ModelID] [int] NOT NULL,
	[Evaluation] [int] NULL,
	[NumberOfEvaluations] [int] NULL,
	[DateOfCreation] [date] NULL,
 CONSTRAINT [PK_Haikus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Haikus]  WITH CHECK ADD  CONSTRAINT [FK_HaikuModel] FOREIGN KEY([ID])
REFERENCES [dbo].[HaikuModels] ([ID])
GO

ALTER TABLE [dbo].[Haikus] CHECK CONSTRAINT [FK_HaikuModel]
GO


