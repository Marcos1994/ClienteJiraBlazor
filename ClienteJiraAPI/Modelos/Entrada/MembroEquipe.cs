using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class MembroEquipe
	{
		public int accountId { get; set; }
		public string emailAddress { get; set; }
		public Dictionary<string,string> avatarUrls { get; set; }
		public string displayName { get; set; }
		public bool active { get; set; }
		public string accountType { get; set; }
	}
}
