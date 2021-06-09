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

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        TextView txt_forgot_password;
        TextView txt_employee;
        TextView txt_forgot_username;
        TextView txt_signup;
        TextView txt_no_space;
        TextView txt_incorrect;

        EditText box_username;
        EditText box_password;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            //DATA ENTERY
            Global.client1.Add("1234567890123");
            Global.client1.Add("Osama");
            Global.client1.Add("Ateeq");
            Global.client1.Add("M");
            Global.client1.Add("03618604568");
            Global.client1.Add("");
            Global.client1.Add("");

            Global.client.Add(Global.client1);
            Global.client1.Clear();

            Global.client1.Add("1234567890124");
            Global.client1.Add("Umar");
            Global.client1.Add("Ateeq");
            Global.client1.Add("M");
            Global.client1.Add("03618657568");
            Global.client1.Add("UMARATEEQ");
            Global.client1.Add("12345678");

            Global.client.Add(Global.client1);
            Global.client1.Clear();
            Global.client1.Add("1234567890125");
            Global.client1.Add("Ali");
            Global.client1.Add("Ateeq");
            Global.client1.Add("M");
            Global.client1.Add("03636607568");
            Global.client1.Add("ALIATEEQ");
            Global.client1.Add("87654321");

            Global.client.Add(Global.client1);
            Global.client1.Clear();
            Global.client1.Add("1234567890126");
            Global.client1.Add("Umar");
            Global.client1.Add("Ali");
            Global.client1.Add("M");
            Global.client1.Add("03638404566");
            Global.client1.Add("UMARSATTI");
            Global.client1.Add("24681012");

            Global.client.Add(Global.client1);
            Global.client1.Clear();

            Global.client1.Add("1234567890127");
            Global.client1.Add("Osama");
            Global.client1.Add("Atiq");
            Global.client1.Add("M");
            Global.client1.Add("03418302568");
            Global.client1.Add("");
            Global.client1.Add("");

            Global.client.Add(Global.client1);
            Global.client1.Clear();

            Global.client1.Add("1234567890128");
            Global.client1.Add("Farrah");
            Global.client1.Add("Rehman");
            Global.client1.Add("F");
            Global.client1.Add("03648305598");
            Global.client1.Add("");
            Global.client1.Add("");

            Global.client.Add(Global.client1);
            Global.client1.Clear();

            Global.client1.Add("1234567890129");
            Global.client1.Add("Fatima");
            Global.client1.Add("Mustehsin");
            Global.client1.Add("F");
            Global.client1.Add("03868246598");
            Global.client1.Add("FATIMA12");
            Global.client1.Add("135791113");

            Global.client.Add(Global.client1);
            Global.client1.Clear();

            Global.client1.Add("1234567890130");
            Global.client1.Add("Khadija");
            Global.client1.Add("Khan");
            Global.client1.Add("F");
            Global.client1.Add("03633355598");
            Global.client1.Add("");
            Global.client1.Add("");

            Global.client.Add(Global.client1);
            Global.client1.Clear();

            Global.client1.Add("1234567890131");
            Global.client1.Add("Laiba");
            Global.client1.Add("Shahid");
            Global.client1.Add("F");
            Global.client1.Add("03448800553");
            Global.client1.Add("SHAHIDLAIBA");
            Global.client1.Add("09876543");

            Global.client.Add(Global.client1);
            Global.client1.Clear();

            Global.client1.Add("1234567890132");
            Global.client1.Add("Zubaida");
            Global.client1.Add("Imran");
            Global.client1.Add("F");
            Global.client1.Add("03191629460");
            Global.client1.Add("");
            Global.client1.Add("");

            Global.client.Add(Global.client1);
            Global.client1.Clear();

            

            Global.account1.Add("PK36SCBL0000001123456703");
            Global.account1.Add("1234567890123");
            Global.account1.Add("Saving");
            Global.account1.Add("Active");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();
            Global.account1.Add("PK36SCBL0000001123456704");
            Global.account1.Add("1234567890124");
            Global.account1.Add("Current");
            Global.account1.Add("Active");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();

            Global.account1.Add("PK36SCBL0000001123456705");
            Global.account1.Add("1234567890125");
            Global.account1.Add("Current");
            Global.account1.Add("Dormant");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();

            Global.account1.Add("PK36SCBL0000001123456706");
            Global.account1.Add("1234567890126");
            Global.account1.Add("Saving");
            Global.account1.Add("Active");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();


            Global.account1.Add("PK36SCBL0000001123456707");
            Global.account1.Add("1234567890127");
            Global.account1.Add("Current");
            Global.account1.Add("Active");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();


            Global.account1.Add("PK36SCBL0000001123456708");
            Global.account1.Add("1234567890128");
            Global.account1.Add("Saving");
            Global.account1.Add("Dormant");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();


            Global.account1.Add("PK36SCBL0000001123456709");
            Global.account1.Add("1234567890129");
            Global.account1.Add("Current");
            Global.account1.Add("Active");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();


            Global.account1.Add("PK36SCBL0000001123456710");
            Global.account1.Add("1234567890130");
            Global.account1.Add("Current");
            Global.account1.Add("Active");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();


            Global.account1.Add("PK36SCBL0000001123456711");
            Global.account1.Add("1234567890131");
            Global.account1.Add("Saving");
            Global.account1.Add("Active");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();


            Global.account1.Add("PK36SCBL0000001123456712");
            Global.account1.Add("1234567890132");
            Global.account1.Add("Current");
            Global.account1.Add("Active");
            Global.account1.Add("03191629460");

            Global.account.Add(Global.account1);
            Global.account1.Clear();


            int bal = 50000;
            for (int i = 0; i < Global.account.Count; i++) 
            {
                Global.balance.Add(bal);
                bal += new Random().Next(0, 30000);
                bal -= new Random().Next(0, 30000);
            }

            long card_number = 1234567890123456;
            long c = 1234567890123;
            int vin = 1234;
            int pin = 4321;
            for (int i = 0; i < Global.account.Count; i++)
            {
                card_number += 1;
                c += 1;
                vin += 1;
                pin--;
                Global.card1.Add(card_number.ToString());
                Global.card1.Add(c.ToString());
                Global.card1.Add(vin.ToString());
                Global.card1.Add(pin.ToString());

                Global.card.Add(Global.card1);
                Global.card1.Clear();
            }


            //PROGRAM
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            txt_signup = FindViewById<TextView>(Resource.Id.txt_signup);
            txt_employee = FindViewById<TextView>(Resource.Id.txt_employee);
            txt_no_space = FindViewById<TextView>(Resource.Id.txt_no_space);
            txt_incorrect = FindViewById<TextView>(Resource.Id.txt_incorrect);
            txt_forgot_password = FindViewById<TextView>(Resource.Id.txt_forgot_password);
            txt_forgot_username = FindViewById<TextView>(Resource.Id.txt_forgot_username);

            box_username = FindViewById<EditText>(Resource.Id.box_username);
            box_password = FindViewById<EditText>(Resource.Id.box_password);


            FindViewById<Button>(Resource.Id.btn_signin).Click += (o, e) =>
            {
                txt_no_space.Visibility = Android.Views.ViewStates.Gone;
                txt_incorrect.Visibility = Android.Views.ViewStates.Gone;
                if (box_username.Text.ToString().Contains(" ")) 
                {
                    txt_no_space.Visibility = Android.Views.ViewStates.Visible;
                }
                else if (box_username.Text.ToString().Length != 0 && box_password.Text.ToString().Length != 0)
                {
                    int at = -1;
                    for (int i = 0; i < Global.client.Count; i++) 
                    {
                        if (Global.client[i][5].Equals(box_username.Text.ToString())) 
                        {
                            at = i;
                        }
                    }

                    if (at != -1)
                    {
                        if (Global.client[at][6].Equals(box_password.Text.ToString()))
                        {
                            string cnic = Global.client[at][0];
                            var InternetBankingActivity = new Intent(this, typeof(InternetBankingActivity));
                            InternetBankingActivity.PutExtra("CNIC", cnic);
                            StartActivity(InternetBankingActivity);
                        }
                        else
                        {
                            txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                        }
                    }
                    else 
                    {
                        txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                    }
                    
                    /*
                        if(username is incorrect || password is incorrect)
                        txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                        else 
                        string cnic = "";
                        //cnic = cnic from database

                        var InternetBankingActivity = new Intent(this, typeof(InternetBankingActivity));
                        InternetBankingActivity.PutExtra("CNIC", cnic);
                        StartActivity(InternetBankingActivity);
                    */
                }
            };

            

            txt_forgot_password.Click += (o, e) =>
            StartActivity(typeof(ForgotPasswordActivity));

            txt_employee.Click += (o, e) =>
             StartActivity(typeof(EmployeeMainActivity));

            txt_forgot_username.Click += (o, e) =>
            StartActivity(typeof(ForgotUsernameActivity));

            txt_signup.Click += (o, e) =>
             StartActivity(typeof(SignupActivity));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}