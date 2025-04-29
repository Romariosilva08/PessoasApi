# PessoasApp

Este projeto foi gerado utilizando o [Angular CLI](https://github.com/angular/angular-cli) versão 19.2.9 para o frontend, com uma API em **.NET** para o backend.

## 📋 Instruções para execução do projeto

### 1. 🖥️ Configuração do Backend (API - PessoasApi)

O backend foi desenvolvido em **.NET** e é responsável por fornecer as APIs que o frontend consome.

#### 🔧 Pré-requisitos:
- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)
- Editor de código ([Visual Studio](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/))

#### 🚀 Configuração e execução:
1. Navegue até a pasta do projeto da API
2. Execute:
```bash
dotnet run
A API estará disponível em:
🔗 http://localhost:5215
📚 Documentação Swagger: http://localhost:5215/swagger

⚙️ Exemplo de launchSettings.json:
json
{
  "$schema": "https://json.schemastore.org/launchsettings.json",
  "profiles": {
    "PessoasApi": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "http://localhost:5215",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
2. 💻 Configuração do Frontend (PessoasApp)
Frontend desenvolvido em Angular.

🔧 Pré-requisitos:
Node.js (versão 14+)

Angular CLI (instalar globalmente):

bash
npm install -g @angular/cli
📦 Instalação:
Na pasta do frontend, execute:

bash
npm install
🚀 Execução:
bash
ng serve
A aplicação estará disponível em:
🌐 http://localhost:4200

🔄 O servidor de desenvolvimento recarrega automaticamente ao modificar arquivos fonte.

🔗 Conexão Frontend-Backend
Certifique-se que:

A API está rodando antes de iniciar o frontend

As URLs de API no frontend apontam para http://localhost:5215

🛠️ Estrutura do Projeto
PessoasApp/
├── backend/      # API .NET
└── frontend/     # Aplicação Angular
ℹ️ Suporte
Para problemas de configuração, consulte a documentação oficial:

Angular CLI

.NET Documentation