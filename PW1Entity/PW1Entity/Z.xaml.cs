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

namespace PW1Entity
{
    /// <summary>
    /// Логика взаимодействия для Z.xaml
    /// </summary>
    public partial class Z : Page
    {
        private PractikaPW1Entities context = new PractikaPW1Entities();
        public Z()
        {
            InitializeComponent();
            dg.ItemsSource = context.Zhanres.ToList();
        }
    }
}
