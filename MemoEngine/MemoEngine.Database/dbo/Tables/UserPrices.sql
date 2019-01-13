CREATE TABLE [dbo].[UserPrices]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1, 1),	-- 일련번호
	ProjectId Int Null,								-- 부모 테이블 번호
	Num Int Null,									-- 년차
	[Year] Int Null,								-- 년도
	StandardPrice Float Null,						-- 기준 단가
	UserPrice Float Null							-- 사용자 단가
)
Go
