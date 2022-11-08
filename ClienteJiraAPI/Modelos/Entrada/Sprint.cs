using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Sprint
	{
		public int id { get; set; }
		public string name { get; set; }
		public string state { get; set; }
		public int boardId { get; set; }
		public string startDate { get; set; }
		public string endDate { get; set; }
	}
}
