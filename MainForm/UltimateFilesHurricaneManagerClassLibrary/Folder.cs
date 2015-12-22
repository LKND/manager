using System;
using System.Collections.Generic;
using System.IO;

namespace UltimateFilesHurricaneManagerClassLibrary
{
    public class Folder : AbstractFolder
    {

        public Folder(string path)
        {
            Path = path;
            var currentDirInfo = new DirectoryInfo(Path);
            Name = currentDirInfo.Name;
            DateOfCreation = currentDirInfo.CreationTime.ToShortDateString();
            FilesList = new List<AbstractFile>();
            DirectoriesList = new List<AbstractFolder>();
        }

        public override IEnumerable<ProgressInfo> Copy(AbstractFolder newFolder)
        {
            Open();

            var progressInfo = new ProgressInfo
            {
                All = FilesList.Count + DirectoriesList.Count
            };

            Directory.CreateDirectory(newFolder.Path);

            foreach (AbstractFile item in FilesList)
            {
                AbstractFile destination = newFolder.CreateFile(item.Name);
                item.Copy(destination);
                progressInfo.Current++;

                yield return progressInfo;
            }
            foreach (AbstractFolder item in DirectoriesList)
            {
                AbstractFolder createdFolder = newFolder.CreateFolder(item.Name);
                foreach (var innerItem in item.Copy(createdFolder))
                {

                }
                progressInfo.Current++;

                yield return progressInfo;
            }
        }

        public override void Open()
        {
            try
            {
                var currentDirInfo = new DirectoryInfo(Path);

                foreach (var item in currentDirInfo.GetFiles())
                {
                    var newFile = new File(System.IO.Path.Combine(Path, item.Name));
                    FilesList.Add(newFile);
                }
                foreach (var item in currentDirInfo.GetDirectories())
                {
                    var newDirectory = new Folder(System.IO.Path.Combine(Path, item.Name));
                    DirectoriesList.Add(newDirectory);
                }
            }
            catch (Exception)
            {
                throw new IOException();
            }
        }

        public override void Remove()
        {
            try
            {
                Directory.Delete(Path, true);
            }
            catch (Exception)
            {
                throw new IOException();
            }
        }

        public override void Replace(string inDirectory)
        {
            try
            {
                Directory.Move(Path, inDirectory);
            }
            catch (Exception)
            {
                throw new IOException();
            }
        }

        public override AbstractFile CreateFile(string fileName)
        {
            return new File(System.IO.Path.Combine(Path, fileName));
        }

        public override AbstractFolder CreateFolder(string folderName)
        {
            Directory.CreateDirectory(System.IO.Path.Combine(Path, folderName));
            return new Folder(System.IO.Path.Combine(Path, folderName));
        }
    }
}

