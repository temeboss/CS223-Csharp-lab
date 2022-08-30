namespace lec_8
{
    partial class card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idmodel = new System.Windows.Forms.Label();
            this.fnmodel = new System.Windows.Forms.Label();
            this.lnmodel = new System.Windows.Forms.Label();
            this.addressmodel = new System.Windows.Forms.Label();
            this.datemodel = new System.Windows.Forms.Label();
            this.gendermodel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idmodel
            // 
            this.idmodel.AutoSize = true;
            this.idmodel.Location = new System.Drawing.Point(174, 42);
            this.idmodel.Name = "idmodel";
            this.idmodel.Size = new System.Drawing.Size(35, 13);
            this.idmodel.TabIndex = 0;
            this.idmodel.Text = "label1";
            // 
            // fnmodel
            // 
            this.fnmodel.AutoSize = true;
            this.fnmodel.Location = new System.Drawing.Point(174, 73);
            this.fnmodel.Name = "fnmodel";
            this.fnmodel.Size = new System.Drawing.Size(35, 13);
            this.fnmodel.TabIndex = 1;
            this.fnmodel.Text = "label1";
            // 
            // lnmodel
            // 
            this.lnmodel.AutoSize = true;
            this.lnmodel.Location = new System.Drawing.Point(174, 102);
            this.lnmodel.Name = "lnmodel";
            this.lnmodel.Size = new System.Drawing.Size(35, 13);
            this.lnmodel.TabIndex = 2;
            this.lnmodel.Text = "label1";
            // 
            // addressmodel
            // 
            this.addressmodel.AutoSize = true;
            this.addressmodel.Location = new System.Drawing.Point(174, 129);
            this.addressmodel.Name = "addressmodel";
            this.addressmodel.Size = new System.Drawing.Size(35, 13);
            this.addressmodel.TabIndex = 3;
            this.addressmodel.Text = "label2";
            // 
            // datemodel
            // 
            this.datemodel.AutoSize = true;
            this.datemodel.Location = new System.Drawing.Point(174, 154);
            this.datemodel.Name = "datemodel";
            this.datemodel.Size = new System.Drawing.Size(35, 13);
            this.datemodel.TabIndex = 4;
            this.datemodel.Text = "label3";
            // 
            // gendermodel
            // 
            this.gendermodel.AutoSize = true;
            this.gendermodel.Location = new System.Drawing.Point(174, 181);
            this.gendermodel.Name = "gendermodel";
            this.gendermodel.Size = new System.Drawing.Size(35, 13);
            this.gendermodel.TabIndex = 5;
            this.gendermodel.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender";
            // 
            // card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gendermodel);
            this.Controls.Add(this.datemodel);
            this.Controls.Add(this.addressmodel);
            this.Controls.Add(this.lnmodel);
            this.Controls.Add(this.fnmodel);
            this.Controls.Add(this.idmodel);
            this.Name = "card";
            this.Size = new System.Drawing.Size(409, 274);
            this.Load += new System.EventHandler(this.card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idmodel;
        private System.Windows.Forms.Label fnmodel;
        private System.Windows.Forms.Label lnmodel;
        private System.Windows.Forms.Label addressmodel;
        private System.Windows.Forms.Label datemodel;
        private System.Windows.Forms.Label gendermodel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
