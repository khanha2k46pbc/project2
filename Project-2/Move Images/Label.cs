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
        public string name { get; set; }
        public string path { get; set; }
        public char key { get; set; }
        public List<string> imagePath { get; set; }

        public Label(string name, char key, string path)
        {
            this.name = name;
            this.key = key;
            this.path = path;

            this.imagePath = Directory.GetFiles(path: path, searchPattern: "*.jpg", searchOption: SearchOption.TopDirectoryOnly).ToList();
            this.imagePath.AddRange(Directory.GetFiles(path: path, searchPattern: "*.png", searchOption: SearchOption.TopDirectoryOnly));
            this.imagePath.AddRange(Directory.GetFiles(path: path, searchPattern: "*.bmp", searchOption: SearchOption.TopDirectoryOnly));
            this.imagePath.AddRange(Directory.GetFiles(path: path, searchPattern: "*.gif", searchOption: SearchOption.TopDirectoryOnly));
            this.imagePath.AddRange(Directory.GetFiles(path: path, searchPattern: "*.jpeg", searchOption: SearchOption.TopDirectoryOnly));
        }
    }
}
