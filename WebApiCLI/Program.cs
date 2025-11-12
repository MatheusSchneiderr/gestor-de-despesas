
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using GestaodeDespesasAPI.Models;

namespace WebApiCLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                Despesa despesa = new Despesa();

                Console.WriteLine("--CADASTRO DE DESPESAS--");
                while (String.IsNullOrEmpty(despesa.Descricao))
                {
                    Console.WriteLine("DIGITE O NOME DA NOVA DESPESA");
                    despesa.Descricao = Console.ReadLine();
                }
                while (despesa.Valor == 0)
                {
                    Console.WriteLine("DIGITE O VALOR DA DESPESA");
                    try
                    {
                        despesa.Valor = Convert.ToDecimal(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("digite um valor válido!");
                    }   
                }

            
                Console.WriteLine("--CADASTRANDO NOVA DESPESA--");

                using (var httpClient = new HttpClient())
                {
                    var url = "http://localhost:5000/api/despesas";
                    var json = JsonConvert.SerializeObject(despesa);
                    var content =  new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(url, content);
                
                    Console.WriteLine(json);
                
                    if (response.IsSuccessStatusCode)
                        Console.WriteLine("Despesa Cadastrada com sucesso!");
                    else
                        Console.WriteLine($"error: {response.StatusCode}");
                
                
                } 
            }
        }
    }
}