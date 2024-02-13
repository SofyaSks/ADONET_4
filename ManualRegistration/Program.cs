using System.Data;
using System.Data.Common;
using System.Data.SqlClient;



DbProviderFactories.RegisterFactory(
                "System.Data.SqlClient", SqlClientFactory.Instance);

Console.WriteLine("Providers:");
foreach (string invarantName in DbProviderFactories.GetProviderInvariantNames())
    Console.WriteLine(invarantName);

Console.Write("Choose a provider: ");
string name = Console.ReadLine()!;

DbProviderFactory factory = DbProviderFactories.GetFactory(name);

// просим фабрику изготовить все нужные детали
IDbConnection connection = factory.CreateConnection()
    ?? throw new NullReferenceException();
connection.ConnectionString
    = @"Data Source=(localdb)\.;Initial Catalog=music2;Integrated Security=True";
connection.Open();

IDbCommand command = factory.CreateCommand()
    ?? throw new NullReferenceException();

command.Connection = connection;
command.CommandText = "select * from songs";

IDataReader reader = command.ExecuteReader();
while (reader.Read())
{
    string title = reader.GetString(1);
    Console.WriteLine(title);
}
