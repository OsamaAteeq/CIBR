using Android.App;
using Android.OS;
using Android.Widget;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Content;
using System.Collections.Generic;
using System;

namespace CIBR
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false , NoHistory = true)]
    public class InternetBankingActivity : AppCompatActivity
    {
        public override void OnBackPressed()
        {
            return;
        }

        TextView txt_log_out;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            int card_at = 0;
            int account_at = 0;
            string cnic = Intent.GetStringExtra("CNIC");
            for (int i = 0; i < Global.client.Count; i++) 
            {
                if (Global.client[i][1].Equals(cnic)) 
                {
                    card_at = i;
                    break;
                }
            }
            for (int i = 0; i < Global.account.Count; i++)
            {
                if (Global.account[i][1].Equals(cnic))
                {
                    account_at = i;
                    break;
                }
            }

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_internet_banking);

            txt_log_out = FindViewById<TextView>(Resource.Id.txt_log_out);

            txt_log_out.Click += (o, e) =>
            {
                StartActivity(typeof(MainActivity));
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}