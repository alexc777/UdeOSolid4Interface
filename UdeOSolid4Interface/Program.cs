using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeOSolid4Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        public enum TypeDevice
        {
            Printer, Fax, Scanner
        }

        public enum TypeDocument
        {
            DOC, TXT, PDF, XLS
        }

        public class Device
        {
            public string Name;
            public string Mac;
            public TypeDevice TypeDevice;

            public Device(string name, string mac, TypeDevice typeDevice)
            {
                Name = name;
                Mac = mac;
                TypeDevice = typeDevice;
            }
        }

        public class Document
        {
            public string Name;
            public TypeDocument TypeDocument;

            public Document(string name, TypeDocument typeDocument)
            {
                Name = name;
                TypeDocument = typeDocument;
            }
        }

        public interface IActionDevice
        {
            void TurnOn(Device device);
            void ShutDown(Device device);
        }

        public interface IPrinter
        {
            void Print(Document document);
            void Scan(Document document);
            void PhotoCopy();
        }

        public interface IFax
        {
            void Print(Document document);
        }

        public interface IScanner
        {
            void Scan(Document document);
        }
    }
}
