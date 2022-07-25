namespace Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_queryRow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_rowSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_partno = new System.Windows.Forms.TextBox();
            this.richTextBox_barcode = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_execute = new System.Windows.Forms.Button();
            this.textBox_connectionStr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox_query = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_barcodeRem = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton_barcode = new System.Windows.Forms.RadioButton();
            this.button_barcodeGen = new System.Windows.Forms.Button();
            this.button_logoRemove = new System.Windows.Forms.Button();
            this.button_logo = new System.Windows.Forms.Button();
            this.richTextBox_setting = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_generate = new System.Windows.Forms.Button();
            this.pictureBox_barcode = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_queryRow);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox_rowSelect);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_partno);
            this.groupBox2.Controls.Add(this.richTextBox_barcode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.richTextBox_description);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button_execute);
            this.groupBox2.Controls.Add(this.textBox_connectionStr);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.richTextBox_query);
            this.groupBox2.Location = new System.Drawing.Point(12, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 601);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get data from DB";
            // 
            // label_queryRow
            // 
            this.label_queryRow.Location = new System.Drawing.Point(118, 182);
            this.label_queryRow.Name = "label_queryRow";
            this.label_queryRow.Size = new System.Drawing.Size(199, 20);
            this.label_queryRow.TabIndex = 13;
            this.label_queryRow.Text = "Get 0 rows from DB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "select row:";
            // 
            // comboBox_rowSelect
            // 
            this.comboBox_rowSelect.FormattingEnabled = true;
            this.comboBox_rowSelect.Location = new System.Drawing.Point(118, 226);
            this.comboBox_rowSelect.Name = "comboBox_rowSelect";
            this.comboBox_rowSelect.Size = new System.Drawing.Size(121, 23);
            this.comboBox_rowSelect.TabIndex = 11;
            this.comboBox_rowSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox_rowSelect_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Barcode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "partNo:";
            // 
            // textBox_partno
            // 
            this.textBox_partno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_partno.Location = new System.Drawing.Point(118, 408);
            this.textBox_partno.Name = "textBox_partno";
            this.textBox_partno.Size = new System.Drawing.Size(514, 16);
            this.textBox_partno.TabIndex = 8;
            // 
            // richTextBox_barcode
            // 
            this.richTextBox_barcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_barcode.Location = new System.Drawing.Point(118, 430);
            this.richTextBox_barcode.Name = "richTextBox_barcode";
            this.richTextBox_barcode.Size = new System.Drawing.Size(514, 165);
            this.richTextBox_barcode.TabIndex = 7;
            this.richTextBox_barcode.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Description:";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_description.Location = new System.Drawing.Point(118, 255);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(514, 147);
            this.richTextBox_description.TabIndex = 5;
            this.richTextBox_description.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Connection String:";
            // 
            // button_execute
            // 
            this.button_execute.Location = new System.Drawing.Point(533, 179);
            this.button_execute.Name = "button_execute";
            this.button_execute.Size = new System.Drawing.Size(99, 23);
            this.button_execute.TabIndex = 4;
            this.button_execute.Text = "Execute";
            this.button_execute.UseVisualStyleBackColor = true;
            this.button_execute.Click += new System.EventHandler(this.button_execute_Click);
            // 
            // textBox_connectionStr
            // 
            this.textBox_connectionStr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_connectionStr.Location = new System.Drawing.Point(118, 38);
            this.textBox_connectionStr.Name = "textBox_connectionStr";
            this.textBox_connectionStr.Size = new System.Drawing.Size(514, 16);
            this.textBox_connectionStr.TabIndex = 0;
            this.textBox_connectionStr.Text = "Server=ERPSERVER;Initial Catalog=infordb;Persist Security Info=True;User ID=sa;Pa" +
    "ssword=baan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Query:";
            // 
            // richTextBox_query
            // 
            this.richTextBox_query.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_query.Location = new System.Drawing.Point(118, 67);
            this.richTextBox_query.Name = "richTextBox_query";
            this.richTextBox_query.Size = new System.Drawing.Size(514, 106);
            this.richTextBox_query.TabIndex = 2;
            this.richTextBox_query.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.button_barcodeRem);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton_barcode);
            this.groupBox1.Controls.Add(this.button_barcodeGen);
            this.groupBox1.Controls.Add(this.button_logoRemove);
            this.groupBox1.Controls.Add(this.button_logo);
            this.groupBox1.Controls.Add(this.richTextBox_setting);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_generate);
            this.groupBox1.Controls.Add(this.pictureBox_barcode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox_logo);
            this.groupBox1.Controls.Add(this.pictureBox_preview);
            this.groupBox1.Location = new System.Drawing.Point(673, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 601);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make Label";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(517, 562);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(89, 33);
            this.button_open.TabIndex = 16;
            this.button_open.Text = "Save&&Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_barcodeRem
            // 
            this.button_barcodeRem.Location = new System.Drawing.Point(177, 539);
            this.button_barcodeRem.Name = "button_barcodeRem";
            this.button_barcodeRem.Size = new System.Drawing.Size(75, 23);
            this.button_barcodeRem.TabIndex = 15;
            this.button_barcodeRem.Text = "Remove";
            this.button_barcodeRem.UseVisualStyleBackColor = true;
            this.button_barcodeRem.Click += new System.EventHandler(this.button_barcodeRem_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(63, 539);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 19);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "qrcode";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton_barcode
            // 
            this.radioButton_barcode.AutoSize = true;
            this.radioButton_barcode.Checked = true;
            this.radioButton_barcode.Location = new System.Drawing.Point(63, 510);
            this.radioButton_barcode.Name = "radioButton_barcode";
            this.radioButton_barcode.Size = new System.Drawing.Size(68, 19);
            this.radioButton_barcode.TabIndex = 13;
            this.radioButton_barcode.TabStop = true;
            this.radioButton_barcode.Text = "barcode";
            this.radioButton_barcode.UseVisualStyleBackColor = true;
            // 
            // button_barcodeGen
            // 
            this.button_barcodeGen.Location = new System.Drawing.Point(177, 510);
            this.button_barcodeGen.Name = "button_barcodeGen";
            this.button_barcodeGen.Size = new System.Drawing.Size(75, 23);
            this.button_barcodeGen.TabIndex = 12;
            this.button_barcodeGen.Text = "Generate";
            this.button_barcodeGen.UseVisualStyleBackColor = true;
            this.button_barcodeGen.Click += new System.EventHandler(this.button_barcodeGen_Click);
            // 
            // button_logoRemove
            // 
            this.button_logoRemove.Location = new System.Drawing.Point(177, 353);
            this.button_logoRemove.Name = "button_logoRemove";
            this.button_logoRemove.Size = new System.Drawing.Size(75, 23);
            this.button_logoRemove.TabIndex = 11;
            this.button_logoRemove.Text = "Remove";
            this.button_logoRemove.UseVisualStyleBackColor = true;
            this.button_logoRemove.Click += new System.EventHandler(this.button_logoRemove_Click);
            // 
            // button_logo
            // 
            this.button_logo.Location = new System.Drawing.Point(63, 353);
            this.button_logo.Name = "button_logo";
            this.button_logo.Size = new System.Drawing.Size(75, 23);
            this.button_logo.TabIndex = 10;
            this.button_logo.Text = "Browse";
            this.button_logo.UseVisualStyleBackColor = true;
            this.button_logo.Click += new System.EventHandler(this.button_logo_Click);
            // 
            // richTextBox_setting
            // 
            this.richTextBox_setting.Location = new System.Drawing.Point(267, 234);
            this.richTextBox_setting.Name = "richTextBox_setting";
            this.richTextBox_setting.Size = new System.Drawing.Size(339, 322);
            this.richTextBox_setting.TabIndex = 9;
            this.richTextBox_setting.Text = resources.GetString("richTextBox_setting.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Barcode:";
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(367, 562);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(144, 33);
            this.button_generate.TabIndex = 7;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // pictureBox_barcode
            // 
            this.pictureBox_barcode.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_barcode.Location = new System.Drawing.Point(63, 389);
            this.pictureBox_barcode.Name = "pictureBox_barcode";
            this.pictureBox_barcode.Size = new System.Drawing.Size(189, 113);
            this.pictureBox_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_barcode.TabIndex = 4;
            this.pictureBox_barcode.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Logo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preview:";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_logo.Location = new System.Drawing.Point(63, 234);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(189, 113);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox_preview.Location = new System.Drawing.Point(63, 41);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(543, 184);
            this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_preview.TabIndex = 0;
            this.pictureBox_preview.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "select logo image";
            this.openFileDialog1.Filter = "PNG|*.png|All Files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG|*.png|All Files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Make Label";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private TextBox textBox_partno;
        private RichTextBox richTextBox_barcode;
        private Label label8;
        private RichTextBox richTextBox_description;
        private Label label9;
        private Button button_execute;
        private TextBox textBox_connectionStr;
        private Label label10;
        private RichTextBox richTextBox_query;
        private Label label_queryRow;
        private Label label1;
        private ComboBox comboBox_rowSelect;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox_logo;
        private PictureBox pictureBox_preview;
        private Label label4;
        private Button button_generate;
        private PictureBox pictureBox_barcode;
        private Button button_logoRemove;
        private Button button_logo;
        private RichTextBox richTextBox_setting;
        private Button button_barcodeRem;
        private RadioButton radioButton2;
        private RadioButton radioButton_barcode;
        private Button button_barcodeGen;
        private OpenFileDialog openFileDialog1;
        private Button button_open;
        private SaveFileDialog saveFileDialog1;
    }
}