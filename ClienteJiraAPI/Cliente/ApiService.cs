using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClienteJiraAPI.Cliente
{
	public class ApiService
    {
        public string Usuario { get; protected set; }
        public string Token { get; protected set; }

        public ApiService()
        {
            if (!File.Exists("token.txt"))
            {
                using (var writer = new StreamWriter("token.txt"))
                {
                    writer.WriteLine("USUARIO");
                    writer.WriteLine("TOKEN");
                }
            }

            using (StreamReader reader = new StreamReader("token.txt"))
            {
                Usuario = reader.ReadLine();
                Token = reader.ReadLine();
            }
        }

        public ApiService(string usuario, string token)
        {
            Usuario = usuario;
            Token = token;
        }
    }
}
