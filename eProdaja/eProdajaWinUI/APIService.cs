using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using eProdaja.Model;
using System.Windows.Forms;
using System.Diagnostics;

namespace eProdajaWinUI
{
    public class APIService
    {
        private string _route = null;

        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object request=null)
        {
            var url = $"{Properties.Settings.Default.ApiURL}{_route}";
            if(request!=null)
            {
                url += "?";
                url += await request?.ToQueryString();
            };
            var result = await url.WithBasicAuth(Username,Password).GetJsonAsync<T>();
            return result;
        }
        
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}{_route}/{id}";
            var result = await url.GetJsonAsync<T>();
            //var result = await url.WithBasicAuth(username,password).GetJsonAsync<T>(); (kada se uradi autentifikacija)
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}{_route}";

            try
            {
                return await url.PostJsonAsync(request).ReceiveJson<T>();
                
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}{_route}/{id}";

            try
            {
                return await url.PutJsonAsync(request).ReceiveJson<T>();

            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }
    }
}
