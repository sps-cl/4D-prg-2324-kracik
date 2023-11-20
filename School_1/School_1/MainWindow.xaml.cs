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
using School_1.Model;

namespace School_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<UserChild> _User = new List<UserChild>();
        public MainWindow()
        {
            InitializeComponent();

            //User user = new User();
            //user.DoSomething();

            //_User.Add(new User() { Id = Guid.NewGuid(), Email = "Test@email.cz" , Name = "Vašek" });
            //_User.Add(new User() { Id = Guid.NewGuid(), Email = "Test1@email.cz", Name = "Marek" });
            //_User.Add(new User() { Id = Guid.NewGuid(), Email = "Test2@email.cz", Name = "Jiří" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _User.Add(new UserChild() { Id = Guid.NewGuid(), Email = EmailBox.Text, Name = NameBox.Text, Popis = PopisBox.Text});
            Refresh();
        }

        public void Refresh()
        {
            try
            {

                MyTree.Items.Clear();

                foreach (var item in _User)
                {
                    TreeViewItem treeitem = new TreeViewItem();

                    treeitem.Header = item.Name;

                    StackPanel stack = new StackPanel();
                    stack.Orientation = Orientation.Horizontal;

                    Label label0 = new Label();
                    label0.Content = item.Email;
                    stack.Children.Add(label0);

                    Label label1 = new Label();
                    label1.Content = item.Id.ToString();
                    stack.Children.Add(label1);

                    Label label2 = new Label();
                    label2.Content = item.Popis;
                    stack.Children.Add(label2);

                    treeitem.Items.Add(stack);

                    MyTree.Items.Add(treeitem);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
