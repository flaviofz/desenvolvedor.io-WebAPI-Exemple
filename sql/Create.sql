create table Cliente(
    Id uniqueidentifier PRIMARY key,
    Telefone varchar(20) null,
    Idade int not null,    
)

create table Endereco(
    Id uniqueidentifier PRIMARY key,
    Estado varchar(2) not null,
    Cidade varchar(20) not null,
    Bairro varchar(50) not null,
    Numero int not null
)