USE [accounting_app_database]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[config](
	[config_id] [int] IDENTITY(1,1) NOT NULL,
	[my_name] [nvarchar](50) NULL,
	[my_address] [nvarchar](50) NULL,
	[my_nip] [nvarchar](50) NULL,
	[my_email] [nvarchar](50) NULL,
	[form_variant] [nvarchar](10) NULL,
	[path_for_jpk] [nvarchar](100) NULL,
	[purpose_of_submission] [nchar](10) NULL,
	[system_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_config] PRIMARY KEY CLUSTERED 
(
	[config_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


