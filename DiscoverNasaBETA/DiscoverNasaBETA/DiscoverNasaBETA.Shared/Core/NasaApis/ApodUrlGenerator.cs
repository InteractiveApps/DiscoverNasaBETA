using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverNasaBETA.Core.NasaApis
{
    public class ApodUrlGenerator : ApiServices.ApiUrlService
    {
        const string BaseUri = "https://api.nasa.gov/planetary/apod?";
        const string apiKey = "I3pA7RdSKvrER6hm6f51BhWzCmoJM6Alq6BjbbEu";
        const string apod_params = "api_key;concept_tags;date";
        public string currentDate
        {
            get
            {
                var date = DateTime.UtcNow; ;

                var year = date.Year.ToString();
                var month = date.Month.ToString();
                var day = date.Day.ToString();

                if (month.Length == 1)
                {
                    month = month.Insert(0, "0");
                }
                if (day.Length==1)
                {
                    day=day.Insert(0, "0");
                }

                return year+"-"+month+"-"+day;
            }   
        }

        public string  apod_values { get; set; }

        public ApodUrlGenerator() : base(BaseUri)
        {
            apod_values=apiKey+";"+"true"+";"+currentDate;
        } 

        public string GetDefaultUrl()
        {
            return GetUrl(apod_params, apod_values);
        }
    }
}
