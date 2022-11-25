using System;
using MvvmCross.Commands;
using System.Windows.Input;
using MvvmCross.Navigation;
using ListApp.Core.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using ListApp.Core.Service;
using System.Collections;

namespace ListApp.Core.ViewModels.Main
{
    public class ListViewModel:BaseViewModel
    {
        private string newsurl = "https://newsdata.io/api/1/news?apikey=pub_13572c5466a64cb490ee50f3a7be343be77b5&q=fifa";

        public ListViewModel()
        {
        }
        private List<News> _NewsList;
        public List<News> NewsList
        {
            get => _NewsList;
            set => SetProperty(ref _NewsList, value);
        }
        private List<FavListModel> _FavList;
        public List<FavListModel> FavList
        {
            get => _FavList;
            set => SetProperty(ref _FavList, value);
        }


        public ICommand getnews => new MvxCommand<bool>( (fromSignInButton) =>
        {
            getnews1();

        });
        public async  void getnews1()
        {
            var ret = new ListService();
            NewsList = await ret.LoadNews();
            var item = new FavListModel();
            int i = 0;
            var Flist = new List<FavListModel>();
            foreach (var rett in NewsList)
            {
                item.Lid = i + 1;
                item.title = rett.title;
                item.description = rett.description;
                item.image_url = rett.image_url;
                item.IsFav = false;
                i++;
                Flist.Add(item);

            }
            FavList = Flist;
 

        }

        //public ICommand ListView => new MvxCommand<string>((ListViewButtonClicked) =>
        //{
        //    string title;
        //    var result = FavList.Where(t => t.title == title).Select(t => t.IsFav);

        //    FavList. = true;

        //});
    }
}

