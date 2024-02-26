using System;
using System.Collections.Generic;
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

namespace NBAManagement.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainScrenNBA.xaml
    /// </summary>
    public partial class MainScrenNBA : Page
    {
        public MainScrenNBA()
        {
            InitializeComponent();
        }

        private void btn_Visitor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisitorMenu());
        }
    }
}
