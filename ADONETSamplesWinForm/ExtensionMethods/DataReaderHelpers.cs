using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETSamplesWinForm.ExtensionMethods
{
    public static class DataReaderHelpers
    {
        public static T GetFieldValue <T> (this SqlDataReader sqlDataReader, string name)
        {
            T ret = default;

            if(!sqlDataReader[name].Equals(DBNull.Value))
            {
                ret = (T)sqlDataReader[name];
            }

            return ret;
        }
    }
}
