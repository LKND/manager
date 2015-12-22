using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace UltimateFilesHurricaneManagerClassLibrary
{
    public class File : AbstractFile
    {        
        public File(string path)
        {
            Path = path;
            var disk = new DriveInfo(Path);
            if (!disk.IsReady)
                return;

            var fileInf = new FileInfo(Path);
            if (!fileInf.Exists) return;

            var currentFileInfo = new FileInfo(Path);
            Name = currentFileInfo.Name;            
            Size = currentFileInfo.Length;
            DateOfCreation = System.IO.File.GetCreationTime(Path).ToShortDateString();
            DateOfChange = System.IO.File.GetLastAccessTimeUtc(path).ToShortDateString();
            DateOfLastAppeal = System.IO.File.GetLastAccessTime(path).ToShortDateString();
        }

        public override void Copy(AbstractFile newFile)
        {
            var fileInf = new FileInfo(Path);
            if (!fileInf.Exists) return;
            // чтение из файла
            using (var fstream = System.IO.File.OpenRead(Path))
            {
                // преобразуем строку в байты
                var array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                fileInf.CopyTo(newFile.Path, true);
            }
        }
        public override void Write(byte[] batesArr)
        {
            using (var fstream = new FileStream(Path, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                var array = System.Text.Encoding.Default.GetBytes(Path);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);

            }
        }
        public override void Replace(string inDirectory)
        {
            var fileInf = new FileInfo(Path);
            if (!fileInf.Exists) return; // чтение из файла
            using (var fstream = System.IO.File.OpenRead(Path))
            {
                // преобразуем строку в байты
                var array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                fileInf.MoveTo(inDirectory);
            }
        }
        public override void Remove()
        {
            if (!System.IO.File.Exists(Path)) return;
            System.IO.File.Delete(Path);
        }
        public override void Open()
        {
            //Проверка на существование файла
            if (!System.IO.File.Exists(Path)) return;
            //Открываем файл внешней программой
            var p1 = new Process { StartInfo = { FileName = Path } };
            p1.Start();
        }
    }
}
