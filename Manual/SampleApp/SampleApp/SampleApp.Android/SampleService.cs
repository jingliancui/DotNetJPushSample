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
using CN.Jpush.Android.Service;

namespace SampleApp.Droid
{
    [Android.App.Service(Enabled =true,Exported =false,Process = ":pushcore")]
    [Android.App.IntentFilter(new string[] { "cn.jiguang.user.service.action" })]
    public class SampleService:JCommonService
    {
    }
}