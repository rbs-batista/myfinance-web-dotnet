# My Finance Web Dotnet

Trabalho da disciplina de Práticas de Implementação e Evolução de Software, pertencente ao curso de Pós-Graduação em Engenharia de Software na PUCMG.

## Descriação

Plataforma que possibilita às famílias registrarem seus ganhos e gastos, visando a análise detalhada de suas despesas e, consequentemente, aprimorar o planejamento financeiro. Essa ferramenta permitirá que o usuário crie um Plano de Contas personalizado para categorizar todas as transações efetuadas. Além disso, é fundamental incluir relatórios de despesas, facilitando uma avaliação minuciosa da situação financeira.

## Arquitetura

 ![Arquitetura My Finance](/MyFinanceWeb-ModelagemArquitetural.png)

## Packages Utilizados

###  Front-End 
- Razor:
  - https://learn.microsoft.com/pt-br/aspnet/core/mvc/views/razor?view=aspnetcore-7.0

### Back-End
- AutoMapper:
  - https://www.nuget.org/packages/automapper/
  - AutoMapper.Extensions.Microsoft.DependencyInjection
  - Versão: 12.0.1
- Microsoft.EntityFrameworkCore.SqlServer
  - https://www.nuget.org/packages/Microsoft.EntityFrameworkCore
  - Versão: 7.0.13


## Requisitos

- ASP.NET Core:
  - https://dotnet.microsoft.com/en-us/download/dotnet/6.0
  - Versão: ^6.0

- Microsoft SQL Server - Ubuntu based images
  - https://hub.docker.com/_/microsoft-mssql-server

## Instalação
   
1. Clone o repositório do projeto:

   ```
   git clone https://github.com/rbs-batista/myfinance-web-dotnet.git
   
   ```

2. Acesse o diretório do projeto:

   ```
   cd myfinance-web-dotnet
   ```

3. Instale as dependências do projeto:

   ```
   dotnet restore
   ```
## Como Rodar

1. Para executar o projeto, utilize os seguintes comandos:

   ```
   dotnet build
   dotnet run
   ```

2. O servidor será iniciado e estará acessível no seguinte endereço:

   ```
   http://localhost:7031
   ```
