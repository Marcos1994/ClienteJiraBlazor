using AutoMapper;
using Negocio.IRepositorio;
using Negocio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servico
{
	public class ServicoEpico
	{
		private readonly IMapper mapper;
		private readonly IRepositorioEpico rEpico;

		public ServicoEpico(IMapper mapper, IRepositorioEpico rEpico)
		{
			this.mapper = mapper;
			this.rEpico = rEpico;
		}

		public async Task<List<Epico>> BuscarEpicosComTarefasPorSprint(int idSprint, string usuario)
		{
			return await rEpico.BuscarEpicosComTarefasEmSprint(idSprint, usuario);
		}
	}
}
