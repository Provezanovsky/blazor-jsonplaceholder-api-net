# BlazorUsersJsonPlaceHolderApi

Atividade em C# / .NET 8 com Blazor e interatividade no servidor.

## O que faz

- Consome `https://jsonplaceholder.typicode.com/users` com `HttpClient`.
- Desserializa a resposta como uma lista de usuários.
- Seleciona a primeira pessoa da lista e imprime nome, cidade e empresa com `Console.WriteLine`.
- Exibe os mesmos dados na página e permite consultar novamente.
- Código indentado e tratamento de falhas de rede, tempo limite, JSON inválido e lista vazia.

Os dados são obtidos da API; os valores do exemplo não estão fixados no código.

## Como executar

Instale o **SDK .NET 8**. Na raiz do repositório, execute:

```bash
dotnet run --project BlazorUsersJsonPlaceHolderApi --launch-profile http
```

Abra **http://localhost:5180**. Ao carregar a página, a aplicação consulta a API e imprime no **terminal do servidor** (não no console do navegador):

```text
Nome: Leanne Graham
Cidade: Gwenborough
Empresa: Romaguera-Crona
```

No IDE, com suporte ao .NET 8 e a carga de trabalho ASP.NET, abra o arquivo `BlazorUsersJsonPlaceHolderApi/BlazorUsersJsonPlaceHolderApi.csproj` e execute o perfil `http`.

## Organização

- `Program.cs`: configura Blazor e o cliente HTTP.
- `Models/User.cs`: representa os campos usados da resposta JSON.
- `Services/UserService.cs`: consulta a lista, seleciona o primeiro usuário e imprime os dados.
- `Components/Pages/Home.razor`: exibe os dados e controla a consulta.
