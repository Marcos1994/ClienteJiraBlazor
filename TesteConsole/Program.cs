using AutoMapper;
using ClienteJiraAPI.Cliente;
using ClienteJiraAPI.Modelos.Entrada;
using Repositorio.Profiles;
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
			ItemTarefa item = await service.GetJiraIssueAsync<ItemTarefa>("NUMVALESA-2723");



			IMapper mapper;
			var mappingConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new UsuarioProfile());
				mc.AddProfile(new ComentarioProfile());
				mc.AddProfile(new TarefaProfile());
				mc.AddProfile(new SubtarefaProfile());
				mc.AddProfile(new EpicoProfile());
				mc.AddProfile(new ProjetoProfile());
				mc.AddProfile(new AnexoProfile());
				mc.AddProfile(new ApontamentoProfile());
				mc.AddProfile(new SprintProfile());
				mc.AddProfile(new RelacionamentoProfile());
			});
			mapper = mappingConfig.CreateMapper();
			Negocio.Modelos.Entidades.Tarefa tarefa = mapper.Map<Negocio.Modelos.Entidades.Tarefa>(item);

			Console.WriteLine("Hello World!");
		}
	}
}
