using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IO
{
    
    public class ClassCallWebApi
    {
        ClassCallWebApi cwac;
        public ClassCallWebApi()
        {
            cwac= new ClassCallWebApi();
        }

        /// <summary>
        /// henter data fra given api URL.
        /// denne synkrone metode kan kommunikere alle former for web API'er.
        /// den skal blot modtage en komplet URL.
        /// </summary>
        /// <param name="inUrl">string</param>
        /// <returns>string</returns>
        public async Task<string> GetDataFromWebApiAsync(string inUrl)
        {
            var content = new MemoryStream(); //pakker kommer løbende
            var webReq = WebRequest.Create(inUrl);
            //datastream der skal converteres til en string
            using (WebResponse response = await webReq.GetResponseAsync())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    await responseStream.CopyToAsync(content); //samler til den rigtige rækkeføglge
                }
            }
            // omdanner resultatet fra api'en til tekst
            return Encoding.UTF8.GetString(content.ToArray());
        }
        public async Task<ClassCallWebApi> GetDataFromOpenExchangeRatesAsync()
        {
            try
            {
                string strJson = await cwac.GetDataFromWebApiAsync("https://openexchangerates.org/api/latest.json?app_id=9df638f3b77d42cda189773673dd28b3");
                return JsonConvert.DeserializeObject<ClassCallWebApi>(strJson);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    } 
    }
