// See https://aka.ms/new-console-template for more information
public class Lavatrice : Macchina
{
    //costruttore
    public Lavatrice(string nome) : base(nome)
    {
        //Random rnd = new Random();
        SerbatoioDetersivo = 1000;
        SerbatoioAmmorbidente = 500;

        ProgrammiLavatrice = new ProgrammaLavatrice[3];

        ProgrammiLavatrice[0] = new ProgrammaLavatrice("Rinfrescante", 2, 20, 20, 5);
        ProgrammiLavatrice[1] = new ProgrammaLavatrice("Rinnovante", 3, 40, 40, 10);
        ProgrammiLavatrice[2] = new ProgrammaLavatrice("Sgrassante", 4, 60, 60, 15);

        //ProgrammaInCorso = AssegnaProgramma();
    }

    //metodi
    //public override string AssegnaProgramma()
    //{
    //    if (InFunzione)
    //    {
    //        Random rnd = new Random();
    //        int rndInt = rnd.Next(0, 3);
    //        return ProgrammaInCorso = ProgrammiLavatrice[rndInt].Nome;
    //    }
    //    else
    //    {
    //        return ProgrammaInCorso = "nessuno";
    //    }
    //}

    //properties
    public int SerbatoioDetersivo { get; }
    public int SerbatoioAmmorbidente { get; }
    public ProgrammaLavatrice[] ProgrammiLavatrice { get; }

}
