using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.Task05.BackupSystem
{
    public class Monitoring
    {
        public static FileInfo logFile = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt"));
        FileSystemWatcher watcher = new FileSystemWatcher();
        
        public Monitoring(string path)
        {
            watcher = new FileSystemWatcher(path, "*.txt");
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }
        
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            FileStream fstream = null;
            try
            {
                fstream = logFile.OpenWrite();
            }
            finally
            {
                if (fstream != null)
                {
                    byte[] array = Encoding.Default.GetBytes(DateTime.Now + ": " + "File: " + e.FullPath + " " + e.ChangeType);
                    fstream.Write(array, 0, array.Length);
                    MessageBox.Show("File: " + e.FullPath + " was " + e.ChangeType);
                }

                fstream.Close();
                File.Copy(e.FullPath, Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Storage\" , DateTime.Now.ToString("HH-mm.dd-MM-yy") + ".txt"), true);
            }
        }
        public void Stop()
        {
            watcher.EnableRaisingEvents = false;
        }

        public void Start()
        {
            watcher.EnableRaisingEvents = true;
        }
    }
}
