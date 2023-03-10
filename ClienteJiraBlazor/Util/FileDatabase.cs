using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteJiraBlazor.Util
{
	public class FileDatabase
    {
        private Dictionary<string, List<string>> Membros;
        private Dictionary<string, Dictionary<string, string>> Epicos;
        public decimal ValorJr { get; private set; }
		public decimal ValorPl { get; private set; }
		public decimal ValorSr { get; private set; }
		public List<string> MembrosJr { get { return Membros["Jr"]; } }
		public List<string> MembrosPl { get { return Membros["Pl"]; } }
		public List<string> MembrosSr { get { return Membros["Sr"]; } }
		public Dictionary<string,string> EpicosAtivos { get { return Epicos["S"]; } }
		public Dictionary<string,string> EpicosInativos { get { return Epicos["N"]; } }

		public FileDatabase()
		{
            if (!File.Exists("valores.txt"))
                AtualizarValores(
                    Convert.ToDecimal("268,43"),
                    Convert.ToDecimal("300,67"),
                    Convert.ToDecimal("345,04"));

            using (StreamReader reader = new StreamReader("valores.txt"))
            {
                ValorJr = Convert.ToDecimal(reader.ReadLine());
                ValorPl = Convert.ToDecimal(reader.ReadLine());
                ValorSr = Convert.ToDecimal(reader.ReadLine());
            }



            Membros = new Dictionary<string, List<string>>();
            Membros.Add("Jr", new List<string>());
            Membros.Add("Pl", new List<string>());
            Membros.Add("Sr", new List<string>());

            if (File.Exists("membros.txt"))
            {
                using (StreamReader reader = new StreamReader("membros.txt"))
                {
                    string linha;
                    string[] valores;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        valores = linha.Split(';');
						try
						{
                            Membros[valores[0]].Add(valores[1]);
						}
						catch (Exception ex) { }
                    }
                }

                foreach (string cargo in Membros.Keys)
                {
                    Membros[cargo].Sort();
                }
            }



            Epicos = new Dictionary<string, Dictionary<string, string>>();
            Epicos.Add("N", new Dictionary<string, string>());
            Epicos.Add("S", new Dictionary<string, string>());
            if (File.Exists("epicos.txt"))
            {
                using (StreamReader reader = new StreamReader("epicos.txt"))
                {
                    string linha;
                    string[] valores;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        valores = linha.Split(';');
                        Epicos[valores[0]].Add(valores[1],valores[2]);
                    }
                }
            }
        }

        public void AtualizarValores(decimal valorJr, decimal valorPl, decimal valorSr)
		{
			ValorJr = valorJr;
			ValorPl = valorPl;
			ValorSr = valorSr;

            using (var writer = new StreamWriter("valores.txt"))
            {
                writer.WriteLine(ValorJr);
                writer.WriteLine(ValorPl);
                writer.WriteLine(ValorSr);
            }
        }

        public void AdicionarMembro(string membro, string cargo)
        {
            Membros[cargo].Add(membro);
            Membros[cargo].Sort();
        }

        public void RemoverMembro(string membro, string cargo)
        {
            Membros[cargo].Remove(membro);
        }

        public void SalvarMembros()
        {
            using (var writer = new StreamWriter("membros.txt"))
            {
                foreach (string cargo in Membros.Keys)
                {
                    foreach (string membro in Membros[cargo])
                    {
                        writer.WriteLine($"{cargo};{membro}");
                    }
                }
            }
        }

        public void AdicionarEpico(string chave, string descricao)
        {
			if (Epicos["N"].ContainsKey(chave))
                Epicos["N"].Remove(chave);

            if (Epicos["S"].ContainsKey(chave))
                Epicos["S"][chave] = descricao;
            else
                Epicos["S"].Add(chave, descricao);
        }

        public void DesativarEpico(string chave)
        {
            Epicos["N"].Add(chave, Epicos["S"][chave]);
            Epicos["S"].Remove(chave);
        }

        public void SalvarEpicos()
        {
            using (var writer = new StreamWriter("epicos.txt"))
            {
                foreach (string chave in Epicos["S"].Keys)
                {
                    writer.WriteLine($"S;{chave};{Epicos["S"][chave]}");
                }
                foreach (string chave in Epicos["N"].Keys)
                {
                    writer.WriteLine($"N;{chave};{Epicos["N"][chave]}");
                }
            }
        }
    }
}
