using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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

namespace WForm001
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            Console.WriteLine("Привет Мир!");
            string strConnectionString = makeCoonectionString2SQL();
            //connToDBEntity(strConnectionString);
            InitializeComponent();
        }

        private static string makeCoonectionString2SQL()
        {

            //string strExePath = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            System.Data.Common.DbConnectionStringBuilder dbConnectionStringBuilder = new SqlConnectionStringBuilder();


            //dbConnectionStringBuilder["ClientLibrary"] = @"C:\Program Files\Firebird\Firebird_2_5\bin\fbclient.dll";

            dbConnectionStringBuilder["Data Source"] = "localhost";
            //dbConnectionStringBuilder["Initial Catalog"] = @"C:\SSG\PROJECTs\TELET\DB4TELEFONE\sampd_cexs.fdb";//"sampd_cexs";
            //dbConnectionStringBuilder["Database"] = Path.Combine(strExePath, "tmp.fdb");
            dbConnectionStringBuilder["Database"] = "sampd_cexs";

            //dbConnectionStringBuilder["User ID"] = "sysdba";
            //dbConnectionStringBuilder["Password"] = "masterkey";

            //dbConnectionStringBuilder["Charset"] = "UTF8";


            //dbConnectionStringBuilder["Embedded"] = FbServerType.Embedded;
            dbConnectionStringBuilder["integrated Security"] = "SSPI";

            return dbConnectionStringBuilder.ConnectionString;

        }


        private static DbContext connToDBEntity(string sConnectionString)
        {
            try
            {
                using (var dbContent = new DbAppContext(sConnectionString))
                {



                    /*var simpleQueryOfVidConnects = dbContent.pO_TEL_VID_CONNECTs.Where(s => s.Id > 0);


                    Console.WriteLine("=================================================");
                    foreach (var oneElement in simpleQueryOfVidConnects)
                    {
                        Console.WriteLine(" Id = {0}  Kod связи {1}  Название вида связи {2}", oneElement.Id, oneElement.KodOfConnect, oneElement.Name);
                    }
                    Console.WriteLine("=================================================");*/




                    var simpleVidConnects = dbContent.pO_TEL_VID_CONNECTs;


                    foreach (var oneTEL_VID_CONNECT in simpleVidConnects)
                    {
                        Console.WriteLine(" Id = {0}  Kod связи {1}  Название вида связи {2}", oneTEL_VID_CONNECT.Id, oneTEL_VID_CONNECT.KodOfConnect, oneTEL_VID_CONNECT.Name);

                    }



                    return dbContent;
                }

            }
            catch (Exception ex)
            {

            }
            return null;
        }



    }
}
