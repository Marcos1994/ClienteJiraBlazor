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

		public async Task<Epico> BuscarEpico(string chave)
		{
			return await rEpico.BuscarEpico(chave);
		}
	}
}
