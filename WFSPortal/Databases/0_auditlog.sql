USE [EpicorHCMCMU2024]
GO

/****** Object:  Table [dbo].[WFS_AuditLog]    Script Date: 4/12/2024 2:30:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WFS_AuditLog](
	[AuditID] [bigint] IDENTITY(1,1) NOT NULL,
	[ObjectName] [nvarchar](255) NOT NULL,
	[RecordID] [nvarchar](1000) NOT NULL,
	[ChangedBy] [nvarchar](255) NOT NULL,
	[ChangeTime] [datetime] NOT NULL,
	[System] [nvarchar](255) NOT NULL,
	[Module] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


