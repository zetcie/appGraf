namespace Appv2
{
    partial class form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.playVideo = new System.Windows.Forms.Button();
            this.listOfSigns = new System.Windows.Forms.ComboBox();
            this.addSign = new System.Windows.Forms.Button();
            this.deleteSign = new System.Windows.Forms.Button();
            this.stopVideo = new System.Windows.Forms.Button();
            this.loadVideo = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.addText = new System.Windows.Forms.Button();
            this.deleteText = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadText = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // playVideo
            // 
            this.playVideo.BackColor = System.Drawing.Color.Salmon;
            this.playVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.playVideo, "playVideo");
            this.playVideo.Name = "playVideo";
            this.playVideo.UseVisualStyleBackColor = false;
            this.playVideo.Click += new System.EventHandler(this.playVideo_Click);
            // 
            // listOfSigns
            // 
            this.listOfSigns.BackColor = System.Drawing.Color.Beige;
            this.listOfSigns.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.listOfSigns, "listOfSigns");
            this.listOfSigns.FormattingEnabled = true;
            this.listOfSigns.Items.AddRange(new object[] {
            resources.GetString("listOfSigns.Items"),
            resources.GetString("listOfSigns.Items1"),
            resources.GetString("listOfSigns.Items2"),
            resources.GetString("listOfSigns.Items3")});
            this.listOfSigns.Name = "listOfSigns";
            this.listOfSigns.SelectionChangeCommitted += new System.EventHandler(this.listOfSigns_SelectionChangeCommitted);
            // 
            // addSign
            // 
            this.addSign.BackColor = System.Drawing.Color.Salmon;
            this.addSign.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.addSign, "addSign");
            this.addSign.Name = "addSign";
            this.addSign.UseVisualStyleBackColor = false;
            this.addSign.Click += new System.EventHandler(this.addSign_Click);
            // 
            // deleteSign
            // 
            this.deleteSign.BackColor = System.Drawing.Color.Salmon;
            this.deleteSign.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.deleteSign, "deleteSign");
            this.deleteSign.Name = "deleteSign";
            this.deleteSign.UseVisualStyleBackColor = false;
            this.deleteSign.Click += new System.EventHandler(this.deleteSign_Click);
            // 
            // stopVideo
            // 
            this.stopVideo.BackColor = System.Drawing.Color.Salmon;
            this.stopVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.stopVideo, "stopVideo");
            this.stopVideo.Name = "stopVideo";
            this.stopVideo.UseVisualStyleBackColor = false;
            this.stopVideo.Click += new System.EventHandler(this.stopVideo_Click);
            // 
            // loadVideo
            // 
            this.loadVideo.BackColor = System.Drawing.Color.Salmon;
            this.loadVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadVideo.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.loadVideo, "loadVideo");
            this.loadVideo.ForeColor = System.Drawing.Color.Black;
            this.loadVideo.Name = "loadVideo";
            this.loadVideo.UseVisualStyleBackColor = false;
            this.loadVideo.Click += new System.EventHandler(this.loadVideo_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.MistyRose;
            resources.ApplyResources(this.videoSourcePlayer1, "videoSourcePlayer1");
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // addText
            // 
            this.addText.BackColor = System.Drawing.Color.Salmon;
            this.addText.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.addText, "addText");
            this.addText.Name = "addText";
            this.addText.UseVisualStyleBackColor = false;
            this.addText.Click += new System.EventHandler(this.addText_Click);
            // 
            // deleteText
            // 
            this.deleteText.BackColor = System.Drawing.Color.Salmon;
            this.deleteText.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.deleteText, "deleteText");
            this.deleteText.Name = "deleteText";
            this.deleteText.UseVisualStyleBackColor = false;
            this.deleteText.Click += new System.EventHandler(this.deleteText_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadText
            // 
            this.loadText.BackColor = System.Drawing.Color.Salmon;
            this.loadText.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.loadText, "loadText");
            this.loadText.Name = "loadText";
            this.loadText.UseVisualStyleBackColor = false;
            this.loadText.Click += new System.EventHandler(this.loadText_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.loadVideo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteText, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.loadText, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.addText, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.playVideo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.stopVideo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.listOfSigns, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.deleteSign, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.addSign, 0, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Name = "label3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Appv2.Properties.Resources.zom;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.videoSourcePlayer1, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playVideo;
        private System.Windows.Forms.ComboBox listOfSigns;
        private System.Windows.Forms.Button addSign;
        private System.Windows.Forms.Button deleteSign;
        private System.Windows.Forms.Button stopVideo;
        private System.Windows.Forms.Button loadVideo;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button addText;
        private System.Windows.Forms.Button deleteText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button loadText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

