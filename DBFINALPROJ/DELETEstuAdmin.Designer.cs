namespace DBFINALPROJ
{
    partial class DELETEstuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DELETEstuAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textROLL = new System.Windows.Forms.TextBox();
            this.comboBATCH = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnBACK);
            this.panel1.Controls.Add(this.btnUPDATE);
            this.panel1.Controls.Add(this.textROLL);
            this.panel1.Controls.Add(this.comboBATCH);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 485);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(369, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 39);
            this.label1.TabIndex = 48;
            this.label1.Text = "DELETE STUDENT INFO";
            // 
            // textROLL
            // 
            this.textROLL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textROLL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textROLL.Location = new System.Drawing.Point(513, 172);
            this.textROLL.Name = "textROLL";
            this.textROLL.Size = new System.Drawing.Size(75, 20);
            this.textROLL.TabIndex = 51;
            this.textROLL.Text = "ROLLNO";
            this.textROLL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textROLL_KeyPress);
            // 
            // comboBATCH
            // 
            this.comboBATCH.FormattingEnabled = true;
            this.comboBATCH.Items.AddRange(new object[] {
            "19F",
            "20F",
            "21F",
            "22F"});
            this.comboBATCH.Location = new System.Drawing.Point(423, 171);
            this.comboBATCH.Name = "comboBATCH";
            this.comboBATCH.Size = new System.Drawing.Size(62, 21);
            this.comboBATCH.TabIndex = 50;
            this.comboBATCH.Text = "BATCH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(474, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "SEARCH";
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUPDATE.BackgroundImage")));
            this.btnUPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUPDATE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Location = new System.Drawing.Point(442, 229);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(125, 35);
            this.btnUPDATE.TabIndex = 59;
            this.btnUPDATE.Text = "DELETE";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBACK.BackgroundImage")));
            this.btnBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBACK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.Location = new System.Drawing.Point(442, 270);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(125, 35);
            this.btnBACK.TabIndex = 60;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // DELETEstuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 510);
            this.Controls.Add(this.panel1);
            this.Name = "DELETEstuAdmin";
            this.Text = "DELETEstuAdmin";
            this.Load += new System.EventHandler(this.DELETEstuAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textROLL;
        private System.Windows.Forms.ComboBox comboBATCH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnBACK;
    }
}