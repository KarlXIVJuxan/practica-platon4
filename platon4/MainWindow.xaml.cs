using System;
using System.Collections.Generic;
using System.Data;
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
using platon4.lab3DataSetTableAdapters;

namespace platon4
{
    public partial class MainWindow : Window
    {
        ColorTableAdapter color = new ColorTableAdapter();
        HumanTableAdapter human = new HumanTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ColourDgr.ItemsSource = color.GetData();
            HumanDgr.ItemsSource = human.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object id = (ColourDgr.SelectedItem as DataRowView).Row[0];
            color.UpdateQuery(ColorTextBox.Text, Convert.ToInt32(id));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (HumanDgr.SelectedItem as DataRowView).Row[0];
            human.UpdateQuery(HumanTextBox.Text, Convert.ToInt32(id));
        }
    }
}
