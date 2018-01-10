using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Media;
using Java.Lang;
using Android.Views;

namespace App4
{
    [Activity(Label = "VIVT Hat(Manual)", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public static MediaPlayer player;
        Button button1, button2;
        protected override void OnStop()
        {
            base.OnStop();
            if (MainActivity.player != null && MainActivity.player.IsPlaying) MainActivity.player.Stop();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
             {
                 Intent intent = new Intent(this, typeof(AutoActivity));

                 StartActivity(intent);

             };
            button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += delegate
              {
                  Intent intent = new Intent(this, typeof(ManualActivity));

                  StartActivity(intent);

              };
        }
        
    }

}

