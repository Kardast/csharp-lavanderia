// See https://aka.ms/new-console-template for more information
public abstract class Macchina
{
    //costruttore
    public Macchina (string nome)
    {
        Nome = nome;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
        Incasso = 0;
    }

    //props
    public string Nome { get; set; }
    public bool InFunzione { get; set; }
    public float Incasso { get; set; }
    public string ProgrammaInCorso { get; set; }
    public int DurataProgrammaInCorso { get; set; }
    public int TempoRimanente { get; set; }
}
