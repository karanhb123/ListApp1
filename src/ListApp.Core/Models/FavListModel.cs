using System;
using System.Collections.Generic;

namespace ListApp.Core.Models
{
    public class FavListModel
    {
        public int Lid { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public string? image_url { get; set; }
        public bool IsFav { get; set; }
    }
}

