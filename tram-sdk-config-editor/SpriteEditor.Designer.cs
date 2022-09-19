namespace tram_sdk_config_editor
{
    partial class SpriteEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cont = new System.Windows.Forms.SplitContainer();
            this.allSpritesList = new System.Windows.Forms.ListBox();
            this.allSpritesListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCont = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.propCont = new System.Windows.Forms.SplitContainer();
            this.framesInSpriteList = new System.Windows.Forms.ListBox();
            this.framesInSpriteListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cont)).BeginInit();
            this.cont.Panel1.SuspendLayout();
            this.cont.Panel2.SuspendLayout();
            this.cont.SuspendLayout();
            this.allSpritesListMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editCont)).BeginInit();
            this.editCont.Panel1.SuspendLayout();
            this.editCont.Panel2.SuspendLayout();
            this.editCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propCont)).BeginInit();
            this.propCont.Panel2.SuspendLayout();
            this.propCont.SuspendLayout();
            this.framesInSpriteListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cont
            // 
            this.cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cont.Location = new System.Drawing.Point(0, 0);
            this.cont.Name = "cont";
            // 
            // cont.Panel1
            // 
            this.cont.Panel1.Controls.Add(this.allSpritesList);
            // 
            // cont.Panel2
            // 
            this.cont.Panel2.Controls.Add(this.editCont);
            this.cont.Size = new System.Drawing.Size(600, 480);
            this.cont.SplitterDistance = 200;
            this.cont.TabIndex = 0;
            // 
            // allSpritesList
            // 
            this.allSpritesList.ContextMenuStrip = this.allSpritesListMenu;
            this.allSpritesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSpritesList.FormattingEnabled = true;
            this.allSpritesList.Location = new System.Drawing.Point(0, 0);
            this.allSpritesList.Name = "allSpritesList";
            this.allSpritesList.Size = new System.Drawing.Size(200, 480);
            this.allSpritesList.TabIndex = 0;
            this.allSpritesList.SelectedIndexChanged += new System.EventHandler(this.allSpritesList_SelectedIndexChanged);
            // 
            // allSpritesListMenu
            // 
            this.allSpritesListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.allSpritesListMenu.Name = "allSpritesListMenu";
            this.allSpritesListMenu.Size = new System.Drawing.Size(122, 70);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // editCont
            // 
            this.editCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editCont.Location = new System.Drawing.Point(0, 0);
            this.editCont.Name = "editCont";
            this.editCont.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // editCont.Panel1
            // 
            this.editCont.Panel1.Controls.Add(this.pictureBox1);
            // 
            // editCont.Panel2
            // 
            this.editCont.Panel2.Controls.Add(this.propCont);
            this.editCont.Size = new System.Drawing.Size(396, 480);
            this.editCont.SplitterDistance = 332;
            this.editCont.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 332);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // propCont
            // 
            this.propCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propCont.Location = new System.Drawing.Point(0, 0);
            this.propCont.Name = "propCont";
            // 
            // propCont.Panel2
            // 
            this.propCont.Panel2.Controls.Add(this.framesInSpriteList);
            this.propCont.Size = new System.Drawing.Size(396, 144);
            this.propCont.SplitterDistance = 190;
            this.propCont.TabIndex = 0;
            // 
            // framesInSpriteList
            // 
            this.framesInSpriteList.ContextMenuStrip = this.framesInSpriteListMenu;
            this.framesInSpriteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.framesInSpriteList.FormattingEnabled = true;
            this.framesInSpriteList.Location = new System.Drawing.Point(0, 0);
            this.framesInSpriteList.Name = "framesInSpriteList";
            this.framesInSpriteList.Size = new System.Drawing.Size(202, 144);
            this.framesInSpriteList.TabIndex = 0;
            // 
            // framesInSpriteListMenu
            // 
            this.framesInSpriteListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.framesInSpriteListMenu.Name = "framesInSpriteListMenu";
            this.framesInSpriteListMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addNewToolStripMenuItem1.Text = "Add new";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // SpriteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cont);
            this.Name = "SpriteEditor";
            this.Size = new System.Drawing.Size(600, 480);
            this.cont.Panel1.ResumeLayout(false);
            this.cont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cont)).EndInit();
            this.cont.ResumeLayout(false);
            this.allSpritesListMenu.ResumeLayout(false);
            this.editCont.Panel1.ResumeLayout(false);
            this.editCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editCont)).EndInit();
            this.editCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.propCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propCont)).EndInit();
            this.propCont.ResumeLayout(false);
            this.framesInSpriteListMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer cont;
        private System.Windows.Forms.ListBox allSpritesList;
        private System.Windows.Forms.SplitContainer editCont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer propCont;
        private System.Windows.Forms.ListBox framesInSpriteList;
        private System.Windows.Forms.ContextMenuStrip allSpritesListMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip framesInSpriteListMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
    }
}
