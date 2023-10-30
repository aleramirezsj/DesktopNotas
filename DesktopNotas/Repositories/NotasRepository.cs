using DesktopNotas.Models;
using Newtonsoft.Json;
using System.Text;

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
        //traemos una nota a partir de su id
        public async Task<Nota> GetById(int id)
        {
            var response=await client.GetStringAsync($"{Url}/{id}");
            return JsonConvert.DeserializeObject<Nota>(response);
        }

        //traemos notas a partir de un filtro

        //guardamos una nota nueva
        public async Task<bool> AddAsync(Nota nota)
        {
            var response = await client.PostAsync(Url,
                new StringContent(JsonConvert.SerializeObject(nota), Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }

        //modificamos una nota existente
        public async Task<bool> UpdateAsync(Nota nota)
        {
            var response = await client.PutAsync($"{Url}/{nota.Id}",
                new StringContent(JsonConvert.SerializeObject(nota),Encoding.UTF8,"application/json"));
            return response.IsSuccessStatusCode;
        }

        //eliminamos una nota
        public async Task<bool> RemoveAsync(int id)
        {
            var response=await client.DeleteAsync($"{Url}/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}
