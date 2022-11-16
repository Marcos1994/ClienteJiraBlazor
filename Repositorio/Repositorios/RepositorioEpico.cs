using AutoMapper;
using ClienteJiraAPI.Cliente;
using ClienteJiraAPI.Modelos.Entrada;
using Negocio.IRepositorio;
using Negocio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Repositorio.Repositorios
{
	public class RepositorioEpico : IRepositorioEpico
	{
		private readonly IMapper mapper;

		public RepositorioEpico(IMapper mapper)
		{
			this.mapper = mapper;
		}

		public async Task<List<Epico>> BuscarEpicosComTarefasEmSprint(int idSprint)
		{
			IssueApiService service = new IssueApiService();
			return await BuscarEpicosComTarefasEmSprint(idSprint, service.Usuario);
		}

		public async Task<List<Epico>> BuscarEpicosComTarefasEmSprint(int idSprint, string usuario)
		{
			IssueApiService service = new IssueApiService();
			List<ItemBase> itens = await service.GetItensPorSprintAsync(idSprint, usuario);
			List<Tarefa> tarefas = new List<Tarefa>();
			foreach (var i in itens)
			{
				tarefas.Add(mapper.Map<Tarefa>(await service.GetJiraIssueAsync<ItemTarefa>(i.key)));
			}

			List<Epico> epicos = new List<Epico>();
			foreach (string chave in (from i in tarefas where i.Epico != null select i.Epico.Chave).Distinct())
			{
				Epico epico = mapper.Map<Epico>(await service.GetJiraIssueAsync<ItemEpico>(chave));
				epico.Tarefas.AddRange((from t in tarefas where t.Epico != null && t.Epico.Chave == chave select t).ToList());
				epicos.Add(epico);
			}

			return epicos; // mapper.Map<List<Epico>>(itens);
		}
	}
}
