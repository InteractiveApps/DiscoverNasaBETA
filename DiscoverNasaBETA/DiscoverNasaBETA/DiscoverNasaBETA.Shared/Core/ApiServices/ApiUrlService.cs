using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverNasaBETA.Core.ApiServices
{
    public class ApiUrlService
    {
        public string BaseUri { get; set; }

        public ApiUrlService(string baseUri)
        {
            BaseUri=baseUri;
        }
        public string GetFormattedApiUrl(string parameters)
        {
            string[ ] _paramArray = parameters.Split(';');
            string sub = string.Empty;
            for (int i = 0; i<_paramArray.Length; i++)
            {
                sub+=_paramArray[i]+"={"+i+"}&";
            }

            sub=sub.Remove(sub.Length-1);

            return BaseUri+sub;
        }

        public string getUrl(string parameters , string values)
        {
            var formattableString = GetFormattedApiUrl(parameters);
            string[ ] valArray = values.Split(';');
            return String.Format(formattableString, valArray);

        }
    }
}
