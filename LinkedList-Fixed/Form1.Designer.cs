﻿namespace LinkedList_Fixed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.numberAddedLabel = new System.Windows.Forms.Label();
            this.sumOfTheListLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.valueFound = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertNumberLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.insertNumberBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.indexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minecraftia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Item";
            // 
            // addItemBox
            // 
            this.addItemBox.Location = new System.Drawing.Point(20, 193);
            this.addItemBox.Name = "addItemBox";
            this.addItemBox.Size = new System.Drawing.Size(124, 20);
            this.addItemBox.TabIndex = 2;
            // 
            // addItemButton
            // 
            this.addItemButton.Font = new System.Drawing.Font("Minecraftia", 20.25F);
            this.addItemButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addItemButton.Location = new System.Drawing.Point(189, 162);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(120, 46);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "Click";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // numberAddedLabel
            // 
            this.numberAddedLabel.AutoSize = true;
            this.numberAddedLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberAddedLabel.Font = new System.Drawing.Font("Minecraftia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberAddedLabel.ForeColor = System.Drawing.Color.Lime;
            this.numberAddedLabel.Location = new System.Drawing.Point(12, 216);
            this.numberAddedLabel.Name = "numberAddedLabel";
            this.numberAddedLabel.Size = new System.Drawing.Size(148, 28);
            this.numberAddedLabel.TabIndex = 4;
            this.numberAddedLabel.Text = "Number Added";
            // 
            // sumOfTheListLabel
            // 
            this.sumOfTheListLabel.AutoSize = true;
            this.sumOfTheListLabel.BackColor = System.Drawing.Color.Transparent;
            this.sumOfTheListLabel.Font = new System.Drawing.Font("Minecraftia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumOfTheListLabel.ForeColor = System.Drawing.Color.Lime;
            this.sumOfTheListLabel.Location = new System.Drawing.Point(15, 310);
            this.sumOfTheListLabel.Name = "sumOfTheListLabel";
            this.sumOfTheListLabel.Size = new System.Drawing.Size(36, 28);
            this.sumOfTheListLabel.TabIndex = 8;
            this.sumOfTheListLabel.Text = "10";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Minecraftia", 20.25F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(268, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minecraftia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(9, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sum of the List";
            // 
            // valueFound
            // 
            this.valueFound.AutoSize = true;
            this.valueFound.BackColor = System.Drawing.Color.Transparent;
            this.valueFound.Font = new System.Drawing.Font("Minecraftia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueFound.ForeColor = System.Drawing.Color.Lime;
            this.valueFound.Location = new System.Drawing.Point(12, 430);
            this.valueFound.Name = "valueFound";
            this.valueFound.Size = new System.Drawing.Size(148, 28);
            this.valueFound.TabIndex = 12;
            this.valueFound.Text = "Number Added";
            this.valueFound.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Minecraftia", 20.25F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(189, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Click";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(20, 407);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(124, 20);
            this.valueBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Minecraftia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(12, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 47);
            this.label4.TabIndex = 9;
            this.label4.Text = "Find Value";
            // 
            // insertNumberLabel
            // 
            this.insertNumberLabel.AutoSize = true;
            this.insertNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.insertNumberLabel.Font = new System.Drawing.Font("Minecraftia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertNumberLabel.ForeColor = System.Drawing.Color.Lime;
            this.insertNumberLabel.Location = new System.Drawing.Point(12, 588);
            this.insertNumberLabel.Name = "insertNumberLabel";
            this.insertNumberLabel.Size = new System.Drawing.Size(176, 28);
            this.insertNumberLabel.TabIndex = 16;
            this.insertNumberLabel.Text = "Number Inserted";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Minecraftia", 20.25F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(199, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 46);
            this.button3.TabIndex = 15;
            this.button3.Text = "Click";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // insertNumberBox
            // 
            this.insertNumberBox.Location = new System.Drawing.Point(20, 547);
            this.insertNumberBox.Name = "insertNumberBox";
            this.insertNumberBox.Size = new System.Drawing.Size(74, 20);
            this.insertNumberBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Minecraftia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(12, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 47);
            this.label5.TabIndex = 13;
            this.label5.Text = "Insert Number";
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(114, 547);
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(74, 20);
            this.indexBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minecraftia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Minecraftia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(120, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Index";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 659);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.insertNumberLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.insertNumberBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valueFound);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sumOfTheListLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberAddedLabel);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.addItemBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addItemBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Label numberAddedLabel;
        private System.Windows.Forms.Label sumOfTheListLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valueFound;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label insertNumberLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox insertNumberBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox indexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}
