using DesktopNotas.Models;
using DesktopNotas.Repositories;
using DesktopNotas.Utils;

namespace DesktopNotas
{
    public partial class FrmNotas : Form
    {
        //probamos la webcam
        WebCam webcam;

        private NotasRepository repository = new NotasRepository();
        Nota NotaEditada { get; set; }
        public FrmNotas()
        {
            InitializeComponent();
            ObtenerNotas();
            webcam = new WebCam(this, AutoActivate: false, pictureBoxFoto);
        }

        private async void ObtenerNotas()
        {
            dataGridNotas.DataSource = await repository.GetAllAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            await RecuperarDatosNotaSeleccionada();
            tabControlNotas.SelectTab(tabPageDetalle);

        }

        private async Task RecuperarDatosNotaSeleccionada()
        {
            int idNotaSeleccionada = (int)dataGridNotas.CurrentRow.Cells[0].Value;
            NotaEditada = await repository.GetById(idNotaSeleccionada);
            txtTitulo.Text = NotaEditada.Titulo;
            txtContenido.Text = NotaEditada.Contenido;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //permite filtrar las notas a partir de un texto, buscando en su título y su contenido
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //limpia los controles de la tabpageDetalle 
            txtTitulo.Text = "";
            txtContenido.Text = "";
            //cambia a la tabpageDetalle, 
            tabControlNotas.SelectTab(tabPageDetalle);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el titulo y id de la nota
            int idNotaSeleccionada = (int)dataGridNotas.CurrentRow.Cells[0].Value;
            string tituloNotaSeleccionada = (string)dataGridNotas.CurrentRow.Cells[1].Value;

            //pregunta si estamos seguros que deseamos eliminar
            var respuesta = MessageBox.Show($"¿Está seguro que desea eliminar a la nota: {tituloNotaSeleccionada}", "Eliminar Nota", MessageBoxButtons.YesNo);
            //si confirma el usuario, elimina la nota
            if (respuesta == DialogResult.Yes)
            {
                var eliminado = await repository.RemoveAsync(idNotaSeleccionada);
                if (eliminado)
                    MessageBox.Show($"La nota {tituloNotaSeleccionada} se eliminó correctamente", "Eliminar nota", MessageBoxButtons.OK);
                ObtenerNotas();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (NotaEditada != null)
            {
                NotaEditada.Titulo = txtTitulo.Text;
                NotaEditada.Contenido = txtContenido.Text;
                var modificacionAlmacenada = await repository.UpdateAsync(NotaEditada);
                if (modificacionAlmacenada)
                {
                    MessageBox.Show($"La nota {NotaEditada.Titulo} fue guardada correctamente", "Editar nota", MessageBoxButtons.OK);
                    ObtenerNotas();
                    tabControlNotas.SelectTab(tabPageLista);
                    NotaEditada = null;
                }
            }
            else //agregamo una nota nueva
            {
                var nota = new Nota()
                {
                    Contenido = txtContenido.Text,
                    Titulo = txtTitulo.Text
                };
                var nuevaNotaAlmacenada = await repository.AddAsync(nota);
                if (nuevaNotaAlmacenada)
                {
                    MessageBox.Show($"La nota {nota.Titulo} fue guardada correctamente", "Nueva nota", MessageBoxButtons.OK);
                    ObtenerNotas();
                    tabControlNotas.SelectTab(tabPageLista);
                }
            }
        }

        private void btnIniciarCámara_Click(object sender, EventArgs e)
        {
            webcam.Initalize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webcam.Deinitalize();
        }
    }
}