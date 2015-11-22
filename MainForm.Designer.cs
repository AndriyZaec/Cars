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
            this.CarsTable = new System.Windows.Forms.DataGridView();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CarsTable
            // 
            this.CarsTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.color,
            this.price,
            this.power,
            this.picture});
            this.CarsTable.Location = new System.Drawing.Point(12, 35);
            this.CarsTable.Name = "CarsTable";
            this.CarsTable.ReadOnly = true;
            this.CarsTable.Size = new System.Drawing.Size(444, 282);
            this.CarsTable.TabIndex = 0;
            this.CarsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsTable_CellClick);
            // 
            // Model
            // 
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // color
            // 
            this.color.HeaderText = "Колір";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Ціна";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // power
            // 
            this.power.HeaderText = "Потужність";
            this.power.Name = "power";
            this.power.ReadOnly = true;
            // 
            // picture
            // 
            this.picture.HeaderText = "picture";
            this.picture.Name = "picture";
            this.picture.ReadOnly = true;
            this.picture.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.Edit);
            this.groupBox1.Controls.Add(this.Remove);
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.Location = new System.Drawing.Point(12, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Edit
            // 
            this.Edit.BackgroundImage = global::Cars.Properties.Resources.edit;
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Location = new System.Drawing.Point(310, 29);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(92, 80);
            this.Edit.TabIndex = 2;
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.BackgroundImage = global::Cars.Properties.Resources.delete;
            this.Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Remove.FlatAppearance.BorderSize = 0;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Location = new System.Drawing.Point(166, 29);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(90, 82);
            this.Remove.TabIndex = 1;
            this.Remove.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(462, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 282);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(702, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CarsTable);
            this.Name = "MainForm";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CarsTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn power;
        private System.Windows.Forms.DataGridViewTextBoxColumn picture;
    }
}

