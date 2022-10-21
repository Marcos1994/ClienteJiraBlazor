using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Progresso
	{
		public int progress { get; set; }
		public int total { get; set; }
		public double percent { get; set; }
	}
}
