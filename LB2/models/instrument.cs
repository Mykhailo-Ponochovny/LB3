using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LB2.models
{
    internal class Instrument
    {
        public string id;
        public TypeOfInstrument instrumentType;
        public double price;

        public Instrument(string id, TypeOfInstrument instrumentType, double price)
        {
            this.id = id;
            this.instrumentType = instrumentType;
            this.price = price;
        }

        public override string ToString()
        {
            return $"ID {id}\n" + $"Тип {instrumentType}\n" + $"Вартість {price}грн\n";
        }
    }
}

enum TypeOfInstrument
{
    drum,
    bassGuitar,
    rhythmGuitar,
    leadGuitar,
    synthesizer,
    piano,
    saxophone,
    violoncello,
    violin,
    accordion
}
