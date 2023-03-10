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
			Epico epico = mapper.Map<Epico>(tarefa);

			string[] informacoesDescricao = epico.Descricao.Split(';');

			foreach (string info in informacoesDescricao)
			{
				string[] aux;
				if (info.ToUpper().Contains("-PEP:"))
				{
					aux = info.Split(':');
					if (aux.Length > 1)
					{
						epico.Pep = aux[1].Trim();
					}
				}
				else if (info.ToUpper().Contains("-PROPOSTA:"))
				{
					aux = info.Split(':');
					if (aux.Length > 1)
					{
						aux[1] = aux[1].Trim().Replace("R$", "");
						try
						{
							if (!string.IsNullOrWhiteSpace(aux[1]))
							{
								epico.OrcamentoTotal = Convert.ToDecimal(aux[1]);
							}
						}
						catch (Exception ex)
						{
							epico.OrcamentoTotal = 0;
						}
					}
				}
				else if (info.ToUpper().Contains("-SOLICITANTE:"))
				{
					aux = info.Split(':');
					if (aux.Length > 1)
					{
						epico.Solicitante = aux[1].Trim();
					}
				}
			}

			return epico;
		}

		public async Task<List<Tarefa>> BuscarTarefas(string chaveEpico)
		{
			IssueApiService service = new IssueApiService();
			List<ItemBase> tarefas = await service.GetItensPorEpicoAsync(chaveEpico);
			return mapper.Map<List<Tarefa>>(tarefas);
		}
	}
}
