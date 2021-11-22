using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WebServices6.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServices6;

[assembly: Xamarin.Forms.Dependency(typeof(Mensaje_Android))]

namespace WebServices6.Droid
{
    class Mensaje_Android : Mensaje
    {
        public void LongAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();
        }

        public void ShortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();

        }
    }
}