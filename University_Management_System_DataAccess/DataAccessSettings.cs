using System;
using System.Configuration;

namespace University_Management_System_DataAccess
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager
            .ConnectionStrings["University_Managment_System_Connection"].ConnectionString;
    }
}
