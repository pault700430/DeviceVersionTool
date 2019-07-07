namespace TargetDeviceView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_detect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_vid = new System.Windows.Forms.Label();
            this.label_pid = new System.Windows.Forms.Label();
            this.label_manufacturer = new System.Windows.Forms.Label();
            this.label_product = new System.Windows.Forms.Label();
            this.label_revision = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton_settings = new System.Windows.Forms.ToolStripSplitButton();
            this.autorunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerCyclingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_detecttime = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label1_fail = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "VID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PID";
            // 
            // button_detect
            // 
            this.button_detect.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_detect.Location = new System.Drawing.Point(128, 185);
            this.button_detect.Name = "button_detect";
            this.button_detect.Size = new System.Drawing.Size(79, 32);
            this.button_detect.TabIndex = 2;
            this.button_detect.Text = "START";
            this.button_detect.UseVisualStyleBackColor = true;
            this.button_detect.Visible = false;
            this.button_detect.Click += new System.EventHandler(this.button_detect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "FW Revision";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(213, 188);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(31, 15);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "####";
            this.label_status.Visible = false;
            // 
            // label_vid
            // 
            this.label_vid.BackColor = System.Drawing.SystemColors.Control;
            this.label_vid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_vid.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vid.Location = new System.Drawing.Point(143, 35);
            this.label_vid.Name = "label_vid";
            this.label_vid.Size = new System.Drawing.Size(135, 21);
            this.label_vid.TabIndex = 1;
            this.label_vid.Text = "                                          \r\n";
            // 
            // label_pid
            // 
            this.label_pid.BackColor = System.Drawing.SystemColors.Control;
            this.label_pid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_pid.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pid.Location = new System.Drawing.Point(143, 66);
            this.label_pid.Name = "label_pid";
            this.label_pid.Size = new System.Drawing.Size(135, 21);
            this.label_pid.TabIndex = 1;
            this.label_pid.Text = "                                          \r\n";
            // 
            // label_manufacturer
            // 
            this.label_manufacturer.BackColor = System.Drawing.SystemColors.Control;
            this.label_manufacturer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_manufacturer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manufacturer.Location = new System.Drawing.Point(143, 96);
            this.label_manufacturer.Name = "label_manufacturer";
            this.label_manufacturer.Size = new System.Drawing.Size(135, 21);
            this.label_manufacturer.TabIndex = 1;
            this.label_manufacturer.Text = "                                          \r\n";
            // 
            // label_product
            // 
            this.label_product.BackColor = System.Drawing.SystemColors.Control;
            this.label_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_product.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.Location = new System.Drawing.Point(143, 126);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(135, 21);
            this.label_product.TabIndex = 1;
            this.label_product.Text = "                                          \r\n";
            // 
            // label_revision
            // 
            this.label_revision.BackColor = System.Drawing.SystemColors.Control;
            this.label_revision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_revision.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_revision.Location = new System.Drawing.Point(143, 156);
            this.label_revision.Name = "label_revision";
            this.label_revision.Size = new System.Drawing.Size(135, 21);
            this.label_revision.TabIndex = 1;
            this.label_revision.Text = "                                          \r\n";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(299, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(299, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(299, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(299, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(299, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSplitButton_settings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(374, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolstrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.BackgroundImage")));
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "V 0.1.1.1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.BackgroundImage")));
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Reload Config File";
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSplitButton_settings
            // 
            this.toolStripSplitButton_settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton_settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorunToolStripMenuItem,
            this.powerCyclingTestToolStripMenuItem});
            this.toolStripSplitButton_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton_settings.Name = "toolStripSplitButton_settings";
            this.toolStripSplitButton_settings.Size = new System.Drawing.Size(61, 22);
            this.toolStripSplitButton_settings.Text = "Settings";
            this.toolStripSplitButton_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // autorunToolStripMenuItem
            // 
            this.autorunToolStripMenuItem.Name = "autorunToolStripMenuItem";
            this.autorunToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.autorunToolStripMenuItem.Text = "Start On Boot Up";
            this.autorunToolStripMenuItem.Click += new System.EventHandler(this.autorunToolStripMenuItem_Click);
            // 
            // powerCyclingTestToolStripMenuItem
            // 
            this.powerCyclingTestToolStripMenuItem.Checked = true;
            this.powerCyclingTestToolStripMenuItem.CheckOnClick = true;
            this.powerCyclingTestToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.powerCyclingTestToolStripMenuItem.Name = "powerCyclingTestToolStripMenuItem";
            this.powerCyclingTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powerCyclingTestToolStripMenuItem.Text = "Power Cycling Test";
            this.powerCyclingTestToolStripMenuItem.Click += new System.EventHandler(this.powerCyclingTestToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Detect Times :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "PASS :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "FAIL :";
            // 
            // label_detecttime
            // 
            this.label_detecttime.BackColor = System.Drawing.SystemColors.Control;
            this.label_detecttime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_detecttime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_detecttime.Location = new System.Drawing.Point(143, 233);
            this.label_detecttime.Name = "label_detecttime";
            this.label_detecttime.Size = new System.Drawing.Size(135, 21);
            this.label_detecttime.TabIndex = 1;
            // 
            // label_pass
            // 
            this.label_pass.BackColor = System.Drawing.SystemColors.Control;
            this.label_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_pass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(143, 263);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(135, 21);
            this.label_pass.TabIndex = 1;
            // 
            // label1_fail
            // 
            this.label1_fail.BackColor = System.Drawing.SystemColors.Control;
            this.label1_fail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1_fail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_fail.Location = new System.Drawing.Point(143, 293);
            this.label1_fail.Name = "label1_fail";
            this.label1_fail.Size = new System.Drawing.Size(135, 21);
            this.label1_fail.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 332);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_detect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_revision);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.label_manufacturer);
            this.Controls.Add(this.label_pid);
            this.Controls.Add(this.label1_fail);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_detecttime);
            this.Controls.Add(this.label_vid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 240);
            this.Name = "Form1";
            this.Text = "Universal Version Check Tool ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_detect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_vid;
        private System.Windows.Forms.Label label_pid;
        private System.Windows.Forms.Label label_manufacturer;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_revision;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_settings;
        private System.Windows.Forms.ToolStripMenuItem autorunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerCyclingTestToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_detecttime;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label1_fail;
    }
}

