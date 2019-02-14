using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarManager2
{
    internal class Layer
    {
            private int selectedItem;
            public int SelectedItem
            {
                get
                {
                    return selectedItem;
                }
                set
                {
                    if (value >= Content.Count)
                    {
                        selectedItem = 0;
                    }
                    else if (value < 0)
                    {
                        selectedItem = Content.Count - 1;
                    }
                    else
                    {
                        selectedItem = value;
                    }
                }
            }

            public List<FileSystemInfo> Content
            {
                get;
                set;
            }

            public void DeleteSelectedItem()
            {
                FileSystemInfo fileSystemInfo = Content[selectedItem];
                if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                {
                    Directory.Delete(fileSystemInfo.FullName, true);
                }
                else
                {
                    File.Delete(fileSystemInfo.FullName);
                }
                Content.RemoveAt(selectedItem);
                selectedItem--;
            }

            public void Draw()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                for (int i = 0; i < Content.Count; ++i)
                {
                    if (i == SelectedItem)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(Content[i].Name);
                }
            }

            internal void RenameFile()
            {
                Console.WriteLine("New name:");
                string t = Console.ReadLine();
                FileSystemInfo fileSystemInfo = Content[selectedItem];
                Console.WriteLine(fileSystemInfo.FullName);
                string t2;
                t2 = Path.GetDirectoryName(fileSystemInfo.FullName) + "\\" + t;
                Console.WriteLine(t2);
                File.Move(fileSystemInfo.FullName, t2);


            }



        }
    }
