using System.Text.Json;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var streamJson = File.ReadAllText("User.json");
            User? jsonDes = JsonSerializer.Deserialize<User>(streamJson);
            Console.WriteLine("Parsed user = {0}, {1}, {2}, {3}", jsonDes.Id, jsonDes.Password, jsonDes.Email, jsonDes.Name);
            streamJson = File.ReadAllText("Admin.json");
            Admin? admin = JsonSerializer.Deserialize<Admin>(streamJson);
            Console.WriteLine("The admin is = {0}, {1}, {2}, {3}, {4}", admin.Name, admin.Password, admin.Age, admin.Email, admin.Balance);
        }
    }
}