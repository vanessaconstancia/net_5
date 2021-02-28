using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace httpClientExemplo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string urlApi =  "https://jsonplaceholder.typicode.com/todos/";
            var client = new HttpClient();
            
            Console.WriteLine("\n Recurso .net 5");
            for(int i=1; i < 5; i++)
            {
                    Todo resposta = await client.GetFromJsonAsync<Todo>(urlApi+i);
                    Console.WriteLine($"Valor obtido da Api {resposta.id}, {resposta.title}");
            }

            Console.WriteLine("\n Versões anteriores");
            for(int i=1; i < 5; i++)
            {
                    var resposta = await client.GetAsync(urlApi+i);
                    var conteudoResposta = await resposta.Content.ReadAsStringAsync();
                    var objTodo = JsonConvert.DeserializeObject<Todo>(conteudoResposta);
                    Console.WriteLine($"Valor obtido da Api {objTodo.id}, {objTodo.title}");
            }

        }
    }
}
