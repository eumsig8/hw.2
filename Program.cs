using System.Text.Json;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var streamJson = File.ReadAllText("user1.json");
            user? jsonDes = JsonSerializer.Deserialize<user>(streamJson);
            Console.WriteLine("Parsed user = {0}, {1}, {2}, {3}", jsonDes.Id, jsonDes.Password, jsonDes.Email, jsonDes.Name);
            streamJson = File.ReadAllText("admin1.json");
            admin? admin1 = JsonSerializer.Deserialize<admin>(streamJson);
            Console.WriteLine("The admin is = {0}, {1}, {2}, {3}, {4}, {5}", admin1.Name, admin1.Password, admin1.Age, admin1.Email, admin1.Balance, admin1.Id);
        }
    }
}