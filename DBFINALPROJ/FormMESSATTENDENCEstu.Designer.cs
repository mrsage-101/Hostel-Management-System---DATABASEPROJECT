namespace DBFINALPROJ
{
    partial class FormMESSATTENDENCEstu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMESSATTENDENCEstu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnINSERT = new System.Windows.Forms.Button();
            this.comboATT = new System.Windows.Forms.ComboBox();
            this.textROLLNO = new System.Windows.Forms.TextBox();
            this.comboBATCH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnINSERT);
            this.panel1.Controls.Add(this.comboATT);
            this.panel1.Controls.Add(this.textROLLNO);
            this.panel1.Controls.Add(this.comboBATCH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 470);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(496, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnINSERT
            // 
            this.btnINSERT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnINSERT.BackgroundImage")));
            this.btnINSERT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnINSERT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINSERT.Location = new System.Drawing.Point(496, 266);
            this.btnINSERT.Name = "btnINSERT";
            this.btnINSERT.Size = new System.Drawing.Size(80, 29);
            this.btnINSERT.TabIndex = 8;
            this.btnINSERT.Text = "INSERT";
            this.btnINSERT.UseVisualStyleBackColor = true;
            this.btnINSERT.Click += new System.EventHandler(this.btnINSERT_Click);
            // 
            // comboATT
            // 
            this.comboATT.FormattingEnabled = true;
            this.comboATT.Items.AddRange(new object[] {
            "PRESENT",
            "ABSENT"});
            this.comboATT.Location = new System.Drawing.Point(462, 205);
            this.comboATT.Name = "comboATT";
            this.comboATT.Size = new System.Drawing.Size(201, 21);
            this.comboATT.TabIndex = 7;
            // 
            // textROLLNO
            // 
            this.textROLLNO.Location = new System.Drawing.Point(528, 171);
            this.textROLLNO.Name = "textROLLNO";
            this.textROLLNO.Size = new System.Drawing.Size(135, 20);
            this.textROLLNO.TabIndex = 6;
            this.textROLLNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textROLLNO_KeyPress);
            // 
            // comboBATCH
            // 
            this.comboBATCH.FormattingEnabled = true;
            this.comboBATCH.Items.AddRange(new object[] {
            "19F",
            "20F",
            "21F",
            "22F"});
            this.comboBATCH.Location = new System.Drawing.Point(462, 170);
            this.comboBATCH.Name = "comboBATCH";
            this.comboBATCH.Size = new System.Drawing.Size(59, 21);
            this.comboBATCH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(346, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "ATTENDENCE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(364, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "STUDENT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(406, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(463, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 13, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(334, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MESS ATTENDENCE DASHBOARD";
            // 
            // FormMESSATTENDENCEstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 495);
            this.Controls.Add(this.panel1);
            this.Name = "FormMESSATTENDENCEstu";
            this.Text = "FormMESSATTENDENCEstu";
            this.Load += new System.EventHandler(this.FormMESSATTENDENCEstu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboATT;
        private System.Windows.Forms.TextBox textROLLNO;
        private System.Windows.Forms.ComboBox comboBATCH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnINSERT;
    }
}