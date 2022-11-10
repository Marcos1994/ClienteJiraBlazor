using Negocio.Modelos.Entidades;
using AutoMapper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using ClienteJiraAPI.Modelos.Entrada;
using Repositorio.Profiles;

namespace AutomapperTeste
{
	public class TesteUsuarioNegocioAPI
	{
		private readonly IMapper mapper;
		public TesteUsuarioNegocioAPI()
		{
			if (mapper == null)
			{
				var mappingConfig = new MapperConfiguration(mc =>
				{
					mc.AddProfile(new UsuarioProfile());
				});
				mapper = mappingConfig.CreateMapper();
			}
		}

		[Fact]
		public void UsuarioJsonCompletoParaUsuario()
		{
			MembroEquipe origem = new MembroEquipe()
			{
				accountId = "7",
				displayName = "Marcos André",
				emailAddress = "marcos.antas@hotmail.com.br",
				active = true,
				avatarUrls = new Dictionary<string, string>()
			};
			origem.avatarUrls.Add("16x16", "Avatar 16x16px");
			origem.avatarUrls.Add("24x24", "Avatar 24x24px");
			origem.avatarUrls.Add("32x32", "Avatar 32x32px");

			Usuario destino = mapper.Map<Usuario>(origem);

			destino.AccountId.Should().Be(origem.accountId);
			destino.Ativo.Should().Be(origem.active);
			destino.Email.Should().Be(origem.emailAddress);
			destino.Nome.Should().Be(origem.displayName);
		}

		[Fact]
		public void UsuarioJsonSemAvatarParaUsuario()
		{
			MembroEquipe origem = new MembroEquipe()
			{
				accountId = "7",
				displayName = "Marcos André",
				emailAddress = "marcos.antas@hotmail.com.br",
				active = true,
				avatarUrls = new Dictionary<string, string>()
			};

			Usuario destino = mapper.Map<Usuario>(origem);

			destino.AccountId.Should().Be(origem.accountId);
			destino.Ativo.Should().Be(origem.active);
			destino.Email.Should().Be(origem.emailAddress);
			destino.Nome.Should().Be(origem.displayName);
		}
	}
}
