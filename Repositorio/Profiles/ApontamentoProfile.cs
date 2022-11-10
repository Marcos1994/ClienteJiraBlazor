using AutoMapper;
using ClienteJiraAPI.Modelos.Entrada;
using Negocio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Profiles
{
	public class ApontamentoProfile : Profile
	{
		public ApontamentoProfile()
		{
			CreateMap<ClienteJiraAPI.Modelos.Entrada.Apontamento, Negocio.Modelos.Entidades.Apontamento>()
				.ForMember(d => d.Tempo, opt => opt.MapFrom(o => o.timeSpentSeconds))
				.ForMember(d => d.Data, opt => opt.MapFrom(o => Convert.ToDateTime(o.started)));
		}
	}
}
