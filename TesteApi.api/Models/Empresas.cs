namespace TesteApi.api.Models
{
    public class Empresas
    {
        public string Id { get; set; }
        public Empresas(string nome)
        {
            this.Id = nome;
        }
    }
}
