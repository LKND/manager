namespace MainForm
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_FromLeft = new System.Windows.Forms.Button();
            this.btn_FromRight = new System.Windows.Forms.Button();
            this.lvKontrol1 = new MainForm.LVKontrol(this.components);
            this.lvKontrol2 = new MainForm.LVKontrol(this.components);
            this.btn_CopyFromLeft = new System.Windows.Forms.Button();
            this.btn_CopyFromRight = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CopyFromRight);
            this.panel1.Controls.Add(this.btn_CopyFromLeft);
            this.panel1.Controls.Add(this.btn_FromRight);
            this.panel1.Controls.Add(this.btn_FromLeft);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Replace);
            this.panel1.Controls.Add(this.btn_Copy);
            this.panel1.Controls.Add(this.btn_Open);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 126);
            this.panel1.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(346, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(93, 27);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Replace
            // 
            this.btn_Replace.Location = new System.Drawing.Point(234, 12);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(92, 27);
            this.btn_Replace.TabIndex = 2;
            this.btn_Replace.Text = "Переместить";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(122, 12);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(95, 28);
            this.btn_Copy.TabIndex = 1;
            this.btn_Copy.Text = "Копировать";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(12, 12);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(95, 28);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Открыть";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 544);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(626, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 126);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvKontrol1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvKontrol2);
            this.splitContainer1.Size = new System.Drawing.Size(626, 418);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_FromLeft
            // 
            this.btn_FromLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_FromLeft.Location = new System.Drawing.Point(12, 46);
            this.btn_FromLeft.Name = "btn_FromLeft";
            this.btn_FromLeft.Size = new System.Drawing.Size(128, 29);
            this.btn_FromLeft.TabIndex = 4;
            this.btn_FromLeft.Text = "Переместить >>";
            this.btn_FromLeft.UseVisualStyleBackColor = true;
            this.btn_FromLeft.Click += new System.EventHandler(this.btn_FromLeft_Click);
            // 
            // btn_FromRight
            // 
            this.btn_FromRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_FromRight.Location = new System.Drawing.Point(494, 46);
            this.btn_FromRight.Name = "btn_FromRight";
            this.btn_FromRight.Size = new System.Drawing.Size(120, 29);
            this.btn_FromRight.TabIndex = 5;
            this.btn_FromRight.Text = "<< Переместить";
            this.btn_FromRight.UseVisualStyleBackColor = true;
            this.btn_FromRight.Click += new System.EventHandler(this.btn_FromRight_Click);
            // 
            // lvKontrol1
            // 
            this.lvKontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKontrol1.ListViewFileLeft = null;
            this.lvKontrol1.ListViewFileRight = null;
            this.lvKontrol1.ListViewFolderLeft = null;
            this.lvKontrol1.ListViewFolderRight = null;
            this.lvKontrol1.Location = new System.Drawing.Point(0, 0);
            this.lvKontrol1.LvSel = false;
            this.lvKontrol1.Name = "lvKontrol1";
            this.lvKontrol1.Size = new System.Drawing.Size(312, 418);
            this.lvKontrol1.TabIndex = 0;
            // 
            // lvKontrol2
            // 
            this.lvKontrol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKontrol2.ListViewFileLeft = null;
            this.lvKontrol2.ListViewFileRight = null;
            this.lvKontrol2.ListViewFolderLeft = null;
            this.lvKontrol2.ListViewFolderRight = null;
            this.lvKontrol2.Location = new System.Drawing.Point(0, 0);
            this.lvKontrol2.LvSel = false;
            this.lvKontrol2.Name = "lvKontrol2";
            this.lvKontrol2.Size = new System.Drawing.Size(310, 418);
            this.lvKontrol2.TabIndex = 0;
            // 
            // btn_CopyFromLeft
            // 
            this.btn_CopyFromLeft.Location = new System.Drawing.Point(12, 81);
            this.btn_CopyFromLeft.Name = "btn_CopyFromLeft";
            this.btn_CopyFromLeft.Size = new System.Drawing.Size(128, 29);
            this.btn_CopyFromLeft.TabIndex = 6;
            this.btn_CopyFromLeft.Text = "Копировать >>";
            this.btn_CopyFromLeft.UseVisualStyleBackColor = true;
            this.btn_CopyFromLeft.Click += new System.EventHandler(this.btn_CopyFromLeft_Click);
            // 
            // btn_CopyFromRight
            // 
            this.btn_CopyFromRight.Location = new System.Drawing.Point(494, 81);
            this.btn_CopyFromRight.Name = "btn_CopyFromRight";
            this.btn_CopyFromRight.Size = new System.Drawing.Size(120, 29);
            this.btn_CopyFromRight.TabIndex = 7;
            this.btn_CopyFromRight.Text = "<< Копировать";
            this.btn_CopyFromRight.UseVisualStyleBackColor = true;
            this.btn_CopyFromRight.Click += new System.EventHandler(this.btn_CopyFromRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 567);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Open;
        private LVKontrol lvKontrol1;
        private LVKontrol lvKontrol2;
        private System.Windows.Forms.Button btn_FromRight;
        private System.Windows.Forms.Button btn_FromLeft;
        private System.Windows.Forms.Button btn_CopyFromRight;
        private System.Windows.Forms.Button btn_CopyFromLeft;
    }
}

