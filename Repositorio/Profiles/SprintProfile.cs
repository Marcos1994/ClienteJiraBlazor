using AutoMapper;
using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Profiles
{
	public class SprintProfile : Profile
	{
		public SprintProfile()
		{
			CreateMap<ClienteJiraAPI.Modelos.Entrada.Sprint, Negocio.Modelos.Entidades.Sprint>()
				.ForMember(d => d.Id, opt => opt.MapFrom(o => o.id))
				.ForMember(d => d.Nome, opt => opt.MapFrom(o => o.name))
				.ForMember(d => d.Inicio, opt => opt.MapFrom(o => Convert.ToDateTime(o.startDate)))
				.ForMember(d => d.Fim, opt => opt.MapFrom(o => Convert.ToDateTime(o.endDate)))
				.ForMember(d => d.Estado, opt => opt.MapFrom(o =>
					(o.state == "active") ? EnumSprint.Ativa :
					(o.state == "backlog") ? EnumSprint.Backlog : EnumSprint.Concluida));
		}
	}
}
