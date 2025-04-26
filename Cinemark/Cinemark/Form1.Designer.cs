namespace Cinemark
{
    partial class Form1
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
            this.Faturamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Faturamento
            // 
            this.Faturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faturamento.Location = new System.Drawing.Point(366, 846);
            this.Faturamento.Name = "Faturamento";
            this.Faturamento.Size = new System.Drawing.Size(215, 46);
            this.Faturamento.TabIndex = 0;
            this.Faturamento.Text = "Faturamento";
            this.Faturamento.UseVisualStyleBackColor = true;
            this.Faturamento.Click += new System.EventHandler(this.Faturamento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 904);
            this.Controls.Add(this.Faturamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Faturamento;
    }
}

