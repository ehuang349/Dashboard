CREATE TABLE [dbo].[ApiAccess] (
    [SysId]     INT           IDENTITY (1, 1) NOT NULL,
    [CreatedAt] DATETIME      DEFAULT (getdate()) NOT NULL,
    [ApiKey]    VARCHAR (255) NOT NULL,
    [User]      VARCHAR (255) NOT NULL,
    [Type]      VARCHAR (255) NOT NULL,
    [IsActive]  BIT           NULL,
    PRIMARY KEY CLUSTERED ([SysId] ASC)
);

