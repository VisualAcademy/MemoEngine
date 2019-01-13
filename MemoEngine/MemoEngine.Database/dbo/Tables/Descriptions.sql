CREATE TABLE [dbo].[Descriptions]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1, 1),
	SiteName NVarChar(Max) Null,
	SiteDescription NVarChar(Max) Null,
	UserGuide NVarChar(Max) Null,					-- 사용자 가이드
	-- ...
)
Go
