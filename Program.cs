// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

//Una lavanderia è aperta 24 ore su 24 e permette ai clienti di servizi autonomamente di 5 Lavatrici e 5 Asciugatrici.
//I clienti che usufruiscono delle macchine, possono effettuare diversi programmi di lavaggio e asciugatura ognuno con un costo diverso (in gettoni) e di una specifica durata.
//Ogni gettone costa 0.50 centesimi di euro e ogni lavaggio consuma detersivo e ammorbidente dai serbatoi della lavatrice.
//Ogni lavatrice può tenere fino ad un massimo di 1 litro di detersivo e 500ml di ammorbidente.

//I programmi di lavaggio hanno quindi queste caratteristiche
//Rinfrescante, costo di 2 gettoni, durata di 20 minuti, consumo di 20ml di detersivo e 5ml di ammorbidente.
//Rinnovante, costo di 3 gettoni, durata di 40 minuti, consumo di 40ml di detersivo e 10ml di ammorbidente.
//Sgrassante, costo di 4 gettoni, durata di 60 minuti, consumo di 60 ml di detersivo e 15ml di ammorbidente.
//Le asciugatrici invece hanno soltanto due programmi di asciugatura, rapido 2 gettoni e intenso 4 gettoni della durata di 30 minuti e 60 minuti rispettivamente.

//Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
//1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e quali non lo sono (in lavaggio / asciugatura oppure ferme)
//2 - Possa essere richiesto il dettaglio di una macchina:
//Tutte le informazioni relative alla macchina, nome del macchinario, stato del macchinario (in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice),
//durata del lavaggio, tempo rimanente alla fine del lavaggio.
//3 - l’attuale incasso generato dall’utilizzo delle macchine.

//classe lavatrice

Lavatrice lavatrice1 = new Lavatrice("Lavatrice 1");
Console.WriteLine("nome lavatrice: " + lavatrice1.Nome);
Console.WriteLine("stato lavatrice: " + lavatrice1.InFunzione);
Console.WriteLine("stato serbatoio detersivo: " + lavatrice1.SerbatoioDetersivo);
Console.WriteLine("stato serbatoio ammorbidente: " + lavatrice1.SerbatoioAmmorbidente);
Console.WriteLine("l'incasso è: " + lavatrice1.Incasso);

//creiamo i programmi lavatrice
ProgrammaLavatrice rinfrescante = new ProgrammaLavatrice("Rinfrescante", 2, 20, 20, 5);
Console.WriteLine("nome programma lavatrice: " + rinfrescante.NomeProgramma);
Console.WriteLine("costo programma lavatrice: " + rinfrescante.Costo);
Console.WriteLine("durata programma lavatrice: " + rinfrescante.Durata);
Console.WriteLine("detersivo programma lavatrice: " + rinfrescante.Detersivo);
Console.WriteLine("ammorbidente programma lavatrice: " + rinfrescante.Ammorbidente);

ProgrammaLavatrice rinnovante = new ProgrammaLavatrice("Rinnovante", 2, 20, 20, 5);
Console.WriteLine("nome programma lavatrice: " + rinnovante.NomeProgramma);
Console.WriteLine("costo programma lavatrice: " + rinnovante.Costo);
Console.WriteLine("durata programma lavatrice: " + rinnovante.Durata);
Console.WriteLine("detersivo programma lavatrice: " + rinnovante.Detersivo);
Console.WriteLine("ammorbidente programma lavatrice: " + rinnovante.Ammorbidente);

ProgrammaLavatrice sgrassante = new ProgrammaLavatrice("Sgrassante", 2, 20, 20, 5);
Console.WriteLine("nome programma lavatrice: " + sgrassante.NomeProgramma);
Console.WriteLine("costo programma lavatrice: " + sgrassante.Costo);
Console.WriteLine("durata programma lavatrice: " + sgrassante.Durata);
Console.WriteLine("detersivo programma lavatrice: " + sgrassante.Detersivo);
Console.WriteLine("ammorbidente programma lavatrice: " + sgrassante.Ammorbidente);

//creiamo i programmi lavatrice
Asciugatrice asciugatrice1 = new Asciugatrice("Asciugatrice 1", false);
Console.WriteLine("nome asciugatrice: " + asciugatrice1.Nome);
Console.WriteLine("stato asciugatrice: " + asciugatrice1.InFunzione);
Console.WriteLine("l'incasso è: " + asciugatrice1.Incasso);

//creiamo i programmi asciugatrice
ProgrammaAsciugatrice rapido = new ProgrammaAsciugatrice("Rapido", 2, 30);
Console.WriteLine("nome programma asciugatrice: " + rapido.NomeProgramma);
Console.WriteLine("costo programma asciugatrice: " + rapido.Costo);
Console.WriteLine("durata programma asciugatrice: " + rapido.Durata);

ProgrammaAsciugatrice intenso = new ProgrammaAsciugatrice("Intenso", 4, 60);
Console.WriteLine("nome programma asciugatrice: " + intenso.NomeProgramma);
Console.WriteLine("costo programma asciugatrice: " + intenso.Costo);
Console.WriteLine("durata programma asciugatrice: " + intenso.Durata);


//Lavatrice lavatrice2 = new Lavatrice("Lavatrice 2");
//Console.WriteLine("nome lavatrice: " + lavatrice2.Nome);
//Console.WriteLine("stato lavatrice: " + lavatrice2.InFunzione);

//Lavatrice lavatrice3 = new Lavatrice("Lavatrice 3");
//Console.WriteLine("nome lavatrice: " + lavatrice3.Nome);
//Console.WriteLine("stato lavatrice: " + lavatrice3.InFunzione);

//Lavatrice lavatrice4 = new Lavatrice("Lavatrice 4");
//Console.WriteLine("nome lavatrice: " + lavatrice4.Nome);
//Console.WriteLine("stato lavatrice: " + lavatrice4.InFunzione);

public class Lavatrice
{
    //costruttore
    public Lavatrice(string nome)
    {
        Nome = nome;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
        SerbatoioDetersivo = rnd.Next(1001);
        SerbatoioAmmorbidente = rnd.Next(501);
        Incasso = rnd.Next(501) * 0.50f;
    }

    //properties
    public string Nome { get; }
    public bool InFunzione { get; }
    public int SerbatoioDetersivo { get; }
    public int SerbatoioAmmorbidente { get; }
    public float Incasso { get; }
}

//classe programma lavatrice
public class ProgrammaLavatrice
{
    //costruttore
    public ProgrammaLavatrice (string nomeProgramma, int costo, int durata, int detersivo, int ammorbidente)
    {
        NomeProgramma = nomeProgramma;
        Costo = costo;
        Durata = durata;
        Detersivo = detersivo;
        Ammorbidente = ammorbidente;
    }

    //properties
    public string NomeProgramma { get; }
    public int Costo { get; }
    public int Durata { get; }
    public int Detersivo { get; }
    public int Ammorbidente { get; }
}

//classe asciugatrice
public class Asciugatrice
{
    //costruttore
    public Asciugatrice(string nome, bool inFunzione)
    {
        Nome = nome;
        Random rnd = new Random();
        InFunzione = inFunzione;
        Incasso = rnd.Next(1, 101) * 0.50f;
    }

    //properties
    public string Nome { get; }
    public bool InFunzione { get; }
    public float Incasso { get; }
}

//classe programma asciugatrice
public class ProgrammaAsciugatrice
{
    //costruttore
    public ProgrammaAsciugatrice(string nomeProgramma, int costo, int durata)
    {
        NomeProgramma = nomeProgramma;
        Costo = costo;
        Durata = durata;
    }

    public string NomeProgramma { get; }
    public int Costo { get; }
    public int Durata { get; }
}