namespace BenigaSimpleReflexAgents
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
            this.gbSettingsMode = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.gbSettingsManual = new System.Windows.Forms.GroupBox();
            this.checkD = new System.Windows.Forms.CheckBox();
            this.checkC = new System.Windows.Forms.CheckBox();
            this.checkB = new System.Windows.Forms.CheckBox();
            this.lblDirty = new System.Windows.Forms.Label();
            this.checkA = new System.Windows.Forms.CheckBox();
            this.cbStartLocation = new System.Windows.Forms.ComboBox();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAction = new System.Windows.Forms.RichTextBox();
            this.pnlD = new System.Windows.Forms.Panel();
            this.pnlB = new System.Windows.Forms.Panel();
            this.pnlC = new System.Windows.Forms.Panel();
            this.pnlA = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSettingsMode.SuspendLayout();
            this.gbSettingsManual.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettingsMode
            // 
            this.gbSettingsMode.Controls.Add(this.rbManual);
            this.gbSettingsMode.Controls.Add(this.rbRandom);
            this.gbSettingsMode.Location = new System.Drawing.Point(550, 47);
            this.gbSettingsMode.Name = "gbSettingsMode";
            this.gbSettingsMode.Size = new System.Drawing.Size(250, 60);
            this.gbSettingsMode.TabIndex = 1;
            this.gbSettingsMode.TabStop = false;
            this.gbSettingsMode.Text = "Mode Settings";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(153, 26);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 1;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Location = new System.Drawing.Point(36, 26);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(84, 17);
            this.rbRandom.TabIndex = 0;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Randomized";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.rbRandom_CheckedChanged);
            // 
            // gbSettingsManual
            // 
            this.gbSettingsManual.Controls.Add(this.checkD);
            this.gbSettingsManual.Controls.Add(this.checkC);
            this.gbSettingsManual.Controls.Add(this.checkB);
            this.gbSettingsManual.Controls.Add(this.lblDirty);
            this.gbSettingsManual.Controls.Add(this.checkA);
            this.gbSettingsManual.Controls.Add(this.cbStartLocation);
            this.gbSettingsManual.Controls.Add(this.lblStartLocation);
            this.gbSettingsManual.Location = new System.Drawing.Point(550, 113);
            this.gbSettingsManual.Name = "gbSettingsManual";
            this.gbSettingsManual.Size = new System.Drawing.Size(250, 122);
            this.gbSettingsManual.TabIndex = 2;
            this.gbSettingsManual.TabStop = false;
            this.gbSettingsManual.Text = "Manual Mode";
            // 
            // checkD
            // 
            this.checkD.AutoSize = true;
            this.checkD.Location = new System.Drawing.Point(179, 88);
            this.checkD.Name = "checkD";
            this.checkD.Size = new System.Drawing.Size(34, 17);
            this.checkD.TabIndex = 6;
            this.checkD.Text = "D";
            this.checkD.UseVisualStyleBackColor = true;
            // 
            // checkC
            // 
            this.checkC.AutoSize = true;
            this.checkC.Location = new System.Drawing.Point(135, 88);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(33, 17);
            this.checkC.TabIndex = 5;
            this.checkC.Text = "C";
            this.checkC.UseVisualStyleBackColor = true;
            // 
            // checkB
            // 
            this.checkB.AutoSize = true;
            this.checkB.Location = new System.Drawing.Point(180, 65);
            this.checkB.Name = "checkB";
            this.checkB.Size = new System.Drawing.Size(33, 17);
            this.checkB.TabIndex = 4;
            this.checkB.Text = "B";
            this.checkB.UseVisualStyleBackColor = true;
            // 
            // lblDirty
            // 
            this.lblDirty.AutoSize = true;
            this.lblDirty.Location = new System.Drawing.Point(53, 65);
            this.lblDirty.Name = "lblDirty";
            this.lblDirty.Size = new System.Drawing.Size(67, 13);
            this.lblDirty.TabIndex = 3;
            this.lblDirty.Text = "Dirty Rooms:";
            // 
            // checkA
            // 
            this.checkA.AutoSize = true;
            this.checkA.Location = new System.Drawing.Point(135, 65);
            this.checkA.Name = "checkA";
            this.checkA.Size = new System.Drawing.Size(33, 17);
            this.checkA.TabIndex = 2;
            this.checkA.Text = "A";
            this.checkA.UseVisualStyleBackColor = true;
            // 
            // cbStartLocation
            // 
            this.cbStartLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartLocation.FormattingEnabled = true;
            this.cbStartLocation.Items.AddRange(new object[] {
            "Random",
            "A",
            "B",
            "C",
            "D"});
            this.cbStartLocation.Location = new System.Drawing.Point(132, 35);
            this.cbStartLocation.Name = "cbStartLocation";
            this.cbStartLocation.Size = new System.Drawing.Size(73, 21);
            this.cbStartLocation.TabIndex = 1;
            this.cbStartLocation.SelectedIndexChanged += new System.EventHandler(this.cbStartLocation_SelectedIndexChanged);
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Location = new System.Drawing.Point(33, 38);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(93, 13);
            this.lblStartLocation.TabIndex = 0;
            this.lblStartLocation.Text = "Starting Location: ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(550, 425);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(680, 425);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAction);
            this.groupBox1.Location = new System.Drawing.Point(550, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 178);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions Taken";
            // 
            // tbAction
            // 
            this.tbAction.Location = new System.Drawing.Point(6, 26);
            this.tbAction.Name = "tbAction";
            this.tbAction.ReadOnly = true;
            this.tbAction.Size = new System.Drawing.Size(238, 146);
            this.tbAction.TabIndex = 0;
            this.tbAction.Text = "";
            // 
            // pnlD
            // 
            this.pnlD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlD.Location = new System.Drawing.Point(276, 248);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(200, 200);
            this.pnlD.TabIndex = 8;
            // 
            // pnlB
            // 
            this.pnlB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlB.Location = new System.Drawing.Point(276, 47);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(200, 200);
            this.pnlB.TabIndex = 6;
            // 
            // pnlC
            // 
            this.pnlC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlC.Location = new System.Drawing.Point(75, 248);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(200, 200);
            this.pnlC.TabIndex = 7;
            // 
            // pnlA
            // 
            this.pnlA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlA.Location = new System.Drawing.Point(75, 47);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(200, 200);
            this.pnlA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "D";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pnlD);
            this.Controls.Add(this.pnlB);
            this.Controls.Add(this.pnlC);
            this.Controls.Add(this.pnlA);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbSettingsManual);
            this.Controls.Add(this.gbSettingsMode);
            this.Name = "Form1";
            this.Text = "Simple Reflex Agent";
            this.gbSettingsMode.ResumeLayout(false);
            this.gbSettingsMode.PerformLayout();
            this.gbSettingsManual.ResumeLayout(false);
            this.gbSettingsManual.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSettingsMode;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.GroupBox gbSettingsManual;
        private System.Windows.Forms.CheckBox checkD;
        private System.Windows.Forms.CheckBox checkC;
        private System.Windows.Forms.CheckBox checkB;
        private System.Windows.Forms.Label lblDirty;
        private System.Windows.Forms.CheckBox checkA;
        private System.Windows.Forms.ComboBox cbStartLocation;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.Panel pnlB;
        private System.Windows.Forms.Panel pnlD;
        private System.Windows.Forms.Panel pnlC;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

