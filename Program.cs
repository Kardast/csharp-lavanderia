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

Lavanderia lavanderia = new Lavanderia();
lavanderia.StampaMacchine();


//creiamo i programmi lavatrice
//ProgrammaLavatrice rinfrescante = new ProgrammaLavatrice("Rinfrescante", 2, 20, 20, 5);
//Console.WriteLine("nome programma lavatrice: " + rinfrescante.NomeProgramma);
//Console.WriteLine("costo programma lavatrice: " + rinfrescante.Costo);
//Console.WriteLine("durata programma lavatrice: " + rinfrescante.Durata);
//Console.WriteLine("detersivo programma lavatrice: " + rinfrescante.Detersivo);
//Console.WriteLine("ammorbidente programma lavatrice: " + rinfrescante.Ammorbidente);

//ProgrammaLavatrice rinnovante = new ProgrammaLavatrice("Rinnovante", 2, 20, 20, 5);
//Console.WriteLine("nome programma lavatrice: " + rinnovante.NomeProgramma);
//Console.WriteLine("costo programma lavatrice: " + rinnovante.Costo);
//Console.WriteLine("durata programma lavatrice: " + rinnovante.Durata);
//Console.WriteLine("detersivo programma lavatrice: " + rinnovante.Detersivo);
//Console.WriteLine("ammorbidente programma lavatrice: " + rinnovante.Ammorbidente);

//ProgrammaLavatrice sgrassante = new ProgrammaLavatrice("Sgrassante", 2, 20, 20, 5);
//Console.WriteLine("nome programma lavatrice: " + sgrassante.NomeProgramma);
//Console.WriteLine("costo programma lavatrice: " + sgrassante.Costo);
//Console.WriteLine("durata programma lavatrice: " + sgrassante.Durata);
//Console.WriteLine("detersivo programma lavatrice: " + sgrassante.Detersivo);
//Console.WriteLine("ammorbidente programma lavatrice: " + sgrassante.Ammorbidente);


//creiamo i programmi asciugatrice
ProgrammaAsciugatrice rapido = new ProgrammaAsciugatrice("Rapido", 2, 30);
Console.WriteLine("nome programma asciugatrice: " + rapido.NomeProgramma);
Console.WriteLine("costo programma asciugatrice: " + rapido.Costo);
Console.WriteLine("durata programma asciugatrice: " + rapido.Durata);

ProgrammaAsciugatrice intenso = new ProgrammaAsciugatrice("Intenso", 4, 60);
Console.WriteLine("nome programma asciugatrice: " + intenso.NomeProgramma);
Console.WriteLine("costo programma asciugatrice: " + intenso.Costo);
Console.WriteLine("durata programma asciugatrice: " + intenso.Durata);

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
    public Asciugatrice(string nome)
    {
        Nome = nome;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
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

//classe lavanderia
public class Lavanderia
{
    public Lavatrice[] Lavatrici { get; }
    public Asciugatrice[] Asciugatrici { get; }

    //costruttore
    public Lavanderia()
    {

        Lavatrici = new Lavatrice[5];

        Lavatrice lavatrice1 = new Lavatrice("Lavatrice 1");
        Lavatrice lavatrice2 = new Lavatrice("Lavatrice 2");
        Lavatrice lavatrice3 = new Lavatrice("Lavatrice 3");
        Lavatrice lavatrice4 = new Lavatrice("Lavatrice 4");
        Lavatrice lavatrice5 = new Lavatrice("Lavatrice 5");

        Lavatrici[0] = lavatrice1;
        Lavatrici[1] = lavatrice2;
        Lavatrici[2] = lavatrice3;
        Lavatrici[3] = lavatrice4;
        Lavatrici[4] = lavatrice5;

        Asciugatrici = new Asciugatrice[5];

        Asciugatrice asciugatrice1 = new Asciugatrice("Asciugatrice 1");
        Asciugatrice asciugatrice2 = new Asciugatrice("Asciugatrice 2");
        Asciugatrice asciugatrice3 = new Asciugatrice("Asciugatrice 3");
        Asciugatrice asciugatrice4 = new Asciugatrice("Asciugatrice 4");
        Asciugatrice asciugatrice5 = new Asciugatrice("Asciugatrice 5");

        Asciugatrici[0] = asciugatrice1;
        Asciugatrici[1] = asciugatrice2;
        Asciugatrici[2] = asciugatrice3;
        Asciugatrici[3] = asciugatrice4;
        Asciugatrici[4] = asciugatrice5;
    }

    public void StampaMacchine()
    {
        Console.WriteLine("STATO LAVATRICI:");
        for (int i = 0; i < Lavatrici.Length; i++)
        {
            Console.WriteLine("Nome lavatrice: " + Lavatrici[i].Nome);
            if (Lavatrici[i].InFunzione)
            {
                Console.WriteLine("Stato: In lavaggio");
            }
            else
            {
                Console.WriteLine("Stato: inattiva");
            }
            Console.WriteLine("-----------------------");
        }
        Console.WriteLine("STATO ASCIUGATRICI:");
        for (int i = 0; i < Asciugatrici.Length; i++)
        {
            Console.WriteLine("Nome asciugatrice: " + Asciugatrici[i].Nome);
            if (Asciugatrici[i].InFunzione)
            {
                Console.WriteLine("Stato: In lavaggio");
            }
            else
            {
                Console.WriteLine("Stato: inattiva");
            }
            Console.WriteLine("-----------------------");
        }
    }

    public void InterrogaMacchine()
    {

    }
}