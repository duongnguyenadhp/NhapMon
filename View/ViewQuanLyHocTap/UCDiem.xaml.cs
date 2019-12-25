using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VMHelper;
namespace View
{
    /// <summary>
    /// Interaction logic for UCDiem.xaml
    /// </summary>
    class Temp
    {
        public int MaHS { get; set; }
        public string TenHS { get; set; }
        public string CMND { get; set; }
        public bool? GioiTinh { get; set; }

        public string GioiTinh2 { get{
                if (GioiTinh == true)
                {
                    return "Nam";
                }
                return "Nữ";
          }}
        public string TenDT { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
    }
    public partial class UCDiem : UserControl
    {
        csdl_nhapmoncnpmEntities db = new csdl_nhapmoncnpmEntities();
        ObservableCollection<HocSinh> DSDiem { get; set; }
        public UCDiem()
        {
            InitializeComponent();
            var join = (from p in db.HocSinhs
                        from c in db.DanTocs
                        where p.MaDT == c.MaDT
                        select new Temp()
                        {
                            MaHS = p.MaHS,
                            TenHS = p.TenHS,
                            CMND = p.CMND,
                            GioiTinh = p.GioiTinh,
                            TenDT = c.TenDT,
                            NgaySinh = p.NgaySinh,
                            DiaChi = p.DiaChi,
                        }
                ).ToList();
            lvDiem.ItemsSource = join;
        }

        private string GioiTinh(bool i)
        {
            if (i)
            {
                return "Nam";

            }
            return "Nữ";
        }
        private void lvDiem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
