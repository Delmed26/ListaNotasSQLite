using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaNotasSQLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditNote : ContentPage
    {
        public EditNote()
        {
            InitializeComponent();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            var nota = (Nota)BindingContext;

            nota.date = DateTime.Now;

            await App.DatabaseNotas.SaveNoteAsync(nota);

            await Navigation.PopAsync();
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var nota = (Nota)BindingContext;

            await App.DatabaseNotas.DeleteNoteAsync(nota);

            await Navigation.PopAsync();
        }
    }
}