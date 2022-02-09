namespace Frogger
{
    partial class FrmFrogger
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrGameTick = new System.Windows.Forms.Timer(this.components);
            this.pnlPause = new System.Windows.Forms.Panel();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPauseText = new System.Windows.Forms.Label();
            this.pnlHighscore = new System.Windows.Forms.Panel();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lbxHighscore = new System.Windows.Forms.ListBox();
            this.btnScoreSave = new System.Windows.Forms.Button();
            this.tbxHighscore = new System.Windows.Forms.TextBox();
            this.lblScoreBox = new System.Windows.Forms.Label();
            this.pnlPause.SuspendLayout();
            this.pnlHighscore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrGameTick
            // 
            this.tmrGameTick.Tick += new System.EventHandler(this.tmrGameTick_Tick);
            // 
            // pnlPause
            // 
            this.pnlPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPause.Controls.Add(this.btnResume);
            this.pnlPause.Controls.Add(this.btnExit);
            this.pnlPause.Controls.Add(this.lblPauseText);
            this.pnlPause.Enabled = false;
            this.pnlPause.Location = new System.Drawing.Point(118, 83);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(200, 100);
            this.pnlPause.TabIndex = 0;
            this.pnlPause.Visible = false;
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(102, 33);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(95, 64);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "Weiterspielen";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(3, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 64);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Spiel beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblPauseText
            // 
            this.lblPauseText.AutoSize = true;
            this.lblPauseText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseText.Location = new System.Drawing.Point(52, 11);
            this.lblPauseText.Name = "lblPauseText";
            this.lblPauseText.Size = new System.Drawing.Size(97, 19);
            this.lblPauseText.TabIndex = 0;
            this.lblPauseText.Text = "Spiel Pausiert";
            this.lblPauseText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHighscore
            // 
            this.pnlHighscore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHighscore.Controls.Add(this.lblScoreBox);
            this.pnlHighscore.Controls.Add(this.tbxHighscore);
            this.pnlHighscore.Controls.Add(this.btnScoreSave);
            this.pnlHighscore.Controls.Add(this.lbxHighscore);
            this.pnlHighscore.Controls.Add(this.lblHighscore);
            this.pnlHighscore.Enabled = false;
            this.pnlHighscore.Location = new System.Drawing.Point(118, 12);
            this.pnlHighscore.Name = "pnlHighscore";
            this.pnlHighscore.Size = new System.Drawing.Size(200, 277);
            this.pnlHighscore.TabIndex = 3;
            this.pnlHighscore.Visible = false;
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.Location = new System.Drawing.Point(62, 5);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(72, 19);
            this.lblHighscore.TabIndex = 0;
            this.lblHighscore.Text = "Highscore";
            this.lblHighscore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxHighscore
            // 
            this.lbxHighscore.FormattingEnabled = true;
            this.lbxHighscore.Location = new System.Drawing.Point(3, 28);
            this.lbxHighscore.Name = "lbxHighscore";
            this.lbxHighscore.Size = new System.Drawing.Size(192, 199);
            this.lbxHighscore.TabIndex = 1;
            // 
            // btnScoreSave
            // 
            this.btnScoreSave.Location = new System.Drawing.Point(132, 235);
            this.btnScoreSave.Name = "btnScoreSave";
            this.btnScoreSave.Size = new System.Drawing.Size(63, 37);
            this.btnScoreSave.TabIndex = 2;
            this.btnScoreSave.Text = "Speichern";
            this.btnScoreSave.UseVisualStyleBackColor = true;
            this.btnScoreSave.Click += new System.EventHandler(this.BtnScoreSave_Click);
            // 
            // tbxHighscore
            // 
            this.tbxHighscore.Location = new System.Drawing.Point(3, 252);
            this.tbxHighscore.Name = "tbxHighscore";
            this.tbxHighscore.Size = new System.Drawing.Size(124, 20);
            this.tbxHighscore.TabIndex = 3;
            this.tbxHighscore.Text = "Name eingeben";
            // 
            // lblScoreBox
            // 
            this.lblScoreBox.AutoSize = true;
            this.lblScoreBox.Location = new System.Drawing.Point(3, 236);
            this.lblScoreBox.Name = "lblScoreBox";
            this.lblScoreBox.Size = new System.Drawing.Size(38, 13);
            this.lblScoreBox.TabIndex = 4;
            this.lblScoreBox.Text = "Score:";
            // 
            // FrmFrogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 301);
            this.Controls.Add(this.pnlHighscore);
            this.Controls.Add(this.pnlPause);
            this.Location = new System.Drawing.Point(100, 150);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFrogger";
            this.Text = "Frogger";
            this.Load += new System.EventHandler(this.FrmFrogger_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmFrogger_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFrogger_KeyDown);
            this.Resize += new System.EventHandler(this.FrmFrogger_Resize);
            this.pnlPause.ResumeLayout(false);
            this.pnlPause.PerformLayout();
            this.pnlHighscore.ResumeLayout(false);
            this.pnlHighscore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrGameTick;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPauseText;
        private System.Windows.Forms.Panel pnlHighscore;
        private System.Windows.Forms.Label lblScoreBox;
        private System.Windows.Forms.TextBox tbxHighscore;
        private System.Windows.Forms.Button btnScoreSave;
        private System.Windows.Forms.ListBox lbxHighscore;
        private System.Windows.Forms.Label lblHighscore;
    }
}

