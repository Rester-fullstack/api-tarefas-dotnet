# 📊 Dashboard de Vendas — SQL Server + Python

Este projeto realiza a **análise completa de vendas** usando **SQL Server** como fonte de dados e **Python** (Pandas + Matplotlib) para gerar gráficos e insights.  
Ideal para estudos de **Data Analytics**, **ETL básico**, **visualização de dados** e **consultas SQL reais**.

---

## 🚀 Tecnologias Utilizadas

### 🔹 Backend / Banco de Dados
- **SQL Server LocalDB**
- **Tabelas normalizadas com FK**
- **Consultas SQL otimizadas**

### 🔹 Data Analysis
- **Python 3**
- **Pandas** — limpeza e manipulação dos dados
- **Matplotlib** — geração dos gráficos
- **pyodbc** — conexão com SQL Server

---

## 📁 Estrutura do Projeto

dashboard-sql-python/
│
├── main.py # Script principal do dashboard
├── requeriments.txt # Dependências do Python
├── README.md # Documentação
│
├── assets/ # (opcional) Gráficos salvos
│ ├── vendas_mensais.png
│ ├── produtos_top.png
│ ├── receita_cidade.png
│ ├── receita_categoria.png
│ └── diagrama-db.png
│
└── database/ # (opcional) Scripts de banco
├── create_tables.sql
└── sample_data.sql

---

# 🗄️ Modelo do Banco de Dados

O projeto usa 3 tabelas principais:

CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100),
    Cidade NVARCHAR(100)
);

CREATE TABLE Produtos (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100),
    Categoria NVARCHAR(50),
    Preco DECIMAL(10, 2)
);

CREATE TABLE Vendas (
    Id INT PRIMARY KEY IDENTITY,
    ClienteId INT FOREIGN KEY REFERENCES Clientes(Id),
    ProdutoId INT FOREIGN KEY REFERENCES Produtos(Id),
    Quantidade INT,
    DataVenda DATE
);

### 📈 Vendas Mensais
![Vendas Mensais](assets/vendas_mensais.png)

### 🥇 Produtos Mais Vendidos
![Produtos Top](assets/produtos_top.png)

### 🏙️ Receita por Cidade
![Receita Cidade](assets/receita_cidade.png)

### 🧩 Receita por Categoria
![Categoria](assets/receita_categoria.png)

🔍 Análises Realizadas
O dashboard apresenta:

✔ Receita mensal total
✔ Produtos mais vendidos
✔ Receita por categoria
✔ Receita por cidade
✔ Quantidade total vendida por produto
✔ Agrupamentos e agregações em SQL e Pandas
Essas análises demonstram domínio de:

Group By

Joins

Manipulação em DataFrames

Visualização com Matplotlib

⚙️ Como Executar o Projeto
1️⃣ Clone o repositório

git clone <URL_DO_REPOSITORIO>
cd dashboard-sql-python

2️⃣ Configure o banco de dados
Crie o banco no SQL Server:

CREATE DATABASE VendasDB;
Execute os scripts (se você colocar eles na pasta database/):

database/create_tables.sql
database/sample_data.sql

3️⃣ Instale as dependências do Python

pip install -r requeriments.txt

4️⃣ Execute o dashboard:

python main.py
Os gráficos serão gerados automaticamente.

🔌 Configuração da Conexão com o Banco
No arquivo main.py, altere a string de conexão caso necessário:

python

conn = pyodbc.connect(
    "Driver={SQL Server};Server=(localdb)\\MSSQLLocalDB;Database=VendasDB;"
)

🧠 Como o Script Funciona (Fluxo)
pgsql

main.py
 ├── conecta ao SQL Server via pyodbc
 ├── faz consultas SQL (joins + group by)
 ├── converte resultados em DataFrames Pandas
 ├── gera gráficos com Matplotlib
 ├── salva os gráficos em /assets
 └── exibe o dashboard
 
🏁 Resultado Final
Um dashboard analítico funcional contendo gráficos como:

📈 Vendas por mês

🥇 Produtos mais vendidos

🧩 Receita por categoria

🏙️ Receita por cidade

Tudo utilizando SQL + Python, o que é muito valorizado para:

vagas de análise de dados,

engenharia de dados,

back-end,

estágios e trainees de TI.

📜 Licença
MIT © 2025 — Ester da Costa Batista

