using Android.App;
using Android.OS;
using Android.Widget;
using Android.Runtime;
using AndroidX.AppCompat.App;

namespace CIBR
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]

    public class SignupActivity : AppCompatActivity
    {
        EditText box_username;
        EditText box_cnic;
        EditText box_debitcard_number;
        EditText box_debitcard_pin;
        EditText box_password;
        EditText box_confirm_password;

        TextView txt_no_space;
        TextView txt_password_mismatch;
        TextView txt_cnic_not_found;
        TextView txt_incorrect_debitcard;
        TextView txt_incorrect_length;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_signup);

            box_username = FindViewById<EditText>(Resource.Id.box_username);
            box_cnic = FindViewById<EditText>(Resource.Id.box_cnic);
            box_debitcard_number = FindViewById<EditText>(Resource.Id.box_debitcard_number);
            box_debitcard_pin = FindViewById<EditText>(Resource.Id.box_debitcard_pin);
            box_password = FindViewById<EditText>(Resource.Id.box_password);
            box_confirm_password = FindViewById<EditText>(Resource.Id.box_confirm_password);

            txt_cnic_not_found = FindViewById<TextView>(Resource.Id.txt_cnic_not_found);
            txt_no_space = FindViewById<TextView>(Resource.Id.txt_no_space);
            txt_password_mismatch = FindViewById<TextView>(Resource.Id.txt_password_mismatch);
            txt_incorrect_debitcard = FindViewById<TextView>(Resource.Id.txt_incorrect_debitcard);
            txt_incorrect_length = FindViewById<TextView>(Resource.Id.txt_incorrect_length);

            FindViewById<Button>(Resource.Id.btn_signup).Click += (o, e) =>
            {
                txt_cnic_not_found.Visibility = Android.Views.ViewStates.Gone;
                txt_no_space.Visibility = Android.Views.ViewStates.Gone;
                txt_password_mismatch.Visibility = Android.Views.ViewStates.Gone;
                txt_incorrect_debitcard.Visibility = Android.Views.ViewStates.Gone;
                txt_incorrect_length.Visibility = Android.Views.ViewStates.Gone;

                int client_at = -1;
                int card_at = -1;
                bool same = true;

                for (int i = 0; i < Global.client.Count; i++) 
                {
                    if (Global.client[i][0].Equals(box_cnic.Text)) 
                    {
                        client_at = i;
                        break;
                    }
                }

                for (int i = 0; i < Global.card.Count; i++)
                {
                    if (Global.card[i][0].Equals(box_debitcard_number.Text) && Global.card[i][3].Equals(box_debitcard_pin.Text))
                    {
                        card_at = i;
                        break;
                    }
                }




                if (client_at == -1)
                {
                    txt_cnic_not_found.Visibility = Android.Views.ViewStates.Visible;
                }
                else if (card_at == -1)
                {
                    txt_incorrect_debitcard.Visibility = Android.Views.ViewStates.Visible;
                }
                else if (!Global.card[card_at][1].Equals(Global.client[client_at][0])) 
                {
                    same = false;
                    txt_incorrect_debitcard.Visibility = Android.Views.ViewStates.Visible;
                }

                else if (!Global.client[client_at][5].Equals(""))
                {

                    if (!box_confirm_password.Text.ToString().Equals(box_password.Text.ToString()))
                    {
                        txt_password_mismatch.Visibility = Android.Views.ViewStates.Visible;
                    }

                    if (box_username.Text.ToString().Contains(" "))
                    {
                        txt_no_space.Visibility = Android.Views.ViewStates.Visible;
                    }

                    if (box_username.Text.Length < 8 || box_password.Text.Length < 8)
                    {
                        txt_incorrect_length.Visibility = Android.Views.ViewStates.Visible;
                    }

                    if (
                    box_username.Text.Length >= 8
                     && box_password.Text.Length >= 8
                     && !box_username.Text.ToString().Contains(" ")
                     && box_confirm_password.Text.ToString().Equals(box_password.Text.ToString()))
                    {
                        Global.client[client_at][5] = box_username.Text;
                        Global.client[client_at][6] = box_password.Text;
                        System.Console.WriteLine("YOUR internet banking account has been created. Do NOT share your user name or password with anyone");
                    }

                }
                

            };

        }
    }
}