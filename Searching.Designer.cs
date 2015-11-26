namespace Cars
{
    partial class Searching
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
            this.CarsNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxPowerOutput = new System.Windows.Forms.Label();
            this.MaxPriceOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarColor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CarsWithSameColor = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchCar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.To = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarsNames
            // 
            this.CarsNames.FormattingEnabled = true;
            this.CarsNames.Location = new System.Drawing.Point(95, 50);
            this.CarsNames.Name = "CarsNames";
            this.CarsNames.Size = new System.Drawing.Size(144, 21);
            this.CarsNames.TabIndex = 0;
            this.CarsNames.SelectedIndexChanged += new System.EventHandler(this.CarsNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(128, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оберіть авто";
            // 
            // MaxPowerOutput
            // 
            this.MaxPowerOutput.AutoSize = true;
            this.MaxPowerOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaxPowerOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaxPowerOutput.Location = new System.Drawing.Point(92, 92);
            this.MaxPowerOutput.Name = "MaxPowerOutput";
            this.MaxPowerOutput.Size = new System.Drawing.Size(59, 13);
            this.MaxPowerOutput.TabIndex = 2;
            this.MaxPowerOutput.Text = "Max power";
            // 
            // MaxPriceOutput
            // 
            this.MaxPriceOutput.AutoSize = true;
            this.MaxPriceOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaxPriceOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaxPriceOutput.Location = new System.Drawing.Point(92, 118);
            this.MaxPriceOutput.Name = "MaxPriceOutput";
            this.MaxPriceOutput.Size = new System.Drawing.Size(53, 13);
            this.MaxPriceOutput.TabIndex = 3;
            this.MaxPriceOutput.Text = "Max price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(125, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Оберіть колір";
            // 
            // CarColor
            // 
            this.CarColor.FormattingEnabled = true;
            this.CarColor.Location = new System.Drawing.Point(92, 58);
            this.CarColor.Name = "CarColor";
            this.CarColor.Size = new System.Drawing.Size(144, 21);
            this.CarColor.TabIndex = 4;
            this.CarColor.SelectedIndexChanged += new System.EventHandler(this.CarColor_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.CarsNames);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MaxPowerOutput);
            this.groupBox1.Controls.Add(this.MaxPriceOutput);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 151);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук надорощого та найпотужнішого автомобілів";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.CarsWithSameColor);
            this.groupBox2.Controls.Add(this.CarColor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 164);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Автомобілі одинакового кольору";
            // 
            // CarsWithSameColor
            // 
            this.CarsWithSameColor.FormattingEnabled = true;
            this.CarsWithSameColor.Location = new System.Drawing.Point(92, 102);
            this.CarsWithSameColor.Name = "CarsWithSameColor";
            this.CarsWithSameColor.Size = new System.Drawing.Size(144, 56);
            this.CarsWithSameColor.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Controls.Add(this.SearchCar);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.To);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.From);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 164);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Авто з цінами у вибраному діапазоні";
            // 
            // SearchCar
            // 
            this.SearchCar.BackgroundImage = global::Cars.Properties.Resources.search;
            this.SearchCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchCar.FlatAppearance.BorderSize = 0;
            this.SearchCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchCar.Location = new System.Drawing.Point(199, 92);
            this.SearchCar.Name = "SearchCar";
            this.SearchCar.Size = new System.Drawing.Size(72, 56);
            this.SearchCar.TabIndex = 11;
            this.SearchCar.UseVisualStyleBackColor = true;
            this.SearchCar.Click += new System.EventHandler(this.SearchCar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(49, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 56);
            this.listBox1.TabIndex = 10;
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(174, 53);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(97, 20);
            this.To.TabIndex = 9;
            this.To.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.To_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(152, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = " - ";
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(49, 53);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(97, 20);
            this.From.TabIndex = 7;
            this.From.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.From_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(98, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введіть діапазон ціни";
            // 
            // Searching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(355, 528);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Searching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaxSearch";
            this.Load += new System.EventHandler(this.MaxSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CarsNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaxPowerOutput;
        private System.Windows.Forms.Label MaxPriceOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CarColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox CarsWithSameColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SearchCar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.Label label3;
    }
}