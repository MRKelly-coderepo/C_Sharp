namespace UserInformationBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_l_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_f_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 153);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pull Users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_l_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_f_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(161, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER INFORMATION";
            // 
            // lbl_l_name
            // 
            this.lbl_l_name.AutoSize = true;
            this.lbl_l_name.Location = new System.Drawing.Point(143, 198);
            this.lbl_l_name.Name = "lbl_l_name";
            this.lbl_l_name.Size = new System.Drawing.Size(0, 32);
            this.lbl_l_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // lbl_f_name
            // 
            this.lbl_f_name.AutoSize = true;
            this.lbl_f_name.Location = new System.Drawing.Point(146, 139);
            this.lbl_f_name.Name = "lbl_f_name";
            this.lbl_f_name.Size = new System.Drawing.Size(0, 32);
            this.lbl_f_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(108, 71);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(0, 32);
            this.lblUserID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 846);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 42);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(206, 32);
            this.toolStripStatusLabel1.Text = "NOT CONNECTED";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(242, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 40);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 888);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblUserID;
        private Label lbl_f_name;
        private Label label2;
        private Label lbl_l_name;
        private Label label3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ComboBox comboBox1;
    }
}