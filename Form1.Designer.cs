namespace PictureViewer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Previous = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Music = new System.Windows.Forms.Button();
            this.Films = new System.Windows.Forms.Button();
            this.Photos = new System.Windows.Forms.Button();
            this.musicFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.filmsBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.photoBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ControlPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 378);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(3, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Show_Controls);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.DimGray;
            this.ControlPanel.Controls.Add(this.Previous);
            this.ControlPanel.Controls.Add(this.Play);
            this.ControlPanel.Controls.Add(this.Next);
            this.ControlPanel.Controls.Add(this.Music);
            this.ControlPanel.Controls.Add(this.Films);
            this.ControlPanel.Controls.Add(this.Photos);
            this.ControlPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ControlPanel.Location = new System.Drawing.Point(3, 3);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(628, 28);
            this.ControlPanel.TabIndex = 1;
            this.ControlPanel.Click += new System.EventHandler(this.Show_Controls);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(3, 3);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "<<";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(84, 3);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 2;
            this.Play.Text = "|>";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click_1);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(165, 3);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = ">>";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click_1);
            // 
            // Music
            // 
            this.Music.Location = new System.Drawing.Point(246, 3);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(75, 23);
            this.Music.TabIndex = 4;
            this.Music.Text = "Music";
            this.Music.UseVisualStyleBackColor = true;
            this.Music.Click += new System.EventHandler(this.Music_Click);
            // 
            // Films
            // 
            this.Films.Location = new System.Drawing.Point(327, 3);
            this.Films.Name = "Films";
            this.Films.Size = new System.Drawing.Size(75, 23);
            this.Films.TabIndex = 5;
            this.Films.Text = "Films";
            this.Films.UseVisualStyleBackColor = true;
            this.Films.Click += new System.EventHandler(this.Films_Click);
            // 
            // Photos
            // 
            this.Photos.Location = new System.Drawing.Point(408, 3);
            this.Photos.Name = "Photos";
            this.Photos.Size = new System.Drawing.Size(75, 23);
            this.Photos.TabIndex = 6;
            this.Photos.Text = "Photos";
            this.Photos.UseVisualStyleBackColor = true;
            this.Photos.Click += new System.EventHandler(this.Photos_Click);
            // 
            // musicFolderDialog
            // 
            this.musicFolderDialog.RootFolder = System.Environment.SpecialFolder.MyMusic;
            this.musicFolderDialog.ShowNewFolderButton = false;
            this.musicFolderDialog.HelpRequest += new System.EventHandler(this.musicFolderDialog_HelpRequest);
            // 
            // filmsBrowserDialog
            // 
            this.filmsBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyVideos;
            this.filmsBrowserDialog.HelpRequest += new System.EventHandler(this.filmsBrowserDialog_HelpRequest);
            // 
            // photoBrowserDialog
            // 
            this.photoBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyPictures;
            this.photoBrowserDialog.HelpRequest += new System.EventHandler(this.photoBrowserDialog_HelpRequest);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 378);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FolderBrowserDialog musicFolderDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel ControlPanel;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Music;
        private System.Windows.Forms.Button Films;
        private System.Windows.Forms.Button Photos;
        private System.Windows.Forms.FolderBrowserDialog filmsBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog photoBrowserDialog;
        private System.Windows.Forms.Timer timer1;
    }
}

