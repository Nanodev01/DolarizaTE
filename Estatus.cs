using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace miDolar
{
    internal class Estatus
    {
        private static readonly HttpClient cliente = new HttpClient();

        public async Task<string> Estado()
        {
            string url = "https://dolarapi.com/v1/estado";

            HttpResponseMessage respuesta = await cliente.GetAsync(url);

            respuesta.EnsureSuccessStatusCode();

            string res = await respuesta.Content.ReadAsStringAsync();

            JObject json = JObject.Parse(res);
            try
            {
                if (json["estado"] != null)
                {
                    string estado = json["estado"].Value<string>();
                    return estado;

                }
                else
                {
                    throw new InvalidOperationException("Respuesta json sin -estado-");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            } 
            
        }

    }
}
