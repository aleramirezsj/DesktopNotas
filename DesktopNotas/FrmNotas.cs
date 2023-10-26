using DesktopNotas.Repositories;

namespace DesktopNotas
{
    public partial class FrmNotas : Form
    {
        private NotasRepository repository=new NotasRepository();
        public FrmNotas()
        {
            InitializeComponent();
            ObtenerNotas();
        }

        private async void ObtenerNotas()
        {
            dataGridNotas.DataSource=await repository.GetAllAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tabControlNotas.SelectTab(tabPageDetalle);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //permite filtrar las notas a partir de un texto, buscando en su título y su contenido
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //limpia los controles de la tabpageDetalle 
            //cambia a la tabpageDetalle, 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //pregunta si estamos seguros que deseamos eliminar
            //si confirma el usuario, elimina la nota
        }
    }
}