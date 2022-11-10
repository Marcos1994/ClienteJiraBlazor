using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Usuario
	{
		public Usuario()
		{

		}

		public Usuario(string accountId, string email, string urlAvatar, string nome, bool ativo)
		{
			AccountId = accountId;
			Email = email;
			UrlAvatar = urlAvatar;
			Nome = nome;
			Ativo = ativo;
		}

		public string AccountId { get; private set; }
		public string Email { get; private set; }
		public string UrlAvatar { get; private set; }
		public string Nome { get; private set; }
		public bool Ativo { get; private set; }
		public List<Remuneracao> HistoricoRemuneracao { get; private set; } = new List<Remuneracao>();
		public List<Epico> Epicos { get; private set; } = new List<Epico>();
		public List<Tarefa> Tarefas { get; private set; } = new List<Tarefa>();

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
