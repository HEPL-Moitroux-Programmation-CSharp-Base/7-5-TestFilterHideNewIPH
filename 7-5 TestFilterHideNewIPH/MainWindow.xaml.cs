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

namespace WPFTestDatagrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Personne> listpersonne = new ObservableCollection<Personne>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = listpersonne;
            listpersonne.Add(new Personne("Simpson", "Homer", new DateTime(2051, 5, 21),
                    @"Images\HomerSimpson.png"));
            listpersonne.Add(new Personne("Simpson", "Marge", new DateTime(2050, 5, 30),
                @"Images\MargeSimpson.png"));
            listpersonne.Add(new Personne("Simpson", "Maggie", new DateTime(2018, 5, 15)));
            listpersonne.Add(new Personne("Simpson", "Bart", new DateTime(2018, 5, 30)));
        }

        private void Contains(object sender, FilterEventArgs e)
        {
            Personne item = e.Item as Personne;
            if (item != null)
            {
                e.Accepted = true;              
            }
        }

    }
}
