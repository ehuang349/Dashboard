CREATE TABLE [dbo].[WeatherRecords] (
    [SysId]              BIGINT         IDENTITY (1, 1) NOT NULL,
    [City]               NVARCHAR (255) NOT NULL,
    [Temperature]        FLOAT (53)     NOT NULL,
    [WeatherDescription] NVARCHAR (255) NULL,
    [Date]               DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([SysId] ASC)
);

