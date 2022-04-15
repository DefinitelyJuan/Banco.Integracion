using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Integracion.CoreAplicacion;


namespace Integracion
{
    /// <summary>
    /// Descripción breve de IntegracionASMX
    /// </summary>
    [WebService(Namespace = "http://integracion.somee.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class IntegracionASMX : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld(string usuario, string contraseña, int pin)
        {            
            return ($"Hello {usuario}, {contraseña},{pin}");
        }


        [WebMethod]
        public DataSet Autenticacion(string usuario, string contraseña, int pin)
        {
            CoreSoapClient core = new CoreSoapClient();
            DataSet auth = core.Autenticacion(usuario, contraseña, pin);
            return auth;
        }

        [WebMethod]
        public DataSet Transaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto)
        {
            CoreSoapClient core = new CoreSoapClient();
            DataSet dataset = core.Transaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
            return dataset;
        }

        [WebMethod]
        public DataSet ObtenerTodasCuentasDiferentes(int ID_Cliente)
        {
            CoreSoapClient core = new CoreSoapClient();
            DataSet dataset = core.ObtenerTodasCuentasDiferentes(ID_Cliente);
            return dataset;
        }

        [WebMethod]
        public DataSet TransaccionATercero(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto)
        {
            CoreSoapClient core = new CoreSoapClient();
            DataSet dataset = core.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto);
            return dataset;
        }
    }
}
