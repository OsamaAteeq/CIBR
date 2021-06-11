using Android.App;
using Android.OS;
using Android.Widget;
using Android.Runtime;
using AndroidX.AppCompat.App;

namespace CIBR
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false, NoHistory = true)]

    public class ForgotUsernameActivity : AppCompatActivity
    {
        EditText box_cnic;
        EditText box_debitcard_number;
        EditText box_debitcard_pin;

        TextView txt_incorrect;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_forgot_username);

            box_cnic = FindViewById<EditText>(Resource.Id.box_cnic);
            box_debitcard_number = FindViewById<EditText>(Resource.Id.box_debitcard_number);
            box_debitcard_pin = FindViewById<EditText>(Resource.Id.box_debitcard_pin);

            txt_incorrect = FindViewById<TextView>(Resource.Id.txt_incorrect);
            FindViewById<Button>(Resource.Id.btn_next).Click += (o, e) =>
            {
                txt_incorrect.Visibility = Android.Views.ViewStates.Gone;
                if (box_cnic.Text.Length != 0 && box_debitcard_number.Text.Length != 0 && box_debitcard_pin.Text.Length != 0)
                {
                    int at = -1;
                    for (int i = 0; i < Global.card.Count; i++) 
                    {
                        if (box_cnic.Text.ToString().Equals(Global.card[i][1])) 
                        {
                            at = i;
                        }
                    }

                    if (at != -1) 
                    {
                        if (Global.card[at][0].Equals(box_debitcard_number.Text.ToString()) && Global.card[at][3].Equals(box_debitcard_pin.Text.ToString())) 
                        {

                            for (int i = 0; i < Global.client.Count; i++) 
                            {
                                if (Global.client[i][0].Equals(box_cnic.Text.ToString())) 
                                {
                                    at = i;
                                }
                            }
                            
                            if (!Global.client[at][5].Equals("")) 
                            {
                                //SUPPOSED TO SEND SMS TO USER
                                System.Console.WriteLine("USERNAME IS : \""+Global.client[at][5]+"\"");
                                StartActivity(typeof(MainActivity));
                            }
                            else
                                txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                        }
                        else
                            txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                    }
                    else
                        txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                    /*
                    if(cnic not found || debitcard number not match || debitcard pin deoesnt match)
                    {
                        txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                    }
                    else {sms username}
                    */

                }
            };

        }
    }
}