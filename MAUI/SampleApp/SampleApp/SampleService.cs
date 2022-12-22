#if ANDROID
using CN.Jpush.Android.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    [Android.App.Service(Enabled = true, Exported = false, Process = ":pushcore", Name = "com.companyname.sampleapp.SampleService")]
    [Android.App.IntentFilter(new string[] { "cn.jiguang.user.service.action" })]
    public class SampleService : JCommonService
    {
    }
}
#endif
