using AutoMapper;
using Negocio.IRepositorio;
using Negocio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servico
{
	public class ServicoTarefa
	{
		private readonly IMapper mapper;
		private readonly IRepositorioTarefa rTarefa;

		public ServicoTarefa(IMapper mapper, IRepositorioTarefa rTarefa)
		{
			this.mapper = mapper;
			this.rTarefa = rTarefa;
		}

		public async Task<Tarefa> BuscarTarefa(string chave)
		{
			return await rTarefa.BuscarTarefa(chave);
		}
	}
}
