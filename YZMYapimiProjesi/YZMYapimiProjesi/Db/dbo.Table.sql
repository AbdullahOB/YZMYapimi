CREATE TABLE [dbo].[Table] (
    [Id]            INT           NOT NULL IDENTITY,
    [KullaniciAdi]  NVARCHAR (50) NOT NULL,
    [Sifre]         NVARCHAR (50) NOT NULL,
    [Adi]           NVARCHAR (50) NOT NULL,
    [Soyadi]        NVARCHAR (50) NOT NULL,
    [Email]         NVARCHAR (50) NOT NULL,
    [TCKimlik]      BIGINT        NOT NULL,
    [Tel]           BIGINT        NOT NULL,
    [Adres]         NVARCHAR (50) NOT NULL,
    [KullaniciTipi] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

