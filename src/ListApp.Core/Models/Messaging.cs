using System;
using MvvmCross.Plugin.Messenger;

namespace ListApp.Core.Models
{
    public class Messaging: MvxMessage
    {
        public Messaging(object sender) : base(sender)
        {
        }

        public bool IsOnline { get; set; }
        public string Errormsg { get; set; }


    }
}

