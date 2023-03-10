using System;
using System.Net.Http;
using System.Text;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ClienteJiraAPI.Modelos.Entrada;
using System.Collections.Generic;

namespace ClienteJiraAPI.Cliente
{
	public class IssueApiService : ApiService
	{
        public async Task<T> GetJiraIssueAsync<T>(string chaveItem)
        {
            string itemStr = string.Empty;

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

						itemStr = await response.Content.ReadAsStringAsync();
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

        public async Task<List<ItemBase>> GetItensPorSprintAsync(int idSprint, string usuario)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"),
                        $"https://interfusao.atlassian.net/rest/api/2/search?jql=cf[10300]={idSprint} AND assignee=\"{ Usuario }\""))
                    {
                        request.Headers.TryAddWithoutValidation("Accept", "application/json");

                        var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(Usuario + ":" + Token));
                        request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                        //HttpResponseMessage response = await httpClient.PostAsJsonAsync($"/Usuario/Login", new Item());
                        HttpResponseMessage response = await httpClient.SendAsync(request);

                        if (!response.IsSuccessStatusCode)
                            throw new Exception(response.ToString());

                        string retorno = await response.Content.ReadAsStringAsync();
                        List<ItemBase> itens = (await response.Content.ReadFromJsonAsync<IssuesApiResponse>()).issues;
                        return itens;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<ItemBase>> GetItensPorEpicoAsync(string chaveEpico, int paginacao = 0)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"),
                        $"https://interfusao.atlassian.net/rest/api/2/search?jql=cf[10600]={chaveEpico}&maxResults=100&startAt={paginacao}"))
                    {
                        request.Headers.TryAddWithoutValidation("Accept", "application/json");

                        var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(Usuario + ":" + Token));
                        request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                        //HttpResponseMessage response = await httpClient.PostAsJsonAsync($"/Usuario/Login", new Item());
                        HttpResponseMessage response = await httpClient.SendAsync(request);

                        if (!response.IsSuccessStatusCode)
                            throw new Exception(response.ToString());

                        string retorno = await response.Content.ReadAsStringAsync();
                        List<ItemBase> itens = (await response.Content.ReadFromJsonAsync<IssuesApiResponse>()).issues;

						if (itens.Count >= 100)
						{
							itens.AddRange(await GetItensPorEpicoAsync(chaveEpico, paginacao + 100));
						}

						return itens;
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
