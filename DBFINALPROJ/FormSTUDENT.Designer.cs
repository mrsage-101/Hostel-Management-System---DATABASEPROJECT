namespace DBFINALPROJ
{
    partial class FormSTUDENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSTUDENT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.comboBATCH = new System.Windows.Forms.ComboBox();
            this.textPASSWORD = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnBACK);
            this.panel1.Controls.Add(this.btnLOGIN);
            this.panel1.Controls.Add(this.comboBATCH);
            this.panel1.Controls.Add(this.textPASSWORD);
            this.panel1.Controls.Add(this.textID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 476);
            this.panel1.TabIndex = 0;
            // 
            // btnBACK
            // 
            this.btnBACK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBACK.BackgroundImage")));
            this.btnBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBACK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.Location = new System.Drawing.Point(493, 279);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(81, 28);
            this.btnBACK.TabIndex = 8;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLOGIN.BackgroundImage")));
            this.btnLOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLOGIN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGIN.Location = new System.Drawing.Point(493, 245);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(81, 28);
            this.btnLOGIN.TabIndex = 7;
            this.btnLOGIN.Text = "LOGIN";
            this.btnLOGIN.UseVisualStyleBackColor = true;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // comboBATCH
            // 
            this.comboBATCH.FormattingEnabled = true;
            this.comboBATCH.Items.AddRange(new object[] {
            "19F",
            "20F",
            "21F",
            "22F"});
            this.comboBATCH.Location = new System.Drawing.Point(448, 159);
            this.comboBATCH.Name = "comboBATCH";
            this.comboBATCH.Size = new System.Drawing.Size(52, 21);
            this.comboBATCH.TabIndex = 6;
            this.comboBATCH.SelectedIndexChanged += new System.EventHandler(this.comboBATCH_SelectedIndexChanged);
            this.comboBATCH.Click += new System.EventHandler(this.comboBATCH_Click);
            // 
            // textPASSWORD
            // 
            this.textPASSWORD.Location = new System.Drawing.Point(448, 195);
            this.textPASSWORD.Name = "textPASSWORD";
            this.textPASSWORD.Size = new System.Drawing.Size(190, 20);
            this.textPASSWORD.TabIndex = 5;
            this.textPASSWORD.Click += new System.EventHandler(this.textPASSWORD_Click);
            this.textPASSWORD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPASSWORD_KeyPress);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(502, 160);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(136, 20);
            this.textID.TabIndex = 4;
            this.textID.Click += new System.EventHandler(this.textID_Click);
            this.textID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(349, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(349, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "STUDENT ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(426, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT LOG IN ";
            // 
            // FormSTUDENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 501);
            this.Controls.Add(this.panel1);
            this.Name = "FormSTUDENT";
            this.Text = "FormSTUDENT";
            this.Load += new System.EventHandler(this.FormSTUDENT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPASSWORD;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.ComboBox comboBATCH;
    }
}