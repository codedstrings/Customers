using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;
using TodoTest.Helper;

namespace TodoTest
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            #region HttpGet
            Console.WriteLine("Press any key to call API");
            Console.ReadLine();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var todo = JsonConvert.DeserializeObject<List<Todo>>(json);
                foreach (Todo item in todo)
                {
                    Console.WriteLine($"userId: {item.userId}");
                    Console.WriteLine($"Username: {item.id}");
                    Console.WriteLine($"Title: {item.title}");
                    string status = item.completed ? "completed" : "incomplete";
                    Console.WriteLine($"Status: {status}");
                    Console.WriteLine();    
                }
            }
            else
            {
                Console.WriteLine("Failed to fetch data. Status code: " + response.StatusCode);
            }
            #endregion
        }
    }
}
