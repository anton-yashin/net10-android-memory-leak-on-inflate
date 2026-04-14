using Android.Views;

namespace AndroidApp2
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private TextView? _textView;
        bool _enabled;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _textView = RequireViewById<TextView>(Resource.Id.textView);
            _textView.Text = "click me";
            _textView.Click += (o, e) => _enabled = !_enabled;

            LoopViews();
        }

        private async void LoopViews()
        {
            await Task.Yield();

            while (true)
            {
                if (_enabled)
                {
                    LayoutInflater.Inflate(Resource.Layout.test, null, false);
                }

                if (_textView != null)
                {
                    var s = _enabled ? "stop" : "start";
                    _textView.Text = $"{DateTime.UtcNow}\nref count {ReferenceCounter.Count}. Click me to {s}";
                }

                await Task.Delay(50);
            }
        }

    }
}