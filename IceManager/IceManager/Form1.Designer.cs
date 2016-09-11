namespace IceManager
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Play = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurrentTrackInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.Current = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentTrack = new System.Windows.Forms.ToolStripStatusLabel();
            this.PlayingMusic = new System.Windows.Forms.ToolStripStatusLabel();
            this.Stop = new System.Windows.Forms.Button();
            this.CurrentArtist = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentAlbum = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Play.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Play.Location = new System.Drawing.Point(12, 12);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(220, 77);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrevButton.ForeColor = System.Drawing.Color.Aqua;
            this.PrevButton.Location = new System.Drawing.Point(12, 178);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(220, 77);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NextButton.ForeColor = System.Drawing.Color.Aqua;
            this.NextButton.Location = new System.Drawing.Point(12, 261);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(220, 77);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentTrackInfo,
            this.Current,
            this.CurrentArtist,
            this.CurrentAlbum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(822, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // CurrentTrackInfo
            // 
            this.CurrentTrackInfo.ForeColor = System.Drawing.Color.White;
            this.CurrentTrackInfo.Name = "CurrentTrackInfo";
            this.CurrentTrackInfo.Size = new System.Drawing.Size(59, 17);
            this.CurrentTrackInfo.Text = "Wating...";
            // 
            // Current
            // 
            this.Current.ForeColor = System.Drawing.Color.White;
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(87, 17);
            this.Current.Text = "CurrentTrack ";
            // 
            // CurrentTrack
            // 
            this.CurrentTrack.ForeColor = System.Drawing.Color.White;
            this.CurrentTrack.Name = "CurrentTrack";
            this.CurrentTrack.Size = new System.Drawing.Size(96, 17);
            this.CurrentTrack.Text = "CurrentTrack : ";
            // 
            // PlayingMusic
            // 
            this.PlayingMusic.Name = "PlayingMusic";
            this.PlayingMusic.Size = new System.Drawing.Size(0, 17);
            // 
            // Stop
            // 
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Stop.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Stop.Location = new System.Drawing.Point(12, 95);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(220, 77);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Pause";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // CurrentArtist
            // 
            this.CurrentArtist.ForeColor = System.Drawing.Color.White;
            this.CurrentArtist.Name = "CurrentArtist";
            this.CurrentArtist.Size = new System.Drawing.Size(43, 17);
            this.CurrentArtist.Text = "Artist ";
            // 
            // CurrentAlbum
            // 
            this.CurrentAlbum.ForeColor = System.Drawing.Color.White;
            this.CurrentAlbum.Name = "CurrentAlbum";
            this.CurrentAlbum.Size = new System.Drawing.Size(44, 17);
            this.CurrentAlbum.Text = "Album";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(822, 373);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.Play);
            this.Name = "Form1";
            this.Text = "iTunes COM for CSharp";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ToolStripStatusLabel CurrentTrack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel PlayingMusic;
        private System.Windows.Forms.ToolStripStatusLabel CurrentTrackInfo;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ToolStripStatusLabel Current;
        private System.Windows.Forms.ToolStripStatusLabel CurrentArtist;
        private System.Windows.Forms.ToolStripStatusLabel CurrentAlbum;
    }
}

