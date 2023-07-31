using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.Move_Images
{
    internal class RootFolder
    {
        internal static string path { get; set; }
        internal static List<string> imagePath { get; set; }
        internal static int current_index { get; set; }
        internal static bool isAllDirectories;
        internal static void refresh() 
        {
            if (isAllDirectories)
            {
                RootFolder.imagePath = Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpg", searchOption: SearchOption.AllDirectories).ToList();
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.png", searchOption: SearchOption.AllDirectories));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.bmp", searchOption: SearchOption.AllDirectories));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.gif", searchOption: SearchOption.AllDirectories));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpeg", searchOption: SearchOption.AllDirectories));
            }
            else
            {
                RootFolder.imagePath = Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpg", searchOption: SearchOption.TopDirectoryOnly).ToList();
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.png", searchOption: SearchOption.TopDirectoryOnly));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.bmp", searchOption: SearchOption.TopDirectoryOnly));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.gif", searchOption: SearchOption.TopDirectoryOnly));
                RootFolder.imagePath.AddRange(Directory.GetFiles(path: RootFolder.path, searchPattern: "*.jpeg", searchOption: SearchOption.TopDirectoryOnly));
            }
        }
    }
}
