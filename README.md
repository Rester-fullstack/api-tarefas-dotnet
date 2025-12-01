# ✅ API de Tarefas — ASP.NET Core 8 + Entity Framework Core

Esta é uma API REST completa para gerenciamento de **tarefas**, construída com **ASP.NET Core 8**, **Entity Framework Core**, **Migrations** e **SQL Server**.  
Ideal para estudos e demonstração prática de CRUD, camadas, persistência e boas práticas no .NET.

---

## 🚀 Tecnologias Utilizadas

- **ASP.NET Core 8 (Web API)**
- **Entity Framework Core 8**
- **SQL Server / LocalDB**
- **Migrations**
- **Swagger / OpenAPI**
- **LINQ**
- **C# 12**

---

## 📌 Funcionalidades da API

A API permite:

✔ Criar uma tarefa  
✔ Listar todas as tarefas  
✔ Buscar tarefa por ID  
✔ Atualizar tarefa  
✔ Excluir tarefa  
✔ Filtrar tarefas por status, título ou data (caso implementado no seu controller)

---

## 📁 Estrutura do Projeto

api-tarefas-dotnet/
│
├── Controllers/
│ └── TarefaController.cs # Endpoints da API
│
├── Data/
│ ├── AppDbContext.cs # Classe de contexto EF Core
│ └── SqlServerConnection.cs # (se existir)
│
├── Migrations/ # Migrações do Entity Framework
│
├── Models/
│ └── Tarefa.cs # Modelo da entidade
│
├── Properties/
│
├── appsettings.json # Configurações do SQL Server
├── Program.cs # Configuração principal do app
└── README.md

---

## 🗄️ Modelo da Entidade

Exemplo do modelo **Tarefa**:

public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public bool Concluida { get; set; }
}
🔌 Configuração do Banco de Dados
No arquivo appsettings.json, a API usa:

"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=TarefasDB;Trusted_Connection=True;"
}

🗃️ Criar a base de dados (Migrations)
Execute os comandos:

dotnet ef database update
Para criar novas migrations:

dotnet ef migrations add NomeDaMigration

📍 Endpoints da API
Com Swagger ativo, você pode testar todos os endpoints.

▶ POST — Criar tarefa
/api/tarefa

▶ GET — Buscar todas as tarefas
/api/tarefa

▶ GET — Buscar por ID
/api/tarefa/{id}

▶ PUT — Atualizar tarefa
/api/tarefa/{id}

▶ DELETE — Excluir tarefa
/api/tarefa/{id}

🧪 Exemplo de JSON (POST)

{
  "titulo": "Estudar ASP.NET",
  "descricao": "Praticar API REST com EF Core",
  "concluida": false
}

▶ Como Executar o Projeto
1️⃣ Clonar o repositório

git clone <URL_DO_REPO>
cd api-tarefas-dotnet

2️⃣ Restaurar dependências

dotnet restore

3️⃣ Atualizar banco de dados (migrations)

dotnet ef database update

4️⃣ Rodar a API

dotnet run
A API ficará disponível em:

https://localhost:7080/swagger

📊 Swagger / Documentação
A API já vem com:

✔ Documentação automática
✔ Testes dos endpoints
✔ Modelos JSON
✔ Interface gráfica para requisições

🎯 Objetivo do Projeto
Este projeto demonstra de forma prática:

CRUD completo no ASP.NET Core

DataAnnotations

Entity Framework Core + Migrations

Padrão REST

Uso de controllers estruturados

Conexão com SQL Server usando appsettings.json

Boas práticas para APIs iniciantes

📜 Licença
MIT © 2025 — Ester da Costa Batista
