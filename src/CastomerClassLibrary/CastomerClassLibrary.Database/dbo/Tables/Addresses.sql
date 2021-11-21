CREATE TABLE [dbo].[Addresses] (
    [AddressID]    INT            IDENTITY (1, 1) NOT NULL,
    [CustomerID]   INT            NOT NULL,
    [AddressLine]  NVARCHAR (100) NOT NULL,
    [AddressLine2] NVARCHAR (100) NULL,
    [AddressType]  NVARCHAR (8)   NOT NULL,
    [City]         NVARCHAR (50)  NOT NULL,
    [PostalCode]   NVARCHAR (6)   NOT NULL,
    [State]        NVARCHAR (20)  NOT NULL,
    [Country]      NVARCHAR (13)  NOT NULL,
    CONSTRAINT [PK_AddressID] PRIMARY KEY CLUSTERED ([AddressID] ASC),
    CONSTRAINT [AddressType_CHK] CHECK ([AddressType]='Billing' OR [AddressType]='Shipping'),
    CONSTRAINT [Country_CHK] CHECK ([Country]='Canada' OR [Country]='United States'),
    FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([CustomerId])
);

