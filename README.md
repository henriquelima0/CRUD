# CRUD em C# com MySQL

Este é um projeto básico de CRUD (Create, Read, Update, Delete) em C# que utiliza MySQL como banco de dados.

## Pré-requisitos

Antes de começar, certifique-se de ter os seguintes requisitos instalados:

- [Visual Studio](https://visualstudio.microsoft.com/)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

## Configuração do Banco de Dados
1. Atualize as informações de conexão no arquivo `appsettings.json` no projeto.

Exemplo de configuração no arquivo `appsettings.json`:

```xml
<connectionStrings>
  <add name="MyConnectionString" connectionString="Server=localhost;Database=NomeDoSeuBancoDeDados;User=seuUsuario;Password=suaSenha;"/>
</connectionStrings>
```


## Funcionalidades
- Create: Adicionar novos registros ao banco de dados.
- Read: Recuperar e exibir informações do banco de dados.
- Update: Atualizar informações existentes no banco de dados.
- Delete: Remover registros do banco de dados.
