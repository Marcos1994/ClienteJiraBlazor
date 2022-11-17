using Negocio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.IRepositorio
{
	public interface IRepositorioTarefa
	{
		public Task<Tarefa> BuscarTarefa(string chave);
		public Task<List<Tarefa>> BuscarTarefasPorSprint(int idSprint, string usuario);
	}
}
