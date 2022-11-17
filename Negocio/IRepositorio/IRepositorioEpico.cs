using Negocio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.IRepositorio
{
	public interface IRepositorioEpico
	{
		public Task<Epico> BuscarEpico(string chave);
	}
}
