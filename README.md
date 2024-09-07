# API de Recomendações de Educação e Carreira Personalizada.

Este projeto é uma API desenvolvida com **ASP.NET Core** que fornece recomendações personalizadas de educação e carreira para usuários. A API permite gerenciar usuários e cursos, fornecendo operações CRUD (Create, Read, Update, Delete) para ambos.

## Funcionalidades

- **Gerenciamento de Usuários**: CRUD completo para usuários, incluindo a criação, listagem, atualização e exclusão de usuários.
- **Gerenciamento de Cursos**: CRUD completo para cursos, permitindo adicionar, listar, atualizar e excluir cursos.
- **Integração com Banco de Dados**: Utiliza Entity Framework Core com Oracle como banco de dados.

## Endpoints

### UsersController

- **GET** `/api/users`: Retorna a lista de todos os usuários.
- **GET** `/api/users/{id}`: Retorna os detalhes de um usuário específico por ID.
- **POST** `/api/users`: Cria um novo usuário.
- **PUT** `/api/users/{id}`: Atualiza as informações de um usuário existente.
- **DELETE** `/api/users/{id}`: Exclui um usuário específico.

### CoursesController

- **GET** `/api/courses`: Retorna a lista de todos os cursos.
- **GET** `/api/courses/{id}`: Retorna os detalhes de um curso específico por ID.
- **POST** `/api/courses`: Cria um novo curso.
- **PUT** `/api/courses/{id}`: Atualiza as informações de um curso existente.
- **DELETE** `/api/courses/{id}`: Exclui um curso específico.

## Como Rodar o Projeto

### Pré-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Oracle Database](https://www.oracle.com/database/)
- [Postman](https://www.postman.com/) (para testar a API)

### Passos para rodar:

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/sua-repositorio.git


2. Instale as dependências:
   ```bash
   dotnet restore

3. Configure a string de conexão com o Oracle no arquivo appsettings.json:
   ```bash
     {
      "ConnectionStrings": {
        "DefaultConnection": "oracle+oracledb://rm551096:130904@oracle.fiap.com.br:1521/ORCL"
      }
    }

4. Execute as migrações para criar o banco de dados:
   ```bash
     dotnet ef database update

5. Inicie o projeto:
   ```bash
     dotnet run

# Estrutura do Projeto
    ```bash
      EducationAndCareerRecommendationsAPI/
      ├── Controllers/
      │   ├── UsersController.cs
      │   └── CoursesController.cs
      ├── Data/
      │   └── ApplicationDbContext.cs
      ├── Models/
      │   ├── User.cs
      │   └── Course.cs
      ├── Repositories/
      │   ├── IRecommendationsRepository.cs
      │   └── RecommendationsRepository.cs
      ├── Services/
      │   ├── IRecommendationsService.cs
      │   └── RecommendationsService.cs
      ├── Program.cs
      ├── Startup.cs
      └── appsettings.json

# Controllers
- **UsersController:** Lida com operações relacionadas a usuários.
- **CoursesController:** Lida com operações relacionadas a cursos.
  
# Models
- **User.cs:** Representa a entidade de um usuário.
- **Course.cs:** Representa a entidade de um curso.
  
# Repositories
- **IRecommendationsRepository:** Interface para o repositório.
- **RecommendationsRepository:** Implementação do repositório.
  
# Services
- **IRecommendationsService:** Interface para o serviço.
- **RecommendationsService:** Implementação do serviço, responsável pela lógica de negócios.

# Migrações do Entity Framework
 - **Criar uma nova migração:**
     ```bash
       dotnet ef migrations add NomeDaMigracao

 - **Criar uma nova migração:**
     ```bash
       dotnet ef database update

# Swagger
## A API é documentada usando Swagger. Para visualizar a documentação e testar os endpoints diretamente no navegador, acesse:     
```bash
  https://localhost:5001/swagger
````

# Tecnologias Utilizadas
- **ASP.NET Core 6**
- **Entity Framework Core**
- **Oracle Database**
- **Swagger/OpenAPI**
- **C#**


