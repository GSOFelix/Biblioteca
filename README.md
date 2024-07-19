# Sistema de Cadastro e Empréstimo de Livros

## Descrição

Este é um programa com fim educacional desenvolvido em C# utilizando Windows Forms para o cadastro de livros, clientes e autores, além da realização de empréstimos de livros. Utilizando também banco de dados MySql. 

## Funcionalidades

- **Cadastro de Livros:** Permite adicionar informações sobre livros.
- **Cadastro de Clientes:** Permite adicionar informações dos clientes que utilizam a biblioteca.
- **Cadastro de Autores:** Permite adicionar dados dos autores dos livros.
- **Empréstimos de Livros:** Funcionalidade para registrar empréstimos de livros aos clientes.

## Tecnologias Utilizadas

- **Linguagem de Programação:** C#
- **Interface Gráfica:** Windows Forms
- **Banco de Dados:** MySQL

## Configuração do Banco de Dados

Na pasta `dados_bd` deste repositório, você encontrará o script necessário para gerar o banco de dados MySQL com alguns registros iniciais. Siga as instruções abaixo para configurar o banco de dados:

1. Abra seu cliente MySQL preferido (por exemplo, MySQL Workbench).
2. Importe e execute o script SQL encontrado em `dados_bd/BIBLIOTECA_backup.sql`.
3. Certifique-se de atualizar as configurações de conexão ao banco de dados na string em `Common\ConfiguracoesForm.cs` do projeto para corresponder às suas credenciais de acesso ao MySQL.

## Requisitos

- **.NET Framework:** Versão [net6.0]
- **MySQL Server:** Versão [8.4.1]

## Instalação

1. Clone o repositório:
    ```sh
    git clone https://github.com/GSOFelix/Biblioteca
    ```
2. Abra o projeto no Visual Studio.
3. Configure a string de conexão ao banco de dados em `Common\ConfiguracoesForm.cs` do projeto.
4. Compile e execute o projeto.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias e correções.


## Autores

- **Nome:** [Guilherme Felix, Vitor Oscar]
- **GitHub:** [https://github.com/GSOFelix] 
