using AutoMapper;
using ClienteJiraAPI.Modelos.Entrada;
using Negocio.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Profiles
{
	public class UsuarioProfile : Profile
	{
		public UsuarioProfile()
		{
			CreateMap<MembroEquipe, Usuario>()
				.ForMember(d => d.Id, opt => opt.MapFrom(o => o.accountId))
				.ForMember(d => d.Email, opt => opt.MapFrom(o => o.emailAddress))
				.ForMember(d => d.Nome, opt => opt.MapFrom(o => o.displayName))
				.ForMember(d => d.Ativo, opt => opt.MapFrom(o => o.active))
				.ForMember(d => d.UrlAvatar, opt => opt.MapFrom(o => o.avatarUrls.Count > 0
					? o.avatarUrls[o.avatarUrls.Keys.ToList().First()] : string.Empty));
		}
	}
}
