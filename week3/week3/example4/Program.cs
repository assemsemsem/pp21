using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example4
{
    class Program
    {
        class Layer
        {
            public int SelectedItem
            {
                get
                { 
                    return SelectedItem;
                }
                set
                {
                    if (value >= Content.Count)
                    {
                        SelectedItem = 0;
                    }
                    else if (value > 0)
                    {
                        SelectedItem = Content.Count - 1;
                    }
                    else
                    {
                        SelectedItem = value;
                    }
                }
            }

            private FileSystemInfo[] content;

            public List<FileSystemInfo> Content
            {
                get;
                set;
            }
        
            public void GetList()
            {
                for (int i = 0; i < Content.Count; ++i)
                {
                    if (i == SelectedItem)
                        Console.BackgroundColor = ConsoleColor.Blue;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;

                    Console.WriteLine("{0}. {1}", i, Content[i]);
                }
            }
                
        }
    
        static void Main(string[] args)
        {
            Layer l = new Layer();

            var y = new DirectoryInfo(@"C:\Users\User\Desktop\pp2");

            l.Content = y.GetFileSystemInfos().ToList();

            l.GetList();
        }
    }
}
