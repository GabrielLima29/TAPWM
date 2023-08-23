namespace Pclasse
{
    partial class frnMensalista2
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
            this.button2 = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnNÃO = new System.Windows.Forms.RadioButton();
            this.rbtnSIM = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 92);
            this.button2.TabIndex = 38;
            this.button2.Text = "Instanciar Mensalista passando parâmetro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(76, 305);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(133, 92);
            this.t.TabIndex = 37;
            this.t.Text = "Instanciar Mensalista";
            this.t.UseVisualStyleBackColor = true;
            this.t.Click += new System.EventHandler(this.T_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Trabalha em Home Office?";
            // 
            // rbtnNÃO
            // 
            this.rbtnNÃO.AutoSize = true;
            this.rbtnNÃO.Location = new System.Drawing.Point(568, 168);
            this.rbtnNÃO.Name = "rbtnNÃO";
            this.rbtnNÃO.Size = new System.Drawing.Size(68, 24);
            this.rbtnNÃO.TabIndex = 35;
            this.rbtnNÃO.TabStop = true;
            this.rbtnNÃO.Text = "NÃO";
            this.rbtnNÃO.UseVisualStyleBackColor = true;
            // 
            // rbtnSIM
            // 
            this.rbtnSIM.AutoSize = true;
            this.rbtnSIM.Location = new System.Drawing.Point(568, 138);
            this.rbtnSIM.Name = "rbtnSIM";
            this.rbtnSIM.Size = new System.Drawing.Size(63, 24);
            this.rbtnSIM.TabIndex = 34;
            this.rbtnSIM.TabStop = true;
            this.rbtnSIM.Text = "SIM";
            this.rbtnSIM.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(245, 226);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 26);
            this.txtData.TabIndex = 33;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(245, 167);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 26);
            this.txtSalario.TabIndex = 32;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(245, 112);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 26);
            this.txtNome.TabIndex = 31;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(245, 53);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 26);
            this.txtMatricula.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Data Entrada na Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Salário Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Matrícula";
            // 
            // frnMensalista2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtnNÃO);
            this.Controls.Add(this.rbtnSIM);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frnMensalista2";
            this.Text = "frnMensalista2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnNÃO;
        private System.Windows.Forms.RadioButton rbtnSIM;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}