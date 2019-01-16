using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.Task05.BackupSystem
{
    public class Rollback
    {
        DirectoryInfo storage = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Storage\"));
        DirectoryInfo[] storageFiles;
        public DateTime date;

        public Rollback(DateTime date)
        {
            this.date = date;
        }

        public void MakeCopy()
        {
            try
            {
                storageFiles = storage.GetDirectories();
                DirectoryInfo dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"MyFolder\");
                if (storageFiles.Count() != 0)
                {
                    FileInfo[] files = dir.GetFiles("*");
                    foreach (FileInfo file in files)
                    {
                        file.Delete();
                    }
                    int copiedFiles = 0;
                    foreach (var file in storageFiles)
                    {
                        if (file.CreationTime.Date <= date)
                        {
                            File.Copy(file.FullName, AppDomain.CurrentDomain.BaseDirectory + @"MyFolder\", true);
                            copiedFiles++;
                        }
                    }

                    if (copiedFiles == 0)
                    {
                        MessageBox.Show("No written changes for this period");
                    }
                    else if (copiedFiles == 1)
                    {
                        MessageBox.Show("1 file was restored");
                    }
                    else if (copiedFiles > 1)
                    {
                        MessageBox.Show(copiedFiles + "files were restored");
                    }
                }
                else
                {
                    MessageBox.Show("No written changes for this period");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No written changes for this period");
            }
        }
    }
}
