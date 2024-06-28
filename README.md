# Projeto ASP.NET Core MVC

Este projeto é um exemplo de uma aplicação web utilizando o padrão de arquitetura Model-View-Controller (MVC) com ASP.NET Core.

## Visão Geral do MVC

MVC é um padrão de design que separa a aplicação em três componentes principais:

- **Model (Modelo)**: Representa os dados da aplicação e a lógica de negócios. Os modelos são responsáveis por recuperar, armazenar e validar dados.
- **View (Visão)**: Responsável pela apresentação dos dados. As views são os componentes da interface do usuário que exibem os dados dos modelos e fornecem formas de interação.
- **Controller (Controlador)**: Gerencia a comunicação entre os modelos e as views. Os controladores recebem as entradas dos usuários, processam as solicitações, interagem com os modelos e retornam as respostas apropriadas às views.

## Estrutura do Projeto

A estrutura típica de um projeto ASP.NET Core MVC inclui as seguintes pastas:

- `Controllers`: Contém os controladores que respondem às solicitações dos usuários.
- `Models`: Contém os modelos da aplicação.
- `Views`: Contém as views que são renderizadas como HTML para o usuário final.
- `wwwroot`: Contém arquivos estáticos, como CSS, JavaScript e imagens.

## Configuração do Ambiente

### Pré-requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download) instalado
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/) instalado

![diagrama](https://github.com/MKawan/api-ef-mvc-agenda/assets/51447066/eca6e928-3369-4631-98f5-c0f2863918ef)

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_ef_mvc_agenda.Models
{
    public class Agenda
    {
        public enum TypesStatus
        {
            Pendente,
            Finalizado,
            Aguardando
        }
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }   
        public TypesStatus Status  { get; set; }  
    }
}
```

```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```

### Clonar o Repositório

```bash
git clone https://github.com/MKawan/api-ef-mvc-agenda.git

cd api-ef-mvc-agenda

dotnet restore

dotnet watch run

```
