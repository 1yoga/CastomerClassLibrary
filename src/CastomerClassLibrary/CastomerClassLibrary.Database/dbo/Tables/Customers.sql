CREATE TABLE [dbo].[Customers] (
    [CustomerId]           INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]            NVARCHAR (50)  NULL,
    [LastName]             NVARCHAR (50)  NOT NULL,
    [PhoneNumber]          NVARCHAR (16)  NULL,
    [Email]                NVARCHAR (50)  NULL,
    [Notes]                NVARCHAR (MAX) NOT NULL,
    [TotalPurchasesAmount] MONEY          NULL,
    CONSTRAINT [PK_CustomerId] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    CONSTRAINT [Email_Validate] CHECK ([Email] like '%_@__%.__%'),
    CONSTRAINT [PhoneNumber_E164] CHECK ([PhoneNumber] like '+[0-9]%[0-9]' OR [PhoneNumber] like '[0-9]%[0-9]')
);

