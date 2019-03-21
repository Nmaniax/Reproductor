namespace Reproductor
{
    partial class FindForm
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
            this.listViewSong1 = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewSong1
            // 
            this.listViewSong1.Location = new System.Drawing.Point(26, 33);
            this.listViewSong1.Name = "listViewSong1";
            this.listViewSong1.Size = new System.Drawing.Size(209, 289);
            this.listViewSong1.TabIndex = 4;
            this.listViewSong1.UseCompatibleStateImageBehavior = false;
            this.listViewSong1.SelectedIndexChanged += new System.EventHandler(this.listViewSong1_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(319, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(270, 105);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(180, 20);
            this.txtArtist.TabIndex = 0;
            this.txtArtist.TextChanged += new System.EventHandler(this.txtArtist_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda por artista";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listViewSong1);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSong1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label label1;
    }
}