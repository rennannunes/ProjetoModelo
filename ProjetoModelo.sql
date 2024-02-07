-- Criação da tabela cad_pessoa
CREATE TABLE cad_pessoa (
    id INT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
	cpf VARCHAR(11) NOT NULL,
	email VARCHAR(245),
	telefone VARCHAR(20) NOT NULL,
    data_nascimento DATETIME,
    createdBy VARCHAR(145),
	createdDate DATETIME,
	alteredBy VARCHAR(145),
	alteredDate DATETIME
);

-- Criação da tabela cad_aluno com referência à cad_pessoa
CREATE TABLE cad_aluno (
    id INT PRIMARY KEY,
	login VARCHAR(45),
	senha VARCHAR(45),
	createdBy VARCHAR(145),
	createdDate DATETIME,
	alteredBy VARCHAR(145),
	alteredDate DATETIME,
    id_pessoa INT FOREIGN KEY REFERENCES cad_pessoa(id)
);

-- Criação da tabela cad_funcionario com referência à cad_pessoa
CREATE TABLE cad_funcionario (
    id INT PRIMARY KEY,
	login VARCHAR(45),
	senha VARCHAR(45),
    cargo VARCHAR(50),
    createdBy VARCHAR(145),
	createdDate DATETIME,
	alteredBy VARCHAR(145),
	alteredDate DATETIME,
	id_pessoa INT FOREIGN KEY REFERENCES cad_pessoa(id),
);

CREATE TABLE cad_endereco (
    id INT PRIMARY KEY,
    cep VARCHAR(45),
	bairro VARCHAR(45),
	cidade VARCHAR(45),
	estado VARCHAR(45),
	rua VARCHAR(45),
	numero VARCHAR(10),
	complemento VARCHAR(45),
	id_pessoa INT FOREIGN KEY REFERENCES cad_pessoa(id),
);