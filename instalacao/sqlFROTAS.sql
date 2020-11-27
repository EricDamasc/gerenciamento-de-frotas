CREATE DATABASE DBFrotas

use DBFrotas;

-- TELA E ACÕES CRIADAS COM SUCESSO
CREATE TABLE tblsenhamaster(
senhaid varchar (25) not null,)

INSERT INTO tblsenhamaster (senhaid) VALUES ('valeapena2020')

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblusuario(
cpf varchar (15) not null primary key,
usersenha varchar (15) not null,
useremail varchar (50) not null,
perfil varchar(15) not null,
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblveiculo (
placa varchar(10)not null primary key,
marca varchar(20) not null,
anoveiculo int not null,
modelo varchar(20) not null,
consumo varchar(20) not null,
tipo varchar(20) not null,
disponibilidade varchar(5) not null,
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblmotorista (
idmotorista int primary key not null,
rg varchar(20)not null,
cpf varchar(20) not null,
nome varchar(40) not null,
nascimento datetime not null,
numcnh varchar(14)not null,
tipocnh varchar(8)not null,
validacnh datetime not null,
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblcliente (
idcliente int primary key not null,
telefone varchar (15) not null,
cnpj varchar (25) not null,
empresa varchar(100) not null,
email varchar (80)not null,
cep varchar(9) not null,
estado varchar(35)not null,
)

-- TELA E ACÕES CRIADAS COM SUCESSO 
CREATE TABLE tblsaidaveiculo (
idsaida int primary key not null,
idmotorista int not null,
idcliente int not null,
datasaida datetime not null,
datachegada datetime null,
veiculoobs varchar(200) null,
foreign key (idmotorista) references tblmotorista (idmotorista),
foreign key (idcliente) references tblcliente (idcliente),
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblsaidaveiculo (
idsaida int primary key not null,
idmotorista int not null,
idcliente int not null,
datasaida datetime not null,
foreign key (idmotorista) references tblmotorista (idmotorista),
foreign key (idcliente) references tblcliente (idcliente),
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
create table tblentradaveiculo(
dataentrada datetime primary key not null,
idsaida int not null,
foreign key (idsaida) references tblsaidaveiculo (idsaida),
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblabastecimento (
idabastecimeto smallint primary key not null,
combustivel varchar(15) not null,
placa varchar (10) not null,
dataabastecimento datetime not null,
valor decimal (9,2) not null,
foreign key (Placa) references tblveiculo (Placa)
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblpneu (
idpneu int primary key not null,
marca varchar (20),
tamanho int null,
preco decimal (8,2) not null,
pneuobs varchar(100) null
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblsolicitacaopneu(
idsolicitacao int primary key not null,
idpneu int not null,
placa varchar (10) not null,
quantidade int not null,
datasolicitacao datetime not null,
observacao varchar (20) null,
foreign Key (idpneu) references tblpneu (idpneu),
foreign Key (placa) references tblveiculo (placa)
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblpeca (
idpeca int primary key not null,
valorpeca decimal (9,2) not null,
marca varchar (20) not null,
peca varchar(20) not null,
pecaobs varchar(100) null
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblmanutencao (
odsmanutencao int primary key not null,
idpeca int not null,
placa varchar(10) not null,
problemas varchar(500) not null,
datamanu datetime not null,
tipodemanu varchar(100),
foreign Key (idpeca) references tblpeca (idpeca),
foreign Key (placa) references tblveiculo (placa)
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tblmultas(
idautoinfracao int not null primary key,
placa varchar (10) not null,
idmotorista int not null,
vencimento datetime not null,
valor decimal(12,2) not null,
foreign Key (idmotorista) references tblmotorista (idmotorista),
foreign Key (placa) references tblveiculo (placa)
)

-- TELA E ACÕES CRIADAS COM SUCESSO (ADCIONAR, ALTERAR, EXCLUIR)
CREATE TABLE tbllocacao(
idlocacao int not null primary key,
placa varchar(10) not null,
valorlocacao decimal(12,2) not null,
datalocacao datetime not null,
foreign Key (placa) references tblveiculo (placa)
)


INSERT INTO tblmultas  
values (1, 'THI9078', 5, '10/02/2000', 200); 

select * from tblveiculo;

select * from tblabastecimento;

select idmotorista from tblmotorista;

select nome from tblmotorista;

insert into tblmultas (idautoinfracao, placa, idmotorista, vencimento, valor)
values (2, 'TRE6544', 5, '10/05/2000', 200)
select ; 


select nome from tblmotorista where idmotorista = 1


drop TABLE tblsaidaveiculo
