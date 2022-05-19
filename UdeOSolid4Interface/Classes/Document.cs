using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeOSolid4Interface.Classes
{

    public enum TypeDocument
    {
        DOC, TXT, PDF, XLS
    }
    public class Document
    {
        public TypeDocument TypeDocument;

        public string Name { get; set; }
        public string Path { get; set; }
        public TypeDocument Type { get; set; }
    }
}
