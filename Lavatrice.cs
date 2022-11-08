// See https://aka.ms/new-console-template for more information
public class Lavatrice : Macchina
{
    //costruttore
    public Lavatrice(string nome) : base(nome)
    {
        Random rnd = new Random();
        SerbatoioDetersivo = rnd.Next(1001);
        SerbatoioAmmorbidente = rnd.Next(501);

        ProgrammiLavatrice = new ProgrammaLavatrice[3];
        ProgrammaLavatrice rinfrescante = new ProgrammaLavatrice("Rinfrescante", 2, 20, 20, 5);
        ProgrammaLavatrice rinnovante = new ProgrammaLavatrice("Rinnovante", 3, 40, 40, 10);
        ProgrammaLavatrice sgrassante = new ProgrammaLavatrice("Sgrassante", 4, 60, 60, 15);

        ProgrammiLavatrice[0] = rinfrescante;
        ProgrammiLavatrice[1] = rinnovante;
        ProgrammiLavatrice[2] = sgrassante;

        ProgrammaInCorso = AssegnaProgramma();
    }

    //metodi
    public override string AssegnaProgramma()
    {
        if (InFunzione)
        {
            Random rnd = new Random();
            int rndInt = rnd.Next(0, 3);
            return ProgrammaInCorso = ProgrammiLavatrice[rndInt].Nome;
        }
        else
        {
            return ProgrammaInCorso = "nessuno";
        }
    }

    //properties
    public int SerbatoioDetersivo { get; }
    public int SerbatoioAmmorbidente { get; }
    public ProgrammaLavatrice[] ProgrammiLavatrice { get; }

}
