/****** Object:  Table [dbo].[HaikuModels]    Script Date: 2/13/2018 11:16:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HaikuModels](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstVerseModel] [nvarchar](200) NULL,
	[SecondVerseModel] [nvarchar](200) NULL,
	[ThirdVerseModel] [nvarchar](200) NULL,
	[Evaluation] [int] NULL,
 CONSTRAINT [PK_HaikuModels] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


