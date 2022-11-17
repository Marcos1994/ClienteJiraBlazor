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

		public async Task<Epico> BuscarEpico(string chave)
		{
			IssueApiService service = new IssueApiService();
			var tarefa = await service.GetJiraIssueAsync<ItemEpico>(chave);
			return mapper.Map<Epico>(tarefa);
		}
	}
}
