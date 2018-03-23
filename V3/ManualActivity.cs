using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Media;
using Java.Lang;

namespace Vivat_HatV5
{
    [Activity(Label = "VIVT Hat")]
    class ManualActivity : Activity
    {
        Button button1, button2, button3, button4, button5, button6, button7, button8;
        int start = 0;
        int second = 3000;
        protected override void OnStop()
        {
            base.OnStop();
            if (MainActivity.player != null && MainActivity.player.IsPlaying) MainActivity.player.Stop();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ManualActivity);
            //Buttom
            button1 = FindViewById<Button>(Resource.Id.buttonM1);
            button1.Click += delegate
            {
                Random random = new Random();
                int idTrack = 0;
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        idTrack = Resource.Raw.yp;
                        break;
                    case 2:
                        start++;
                        idTrack = Resource.Raw.pks;
                        break;
                    default:
                        start++;


                        break;
                }
                MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                MainActivity.player.Start();
                Thread.Sleep(second);

            };
            button2 = FindViewById<Button>(Resource.Id.buttonM2);
            button2.Click += delegate
            {
                Random random = new Random();
                int idTrack = 0;
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        idTrack = Resource.Raw.yp;
                        break;
                    case 2:
                        start++;
                        idTrack = Resource.Raw.pks;
                        break;
                    default:
                        start++;


                        break;
                }
                MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                MainActivity.player.Start();
                Thread.Sleep(second);
            };
            button3 = FindViewById<Button>(Resource.Id.buttonM3);
            button3.Click += delegate
            {
                Random random = new Random();
                int idTrack = 0;
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        idTrack = Resource.Raw.yp;
                        break;
                    case 2:                 
                        start++;
                        idTrack = Resource.Raw.pks;
                        break;
                    default:
                        start++;


                        break;
                }

                MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                MainActivity.player.Start();
                Thread.Sleep(second);
            };
            button4 = FindViewById<Button>(Resource.Id.buttonM4);
            button4.Click += delegate
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.yp);
                        MainActivity.player.Start();
                        Thread.Sleep(second);
                        break;
                    case 2:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.pks);
                        MainActivity.player.Start();
                        Thread.Sleep(second);
                        break;
                    default:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        MainActivity.player.Start();
                        Thread.Sleep(second);
                        break;
                }
                MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                MainActivity.player.Start();
                Thread.Sleep(second);
            };
            button5 = FindViewById<Button>(Resource.Id.buttonM5);
            button5.Click += delegate
            {
                Random random = new Random();
                int idTrack = 0;
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        idTrack = Resource.Raw.yp;
                        break;
                    case 2:
                        start++;
                        idTrack = Resource.Raw.pks;
                        break;
                    default:
                        start++;


                        break;
                }
                MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                MainActivity.player.Start();
                Thread.Sleep(second);
            };
            button6 = FindViewById<Button>(Resource.Id.buttonM6);
            button6.Click += delegate
            {
                Random random = new Random();
                int idTrack = 0;
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        idTrack = Resource.Raw.yp;
                        break;
                    case 2:
                        start++;
                        idTrack = Resource.Raw.pks;
                        break;
                    default:
                        start++;


                        break;
                }
                MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                MainActivity.player.Start();
                Thread.Sleep(second);
            };
            button7 = FindViewById<Button>(Resource.Id.buttonM7);
            button7.Click += delegate
            {
                Random random = new Random();
                int idTrack = 0;
                switch (random.Next(0, 3))
                {
                    case 1:
                        start++;
                        idTrack = Resource.Raw.yp;
                        break;
                    case 2:
                        start++;
                        idTrack = Resource.Raw.pks;
                        break;
                    default:
                        start++;


                        break;
                }
                MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                MainActivity.player.Start();
                Thread.Sleep(second);
            };
            button8 = FindViewById<Button>(Resource.Id.buttonM8);
            button8.Click += delegate
            {
                if (start > 0)
                {
                    MainActivity.player.Stop();
                }
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);

            };
        }
    }
}