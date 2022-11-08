// See https://aka.ms/new-console-template for more information
//classe asciugatrice
public class Asciugatrice : Macchina
{
    //costruttore
    public Asciugatrice(string nome) : base(nome)
    {
        ProgrammiAsciugatrice = new ProgrammaAsciugatrice[2];
        ProgrammaAsciugatrice rapido = new ProgrammaAsciugatrice("Rapido", 2, 30);
        ProgrammaAsciugatrice intenso = new ProgrammaAsciugatrice("Intenso", 4, 60);

        ProgrammiAsciugatrice[0] = rapido;
        ProgrammiAsciugatrice[1] = intenso;

        ProgrammaInCorso = AssegnaProgramma();
    }

    //metodi
        public override string AssegnaProgramma()
    {
        if (InFunzione)
        {
            Random rnd = new Random();
            int rndInt = rnd.Next(0, 2);
            return ProgrammaInCorso = ProgrammiAsciugatrice[rndInt].Nome;
        }
        else
        {
            return ProgrammaInCorso = "nessuno";
        }
    }

    //properties
    public ProgrammaAsciugatrice[] ProgrammiAsciugatrice { get; set; }
}
