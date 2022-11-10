using AutoMapper;
using Negocio.Modelos.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Profiles
{
	public class AnexoProfile : Profile
	{
		public AnexoProfile()
		{
			CreateMap<ClienteJiraAPI.Modelos.Entrada.Anexo, Negocio.Modelos.Entidades.Anexo>()
				.ForMember(d => d.Id, opt => opt.MapFrom(o => Convert.ToInt32(o.id)))
				.ForMember(d => d.Nome, opt => opt.MapFrom(o => o.fileName))
				.ForMember(d => d.Conteudo, opt => opt.MapFrom(o => o.content))
				.ForMember(d => d.DataCriacao, opt => //2022-10-04T20:06:51.613-0300
				{
					opt.PreCondition(o => !string.IsNullOrEmpty(o.created));
					opt.MapFrom(o => Convert.ToDateTime(o.created));
				})
				.ForMember(d => d.TipoArquivo, opt => opt.MapFrom(o =>
					(o.mimeType == "application/pdf") ? EnumTipoArquivo.Pdf : EnumTipoArquivo.Imagem));
		}
	}
}
