using ClienteJiraAPI.Cliente;
using ClienteJiraAPI.Modelos.Entrada;
using System;
using System.Threading.Tasks;

namespace TesteConsole
{
	class Program
	{
		static async Task Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			IssueApiService service = new IssueApiService();
			ItemTarefa item = await service.GetJiraIssueAsync<ItemTarefa>("NUMVALESA-2727");
			Console.WriteLine("Hello World!");
		}
	}
}
