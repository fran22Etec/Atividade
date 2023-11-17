
namespace Atividade
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
            this.estadonascimento = new System.Windows.Forms.ComboBox();
            this.solteiro = new System.Windows.Forms.RadioButton();
            this.nome = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viuvo = new System.Windows.Forms.RadioButton();
            this.divorciado = new System.Windows.Forms.RadioButton();
            this.casado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // estadonascimento
            // 
            this.estadonascimento.FormattingEnabled = true;
            this.estadonascimento.Items.AddRange(new object[] {
            "",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "São Paulo (SP)"});
            this.estadonascimento.Location = new System.Drawing.Point(63, 141);
            this.estadonascimento.Name = "estadonascimento";
            this.estadonascimento.Size = new System.Drawing.Size(121, 21);
            this.estadonascimento.TabIndex = 1;
            this.estadonascimento.Text = "Estado Nascimento";
            this.estadonascimento.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // solteiro
            // 
            this.solteiro.AutoSize = true;
            this.solteiro.Location = new System.Drawing.Point(64, 254);
            this.solteiro.Name = "solteiro";
            this.solteiro.Size = new System.Drawing.Size(60, 17);
            this.solteiro.TabIndex = 2;
            this.solteiro.TabStop = true;
            this.solteiro.Text = "Solteiro";
            this.solteiro.UseVisualStyleBackColor = true;
            this.solteiro.CheckedChanged += new System.EventHandler(this.estadocivil_CheckedChanged);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(61, 33);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(41, 13);
            this.nome.TabIndex = 4;
            this.nome.Text = "Nome :";
            this.nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(62, 81);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(30, 13);
            this.cpf.TabIndex = 5;
            this.cpf.Text = "CPF:";
            this.cpf.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // viuvo
            // 
            this.viuvo.AutoSize = true;
            this.viuvo.Location = new System.Drawing.Point(64, 323);
            this.viuvo.Name = "viuvo";
            this.viuvo.Size = new System.Drawing.Size(52, 17);
            this.viuvo.TabIndex = 8;
            this.viuvo.TabStop = true;
            this.viuvo.Text = "Viúvo";
            this.viuvo.UseVisualStyleBackColor = true;
            // 
            // divorciado
            // 
            this.divorciado.AutoSize = true;
            this.divorciado.Location = new System.Drawing.Point(64, 300);
            this.divorciado.Name = "divorciado";
            this.divorciado.Size = new System.Drawing.Size(76, 17);
            this.divorciado.TabIndex = 9;
            this.divorciado.TabStop = true;
            this.divorciado.Text = "Divorciado";
            this.divorciado.UseVisualStyleBackColor = true;
            // 
            // casado
            // 
            this.casado.AutoSize = true;
            this.casado.Location = new System.Drawing.Point(64, 277);
            this.casado.Name = "casado";
            this.casado.Size = new System.Drawing.Size(61, 17);
            this.casado.TabIndex = 10;
            this.casado.TabStop = true;
            this.casado.Text = "Casado";
            this.casado.UseVisualStyleBackColor = true;
            this.casado.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(65, 97);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Estado Civil";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(66, 203);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.casado);
            this.Controls.Add(this.divorciado);
            this.Controls.Add(this.viuvo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.solteiro);
            this.Controls.Add(this.estadonascimento);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox estadonascimento;
        private System.Windows.Forms.RadioButton solteiro;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton viuvo;
        private System.Windows.Forms.RadioButton divorciado;
        private System.Windows.Forms.RadioButton casado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

