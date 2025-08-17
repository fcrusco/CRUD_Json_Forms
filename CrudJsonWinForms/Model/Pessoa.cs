namespace CrudJsonWinForms.Model
{
    public class Pessoa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        // Sobrescrever ToString()
        public override string ToString()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
