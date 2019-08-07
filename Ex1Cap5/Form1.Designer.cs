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
            ((System.ComponentModel.ISupportInitialize)(this.numberPeopleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Persons";
            // 
            // numberPeopleUpDown
            // 
            this.numberPeopleUpDown.Location = new System.Drawing.Point(27, 29);
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
            this.label4.Location = new System.Drawing.Point(11, 118);
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
            this.costLabel.Location = new System.Drawing.Point(57, 116);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(115, 23);
            this.costLabel.TabIndex = 5;
            // 
            // healthyOption
            // 
            this.healthyOption.AutoSize = true;
            this.healthyOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthyOption.Location = new System.Drawing.Point(12, 81);
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
            this.fancyOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fancyOption.Location = new System.Drawing.Point(12, 55);
            this.fancyOption.Name = "fancyOption";
            this.fancyOption.Size = new System.Drawing.Size(133, 20);
            this.fancyOption.TabIndex = 7;
            this.fancyOption.Text = "Fancy Decoration";
            this.fancyOption.UseVisualStyleBackColor = true;
            this.fancyOption.CheckedChanged += new System.EventHandler(this.fancyOption_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 152);
            this.Controls.Add(this.fancyOption);
            this.Controls.Add(this.healthyOption);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberPeopleUpDown);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberPeopleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberPeopleUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.CheckBox healthyOption;
        private System.Windows.Forms.CheckBox fancyOption;
    }
}

