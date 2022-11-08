// See https://aka.ms/new-console-template for more information
//classe programma lavatrice
public class ProgrammaLavatrice : Programma
{
    //costruttore
    public ProgrammaLavatrice (string nome, int costo, int durata, int detersivo, int ammorbidente) : base (nome, costo, durata)
    {
        Detersivo = detersivo;
        Ammorbidente = ammorbidente;
    }

    //properties
    public int Detersivo { get; set; }
    public int Ammorbidente { get; set; }
}
