using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Media;
using Java.Lang;
using Android.Views;
using Java.IO;
using System.Collections.Generic;

namespace Vivat_HatV5
{
    [Activity(Label = "VIVT Hat(Auto)")]
    class AutoActivity : Activity
    {
        Random random = new Random();
        Button button1, button2, button3;
        LinearLayout line1;
        //MediaPlayer player;
        int start = 0;
        public override void OnActionModeStarted(ActionMode mode)
        {
            base.OnActionModeStarted(mode);
        }
        protected override void OnStop()
        {
            base.OnStop();
            if (MainActivity.player != null && MainActivity.player.IsPlaying) MainActivity.player.Stop();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AutoActivity);
            // Android.Util.Log.Info()
            line1 = FindViewById<LinearLayout>(Resource.Id.lineLayot);
            line1.KeyPress += Line1_KeyPress;
            button1 = FindViewById<Button>(Resource.Id.buttonA1);
            button1.Click += delegate
            {
                /*start++;
                player = MediaPlayer.Create(this, Resource.Raw.Test);
                player.Start();
                Thread.Sleep(10000);*/

                
                switch (random.Next(1, 8))
                {
                    case 1:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.econom);
                        MainActivity.player.Start();
                        break;
                    case 2:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.ivt);
                        MainActivity.player.Start();
                        break;
                    case 3:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.logist);
                        MainActivity.player.Start();
                        break;
                    case 4:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.yp);
                        MainActivity.player.Start();
                        break;
                    case 5:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.secretarsh);
                        MainActivity.player.Start();
                        break;
                    case 6:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.naladshik);
                        MainActivity.player.Start();
                        break;
                    case 7:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        MainActivity.player.Start();
                        break;
                };
            };
            button2 = FindViewById<Button>(Resource.Id.buttonA2);
            button2.Click += delegate
            {
                if (start > 0)
                {
                    MainActivity.player.Stop();
                }

            };
            button3 = FindViewById<Button>(Resource.Id.buttonA3);
            button3.Click += delegate
            {
                if (start > 0)
                {
                    MainActivity.player.Stop();
                }
                Intent intent = new Intent(this, typeof(MainActivity));

                StartActivity(intent);
                //KeyEvent.Creator.()
            };




        }

        private void Line1_KeyPress(object sender, View.KeyEventArgs e)
        {
            if (e.KeyCode == Keycode.VolumeUp)
            {
                Random random = new Random();
                switch (random.Next(1, 7))
                {
                    case 1:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.econom);
                        MainActivity.player.Start();
                        break;
                    case 2:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.ivt);
                        MainActivity.player.Start();
                        break;
                    case 3:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.logist);
                        MainActivity.player.Start();
                        break;
                    case 4:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.yp);
                        MainActivity.player.Start();
                        break;
                    case 5:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.secretarsh);
                        MainActivity.player.Start();
                        break;
                    case 6:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.naladshik);
                        MainActivity.player.Start();
                        break;
                    case 7:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        MainActivity.player.Start();
                        break;
                };
            }
        }

        public override bool OnKeyDown(Keycode e, KeyEvent keyEvent)
        {
            base.OnKeyDown(e, keyEvent);
            if (e == Keycode.VolumeUp)
            {
                Random random = new Random();
                switch (random.Next(1, 7))
                {
                    case 1:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.econom);
                        MainActivity.player.Start();
                        break;
                    case 2:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.ivt);
                        MainActivity.player.Start();
                        break;
                    case 3:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.logist);
                        MainActivity.player.Start();
                        break;
                    case 4:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.yp);
                        MainActivity.player.Start();
                        break;
                    case 5:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.secretarsh);
                        MainActivity.player.Start();
                        break;
                    case 6:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.naladshik);
                        MainActivity.player.Start();
                        break;
                    case 7:
                        start++;
                        MainActivity.player = MediaPlayer.Create(this, Resource.Raw.Addit);
                        MainActivity.player.Start();
                        break;
                };
            }
            if (e == Keycode.VolumeDown)
            {
                if (start > 0)
                {
                    MainActivity.player.Stop();
                }
            }
            return true;
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
    /*public class LogReaderTask : AsyncTask<Java.Lang.Void, Android.Resource.String, Java.Lang.Void>
    {
        private string LOGCAT_CMD = "logcat";
        private int BUFFER_SIZE = 1024;
        private bool isRunning = true;
        private Java.Lang.Process logprocess = null;
        private Java.IO.BufferedReader reader = null;
        private List<string> line = null;
        public object adapter { get; private set; }
        protected void doInBackground()
        {
            try
            {
                logprocess = Runtime.GetRuntime().Exec(LOGCAT_CMD);
            }
            catch (InvalidOperationException e)
            {
                isRunning = false;
            }
            try
            {
                reader = new Java.IO.BufferedReader(new InputStreamReader(
                        logprocess.InputStream), BUFFER_SIZE);
            }
            catch (IllegalArgumentException e)
            {
                e.PrintStackTrace();
                isRunning = false;
            }
            try
            {
                while (isRunning)
                {
                    line.Add(reader.ReadLine());
                    PublishProgress(line.ToArray());
                }
            }
            catch (IOException e)
            {
                e.PrintStackTrace();
                isRunning = false;
            }
        }
        protected void onCancelled()
        {
            base.OnCancelled();
        }
        protected void onPreExecute()
        {
            base.OnPreExecute();
        }
        protected void onPostExecute(Java.Lang.Object result)
        {
            base.OnPostExecute(result);
        }
        protected void onProgressUpdate(params string[] values)
        {
            base.OnProgressUpdate(values);
            this.adapter = values[0];
        }
        public void stopTask()
        {
            isRunning = false;
            logprocess.Destroy();
        }
        protected override Java.Lang.Void RunInBackground(params Java.Lang.Void[] @params)
        {
           //Android.App.Application.
            return null;
        }
    }*/
}