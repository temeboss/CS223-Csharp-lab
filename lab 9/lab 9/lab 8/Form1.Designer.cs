namespace lec_8
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
            this.id = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.Label();
            this.ln = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.sy = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.fntext = new System.Windows.Forms.TextBox();
            this.lntext = new System.Windows.Forms.TextBox();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.datetext = new System.Windows.Forms.DateTimePicker();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.gendertext = new System.Windows.Forms.GroupBox();
            this.add = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.card1 = new lec_8.card();
            this.gendertext.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(12, 41);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(32, 25);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fn.Location = new System.Drawing.Point(12, 77);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(106, 25);
            this.fn.TabIndex = 1;
            this.fn.Text = "first name";
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ln.Location = new System.Drawing.Point(12, 126);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(112, 25);
            this.ln.TabIndex = 2;
            this.ln.Text = "Last name";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address.Location = new System.Drawing.Point(12, 168);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(91, 25);
            this.address.TabIndex = 3;
            this.address.Text = "Address";
            // 
            // sy
            // 
            this.sy.AutoSize = true;
            this.sy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sy.Location = new System.Drawing.Point(12, 207);
            this.sy.Name = "sy";
            this.sy.Size = new System.Drawing.Size(126, 25);
            this.sy.TabIndex = 4;
            this.sy.Text = "School year";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender.Location = new System.Drawing.Point(12, 245);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(79, 25);
            this.gender.TabIndex = 5;
            this.gender.Text = "gender";
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(148, 47);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(178, 20);
            this.idtext.TabIndex = 6;
            this.idtext.TextChanged += new System.EventHandler(this.idtext_TextChanged);
            // 
            // fntext
            // 
            this.fntext.Location = new System.Drawing.Point(148, 83);
            this.fntext.Name = "fntext";
            this.fntext.Size = new System.Drawing.Size(178, 20);
            this.fntext.TabIndex = 7;
            // 
            // lntext
            // 
            this.lntext.Location = new System.Drawing.Point(148, 131);
            this.lntext.Name = "lntext";
            this.lntext.Size = new System.Drawing.Size(178, 20);
            this.lntext.TabIndex = 8;
            this.lntext.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(148, 174);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(178, 20);
            this.addresstext.TabIndex = 9;
            // 
            // datetext
            // 
            this.datetext.Location = new System.Drawing.Point(148, 212);
            this.datetext.Name = "datetext";
            this.datetext.Size = new System.Drawing.Size(178, 20);
            this.datetext.TabIndex = 10;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(16, 19);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 11;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(135, 19);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 12;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // gendertext
            // 
            this.gendertext.Controls.Add(this.female);
            this.gendertext.Controls.Add(this.male);
            this.gendertext.Location = new System.Drawing.Point(118, 245);
            this.gendertext.Name = "gendertext";
            this.gendertext.Size = new System.Drawing.Size(200, 100);
            this.gendertext.TabIndex = 13;
            this.gendertext.TabStop = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(291, 351);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 14;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.card1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(425, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 279);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // card1
            // 
            this.card1.address = null;
            this.card1.BackColor = System.Drawing.Color.Gainsboro;
            this.card1.date = null;
            this.card1.First = "";
            this.card1.gender = null;
            this.card1.Id = null;
            this.card1.last = null;
            this.card1.Location = new System.Drawing.Point(3, 3);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(321, 274);
            this.card1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.gendertext);
            this.Controls.Add(this.datetext);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.lntext);
            this.Controls.Add(this.fntext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.sy);
            this.Controls.Add(this.address);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gendertext.ResumeLayout(false);
            this.gendertext.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label sy;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox fntext;
        private System.Windows.Forms.TextBox lntext;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.DateTimePicker datetext;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.GroupBox gendertext;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private card card1;
    }
}

