using Negocio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.IRepositorio
{
	public interface IRepositorioEpico
	{
		public Task<List<Epico>> BuscarEpicosComTarefasEmSprint(int idSprint);
		public Task<List<Epico>> BuscarEpicosComTarefasEmSprint(int idSprint, string usuario);
	}
}
