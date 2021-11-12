using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaNotasSQLite
{
    public partial class App : Application
    {
        static NotasBD notasBD;

        public static NotasBD DatabaseNotas 
        { 
            get
            {
                if(notasBD == null)
                {
                    notasBD = new NotasBD(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notas.db3"));
                }

                return notasBD;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
