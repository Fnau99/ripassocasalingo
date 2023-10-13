using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    //creo la classe auto in cui andrò a dichiarire tutte le proprietà richieste
    public class Auto
    {
        //dichiaro le proprietà dell'auto
        #region Proprietà
        public string Modello;
        public string Marca;
        public string Colore;
        public TipiMotore Motori;

        //dichiaro le varie tipologie di motore, successivamente, l'enum appena fatto, va dichiarato come varibaile (devo rendere public il tipo enum)
        //TipiMotore è un tipo come int, char, string...
        public enum TipiMotore
        {
            Benzina,
            Diesel,
            GPL,
            Elettrica,
            Metano
        }
        #endregion

        //Dichiaro il costruttore, che serve per evitare di ingolfare il codice con tante righe.
        public Auto(TipiMotore TypeMotors, string brand, string color, string model)
        {
            TypeMotors = Motori;
            brand = Marca;
            color = Colore;
            model = Modello;
        }

        //Dichiaro il metodo che andro a richiamare per visualizzare quello presente nella classe
        public void Mostra()
        {
            Console.WriteLine("Modello :" + Modello, "Marca: " + Marca, "Colore: " + Colore + "Tipo di motore: " + Motori);
        }

    }
}
