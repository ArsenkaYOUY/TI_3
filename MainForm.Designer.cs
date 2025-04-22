namespace timb3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numP = new System.Windows.Forms.NumericUpDown();
            this.numQ = new System.Windows.Forms.NumericUpDown();
            this.numE = new System.Windows.Forms.NumericUpDown();
            this.txtD = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnOpenEncrypt = new System.Windows.Forms.Button();
            this.btnOpenDecrypt = new System.Windows.Forms.Button();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblFR = new System.Windows.Forms.Label();
            this.btnSaveDec = new System.Windows.Forms.Button();
            this.lblRValue = new System.Windows.Forms.Label();
            this.lblFValue = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveEn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE)).BeginInit();
            this.SuspendLayout();
            // 
            // numP
            // 
            this.numP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numP.Location = new System.Drawing.Point(850, 77);
            this.numP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numP.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numP.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numP.Name = "numP";
            this.numP.Size = new System.Drawing.Size(150, 29);
            this.numP.TabIndex = 0;
            this.numP.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numQ
            // 
            this.numQ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numQ.Location = new System.Drawing.Point(850, 123);
            this.numQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numQ.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numQ.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numQ.Name = "numQ";
            this.numQ.Size = new System.Drawing.Size(150, 29);
            this.numQ.TabIndex = 1;
            this.numQ.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numE
            // 
            this.numE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numE.Location = new System.Drawing.Point(850, 162);
            this.numE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numE.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numE.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numE.Name = "numE";
            this.numE.Size = new System.Drawing.Size(150, 29);
            this.numE.TabIndex = 2;
            this.numE.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtD.Enabled = false;
            this.txtD.Location = new System.Drawing.Point(850, 247);
            this.txtD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(149, 29);
            this.txtD.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(850, 203);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 31);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Расчитать";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnOpenEncrypt
            // 
            this.btnOpenEncrypt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenEncrypt.Location = new System.Drawing.Point(354, 14);
            this.btnOpenEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenEncrypt.Name = "btnOpenEncrypt";
            this.btnOpenEncrypt.Size = new System.Drawing.Size(250, 31);
            this.btnOpenEncrypt.TabIndex = 6;
            this.btnOpenEncrypt.Text = "Зашифровать файл";
            this.btnOpenEncrypt.UseVisualStyleBackColor = false;
            this.btnOpenEncrypt.Click += new System.EventHandler(this.btnOpenEncrypt_Click);
            // 
            // btnOpenDecrypt
            // 
            this.btnOpenDecrypt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenDecrypt.Location = new System.Drawing.Point(642, 15);
            this.btnOpenDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenDecrypt.Name = "btnOpenDecrypt";
            this.btnOpenDecrypt.Size = new System.Drawing.Size(261, 31);
            this.btnOpenDecrypt.TabIndex = 7;
            this.btnOpenDecrypt.Text = "Расшифровать файл";
            this.btnOpenDecrypt.UseVisualStyleBackColor = false;
            this.btnOpenDecrypt.Click += new System.EventHandler(this.btnOpenDecrypt_Click);
            // 
            // txtIn
            // 
            this.txtIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIn.Location = new System.Drawing.Point(13, 73);
            this.txtIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.ReadOnly = true;
            this.txtIn.Size = new System.Drawing.Size(698, 225);
            this.txtIn.TabIndex = 8;
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOut.Location = new System.Drawing.Point(491, 371);
            this.txtOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(698, 230);
            this.txtOut.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(822, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "E";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(822, 250);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(20, 22);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "D";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(1021, 85);
            this.lblR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(30, 22);
            this.lblR.TabIndex = 18;
            this.lblR.Text = "R=";
            // 
            // lblFR
            // 
            this.lblFR.AutoSize = true;
            this.lblFR.Location = new System.Drawing.Point(1021, 130);
            this.lblFR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFR.Name = "lblFR";
            this.lblFR.Size = new System.Drawing.Size(60, 22);
            this.lblFR.TabIndex = 19;
            this.lblFR.Text = "F(R)=";
            // 
            // btnSaveDec
            // 
            this.btnSaveDec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveDec.Location = new System.Drawing.Point(13, 308);
            this.btnSaveDec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveDec.Name = "btnSaveDec";
            this.btnSaveDec.Size = new System.Drawing.Size(150, 31);
            this.btnSaveDec.TabIndex = 20;
            this.btnSaveDec.Text = "Сохранить";
            this.btnSaveDec.UseVisualStyleBackColor = false;
            this.btnSaveDec.Click += new System.EventHandler(this.btnSaveDec_Click);
            // 
            // lblRValue
            // 
            this.lblRValue.AutoSize = true;
            this.lblRValue.Location = new System.Drawing.Point(1080, 85);
            this.lblRValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRValue.Name = "lblRValue";
            this.lblRValue.Size = new System.Drawing.Size(20, 22);
            this.lblRValue.TabIndex = 21;
            this.lblRValue.Text = "0";
            // 
            // lblFValue
            // 
            this.lblFValue.AutoSize = true;
            this.lblFValue.Location = new System.Drawing.Point(1080, 131);
            this.lblFValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFValue.Name = "lblFValue";
            this.lblFValue.Size = new System.Drawing.Size(20, 22);
            this.lblFValue.TabIndex = 22;
            this.lblFValue.Text = "0";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnSaveEn
            // 
            this.btnSaveEn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveEn.Location = new System.Drawing.Point(491, 604);
            this.btnSaveEn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveEn.Name = "btnSaveEn";
            this.btnSaveEn.Size = new System.Drawing.Size(150, 31);
            this.btnSaveEn.TabIndex = 23;
            this.btnSaveEn.Text = "Сохранить";
            this.btnSaveEn.UseVisualStyleBackColor = false;
            this.btnSaveEn.Click += new System.EventHandler(this.btnSaveEn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Расшифрованный";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1049, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Зашифрованный";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1202, 648);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveEn);
            this.Controls.Add(this.lblFValue);
            this.Controls.Add(this.lblRValue);
            this.Controls.Add(this.btnSaveDec);
            this.Controls.Add(this.lblFR);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.btnOpenDecrypt);
            this.Controls.Add(this.btnOpenEncrypt);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.numE);
            this.Controls.Add(this.numQ);
            this.Controls.Add(this.numP);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "СуперШифратор";
            ((System.ComponentModel.ISupportInitialize)(this.numP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numP;
        private System.Windows.Forms.NumericUpDown numQ;
        private System.Windows.Forms.NumericUpDown numE;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnOpenEncrypt;
        private System.Windows.Forms.Button btnOpenDecrypt;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblFR;
        private System.Windows.Forms.Button btnSaveDec;
        private System.Windows.Forms.Label lblRValue;
        private System.Windows.Forms.Label lblFValue;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnSaveEn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

