using AutoMapper;
using ClienteJiraAPI.Modelos.Entrada;
using Negocio.Modelos.Entidades;
using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Profiles
{
	public class RelacionamentoProfile : Profile
	{
		public RelacionamentoProfile()
		{
			CreateMap<ItemRelacionado, Relacionamento>()
				.ForMember(d => d.TarefaRelacionada, opt => opt.MapFrom(o =>
					(o.outwardIssue != null) ? o.outwardIssue : o.inwardIssue))
				.ForMember(d => d.TipoRelacionamento, opt => opt.MapFrom(o =>
					(o.type.id == "10103") ? EnumRelacionamento.Relacionado :
					(o.type.id == "10501") ?
						((o.outwardIssue != null) ? EnumRelacionamento.TemQueSerFeitaAntes
						: EnumRelacionamento.TemQueSerFeitaDepois)
					: EnumRelacionamento.Relacionado));
		}
	}
}
