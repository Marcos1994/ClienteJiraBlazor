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
				.ForMember(d => d.UrlAvatar, opt => opt.MapFrom(o => o.avatarUrls[o.avatarUrls.Keys.ToList().First()]))
				.ForMember(d => d.Ativo, opt => opt.MapFrom(o => o.active));
		}
	}

	//public class ItemProfile : Profile
	//{
	//	public ItemProfile()
	//	{
	//		CreateMap<ItemUpdateModel, ItemInputModel>();

	//		CreateMap<ItemInputModel, Item>()
	//			.ForMember(d => d.RelacoesUsuarios, opt =>
	//			{
	//				opt.Condition(s => s.Relacao != EnumRelacaoUsuarioItem.NaoPossuo);
	//				opt.MapFrom(s => new[] { new RelacaoItemUsuarioInputModel { Relacao = s.Relacao, IdUsuario = s.IdUsuario, Comentario = s.Comentario } });
	//			});
	//		CreateMap<RelacaoItemUsuarioInputModel, ItemUsuario>()
	//			.ConvertUsing(s => (s.Relacao == EnumRelacaoUsuarioItem.NaoPossuo)
	//				? null : new ItemUsuario(s.IdUsuario, s.IdItem, (int)s.Relacao, s.Comentario));

	//		CreateMap<Item, ItemViewModel>()
	//			.IncludeBase<Item, ItemBasicViewModel>();
	//		CreateMap<Item, ItemBasicViewModel>()
	//			.IncludeMembers(r => r.RelacoesUsuarios.FirstOrDefault());
	//		CreateMap<ItemUsuario, ItemBasicViewModel>();
	//		CreateMap<ItemUsuario, EnumRelacaoUsuarioItem>(MemberList.None)
	//			.ConvertUsing(src => (EnumRelacaoUsuarioItem)src.Relacao);

	//	}
	//}
}
