using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitaMedica.Data
{
    public class DBConnection
    {
        private static MySqlConnection ObjSqlConnection;

        private DBConnection() { }

        public static MySqlConnection StringConnectionDB()
        {
            if (ObjSqlConnection == null)
            {
                try
                {
                    string stringConnection =
                                        ConfigurationManager
                                        .ConnectionStrings["DBConnection"]
                                        .ConnectionString;

                    ObjSqlConnection = new MySqlConnection(stringConnection);

                    System.Diagnostics.Debug.WriteLine(
                        "Conexión a la base de datos realizada con exito."
                    );
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(
                        "No fue posible conectarse con la base de datos\nExcepción: " + e
                    );
                }
            }

            return ObjSqlConnection;
        }

    }
}
