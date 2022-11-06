using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Usuario
	{
		public int Id { get; private set; }
		public string Email { get; private set; }
		public string UrlAvatar { get; private set; }
		public string Nome { get; private set; }
		public bool Ativo { get; private set; }
		public List<Remuneracao> HistoricoRemuneracao { get; private set; }
		public List<Epico> Epicos { get; private set; }
		public List<Tarefa> Tarefas { get; private set; }

		public Usuario()
		{
			HistoricoRemuneracao = new List<Remuneracao>();
			Epicos = new List<Epico>();
			Tarefas = new List<Tarefa>();
		}

		public double RemuneracaoAtual()
		{
			Remuneracao r = HistoricoRemuneracao.FirstOrDefault(r => r.Final == null);
			return (r == null)
				? 0 : r.Valor;
		}

		public double RemuneracaoEm(DateTime data)
		{
			Remuneracao remuneracao = (from r in HistoricoRemuneracao
									  where r.Final <= data && r.Inicio >= data
									  orderby r.Inicio descending
									  select r).FirstOrDefault();
			return (remuneracao == null)
				? 0 : remuneracao.Valor;
		}
	}
}
