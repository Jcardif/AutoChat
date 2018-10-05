using System;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace AutoChat.Adapters
{
    public class ChatListViewAdapter : BaseAdapter
    {
        public override Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }

        public override int Count { get; }
    }
}