using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteASPNet
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            //Llamar al servicio
            wsReniec.wsReniecSoapClient servicio = new wsReniec.wsReniecSoapClient();
            //Caputar  elk  DNI
            string dni = txtDNI.Text.Trim();
            //Consultar servicio 
            gvDatosDNI.DataSource = servicio.BuscarDNI(dni);
            gvDatosDNI.DataBind();
        }
    }
}