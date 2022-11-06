using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Modelos.Entidades.Enum
{
	/// <summary>
	/// Valores positivos são relacionados à tarefa de destino e valores negativos à tarefa de origem (relação inversa). Positivo = outward.
	/// </summary>
	public enum EnumRelacionamento
	{
		Relacionado = 10103,
		TemQueSerFeitaAntes = 10501,
		TemQueSerFeitaDepois = -10501
	}
}
