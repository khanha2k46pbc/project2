using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.Move_Images
{
    internal class Label
    {
        internal Label(string name, char key, string path)
        {
            this.name = name;
            this.key = key;
            this.path = path;
            this.refresh();
        }

        internal string name { get; set; }
        internal string path { get; set; }
        internal char key { get; set; }
        internal List<string> imagePath { get; set; }
        internal void refresh()
        {
            this.imagePath = null;
            this.imagePath = Directory.GetFiles(path: path, searchPattern: "*.jpg", searchOption: SearchOption.TopDirectoryOnly).ToList();
            this.imagePath.AddRange(Directory.GetFiles(path: path, searchPattern: "*.png", searchOption: SearchOption.TopDirectoryOnly));
            this.imagePath.AddRange(Directory.GetFiles(path: path, searchPattern: "*.bmp", searchOption: SearchOption.TopDirectoryOnly));
            this.imagePath.AddRange(Directory.GetFiles(path: path, searchPattern: "*.gif", searchOption: SearchOption.TopDirectoryOnly));
            this.imagePath.AddRange(Directory.GetFiles(path: path, searchPattern: "*.jpeg", searchOption: SearchOption.TopDirectoryOnly));
        }
    }
}
