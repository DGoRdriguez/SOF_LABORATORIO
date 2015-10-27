using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ws_Sof_Laboratorio
{
    /// <summary>
    /// Servicio de Validación y envío de datos desde el servicio de windows.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class ws_Sof_Laboratorio : System.Web.Services.WebService
    {

        [WebMethod]
        public string mtdEnvioDatos()
        {
            return "Hello World";
        }
    }
}
