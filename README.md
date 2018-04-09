# ProjetoLivros feito com DDD, .Net Framework 4.6, Entity Framework 6, Web Api 2, Angular 5, MaterializeCSS e Sql Server.

O banco de dados é 'code first' e sua 'connection string' fica no Web.config do projeto Livro.Api.
Para criar o banco basta abrir o cmd do Nuget apontando para o projeto Livro.Infra.Data e digitar 'Update-Database -verbose'.

Para rodar o front basta abrir a pasta do projeto Livro.Ui no cmd e rodar os comandos 'npm install' e depois 'npm start'.
