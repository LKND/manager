using System.Collections.Generic;

namespace UltimateFilesHurricaneManagerClassLibrary
{
    public abstract class AbstractFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public long Size { get; set; }
        public string DateOfCreation { get; set; }
        public string DateOfChange { get; set; }
        public string DateOfLastAppeal { get; set; }

        public abstract void Copy(AbstractFile file);
        public abstract void Write(byte[] batesArr);
        public abstract void Replace(string inDirectory);
        public abstract void Remove();
        public abstract void Open();
    }

    public abstract class AbstractFolder
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string DateOfCreation { get; set; }
        public List<AbstractFile> FilesList { get; set; }        
        public List<AbstractFolder> DirectoriesList { get; set; }

        public abstract IEnumerable<ProgressInfo> Copy(AbstractFolder nodeElement);
        public abstract void Open();
        public abstract void Remove();
        public abstract void Replace(string inDirectory);
        public abstract AbstractFile CreateFile(string fileName);
        public abstract AbstractFolder CreateFolder(string folderNmae);
    }
}
