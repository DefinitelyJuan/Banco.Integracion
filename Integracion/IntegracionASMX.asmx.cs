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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        public DataSet Autenticacion(string usuario, string contraseña, int pin, string clave)
        {
            DataSet empty = null;
            if (clave == "Droog ethereal develop 269138")
            {
                log.Info($"Iniciando solicitud de autenticacion para el usuario {usuario}");
                CoreSoapClient core = new CoreSoapClient();
                DataSet auth = core.Autenticacion(usuario, contraseña, pin, clave);
                log.Info("Proceso completado, enviando dataset de respuesta...");
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
                log.Info($"Iniciando solicitud de transaccion para la cuenta {NoCuenta} con monto {Monto}");
                CoreSoapClient core = new CoreSoapClient();
                DataSet dataset = core.Transaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto, clave);
                log.Info($"Proceso completado, enviando dataset de respuesta...");
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
                log.Info($"Iniciando solicitud de obtener todas las cuentas que no pertenecen al cliente de id {ID_Cliente}");
                CoreSoapClient core = new CoreSoapClient();
                DataSet dataset = core.ObtenerTodasCuentasDiferentes(ID_Cliente, clave);
                log.Info($"Proceso completado, enviando dataset de respuesta...");
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
                log.Info($"Iniciando transaccion a tercero: origen {NoCuenta}, destinatario {Entidad} y monto {Monto}");
                CoreSoapClient core = new CoreSoapClient();
                DataSet dataset = core.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto, clave);
                log.Info($"Proceso completado, enviando dataset de respuesta...");
                return dataset;
            }
            else
            {
                return empty;
            }
        }

        [WebMethod]
        public bool InsertarBeneficiario(int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente, string clave)
        {
            bool response = false;
            if (clave == "Droog ethereal develop 269138")
            {
                try
                {
                    log.Info($"Iniciando solicitud para insertar el beneficiario de nombre {Nombre} para la cuenta {NoCuenta}");
                    CoreSoapClient core = new CoreSoapClient();
                    core.InsertarBeneficiario(NoCuenta, ID_TipoBeneficiario, Nombre, ID_Cliente, clave);
                    log.Info($"Proceso completado, enviando dataset de respuesta...");
                    return response;
                }
                catch (Exception err)
                {
                    log.Error(err.Message);
                    return response;
                }

            }
            else
            {
                return response;
            }
        }
    }
}
