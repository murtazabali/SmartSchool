using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace SmartSchool
{
    class DB
    {

        private static string _connStr;
        private static DB _dbConnection;
        public static DB GetInstance()
        {
            if (_dbConnection == null)
            {
                _dbConnection = new DB();
            }
            return _dbConnection;
        }

        public string connStr
        {
            get
            {
                _connStr = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
                return _connStr;
            }


        }
    }
}
