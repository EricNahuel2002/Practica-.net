using Clase2._2c2025.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase2._2c2025;


namespace Clase_2_practica
{
    public partial class frmAgregarTipoLocal : Form
    {
        public frmAgregarTipoLocal()
        {
            InitializeComponent();
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarNuevoTipo_Click(object sender, EventArgs e)
        {
            TipoLocal tipo = new TipoLocal(tbNuevoTipoLocal.Text);
            EnviarTipoLocalAApi(tipo);
        }

        

        private async Task EnviarTipoLocalAApi(TipoLocal local)
        {
            //SERIALIZAR EL OBJETO RESEÑA A JSON
            var localSerializado = System.Text.Json.JsonSerializer.Serialize(local);
            //GENERAR CUERPO DE LA SOLICITUD
            var data = new StringContent(localSerializado, System.Text.Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync("https://localhost:7139/api/Reseñas/TiposLocales", data);
            }
        }

        
    }
}
