using System.IO;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace WpfAppTest.View
{
    /// <summary>
    /// Interaction logic for ComboBox.xaml
    /// </summary>
    public partial class ComboBox : UserControl
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CityName.SelectedValue != null && DepName.SelectedValue != null && Name.SelectedValue != null && TeamName.SelectedValue != null && ShiftName.SelectedValue != null)
            {
                    Form form = new Form();
                    form.CityName = CityName.Text;
                    form.DepName = DepName.Text;
                    form.Name = Name.Text;
                    form.TeamName = TeamName.Text;
                    form.ShiftName = ShiftName.Text;
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(form, Formatting.Indented);
                    SaveJsonToDisk(json);
                    MessageBoxResult result = MessageBox.Show("Успешный успех", "Success");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Выберите все поля", "Ошибка!");
            }
        }
        public bool SaveJsonToDisk(string json)
        {
            string path = @"D:\WpfAppTest\WpfAppTest\data.json";
            if (File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            System.IO.File.WriteAllText(path, json);

            return (true);
        }

        public class Form
        {
            public string CityName { get; set; }
            public string DepName { get; set; }
            public string Name { get; set; }
            public string TeamName { get; set; }
            public string ShiftName { get; set; }
        }
    }
}
