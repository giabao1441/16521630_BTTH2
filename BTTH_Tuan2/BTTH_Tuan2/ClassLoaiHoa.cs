using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH_Tuan2
{
    class ClassLoaiHoa : List<ClassHoa>
    {
        public string TenLoai { get; set; }
        private ClassLoaiHoa (string TenLoai)
        {
            this.TenLoai = TenLoai;
        }
        public IList<ClassLoaiHoa> LoaiHoas { get; set; }
        public ClassLoaiHoa()
        {
            List<ClassLoaiHoa> l = new List<ClassLoaiHoa>
            {
                new ClassLoaiHoa ("Hoa cúc")
                    {
                        new ClassHoa {TenHoa = "Đón xuân", Gia = 300, Hinh = "flowerone.jpg", Mota = "Hoa cúc các màu: trắng, vàng, cam" },
                        new ClassHoa {TenHoa = "Hồn nhiên", Gia = 300, Hinh = "flowertwo.jpg", Mota = "Hoa cúc vàng, cam, lá măng"},
                        new ClassHoa {TenHoa = "Đón mẹ", Gia = 300, Hinh = "flowerfour.jpg", Mota = "Hoa hẹ"}
                    },

                    new ClassLoaiHoa ("Hoa Cuới")
                    {
                        new ClassHoa { TenHoa = "Tím thủy chung", Gia = 300, Hinh = "flowerthree.jpg", Mota = "Hoa cúc tím" },
                        new ClassHoa { TenHoa = "Đón xuân", Gia = 300, Hinh = "flowerone.jpg", Mota = "Hoa cúc các màu: trắng, vàng, cam" },
                        new ClassHoa { TenHoa = "Hồn nhiên", Gia = 300, Hinh = "flowertwo.jpg", Mota = "Hoa cúc vàng, cam, lá măng"},
                        new ClassHoa { TenHoa = "Đón mẹ", Gia = 300, Hinh = "flowerfour.jpg", Mota = "Hoa hẹ"}
                    },
                    new ClassLoaiHoa ("Hoa đám ma")
                    {
                        new ClassHoa {TenHoa = "Đón xuân", Gia = 300, Hinh = "flowerone.jpg", Mota = "Hoa cúc các màu: trắng, vàng, cam" },
                        new ClassHoa {TenHoa = "Hồn nhiên", Gia = 300, Hinh = "flowertwo.jpg", Mota = "Hoa cúc vàng, cam, lá măng"},
                        new ClassHoa {TenHoa = "Đón mẹ", Gia = 300, Hinh = "flowerfour.jpg", Mota = "Hoa hẹ"}
                    }
            };
            LoaiHoas = l;
        }
    } 
}
