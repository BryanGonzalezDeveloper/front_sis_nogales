using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSIS
{
    public class ObjSIS
    {
        public class Articulo
        {
            public int intID;
            public string Descripcion;
            public decimal precioUnitario;
            public int stockActual;
            public int IdProveedor;
            public int stockMinimo;

            public string InsertarCita(string strconexion)
            {
                string striSQL = $"INSERT INTO [dbo].[Articulo] ([Descripcion],[precioUnitario],[stockActual] ,[IdProveedor] ,[stockMinimo] ) VALUES (" +
                    $",'{Descripcion}', {precioUnitario}, {stockActual},{IdProveedor},{stockMinimo})";
                string strError = "";
                int intRegistrosAfectados;
                intRegistrosAfectados = cslUtileriasBD.clsSQLServer.exeQuery(strconexion, striSQL, ref strError);
               
                if (strError == "")
                {
                    return "";
                }
                else
                {
                    return strError;
                }
            }
        }
        public class Proveedor
        {
            public string razonSocial;
            public string Telefono;
            public string email;
            public string sitioWeb;

            public string InsertarCita(string strconexion)
            {
                string striSQL = $"INSERT INTO [dbo].[Proveedor]([razonSocial],[Telefono],[email],[sitioWeb])" +
                    $"VALUES( '{razonSocial}', '{Telefono}', '{email}', '{sitioWeb}')";
                string strError = "";
                int intRegistrosAfectados;
                intRegistrosAfectados = cslUtileriasBD.clsSQLServer.exeQuery(strconexion, striSQL, ref strError);

                if (strError == "")
                {
                    return "";
                }
                else
                {
                    return strError;
                }
            }
        }
    }
}
