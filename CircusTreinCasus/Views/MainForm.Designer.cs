namespace CircusTreinCasus
{
    partial class MainForm
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
            this.btnAddAnimalToList = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.rbtnLarge = new System.Windows.Forms.RadioButton();
            this.rbtnMiddle = new System.Windows.Forms.RadioButton();
            this.rbtnVegetarian = new System.Windows.Forms.RadioButton();
            this.rbtnMeat = new System.Windows.Forms.RadioButton();
            this.rbtnSmall = new System.Windows.Forms.RadioButton();
            this.lbWagons = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDivideAnimals = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.lbTrain = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAnimalToList
            // 
            this.btnAddAnimalToList.Location = new System.Drawing.Point(12, 12);
            this.btnAddAnimalToList.Name = "btnAddAnimalToList";
            this.btnAddAnimalToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnimalToList.TabIndex = 0;
            this.btnAddAnimalToList.Text = "Add Animal";
            this.btnAddAnimalToList.UseVisualStyleBackColor = true;
            this.btnAddAnimalToList.Click += new System.EventHandler(this.btnAddAnimalToList_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // rbtnLarge
            // 
            this.rbtnLarge.AutoSize = true;
            this.rbtnLarge.Location = new System.Drawing.Point(4, 52);
            this.rbtnLarge.Name = "rbtnLarge";
            this.rbtnLarge.Size = new System.Drawing.Size(52, 17);
            this.rbtnLarge.TabIndex = 3;
            this.rbtnLarge.TabStop = true;
            this.rbtnLarge.Text = "Large";
            this.rbtnLarge.UseVisualStyleBackColor = true;
            // 
            // rbtnMiddle
            // 
            this.rbtnMiddle.AutoSize = true;
            this.rbtnMiddle.Location = new System.Drawing.Point(4, 29);
            this.rbtnMiddle.Name = "rbtnMiddle";
            this.rbtnMiddle.Size = new System.Drawing.Size(56, 17);
            this.rbtnMiddle.TabIndex = 4;
            this.rbtnMiddle.TabStop = true;
            this.rbtnMiddle.Text = "Middle";
            this.rbtnMiddle.UseVisualStyleBackColor = true;
            // 
            // rbtnVegetarian
            // 
            this.rbtnVegetarian.AutoSize = true;
            this.rbtnVegetarian.Location = new System.Drawing.Point(11, 64);
            this.rbtnVegetarian.Name = "rbtnVegetarian";
            this.rbtnVegetarian.Size = new System.Drawing.Size(76, 17);
            this.rbtnVegetarian.TabIndex = 5;
            this.rbtnVegetarian.TabStop = true;
            this.rbtnVegetarian.Text = "Vegetarian";
            this.rbtnVegetarian.UseVisualStyleBackColor = true;
            // 
            // rbtnMeat
            // 
            this.rbtnMeat.AutoSize = true;
            this.rbtnMeat.Location = new System.Drawing.Point(12, 41);
            this.rbtnMeat.Name = "rbtnMeat";
            this.rbtnMeat.Size = new System.Drawing.Size(73, 17);
            this.rbtnMeat.TabIndex = 6;
            this.rbtnMeat.TabStop = true;
            this.rbtnMeat.Text = "Meateater";
            this.rbtnMeat.UseVisualStyleBackColor = true;
            // 
            // rbtnSmall
            // 
            this.rbtnSmall.AutoSize = true;
            this.rbtnSmall.Location = new System.Drawing.Point(4, 6);
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.Size = new System.Drawing.Size(50, 17);
            this.rbtnSmall.TabIndex = 7;
            this.rbtnSmall.TabStop = true;
            this.rbtnSmall.Text = "Small";
            this.rbtnSmall.UseVisualStyleBackColor = true;
            // 
            // lbWagons
            // 
            this.lbWagons.FormattingEnabled = true;
            this.lbWagons.Location = new System.Drawing.Point(338, 12);
            this.lbWagons.Name = "lbWagons";
            this.lbWagons.Size = new System.Drawing.Size(164, 433);
            this.lbWagons.TabIndex = 8;
            this.lbWagons.SelectedIndexChanged += new System.EventHandler(this.lbWagons_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 211);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            // 
            // btnDivideAnimals
            // 
            this.btnDivideAnimals.Location = new System.Drawing.Point(16, 415);
            this.btnDivideAnimals.Name = "btnDivideAnimals";
            this.btnDivideAnimals.Size = new System.Drawing.Size(95, 23);
            this.btnDivideAnimals.TabIndex = 11;
            this.btnDivideAnimals.Text = "Divide Animals";
            this.btnDivideAnimals.UseVisualStyleBackColor = true;
            this.btnDivideAnimals.Click += new System.EventHandler(this.btnDivideAnimals_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSmall);
            this.groupBox1.Controls.Add(this.rbtnMiddle);
            this.groupBox1.Controls.Add(this.rbtnLarge);
            this.groupBox1.Location = new System.Drawing.Point(8, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 71);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.Location = new System.Drawing.Point(168, 12);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(164, 433);
            this.lbAnimals.TabIndex = 14;
            // 
            // lbTrain
            // 
            this.lbTrain.FormattingEnabled = true;
            this.lbTrain.Location = new System.Drawing.Point(508, 12);
            this.lbTrain.Name = "lbTrain";
            this.lbTrain.Size = new System.Drawing.Size(164, 433);
            this.lbTrain.TabIndex = 15;
            this.lbTrain.SelectedIndexChanged += new System.EventHandler(this.lbTrain_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTrain);
            this.Controls.Add(this.lbAnimals);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDivideAnimals);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbWagons);
            this.Controls.Add(this.rbtnMeat);
            this.Controls.Add(this.rbtnVegetarian);
            this.Controls.Add(this.btnAddAnimalToList);
            this.Name = "MainForm";
            this.Text = "CircusTrein";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimalToList;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lbWagons;
        private System.Windows.Forms.RadioButton rbtnSmall;
        private System.Windows.Forms.RadioButton rbtnMeat;
        private System.Windows.Forms.RadioButton rbtnVegetarian;
        private System.Windows.Forms.RadioButton rbtnMiddle;
        private System.Windows.Forms.RadioButton rbtnLarge;
        private System.Windows.Forms.Button btnDivideAnimals;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbTrain;
        private System.Windows.Forms.ListBox lbAnimals;
    }
}

