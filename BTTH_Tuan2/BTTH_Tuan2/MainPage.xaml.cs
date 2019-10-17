using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH_Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async private void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageListView());
        }
        async private void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageListHoaGroup());
        }
    }
}