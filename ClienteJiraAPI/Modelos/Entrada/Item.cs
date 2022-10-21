using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Item
	{
		public string id { get; set; }
		public string self { get; set; }
		public string key { get; set; }
		public Campos fields { get; set; }
	}
}
