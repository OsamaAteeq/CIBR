using Android.App;
using Android.OS;
using Android.Widget;
using Android.Runtime;
using AndroidX.AppCompat.App;
using System.Collections.Generic;

namespace CIBR
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]

    public class EmployeeMainActivity : AppCompatActivity
    {
        

        EditText box_pass_code;
        EditText box_employee_id;
        EditText box_branch_code;

        TextView txt_incorrect;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_employee_main);

            box_pass_code = FindViewById<EditText>(Resource.Id.box_pass_code);
            box_employee_id = FindViewById<EditText>(Resource.Id.box_employee_id);
            box_branch_code = FindViewById<EditText>(Resource.Id.box_branch_id);

            txt_incorrect = FindViewById<TextView>(Resource.Id.txt_incorrect);

            FindViewById<Button>(Resource.Id.btn_signin).Click += (o, e) =>
            {
                txt_incorrect.Visibility = Android.Views.ViewStates.Gone;
                /*
                if(username doesnt exist or password incorrect or branch code is incorrect)
                {
                    txt_incorrect.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    StartActivity(typeof(EmployeePageActivity));
                }
                */
            };

        }
    }
}