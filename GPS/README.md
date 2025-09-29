# 🛰️ GPS API

API desenvolvida em **.NET 8** para gerenciamento de **Pontos de Interesse**.

---

## 🚀 Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/)
- Swagger (Swashbuckle)
- Entity Framework Core + MySQL
- [AutoMapper](https://automapper.org/) para mapeamento entre entidades e DTOs
- [xUnit](https://xunit.net/) + [Moq](https://github.com/moq) para testes unitários


---
## 📌 Exemplo de Consulta de Pontos Próximos

Considere a seguinte base de dados de POIs (Pontos de Interesse):

- 'Lanchonete' (x=27, y=12)
- 'Posto' (x=31, y=18)
- 'Joalheria' (x=15, y=12)
- 'Floricultura' (x=19, y=21)
- 'Pub' (x=12, y=8)
- 'Supermercado' (x=23, y=6)
- 'Churrascaria' (x=28, y=2)

Se o ponto de referência for **(x=20, y=10)** e a distância máxima for **10 metros**, o serviço `PontosProximos` retornará os seguintes POIs:

- Lanchonete
- Joalheria
- Pub
- Supermercado

> Este exemplo demonstra como a API filtra os pontos dentro de um raio específico a partir de uma coordenada fornecida.
---

## ⚙️ Configuração

1. **Clone o repositório**
   ```bash
   git clone https://github.com/seu-usuario/gps.git
   cd gps
Configure a connection string
No appsettings.json do projeto API, ajuste a conexão com seu banco MySQL:


Copiar código
```
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=GPS;User=root;Password=suasenha;"
}

```
Restaure pacotes e crie o banco

bash
Copiar código
```dotnet restore
dotnet ef database update

```
Execute a aplicação

A API estará disponível em:  
`https://localhost:7176/swagger`

📌 Endpoints Principais
Pontos de Interesse

GET /api/pontos → lista todos os pontos

POST /api/pontos → cria um novo ponto

GET /api/pontos/proximos?x=0&y=0&dist=10 → retorna pontos próximos de uma coordenada


👨‍💻 Autor
Desenvolvido por Lucas Melo 🚀


---

