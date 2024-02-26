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
using NBAManagement.Data;

namespace NBAManagement.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeamsMain.xaml
    /// </summary>
    public partial class TeamsMain : Page
    {
        int Count { get; set; } = 0;

        public TeamsMain()
        {
            InitializeComponent();

            var data = new BasketballSystemEntities();

            List<ListView> list = new List<ListView>(); 

            ListView view = new ListView();

            foreach (var entity in data.Team)
            {
                if (view.Items.Count < 5)
                {
                    view.Items.Add(entity);
                }
                else
                {
                    list.Add(view);
                    view = new ListView();
                    view.Items.Add(entity);
                }
            }

           
            if (view.Items.Count > 0)
            {
                list.Add(view);
            }


            DataTemplate dataTemplate = new DataTemplate(typeof(Team));

            FrameworkElementFactory stackPanelFactory = new FrameworkElementFactory(typeof(StackPanel));
      
            FrameworkElementFactory textBlockFactory = new FrameworkElementFactory(typeof(TextBlock));
            textBlockFactory.SetBinding(TextBlock.TextProperty, new Binding("Name"));
            stackPanelFactory.AppendChild(textBlockFactory);
              

            dataTemplate.VisualTree = stackPanelFactory;


            foreach (ListView item in list)
            {
                item.ItemTemplate = dataTemplate;

                if (Count < 3)
                {
                    
                    DatasOne.Children.Add(item);
                    Count++;
                }
                else
                {
                    DatasTwo.Children.Add(item);
                }
            }


        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisitorMenu());
        }
    }
}
