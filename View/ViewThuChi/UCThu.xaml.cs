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
    /// Interaction logic for UCThu.xaml
    /// </summary>
    public partial class UCThu : UserControl
    {
        csdl_nhapmoncnpmEntities db = new csdl_nhapmoncnpmEntities();
        ObservableCollection<PhieuThu> DSPhieuThu { get; set; }
        public UCThu()
        {
            InitializeComponent();
            var join = (from p in db.PhieuThus
                        from c in db.LoaiPhieuThus
                        where p.MaLoaiPhieuThu == c.MaLoaiPhieuThu
                        select new
                        {
                            MaPhieuThu = p.MaPhieuThu,
                            TenLoaiPhieuThu = c.TenLoaiPhieuThu,
                            NgayTaoPhieu = p.NgayTaoPhieu,
                            SoTienThu = p.SoTienThu,
                            TinhTrang = p.TinhTrang,
                        }
                    ).ToList();
            lvThu.ItemsSource = join;
        }
        

        private void lvThu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
