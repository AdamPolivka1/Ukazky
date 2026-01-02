using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Objects;

Console.WriteLine("=== HTTP Client ===");

Console.WriteLine("Vyberte možnost (C|R|U|D): ");
Console.WriteLine("[C] Vytvoření záznamu POST");
Console.WriteLine("[R] Čtení záznamu GET");
Console.WriteLine("[U] Upravení záznamu PATCH");
Console.WriteLine("[D] Smazání záznamu DELETE");
Console.Write("Vyberte možnost: ");
char Action = Console.ReadKey().KeyChar
                    .ToString()
                    .ToUpper()
                    .ToCharArray()[0];


Console.WriteLine("\n");
const String API_PATH = "https://jsonplaceholder.typicode.com";

HttpClient client = new HttpClient() { 
    BaseAddress = new Uri(API_PATH)
};

// GET
if (Action == 'R')
{
    using (HttpResponseMessage msg = await client.GetAsync("/users/6"))
    {
        var jsonResponseString = await msg.Content.ReadAsStringAsync();

        var ops = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        User user = JsonSerializer.Deserialize<User>(jsonResponseString, ops);

        if (user != null)
        {
            Console.WriteLine($"Uživatel s ID {user.Id}");
            Console.WriteLine($"\tName: {user.Name}");
            Console.WriteLine($"\tUsername: {user.Username}");
        }

        Console.WriteLine("\n\nInformace o požadavku");
        Console.WriteLine($"StatusCode: {msg.StatusCode}");
        Console.WriteLine($"=== Headers ===\n{msg.Headers}");
    }
}

// POST (CREATE)
if (Action == 'C') {
    var newUser = new User()
    {
        Id = 11,
        Name = "Adam",
        Username = "adm1"
    };

    using (HttpResponseMessage response = await client.PostAsJsonAsync("users", newUser)) {
        var StatusCode = response.EnsureSuccessStatusCode();
        Console.WriteLine($"StatusCode: {StatusCode}");

        var user = await response.Content.ReadFromJsonAsync<User>();
        if (user != null)
        {
            Console.WriteLine($"Uživatel s ID {user.Id}");
            Console.WriteLine($"\tName: {user.Name}");
            Console.WriteLine($"\tUsername: {user.Username}");
        }
    }
}

// PATCH (UPDATE)
if (Action == 'U') {
    using StringContent jsonContent = new(
        JsonSerializer.Serialize(new
        {
            Id = 1,
            Name = "Adam",
            Username = "adm1"
        }),
        Encoding.UTF8,
        "application/json");

    using HttpResponseMessage response = await client.PutAsync("users/1", jsonContent);

    var StatusCode = response.EnsureSuccessStatusCode();
    Console.WriteLine($"StatusCode: {StatusCode}");
}

// DELETE
if (Action == 'D') {
    using HttpResponseMessage response = await client.DeleteAsync("users/1");
    var StatusCode = response.EnsureSuccessStatusCode();
    Console.WriteLine($"{StatusCode}\n");
}