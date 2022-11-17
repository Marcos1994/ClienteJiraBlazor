using AutoMapper;
using ClienteJiraAPI.Cliente;
using ClienteJiraAPI.Modelos.Entrada;
using Negocio.IRepositorio;
using Negocio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositorios
{
	public class RepositorioTarefa : IRepositorioTarefa
	{
		private readonly IMapper mapper;

		public RepositorioTarefa(IMapper mapper)
		{
			this.mapper = mapper;
		}

		public async Task<Tarefa> BuscarTarefa(string chave)
		{
			IssueApiService service = new IssueApiService();
			var tarefa = await service.GetJiraIssueAsync<ItemTarefa>(chave);
			return mapper.Map<Tarefa>(tarefa);
		}

		public async Task<List<Tarefa>> BuscarTarefasPorSprint(int idSprint, string usuario)
		{
			IssueApiService service = new IssueApiService();
			List<ItemBase> itens = await service.GetItensPorSprintAsync(idSprint, usuario);

			return mapper.Map<List<Tarefa>>(itens);
		}
	}
}
