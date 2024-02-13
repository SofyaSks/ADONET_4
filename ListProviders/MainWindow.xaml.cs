using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

namespace ListProviders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // возвращает DataTable
            DataContext = DbProviderFactories.GetFactoryClasses().DefaultView;

            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            IDbConnection connection = factory.CreateConnection();
            connection.ConnectionString = "Data Source=(localdb)\\.;Initial Catalog=music2;Integrated Security=True";
            connection.Open();

            IDbCommand command = factory.CreateCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            IDataReader reader = command.ExecuteReader();

            while (reader.Read()){

            }
        }
    }
}
