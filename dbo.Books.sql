CREATE TABLE [dbo].[Books] (
    [BookId]    INT           IDENTITY (1, 1) NOT NULL,
    [Title]     NVARCHAR (50) NOT NULL,
    [Author]    NVARCHAR (50) NULL,
    [Genre]     NVARCHAR (50) NULL,
    [RentedBy]  INT           NULL,
    [DueBy]     DATE          NULL,
    [Publisher] NVARCHAR (50) NULL,
    CONSTRAINT [PK_BookId] PRIMARY KEY CLUSTERED ([BookId] ASC),
    CONSTRAINT [FK_Books_UserID] FOREIGN KEY ([RentedBy]) REFERENCES [dbo].[Users] ([UserId])
);

