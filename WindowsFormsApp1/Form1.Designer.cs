
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(16, 23);
            this.textBoxEntrada.Multiline = true;
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEntrada.Size = new System.Drawing.Size(565, 129);
            this.textBoxEntrada.TabIndex = 0;
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaida.Location = new System.Drawing.Point(16, 190);
            this.textBoxSaida.Multiline = true;
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSaida.Size = new System.Drawing.Size(565, 138);
            this.textBoxSaida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saída";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Processar Extrato da Rico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSaida);
            this.Controls.Add(this.textBoxEntrada);
            this.Name = "Form1";
            this.Text = "Extrato da Rico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.TextBox textBoxSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

