using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class DalConexion
    {
        public static String getConexion()
        {
            //String CadenaDeConexion = @"Data Source=142.4.196.46;Initial Catalog=BD_proyint02_MiCherry;uid=proyint02_micherry;pwd=pa$$w0rd";
            //String CadenaDeConexion = @"Data Source=JCRK27\SQLEXPRESS;Initial Catalog=asistentevirtual;uid=sa;pwd=123456";
            String CadenaDeConexion = @"Data Source=104.210.158.108;Initial Catalog=asistentevirtual;uid=sa;pwd=123456";
            return CadenaDeConexion;
        }
    }
}
