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
        TextView txt_balance;
        TextView txt_card_number;
        TextView txt_transaction_amount;
        TextView txt_see_all;
        SearchView searchView1;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            int card_at = 0;
            int account_at = 0;
            int transaction_at = -1;
            string transaction_amount;
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

            if (Global.transaction.Count > 0)
            {
                for (int i = Global.transaction.Count - 1; i >= 0; i++)
                {
                    if (Global.transaction[i][2].Equals(Global.account[account_at][0]))
                    {
                        transaction_at = i;
                        break;
                    }
                }
            }

            if (transaction_at == -1)
            {
                transaction_amount = Global.balance[card_at].ToString();
            }
            else 
            {
                transaction_amount = Global.transaction[transaction_at][3];
            }

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_internet_banking);

            txt_balance = FindViewById<TextView>(Resource.Id.txt_balance);
            txt_card_number = FindViewById<TextView>(Resource.Id.txt_card_number);
            txt_transaction_amount = FindViewById<TextView>(Resource.Id.txt_transaction_amount);
            txt_see_all = FindViewById<TextView>(Resource.Id.txt_see_all);

            searchView1 = FindViewById<SearchView>(Resource.Id.searchView1);

            txt_log_out = FindViewById<TextView>(Resource.Id.txt_log_out);

            txt_card_number.Text = Global.card[card_at][0].Substring(0,4) + " "+ Global.card[card_at][0].Substring(4, 4) + " " + Global.card[card_at][0].Substring(8, 4) + " " + Global.card[card_at][0].Substring(12, 4);
            txt_balance.Text = "RS. "+Global.balance[card_at].ToString();
            txt_transaction_amount.Text = "RS. " + transaction_amount;

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