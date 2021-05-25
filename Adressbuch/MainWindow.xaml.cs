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
using System.Xml.Linq;
using System.IO;

namespace Adressbuch
{
    public partial class MainWindow : Window
    {
        private List<User> userlist = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            ReadXML();
        }

        public void WriteXML()
        {
            var temp = userlist;
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(List<User>));

            var path = Directory.GetCurrentDirectory() + "\\Adressen.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, temp);
            file.Close();
        }

        public void ReadXML()
        {
            var path = Directory.GetCurrentDirectory() + "\\Adressen.xml";

            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(List<User>));
            if (File.Exists(path))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                userlist = (List<User>)reader.Deserialize(file);
                file.Close();

                updateTable();
            }
            else
            {
                WriteXML();
            }
        }

        public void updateTable()
        {
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = userlist;
        }

        private void clearBoxes()
        {
            textName.Text = "";
            textMail.Text = "";
            textTel.Text = "";
            textAnsch.Text = "";
        }

        private void Buttonadd_Click(object sender, RoutedEventArgs e)
        {
            if (textName.Text != "")
            {
                userlist.Add(new User { name = textName.Text, email = textMail.Text, tel = textTel.Text, anschrift = textAnsch.Text });

                updateTable();
                clearBoxes();
                WriteXML();
            }
        }

        private void Buttondel_Click(object sender, RoutedEventArgs e)
        {
            var currentRowIndex = dataGrid.SelectedIndex;

            if (currentRowIndex >= 0)
            {
                userlist.RemoveAt(currentRowIndex);
                editimage.Opacity = 0;
                updateTable();
                clearBoxes();
                WriteXML();
            }
        }

        private void textSuche_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textSuche.Text != "")
            {
                var query =
                    from c in userlist
                    where c.name.Contains(textSuche.Text) ||
                    c.anschrift.Contains(textSuche.Text) ||
                    c.email.Contains(textSuche.Text) ||
                    c.tel.Contains(textSuche.Text)
                    select c;

                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = query;
            }
            else
            {
                updateTable();
            }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedIndex >= 0)
            {
                object item = dataGrid.SelectedItem;
                textName.Text = (dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                textMail.Text = (dataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                textTel.Text = (dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                textAnsch.Text = (dataGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
            }
        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {
            object item = dataGrid.SelectedItem;
            int itemindex = dataGrid.SelectedIndex;
            if (itemindex >= 0)
            {
                if (textName.Text != userlist[itemindex].name) { editimage.Opacity = 100; }
                if (textMail.Text != userlist[itemindex].email) { editimage.Opacity = 100; }
                if (textTel.Text != userlist[itemindex].tel) { editimage.Opacity = 100; }
                if (textAnsch.Text != userlist[itemindex].anschrift) { editimage.Opacity = 100; }
            }
        }

        private void Buttonedit_Click(object sender, RoutedEventArgs e)
        {
            int itemindex = dataGrid.SelectedIndex;
            if (dataGrid.SelectedIndex >= 0)
            {
                userlist[itemindex].name = textName.Text;
                userlist[itemindex].email = textMail.Text;
                userlist[itemindex].tel = textTel.Text;
                userlist[itemindex].anschrift = textAnsch.Text;
                editimage.Opacity = 0;
                updateTable();
                clearBoxes();
                WriteXML();
            }
        }
    }
}