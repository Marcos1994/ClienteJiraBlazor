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
	public class TesteAnexoNegocioAPI
	{
		private readonly IMapper mapper;
		public TesteAnexoNegocioAPI()
		{
			if (mapper == null)
			{
				var mappingConfig = new MapperConfiguration(mc =>
				{
					mc.AddProfile(new AnexoProfile());
				});
				mapper = mappingConfig.CreateMapper();
			}
		}

		[Fact]
		public void JsonAnexoParaAnexo()
		{
			ClienteJiraAPI.Modelos.Entrada.Anexo origem = new ClienteJiraAPI.Modelos.Entrada.Anexo()
			{
				id = "7",
				content = "Arquivo PDF",
				fileName = "Arquivo.pdf",
				mimeType = "application/pdf",
				created = "2022-10-04T20:06:51.613-0300"
			};

			Negocio.Modelos.Entidades.Anexo destino = mapper.Map<Negocio.Modelos.Entidades.Anexo>(origem);

			destino.Id.ToString().Should().Be(origem.id);
			destino.Conteudo.Should().Be(origem.content);
			destino.Nome.Should().Be(origem.fileName);
			destino.TipoArquivo.Should().Be(EnumTipoArquivo.Pdf);
			destino.DataCriacao.Should().Be(new DateTime(2022, 10, 4, 20, 6, 51, 613));
		}
	}
}
