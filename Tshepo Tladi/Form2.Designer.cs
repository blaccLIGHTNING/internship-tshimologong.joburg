
namespace Tshepo_Tladi
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCntct = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCntct = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxOther = new System.Windows.Forms.CheckBox();
            this.cBoxBeef = new System.Windows.Forms.CheckBox();
            this.cBoxChicken = new System.Windows.Forms.CheckBox();
            this.cBoxPap = new System.Windows.Forms.CheckBox();
            this.cBoxPasta = new System.Windows.Forms.CheckBox();
            this.cBoxPizza = new System.Windows.Forms.CheckBox();
            this.gBoxIndicate = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClmBlank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSAgree = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmAgree = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmNeutral = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmDisagree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSDisagree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gBoxIndicate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPicker);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtCntct);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblCntct);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(112, 115);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(130, 20);
            this.dtPicker.TabIndex = 10;
            this.dtPicker.Value = new System.DateTime(2023, 5, 29, 10, 26, 48, 0);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(112, 141);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(24, 20);
            this.txtAge.TabIndex = 9;
            // 
            // txtCntct
            // 
            this.txtCntct.Location = new System.Drawing.Point(112, 89);
            this.txtCntct.Name = "txtCntct";
            this.txtCntct.Size = new System.Drawing.Size(130, 20);
            this.txtCntct.TabIndex = 7;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(112, 63);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(130, 20);
            this.txtFname.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(112, 37);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(130, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(22, 144);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            this.lblAge.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 118);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblCntct
            // 
            this.lblCntct.AutoSize = true;
            this.lblCntct.Location = new System.Drawing.Point(22, 92);
            this.lblCntct.Name = "lblCntct";
            this.lblCntct.Size = new System.Drawing.Size(84, 13);
            this.lblCntct.TabIndex = 2;
            this.lblCntct.Text = "Contact Number";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(22, 66);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 13);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name/s";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(22, 40);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxOther);
            this.groupBox2.Controls.Add(this.cBoxBeef);
            this.groupBox2.Controls.Add(this.cBoxChicken);
            this.groupBox2.Controls.Add(this.cBoxPap);
            this.groupBox2.Controls.Add(this.cBoxPasta);
            this.groupBox2.Controls.Add(this.cBoxPizza);
            this.groupBox2.Location = new System.Drawing.Point(19, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "What is your favourite food? (you can choose more than 1 answer)";
            // 
            // cBoxOther
            // 
            this.cBoxOther.AutoSize = true;
            this.cBoxOther.Location = new System.Drawing.Point(6, 134);
            this.cBoxOther.Name = "cBoxOther";
            this.cBoxOther.Size = new System.Drawing.Size(52, 17);
            this.cBoxOther.TabIndex = 5;
            this.cBoxOther.Text = "Other";
            this.cBoxOther.UseVisualStyleBackColor = true;
            // 
            // cBoxBeef
            // 
            this.cBoxBeef.AutoSize = true;
            this.cBoxBeef.Location = new System.Drawing.Point(6, 111);
            this.cBoxBeef.Name = "cBoxBeef";
            this.cBoxBeef.Size = new System.Drawing.Size(78, 17);
            this.cBoxBeef.TabIndex = 4;
            this.cBoxBeef.Text = "Beef stir fry";
            this.cBoxBeef.UseVisualStyleBackColor = true;
            // 
            // cBoxChicken
            // 
            this.cBoxChicken.AutoSize = true;
            this.cBoxChicken.Location = new System.Drawing.Point(6, 88);
            this.cBoxChicken.Name = "cBoxChicken";
            this.cBoxChicken.Size = new System.Drawing.Size(95, 17);
            this.cBoxChicken.TabIndex = 3;
            this.cBoxChicken.Text = "Chicken stir fry";
            this.cBoxChicken.UseVisualStyleBackColor = true;
            // 
            // cBoxPap
            // 
            this.cBoxPap.AutoSize = true;
            this.cBoxPap.Location = new System.Drawing.Point(6, 65);
            this.cBoxPap.Name = "cBoxPap";
            this.cBoxPap.Size = new System.Drawing.Size(94, 17);
            this.cBoxPap.TabIndex = 2;
            this.cBoxPap.Text = "Pap and Wors";
            this.cBoxPap.UseVisualStyleBackColor = true;
            // 
            // cBoxPasta
            // 
            this.cBoxPasta.AutoSize = true;
            this.cBoxPasta.Location = new System.Drawing.Point(6, 42);
            this.cBoxPasta.Name = "cBoxPasta";
            this.cBoxPasta.Size = new System.Drawing.Size(53, 17);
            this.cBoxPasta.TabIndex = 1;
            this.cBoxPasta.Text = "Pasta";
            this.cBoxPasta.UseVisualStyleBackColor = true;
            // 
            // cBoxPizza
            // 
            this.cBoxPizza.AutoSize = true;
            this.cBoxPizza.Location = new System.Drawing.Point(6, 19);
            this.cBoxPizza.Name = "cBoxPizza";
            this.cBoxPizza.Size = new System.Drawing.Size(51, 17);
            this.cBoxPizza.TabIndex = 0;
            this.cBoxPizza.Text = "Pizza";
            this.cBoxPizza.UseVisualStyleBackColor = true;
            // 
            // gBoxIndicate
            // 
            this.gBoxIndicate.Controls.Add(this.dataGridView1);
            this.gBoxIndicate.Location = new System.Drawing.Point(19, 403);
            this.gBoxIndicate.Name = "gBoxIndicate";
            this.gBoxIndicate.Size = new System.Drawing.Size(635, 154);
            this.gBoxIndicate.TabIndex = 2;
            this.gBoxIndicate.TabStop = false;
            this.gBoxIndicate.Text = "On ascale of 1 to 5, indicate whether you strongly agree or strongly disagree";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmBlank,
            this.ClmSAgree,
            this.ClmAgree,
            this.ClmNeutral,
            this.ClmDisagree,
            this.ClmSDisagree});
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 119);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClmBlank
            // 
            this.ClmBlank.HeaderText = "";
            this.ClmBlank.Name = "ClmBlank";
            // 
            // ClmSAgree
            // 
            this.ClmSAgree.HeaderText = "Strongly Agree";
            this.ClmSAgree.Name = "ClmSAgree";
            this.ClmSAgree.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmSAgree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ClmAgree
            // 
            this.ClmAgree.HeaderText = "Agree";
            this.ClmAgree.Name = "ClmAgree";
            this.ClmAgree.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmAgree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ClmNeutral
            // 
            this.ClmNeutral.HeaderText = "Neutral";
            this.ClmNeutral.Name = "ClmNeutral";
            this.ClmNeutral.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmNeutral.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ClmDisagree
            // 
            this.ClmDisagree.HeaderText = "Disagree";
            this.ClmDisagree.Name = "ClmDisagree";
            // 
            // ClmSDisagree
            // 
            this.ClmSDisagree.HeaderText = "Strongly Disagree";
            this.ClmSDisagree.Name = "ClmSDisagree";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(413, 577);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Tshepo_Tladi.Form1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gBoxIndicate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Take your survey";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gBoxIndicate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCntct;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCntct;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBoxOther;
        private System.Windows.Forms.CheckBox cBoxBeef;
        private System.Windows.Forms.CheckBox cBoxChicken;
        private System.Windows.Forms.CheckBox cBoxPap;
        private System.Windows.Forms.CheckBox cBoxPasta;
        private System.Windows.Forms.CheckBox cBoxPizza;
        private System.Windows.Forms.GroupBox gBoxIndicate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmBlank;
        private System.Windows.Forms.DataGridViewButtonColumn ClmSAgree;
        private System.Windows.Forms.DataGridViewButtonColumn ClmAgree;
        private System.Windows.Forms.DataGridViewButtonColumn ClmNeutral;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDisagree;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSDisagree;
    }
}