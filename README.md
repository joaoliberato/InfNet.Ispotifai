# InfNet.Ispotifai

Projeto de exemplo de uma aplicação de streaming de músicas, desenvolvido com .NET 8 e Razor Pages, seguindo arquitetura em camadas (WebApp, API, Application, Domain, Infrastructure).

## Projeto Publicado

Acesse a versão publicada na Azure:  
👉 [https://ispotifaiweb.azurewebsites.net/](https://ispotifaiweb.azurewebsites.net/)

## Visão Geral

O InfNet.Ispotifai simula funcionalidades básicas de um serviço de streaming musical, permitindo:
- Cadastro e autenticação de usuários
- Pesquisa de músicas
- Gerenciamento de músicas favoritas
- Escolha de planos de assinatura

A solução é composta por:
- **InfNet.Ispotifai.WebApp**: Frontend Razor Pages para interação do usuário
- **InfNet.Ispotifai.API**: API REST para operações de dados
- **InfNet.Ispotifai.Application/Domain/Infrastructure**: Camadas de negócio, domínio e acesso a dados

## Principais Funcionalidades

- Cadastro e login de usuários
- Pesquisa e listagem de músicas
- Adição e remoção de músicas favoritas
- Seleção de planos de assinatura
- Interface web responsiva

## Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Razor Pages
- Entity Framework Core (SQL Server)
- Swagger (documentação da API)

## Configuração e Execução

### Pré-requisitos

- .NET 8 SDK
- SQL Server (local ou Azure)
- Visual Studio 2022

### Configuração do Banco de Dados

1. Atualize a string de conexão em `InfNet.Ispotifai.API/appsettings.json` conforme seu ambiente.
2. Execute as migrations do Entity Framework para criar o banco: dotnet ef database update --project InfNet.Ispotifai.Infrastructure

### Executando a Aplicação

1. Inicie o projeto `InfNet.Ispotifai.API` para disponibilizar a API.
2. Inicie o projeto `InfNet.Ispotifai.WebApp` para acessar a interface web.
3. Acesse `https://localhost:<porta>/` no navegador.

### Configuração de URLs

- A URL base da API pode ser ajustada em `InfNet.Ispotifai.WebApp/appsettings.json` na chave `IspotifaiApiSettings:BaseUrl`.

## Uso

- Acesse a página inicial e realize o cadastro ou login.
- Pesquise músicas e adicione/remova dos favoritos.
- Gerencie seu plano de assinatura.

## Estrutura de Pastas

- `WebApp/`: Interface web (Razor Pages)
- `API/`: API REST
- `Application/`: Serviços de aplicação
- `Domain/`: Entidades e interfaces de domínio
- `Infrastructure/`: Acesso a dados e repositórios

## Licença

Este projeto é apenas para fins educacionais.
