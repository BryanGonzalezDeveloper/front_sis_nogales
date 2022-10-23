namespace ObjSIS
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
                string striSQL = $"INSERT INTO [dbo].[TbCita]([Articulo],[ID],[Descripcion],[precioUnitario],[stockActual] ,[IdProveedor] ,[stockMinimo] )VALUES ({intID}" +
                    $",'{Descripcion}', { precioUnitario}, { stockActual},'{IdProveedor}','{stockMinimo}')";
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