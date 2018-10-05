using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AutoChat.Models
{
    public enum Status
    {
        Sent, Delivered
    }

    public enum UserType
    {
        Other, Self
    }
    public class AutoChatItem
    {
        public UserType UserType { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }
        public Status Status { get; set; }

    }
}