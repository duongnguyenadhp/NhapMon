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
    /// Interaction logic for UCPhanCongChuNhiem.xaml
    /// </summary>
    public partial class UCPhanCongChuNhiem : UserControl
    {
        csdl_nhapmoncnpmEntities db = new csdl_nhapmoncnpmEntities();
        ObservableCollection<ChuNhiemLop> DSChuNhiem { get; set; }
        public UCPhanCongChuNhiem()
        {
            InitializeComponent();
            var join = (from p in db.ChuNhiemLops
                       from c in db.GiaoViens
                       from d in db.Lops
                       where p.MaGV == c.MaGV && d.MaLop==p.MaLop
                       select new
                       {
                           TenLop=d.TenLop,
                           HocKy=p.HocKy,
                           NamHoc=p.NamHoc,
                           TenGV=c.TenGV
                       }).ToList();
            
            lvPCCN.ItemsSource = join;
        }

        private void lvPCCN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lvPCCN_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
