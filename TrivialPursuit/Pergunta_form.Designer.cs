namespace TrivialPursuit
{
    partial class Pergunta_form
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
            this.Questao1 = new System.Windows.Forms.Label();
            this.resp_A = new System.Windows.Forms.Button();
            this.resp_B = new System.Windows.Forms.Button();
            this.resp_C = new System.Windows.Forms.Button();
            this.resp_D = new System.Windows.Forms.Button();
            this.categoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Questao1
            // 
            this.Questao1.AutoSize = true;
            this.Questao1.Location = new System.Drawing.Point(85, 39);
            this.Questao1.Name = "Questao1";
            this.Questao1.Size = new System.Drawing.Size(107, 13);
            this.Questao1.TabIndex = 0;
            this.Questao1.Text = "Isto é uma pergunta?";
            this.Questao1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resp_A
            // 
            this.resp_A.Location = new System.Drawing.Point(100, 85);
            this.resp_A.Name = "resp_A";
            this.resp_A.Size = new System.Drawing.Size(75, 23);
            this.resp_A.TabIndex = 1;
            this.resp_A.Text = "button1";
            this.resp_A.UseVisualStyleBackColor = true;
            this.resp_A.Click += new System.EventHandler(this.resp_A_Click);
            // 
            // resp_B
            // 
            this.resp_B.Location = new System.Drawing.Point(100, 135);
            this.resp_B.Name = "resp_B";
            this.resp_B.Size = new System.Drawing.Size(75, 23);
            this.resp_B.TabIndex = 2;
            this.resp_B.Text = "button2";
            this.resp_B.UseVisualStyleBackColor = true;
            this.resp_B.Click += new System.EventHandler(this.resp_B_Click);
            // 
            // resp_C
            // 
            this.resp_C.Location = new System.Drawing.Point(100, 191);
            this.resp_C.Name = "resp_C";
            this.resp_C.Size = new System.Drawing.Size(75, 23);
            this.resp_C.TabIndex = 3;
            this.resp_C.Text = "button3";
            this.resp_C.UseVisualStyleBackColor = true;
            this.resp_C.Click += new System.EventHandler(this.resp_C_Click);
            // 
            // resp_D
            // 
            this.resp_D.Location = new System.Drawing.Point(100, 242);
            this.resp_D.Name = "resp_D";
            this.resp_D.Size = new System.Drawing.Size(75, 23);
            this.resp_D.TabIndex = 4;
            this.resp_D.Text = "button4";
            this.resp_D.UseVisualStyleBackColor = true;
            this.resp_D.Click += new System.EventHandler(this.resp_D_Click);
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Location = new System.Drawing.Point(106, 9);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(52, 13);
            this.categoria.TabIndex = 5;
            this.categoria.Text = "Categoria";
            // 
            // Pergunta_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 310);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.resp_D);
            this.Controls.Add(this.resp_C);
            this.Controls.Add(this.resp_B);
            this.Controls.Add(this.resp_A);
            this.Controls.Add(this.Questao1);
            this.Name = "Pergunta_form";
            this.Text = "Pergunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Questao1;
        private System.Windows.Forms.Button resp_A;
        private System.Windows.Forms.Button resp_B;
        private System.Windows.Forms.Button resp_C;
        private System.Windows.Forms.Button resp_D;
        private System.Windows.Forms.Label categoria;
    }
}