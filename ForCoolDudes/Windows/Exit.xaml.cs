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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ForCoolDudes.Windows
{
    /// <summary>
    /// Логика взаимодействия для Exit.xaml
    /// </summary>
    public partial class Exit : Window
    {
        public Exit()
        {
            InitializeComponent();
            btn_exit_yes.MouseMove += btn_exit_yes_MouseMove;
        }

        private void btn_exit_yes_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btn_exit_no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_exit_yes_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int newLeft = rnd.Next(Convert.ToInt32(cnv.ActualWidth - btn_exit_yes.ActualWidth));
            int newTop = rnd.Next(Convert.ToInt32(cnv.ActualHeight - btn_exit_yes.ActualHeight));
            btn_exit_yes.Margin = new Thickness(rnd.Next(newLeft), rnd.Next(newTop), 0, 0);
        }
    }
}
