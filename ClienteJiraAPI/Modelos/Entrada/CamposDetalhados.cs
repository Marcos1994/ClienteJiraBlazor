using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class CamposDetalhados : Campos
	{
		public int aggregateTimeOriginalEstimate { get; set; }
		public int aggregateTimeEstimate { get; set; }
		public int aggregateTimespent { get; set; }
		/// <summary>
		/// Start Date
		/// </summary>
		public string customfield_12505 { get; set; }
		/// <summary>
		/// End Date
		/// </summary>
		public string customfield_12506 { get; set; }
		/// <summary>
		/// Alguma data
		/// </summary>
		public string customfield_10001 { get; set; }
		public MembroEquipe assignee { get; set; }
		public MembroEquipe creator { get; set; }
		public MembroEquipe reporter { get; set; }
		public string created { get; set; }
		public string updated { get; set; }
		public string description { get; set; }
		public Progresso aggregateProgress { get; set; }
		public Projeto project { get; set; }
		public List<Anexo> attachment { get; set; }
		public Comentarios comment { get; set; }
		public Progresso progress { get; set; }
		public List<string> labels { get; set; }
	}
}
