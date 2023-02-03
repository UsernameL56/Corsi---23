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
                        //input
                        Console.WriteLine("\nInserire la parola da cancellare: ");
                        parola = Convert.ToString(Console.ReadLine());
                        //richiamo alla funzione
                        array = Cancellazione(array, ref indice, parola);
                        Console.WriteLine("\nElemento cancellato correttamente");

                        Console.WriteLine("Premere un pulsante per continuare...");
                        Console.ReadLine();
                        break;
                    case 3:
                        BubbleSort(array);
                        break;
                    case 4:
                        Console.WriteLine("\nInserire la parola che si vuole cercare: ");
                        parola = Convert.ToString(Console.ReadLine());
                        if (Ricerca(array, parola, ref indice))
                        {
                            int ricerca = RicercaSequenziale(array, parola);
                            Console.WriteLine("La parola è stata trovata in posizione " + ricerca);
                        }
                        else
                            Console.WriteLine(-1);
                        
                        Console.WriteLine("Premere un pulsante per continuare...");
                        Console.ReadLine();
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        
                        break;
                    case 7:
                        Stampa(array, indice);
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
        static string[] Cancellazione(string[] array, ref int i, string input)
        {
            //ciclo per ricercare la parola nell'array
            for(int z = 0; z < array.Length; z++)
            {
                //se la parola viene trovata allora
                if (array[z] == input)
                {
                    //ciclo per sovrascrivere le parole per cancellare quella inserita
                    while(z < i)
                    {
                        array[z] = array[z + 1];
                        z++;
                    }
                    //decremento dell'indice data la parola cancellata
                    i = i - 1;
                    //uscita dal ciclo 
                    break;
                }
            }
            //ritorno del nuovo ciclo
            return array;
        }

        static void BubbleSort(string[] array)
        {
            string temp;
            for (int x = 0; x < array.Length - 1; x++)                     // ripeti per tutti i numeri
            {
                for (int y = 0; y < array.Length - 1; y++)                 // li confronto tutti a coppie
                    if (string.Compare(array[y], array[y+1]) == 1)                        // se ne trovo uno maggiore
                    {
                        temp = array[y];                          // li scambio tra loro
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }
            }
        }

            static int RicercaSequenziale(string[] array, string input)
        {
            int controllo = 0;
            for (int z = 0; z < array.Length; z++)
            {
                if (array[z] == input)
                {
                    break;
                }
                controllo++;
            }
            return controllo;
        }

        static bool Ricerca(string[] array, string input, ref int indice)
        {
            bool trovato = true;
            //ciclo per controllare se l'elemento inserito è presente nell'array
            for (int i = 0; i < array.Length; i++)
            {
                //in base all'input, avremo un output true o false
                if (array[i] == input)
                {
                    trovato = true;
                    //una volta trovato il numero esci dal ciclo
                    break;
                }
                else
                    trovato = false;
                //incremento dell'indice di ricerca per l'output nel main
                indice++;
            }
            //ritorno in base all'input
            return trovato;
        }

        static void Stampa(string[]array, int indice)
        {
            for (int i = 0; i < indice; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine("Premere un pulsante per continuare...");
            Console.ReadLine();
        }
    }
}
