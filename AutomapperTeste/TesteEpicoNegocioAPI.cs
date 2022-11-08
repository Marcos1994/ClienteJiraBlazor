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
	public class TesteEpicoNegocioAPI
	{
		private readonly IMapper mapper;
		public TesteEpicoNegocioAPI()
		{
			if (mapper == null)
			{
				var mappingConfig = new MapperConfiguration(mc =>
				{
					mc.AddProfile(new UsuarioProfile());
					mc.AddProfile(new ComentarioProfile());
					mc.AddProfile(new EpicoProfile());
					mc.AddProfile(new ProjetoProfile());
					mc.AddProfile(new AnexoProfile());
				});
				mapper = mappingConfig.CreateMapper();
			}
		}

		[Fact]
		public void JsonItemParaEpico()
		{
			#region Instanciacao do epico de origem
			ClienteJiraAPI.Modelos.Entrada.ItemEpico origem = new ClienteJiraAPI.Modelos.Entrada.ItemEpico()
			{
				id = "60627",
				key = "NUAGIL-644",
				self = "https://interfusao.atlassian.net/rest/api/2/issue/60627",
				fields = new ClienteJiraAPI.Modelos.Entrada.CamposEpico()
				{
					assignee = new ClienteJiraAPI.Modelos.Entrada.MembroEquipe()
					{
						accountId = 8,
						displayName = "Gustavo Ristow",
						emailAddress = "gustavo.ristow@interfusaoti.com.br",
						active = true,
						avatarUrls = new Dictionary<string, string>()
						{
							{ "16x16", "Avatar 16x16px" },
							{ "32x32", "Avatar 32x32px" },
							{ "64x64", "Avatar 64x64px" }
						}
					},
					reporter = new ClienteJiraAPI.Modelos.Entrada.MembroEquipe()
					{
						accountId = 7,
						displayName = "Marcos André",
						emailAddress = "marcos.antas@hotmail.com.br",
						active = true,
						avatarUrls = new Dictionary<string, string>()
						{
							{ "16x16", "Avatar 16x16px" },
							{ "32x32", "Avatar 32x32px" },
							{ "64x64", "Avatar 64x64px" }
						}
					},
					attachment = new List<ClienteJiraAPI.Modelos.Entrada.Anexo>()
					{
						new ClienteJiraAPI.Modelos.Entrada.Anexo()
						{
							id = "7",
							content = "Arquivo PDF",
							fileName = "Arquivo.pdf",
							mimeType = "application/pdf",
							created = "2022-10-04T20:06:51.613-0300"
						}
					},
					created = "2022-10-04T19:05:27.230-0300",
					customfield_10601 = "[644] Jira Client Blazor",
					sumary = "Jira Client Blazor",
					status = new ClienteJiraAPI.Modelos.Entrada.Status()
					{
						name = "Em andamento"
					},
					customfield_12505 = "2022-10-07",
					customfield_12506 = "2022-10-20",
					description = "Descrição do épico",
					project = new ClienteJiraAPI.Modelos.Entrada.Projeto()
					{
						id = "16785",
						key = "NUAGIL",
						name = "NU-AGIL",
						projectTypeKey = "software",
						avatarUrls = new Dictionary<string, string>()
						{
							{"16x16", "Avatar 16x16px" },
							{"32x32", "Avatar 32x32px" },
							{"64x64", "Avatar 64x64px" }
						},
						projectCategory = new ClienteJiraAPI.Modelos.Entrada.CategoriaProjeto()
						{
							id = "10101",
							name = "Interfusão",
							description = "Projetos Internos da Interfusão"
						}
					},
					labels = new List<string>()
					{
						"GU"
					},
					comment = new ClienteJiraAPI.Modelos.Entrada.Comentarios()
					{
						comments = new List<ClienteJiraAPI.Modelos.Entrada.Comentario>()
						{
							new ClienteJiraAPI.Modelos.Entrada.Comentario()
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
							},
							new ClienteJiraAPI.Modelos.Entrada.Comentario()
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
							}
						}
					}
				}
			};
			#endregion

			Negocio.Modelos.Entidades.Epico destino = mapper.Map<Negocio.Modelos.Entidades.Epico>(origem);

			destino.Id.ToString().Should().Be(origem.id);
		}
	}
}
