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
	public class TesteTarefaNegocioAPI
	{
		private readonly IMapper mapper;
		public TesteTarefaNegocioAPI()
		{
			if (mapper == null)
			{
				var mappingConfig = new MapperConfiguration(mc =>
				{
					mc.AddProfile(new UsuarioProfile());
					mc.AddProfile(new ComentarioProfile());
					mc.AddProfile(new TarefaProfile());
					mc.AddProfile(new SubtarefaProfile());
					mc.AddProfile(new EpicoProfile());
					mc.AddProfile(new ProjetoProfile());
					mc.AddProfile(new AnexoProfile());
					mc.AddProfile(new ApontamentoProfile());
					mc.AddProfile(new SprintProfile());
					mc.AddProfile(new RelacionamentoProfile());
				});
				mapper = mappingConfig.CreateMapper();
			}
		}

		[Fact]
		public void JsonItemParaEpico()
		{
			#region Instanciacao do epico de origem
			ClienteJiraAPI.Modelos.Entrada.ItemTarefa origem = new ClienteJiraAPI.Modelos.Entrada.ItemTarefa()
			{
				id = "60627",
				key = "NUAGIL-644",
				self = "https://interfusao.atlassian.net/rest/api/2/issue/60627",
				fields = new ClienteJiraAPI.Modelos.Entrada.CamposTarefa()
				{
					assignee = new ClienteJiraAPI.Modelos.Entrada.MembroEquipe()
					{
						accountId = "8",
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
						accountId = "7",
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
					summary = "Jira Client Blazor",
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
							{ "16x16", "Avatar 16x16px" },
							{ "32x32", "Avatar 32x32px" },
							{ "64x64", "Avatar 64x64px" }
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
									accountId = "7",
									displayName = "Marcos André",
									emailAddress = "marcos.antas@hotmail.com.br",
									active = true,
									avatarUrls = new Dictionary<string, string>()
									{
										{ "16x16", "Avatar 16x16px" },
										{ "32x32", "Avatar 32x32px" },
										{ "64x64", "Avatar 64x64px" }
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
									accountId = "8",
									displayName = "Gustavo Ristow",
									emailAddress = "gustavo.ristow@interfusaoti.com.br",
									active = true,
									avatarUrls = new Dictionary<string, string>()
									{
										{ "16x16", "Avatar 16x16px" },
										{ "32x32", "Avatar 32x32px" },
										{ "64x64", "Avatar 64x64px" }
									}
								}
							}
						}
					},
					parent = new ClienteJiraAPI.Modelos.Entrada.ItemBase()
					{
						id = "60627",
						key = "NUAGIL-644",
						self = "https://interfusao.atlassian.net/rest/api/2/issue/60627",
						fields = new ClienteJiraAPI.Modelos.Entrada.CamposTarefa()
						{
							issueType = new ClienteJiraAPI.Modelos.Entrada.TipoItem()
							{
								id = "5"
							},
							assignee = new ClienteJiraAPI.Modelos.Entrada.MembroEquipe()
							{
								accountId = "8",
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
								accountId = "7",
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
							summary = "Jira Client Blazor",
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
									{ "16x16", "Avatar 16x16px" },
									{ "32x32", "Avatar 32x32px" },
									{ "64x64", "Avatar 64x64px" }
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
											accountId = "7",
											displayName = "Marcos André",
											emailAddress = "marcos.antas@hotmail.com.br",
											active = true,
											avatarUrls = new Dictionary<string, string>()
											{
												{ "16x16", "Avatar 16x16px" },
												{ "32x32", "Avatar 32x32px" },
												{ "64x64", "Avatar 64x64px" }
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
											accountId = "8",
											displayName = "Gustavo Ristow",
											emailAddress = "gustavo.ristow@interfusaoti.com.br",
											active = true,
											avatarUrls = new Dictionary<string, string>()
											{
												{ "16x16", "Avatar 16x16px" },
												{ "32x32", "Avatar 32x32px" },
												{ "64x64", "Avatar 64x64px" }
											}
										}
									}
								}
							}

						}
					},
					timeEstimate = 3600,
					customfield_10600 = "Link do epico",
					priority = new ClienteJiraAPI.Modelos.Entrada.Prioridade()
					{
						id = "3"
					},
					customfield_10004 = 1,
					customfield_10300 = new List<ClienteJiraAPI.Modelos.Entrada.Sprint>()
					{
						new ClienteJiraAPI.Modelos.Entrada.Sprint()
						{
							id = 559,
							name = "NUAGIL Sprint 121 0310-0710",
							state = "active",
							startDate = "2022-10-03T13:14:48.103Z",
							endDate = "2022-10-07T23:05:00.000Z"
						}
					},
					subtasks = new List<ClienteJiraAPI.Modelos.Entrada.ItemBase>()
					{
						new ClienteJiraAPI.Modelos.Entrada.ItemBase()
						{
							id = "60627",
							key = "NUAGIL-644",
							self = "https://interfusao.atlassian.net/rest/api/2/issue/60627",
							fields = new ClienteJiraAPI.Modelos.Entrada.CamposTarefa()
							{
								issueType = new ClienteJiraAPI.Modelos.Entrada.TipoItem()
								{
									id = "8"
								},
								assignee = new ClienteJiraAPI.Modelos.Entrada.MembroEquipe()
								{
									accountId = "8",
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
									accountId = "7",
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
								summary = "Jira Client Blazor",
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
										{ "16x16", "Avatar 16x16px" },
										{ "32x32", "Avatar 32x32px" },
										{ "64x64", "Avatar 64x64px" }
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
												accountId = "7",
												displayName = "Marcos André",
												emailAddress = "marcos.antas@hotmail.com.br",
												active = true,
												avatarUrls = new Dictionary<string, string>()
												{
													{ "16x16", "Avatar 16x16px" },
													{ "32x32", "Avatar 32x32px" },
													{ "64x64", "Avatar 64x64px" }
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
												accountId = "8",
												displayName = "Gustavo Ristow",
												emailAddress = "gustavo.ristow@interfusaoti.com.br",
												active = true,
												avatarUrls = new Dictionary<string, string>()
												{
													{ "16x16", "Avatar 16x16px" },
													{ "32x32", "Avatar 32x32px" },
													{ "64x64", "Avatar 64x64px" }
												}
											}
										}
									}
								}

							}
						}
					},
					issueLinks = new List<ClienteJiraAPI.Modelos.Entrada.ItemRelacionado>()
					{
						new ClienteJiraAPI.Modelos.Entrada.ItemRelacionado()
						{
							type = new ClienteJiraAPI.Modelos.Entrada.TipoRelacionamento()
							{
								id = "10501"
							},
							outwardIssue = new ClienteJiraAPI.Modelos.Entrada.ItemBase()
							{
								id = "60627",
								key = "NUAGIL-644",
								self = "https://interfusao.atlassian.net/rest/api/2/issue/60627",
								fields = new ClienteJiraAPI.Modelos.Entrada.CamposTarefa()
								{
									issueType = new ClienteJiraAPI.Modelos.Entrada.TipoItem()
									{
										id = "3"
									},
									assignee = new ClienteJiraAPI.Modelos.Entrada.MembroEquipe()
									{
										accountId = "8",
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
										accountId = "7",
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
									summary = "Jira Client Blazor",
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
											{ "16x16", "Avatar 16x16px" },
											{ "32x32", "Avatar 32x32px" },
											{ "64x64", "Avatar 64x64px" }
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
													accountId = "7",
													displayName = "Marcos André",
													emailAddress = "marcos.antas@hotmail.com.br",
													active = true,
													avatarUrls = new Dictionary<string, string>()
													{
														{ "16x16", "Avatar 16x16px" },
														{ "32x32", "Avatar 32x32px" },
														{ "64x64", "Avatar 64x64px" }
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
													accountId = "8",
													displayName = "Gustavo Ristow",
													emailAddress = "gustavo.ristow@interfusaoti.com.br",
													active = true,
													avatarUrls = new Dictionary<string, string>()
													{
														{ "16x16", "Avatar 16x16px" },
														{ "32x32", "Avatar 32x32px" },
														{ "64x64", "Avatar 64x64px" }
													}
												}
											}
										}
									}

								}
							}
						}
					},
					worklog = new ClienteJiraAPI.Modelos.Entrada.Apontamentos()
					{
						worklogs = new List<ClienteJiraAPI.Modelos.Entrada.Apontamento>()
						{
							new ClienteJiraAPI.Modelos.Entrada.Apontamento()
							{
								timeSpentSeconds = 1800,
								started = "2022-10-05T05:30:00.000-0300"
							},
							new ClienteJiraAPI.Modelos.Entrada.Apontamento()
							{
								timeSpentSeconds = 3600,
								started = "2022-10-04T05:30:00.000-0300"
							}
						}
					}
				}
			};
			#endregion

			Negocio.Modelos.Entidades.Tarefa destino = mapper.Map<Negocio.Modelos.Entidades.Tarefa>(origem);

			destino.Id.ToString().Should().Be(origem.id);
		}
	}
}
