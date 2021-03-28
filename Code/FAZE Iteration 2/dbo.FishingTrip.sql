CREATE TABLE [dbo].[FishingTrip] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Location]          NVARCHAR (MAX) NOT NULL,
    [Date]              DATETIME2 (7)  NOT NULL,
    [StartTime]         DATETIME2 (7)  NOT NULL,
    [TimeSpentFishing]  TIME (7)       NOT NULL,
    [TotalFishCaught]   INT            NOT NULL,
    [NumOfBites]        INT            NULL,
    [NumOfBaitUsed]     INT            NULL,
    [Season]            NVARCHAR (MAX) NULL,
    [AvgTemp]           FLOAT (53)     NULL,
    [WeatherConditions] NVARCHAR (MAX) NULL,
    [MoonPhase]         NVARCHAR (MAX) NULL,
    [Tide]              NVARCHAR (MAX) NULL,
    [Comments]          NVARCHAR (MAX) NULL,
    [UsersFK]           NVARCHAR (450) NULL,
    CONSTRAINT [PK_FishingTrip] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FishingTrip_AspNetUsers_UsersFK] FOREIGN KEY ([UsersFK]) REFERENCES [dbo].[AspNetUsers] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FishingTrip_UsersFK]
    ON [dbo].[FishingTrip]([UsersFK] ASC);

