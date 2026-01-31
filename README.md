# 📚 BooksAPI - .NET 10 Minimal API

API REST desenvolvida com **ASP.NET Core 10** para gerenciamento de um catálogo de livros, utilizando persistência em memória e alta performance.

## 🚀 Tecnologias
- **C# 14** & **.NET 10**
- **Entity Framework Core** (In-Memory)
- **OpenAPI** (Documentação nativa)
- **Source Generators** (Otimização de JSON)

## 🛠️ Como Executar
1. Instale o SDK do .NET 10.
2. Clone o repositório: `git clone https://github.com/seu-usuario/BooksApi.git`
3. Execute: `dotnet run`
4. A API estará disponível em: `http://localhost:5068/livros`

## 📡 Endpoints (Testados via Postman)
- `GET /livros`: Lista todos os livros.
- `GET /livros/{id}`: Busca por ID.
- `POST /livros`: Cadastra novo (Enviar JSON no Body).
- `PUT /livros/{id}`: Atualiza um registro.
- `DELETE /livros/{id}`: Remove um registro.

---
Desenvolvido por Evander Teixeira