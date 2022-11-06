using Negocio.Modelos.Entidades;
using AutoMapper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using ClienteJiraAPI.Modelos.Entrada;

namespace AutomapperTeste
{
	public class TesteUsuarioNegocioAPI
	{
		public TesteUsuarioNegocioAPI()
		{

		}

		[Fact]
		public void Test1()
		{
			MembroEquipe origem = new MembroEquipe()
			{
				accountId = 7,
				displayName = "Marcos André",
				emailAddress = "marcos.antas@hotmail.com.br",
				active = true,
				avatarUrls = new Dictionary<string, string>()
			};

			Usuario destino = new Usuario(7, "marcos.antas@hotmail.com.br", "", "Marcos André", true);

			destino.Id.Should().Be(7);
			destino.UrlAvatar.Should().Be(string.Empty);
			destino.Tarefas.Should().NotBeNull();
			destino.Tarefas.Should().BeEmpty();
		}
	}
}
