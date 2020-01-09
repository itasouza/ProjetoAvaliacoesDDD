/*
Created		07/01/2020
Modified		07/01/2020
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/


Create table [Usuario]
(
	[UsuarioId] Integer Identity NOT NULL,
	[NomeUsuario] Varchar(250) NULL,
	[Email] Varchar(250) NULL,
	[DataCadastro] Datetime NULL,
Primary Key ([UsuarioId])
) 
go

Create table [Produto]
(
	[ProdutoId] Integer Identity NOT NULL,
	[NomeProduto] Varchar(250) NULL,
	[DescricaoProduto] Text NULL,
	[ValorProduto] Decimal(18,2) NULL,
	[Ativo] Char(1) NULL,
	[DataFabricacao] Datetime NULL,
	[DataValidade] Datetime NULL,
	[FotoProduto] Varchar(250) NULL,
	[ProdutoPromocao] Char(1) NULL,
Primary Key ([ProdutoId])
) 
go

Create table [Avaliacoes]
(
	[AvaliacoesId] Integer Identity NOT NULL,
	[UsuarioId] Integer NOT NULL,
	[ProdutoId] Integer NOT NULL,
	[Titulo] Varchar(250) NULL,
	[Descricao] Text NULL,
	[QuantidadeEstrela] Integer NULL,
	[DataCadastro] Datetime NULL,
	[AvaliacaoUtil] Char(1) NULL,
Primary Key ([AvaliacoesId])
) 
go


Alter table [Avaliacoes] add  foreign key([UsuarioId]) references [Usuario] ([UsuarioId])  on update no action on delete no action 
go
Alter table [Avaliacoes] add  foreign key([ProdutoId]) references [Produto] ([ProdutoId])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


