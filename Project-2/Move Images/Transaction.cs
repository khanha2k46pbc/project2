using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.Move_Images
{
    internal class Transaction
    {
        internal string source { get; set; }
        internal string destination { get; set; }
        internal Transaction(string source, string destination)
        {
            this.source = source;
            this.destination = destination;
        }
    }
}
