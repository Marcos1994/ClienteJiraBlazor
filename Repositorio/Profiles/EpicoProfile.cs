using AutoMapper;
using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Profiles
{
	public class EpicoProfile : Profile
	{
		public EpicoProfile()
		{
			CreateMap<ClienteJiraAPI.Modelos.Entrada.ItemEpico, Negocio.Modelos.Entidades.Epico>()
				.ForMember(d => d.Id, opt => opt.MapFrom(o => o.id))
				.ForMember(d => d.Chave, opt => opt.MapFrom(o => o.key))
				.ForMember(d => d.Nome, opt => opt.MapFrom(o => o.fields.customfield_10601))
				.ForMember(d => d.Status, opt => opt.MapFrom(o =>
					(o.fields.status.name == "Backlog") ? EnumStatus.Backlog :
					(o.fields.status.name == "Em andamento") ? EnumStatus.EmAndamento :
					(o.fields.status.name == "Concluído") ? EnumStatus.Concluido : EnumStatus.Backlog))
				.ForMember(d => d.Reportado, opt => opt.MapFrom(o => o.fields.reporter))
				.ForMember(d => d.Atribuido, opt => opt.MapFrom(o => o.fields.assignee))
				.ForMember(d => d.DataInicio, opt =>
				{
					opt.PreCondition(o => !string.IsNullOrEmpty(o.fields.customfield_12505));
					opt.MapFrom(o => Convert.ToDateTime(o.fields.customfield_12505));
				})
				.ForMember(d => d.DataLimite, opt =>
				{
					opt.PreCondition(o => !string.IsNullOrEmpty(o.fields.customfield_12506));
					opt.MapFrom(o => Convert.ToDateTime(o.fields.customfield_12506));
				})
				.ForMember(d => d.Descricao, opt => opt.MapFrom(o => o.fields.description))
				.ForMember(d => d.Projeto, opt => opt.MapFrom(o => o.fields.project))
				.ForMember(d => d.Rotulos, opt => opt.MapFrom(o => o.fields.labels))
				.ForMember(d => d.Anexos, opt => opt.MapFrom(o => o.fields.attachment))
				.ForMember(d => d.Comentarios, opt => opt.MapFrom(o => o.fields.comment.comments));

			CreateMap<ClienteJiraAPI.Modelos.Entrada.ItemBase, Negocio.Modelos.Entidades.Epico>()
				.ForMember(d => d.Id, opt => opt.MapFrom(o => o.id))
				.ForMember(d => d.Chave, opt => opt.MapFrom(o => o.key))
				.ForMember(d => d.Nome, opt => opt.MapFrom(o => o.fields.summary))
				.ForMember(d => d.Status, opt => opt.MapFrom(o =>
					(o.fields.status.name == "Backlog") ? EnumStatus.Backlog :
					(o.fields.status.name == "Em andamento") ? EnumStatus.EmAndamento :
					(o.fields.status.name == "Concluído") ? EnumStatus.Concluido : EnumStatus.Backlog))
				.ForMember(d => d.Reportado, opt => opt.MapFrom(o => o.fields.reporter))
				.ForMember(d => d.Atribuido, opt => opt.MapFrom(o => o.fields.assignee))
				.ForMember(d => d.DataInicio, opt =>
				{
					opt.PreCondition(o => !string.IsNullOrEmpty(o.fields.customfield_12505));
					opt.MapFrom(o => Convert.ToDateTime(o.fields.customfield_12505));
				})
				.ForMember(d => d.DataLimite, opt =>
				{
					opt.PreCondition(o => !string.IsNullOrEmpty(o.fields.customfield_12506));
					opt.MapFrom(o => Convert.ToDateTime(o.fields.customfield_12506));
				})
				.ForMember(d => d.Descricao, opt => opt.MapFrom(o => o.fields.description))
				.ForMember(d => d.Projeto, opt => opt.MapFrom(o => o.fields.project))
				.ForMember(d => d.Rotulos, opt => opt.MapFrom(o => o.fields.labels))
				.ForMember(d => d.Anexos, opt => opt.MapFrom(o => o.fields.attachment))
				.ForMember(d => d.Comentarios, opt => opt.MapFrom(o => o.fields.comment.comments));
		}
	}
}
