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

namespace final
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        damage_System system = new damage_System();

        private void tag_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void body_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AKMbutton_Click(object sender, RoutedEventArgs e)
        {
            system.damage = 49;
            system.Update();
            Change();
        }

        private void M16A4button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void M416button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void h1_Click(object sender, RoutedEventArgs e)
        {
            system.head_Reduce = 75;
            system.Update();
            Change();
        }

        void Change()
        {
            head.TB.Text = system.head_Damage.ToString();
            shoulder.TB.Text = system.body_Damage.ToString();
            hand.TB.Text = system.hand_Damage.ToString();
            body.TB.Text = system.body_Damage.ToString();
            dick.DICK.Text = system.dick_Damage.ToString();
        }

        private void a1_Click(object sender, RoutedEventArgs e)
        {
            system.reduce = 30;
            system.Update();
            Change();
        }
    }

    public class damage_System
    {
        public float damage = 0;
        public float reduce = 0;
        public float head_Reduce = 0;

        public float head_Damage = 0;
        public float body_Damage = 0;
        public float hand_Damage = 0;
        public float dick_Damage = 0;

        public void Update()
        {
            head_Damage = damage * (250 - head_Reduce) / 100;
            body_Damage = damage * (100 - reduce) / 100;
            hand_Damage = damage * (100 - reduce) / 100 * 0.75f;
            if(damage > 0)
            {
                dick_Damage = 9999;
            }
        }
    }
}
