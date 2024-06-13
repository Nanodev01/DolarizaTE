using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Security.Policy;

namespace miDolar
{
    internal class Conversor
    {

        HttpClient cliente = new HttpClient();
        private async Task<decimal> blueCompra()
        {
            string url = "https://dolarapi.com/v1/dolares/blue";

            try
            {
                HttpResponseMessage res = await cliente.GetAsync(url);
                res.EnsureSuccessStatusCode();

                string r = await res.Content.ReadAsStringAsync();
                JObject re = JObject.Parse(r);
                if (re["compra"] != null && re["venta"] != null)
                {
                    decimal precio = re["compra"].Value<decimal>();

                    return precio;
                }
                else
                {
                    throw new Exception ("[ERROR] >>> Datos no encontrados");
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            
            }
        
        }

        private async Task<decimal> blueVenta()
        {
            string url = "https://dolarapi.com/v1/dolares/blue";

            try
            {
                HttpResponseMessage res = await cliente.GetAsync(url);
                res.EnsureSuccessStatusCode();

                string r = await res.Content.ReadAsStringAsync();
                JObject re = JObject.Parse(r);
                if (re["compra"] != null && re["venta"] != null)
                {
                    decimal precio = re["venta"].Value<decimal>();

                    return precio;
                }
                else
                {
                    throw new Exception("[ERROR] >>> Datos no encontrados");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;

            }

        }

        // private async Task<decimal> bolsaCompra()
        // {
        //     HttpResponseMessage res = await cliente.GetAsync();


        // }





        public async Task<decimal> blueCompra(decimal i) {
            decimal cambio = await blueCompra();
            i *= cambio;

            return i;
        }
        public async Task<decimal> blueVenta(decimal i)
        {
            decimal cambio = await blueVenta();
            i *= cambio;

            return i;
        }
    }
}
