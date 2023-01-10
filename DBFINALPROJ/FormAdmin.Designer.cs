namespace DBFINALPROJ
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnINSERT = new System.Windows.Forms.Button();
            this.textPASSWORD = new System.Windows.Forms.TextBox();
            this.textUSERNAME = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.btnINSERT);
            this.panel1.Controls.Add(this.textPASSWORD);
            this.panel1.Controls.Add(this.textUSERNAME);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 484);
            this.panel1.TabIndex = 0;
            // 
            // btnBACK
            // 
            this.btnBACK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBACK.BackgroundImage")));
            this.btnBACK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBACK.Location = new System.Drawing.Point(485, 304);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(78, 29);
            this.btnBACK.TabIndex = 6;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // btnINSERT
            // 
            this.btnINSERT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnINSERT.BackgroundImage")));
            this.btnINSERT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnINSERT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINSERT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnINSERT.Location = new System.Drawing.Point(485, 269);
            this.btnINSERT.Name = "btnINSERT";
            this.btnINSERT.Size = new System.Drawing.Size(78, 29);
            this.btnINSERT.TabIndex = 5;
            this.btnINSERT.Text = "LOGIN";
            this.btnINSERT.UseVisualStyleBackColor = true;
            this.btnINSERT.Click += new System.EventHandler(this.btnINSERT_Click);
            // 
            // textPASSWORD
            // 
            this.textPASSWORD.Location = new System.Drawing.Point(444, 207);
            this.textPASSWORD.Name = "textPASSWORD";
            this.textPASSWORD.Size = new System.Drawing.Size(174, 20);
            this.textPASSWORD.TabIndex = 4;
            this.textPASSWORD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPASSWORD_KeyPress);
            // 
            // textUSERNAME
            // 
            this.textUSERNAME.Location = new System.Drawing.Point(447, 157);
            this.textUSERNAME.Name = "textUSERNAME";
            this.textUSERNAME.Size = new System.Drawing.Size(169, 20);
            this.textUSERNAME.TabIndex = 3;
            this.textUSERNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUSERNAME_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(341, 207);
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
            this.label2.Location = new System.Drawing.Point(345, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(437, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN LOGIN";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 509);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnINSERT;
        private System.Windows.Forms.TextBox textPASSWORD;
        private System.Windows.Forms.TextBox textUSERNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}