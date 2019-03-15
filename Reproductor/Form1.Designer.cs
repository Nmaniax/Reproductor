namespace Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textAlbum = new System.Windows.Forms.TextBox();
            this.textArtist = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.listViewSongs = new System.Windows.Forms.ListView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(288, 182);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(38, 36);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(332, 182);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(390, 182);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 36);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(434, 182);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(38, 36);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textGenre);
            this.groupBox1.Controls.Add(this.textYear);
            this.groupBox1.Controls.Add(this.textAlbum);
            this.groupBox1.Controls.Add(this.textArtist);
            this.groupBox1.Controls.Add(this.labelGenre);
            this.groupBox1.Controls.Add(this.labelYear);
            this.groupBox1.Controls.Add(this.labelAlbum);
            this.groupBox1.Controls.Add(this.labelArtist);
            this.groupBox1.Location = new System.Drawing.Point(228, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(51, 103);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(218, 20);
            this.textGenre.TabIndex = 7;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(51, 76);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(218, 20);
            this.textYear.TabIndex = 6;
            // 
            // textAlbum
            // 
            this.textAlbum.Location = new System.Drawing.Point(51, 50);
            this.textAlbum.Name = "textAlbum";
            this.textAlbum.Size = new System.Drawing.Size(218, 20);
            this.textAlbum.TabIndex = 5;
            // 
            // textArtist
            // 
            this.textArtist.Location = new System.Drawing.Point(51, 24);
            this.textArtist.Name = "textArtist";
            this.textArtist.Size = new System.Drawing.Size(218, 20);
            this.textArtist.TabIndex = 4;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(6, 103);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(42, 13);
            this.labelGenre.TabIndex = 3;
            this.labelGenre.Text = "Genero";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(8, 79);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(26, 13);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Año";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(8, 52);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(36, 13);
            this.labelAlbum.TabIndex = 1;
            this.labelAlbum.Text = "Album";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(6, 27);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(36, 13);
            this.labelArtist.TabIndex = 0;
            this.labelArtist.Text = "Artista";
            // 
            // listViewSongs
            // 
            this.listViewSongs.Location = new System.Drawing.Point(12, 37);
            this.listViewSongs.Name = "listViewSongs";
            this.listViewSongs.Size = new System.Drawing.Size(210, 333);
            this.listViewSongs.TabIndex = 8;
            this.listViewSongs.UseCompatibleStateImageBehavior = false;
            this.listViewSongs.SelectedIndexChanged += new System.EventHandler(this.listViewSongs_SelectedIndexChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(48, 376);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(134, 47);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Reproductor.Properties.Resources.Start;
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(360, 255);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(38, 36);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::Reproductor.Properties.Resources.pause1;
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(404, 255);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(38, 36);
            this.btnPause.TabIndex = 11;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(316, 255);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(38, 36);
            this.btnStop.TabIndex = 10;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 447);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.listViewSongs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textAlbum;
        private System.Windows.Forms.TextBox textArtist;
        private System.Windows.Forms.ListView listViewSongs;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
    }
}

