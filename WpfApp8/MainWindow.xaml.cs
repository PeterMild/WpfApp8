using System;
using System.Collections;
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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;

        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();

        }

    
               private void addButton_Click(object sender, RoutedEventArgs e)
        {
          string addText = (txtBox.Text);
            arrayList.Add(addText);
            arrayList.Sort();
            MessageBox.Show("เพิ่ม " + addText + " เรียบร้อยแล้ว");
            
            
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            string removeText = (txtBox.Text);
            arrayList.Remove(removeText);
            MessageBox.Show("ลบ " + removeText + " เรียบร้อยแล้ว");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                           
            foreach(string data in arrayList)
            {
                arrayList.Sort();
                MessageBox.Show(data.ToString());
                
            }
        }
    }
}
