# BellosoftTest API – Junior Backend Developer Coding Assessment

Projeto desenvolvido como parte do teste para Junior Backend Developer. Trata-se de uma API RESTful em .NET 8 que integra com a API externa ViaCEP para cadastro e consulta de clientes, demonstrando conhecimentos em desenvolvimento de APIs, integração de terceiros, persistência de dados e boas práticas de backend.

Funcionalidades principais:

Integração com a API ViaCEP para busca de endereços por CEP. Cadastro de clientes no banco PostgreSQL utilizando dados processados da API externa. Consulta de clientes por ID. Pesquisa de clientes por nome. Listagem de todos os clientes. Atualização de clientes via ID. Deleção de clientes via ID. Uso de DTOs e AutoMapper para mapeamento de dados e maior privacidade. Swagger UI para documentação e testes da API. Postman Collection disponível para testar todos os endpoints.

Tecnologias utilizadas: .NET 8, C#; Entity Framework Core para acesso e gerenciamento do banco de dados PostgreSQL; AutoMapper versão 13.0.1 para conversão entre entidades e DTOs; PostgreSQL como banco de dados relacional; ViaCEP API para integração de dados externos; Swagger para documentação da API.

Pré-requisitos: .NET SDK 8 instalado; PostgreSQL rodando localmente ou em container; Ferramenta cliente SQL (pgAdmin, DBeaver ou similar); Postman (para usar a collection de teste); Instalação e configuração; Clone o repositório e entre na pasta do projeto. Restaure as dependências do projeto com dotnet restore. No arquivo appsettings.json, configure a connection string para seu banco PostgreSQL. Garanta que os pacotes AutoMapper e AutoMapper.Extensions.Microsoft.DependencyInjection estejam na mesma versão (13.0.1). Crie as tabelas no banco usando as migrations do Entity Framework Core com dotnet ef database update. Execute a aplicação com dotnet run. A API ficará disponível via HTTPS, e a documentação dos endpoints estará acessível via Swagger UI. Postman Collection: utilize o arquivo fornecido para testar todos os endpoints, incluindo cadastro, consulta, atualização e deleção de clientes. Cadastro de Clientes;

O endpoint de cadastro permite criar um novo cliente com informações pessoais, contatos e endereços. O JSON esperado deve seguir a estrutura: nome: nome completo do cliente contatos: lista de contatos do cliente. Cada contato deve ter: tipo: o tipo do contato, que deve ser um dos valores "email", "telefone" ou "outro" texto: a informação correspondente ao tipo escolhido: Se tipo for "email", insira o endereço de email (ex: "joao.silva@email.com") Se tipo for "telefone", insira o número de telefone completo (ex: "+5511999999999") Se tipo for "outro", insira a informação do outro meio de contato (ex: "Telegram: @joaosilva") enderecos: lista de endereços do cliente. Cada endereço deve ter: cep: CEP do endereço numero: número da residência ou estabelecimento complemento: informações adicionais do endereço (opcional).

Exemplo de JSON preenchido:

{ "nome": "João Silva", "contatos": [ { "tipo": "email", "texto": "joao.silva@email.com " }, { "tipo": "telefone", "texto": "+5511999999999" }, { "tipo": "outro", "texto": "Telegram: @joaosilva" } ], "enderecos": [ { "cep": "12345000", "numero": "100", "complemento": "Apto 101" } ] }

Boas práticas aplicadas: Organização do código com separação de responsabilidades (Controllers, Services, Mappers, DTOs); Tratamento de erros e validações básicas nas operações; Uso de DTOs para proteger dados sensíveis; Migrations do EF Core para versionamento do banco de dados; Documentação via Swagger UI; Histórico de commits estruturado, com mensagens claras e incrementais; Postman Collection para testes práticos de todos os endpoints;

Links relevantes: Documentação da API ViaCEP: https://viacep.com.br

Próximos passos: Implementar autenticação JWT; Criar testes unitários e de integração; Containerização com Docker; Deploy em nuvem (Heroku, Railway ou Azure).

Observações importantes: Não incluir credenciais de produção; Garantir que AutoMapper esteja na versão correta (13.0.1) para evitar conflitos; A criatividade na escolha da API externa e na implementação das features foi considerada para este teste.

Use a Postman Collection fornecida para validar todos os endpoints e fluxos de cadastro, consulta, atualização e deleção.
