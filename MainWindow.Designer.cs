namespace PDFCombiner
{
    partial class PDFCombiner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFCombiner));
            this.filesList = new System.Windows.Forms.DataGridView();
            this.filePath = new System.Windows.Forms.TextBox();
            this.setPath = new System.Windows.Forms.Button();
            this.addFileToDataGrid = new System.Windows.Forms.Button();
            this.makePDF = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybierzPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.połączPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.clearList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filesList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesList
            // 
            this.filesList.AllowUserToAddRows = false;
            this.filesList.AllowUserToDeleteRows = false;
            this.filesList.BackgroundColor = System.Drawing.Color.LightCoral;
            this.filesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.filesList, "filesList");
            this.filesList.Name = "filesList";
            this.filesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filesList_CellContentClick);
            // 
            // filePath
            // 
            resources.ApplyResources(this.filePath, "filePath");
            this.filePath.Name = "filePath";
            // 
            // setPath
            // 
            this.setPath.BackColor = System.Drawing.Color.Red;
            this.setPath.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.setPath, "setPath");
            this.setPath.ForeColor = System.Drawing.SystemColors.Control;
            this.setPath.Name = "setPath";
            this.setPath.UseVisualStyleBackColor = false;
            this.setPath.Click += new System.EventHandler(this.setPath_Click);
            // 
            // addFileToDataGrid
            // 
            this.addFileToDataGrid.BackColor = System.Drawing.Color.Red;
            this.addFileToDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.addFileToDataGrid, "addFileToDataGrid");
            this.addFileToDataGrid.ForeColor = System.Drawing.SystemColors.Control;
            this.addFileToDataGrid.Name = "addFileToDataGrid";
            this.addFileToDataGrid.UseVisualStyleBackColor = false;
            this.addFileToDataGrid.Click += new System.EventHandler(this.addFileToDataGrid_Click);
            // 
            // makePDF
            // 
            this.makePDF.BackColor = System.Drawing.Color.Red;
            this.makePDF.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.makePDF, "makePDF");
            this.makePDF.ForeColor = System.Drawing.SystemColors.Control;
            this.makePDF.Name = "makePDF";
            this.makePDF.UseVisualStyleBackColor = false;
            this.makePDF.Click += new System.EventHandler(this.makePDF_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.połączPDFToolStripMenuItem,
            this.wyczyśćToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybierzPlikToolStripMenuItem,
            this.dodajPlikToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            resources.ApplyResources(this.plikToolStripMenuItem, "plikToolStripMenuItem");
            // 
            // wybierzPlikToolStripMenuItem
            // 
            this.wybierzPlikToolStripMenuItem.Name = "wybierzPlikToolStripMenuItem";
            resources.ApplyResources(this.wybierzPlikToolStripMenuItem, "wybierzPlikToolStripMenuItem");
            this.wybierzPlikToolStripMenuItem.Click += new System.EventHandler(this.wybierzPlikToolStripMenuItem_Click);
            // 
            // dodajPlikToolStripMenuItem
            // 
            this.dodajPlikToolStripMenuItem.Name = "dodajPlikToolStripMenuItem";
            resources.ApplyResources(this.dodajPlikToolStripMenuItem, "dodajPlikToolStripMenuItem");
            this.dodajPlikToolStripMenuItem.Click += new System.EventHandler(this.dodajPlikToolStripMenuItem_Click);
            // 
            // połączPDFToolStripMenuItem
            // 
            this.połączPDFToolStripMenuItem.Name = "połączPDFToolStripMenuItem";
            resources.ApplyResources(this.połączPDFToolStripMenuItem, "połączPDFToolStripMenuItem");
            this.połączPDFToolStripMenuItem.Click += new System.EventHandler(this.połączPDFToolStripMenuItem_Click);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            resources.ApplyResources(this.wyczyśćToolStripMenuItem, "wyczyśćToolStripMenuItem");
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title.Name = "title";
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.author, "author");
            this.author.ForeColor = System.Drawing.SystemColors.Control;
            this.author.Name = "author";
            this.author.UseVisualStyleBackColor = false;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // version
            // 
            resources.ApplyResources(this.version, "version");
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.version.ForeColor = System.Drawing.SystemColors.ControlText;
            this.version.Name = "version";
            // 
            // clearList
            // 
            this.clearList.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.clearList, "clearList");
            this.clearList.ForeColor = System.Drawing.SystemColors.Control;
            this.clearList.Name = "clearList";
            this.clearList.UseVisualStyleBackColor = false;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // PDFCombiner
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.makePDF);
            this.Controls.Add(this.addFileToDataGrid);
            this.Controls.Add(this.setPath);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "PDFCombiner";
            ((System.ComponentModel.ISupportInitialize)(this.filesList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filesList;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button setPath;
        private System.Windows.Forms.Button addFileToDataGrid;
        private System.Windows.Forms.Button makePDF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem połączPDFToolStripMenuItem;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ToolStripMenuItem wybierzPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPlikToolStripMenuItem;
        private System.Windows.Forms.Button author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.Button clearList;
    }
}

