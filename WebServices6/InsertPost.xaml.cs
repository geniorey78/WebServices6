﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebServices6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPost : ContentPage
    {
        public InsertPost()
        {
            InitializeComponent();
        }





        private async void btnInsertar_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);
                cliente.UploadValues("http://192.168.100.13/moviles/post.php", "POST", parametros);



                //await DisplayAlert("Alerta", "ingresado correctamente", "ok");
                var mensaje = "Dato ingresado con exito";
                DependencyService.Get<Mensaje>().LongAlert(mensaje);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
            }
            catch (Exception ex)
            {

                //await DisplayAlert("error", ex.Message, "ok");

            }
        }



        private async void btnRegresar_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());

        }
    }
}