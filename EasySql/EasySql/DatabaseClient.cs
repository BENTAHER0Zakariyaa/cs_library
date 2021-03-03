using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EasySql
{
    public class DatabaseClient : Sql
    {
        public DatabaseClient() : base()
        { }
        public DatabaseClient(string stringConnection) : base(stringConnection)
        { }

        //Open
        public void Open()
        {
            if (this.Connection.State.Equals(ConnectionState.Open))
            {
                this.Close();
                this.Connection.Open();
            }
            else
                this.Connection.Open();
        }

        //Close
        public void Close()
        {
            this.Connection.Close();
        }
        private void ExecuteReader(string stringConnection)
        {
            this.setCommand(stringConnection);
            this.Reader = this.Command.ExecuteReader();
        }

        private void ExecuteNonQuery(string stringConnection)
        {
            this.setCommand(stringConnection);
            this.Command.ExecuteNonQuery();
        }

        private Object ExecuteScalar(string stringConnection)
        {
            this.setCommand(stringConnection);
            return this.Command.ExecuteScalar();
        }
    }
}
