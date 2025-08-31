using Clase2._2c2025.Entidad;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Clase_2_practica
{
    public partial class frmReseña : Form
    {
        public frmReseña()
        {
            InitializeComponent();
            cargarPuntuacion();
        }

        private void cargarPuntuacion()
        {
            cmbPuntuacion.Items.Clear();
            cmbPuntuacion.Items.Add("1");
            cmbPuntuacion.Items.Add("2");
            cmbPuntuacion.Items.Add("3");
            cmbPuntuacion.Items.Add("4");
            cmbPuntuacion.Items.Add("5");
            cmbPuntuacion.Items.Add("6");
            cmbPuntuacion.Items.Add("7");
            cmbPuntuacion.Items.Add("8");
            cmbPuntuacion.Items.Add("9");
            cmbPuntuacion.Items.Add("10");
            cmbPuntuacion.SelectedIndex = 0;
        }

        private void btnGuardarReseña_Click(object sender, EventArgs e)
        {
            Reseña reseña = new Reseña(dtpFecha.Value.ToString("dd/MM/yyyy"), tbDireccion.Text, cmbTipoLocal.SelectedItem.ToString(), cmbPuntuacion.SelectedItem.ToString());
            //cargarGrillaReseña(reseña);
            EnviarReseñaAApi(reseña);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ObtenerReseñasDeApi();
        }

        private void cargarGrillaReseña(Reseña reseña)
        {
            dgvReseñas.Rows.Add(reseña.Fecha, reseña.Direccion, reseña.TipoLocal, reseña.Puntuacion);
        }

        private async Task EnviarReseñaAApi(Reseña reseña)
        {
            //SERIALIZAR EL OBJETO RESEÑA A JSON
            var reseñaSerializada = System.Text.Json.JsonSerializer.Serialize(reseña);
            //GENERAR CUERPO DE LA SOLICITUD
            var data = new StringContent(reseñaSerializada, System.Text.Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync("https://localhost:7139/api/Reseñas", data);
            }
        }

        private async Task ObtenerReseñasDeApi()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7139/api/Reseñas");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    var reseñas = System.Text.Json.JsonSerializer.Deserialize<List<Reseña>>(jsonResponse, options);
                    foreach (var reseña in reseñas)
                    {
                        cargarGrillaReseña(reseña);
                    }
                }
            }
        }
        private async Task ObtenerTiposDeLocalesDeApi()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7139/api/Reseñas/TiposLocales");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    var locales = System.Text.Json.JsonSerializer.Deserialize<List<TipoLocal>>(jsonResponse, options);
                    foreach (var local in locales)
                    {
                        CargarTiposDeLocales(local);
                    }
                }
            }
        }

        private void CargarTiposDeLocales(TipoLocal tipoLocal)
        {
            cmbTipoLocal.Items.Add(tipoLocal);
        }

        private void btnAgregarTipoLocal_Click(object sender, EventArgs e)
        {
            frmAgregarTipoLocal frmAgregarTipoLocal = new frmAgregarTipoLocal();
            frmAgregarTipoLocal.Show();
        }

        private void btnRefrescarTiposDeLocales_Click(object sender, EventArgs e)
        {
            ObtenerTiposDeLocalesDeApi();
        }
    }
}
