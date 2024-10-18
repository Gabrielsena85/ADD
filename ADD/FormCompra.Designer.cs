namespace ADD
{
    partial class FormCompra
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBoxNomedoProduto = new ComboBox();
            comboBoxFonecedorP = new ComboBox();
            numericUpDownQuantidadeP = new NumericUpDown();
            numericUpDownDescontoP = new NumericUpDown();
            textBoxPrecoU = new TextBox();
            textBoxValorT = new TextBox();
            textBoxTotalD = new TextBox();
            button0OK = new Button();
            button0Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidadeP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDescontoP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 59);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 96);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 131);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Desconto (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 189);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 169);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 5;
            label6.Text = "Preço Unitário:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 207);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 6;
            label7.Text = "Valor Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 245);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 7;
            label8.Text = "Total Com Desconto:";
            // 
            // comboBoxNomedoProduto
            // 
            comboBoxNomedoProduto.FormattingEnabled = true;
            comboBoxNomedoProduto.Location = new Point(183, 27);
            comboBoxNomedoProduto.Name = "comboBoxNomedoProduto";
            comboBoxNomedoProduto.Size = new Size(121, 23);
            comboBoxNomedoProduto.TabIndex = 8;
            // 
            // comboBoxFonecedorP
            // 
            comboBoxFonecedorP.FormattingEnabled = true;
            comboBoxFonecedorP.Location = new Point(183, 59);
            comboBoxFonecedorP.Name = "comboBoxFonecedorP";
            comboBoxFonecedorP.Size = new Size(121, 23);
            comboBoxFonecedorP.TabIndex = 9;
            // 
            // numericUpDownQuantidadeP
            // 
            numericUpDownQuantidadeP.Location = new Point(183, 94);
            numericUpDownQuantidadeP.Name = "numericUpDownQuantidadeP";
            numericUpDownQuantidadeP.Size = new Size(120, 23);
            numericUpDownQuantidadeP.TabIndex = 10;
            // 
            // numericUpDownDescontoP
            // 
            numericUpDownDescontoP.DecimalPlaces = 2;
            numericUpDownDescontoP.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownDescontoP.Location = new Point(183, 123);
            numericUpDownDescontoP.Name = "numericUpDownDescontoP";
            numericUpDownDescontoP.Size = new Size(120, 23);
            numericUpDownDescontoP.TabIndex = 11;
            // 
            // textBoxPrecoU
            // 
            textBoxPrecoU.BackColor = SystemColors.ControlDark;
            textBoxPrecoU.ForeColor = SystemColors.Window;
            textBoxPrecoU.Location = new Point(183, 161);
            textBoxPrecoU.Name = "textBoxPrecoU";
            textBoxPrecoU.ReadOnly = true;
            textBoxPrecoU.Size = new Size(120, 23);
            textBoxPrecoU.TabIndex = 12;
            // 
            // textBoxValorT
            // 
            textBoxValorT.BackColor = SystemColors.ControlDark;
            textBoxValorT.ForeColor = SystemColors.Window;
            textBoxValorT.Location = new Point(183, 199);
            textBoxValorT.Name = "textBoxValorT";
            textBoxValorT.ReadOnly = true;
            textBoxValorT.Size = new Size(120, 23);
            textBoxValorT.TabIndex = 13;
            // 
            // textBoxTotalD
            // 
            textBoxTotalD.BackColor = SystemColors.ControlDark;
            textBoxTotalD.ForeColor = SystemColors.Window;
            textBoxTotalD.Location = new Point(183, 237);
            textBoxTotalD.Name = "textBoxTotalD";
            textBoxTotalD.ReadOnly = true;
            textBoxTotalD.Size = new Size(121, 23);
            textBoxTotalD.TabIndex = 14;
            // 
            // button0OK
            // 
            button0OK.Location = new Point(55, 304);
            button0OK.Name = "button0OK";
            button0OK.Size = new Size(75, 23);
            button0OK.TabIndex = 15;
            button0OK.Text = "Ok";
            button0OK.UseVisualStyleBackColor = true;
            button0OK.Click += button0OK_Click;
            // 
            // button0Cancelar
            // 
            button0Cancelar.Location = new Point(255, 304);
            button0Cancelar.Name = "button0Cancelar";
            button0Cancelar.Size = new Size(75, 23);
            button0Cancelar.TabIndex = 16;
            button0Cancelar.Text = "Cancelar";
            button0Cancelar.UseVisualStyleBackColor = true;
            button0Cancelar.Click += button0Cancelar_Click;
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 450);
            Controls.Add(button0Cancelar);
            Controls.Add(button0OK);
            Controls.Add(textBoxTotalD);
            Controls.Add(textBoxValorT);
            Controls.Add(textBoxPrecoU);
            Controls.Add(numericUpDownDescontoP);
            Controls.Add(numericUpDownQuantidadeP);
            Controls.Add(comboBoxFonecedorP);
            Controls.Add(comboBoxNomedoProduto);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCompra";
            Text = "FormCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidadeP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDescontoP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxNomedoProduto;
        private ComboBox comboBoxFonecedorP;
        private NumericUpDown numericUpDownQuantidadeP;
        private NumericUpDown numericUpDownDescontoP;
        private TextBox textBoxPrecoU;
        private TextBox textBoxValorT;
        private TextBox textBoxTotalD;
        private Button button0OK;
        private Button button0Cancelar;
    }
}