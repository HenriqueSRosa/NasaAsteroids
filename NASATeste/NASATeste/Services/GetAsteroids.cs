using NASATeste.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASATeste.Services
{
    class GetAsteroids
    {

        public NEO getAsteroids(string startDate, string endDate)
        {
            Dictionary<string, string> urlParams = new Dictionary<string, string>
                        {
                            { "start_date", startDate},
                            { "end_date", endDate},
                            { "api_key", "NjgpxgSbYHXyFSBI3HaOhRowtjMZgAKv2t4DMRym"}
                        };



            return RequestGetAsync<NEO>
                ("https://api.nasa.gov/neo/rest/v1/feed", urlParams).Result;
        }
        public static async Task<T> RequestGetAsync<T>(string url, Dictionary<string, string> urlParams = null)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                if (urlParams?.Count > 0)
                {
                    string parametros = AsQueryString(urlParams);
                    url = url + parametros;
                }

                HttpResponseMessage result = await client.GetAsync(url).ConfigureAwait(false);

                var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (result.StatusCode != HttpStatusCode.OK)
                {
                    var erro = JsonConvert.DeserializeObject<ErrorMessage>(resultContent);
                    throw new Exception(erro.Message);
                    MessageBox.Show("Não foi possível acessar os dados da API. Favor tentar novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

                return JsonConvert.DeserializeObject<T>(resultContent);
            }
        }

        public static string AsQueryString(Dictionary<String, String> parameters)
        {
            if (!parameters.Any())
                return "";

            var builder = new StringBuilder("?");

            var separator = "";
            foreach (var kvp in parameters.Where(kvp => kvp.Value != null))
            {
                builder.AppendFormat("{0}{1}={2}", separator, WebUtility.UrlEncode(kvp.Key), WebUtility.UrlEncode(kvp.Value.ToString()));

                separator = "&";
            }

            return builder.ToString();
        }

    }
}
