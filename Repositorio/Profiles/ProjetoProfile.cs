using AutoMapper;
using ClienteJiraAPI.Modelos.Entrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Profiles
{
	public class ProjetoProfile : Profile
	{
		public ProjetoProfile()
		{
			CreateMap<ClienteJiraAPI.Modelos.Entrada.Projeto, Negocio.Modelos.Entidades.Projeto>()
				.ForMember(d => d.Id, opt => opt.MapFrom(o => o.id))
				.ForMember(d => d.Chave, opt => opt.MapFrom(o => o.key))
				.ForMember(d => d.Nome, opt => opt.MapFrom(o => o.name))
				.ForMember(d => d.Tipo, opt => opt.MapFrom(o => o.projectTypeKey))
				.ForMember(d => d.Foto, opt => opt.MapFrom(o => o.avatarUrls.Count > 0
					? o.avatarUrls[o.avatarUrls.Keys.ToList().First()] : string.Empty))
				.ForMember(d => d.Categoria, opt => opt.MapFrom(o => o.projectCategory.name));
		}
	}
}
