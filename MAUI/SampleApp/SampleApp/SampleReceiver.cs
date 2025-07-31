using Android.Content;
using CN.Jpush.Android.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    [BroadcastReceiver(Enabled = true, Exported = false, Name = "com.companyname.sampleapp.SampleReceiver")]
    [Android.App.IntentFilter(
    [
        "cn.jpush.android.intent.RECEIVE_MESSAGE",
    ],
    Categories = new string[]
    {
        "com.companyname.sampleapp"
    })]
    public class SampleReceiver : JPushMessageReceiver
    {
    }
}
