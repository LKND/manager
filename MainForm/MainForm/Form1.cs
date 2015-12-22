using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateFilesHurricaneManagerClassLibrary;
using File = System.IO.File;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Open_Click(object sender, EventArgs e)
        {
            bool lvkFolderLeft = (lvKontrol1.ListViewFolderLeft != null);
            bool lvkFileLeft = (lvKontrol1.ListViewFileLeft == null);
            if (lvkFolderLeft && lvkFileLeft)
            {
                var qwe = new Folder(lvKontrol1.ListViewFolderLeft.Path);
                lvKontrol1.OpenDirorFile(lvKontrol1.ListViewFolderLeft.Path, qwe);
                lvKontrol1.ListViewFolderLeft = null;
                lvKontrol1.ListViewFileLeft = null;
            }
            if (!lvkFolderLeft && !lvkFileLeft)
            {
                var qwe = new Folder(lvKontrol1.ListViewFileLeft.Path);
                lvKontrol1.OpenDirorFile(lvKontrol1.ListViewFileLeft.Path, qwe);
                lvKontrol1.ListViewFolderLeft = null;
                lvKontrol1.ListViewFileLeft = null;
            }

            bool lvkFolderRight = (lvKontrol2.ListViewFolderRight != null);
            bool lvkFileRight = (lvKontrol2.ListViewFileRight == null);
            if (lvkFolderRight && lvkFileRight)
            {
                var qwe = new Folder(lvKontrol2.ListViewFolderRight.Path);
                lvKontrol2.OpenDirorFile(lvKontrol2.ListViewFolderRight.Path, qwe);
                lvKontrol2.ListViewFolderRight = null;
                lvKontrol2.ListViewFileRight = null;
            }
            if (!lvkFolderRight && !lvkFileRight)
            {
                var qwe = new Folder(lvKontrol2.ListViewFileRight.Path);
                lvKontrol2.OpenDirorFile(lvKontrol2.ListViewFileRight.Path, qwe);
                lvKontrol2.ListViewFolderRight = null;
                lvKontrol2.ListViewFileRight = null;
            }
        }
        private void btn_Copy_Click(object sender, EventArgs e)
        {
            //var qwe = new Folder(lvKontrol1.ListViewFolderLeft.Path);
            //var qwe1 = new Folder(lvKontrol2.ListViewFolderRight.Path);
            //Folder f1 = lvKontrol1.GetParentFolder();
            ////слева - папка для копирования, правая - корневая папка.
            //foreach (var item in qwe.Copy(qwe1))
            //{
            //    MessageBox.Show(item.ToString());
            //}

            if ((lvKontrol1.ListViewFolderLeft != null) && (lvKontrol1.ListViewFileLeft == null))
            {
                var qwe = new Folder(lvKontrol1.ListViewFolderLeft.Path);
                Folder f1 = lvKontrol1.GetParentFolder();
                Folder f2 = lvKontrol2.GetParentFolder();
                qwe.Replace(lvKontrol2.ListViewFolderRight.Path + "/" + lvKontrol1.ListViewFolderLeft.Name);
                
                lvKontrol1.FilList(f1);
                lvKontrol2.FilList(f2);
                lvKontrol1.LvSel = false;
                lvKontrol2.LvSel = false;
            }
            else
            {
                var qwe = new UltimateFilesHurricaneManagerClassLibrary.File(lvKontrol1.ListViewFileLeft.Path);
                Folder f1 = lvKontrol1.GetParentFolder();
                Folder f2 = lvKontrol2.GetParentFolder();
                qwe.Copy();
                lvKontrol1.FilList(f1);
                lvKontrol2.FilList(f2);
                lvKontrol1.LvSel = false;
                lvKontrol2.LvSel = false;
            }
        }
        private void btn_Replace_Click(object sender, EventArgs e)
        {
            if ((lvKontrol1.LvSel==true)&&(lvKontrol2.LvSel==true))
            {
                if ((lvKontrol1.ListViewFolderLeft != null) && (lvKontrol1.ListViewFileLeft == null))
                {
                    var qwe = new Folder(lvKontrol1.ListViewFolderLeft.Path);
                    Folder f1 = lvKontrol1.GetParentFolder();
                    Folder f2 = lvKontrol2.GetParentFolder();
                    qwe.Replace(lvKontrol2.ListViewFolderRight.Path + "/" + lvKontrol1.ListViewFolderLeft.Name);
                    lvKontrol1.FilList(f1);
                    lvKontrol2.FilList(f2);
                    lvKontrol1.LvSel = false;
                    lvKontrol2.LvSel = false;
                }
                else
                {
                    var qwe = new UltimateFilesHurricaneManagerClassLibrary.File(lvKontrol1.ListViewFileLeft.Path);
                    Folder f1 = lvKontrol1.GetParentFolder();
                    Folder f2 = lvKontrol2.GetParentFolder();
                    qwe.Replace(lvKontrol2.ListViewFolderRight.Path + "/" + lvKontrol1.ListViewFileLeft.Name);
                    lvKontrol1.FilList(f1);
                    lvKontrol2.FilList(f2);
                    lvKontrol1.LvSel = false;
                    lvKontrol2.LvSel = false;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if ((lvKontrol1.LvSel==true)&&(lvKontrol2.LvSel==false))
            {
                if ((lvKontrol1.ListViewFolderLeft!=null)&&(lvKontrol1.ListViewFileLeft==null))
                {
                    var qwe = new Folder(lvKontrol1.ListViewFolderLeft.Path);
                    Folder f1 = lvKontrol1.GetParentFolder();
                    qwe.Remove();
                    lvKontrol1.FilList(f1);
                    lvKontrol1.LvSel = false;
                }
                else
                {
                    var qwe = new UltimateFilesHurricaneManagerClassLibrary.File(lvKontrol1.ListViewFileLeft.Path);
                    Folder f1 = lvKontrol1.GetParentFolder();
                    qwe.Remove();
                    lvKontrol1.FilList(f1);
                    lvKontrol1.LvSel = false;
                }
            }
            else
            {
                if ((lvKontrol2.ListViewFolderRight != null) && (lvKontrol2.ListViewFileRight == null))
                {
                    var qwe = new Folder(lvKontrol2.ListViewFolderRight.Path);
                    Folder f1 = lvKontrol2.GetParentFolder();
                    qwe.Remove();
                    lvKontrol2.FilList(f1);
                    lvKontrol2.LvSel = false;
                }
                else
                {
                    var qwe = new UltimateFilesHurricaneManagerClassLibrary.File(lvKontrol2.ListViewFileRight.Path);
                    Folder f1 = lvKontrol2.GetParentFolder();
                    qwe.Remove();
                    lvKontrol2.FilList(f1);
                    lvKontrol2.LvSel = false;
                }
            }
        }

        private void btn_FromLeft_Click(object sender, EventArgs e)
        {
            if ((lvKontrol1.ListViewFolderLeft != null) && (lvKontrol1.ListViewFileLeft == null))
            {
                var qwe = new Folder(lvKontrol1.ListViewFolderLeft.Path);
                Folder f1 = lvKontrol1.GetParentFolder();
                Folder f2 = lvKontrol2.GetParentFolder();
                qwe.Replace(lvKontrol2.ListViewFolderRight.Path + "/" + lvKontrol1.ListViewFolderLeft.Name);
                lvKontrol1.FilList(f1);
                lvKontrol2.FilList(f2);
                lvKontrol1.LvSel = false;
                lvKontrol2.LvSel = false;
            }
            else
            {
                var qwe = new UltimateFilesHurricaneManagerClassLibrary.File(lvKontrol1.ListViewFileLeft.Path);
                Folder f1 = lvKontrol1.GetParentFolder();
                Folder f2 = lvKontrol2.GetParentFolder();
                qwe.Replace(lvKontrol2.ListViewFolderRight.Path + @"\" + lvKontrol1.ListViewFileLeft.Name);
                lvKontrol1.FilList(f1);
                lvKontrol2.FilList(f2);
                lvKontrol1.LvSel = false;
                lvKontrol2.LvSel = false;
            }
        }
        private void btn_FromRight_Click(object sender, EventArgs e)
        {
            if ((lvKontrol2.ListViewFolderRight != null) && (lvKontrol2.ListViewFileRight == null))
            {
                var qwe = new Folder(lvKontrol2.ListViewFolderRight.Path);
                Folder f1 = lvKontrol2.GetParentFolder();
                Folder f2 = lvKontrol1.GetParentFolder();
                qwe.Replace(lvKontrol1.ListViewFolderLeft.Path + "/" + lvKontrol2.ListViewFolderRight.Name);
                lvKontrol1.FilList(f2);
                lvKontrol2.FilList(f1);
                lvKontrol1.LvSel = false;
                lvKontrol2.LvSel = false;
            }
            else
            {
                var qwe = new UltimateFilesHurricaneManagerClassLibrary.File(lvKontrol2.ListViewFileRight.Path);
                Folder f1 = lvKontrol2.GetParentFolder();
                Folder f2 = lvKontrol1.GetParentFolder();
                qwe.Replace(lvKontrol1.ListViewFolderLeft.Path + "/" + lvKontrol2.ListViewFileRight.Name);
                lvKontrol1.FilList(f2);
                lvKontrol2.FilList(f1);
                lvKontrol1.LvSel = false;
                lvKontrol2.LvSel = false;
            }
        }

        private void btn_CopyFromLeft_Click(object sender, EventArgs e)
        {

        }
        private void btn_CopyFromRight_Click(object sender, EventArgs e)
        {

        }
    }
}
