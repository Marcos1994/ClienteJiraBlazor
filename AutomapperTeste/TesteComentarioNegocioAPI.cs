using AutoMapper;
using FluentAssertions;
using Negocio.Modelos.Entidades.Enum;
using Repositorio.Profiles;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace AutomapperTeste
{
	public class TesteComentarioNegocioAPI
	{
		private readonly IMapper mapper;
		public TesteComentarioNegocioAPI()
		{
			if (mapper == null)
			{
				var mappingConfig = new MapperConfiguration(mc =>
				{
					mc.AddProfile(new UsuarioProfile());
					mc.AddProfile(new ComentarioProfile());
				});
				mapper = mappingConfig.CreateMapper();
			}
		}

		[Fact]
		public void JsonComentarioParaComentario()
		{
			ClienteJiraAPI.Modelos.Entrada.Comentario origem = new ClienteJiraAPI.Modelos.Entrada.Comentario()
			{
				id = "1",
				body = "Primeiro comentario",
				created = "2022-10-04T20:06:51.613-0300",
				author = new ClienteJiraAPI.Modelos.Entrada.MembroEquipe()
				{
					accountId = 7,
					displayName = "Marcos André",
					emailAddress = "marcos.antas@hotmail.com.br",
					active = true,
					avatarUrls = new Dictionary<string, string>()
					{
						{"16x16", "Avatar 16x16px" },
						{"32x32", "Avatar 32x32px" },
						{"64x64", "Avatar 64x64px" }
					}
				}
			};

			Negocio.Modelos.Entidades.Comentario destino = mapper.Map<Negocio.Modelos.Entidades.Comentario>(origem);

			destino.Autor.Nome.Should().Be(origem.author.displayName);
		}

		[Fact]
		public void JsonComentariosParaListComentario()
		{
			ClienteJiraAPI.Modelos.Entrada.Comentarios origem = new ClienteJiraAPI.Modelos.Entrada.Comentarios()
			{
				comments = new List<ClienteJiraAPI.Modelos.Entrada.Comentario>()
			};
			origem.comments.Add(new ClienteJiraAPI.Modelos.Entrada.Comentario()
			{
				id = "1",
				body = "Primeiro comentario",
				created = "2022-10-04T20:06:51.613-0300",
				author = new ClienteJiraAPI.Modelos.Entrada.MembroEquipe()
				{
					accountId = 7,
					displayName = "Marcos André",
					emailAddress = "marcos.antas@hotmail.com.br",
					active = true,
					avatarUrls = new Dictionary<string, string>()
					{
						{"16x16", "Avatar 16x16px" },
						{"32x32", "Avatar 32x32px" },
						{"64x64", "Avatar 64x64px" }
					}
				}
			});
			origem.comments.Add(new ClienteJiraAPI.Modelos.Entrada.Comentario()
			{
				id = "2",
				body = "Segundo comentario",
				created = "2022-10-04T20:06:51.615-0300",
				author = new ClienteJiraAPI.Modelos.Entrada.MembroEquipe()
				{
					accountId = 8,
					displayName = "Gustavo Ristow",
					emailAddress = "gustavo.ristow@interfusaoti.com.br",
					active = true,
					avatarUrls = new Dictionary<string, string>()
					{
						{"16x16", "Avatar 16x16px" },
						{"32x32", "Avatar 32x32px" },
						{"64x64", "Avatar 64x64px" }
					}
				}
			});

			List<Negocio.Modelos.Entidades.Comentario> destino = mapper.Map<List<Negocio.Modelos.Entidades.Comentario>>(origem.comments);

			destino.Count.Should().Be(origem.comments.Count);
		}
	}
}
