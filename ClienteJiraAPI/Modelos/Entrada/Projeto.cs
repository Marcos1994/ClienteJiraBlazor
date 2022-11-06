using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class Projeto
	{
		public string id { get; set; }
		public string key { get; set; }
		public string name { get; set; }
		public string projectTypeKey { get; set; }
		public Dictionary<string,string> avatarUrls { get; set; }
		public CategoriaProjeto projectCategory { get; set; }
	}
}
