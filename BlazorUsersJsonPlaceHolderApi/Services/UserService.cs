using System.Net.Http.Json;
using BlazorUsersJsonPlaceHolderApi.Models;

namespace BlazorUsersJsonPlaceHolderApi.Services;

public class UserService(HttpClient httpClient)
{
    public async Task<User?> GetFirstUserAsync()
    {
        // O endpoint retorna uma lista; selecionamos seu primeiro elemento.
        var users = await httpClient.GetFromJsonAsync<List<User>>("users");
        var firstUser = users?.FirstOrDefault();

        if (firstUser is not null)
        {
            // Console do servidor: terminal do dotnet run ou saída do Visual Studio.
            Console.WriteLine($"Nome: {firstUser.Name}");
            Console.WriteLine($"Cidade: {firstUser.Address.City}");
            Console.WriteLine($"Empresa: {firstUser.Company.Name}");
        }

        return firstUser;
    }
}
