USE [accounting_app_database]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[invoice](
	[invoice_id] [int] IDENTITY(1,1) NOT NULL,
	[invoice_number] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[amount_net] [numeric](18, 2) NOT NULL,
	[amount_vat] [numeric](18, 2) NOT NULL,
	[vat_rate] [numeric](4, 2) NOT NULL,
	[contractor_name] [nvarchar](50) NOT NULL,
	[contractor_address] [nvarchar](100) NOT NULL,
	[contractor_nip] [nvarchar](50) NOT NULL,
	[income] [bit] NOT NULL,
	[date_of_issue] [date] NOT NULL,
	[date_of_sale] [date] NOT NULL,
	[date_added] [datetime] NULL,
 CONSTRAINT [PK_invoices] PRIMARY KEY CLUSTERED 
(
	[invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


