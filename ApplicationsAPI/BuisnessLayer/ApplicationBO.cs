using BuisnessLayer.Interface;
using DataEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BuisnessLayer
{
    public class ApplicationBO : IApplicationBO
    {
        public static string url = "https://rpnszaidmg.execute-api.eu-west-1.amazonaws.com/Prod";
        public List<Application> GetApplications()
        {
            try
            {
                string res = HttpRequest.Get(url + "/applications").Result;
                var response = JsonConvert.DeserializeObject<List<Application>>(res);
                return response;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Card> GetCards(string appId)
        {
            try
            {
                string res = HttpRequest.Get(url + $"/cards/{appId}").Result;
                var response = JsonConvert.DeserializeObject<List<Card>>(res);
                return response;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Trans> GetTrans(string appId)
        {
            try
            {
                string res = HttpRequest.Get(url + $"/trans/{appId}").Result;
                var response = JsonConvert.DeserializeObject<List<Trans>>(res);
                return response;
            }

            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
