using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateFilesHurricaneManagerClassLibrary;
using System.IO;
using File = UltimateFilesHurricaneManagerClassLibrary.File;

namespace MainForm
{
    public partial class LVKontrol : Panel
    {
        public string[] Drives = Environment.GetLogicalDrives();
        File fales;
        string SelPath;
        Folder SelectedFolder;
        File SelectedFile;
        Folder parentFolder;
        Boolean bLV = false;

        //для копирования - свойство - текущая папка(из правого контрола(Folder)), свойство - текущий файл(из левого контрола(File)), не пути к ним, а именно объекты 
        public Folder ListViewFolderLeft
        {
            get { return SelectedFolder; }
            set { SelectedFolder = value; }
        }
        public File ListViewFileLeft
        {
            get { return SelectedFile; }
            set { SelectedFile = value; }
        }
        public Folder ListViewFolderRight
        {
            get { return SelectedFolder; }
            set { SelectedFolder = value; }
        }
        public File ListViewFileRight
        {
            get { return SelectedFile; }
            set { SelectedFile = value; }
        }
        public bool LvSel
        {
            get
            {
                if (listView1.SelectedIndices.Count>0)
                {
                    bLV=true;
                }
                return bLV;
            }
            set { bLV = value; }
        }

        //public Folder FolderToCopyL {
        //    get
        //    {
        //        string fold = Directory.GetCurrentDirectory();
        //        Folder FoldtoCopy = new Folder(fold);
        //        return FolderToCopyL;
        //    } 
        //}
        public Folder GetParentFolder()
        {
            int selected = 0;
            if (listView1.SelectedIndices.Count > 0)
            {
                selected = listView1.SelectedIndices[0];
            }
            var t = listView1.Items[selected];
            //string asd = Directory.GetParent(t.SubItems[1].Text).ToString();
            FileAttributes attr = System.IO.File.GetAttributes(t.SubItems[1].Text);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                SelectedFolder = new Folder(t.SubItems[1].Text);
                string par = Directory.GetParent(SelectedFolder.Path).ToString();
                parentFolder = new Folder(par);
            }
            else
            {
                SelectedFile = new File(t.SubItems[1].Text);
                string par2 = Directory.GetParent(SelectedFile.Path).ToString();
                parentFolder = new Folder(par2);
            }
            return parentFolder;
        }

#region
        public LVKontrol()
        {
            InitializeComponent();
        }
        public void CreateDiskBut()
        {
            var listBtn = new List<Button>();
            int k = 0;
            for (int i = 0; i < Drives.Length; i++)
            {
                var btn = new Button
                {
                    Location = new Point(10 + k, 30),
                    Size = new Size(50, 25),
                    Name = "BTN" + Drives[i],
                    Text = Drives[i],
                    Dock = DockStyle.Top
                };
                listBtn.Add(btn);
                k = k + 50;
                btn.Click += ButtonClickOd;
            }
            foreach (var b in listBtn)
            {
                panel1.Controls.AddRange(new Control[] { b });
            }

        }
        public void ButtonClickOd(object sender, EventArgs e)
        {
            string g = ((Button) sender).Text;
            OpenDir(g);
        }
        public void OpenDir(string d)
        {
            string c = d;
            listView1.Items.Clear();
            Folder flFile = new Folder(c);
            flFile.Open();
            foreach (var l in flFile.DirectoriesList)
            {
                ListViewItem lvi = new ListViewItem();
                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                lvi.Text = l.Name;
                lvsi.Text = l.Path;
                lvi.SubItems.Add(lvsi);
                listView1.Items.Add(lvi);
            }
            foreach (var l in flFile.FilesList)
            {
                ListViewItem lvi = new ListViewItem();
                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
                lvi.Text = l.Name;
                lvsi.Text = l.Path;
                //lvsi1.Text = l.Size.ToString();
                lvi.SubItems.Add(lvsi);
                //lvi.SubItems.Add(lvsi1);
                listView1.Items.Add(lvi);
            }
            ls.Add(c);
        }
        public void FilList(Folder flFile)
        {
            flFile.Open();
            listView1.Items.Clear();
            foreach (var l in flFile.DirectoriesList)
            {
                ListViewItem lvi = new ListViewItem();
                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                lvi.Text = l.Name;
                lvsi.Text = l.Path;
                lvi.SubItems.Add(lvsi);
                listView1.Items.Add(lvi);
            }
            foreach (var l in flFile.FilesList)
            {
                ListViewItem lvi = new ListViewItem();
                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvsi1 = new ListViewItem.ListViewSubItem();
                lvi.Text = l.Name;
                lvsi.Text = l.Path;
                lvsi1.Text = l.Size.ToString();
                lvi.SubItems.Add(lvsi);
                lvi.SubItems.Add(lvsi1);
                listView1.Items.Add(lvi);
            }
        }
        public void OpenDirorFile(string t1, Folder flFile)
        {
            ls.Add(t1);
            FileAttributes attr = System.IO.File.GetAttributes(t1);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                FilList(flFile);
            else
            {
                var file = new File(t1);
                file.Open();
            }
        }
        public LVKontrol(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Path");
            listView1.Columns.Add("Size");
            listView1.Dock = DockStyle.Bottom;
            CreateDiskBut();
            var flFile = new Folder(@"C:\");
            FilList(flFile);
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int selected=0;
            if (listView1.SelectedIndices.Count > 0)
            {
                selected = listView1.SelectedIndices[0];
            }
            var t = listView1.Items[selected];
            string t1 = t.SubItems[1].Text;
            var flFile = new Folder(t1);
            OpenDirorFile(t1,flFile);
        }

        string backPath;
        List<string> ls = new List<string>(); 
        private void btn_Back_Click(object sender, EventArgs e)
        {
            int h = ls.Count;
            string baskPath=null;
            if (ls.Count-2>=0)
            {
                baskPath = ls[h - 2];
                ls.RemoveAt(ls.Count - 1);
                Folder backFolder = new Folder(baskPath);
                //OpenDirorFile(baskPath,backFolder);
                FileAttributes attr = System.IO.File.GetAttributes(baskPath);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    FilList(backFolder);
                else
                {
                    var file = new File(backPath);
                    file.Open();
                }
            }
        }
#endregion
        private void listView1_Click(object sender, EventArgs e)
        {
            int selected = 0;
            if (listView1.SelectedIndices.Count > 0)
            {
                selected = listView1.SelectedIndices[0];
            }
            var t = listView1.Items[selected];
            //string asd = Directory.GetParent(t.SubItems[1].Text).ToString();
            FileAttributes attr = System.IO.File.GetAttributes(t.SubItems[1].Text);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                SelectedFolder = new Folder(t.SubItems[1].Text);
            else
            {
                SelectedFile = new File(t.SubItems[1].Text);
            }
            //SelPath = t.SubItems[1].Text;
        }
    }
}
