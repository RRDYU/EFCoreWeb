namespace EFCore.WebAPI.Models
{
    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Heroi HeroiId { get; set; }
    }
}
