using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Acompanhamento
	{
		public int originalEstimateSeconds { get; set; }
		public int remainingEstimateSeconds { get; set; }
		public int timeSpentSeconds { get; set; }
	}
}
