using System;

namespace Hotel
{
    internal class SqlConnection
    {
        public string ConnectionString { get; internal set; }

        public static implicit operator System.Data.SqlClient.SqlConnection(SqlConnection v)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}