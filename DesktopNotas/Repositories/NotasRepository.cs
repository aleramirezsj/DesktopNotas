using DesktopNotas.Models;
using Newtonsoft.Json;

namespace DesktopNotas.Repositories
{
    public class NotasRepository
    {
        const string Url = "https://webnotasale.azurewebsites.net/api/apinotas";
        HttpClient client= new HttpClient();

        public NotasRepository()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        //traemos las notas
        public async Task<IEnumerable<Nota>> GetAllAsync()
        {
            var response= await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Nota>>(response);
        }

        //traemos notas a partir de un filtro

        //guardamos una nota nueva

        //modificamos una nota existente

        //eliminamos una nota

    }
}
