namespace Hw6
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
            this.cbox_ShapeSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Para2 = new System.Windows.Forms.TextBox();
            this.txt_Para1 = new System.Windows.Forms.TextBox();
            this.lbl_Para2 = new System.Windows.Forms.Label();
            this.lbl_Para1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_MaterialSelect = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txt_Display = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AmountOfShape = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBSort = new System.Windows.Forms.ComboBox();
            this.rBtnAscent = new System.Windows.Forms.RadioButton();
            this.rBtnDescent = new System.Windows.Forms.RadioButton();
            this.btnConcern = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_ShapeSelect
            // 
            this.cbox_ShapeSelect.FormattingEnabled = true;
            this.cbox_ShapeSelect.Items.AddRange(new object[] {
            "球",
            "正方體",
            "圓柱體",
            "金字塔"});
            this.cbox_ShapeSelect.Location = new System.Drawing.Point(106, 21);
            this.cbox_ShapeSelect.Name = "cbox_ShapeSelect";
            this.cbox_ShapeSelect.Size = new System.Drawing.Size(185, 20);
            this.cbox_ShapeSelect.TabIndex = 0;
            this.cbox_ShapeSelect.SelectedIndexChanged += new System.EventHandler(this.cbox_ShapeSelect_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Para2);
            this.groupBox1.Controls.Add(this.txt_Para1);
            this.groupBox1.Controls.Add(this.lbl_Para2);
            this.groupBox1.Controls.Add(this.lbl_Para1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbox_ShapeSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "形狀設定";
            // 
            // txt_Para2
            // 
            this.txt_Para2.Location = new System.Drawing.Point(207, 65);
            this.txt_Para2.Name = "txt_Para2";
            this.txt_Para2.Size = new System.Drawing.Size(84, 22);
            this.txt_Para2.TabIndex = 5;
            this.txt_Para2.Text = "0";
            // 
            // txt_Para1
            // 
            this.txt_Para1.Location = new System.Drawing.Point(54, 65);
            this.txt_Para1.Name = "txt_Para1";
            this.txt_Para1.Size = new System.Drawing.Size(84, 22);
            this.txt_Para1.TabIndex = 4;
            this.txt_Para1.Text = "0";
            // 
            // lbl_Para2
            // 
            this.lbl_Para2.AutoSize = true;
            this.lbl_Para2.Location = new System.Drawing.Point(184, 68);
            this.lbl_Para2.Name = "lbl_Para2";
            this.lbl_Para2.Size = new System.Drawing.Size(17, 12);
            this.lbl_Para2.TabIndex = 3;
            this.lbl_Para2.Text = "高";
            // 
            // lbl_Para1
            // 
            this.lbl_Para1.AutoSize = true;
            this.lbl_Para1.Location = new System.Drawing.Point(19, 68);
            this.lbl_Para1.Name = "lbl_Para1";
            this.lbl_Para1.Size = new System.Drawing.Size(29, 12);
            this.lbl_Para1.TabIndex = 2;
            this.lbl_Para1.Text = "底邊";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "形狀類別";
            // 
            // cbox_MaterialSelect
            // 
            this.cbox_MaterialSelect.FormattingEnabled = true;
            this.cbox_MaterialSelect.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cbox_MaterialSelect.Location = new System.Drawing.Point(105, 21);
            this.cbox_MaterialSelect.Name = "cbox_MaterialSelect";
            this.cbox_MaterialSelect.Size = new System.Drawing.Size(185, 20);
            this.cbox_MaterialSelect.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbox_MaterialSelect);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "材質設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "材質類別";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(324, 19);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "計算";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txt_Display
            // 
            this.txt_Display.Location = new System.Drawing.Point(626, 48);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Display.Size = new System.Drawing.Size(374, 380);
            this.txt_Display.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 21);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "加入";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "數量";
            // 
            // txt_AmountOfShape
            // 
            this.txt_AmountOfShape.Location = new System.Drawing.Point(206, 21);
            this.txt_AmountOfShape.Name = "txt_AmountOfShape";
            this.txt_AmountOfShape.Size = new System.Drawing.Size(84, 22);
            this.txt_AmountOfShape.TabIndex = 8;
            this.txt_AmountOfShape.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Add);
            this.groupBox3.Controls.Add(this.txt_AmountOfShape);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "增加Shape";
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(13, 282);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Message.Size = new System.Drawing.Size(296, 146);
            this.txt_Message.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnConcern);
            this.groupBox4.Controls.Add(this.rBtnDescent);
            this.groupBox4.Controls.Add(this.rBtnAscent);
            this.groupBox4.Controls.Add(this.cBSort);
            this.groupBox4.Location = new System.Drawing.Point(324, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 135);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "排序";
            // 
            // cBSort
            // 
            this.cBSort.FormattingEnabled = true;
            this.cBSort.Items.AddRange(new object[] {
            "重量",
            "體積"});
            this.cBSort.Location = new System.Drawing.Point(140, 24);
            this.cBSort.Name = "cBSort";
            this.cBSort.Size = new System.Drawing.Size(121, 20);
            this.cBSort.TabIndex = 0;
            // 
            // rBtnAscent
            // 
            this.rBtnAscent.AutoSize = true;
            this.rBtnAscent.Location = new System.Drawing.Point(26, 64);
            this.rBtnAscent.Name = "rBtnAscent";
            this.rBtnAscent.Size = new System.Drawing.Size(47, 16);
            this.rBtnAscent.TabIndex = 1;
            this.rBtnAscent.TabStop = true;
            this.rBtnAscent.Text = "遞增";
            this.rBtnAscent.UseVisualStyleBackColor = true;
            // 
            // rBtnDescent
            // 
            this.rBtnDescent.AutoSize = true;
            this.rBtnDescent.Location = new System.Drawing.Point(140, 64);
            this.rBtnDescent.Name = "rBtnDescent";
            this.rBtnDescent.Size = new System.Drawing.Size(47, 16);
            this.rBtnDescent.TabIndex = 2;
            this.rBtnDescent.TabStop = true;
            this.rBtnDescent.Text = "遞減";
            this.rBtnDescent.UseVisualStyleBackColor = true;
            // 
            // btnConcern
            // 
            this.btnConcern.Location = new System.Drawing.Point(26, 97);
            this.btnConcern.Name = "btnConcern";
            this.btnConcern.Size = new System.Drawing.Size(75, 23);
            this.btnConcern.TabIndex = 3;
            this.btnConcern.Text = "確定";
            this.btnConcern.UseVisualStyleBackColor = true;
            this.btnConcern.Click += new System.EventHandler(this.btnConcern_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "排序方式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 482);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_Display);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "103Quiz5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_ShapeSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_MaterialSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Para2;
        private System.Windows.Forms.TextBox txt_Para1;
        private System.Windows.Forms.Label lbl_Para2;
        private System.Windows.Forms.Label lbl_Para1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txt_Display;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AmountOfShape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnConcern;
        private System.Windows.Forms.RadioButton rBtnDescent;
        private System.Windows.Forms.RadioButton rBtnAscent;
        private System.Windows.Forms.ComboBox cBSort;
        private System.Windows.Forms.Label label4;
    }
}

