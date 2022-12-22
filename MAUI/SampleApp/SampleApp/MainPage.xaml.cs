namespace SampleApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void InitBtn_Clicked(object sender, EventArgs e)
    {
#if ANDROID
        var activity = Microsoft.Maui.ApplicationModel.Platform.CurrentActivity;
        CN.Jpush.Android.Api.JPushInterface.SetDebugMode(true);
        CN.Jpush.Android.Api.JPushInterface.Init(activity);
#endif
    }
}

