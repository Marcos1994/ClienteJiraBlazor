using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public abstract class Item
	{
		public string id { get; set; }
		public string self { get; set; }
		public string key { get; set; }
	}
}
