# 📚 BooksAPI - .NET 10 Minimal API
Esta é uma API RESTful desenvolvida para fins de aprendizado, utilizando as tecnologias mais recentes do ecossistema .NET 10. O projeto gerencia um catálogo de livros de forma simples e extremamente performática.

## 🚀 Tecnologias Utilizadas
- Runtime: .NET 10 (Free Tier)
- Framework: ASP.NET Core (Minimal APIs)
- Banco de Dados: Entity Framework Core (In-Memory Database)
- Performance: Native AOT Ready com Source Generators para JSON
- Documentação: OpenAPI (Swagger/Scalar compatível)
  
## 🛠️ Funcionalidades (Endpoints)
API expõe os seguintes recursos em http://localhost:5068/livros:
| Método | Endpoint | Descrição |
| :--- | :--- | :--- | 
| GET | /livros |Lista todos os livros cadastrados. |
| GET | /livros/{id} | Busca um livro específico pelo ID. | 
| POST | /livros | Cadastra um novo livro. | 
| PUT | /livros/{id} | Atualiza os dados de um livro existente. | 
| DELETE | /livros/{id} | Remove um livro do catálogo. | 

## 📦 Como rodar o projeto
1. Pré-requisitos: Instalar o .NET 10 SDK.
2. Clonar o repositório: ```Bashgit clone https://github.com/seu-usuario/BooksApi.git
cd BooksApi```
3. Executar a aplicação: ```Bash dotnet run```
4. Testar:
   - Abra o seu navegador ou Postman em: http://localhost:5068/livros
   - A especificação da API estará disponível em: http://localhost:5068/openapi/v1.json

## 📝 Exemplo de JSON para POST/PUT

```
JSON{
  "titulo": "O deploy de sexta-feira",
  "autor": "Evander Teixeira"
}
```
