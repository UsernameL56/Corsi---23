using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corsi___23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dichiarazioni 
            string[] array = new string[100];
            string parola;
            int indice = 0;
            int scelta = 0;

            //struttura menù
            do
            {
                //stampa delle opzioni
                Console.Clear();
                Console.WriteLine("1 - Aggiunta di un nome;");
                Console.WriteLine("2 - Cancellazione del singolo nome;");
                Console.WriteLine("3 - Ordinamento dei nomi (bubble sort);");
                Console.WriteLine("4 - Ricerca sequenziale;");
                Console.WriteLine("5 - Visualizza nomi ripetuti con numero ripetizioni;");
                Console.WriteLine("6 - Modifica di un nome;");
                Console.WriteLine("7 - Visualizzazione di tutti i nomi presenti;");
                Console.WriteLine("8 - Ricerca del nome più lungo e più corto;");
                Console.WriteLine("9 - Cancellazione di tutte le occorrenze di un nome;");
                Console.WriteLine("0 - uscita dal programma");
                //scelta delle opzione
                Console.WriteLine("Inserisci la scelta: ");
                scelta = int.Parse(Console.ReadLine());
                //esecuzione dell'opzione
                switch (scelta)
                {
                    case 1:
                        //input
                        Console.WriteLine("\nInserire una parola: ");
                        parola = Convert.ToString(Console.ReadLine());
                        //richiamo della funzione
                        if (Aggiunta(array, ref indice, parola) == true)
                            Console.WriteLine("\nParola inserita correttamente");
                        else
                            //output in caso si sia raggiunto il numero massimo di elementi che si possono inserire
                            Console.WriteLine("\nArray pieno");
                        Console.WriteLine("Premere un pulsante per continuare...");
                        Console.ReadLine();
                        break;
                    case 2:
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        
                        break;
                    case 7:
                        //stampa per poter andare a capo
                        Console.WriteLine("");
                        //ciclo per stampare l'array
                        for (int i = 0; i < indice; i++)
                        {
                            Console.Write(array[i] + ", ");
                        }
                        Console.WriteLine("Premere un pulsante per continuare...");
                        Console.ReadLine();
                        break;
                    case 8:
                        

                        break;
                }
            } while (scelta != 0);
        }

        static bool Aggiunta(string[] array, ref int i, string input)
        {
            bool inserito = true;
            //controllare se non abbiamo raggiunto la fine dell'array, se questa condizione è vera allora non fare nulla
            if (i < array.Length)
            {
                //inserimento dell'elemento
                array[i] = input;
                //incremento dell'indice
                i++;
            }
            else
                inserito = false;
            //ritorno in base allo spazio disponibile
            return inserito;
        }

        
    }
}
