/*

* CONECTAR A UM SERVIDOR SQL LOCAL NO LINUX:

sqlcmd -S localhost -U SA -P UbuntuSQL2016


* EXECUTAR UM ARQUIVO DE SCRIPTS:

sqlcmd -S localhost -U SA -P UbuntuSQL2016 -i ScriptCotacoes.sql

*/

CREATE DATABASE ExemploCotacoes;
GO

USE ExemploCotacoes;
GO

CREATE TABLE dbo.Cotacoes(
	Sigla char(3) NOT NULL,
	NomeMoeda varchar(30) NOT NULL,
	UltimaCotacao datetime NOT NULL,
	Valor numeric (18,4) NOT NULL,
	CONSTRAINT PK_Cotacoes PRIMARY KEY (Sigla)
);
GO


INSERT INTO dbo.Cotacoes
           (Sigla
           ,NomeMoeda
           ,UltimaCotacao
           ,Valor)
     VALUES
           ('USD'
           ,'Dólar norte-americano'
           ,'2017-01-04 16:59'
           ,3.2183);
GO

INSERT INTO dbo.Cotacoes
           (Sigla
           ,NomeMoeda
           ,UltimaCotacao
           ,Valor)
     VALUES
           ('EUR'
           ,'Euro'
           ,'2017-01-04 16:59'
           ,3.3860);
GO

INSERT INTO dbo.Cotacoes
           (Sigla
           ,NomeMoeda
           ,UltimaCotacao
           ,Valor)
     VALUES
           ('LIB'
           ,'Libra esterlina'
           ,'2017-01-04 16:59'
           ,3.9701);
GO