- [1. Pré-Requisitos](#1-pré-requisitos)
  - [1.1. Para desenvolvimento](#11-para-desenvolvimento)
  - [1.2. Somente para compilar e executar](#12-somente-para-compilar-e-executar)
- [2. Instruções de construção, execução e uso da API](#2-instruções-de-construção-execução-e-uso-da-api)
- [3. Banco de Dados do Projeto](#3-banco-de-dados-do-projeto)

# Projeto Formulário de Usuário 

O Formulário de Usuários trata-se de um sistema desenvolvido para mapear, armazenar e coletar usuários registrados.  O objetivo é fornecer esta implementação como entrega de um exame.

* Data: 05/01/2023
* Versão atual: 1.0 (manter pacotes atualizados na versão 6.0.12)

## 1. Pré-Requisitos

### 1.1. Para desenvolvimento

* Windows 10 ou 11.
* [Visual Studio na última versão](https://visualstudio.microsoft.com/pt-br/downloads/)
* C# na última versão (Obtido diretamente pela IDE em conjunto com os subitens abaixo) 
* .NET Core v. 6.0.12 
  * Microsoft.EntityFrameworkCore v. 6.0.12 
  * Microsoft.EntityFrameworkCore.SqlServer v. 6.0.12
  * Microsoft.EntityFrameworkCore.Tools v. 6.0.12
  * Microsoft.VisualStudio.Web.CodeGeneration. v. 6.0.12 
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
* [SQL Server Management Studio](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

### 1.2. Somente para compilar e executar

* Em Sistema Operacional Windows
  * [C# última versão](https://dotnet.microsoft.com/en-us/download) 
  * [.NET 6.0.12](https://dotnet.microsoft.com/en-us/download)
  * [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)


## 2. Instruções de construção, execução e uso da API

Antes de executar certifique-se de que o SQL Server está executando corretamente com o banco de dados montado (ver Seção [3](#3-banco-de-dados-do-projeto) deste documento).

Antes de construir oa aplicação certifique-se de que o SQL Server esteja **sem autenticação** e com o banco de dados `meu-bd` criado corretamente. 

## 3. Banco de Dados do Projeto

O banco de dados não relacional deste projeto é hospedado no SQL Server. O nome utilizado por padrão é `meu-bd`.

Para administrar o banco através de uma interface gráfica, utilize o [SQL Server Management Studio](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads). A ferramenta já vem pronta para acessar o SQL Server local sem autenticação. Para criar o banco de dados digite a seguinte linha de comando:

```
Update-database -Context Context
```
