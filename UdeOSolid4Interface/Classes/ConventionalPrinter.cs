using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeOSolid4Interface.Interfaces;

namespace UdeOSolid4Interface.Classes
{
    public class ConventionalPrinter : IPrinter, IActionDevice
    {
        private IPrinter printer;
        public void Print(Document document)
        {
            printer.Print(document);
        }

        public void ShutDown(Device device)
        {
            throw new NotImplementedException();
        }

        public void TurnOn(Device device)
        {
            throw new NotImplementedException();
        }
    }
}
