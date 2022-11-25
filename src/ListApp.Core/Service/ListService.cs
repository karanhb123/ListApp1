using System;
using ListApp.Core.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListApp.Core.Service
{
    public class ListService
    {
        private string newsurl = "https://newsdata.io/api/1/news?apikey=pub_13572c5466a64cb490ee50f3a7be343be77b5&q=fifa";

        public List<News> NewsList { get; private set; }
        public List<FavListModel> FavLists { get; set; }
        //public List<FavListModel> NList;
        public async Task<List<News>> LoadNews()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(newsurl);
            //var results = response.Content.GetType();
            string result = response.Content.ToString();
            Console.WriteLine(result);
            NewsModel Items;

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<NewsModel>(content);

                NewsList = Items.results;

            }
            List<FavListModel> NList=new List<FavListModel>();

            return NewsList;
        }
        
    }
}

