namespace EFCore.WebAPI.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Batalha BatalhaId{ get; set; }
    }
}
