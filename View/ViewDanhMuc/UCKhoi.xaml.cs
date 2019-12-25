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
    /// Interaction logic for UCKhoi.xaml
    /// </summary>
    public partial class UCKhoi : UserControl
    {
        csdl_nhapmoncnpmEntities db = new csdl_nhapmoncnpmEntities();
        ObservableCollection<Khoi> DSKhoi { get; set; }
        public UCKhoi()
        {
            InitializeComponent();
            DSKhoi =new ObservableCollection<Khoi>(db.Khois.ToList());
            lvKhoi.ItemsSource = DSKhoi;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            Khoi newKhoi = new Khoi();
            newKhoi.MaKhoi = int.Parse(tbMaKhoi.Text);
            newKhoi.TenKhoi = tbTenKhoi.Text;
            var check = db.Khois.Where(x => x.MaKhoi == newKhoi.MaKhoi).SingleOrDefault();
            if (check == null)
            {
                db.Khois.Add(newKhoi);
                db.SaveChanges();
                DSKhoi.Add(newKhoi);

            }
            else
            {
                MessageBox.Show("Trùng mã khối!");
            }

        }

        private void btnXo_Click(object sender, RoutedEventArgs e)
        {
            Khoi userSelected = lvKhoi.SelectedItem as Khoi;
            var check = db.Khois.Where(x => x.MaKhoi == userSelected.MaKhoi).SingleOrDefault();
            if (check != null)
            {
                db.Khois.Remove(check);
                db.SaveChanges();
                DSKhoi.Remove(check);
            }
        }

        private void lvKhoi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
