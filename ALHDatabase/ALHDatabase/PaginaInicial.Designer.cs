namespace ALHDatabase
{
    partial class PaginaInicial
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
            this.buttonAtualizarC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textPaisPI = new System.Windows.Forms.ComboBox();
            this.textPasswordPI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmailPI = new System.Windows.Forms.TextBox();
            this.textNomePI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApagarC = new System.Windows.Forms.Button();
            this.labelInfoPI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAtualizarC
            // 
            this.buttonAtualizarC.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizarC.Location = new System.Drawing.Point(152, 383);
            this.buttonAtualizarC.Name = "buttonAtualizarC";
            this.buttonAtualizarC.Size = new System.Drawing.Size(253, 56);
            this.buttonAtualizarC.TabIndex = 18;
            this.buttonAtualizarC.Text = "Atualizar Conta";
            this.buttonAtualizarC.UseVisualStyleBackColor = true;
            this.buttonAtualizarC.Click += new System.EventHandler(this.buttonAtualizarC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "País:";
            // 
            // textPaisPI
            // 
            this.textPaisPI.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPaisPI.FormattingEnabled = true;
            this.textPaisPI.Items.AddRange(new object[] {
            "Portugal",
            "França",
            "Espanha",
            "Brasil"});
            this.textPaisPI.Location = new System.Drawing.Point(152, 290);
            this.textPaisPI.Name = "textPaisPI";
            this.textPaisPI.Size = new System.Drawing.Size(172, 39);
            this.textPaisPI.TabIndex = 16;
            // 
            // textPasswordPI
            // 
            this.textPasswordPI.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPasswordPI.Location = new System.Drawing.Point(152, 223);
            this.textPasswordPI.Name = "textPasswordPI";
            this.textPasswordPI.Size = new System.Drawing.Size(275, 40);
            this.textPasswordPI.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "EMail:";
            // 
            // textEmailPI
            // 
            this.textEmailPI.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmailPI.Location = new System.Drawing.Point(152, 103);
            this.textEmailPI.Name = "textEmailPI";
            this.textEmailPI.Size = new System.Drawing.Size(275, 40);
            this.textEmailPI.TabIndex = 12;
            // 
            // textNomePI
            // 
            this.textNomePI.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomePI.Location = new System.Drawing.Point(152, 160);
            this.textNomePI.Name = "textNomePI";
            this.textNomePI.Size = new System.Drawing.Size(275, 40);
            this.textNomePI.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Atualizar Conta:";
            // 
            // buttonApagarC
            // 
            this.buttonApagarC.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagarC.Location = new System.Drawing.Point(443, 383);
            this.buttonApagarC.Name = "buttonApagarC";
            this.buttonApagarC.Size = new System.Drawing.Size(253, 56);
            this.buttonApagarC.TabIndex = 20;
            this.buttonApagarC.Text = "Apagar Conta";
            this.buttonApagarC.UseVisualStyleBackColor = true;
            this.buttonApagarC.Click += new System.EventHandler(this.buttonApagarC_Click);
            // 
            // labelInfoPI
            // 
            this.labelInfoPI.AutoSize = true;
            this.labelInfoPI.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoPI.Location = new System.Drawing.Point(332, 9);
            this.labelInfoPI.Name = "labelInfoPI";
            this.labelInfoPI.Size = new System.Drawing.Size(225, 40);
            this.labelInfoPI.TabIndex = 21;
            this.labelInfoPI.Text = "Conta de Nome";
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInfoPI);
            this.Controls.Add(this.buttonApagarC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAtualizarC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPaisPI);
            this.Controls.Add(this.textPasswordPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEmailPI);
            this.Controls.Add(this.textNomePI);
            this.Controls.Add(this.label2);
            this.Name = "PaginaInicial";
            this.Text = "PaginaInicial";
            this.Load += new System.EventHandler(this.PaginaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtualizarC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox textPaisPI;
        private System.Windows.Forms.TextBox textPasswordPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEmailPI;
        private System.Windows.Forms.TextBox textNomePI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApagarC;
        private System.Windows.Forms.Label labelInfoPI;
    }
}