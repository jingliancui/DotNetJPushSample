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
using CN.Jpush.Android.Api;
using CN.Jpush.Android.Service;
using Xamarin.Forms.Platform.Android;

namespace SampleApp.Droid
{
    
    [BroadcastReceiver(Enabled = true, Exported = false)]
    [Android.App.IntentFilter(new string[]
    {
        "cn.jpush.android.intent.RECEIVE_MESSAGE"
    },
    Categories=new string[] 
    {
        "com.companyname.sampleapp"
    })]
    public class SampleReceiver : JPushMessageReceiver
    {
        public override void OnNotifyMessageOpened(Context p0, NotificationMessage p1)
        {
            base.OnNotifyMessageOpened(p0, p1);

            App.Paras = p1.NotificationExtras;            
        }
    }
    
}