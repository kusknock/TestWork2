namespace TestWork2
{
    partial class AddHouse
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
            this.comboRegion = new System.Windows.Forms.ComboBox();
            this.comboLocality = new System.Windows.Forms.ComboBox();
            this.comboStreet = new System.Windows.Forms.ComboBox();
            this.lblSelectRegion = new System.Windows.Forms.Label();
            this.lblSelectLocality = new System.Windows.Forms.Label();
            this.lblSelectStreet = new System.Windows.Forms.Label();
            this.comboTypesHouses = new System.Windows.Forms.ComboBox();
            this.lblTypeHouse = new System.Windows.Forms.Label();
            this.numAparts = new System.Windows.Forms.NumericUpDown();
            this.lblNumAparts = new System.Windows.Forms.Label();
            this.numOfHouse = new System.Windows.Forms.NumericUpDown();
            this.lblNumOfHouse = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAparts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRegion
            // 
            this.comboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRegion.FormattingEnabled = true;
            this.comboRegion.Location = new System.Drawing.Point(12, 29);
            this.comboRegion.Name = "comboRegion";
            this.comboRegion.Size = new System.Drawing.Size(262, 24);
            this.comboRegion.TabIndex = 0;
            this.comboRegion.SelectedIndexChanged += new System.EventHandler(this.comboRegion_SelectedIndexChanged);
            // 
            // comboLocality
            // 
            this.comboLocality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocality.FormattingEnabled = true;
            this.comboLocality.Location = new System.Drawing.Point(12, 85);
            this.comboLocality.Name = "comboLocality";
            this.comboLocality.Size = new System.Drawing.Size(262, 24);
            this.comboLocality.TabIndex = 1;
            this.comboLocality.SelectedIndexChanged += new System.EventHandler(this.comboLocality_SelectedIndexChanged);
            // 
            // comboStreet
            // 
            this.comboStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStreet.FormattingEnabled = true;
            this.comboStreet.Location = new System.Drawing.Point(12, 142);
            this.comboStreet.Name = "comboStreet";
            this.comboStreet.Size = new System.Drawing.Size(262, 24);
            this.comboStreet.TabIndex = 2;
            // 
            // lblSelectRegion
            // 
            this.lblSelectRegion.AutoSize = true;
            this.lblSelectRegion.Location = new System.Drawing.Point(12, 9);
            this.lblSelectRegion.Name = "lblSelectRegion";
            this.lblSelectRegion.Size = new System.Drawing.Size(127, 17);
            this.lblSelectRegion.TabIndex = 3;
            this.lblSelectRegion.Text = "Выберите регион:";
            // 
            // lblSelectLocality
            // 
            this.lblSelectLocality.AutoSize = true;
            this.lblSelectLocality.Location = new System.Drawing.Point(12, 65);
            this.lblSelectLocality.Name = "lblSelectLocality";
            this.lblSelectLocality.Size = new System.Drawing.Size(204, 17);
            this.lblSelectLocality.TabIndex = 3;
            this.lblSelectLocality.Text = "Выберите населенный пункт:";
            // 
            // lblSelectStreet
            // 
            this.lblSelectStreet.AutoSize = true;
            this.lblSelectStreet.Location = new System.Drawing.Point(12, 122);
            this.lblSelectStreet.Name = "lblSelectStreet";
            this.lblSelectStreet.Size = new System.Drawing.Size(120, 17);
            this.lblSelectStreet.TabIndex = 3;
            this.lblSelectStreet.Text = "Выберите улицу:";
            // 
            // comboTypesHouses
            // 
            this.comboTypesHouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypesHouses.FormattingEnabled = true;
            this.comboTypesHouses.Location = new System.Drawing.Point(12, 203);
            this.comboTypesHouses.Name = "comboTypesHouses";
            this.comboTypesHouses.Size = new System.Drawing.Size(262, 24);
            this.comboTypesHouses.TabIndex = 2;
            // 
            // lblTypeHouse
            // 
            this.lblTypeHouse.AutoSize = true;
            this.lblTypeHouse.Location = new System.Drawing.Point(12, 183);
            this.lblTypeHouse.Name = "lblTypeHouse";
            this.lblTypeHouse.Size = new System.Drawing.Size(142, 17);
            this.lblTypeHouse.TabIndex = 3;
            this.lblTypeHouse.Text = "Выберите тип дома:";
            // 
            // numAparts
            // 
            this.numAparts.Location = new System.Drawing.Point(12, 262);
            this.numAparts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAparts.Name = "numAparts";
            this.numAparts.Size = new System.Drawing.Size(120, 22);
            this.numAparts.TabIndex = 4;
            this.numAparts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumAparts
            // 
            this.lblNumAparts.AutoSize = true;
            this.lblNumAparts.Location = new System.Drawing.Point(12, 242);
            this.lblNumAparts.Name = "lblNumAparts";
            this.lblNumAparts.Size = new System.Drawing.Size(114, 17);
            this.lblNumAparts.TabIndex = 5;
            this.lblNumAparts.Text = "Кол-во квартир:";
            // 
            // numOfHouse
            // 
            this.numOfHouse.Location = new System.Drawing.Point(154, 262);
            this.numOfHouse.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numOfHouse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfHouse.Name = "numOfHouse";
            this.numOfHouse.Size = new System.Drawing.Size(120, 22);
            this.numOfHouse.TabIndex = 4;
            this.numOfHouse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumOfHouse
            // 
            this.lblNumOfHouse.AutoSize = true;
            this.lblNumOfHouse.Location = new System.Drawing.Point(154, 242);
            this.lblNumOfHouse.Name = "lblNumOfHouse";
            this.lblNumOfHouse.Size = new System.Drawing.Size(92, 17);
            this.lblNumOfHouse.TabIndex = 5;
            this.lblNumOfHouse.Text = "Номер дома:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 65);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 383);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNumOfHouse);
            this.Controls.Add(this.lblNumAparts);
            this.Controls.Add(this.numOfHouse);
            this.Controls.Add(this.numAparts);
            this.Controls.Add(this.lblTypeHouse);
            this.Controls.Add(this.lblSelectStreet);
            this.Controls.Add(this.lblSelectLocality);
            this.Controls.Add(this.lblSelectRegion);
            this.Controls.Add(this.comboTypesHouses);
            this.Controls.Add(this.comboStreet);
            this.Controls.Add(this.comboLocality);
            this.Controls.Add(this.comboRegion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddHouse";
            this.Text = "Добавить дом";
            this.Load += new System.EventHandler(this.AddHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAparts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRegion;
        private System.Windows.Forms.ComboBox comboLocality;
        private System.Windows.Forms.ComboBox comboStreet;
        private System.Windows.Forms.Label lblSelectRegion;
        private System.Windows.Forms.Label lblSelectLocality;
        private System.Windows.Forms.Label lblSelectStreet;
        private System.Windows.Forms.ComboBox comboTypesHouses;
        private System.Windows.Forms.Label lblTypeHouse;
        private System.Windows.Forms.NumericUpDown numAparts;
        private System.Windows.Forms.Label lblNumAparts;
        private System.Windows.Forms.NumericUpDown numOfHouse;
        private System.Windows.Forms.Label lblNumOfHouse;
        private System.Windows.Forms.Button btnAdd;
    }
}