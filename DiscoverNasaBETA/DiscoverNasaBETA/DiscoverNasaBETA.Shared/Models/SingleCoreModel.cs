using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverNasaBETA.Models
{
    public class Apod_RootObject
    {
        public string url { get; set; }
        public string media_type { get; set; }
        public string explanation { get; set; }
        public List<string> concepts { get; set; }
        public string title { get; set; }
        public string concepts_string
        {
            get
            {
                var result = string.Empty;
                foreach (var item in concepts)
                {
                    result+="#"+item+"  ";
                }
                if (result!=string.Empty)
                {
                    result =  result.Insert(0, "Concept Tags: ");
                }
                return result;
            }
        }
    }

    public class Sounds_Result
    {
        public string description { get; set; }
        public string license { get; set; }
        public string title { get; set; }
        public string download_url { get; set; }
        public int duration { get; set; }
        public string last_modified { get; set; }
        public string stream_url { get; set; }
        public string tag_list { get; set; }
        public int id { get; set; }
    }

    public class Sounds_RootObject
    {
        public int count { get; set; }
        public List<Sounds_Result> results { get; set; }
    }

    public class Earth_Result
    {
        public string date { get; set; }
        public string id { get; set; }
    }

    public class Earth_RootObject
    {
        public int count { get; set; }
        public List<Earth_Result> results { get; set; }
    }

    public class Imagery_RootObject
    {
        public string date { get; set; }
        public string url { get; set; }
        public double cloud_score { get; set; }
        public string id { get; set; }
    }
}
