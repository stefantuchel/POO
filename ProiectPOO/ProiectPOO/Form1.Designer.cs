
namespace VoicuStefanProiect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Clear_Project = new System.Windows.Forms.ToolStripButton();
            this.Savey = new System.Windows.Forms.ToolStripButton();
            this.Printy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.Fig_pick = new System.Windows.Forms.ToolStripComboBox();
            this.GoGO = new System.Windows.Forms.ToolStripButton();
            this.COL = new System.Windows.Forms.ToolStripButton();
            this.Filly = new System.Windows.Forms.ToolStripButton();
            this.Infoy = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Nr_fig = new System.Windows.Forms.ToolStripTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(695, 562);
            this.pic.TabIndex = 10;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clear_Project,
            this.Savey,
            this.Printy,
            this.toolStripButton4,
            this.Fig_pick,
            this.GoGO,
            this.COL,
            this.Filly,
            this.Infoy,
            this.toolStripLabel1,
            this.Nr_fig});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(695, 47);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Clear_Project
            // 
            this.Clear_Project.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Clear_Project.Image = ((System.Drawing.Image)(resources.GetObject("Clear_Project.Image")));
            this.Clear_Project.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear_Project.Name = "Clear_Project";
            this.Clear_Project.Size = new System.Drawing.Size(44, 44);
            this.Clear_Project.Text = "Clear";
            this.Clear_Project.Click += new System.EventHandler(this.Clear_Project_Click);
            // 
            // Savey
            // 
            this.Savey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Savey.Image = ((System.Drawing.Image)(resources.GetObject("Savey.Image")));
            this.Savey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Savey.Name = "Savey";
            this.Savey.Size = new System.Drawing.Size(44, 44);
            this.Savey.Text = "Save";
            this.Savey.Click += new System.EventHandler(this.Savey_Click);
            // 
            // Printy
            // 
            this.Printy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Printy.Image = ((System.Drawing.Image)(resources.GetObject("Printy.Image")));
            this.Printy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Printy.Name = "Printy";
            this.Printy.Size = new System.Drawing.Size(44, 44);
            this.Printy.Text = "Print";
            this.Printy.Click += new System.EventHandler(this.Printy_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Fig_pick
            // 
            this.Fig_pick.Items.AddRange(new object[] {
            "Linie",
            "Triunghi",
            "Dreptunghi",
            "Elipsa",
            "Curba Brazier"});
            this.Fig_pick.Name = "Fig_pick";
            this.Fig_pick.Size = new System.Drawing.Size(121, 47);
            this.Fig_pick.Click += new System.EventHandler(this.Fig_pick_Click);
            // 
            // GoGO
            // 
            this.GoGO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoGO.Image = ((System.Drawing.Image)(resources.GetObject("GoGO.Image")));
            this.GoGO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoGO.Name = "GoGO";
            this.GoGO.Size = new System.Drawing.Size(44, 44);
            this.GoGO.Text = "Start";
            this.GoGO.Click += new System.EventHandler(this.GoGO_Click);
            // 
            // COL
            // 
            this.COL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.COL.Image = ((System.Drawing.Image)(resources.GetObject("COL.Image")));
            this.COL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.COL.Name = "COL";
            this.COL.Size = new System.Drawing.Size(44, 44);
            this.COL.Text = "Choose Color";
            this.COL.Click += new System.EventHandler(this.COL_Click);
            // 
            // Filly
            // 
            this.Filly.BackColor = System.Drawing.Color.White;
            this.Filly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Filly.Image = ((System.Drawing.Image)(resources.GetObject("Filly.Image")));
            this.Filly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Filly.Name = "Filly";
            this.Filly.Size = new System.Drawing.Size(44, 44);
            this.Filly.Text = "Fill";
            this.Filly.Click += new System.EventHandler(this.Filly_Click);
            // 
            // Infoy
            // 
            this.Infoy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Infoy.Image = ((System.Drawing.Image)(resources.GetObject("Infoy.Image")));
            this.Infoy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Infoy.Name = "Infoy";
            this.Infoy.Size = new System.Drawing.Size(44, 44);
            this.Infoy.Text = "Info";
            this.Infoy.Click += new System.EventHandler(this.Infoy_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 44);
            this.toolStripLabel1.Text = "Nr.Figuri";
            // 
            // Nr_fig
            // 
            this.Nr_fig.Name = "Nr_fig";
            this.Nr_fig.Size = new System.Drawing.Size(100, 47);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tablou Abstract";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Clear_Project;
        private System.Windows.Forms.ToolStripButton Savey;
        private System.Windows.Forms.ToolStripButton Printy;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton GoGO;
        private System.Windows.Forms.ToolStripButton COL;
        private System.Windows.Forms.ToolStripButton Filly;
        private System.Windows.Forms.ToolStripButton Infoy;
        private System.Windows.Forms.ToolStripComboBox Fig_pick;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox Nr_fig;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

