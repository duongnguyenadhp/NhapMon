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
    /// Interaction logic for UCGiaoVien.xaml
    /// </summary>
    public partial class UCGiaoVien : UserControl
    {
        csdl_nhapmoncnpmEntities db = new csdl_nhapmoncnpmEntities();
        ObservableCollection<GiaoVien> DSGiaoVien { get; set; }
        public UCGiaoVien()
        {
            InitializeComponent();
            DSGiaoVien = new ObservableCollection<GiaoVien>(db.GiaoViens.ToList());
            lvGiaoVien.ItemsSource = DSGiaoVien;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
