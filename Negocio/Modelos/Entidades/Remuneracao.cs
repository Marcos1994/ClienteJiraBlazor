using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades
{
	public class Remuneracao
	{
		public double Valor { get; private set; }
		public DateTime Inicio { get; private set; }
		public DateTime Final { get; private set; }
	}
}
