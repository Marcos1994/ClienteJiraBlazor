using Negocio.Modelos.Entidades;
using AutoMapper;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AutomapperTeste
{
	public class TesteUsuarioNegocioAPI
	{
		[Fact]
		public void Test1()
		{
			Usuario origem = new Usuario(7, "marcos.antas@hotmail.com.br", "", "Marcos André", true);

			origem.Id.Should().Be(7);
			origem.UrlAvatar.Should().Be(string.Empty);
			origem.Tarefas.Should().NotBeNull();
			origem.Tarefas.Should().BeEmpty();
		}
	}
}
