namespace ConsultaDePesssoas
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
            this.codigoInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idadeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.lerBtn = new System.Windows.Forms.Button();
            this.deletarBtn = new System.Windows.Forms.Button();
            this.sexoInput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // codigoInput
            // 
            this.codigoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoInput.Location = new System.Drawing.Point(165, 55);
            this.codigoInput.Name = "codigoInput";
            this.codigoInput.Size = new System.Drawing.Size(241, 44);
            this.codigoInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome:";
            // 
            // nomeInput
            // 
            this.nomeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeInput.Location = new System.Drawing.Point(165, 120);
            this.nomeInput.Name = "nomeInput";
            this.nomeInput.Size = new System.Drawing.Size(241, 44);
            this.nomeInput.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Idade:";
            // 
            // idadeInput
            // 
            this.idadeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeInput.Location = new System.Drawing.Point(165, 247);
            this.idadeInput.Name = "idadeInput";
            this.idadeInput.Size = new System.Drawing.Size(241, 44);
            this.idadeInput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo:";
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarBtn.Location = new System.Drawing.Point(12, 332);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(169, 47);
            this.cadastrarBtn.TabIndex = 10;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // lerBtn
            // 
            this.lerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lerBtn.Location = new System.Drawing.Point(201, 332);
            this.lerBtn.Name = "lerBtn";
            this.lerBtn.Size = new System.Drawing.Size(82, 47);
            this.lerBtn.TabIndex = 11;
            this.lerBtn.Text = "Ler";
            this.lerBtn.UseVisualStyleBackColor = true;
            this.lerBtn.Click += new System.EventHandler(this.lerBtn_Click);
            // 
            // deletarBtn
            // 
            this.deletarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletarBtn.Location = new System.Drawing.Point(299, 332);
            this.deletarBtn.Name = "deletarBtn";
            this.deletarBtn.Size = new System.Drawing.Size(130, 47);
            this.deletarBtn.TabIndex = 12;
            this.deletarBtn.Text = "Deletar";
            this.deletarBtn.UseVisualStyleBackColor = true;
            this.deletarBtn.Click += new System.EventHandler(this.deletarBtn_Click);
            // 
            // sexoInput
            // 
            this.sexoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoInput.FormattingEnabled = true;
            this.sexoInput.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexoInput.Location = new System.Drawing.Point(165, 185);
            this.sexoInput.Name = "sexoInput";
            this.sexoInput.Size = new System.Drawing.Size(241, 33);
            this.sexoInput.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 418);
            this.Controls.Add(this.sexoInput);
            this.Controls.Add(this.deletarBtn);
            this.Controls.Add(this.lerBtn);
            this.Controls.Add(this.cadastrarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idadeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigoInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idadeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button lerBtn;
        private System.Windows.Forms.Button deletarBtn;
        private System.Windows.Forms.ComboBox sexoInput;
    }
}

