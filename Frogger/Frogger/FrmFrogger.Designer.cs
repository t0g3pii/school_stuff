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
            this.lblPauseText = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.pnlPause.SuspendLayout();
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
            // FrmFrogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 301);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrGameTick;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPauseText;
    }
}

