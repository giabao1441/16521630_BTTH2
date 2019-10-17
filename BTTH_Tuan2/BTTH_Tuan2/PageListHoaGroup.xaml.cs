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
    public partial class PageListHoaGroup : ContentPage
    {
        public PageListHoaGroup()
        {
            InitializeComponent();
            ClassLoaiHoa l = new ClassLoaiHoa();
            lstHoa.ItemsSource = l.LoaiHoas;
        }
    }
}