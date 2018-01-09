using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Media;
using Java.Lang;

namespace App4
{
    [Activity(Label ="test")]
    class ManualActivity: Activity
    {
        Button button1, button2, button3, button4, button5, button6, button7, button8;
        MediaPlayer player;
        int start = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ManualActivity);
            //Buttom
            button1 = FindViewById<Button>(Resource.Id.buttonM1);
            button1.Click += delegate
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.yp);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    case 2:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.pks);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    default:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                }

                };
            button2 = FindViewById<Button>(Resource.Id.buttonM2);
            button2.Click += delegate
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.yp);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    case 2:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.pks);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    default:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                }
            };
            button3 = FindViewById<Button>(Resource.Id.buttonM3);
            button3.Click += delegate
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.yp);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    case 2:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.pks);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    default:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                }
            };
            button4 = FindViewById<Button>(Resource.Id.buttonM4);
            button4.Click += delegate
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.yp);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    case 2:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.pks);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    default:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                }
            };
            button5 = FindViewById<Button>(Resource.Id.buttonM5);
            button5.Click += delegate
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.yp);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    case 2:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.pks);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    default:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                }
            };
            button6 = FindViewById<Button>(Resource.Id.buttonM6);
            button6.Click += delegate
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.yp);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    case 2:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.pks);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    default:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                }
            };
            button7 = FindViewById<Button>(Resource.Id.buttonM7);
            button7.Click += delegate
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.yp);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    case 2:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.pks);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                    default:
                        start++;
                        player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        player.Start();
                        Thread.Sleep(10000);
                        break;
                }
            };
            button8 = FindViewById<Button>(Resource.Id.buttonM8);
            button8.Click += delegate
            {
                if (start>0)
                {
                    player.Stop();
                    Intent intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                }
            };
        }
    }
}