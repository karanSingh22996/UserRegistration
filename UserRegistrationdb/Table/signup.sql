CREATE TABLE [dbo].[signup](
	[Id]		[int] IDENTITY	(1,1) NOT NULL,
	[FirstName] [nvarchar]		(30) NULL,
	[LastName]	[nvarchar]		(30) NULL,
	[Email]		[nvarchar]		(50) NULL,
	[Pass]		[nvarchar]		(8) NULL,
	[MobileNo] [varchar]		(10) NULL,
UNIQUE NONCLUSTERED 
(
	[MobileNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
