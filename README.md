# 📌 API de Tarefas - ASP.NET Core

API RESTful simples para gerenciamento de tarefas (to-do list), desenvolvida com **ASP.NET Core**, **Entity Framework Core** e **SQL Server**. Documentação automática com **Swagger** e testes com **Postman** ou `curl`.

---

## 🚀 Funcionalidades

- ✅ Criar tarefa (POST)
- ✅ Listar todas as tarefas (GET)
- ✅ Buscar tarefa por ID (GET)
- ✅ Atualizar tarefa (PUT)
- ✅ Deletar tarefa (DELETE)

---

## 🛠 Tecnologias Utilizadas

- ASP.NET Core 6 / 7
- Entity Framework Core
- SQL Server (LocalDB)
- Swagger (Swashbuckle)
- Postman / curl para testes

---

## 📁 Estrutura do Projeto

api-tarefas-dotnet/
├── Controllers/
│ └── TarefasController.cs
├── Models/
│ └── Tarefa.cs
├── Data/
│ └── AppDbContext.cs
├── appsettings.json
└── Program.cs


---

## ⚙️ Como Rodar o Projeto Localmente

### 1. Clone o repositório
  git clone https://github.com//api-tarefas-dotnet.git
  cd api-tarefas-dotnet
2. Restaure os pacotes e compile
  dotnet restore
  dotnet build
3. Atualize o banco de dados
  dotnet ef migrations add InitialCreate
  dotnet ef database update
Verifique se o DefaultConnection no appsettings.json está apontando para um SQL Server local válido.

4. Rode a aplicação
dotnet run
Acesse no navegador

🧪 Testes com Swagger ou Postman
Exemplo: Criar tarefa (POST /api/tarefas)

{
  "titulo": "Estudar .NET",
  "descricao": "Revisar Entity Framework",
  "concluida": false
}

Exemplo com curl:

curl -X POST \
 -H "Content-Type: application/json" \
 -d "{\"titulo\": \"Nova tarefa\", \"descricao\": \"Testando\", \"concluida\": false}" -k
