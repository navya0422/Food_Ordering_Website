namespace Food_Ordering_Website
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IceCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.BackLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(409, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ice Cream ordering ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(498, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(440, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Ice Cream";
            // 
            // IceCb
            // 
            this.IceCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IceCb.FormattingEnabled = true;
            this.IceCb.Items.AddRange(new object[] {
            "Vanilla",
            "Strawberry",
            "Chocolate",
            "Rocky Road",
            "Chocolate Chip"});
            this.IceCb.Location = new System.Drawing.Point(447, 338);
            this.IceCb.Name = "IceCb";
            this.IceCb.Size = new System.Drawing.Size(288, 45);
            this.IceCb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(440, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select The Price";
            // 
            // PriceTb
            // 
            this.PriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PriceTb.Location = new System.Drawing.Point(447, 530);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(288, 44);
            this.PriceTb.TabIndex = 5;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.SubmitBtn.ForeColor = System.Drawing.Color.Black;
            this.SubmitBtn.Location = new System.Drawing.Point(525, 634);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(128, 55);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // BackLbl
            // 
            this.BackLbl.AutoSize = true;
            this.BackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BackLbl.Location = new System.Drawing.Point(546, 761);
            this.BackLbl.Name = "BackLbl";
            this.BackLbl.Size = new System.Drawing.Size(88, 37);
            this.BackLbl.TabIndex = 8;
            this.BackLbl.Text = "Back";
            this.BackLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 843);
            this.Controls.Add(this.BackLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IceCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IceCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label BackLbl;
    }
}