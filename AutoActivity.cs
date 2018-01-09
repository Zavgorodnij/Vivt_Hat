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
    [Activity(Label = "App4")]
    class AutoActivity : Activity
    {
        Button button1, button2, button3;
        MediaPlayer player;
        int start = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AutoActivity);
            button1 = FindViewById<Button>(Resource.Id.buttonA1);
            button1.Click += delegate
            {
                /*start++;
                player = MediaPlayer.Create(this, Resource.Raw.Test);
                player.Start();
                Thread.Sleep(10000);*/

                Random random = new Random();
                switch (random.Next(1, 7))
                {
                    case 1:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Test);
                        player.Start();
                        break;
                    case 2:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Test);
                        player.Start();
                        break;
                    case 3:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Test);
                        player.Start();
                        break;
                    case 4:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Test);
                        player.Start();
                        break;
                    case 5:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Test);
                        player.Start();
                        break;
                    case 6:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Test);
                        player.Start();
                        break;
                    case 7:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Test);
                        player.Start();
                        break;
                };
            };
            button2 = FindViewById<Button>(Resource.Id.buttonA2);
            button2.Click += delegate
            {
                if (start > 0)
                {
                    player.Stop();
                }

            };
            button3 = FindViewById<Button>(Resource.Id.buttonA3);
            button3.Click += delegate
            {
                if (start > 0)
                {
                    player.Stop();
                }
                Intent intent = new Intent(this, typeof(MainActivity));

                StartActivity(intent);
            };
            



        }
        /*public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            switch (keyCode)
            {
                // in smartphone
                case Keycode.VolumeUp:
                    start++;
                    player = MediaPlayer.Create(this, Resource.Raw.Test);
                    player.Start();
                    break;
                    //return true;
            }
            return base.OnKeyDown(keyCode, e);
        }*/
    }
}