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
    /// Interaction logic for UCLop.xaml
    /// </summary>
    public partial class UCLop : UserControl
    {
        csdl_nhapmoncnpmEntities db = new csdl_nhapmoncnpmEntities();
        ObservableCollection<Lop> DSLop { get; set; }
        public UCLop()
        {
            InitializeComponent();
            DSLop = new ObservableCollection<Lop>(db.Lops.ToList());
            lvLop.ItemsSource = DSLop;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
