using System;

namespace Negocio.Modelos.Entidades
{
	public class Apontamento
	{
		public Apontamento()
		{

		}

		public Apontamento(int tempo, DateTime data)
		{
			Tempo = tempo;
			Data = data;
		}

		public int Tempo { get; private set; }
		public DateTime? Data { get; private set; }
	}
}