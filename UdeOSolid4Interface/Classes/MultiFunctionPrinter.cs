using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeOSolid4Interface.Interfaces;

namespace UdeOSolid4Interface.Classes
{
    public class MultiFunctionPrinter : IMultiFunctionPrinter
    {
        private IScanner scanner;
        private IPrinter printer;
        private IFax fax;
        private IActionDevice devices;

        public void Fax(Document document)
        {
            fax.Fax(document);
        }

        public void Print(Document document)
        {
            printer.Print(document);
        }

        public void Scan(Document document)
        {
            scanner.Scan(document);
        }

        public void ShutDown(Device device)
        {
            devices.ShutDown(device);
        }

        public void TurnOn(Device device)
        {
            devices.TurnOn(device);
        }
    }
}
