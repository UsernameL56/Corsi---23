﻿using System;
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
                        //richiamo alla funzione
                        BubbleSort(array, indice);

                        break;
                    case 4:
                        //input
                        Console.WriteLine("\nInserire la parola che si vuole cercare: ");
                        parola = Convert.ToString(Console.ReadLine());
                        //richiamo alla funzione di ricerca della parola in generale per verificare che sia presente nell'array
                        if (Ricerca(array, parola, ref indice))
                        {
                            //richiamo alla funzione di ricerca sequenziale
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
                        //richiamo alla funzione
                        Stampa(array, indice);

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

        static void BubbleSort(string[] array, int indice)
        {
            //dichiarazione variabile temporanea d'appoggio
            string temp;
            //ciclo per ripetere tutte le parole
            for (int x = 0; x < indice - 1; x++)
            {
                //ciclo per confrontarle a coppie
                for (int y = 0; y < indice - 1; y++)
                    //se una parola viene dopo nell'alfabeto, allora scambiala con l'altra
                    if (string.Compare(array[y], array[y+1]) == 1)                      
                    {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }
            }
        }



        static int RicercaSequenziale(string[] array, string input)
        {
            //dichiarazione variabile per controllare la posizione della parola cercata
            int controllo = 0;
            //ciclo per controllare tutto l'array
            for (int z = 0; z < array.Length; z++)
            {
                //se la parola da cercare viene trovata allora fine ciclo
                if (array[z] == input)
                {
                    break;
                }
                controllo++;
            }
            return controllo;
        }

        static void Stampa(string[]array, int indice)
        {
            for (int i = 0; i < indice; i++)
            {
                Console.Write(array[i] + ", ");
            }
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
    }
}
