// See https://aka.ms/new-console-template for more information
//classe lavanderia
public class Lavanderia
{
    public Lavatrice[] Lavatrici { get; }
    public Asciugatrice[] Asciugatrici { get; }

    //costruttore
    public Lavanderia()
    {

        Lavatrici = new Lavatrice[5];

        Lavatrici[0] = new Lavatrice("Lavatrice 1");
        Lavatrici[1] = new Lavatrice("Lavatrice 2");
        Lavatrici[2] = new Lavatrice("Lavatrice 3");
        Lavatrici[3] = new Lavatrice("Lavatrice 4");
        Lavatrici[4] = new Lavatrice("Lavatrice 5");

        Asciugatrici = new Asciugatrice[5];

        Asciugatrici[0] = new Asciugatrice("Asciugatrice 1");
        Asciugatrici[1] = new Asciugatrice("Asciugatrice 2");
        Asciugatrici[2] = new Asciugatrice("Asciugatrice 3");
        Asciugatrici[3] = new Asciugatrice("Asciugatrice 4");
        Asciugatrici[4] = new Asciugatrice("Asciugatrice 5");
    }

    public void AssegnaProgramma()
    {
        for (int i = 0; i < Lavatrici.Length; i++)
        {
            if (Lavatrici[i].InFunzione)
            {
                Random rnd = new Random();
                int rndInt = rnd.Next(0, 3);
                Lavatrici[i].ProgrammaInCorso = Lavatrici[i].ProgrammiLavatrice[rndInt].Nome;
                Lavatrici[i].DurataProgrammaInCorso = Lavatrici[i].ProgrammiLavatrice[rndInt].Durata;
                Lavatrici[i].SerbatoioDetersivo = Lavatrici[i].SerbatoioDetersivo - Lavatrici[i].ProgrammiLavatrice[rndInt].Detersivo;
                Lavatrici[i].SerbatoioAmmorbidente = Lavatrici[i].SerbatoioAmmorbidente - Lavatrici[i].ProgrammiLavatrice[rndInt].Ammorbidente;
                Lavatrici[i].Incasso = Lavatrici[i].Incasso + Lavatrici[i].ProgrammiLavatrice[rndInt].Costo;
                Lavatrici[i].TempoRimanente = new Random().Next(0, Lavatrici[i].ProgrammiLavatrice[rndInt].Durata + 1);
            }
        }

        for (int i = 0; i < Asciugatrici.Length; i++)
        {
            if (Asciugatrici[i].InFunzione)
            {
                Random rnd = new Random();
                int rndInt = rnd.Next(0, 2);
                Asciugatrici[i].ProgrammaInCorso = Asciugatrici[i].ProgrammiAsciugatrice[rndInt].Nome;
                Asciugatrici[i].DurataProgrammaInCorso = Asciugatrici[i].ProgrammiAsciugatrice[rndInt].Durata;
                Asciugatrici[i].Incasso = Asciugatrici[i].Incasso + Asciugatrici[i].ProgrammiAsciugatrice[rndInt].Costo;
                Asciugatrici[i].TempoRimanente = new Random().Next(0, Asciugatrici[i].ProgrammiAsciugatrice[rndInt].Durata + 1);
            }
        }
    }

    public void StampaMacchine()
    {
        Console.WriteLine("STATO LAVATRICI:");
        for (int i = 0; i < Lavatrici.Length; i++)
        {
            Console.WriteLine("Nome lavatrice: " + Lavatrici[i].Nome);
            Console.WriteLine("Programma lavatrice: " + Lavatrici[i].ProgrammaInCorso);
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
            Console.WriteLine("Programma asciugatrice: " + Asciugatrici[i].ProgrammaInCorso);
            if (Asciugatrici[i].InFunzione)
            {
                Console.WriteLine("Stato: In asciugatura");
            }
            else
            {
                Console.WriteLine("Stato: inattiva");
            }
            Console.WriteLine("-----------------------");
        }
    }

    public void InterrogaMacchine(string interrogazione)
    {
        if (interrogazione == "lavatrice")
        {
            Console.WriteLine("Scegli la lavatrice [1,2,3,4,5]");
            int lavatriceScelta = Convert.ToInt32(Console.ReadLine());
            if (lavatriceScelta > 0 && lavatriceScelta < 6)
            {
                Console.WriteLine("nome lavatrice: " + Lavatrici[lavatriceScelta - 1].Nome);
                if (Lavatrici[lavatriceScelta - 1].InFunzione)
                {
                    Console.WriteLine("Stato: In lavaggio");
                }
                else
                {
                    Console.WriteLine("Stato: inattiva");
                }
                Console.WriteLine("stato serbatoio detersivo: " + Lavatrici[lavatriceScelta - 1].SerbatoioDetersivo);
                Console.WriteLine("stato serbatoio ammorbidente: " + Lavatrici[lavatriceScelta - 1].SerbatoioAmmorbidente);
                Console.WriteLine("programma in funzione: " + Lavatrici[lavatriceScelta - 1].ProgrammaInCorso);
                Console.WriteLine("durata programma: " + Lavatrici[lavatriceScelta - 1].DurataProgrammaInCorso + " minuti");
                Console.WriteLine("l'incasso è: " + Lavatrici[lavatriceScelta - 1].Incasso);
                Console.WriteLine("il tempo rimanente è: " + Lavatrici[lavatriceScelta - 1].TempoRimanente + " minuti");

            }
            else
            {
                Console.WriteLine("fai una scelta appropriata");
                Console.WriteLine("Vuoi interrogare una lavatrice o un'asciugatrice? [lavatrice/asciugatrice]");
                string input = Console.ReadLine();
                InterrogaMacchine(input);
            }
        }
        else if (interrogazione == "asciugatrice")
        {
            Console.WriteLine("Scegli l'asciugatrice [1,2,3,4,5]");
            int asciugatriceScelta = Convert.ToInt32(Console.ReadLine());
            if (asciugatriceScelta > 0 && asciugatriceScelta < 6)
            {
                Console.WriteLine("nome asciugatrice: " + Asciugatrici[asciugatriceScelta - 1].Nome);
                if (Asciugatrici[asciugatriceScelta - 1].InFunzione)
                {
                    Console.WriteLine("Stato: In asciugatura");
                }
                else
                {
                    Console.WriteLine("Stato: inattiva");
                }
                Console.WriteLine("programma in funzione: " + Asciugatrici[asciugatriceScelta - 1].ProgrammaInCorso);
                Console.WriteLine("durata programma: " + Asciugatrici[asciugatriceScelta - 1].DurataProgrammaInCorso + " minuti");
                Console.WriteLine("l'incasso è: " + Asciugatrici[asciugatriceScelta - 1].Incasso);
                Console.WriteLine("il tempo rimanente è: " + Asciugatrici[asciugatriceScelta - 1].TempoRimanente + " minuti");

            }
            else
            {
                Console.WriteLine("fai una scelta appropriata");
                Console.WriteLine("Vuoi interrogare una lavatrice o un'asciugatrice? [lavatrice/asciugatrice]");
                string input = Console.ReadLine();
                InterrogaMacchine(input);
            }
        }
        else
        {
            Console.WriteLine("fai una scelta appropriata");
            Console.WriteLine("Vuoi interrogare una lavatrice o un'asciugatrice? [lavatrice/asciugatrice]");
            string input = Console.ReadLine();
            InterrogaMacchine(input);
        }
    }

    public void IncassoTotale()
    {
        //totale lavatrici
        float totLavatrici = 0;
        foreach (Lavatrice lavatrice in Lavatrici)
        {
            totLavatrici += lavatrice.Incasso;
        }
        Console.WriteLine("L'attuale incasso delle lavatrici è: " + (totLavatrici * 0.50f));

        //totale asciugatrici
        float totAsciugatrici = 0;
        foreach (Asciugatrice asciugatrice in Asciugatrici)
        {
            totAsciugatrici += asciugatrice.Incasso;
        }
        Console.WriteLine("L'attuale incasso delle asciugatrici è: " + (totAsciugatrici * 0.50f));

        //totale macchine
        Console.WriteLine("L'attuale incasso di tutte le macchine è: " + ((totAsciugatrici + totLavatrici) * 0.50f));

    }
}