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
using System.Windows.Shapes;

namespace TaskCorses1.AppWindows
{
    /// <summary>
    /// Логика взаимодействия для ApplicationDescriptionWindow.xaml
    /// </summary>
    public partial class ApplicationDescriptionWindow : Window
    {
        Models.Application postApp;
        public ApplicationDescriptionWindow(Models.Application application)
        {
            InitializeComponent();
            postApp = application;
            this.DataContext = postApp;
        }

       
    }
}
