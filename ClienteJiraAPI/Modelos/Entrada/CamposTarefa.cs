using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteJiraAPI.Modelos.Entrada
{
	public class CamposTarefa
	{
		public Item parent { get; set; }
		public int timeEstimate { get; set; }
		public List<ItemRelacionado> issueLinks { get; set; }
		public string customfield_10600 { get; set; }
		public int timeSpent { get; set; }
		/// <summary>
		/// Sprints
		/// </summary>
		public List<Sprint> customfield_10300 { get; set; }
		public int timeOriginalEstimate { get; set; }
		/// <summary>
		/// Storypoints
		/// </summary>
		public double customfield_10004 { get; set; }
		public Prioridade priority { get; set; }
		public Apontamentos worklog { get; set; }
		public Acompanhamento timetracking { get; set; }
	}
}
