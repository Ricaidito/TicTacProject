
namespace TicTacProject
{
    partial class MenuApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnMP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TicTacToe Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSP
            // 
            this.btnSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSP.Location = new System.Drawing.Point(57, 64);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(107, 43);
            this.btnSP.TabIndex = 1;
            this.btnSP.Text = "Singleplayer";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMP
            // 
            this.btnMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMP.Location = new System.Drawing.Point(57, 123);
            this.btnMP.Name = "btnMP";
            this.btnMP.Size = new System.Drawing.Size(107, 43);
            this.btnMP.TabIndex = 2;
            this.btnMP.Text = "Multiplayer";
            this.btnMP.UseVisualStyleBackColor = true;
            this.btnMP.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQ.Location = new System.Drawing.Point(57, 182);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(107, 43);
            this.btnQ.TabIndex = 3;
            this.btnQ.Text = "Salir";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Creado por: Ricardo Arturo";
            // 
            // MenuApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnMP);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToeGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuApp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnMP;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Label label2;
    }
}

