﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTarefas.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Visualizar : ContentPage
    {
        public Visualizar()
        {
            InitializeComponent();
        }

        private void OnBtnVoltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}