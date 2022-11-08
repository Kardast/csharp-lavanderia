// See https://aka.ms/new-console-template for more information
//classe asciugatrice
public class Asciugatrice : Macchina
{
    //costruttore
    public Asciugatrice(string nome) : base(nome)
    {
        ProgrammiAsciugatrice = new ProgrammaAsciugatrice[2];

        ProgrammiAsciugatrice[0] = new ProgrammaAsciugatrice("Rapido", 2, 30);
        ProgrammiAsciugatrice[1] = new ProgrammaAsciugatrice("Intenso", 4, 60);

    }

    //properties
    public ProgrammaAsciugatrice[] ProgrammiAsciugatrice { get; set; }
}
