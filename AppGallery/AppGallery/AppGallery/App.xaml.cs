using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //pagina já passando para o construtor a pagina que definimos
            //var pagina = new NavigationPage(
            //        new XamarinForms.Paginas.PaginaNavegacao.Conteudo01()
            //    );

            MainPage = new XamarinForms.Paginas.Modal.Conteudo01();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
