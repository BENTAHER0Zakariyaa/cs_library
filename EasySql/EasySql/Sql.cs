using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EasySql
{
    public class Sql
    {
        private SqlConnection connection;
        private SqlCommand command;

        //Data OutPut
        private DataTable table;
        private SqlDataReader reader;


        internal Sql()
        {
            this.connection = new SqlConnection();
        }

        internal Sql(string stringConnection)
        {
            this.connection = new SqlConnection(stringConnection);
        }

        public SqlConnection Connection { get => this.connection; }
        public SqlCommand Command { get => this.command; }

        public DataTable Table { get => table; set => table = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }

        public void setCommand(string stringQuery)
        {
            this.command = new SqlCommand(stringQuery, this.connection);
        }
        

    }
}
