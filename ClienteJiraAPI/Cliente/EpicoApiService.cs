using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ClienteJiraAPI.Modelos.Entrada;

namespace ClienteJiraAPI.Cliente
{
	public class EpicoApiService
	{
		public EpicoApiService()
        {

        }

		public EpicoApiService(string usuario, string token)
		{
			Usuario = usuario;
			Token = token;
		}

		public string Usuario { get; private set; }
		public string Token { get; private set; }

        public async Task<T> GetJiraIssueAsync<T>(string chaveItem)
        {
            string result = string.Empty;

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {


                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://interfusao.atlassian.net/rest/api/2/issue/" + chaveItem))
                    {
                        request.Headers.TryAddWithoutValidation("Accept", "application/json");

                        var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(Usuario + ":" + Token));
                        request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                        //HttpResponseMessage response = await httpClient.PostAsJsonAsync($"/Usuario/Login", new Item());
                        HttpResponseMessage response = await httpClient.SendAsync(request);

						if (!response.IsSuccessStatusCode)
							throw new Exception(response.ToString());

						string itemStr = await response.Content.ReadAsStringAsync();
                        T item = await response.Content.ReadFromJsonAsync<T>();
						return item;
					}
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
