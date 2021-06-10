using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTarefas.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listar : ContentPage
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void OnBtnCadastrar(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Cadastrar());
        }

        private void OnBtnVisualizar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Visualizar());
        }
    }
}