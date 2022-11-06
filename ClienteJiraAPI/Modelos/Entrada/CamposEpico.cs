using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class CamposEpico : CamposDetalhados
	{
		/// <summary>
		/// Epic Name
		/// </summary>
		public string customfield_10601 { get; set; }
	}
}
