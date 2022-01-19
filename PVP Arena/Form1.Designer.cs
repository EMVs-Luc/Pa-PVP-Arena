
namespace PVP_Arena
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.arenaInnen = new System.Windows.Forms.Panel();
            this.Player2 = new System.Windows.Forms.Panel();
            this.Player1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player1Inv3 = new System.Windows.Forms.Panel();
            this.player1Inv2 = new System.Windows.Forms.Panel();
            this.player1Inv1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.player2Inv3 = new System.Windows.Forms.Panel();
            this.player2Inv2 = new System.Windows.Forms.Panel();
            this.player2Inv1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.arenaInnen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.arenaInnen);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 590);
            this.panel1.TabIndex = 1;
            // 
            // arenaInnen
            // 
            this.arenaInnen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.arenaInnen.Controls.Add(this.Player2);
            this.arenaInnen.Controls.Add(this.Player1);
            this.arenaInnen.Location = new System.Drawing.Point(13, 14);
            this.arenaInnen.Name = "arenaInnen";
            this.arenaInnen.Size = new System.Drawing.Size(1219, 560);
            this.arenaInnen.TabIndex = 2;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Player2.Location = new System.Drawing.Point(1178, 14);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(29, 30);
            this.Player2.TabIndex = 1;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Aqua;
            this.Player1.Location = new System.Drawing.Point(17, 515);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(29, 30);
            this.Player1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.player1Inv3);
            this.panel2.Controls.Add(this.player1Inv2);
            this.panel2.Controls.Add(this.player1Inv1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(12, 646);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 91);
            this.panel2.TabIndex = 2;
            // 
            // player1Inv3
            // 
            this.player1Inv3.BackColor = System.Drawing.Color.Black;
            this.player1Inv3.Location = new System.Drawing.Point(178, 20);
            this.player1Inv3.Name = "player1Inv3";
            this.player1Inv3.Size = new System.Drawing.Size(58, 54);
            this.player1Inv3.TabIndex = 2;
            // 
            // player1Inv2
            // 
            this.player1Inv2.BackColor = System.Drawing.Color.Black;
            this.player1Inv2.Location = new System.Drawing.Point(96, 20);
            this.player1Inv2.Name = "player1Inv2";
            this.player1Inv2.Size = new System.Drawing.Size(58, 54);
            this.player1Inv2.TabIndex = 1;
            // 
            // player1Inv1
            // 
            this.player1Inv1.BackColor = System.Drawing.Color.Black;
            this.player1Inv1.Location = new System.Drawing.Point(13, 20);
            this.player1Inv1.Name = "player1Inv1";
            this.player1Inv1.Size = new System.Drawing.Size(58, 54);
            this.player1Inv1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(77, 85);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.player2Inv3);
            this.panel7.Controls.Add(this.player2Inv2);
            this.panel7.Controls.Add(this.player2Inv1);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Location = new System.Drawing.Point(999, 643);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 91);
            this.panel7.TabIndex = 4;
            // 
            // player2Inv3
            // 
            this.player2Inv3.BackColor = System.Drawing.Color.Black;
            this.player2Inv3.Location = new System.Drawing.Point(178, 20);
            this.player2Inv3.Name = "player2Inv3";
            this.player2Inv3.Size = new System.Drawing.Size(58, 54);
            this.player2Inv3.TabIndex = 2;
            // 
            // player2Inv2
            // 
            this.player2Inv2.BackColor = System.Drawing.Color.Black;
            this.player2Inv2.Location = new System.Drawing.Point(96, 20);
            this.player2Inv2.Name = "player2Inv2";
            this.player2Inv2.Size = new System.Drawing.Size(58, 54);
            this.player2Inv2.TabIndex = 1;
            // 
            // player2Inv1
            // 
            this.player2Inv1.BackColor = System.Drawing.Color.Black;
            this.player2Inv1.Location = new System.Drawing.Point(13, 20);
            this.player2Inv1.Name = "player2Inv1";
            this.player2Inv1.Size = new System.Drawing.Size(58, 54);
            this.player2Inv1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(77, 85);
            this.panel11.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1271, 749);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "PVP Arena";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.arenaInnen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.KeyDown += this.Form1_KeyDow;

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel arenaInnen;
        public System.Windows.Forms.Panel Player2;
        public  System.Windows.Forms.Panel Player1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel player1Inv3;
        private System.Windows.Forms.Panel player1Inv2;
        private System.Windows.Forms.Panel player1Inv1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel player2Inv3;
        private System.Windows.Forms.Panel player2Inv2;
        private System.Windows.Forms.Panel player2Inv1;
        private System.Windows.Forms.Panel panel11;
    }
}

