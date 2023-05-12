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
    public partial class activity05 : ContentPage
    {

        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = contacts;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var detailPage = new detailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name="Arnold Nicholas Lim",
                Age=21,
                Occupation="Analyst",
                Country="Philippines"
            });

            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "John Cena",
                Age = 45,
                Occupation = "Wrestler",
                Country = "Dubai"
            });

            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "Shawn Michaels",
                Age = 55,
                Occupation = "Wrestler",
                Country = "New York"
            });
        }
    }
}