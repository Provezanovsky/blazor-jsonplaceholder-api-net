namespace BlazorUsersJsonPlaceHolderApi.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Address Address { get; set; } = new();
    public Company Company { get; set; } = new();
}

public class Address
{
    public string City { get; set; } = string.Empty;
}

public class Company
{
    public string Name { get; set; } = string.Empty;
}
