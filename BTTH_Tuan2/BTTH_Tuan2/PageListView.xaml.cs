using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH_Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListView : ContentPage
    {
        ObservableCollection<ClassHoa> Hoas = new ObservableCollection<ClassHoa>();

        public PageListView()
        {
            InitializeComponent();
            Hoas.Add(new ClassHoa { TenHoa = "Đón xuân", Gia = 300, Hinh = "flowerone.jpg", Mota = "Hoa cúc các màu: trắng, vàng, cam" });
            Hoas.Add(new ClassHoa { TenHoa = "Hồn nhiên", Gia = 300, Hinh = "flowertwo.jpg", Mota = "Hoa cúc vàng, cam, lá măng" });
            Hoas.Add(new ClassHoa { TenHoa = "Tím thủy chung", Gia = 300, Hinh = "flowerthree.jpg", Mota = "Hoa cúc tím" });
            Hoas.Add(new ClassHoa { TenHoa = "Đón mẹ", Gia = 300, Hinh = "flowerfour.jpg", Mota = "Hoa hẹ" });

            listhoa.ItemsSource = Hoas;
        }
    }
}