using PDC03_MOD04.DataModels;
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
    public partial class activity1 : ContentPage
    {
        public activity1()
        {
            InitializeComponent();
            List<BallInfo> myList = new List<BallInfo>
            {
               new BallInfo{Name="Mikasa", Description="V200W", ImageUrl="https://mikasasports.co.jp/e/wp-content/uploads/2018/11/V200W.png" },
               new BallInfo{Name="Molten", Description="V5M", ImageUrl="https://storage.sg.content-cdn.io/cdn-cgi/image/width=400,height=400,quality=75,format=auto,fit=cover,g=top/in-resources/2179346b-6078-4d04-9dbf-902897b11350/Images/ProductImages/Source/V5M3500_1.jpg" },
               new BallInfo{Name="Wilson", Description="K1 Gold", ImageUrl="https://www.wilson.com/en-us/media/catalog/product/W/T/WTH1895A5XB__c0474667aa4b4376ebb6d3b7ccfe76fc.png?dpr=1&fit=bounds&orient=1&quality=95&optimize=high&format=pjpg&auto=webp&enable=upscale&width=778&height=950&canvas=778%2C950&bg-color=f5f5f5" },
            };
            myListView.ItemsSource = myList;
        }
    }
}