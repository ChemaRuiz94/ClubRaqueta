using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRaqueta
{
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            btn_insertar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities()) 
            {
                var consulta = from soc in objBD.socios
                               select new 
                               {
                                   DNI = soc.DNI,
                                   NOMBRE = soc.nombre,
                                   APELLIDOS = soc.apellidos,
                                   DOMICILIO = soc.domicilio,
                                   TELEFONO = soc.telefono,
                                   EMAIL = soc.email,
                                   CCC = soc.cuentaCorriente
                               };
                dgv_socios.DataSource = consulta.ToList();
            }
        }
    }
}
