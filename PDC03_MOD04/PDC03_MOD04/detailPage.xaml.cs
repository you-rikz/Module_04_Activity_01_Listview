using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class detailPage : ContentPage
    {
        public detailPage()
        {
            InitializeComponent();
        }

        async void OnCloseButton(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}