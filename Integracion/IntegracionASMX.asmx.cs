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
        public DataSet Autenticacion(string usuario, string contraseña, int pin, string clave)
        {
            DataSet empty = null;
            if (clave == "Droog ethereal develop 269138")
            {
                CoreSoapClient core = new CoreSoapClient();
                DataSet auth = core.Autenticacion(usuario, contraseña, pin, clave);
                return auth;
            }
            else
            {
                return empty;
            }
        }

        [WebMethod]
        public DataSet Transaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto, string clave)
        {
            DataSet empty = null;
            if (clave == "Droog ethereal develop 269138")
            {
                CoreSoapClient core = new CoreSoapClient();
                DataSet dataset = core.Transaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto, clave);
                return dataset;
            }
            else
            {
                return empty;
            }

        }

        [WebMethod]
        public DataSet ObtenerTodasCuentasDiferentes(int ID_Cliente, string clave)
        {
            DataSet empty = null;
            if (clave == "Droog ethereal develop 269138")
            {
                CoreSoapClient core = new CoreSoapClient();
                DataSet dataset = core.ObtenerTodasCuentasDiferentes(ID_Cliente, clave);
                return dataset;
            }
            else
            {
                return empty;
            }
        }

        [WebMethod]
        public DataSet TransaccionATercero(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto, string clave)
        {
            DataSet empty = null;
            if (clave == "Droog ethereal develop 269138")
            {
                CoreSoapClient core = new CoreSoapClient();
                DataSet dataset = core.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto, clave);
                return dataset;
            }
            else
            {
                return empty;
            }
        }

        [WebMethod]
        public bool InsertarBeneficiario(int ID_Beneficiario, int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente, string clave)
        {
            bool response = false;
            if (clave == "Droog ethereal develop 269138")
            {
                CoreSoapClient core = new CoreSoapClient();
                core.InsertarBeneficiario(ID_Beneficiario, NoCuenta, ID_TipoBeneficiario, Nombre, ID_Cliente, clave);
                return response;
            }
            else
            {
                return response;
            }
        }
    }
}
