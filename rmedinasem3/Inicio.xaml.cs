﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rmedinasem3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAbri_Clicked(object sender, EventArgs e)
        {   
            string datoUno = txtDato.Text;
            string datoDos = txtDatoDos.Text;

            //Abrir ventana registro

        }
    }
}