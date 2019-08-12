namespace Ex1Cap5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numberPeopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.healthyOption = new System.Windows.Forms.CheckBox();
            this.fancyOption = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fancyBirthdayCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayCakeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.costBirthdayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfPeopleBirthday = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberPeopleUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(31, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Persons";
            // 
            // numberPeopleUpDown
            // 
            this.numberPeopleUpDown.Location = new System.Drawing.Point(34, 23);
            this.numberPeopleUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberPeopleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberPeopleUpDown.Name = "numberPeopleUpDown";
            this.numberPeopleUpDown.Size = new System.Drawing.Size(127, 20);
            this.numberPeopleUpDown.TabIndex = 1;
            this.numberPeopleUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberPeopleUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(61, 99);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(115, 23);
            this.costLabel.TabIndex = 5;
            // 
            // healthyOption
            // 
            this.healthyOption.AutoSize = true;
            this.healthyOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthyOption.Location = new System.Drawing.Point(28, 76);
            this.healthyOption.Name = "healthyOption";
            this.healthyOption.Size = new System.Drawing.Size(115, 20);
            this.healthyOption.TabIndex = 6;
            this.healthyOption.Text = "Healthy Option";
            this.healthyOption.UseVisualStyleBackColor = true;
            this.healthyOption.CheckedChanged += new System.EventHandler(this.healthyOption_CheckedChanged);
            // 
            // fancyOption
            // 
            this.fancyOption.AutoSize = true;
            this.fancyOption.Checked = true;
            this.fancyOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancyOption.Location = new System.Drawing.Point(28, 50);
            this.fancyOption.Name = "fancyOption";
            this.fancyOption.Size = new System.Drawing.Size(133, 20);
            this.fancyOption.TabIndex = 7;
            this.fancyOption.Text = "Fancy Decoration";
            this.fancyOption.UseVisualStyleBackColor = true;
            this.fancyOption.CheckedChanged += new System.EventHandler(this.fancyOption_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 160);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.healthyOption);
            this.tabPage1.Controls.Add(this.fancyOption);
            this.tabPage1.Controls.Add(this.numberPeopleUpDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 134);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Planner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fancyBirthdayCheck);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.birthdayCakeTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.costBirthdayLabel);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numberOfPeopleBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Planner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fancyBirthdayCheck
            // 
            this.fancyBirthdayCheck.AutoSize = true;
            this.fancyBirthdayCheck.Checked = true;
            this.fancyBirthdayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthdayCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fancyBirthdayCheck.Location = new System.Drawing.Point(46, 52);
            this.fancyBirthdayCheck.Name = "fancyBirthdayCheck";
            this.fancyBirthdayCheck.Size = new System.Drawing.Size(88, 19);
            this.fancyBirthdayCheck.TabIndex = 10;
            this.fancyBirthdayCheck.Text = "Fancy Party";
            this.fancyBirthdayCheck.UseVisualStyleBackColor = true;
            this.fancyBirthdayCheck.CheckedChanged += new System.EventHandler(this.fancyBirthdayCheck_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cake Text";
            // 
            // birthdayCakeTextBox
            // 
            this.birthdayCakeTextBox.Location = new System.Drawing.Point(68, 75);
            this.birthdayCakeTextBox.Name = "birthdayCakeTextBox";
            this.birthdayCakeTextBox.Size = new System.Drawing.Size(113, 20);
            this.birthdayCakeTextBox.TabIndex = 8;
            this.birthdayCakeTextBox.Text = "Happy Birthday";
            this.birthdayCakeTextBox.TextChanged += new System.EventHandler(this.birthdayCakeTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cost";
            // 
            // costBirthdayLabel
            // 
            this.costBirthdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costBirthdayLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.costBirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costBirthdayLabel.Location = new System.Drawing.Point(66, 108);
            this.costBirthdayLabel.Name = "costBirthdayLabel";
            this.costBirthdayLabel.Size = new System.Drawing.Size(115, 23);
            this.costBirthdayLabel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(31, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Persons";
            // 
            // numberOfPeopleBirthday
            // 
            this.numberOfPeopleBirthday.Location = new System.Drawing.Point(34, 23);
            this.numberOfPeopleBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberOfPeopleBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleBirthday.Name = "numberOfPeopleBirthday";
            this.numberOfPeopleBirthday.Size = new System.Drawing.Size(127, 20);
            this.numberOfPeopleBirthday.TabIndex = 3;
            this.numberOfPeopleBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfPeopleBirthday.ValueChanged += new System.EventHandler(this.numberOfPeopleBirthday_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 185);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";            
            ((System.ComponentModel.ISupportInitialize)(this.numberPeopleUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberPeopleUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.CheckBox healthyOption;
        private System.Windows.Forms.CheckBox fancyOption;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox fancyBirthdayCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox birthdayCakeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label costBirthdayLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfPeopleBirthday;
    }
}

