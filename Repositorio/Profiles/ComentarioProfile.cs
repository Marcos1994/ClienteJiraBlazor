using AutoMapper;
using ClienteJiraAPI.Modelos.Entrada;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Profiles
{
	public class ComentarioProfile : Profile
	{
		public ComentarioProfile()
		{
			CreateMap<Comentario, Negocio.Modelos.Entidades.Comentario>()
				.ForMember(d => d.Id, opt => opt.MapFrom(o => Convert.ToInt32(o.id)))
				.ForMember(d => d.Autor, opt => opt.MapFrom(o => o.author))
				.ForMember(d => d.Conteudo, opt => opt.MapFrom(o => o.body))
				.ForMember(d => d.DataCriacao, opt => opt.MapFrom(o => Convert.ToDateTime(o.created))); //2022-10-04T20:06:51.613-0300
		}
	}
}
