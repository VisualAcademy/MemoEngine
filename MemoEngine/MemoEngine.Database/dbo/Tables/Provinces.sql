-- 지방 테이블: 지역별 위도경도
CREATE TABLE [dbo].[Provinces] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,				-- 번호
    [ProvinceName] NVARCHAR (MAX) NULL,									-- 지자체명
    [LocationName] NVARCHAR (MAX) NULL,
    [LocationCode] NVARCHAR (MAX) NULL,
    [Latitude]     REAL           NOT NULL,
    [Longitude]    REAL           NOT NULL,
    [Elevation]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Provinces] PRIMARY KEY CLUSTERED ([Id] ASC)
);
