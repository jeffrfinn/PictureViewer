namespace PictureViewer
{
    partial class MainScreen
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
            this.Viewer = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Previous = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Music = new System.Windows.Forms.Button();
            this.Films = new System.Windows.Forms.Button();
            this.Photos = new System.Windows.Forms.Button();
            this.musicFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.photoBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.filmsBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Viewer
            // 
            this.Viewer.BackColor = System.Drawing.Color.Black;
            this.Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer.Location = new System.Drawing.Point(0, 0);
            this.Viewer.Name = "Viewer";
            this.Viewer.Size = new System.Drawing.Size(917, 324);
            this.Viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Viewer.TabIndex = 0;
            this.Viewer.TabStop = false;
            this.Viewer.Click += new System.EventHandler(this.Show_Controls);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.ControlPanel.Controls.Add(this.Previous);
            this.ControlPanel.Controls.Add(this.Play);
            this.ControlPanel.Controls.Add(this.Next);
            this.ControlPanel.Controls.Add(this.Music);
            this.ControlPanel.Controls.Add(this.Films);
            this.ControlPanel.Controls.Add(this.Photos);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(917, 33);
            this.ControlPanel.TabIndex = 1;
            this.ControlPanel.Visible = false;
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(3, 3);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 7;
            this.Previous.Text = "<<";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(84, 3);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 8;
            this.Play.Text = "|>";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(165, 3);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 9;
            this.Next.Text = ">>";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Music
            // 
            this.Music.Location = new System.Drawing.Point(246, 3);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(75, 23);
            this.Music.TabIndex = 10;
            this.Music.Text = "Music";
            this.Music.UseVisualStyleBackColor = true;
            this.Music.Click += new System.EventHandler(this.Music_Click);
            // 
            // Films
            // 
            this.Films.Location = new System.Drawing.Point(327, 3);
            this.Films.Name = "Films";
            this.Films.Size = new System.Drawing.Size(75, 23);
            this.Films.TabIndex = 11;
            this.Films.Text = "Films";
            this.Films.UseVisualStyleBackColor = true;
            this.Films.Click += new System.EventHandler(this.Films_Click);
            // 
            // Photos
            // 
            this.Photos.Location = new System.Drawing.Point(408, 3);
            this.Photos.Name = "Photos";
            this.Photos.Size = new System.Drawing.Size(75, 23);
            this.Photos.TabIndex = 12;
            this.Photos.Text = "Photos";
            this.Photos.UseVisualStyleBackColor = true;
            this.Photos.Click += new System.EventHandler(this.Photos_Click);
            // 
            // musicFolderDialog
            // 
            this.musicFolderDialog.RootFolder = System.Environment.SpecialFolder.MyMusic;
            this.musicFolderDialog.ShowNewFolderButton = false;
            // 
            // photoBrowserDialog
            // 
            this.photoBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyPictures;
            // 
            // filmsBrowserDialog
            // 
            this.filmsBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyVideos;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(917, 324);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.Viewer);
            this.KeyPreview = true;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Viewer;
        private System.Windows.Forms.FlowLayoutPanel ControlPanel;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Music;
        private System.Windows.Forms.Button Films;
        private System.Windows.Forms.Button Photos;
        private System.Windows.Forms.FolderBrowserDialog musicFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog photoBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog filmsBrowserDialog;
        private System.Windows.Forms.Timer timer1;
    }
}