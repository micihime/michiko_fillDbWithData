USE [Haiku]
GO

/****** Object:  Table [dbo].[HaikuWords]    Script Date: 2/11/2018 7:43:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HaikuWords](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WordString] [varchar](50) NULL,
	[WordPartOfSpeech] [varchar](50) NULL,
	[NumberOfSyllables] [smallint] NULL,
 CONSTRAINT [PK_HaikuWords] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


