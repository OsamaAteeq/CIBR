using Android.App;
using Android.OS;
using Android.Widget;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Content;
using System;

namespace CIBR
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]

    public class ForgotPasswordActivity : AppCompatActivity
    {
        
        EditText box_username;
        EditText box_debitcard_number;
        EditText box_debitcard_pin;

        TextView txt_no_space;
        TextView txt_forgot_username;
        TextView txt_incorrect;
        private string rndm = new Random().Next(0, 999999).ToString("D6");

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_forgot_password);

            box_username = FindViewById<EditText>(Resource.Id.box_username);
            box_debitcard_number = FindViewById<EditText>(Resource.Id.box_debitcard_number);
            box_debitcard_pin = FindViewById<EditText>(Resource.Id.box_debitcard_pin);

            txt_no_space = FindViewById<TextView>(Resource.Id.txt_no_space);
            txt_incorrect = FindViewById<TextView>(Resource.Id.txt_incorrect);
            txt_forgot_username = FindViewById<TextView>(Resource.Id.txt_forgot_username);



            FindViewById<Button>(Resource.Id.btn_next).Click += (o, e) =>
            {
                txt_no_space.Visibility = Android.Views.ViewStates.Gone;
                txt_incorrect.Visibility = Android.Views.ViewStates.Gone;
                if (box_username.Text.ToString().Contains(" "))
                {
                    txt_no_space.Visibility = Android.Views.ViewStates.Visible;
                }
                else if (box_username.Text.ToString().Length > 0 && box_debitcard_number.Text.ToString().Length > 0 && box_debitcard_pin.Text.ToString().Length > 0 )
                {
                    int at = -1;
                    for (int i = 0; i < Global.client.Count; i++) 
                    {
                        if (box_username.Text.ToString().Equals(Global.client[i][5])) 
                        {
                            at = i;
                        }
                    }
                    string cnic = Global.client[at][0];
                    if (at != 0) 
                    {
                        for (int i = 0; i < Global.card.Count; i++) 
                        {
                            if (Global.card[i][1].Equals(cnic)) 
                            {
                                at = i;
                            }
                        }
                    }
                    else
                        txt_incorrect.Visibility = Android.Views.ViewStates.Visible;

                    if (Global.card[at][0].Equals(box_debitcard_number.Text.ToString()) && Global.card[at][3].Equals(box_debitcard_pin.Text.ToString()))
                    {
                        /*
                            if(username not found || debitcard number not match || debitcard pin deoesnt match)
                                txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                            else
                                {
                        */
                        //CODE FOR DEMONSTRATION: 
                        System.Console.WriteLine("\n\n\n\n\n\n\nOTP : " + rndm); //SUPPOSED TO BE A MESSAGE
                        var OTPActivity = new Intent(this, typeof(OTPActivity));
                        OTPActivity.PutExtra("OTP", rndm);
                        StartActivity(OTPActivity);
                        /*
                                }
                        */
                    }
                    else
                        txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                    txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
            };
            txt_forgot_username.Click += (o, e) =>
            StartActivity(typeof(ForgotUsernameActivity));
        }
    }
}