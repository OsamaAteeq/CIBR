using Android.App;
using Android.OS;
using Android.Widget;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Content;
using System;
using System.Timers;

namespace CIBR
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false , NoHistory =true)]

    public class OTPActivity : AppCompatActivity
    {
        Timer timer;
        public override void OnBackPressed()
        {
            timer.Stop();
            base.OnBackPressed();
        }
        private string rndm = new Random().Next(0, 99999999).ToString("D8");
        EditText box_otp1;
        EditText box_otp2;
        EditText box_otp3;
        EditText box_otp4;
        EditText box_otp5;
        EditText box_otp6;
        TextView txt_time;
        TextView txt_incorrect;

        

        protected override void OnCreate(Bundle savedInstanceState)
        {

            string otp = Intent.GetStringExtra("OTP");
            string user_name = Intent.GetStringExtra("USERNAME");

            System.Console.WriteLine("\n\n\n\n\n\n\nOTP : " + otp); //DISPLAY AGAIN
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_otp);

            box_otp1 = FindViewById<EditText>(Resource.Id.box_otp1);
            box_otp2 = FindViewById<EditText>(Resource.Id.box_otp2);
            box_otp3 = FindViewById<EditText>(Resource.Id.box_otp3);
            box_otp4 = FindViewById<EditText>(Resource.Id.box_otp4);
            box_otp5 = FindViewById<EditText>(Resource.Id.box_otp5);
            box_otp6 = FindViewById<EditText>(Resource.Id.box_otp6);

            

            txt_time = FindViewById<TextView>(Resource.Id.txt_time);
            txt_incorrect = FindViewById<TextView>(Resource.Id.txt_incorrect);

            timer = new Timer();
            timer.Interval = 1000;
            int count = 60;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            void Timer_Elapsed(object sender, ElapsedEventArgs e) 
            {
                count--;
                txt_time.Text = count.ToString();
                if (count <= 0) 
                {
                    timer.Stop();
                    StartActivity(typeof(ForgotPasswordActivity));
                }
            }

            FindViewById<Button>(Resource.Id.btn_enter).Click += (o, e) =>
            {
                timer.Stop();
                if (box_otp1.Text.Length == 1 && box_otp2.Text.Length == 1 && box_otp3.Text.Length == 1 && box_otp4.Text.Length == 1 && box_otp5.Text.Length == 1 && box_otp6.Text.Length == 1)
                {
                    string entered = box_otp1.Text;
                    entered += box_otp2.Text;
                    entered += box_otp3.Text;
                    entered += box_otp4.Text;
                    entered += box_otp5.Text;
                    entered += box_otp6.Text;

                    if (entered.Equals(otp))
                    {
                        System.Console.WriteLine(rndm);
                        for (int i = 0; i < Global.client.Count; i++) 
                        {
                            if (user_name.Equals(Global.client[i][5])) 
                            {
                                Global.client[i][6] = rndm;
                                break;
                            }
                        }
                        timer.Stop();
                        StartActivity(typeof(MainActivity));
                    }
                    else
                    {
                        txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                        
                    }
                }
                timer.Start();
            };
        }
    }
}