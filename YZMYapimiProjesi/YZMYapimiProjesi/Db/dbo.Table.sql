CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Adi] NVARCHAR(50) NOT NULL, 
    [Soyadi] NVARCHAR(50) NOT NULL, 
    [KullaniciAdi] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Tel] BIGINT NOT NULL, 
    [TCKimlik] BIGINT NOT NULL, 
    [Adres] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL
)
