namespace MultiMediaApp_LA3
{
    partial class MultiMediaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiMediaForm));
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRunSound = new System.Windows.Forms.Button();
            this.btnSystemSounds = new System.Windows.Forms.Button();
            this.btnStopSound = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnPlayMP3 = new System.Windows.Forms.Button();
            this.btnStopMP3 = new System.Windows.Forms.Button();
            this.btnPlayVideo = new System.Windows.Forms.Button();
            this.btnPauseVideo = new System.Windows.Forms.Button();
            this.btnStopVideo = new System.Windows.Forms.Button();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenImage
            // 
            resources.ApplyResources(this.btnOpenImage, "btnOpenImage");
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnRunSound
            // 
            resources.ApplyResources(this.btnRunSound, "btnRunSound");
            this.btnRunSound.Name = "btnRunSound";
            this.btnRunSound.UseVisualStyleBackColor = true;
            this.btnRunSound.Click += new System.EventHandler(this.btnRunSound_Click);
            // 
            // btnSystemSounds
            // 
            resources.ApplyResources(this.btnSystemSounds, "btnSystemSounds");
            this.btnSystemSounds.Name = "btnSystemSounds";
            this.btnSystemSounds.UseVisualStyleBackColor = true;
            this.btnSystemSounds.Click += new System.EventHandler(this.btnSystemSounds_Click);
            // 
            // btnStopSound
            // 
            resources.ApplyResources(this.btnStopSound, "btnStopSound");
            this.btnStopSound.Name = "btnStopSound";
            this.btnStopSound.UseVisualStyleBackColor = true;
            this.btnStopSound.Click += new System.EventHandler(this.btnStopSound_Click);
            // 
            // btnPlay
            // 
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnPlayMP3
            // 
            resources.ApplyResources(this.btnPlayMP3, "btnPlayMP3");
            this.btnPlayMP3.Name = "btnPlayMP3";
            this.btnPlayMP3.UseVisualStyleBackColor = true;
            this.btnPlayMP3.Click += new System.EventHandler(this.btnPlayMP3_Click);
            // 
            // btnStopMP3
            // 
            resources.ApplyResources(this.btnStopMP3, "btnStopMP3");
            this.btnStopMP3.Name = "btnStopMP3";
            this.btnStopMP3.UseVisualStyleBackColor = true;
            this.btnStopMP3.Click += new System.EventHandler(this.btnStopMP3_Click);
            // 
            // btnPlayVideo
            // 
            resources.ApplyResources(this.btnPlayVideo, "btnPlayVideo");
            this.btnPlayVideo.Name = "btnPlayVideo";
            this.btnPlayVideo.UseVisualStyleBackColor = true;
            this.btnPlayVideo.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // btnPauseVideo
            // 
            resources.ApplyResources(this.btnPauseVideo, "btnPauseVideo");
            this.btnPauseVideo.Name = "btnPauseVideo";
            this.btnPauseVideo.UseVisualStyleBackColor = true;
            this.btnPauseVideo.Click += new System.EventHandler(this.btnPauseVideo_Click);
            // 
            // btnStopVideo
            // 
            resources.ApplyResources(this.btnStopVideo, "btnStopVideo");
            this.btnStopVideo.Name = "btnStopVideo";
            this.btnStopVideo.UseVisualStyleBackColor = true;
            this.btnStopVideo.Click += new System.EventHandler(this.btnStopVideo_Click);
            // 
            // btnOpenVideo
            // 
            resources.ApplyResources(this.btnOpenVideo, "btnOpenVideo");
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            resources.GetString("comboBoxLanguage.Items"),
            resources.GetString("comboBoxLanguage.Items1")});
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            // 
            // WindowsMediaPlayer
            // 
            resources.ApplyResources(this.WindowsMediaPlayer, "WindowsMediaPlayer");
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            // 
            // MultiMediaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.btnOpenVideo);
            this.Controls.Add(this.btnStopVideo);
            this.Controls.Add(this.btnPauseVideo);
            this.Controls.Add(this.btnPlayVideo);
            this.Controls.Add(this.btnStopMP3);
            this.Controls.Add(this.btnPlayMP3);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStopSound);
            this.Controls.Add(this.btnSystemSounds);
            this.Controls.Add(this.btnRunSound);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenImage);
            this.MaximizeBox = false;
            this.Name = "MultiMediaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRunSound;
        private System.Windows.Forms.Button btnSystemSounds;
        private System.Windows.Forms.Button btnStopSound;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBrowse;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Button btnPlayMP3;
        private System.Windows.Forms.Button btnStopMP3;
        private System.Windows.Forms.Button btnPlayVideo;
        private System.Windows.Forms.Button btnPauseVideo;
        private System.Windows.Forms.Button btnStopVideo;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelLanguage;
    }
}

