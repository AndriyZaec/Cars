namespace Cars
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CarList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SortedData = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Button();
            this.Closing = new System.Windows.Forms.Button();
            this.CloseSort = new System.Windows.Forms.Button();
            this.OptimalCarsInfo = new System.Windows.Forms.Button();
            this.MaxSearch = new System.Windows.Forms.Button();
            this.PriceSort = new System.Windows.Forms.Button();
            this.SaveNew = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.SaveNew);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.Edit);
            this.groupBox1.Controls.Add(this.Remove);
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // CarList
            // 
            this.CarList.FormattingEnabled = true;
            this.CarList.Location = new System.Drawing.Point(12, 40);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(238, 277);
            this.CarList.TabIndex = 3;
            this.CarList.SelectedIndexChanged += new System.EventHandler(this.CarList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список автомобілів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(324, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Назва";
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(327, 40);
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Size = new System.Drawing.Size(129, 20);
            this.Model.TabIndex = 6;
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(327, 116);
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Size = new System.Drawing.Size(129, 20);
            this.Color.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(324, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Колір";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(327, 200);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(129, 20);
            this.Price.TabIndex = 10;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(324, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ціна";
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(327, 282);
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            this.Power.Size = new System.Drawing.Size(129, 20);
            this.Power.TabIndex = 12;
            this.Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Power_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(324, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Потужність";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.OptimalCarsInfo);
            this.groupBox2.Controls.Add(this.MaxSearch);
            this.groupBox2.Controls.Add(this.PriceSort);
            this.groupBox2.Location = new System.Drawing.Point(483, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 315);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // SortedData
            // 
            this.SortedData.FormattingEnabled = true;
            this.SortedData.Location = new System.Drawing.Point(680, 40);
            this.SortedData.Name = "SortedData";
            this.SortedData.Size = new System.Drawing.Size(194, 407);
            this.SortedData.TabIndex = 14;
            this.SortedData.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(677, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Посортовані дані";
            this.label6.Visible = false;
            // 
            // Help
            // 
            this.Help.BackgroundImage = global::Cars.Properties.Resources.help;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help.FlatAppearance.BorderSize = 0;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.Location = new System.Drawing.Point(486, 333);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 56);
            this.Help.TabIndex = 17;
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Closing
            // 
            this.Closing.BackgroundImage = global::Cars.Properties.Resources.close;
            this.Closing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closing.FlatAppearance.BorderSize = 0;
            this.Closing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closing.Location = new System.Drawing.Point(567, 395);
            this.Closing.Name = "Closing";
            this.Closing.Size = new System.Drawing.Size(75, 56);
            this.Closing.TabIndex = 16;
            this.Closing.UseVisualStyleBackColor = true;
            this.Closing.Click += new System.EventHandler(this.Closing_Click);
            // 
            // CloseSort
            // 
            this.CloseSort.BackgroundImage = global::Cars.Properties.Resources.close;
            this.CloseSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseSort.FlatAppearance.BorderSize = 0;
            this.CloseSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseSort.Location = new System.Drawing.Point(880, 12);
            this.CloseSort.Name = "CloseSort";
            this.CloseSort.Size = new System.Drawing.Size(57, 48);
            this.CloseSort.TabIndex = 3;
            this.CloseSort.UseVisualStyleBackColor = true;
            this.CloseSort.Click += new System.EventHandler(this.CloseSort_Click);
            // 
            // OptimalCarsInfo
            // 
            this.OptimalCarsInfo.BackgroundImage = global::Cars.Properties.Resources.info;
            this.OptimalCarsInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptimalCarsInfo.FlatAppearance.BorderSize = 0;
            this.OptimalCarsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OptimalCarsInfo.Location = new System.Drawing.Point(28, 214);
            this.OptimalCarsInfo.Name = "OptimalCarsInfo";
            this.OptimalCarsInfo.Size = new System.Drawing.Size(98, 91);
            this.OptimalCarsInfo.TabIndex = 4;
            this.OptimalCarsInfo.UseVisualStyleBackColor = true;
            this.OptimalCarsInfo.Click += new System.EventHandler(this.OptimalCarsInfo_Click);
            // 
            // MaxSearch
            // 
            this.MaxSearch.BackgroundImage = global::Cars.Properties.Resources.search;
            this.MaxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaxSearch.FlatAppearance.BorderSize = 0;
            this.MaxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaxSearch.Location = new System.Drawing.Point(28, 117);
            this.MaxSearch.Name = "MaxSearch";
            this.MaxSearch.Size = new System.Drawing.Size(98, 77);
            this.MaxSearch.TabIndex = 3;
            this.MaxSearch.UseVisualStyleBackColor = true;
            this.MaxSearch.Click += new System.EventHandler(this.MaxSearch_Click);
            // 
            // PriceSort
            // 
            this.PriceSort.BackgroundImage = global::Cars.Properties.Resources.sort;
            this.PriceSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PriceSort.FlatAppearance.BorderSize = 0;
            this.PriceSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PriceSort.Location = new System.Drawing.Point(28, 28);
            this.PriceSort.Name = "PriceSort";
            this.PriceSort.Size = new System.Drawing.Size(98, 83);
            this.PriceSort.TabIndex = 2;
            this.PriceSort.UseVisualStyleBackColor = true;
            this.PriceSort.Click += new System.EventHandler(this.PriceSort_Click);
            // 
            // SaveNew
            // 
            this.SaveNew.BackgroundImage = global::Cars.Properties.Resources.save;
            this.SaveNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveNew.FlatAppearance.BorderSize = 0;
            this.SaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveNew.Location = new System.Drawing.Point(18, 29);
            this.SaveNew.Name = "SaveNew";
            this.SaveNew.Size = new System.Drawing.Size(92, 80);
            this.SaveNew.TabIndex = 4;
            this.SaveNew.UseVisualStyleBackColor = true;
            this.SaveNew.Visible = false;
            this.SaveNew.Click += new System.EventHandler(this.SaveNew_Click);
            // 
            // Save
            // 
            this.Save.BackgroundImage = global::Cars.Properties.Resources.save;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(333, 29);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 80);
            this.Save.TabIndex = 3;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Edit
            // 
            this.Edit.BackgroundImage = global::Cars.Properties.Resources.edit;
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Location = new System.Drawing.Point(333, 29);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(92, 80);
            this.Edit.TabIndex = 2;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Remove
            // 
            this.Remove.BackgroundImage = global::Cars.Properties.Resources.delete;
            this.Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Remove.FlatAppearance.BorderSize = 0;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Location = new System.Drawing.Point(173, 29);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(90, 82);
            this.Remove.TabIndex = 1;
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Create
            // 
            this.Create.BackgroundImage = global::Cars.Properties.Resources.add;
            this.Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Create.FlatAppearance.BorderSize = 0;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Location = new System.Drawing.Point(18, 30);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(91, 80);
            this.Create.TabIndex = 0;
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(666, 463);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Closing);
            this.Controls.Add(this.CloseSort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SortedData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarList);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ListBox CarList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Power;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button SaveNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PriceSort;
        private System.Windows.Forms.ListBox SortedData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseSort;
        private System.Windows.Forms.Button MaxSearch;
        private System.Windows.Forms.Button OptimalCarsInfo;
        private System.Windows.Forms.Button Closing;
        private System.Windows.Forms.Button Help;
    }
}

