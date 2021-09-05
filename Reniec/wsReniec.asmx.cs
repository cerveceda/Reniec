using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Reniec
{
    /// <summary>
    /// Descripción breve de wsReniec
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsReniec : System.Web.Services.WebService
    {
        //Acceder a la Cadena de Conexion
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod(Description ="Consultar con el DNI del usuario")]
        public DataSet BuscarDNI(string dni)
        {
            //llamar al procedimiento almacenado
            SqlCommand comando = new SqlCommand("spBuscarDNI", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            // Enviar el DNI al PA
            comando.Parameters.AddWithValue("@DNI",dni);
            // Traer lo datos del  PA
            SqlDataAdapter adpter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            //Colcado de datos del gestor sql al web service
            adpter.Fill(data);
            //Devolver valores al Web services
            return data;

        }
    }
}
