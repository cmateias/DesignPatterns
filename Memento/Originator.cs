using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Originator
    {
        public LEDTV ledTV;

        public Memento CreateMemento()
        {
            return new Memento(ledTV);
        }
        public void SetMemento(Memento memento)
        {
            ledTV = memento.ledTV;
        }
        public string GetDetails()
        {
            return "Originator [ledTV=" + ledTV.GetDetails() + "]";
        }
    }
}
