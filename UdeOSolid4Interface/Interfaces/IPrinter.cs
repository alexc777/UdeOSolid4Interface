using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeOSolid4Interface.Classes;

namespace UdeOSolid4Interface.Interfaces
{
    public interface IActionDevice
    {
        void TurnOn(Device device);
        void ShutDown(Device device);
    }

    public interface IPrinter
    {
        void Print(Document document);
    }

    public interface IFax
    {
        void Fax(Document document);
    }

    public interface IScanner
    {
        void Scan(Document document);
    }

    interface IMultiFunctionPrinter : IPrinter, IFax, IScanner, IActionDevice
    {

    }
}
