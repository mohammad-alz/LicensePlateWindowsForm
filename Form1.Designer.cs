
namespace LicensePlateWindowsForm
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
            this.fileAddress_txt = new System.Windows.Forms.TextBox();
            this.Plate_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Proccess_Btn = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Browse_Btn = new System.Windows.Forms.PictureBox();
            this.Browse_md_Btn = new System.Windows.Forms.PictureBox();
            this.Browse_h_Btn = new System.Windows.Forms.PictureBox();
            this.Proccess_md_Btn = new System.Windows.Forms.PictureBox();
            this.Proccess_h_Btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proccess_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse_md_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse_h_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proccess_md_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proccess_h_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // fileAddress_txt
            // 
            this.fileAddress_txt.BackColor = System.Drawing.Color.LightGray;
            this.fileAddress_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileAddress_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileAddress_txt.Location = new System.Drawing.Point(146, 383);
            this.fileAddress_txt.Name = "fileAddress_txt";
            this.fileAddress_txt.Size = new System.Drawing.Size(466, 27);
            this.fileAddress_txt.TabIndex = 3;
            this.fileAddress_txt.TextChanged += new System.EventHandler(this.fileAddress_txt_TextChanged);
            // 
            // Plate_lbl
            // 
            this.Plate_lbl.AutoSize = true;
            this.Plate_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Plate_lbl.Font = new System.Drawing.Font("B Nazanin", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Plate_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Plate_lbl.Location = new System.Drawing.Point(258, 522);
            this.Plate_lbl.Name = "Plate_lbl";
            this.Plate_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Plate_lbl.Size = new System.Drawing.Size(0, 49);
            this.Plate_lbl.TabIndex = 9;
            this.Plate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LicensePlateWindowsForm.Properties.Resources.Plate_txt1;
            this.pictureBox1.Location = new System.Drawing.Point(48, 528);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Proccess_Btn
            // 
            this.Proccess_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Proccess_Btn.Image = global::LicensePlateWindowsForm.Properties.Resources.Proccess;
            this.Proccess_Btn.Location = new System.Drawing.Point(261, 452);
            this.Proccess_Btn.Name = "Proccess_Btn";
            this.Proccess_Btn.Size = new System.Drawing.Size(116, 35);
            this.Proccess_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Proccess_Btn.TabIndex = 5;
            this.Proccess_Btn.TabStop = false;
            this.Proccess_Btn.MouseEnter += new System.EventHandler(this.Proccess_Btn_MouseEnter);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(146, 66);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(341, 256);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // Browse_Btn
            // 
            this.Browse_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Browse_Btn.Image = global::LicensePlateWindowsForm.Properties.Resources.Browse_Simple;
            this.Browse_Btn.Location = new System.Drawing.Point(30, 373);
            this.Browse_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Browse_Btn.Name = "Browse_Btn";
            this.Browse_Btn.Size = new System.Drawing.Size(83, 46);
            this.Browse_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Browse_Btn.TabIndex = 0;
            this.Browse_Btn.TabStop = false;
            this.Browse_Btn.MouseEnter += new System.EventHandler(this.Browse_Btn_MouseEnter);
            // 
            // Browse_md_Btn
            // 
            this.Browse_md_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Browse_md_Btn.Image = global::LicensePlateWindowsForm.Properties.Resources.Browse_MouseDown;
            this.Browse_md_Btn.Location = new System.Drawing.Point(30, 373);
            this.Browse_md_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Browse_md_Btn.Name = "Browse_md_Btn";
            this.Browse_md_Btn.Size = new System.Drawing.Size(83, 46);
            this.Browse_md_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Browse_md_Btn.TabIndex = 2;
            this.Browse_md_Btn.TabStop = false;
            this.Browse_md_Btn.Visible = false;
            // 
            // Browse_h_Btn
            // 
            this.Browse_h_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Browse_h_Btn.Image = global::LicensePlateWindowsForm.Properties.Resources.Browse_Hover2;
            this.Browse_h_Btn.Location = new System.Drawing.Point(30, 373);
            this.Browse_h_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Browse_h_Btn.Name = "Browse_h_Btn";
            this.Browse_h_Btn.Size = new System.Drawing.Size(83, 46);
            this.Browse_h_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Browse_h_Btn.TabIndex = 1;
            this.Browse_h_Btn.TabStop = false;
            this.Browse_h_Btn.Visible = false;
            this.Browse_h_Btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Browse_h_Btn_MouseDown);
            this.Browse_h_Btn.MouseLeave += new System.EventHandler(this.Browse_h_Btn_MouseLeave);
            this.Browse_h_Btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Browse_h_Btn_MouseUp);
            // 
            // Proccess_md_Btn
            // 
            this.Proccess_md_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Proccess_md_Btn.Image = global::LicensePlateWindowsForm.Properties.Resources.Proccess_MouseDown;
            this.Proccess_md_Btn.Location = new System.Drawing.Point(261, 452);
            this.Proccess_md_Btn.Name = "Proccess_md_Btn";
            this.Proccess_md_Btn.Size = new System.Drawing.Size(116, 35);
            this.Proccess_md_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Proccess_md_Btn.TabIndex = 7;
            this.Proccess_md_Btn.TabStop = false;
            this.Proccess_md_Btn.Visible = false;
            // 
            // Proccess_h_Btn
            // 
            this.Proccess_h_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Proccess_h_Btn.Image = global::LicensePlateWindowsForm.Properties.Resources.Proccess_Hover;
            this.Proccess_h_Btn.Location = new System.Drawing.Point(261, 452);
            this.Proccess_h_Btn.Name = "Proccess_h_Btn";
            this.Proccess_h_Btn.Size = new System.Drawing.Size(116, 35);
            this.Proccess_h_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Proccess_h_Btn.TabIndex = 6;
            this.Proccess_h_Btn.TabStop = false;
            this.Proccess_h_Btn.Visible = false;
            this.Proccess_h_Btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Proccess_h_Btn_MouseDown);
            this.Proccess_h_Btn.MouseLeave += new System.EventHandler(this.Proccess_h_Btn_MouseLeave);
            this.Proccess_h_Btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Proccess_h_Btn_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LicensePlateWindowsForm.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(652, 623);
            this.Controls.Add(this.Plate_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Proccess_Btn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.fileAddress_txt);
            this.Controls.Add(this.Browse_Btn);
            this.Controls.Add(this.Browse_md_Btn);
            this.Controls.Add(this.Browse_h_Btn);
            this.Controls.Add(this.Proccess_md_Btn);
            this.Controls.Add(this.Proccess_h_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plate Detector";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proccess_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse_md_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browse_h_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proccess_md_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proccess_h_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Browse_Btn;
        private System.Windows.Forms.PictureBox Browse_h_Btn;
        private System.Windows.Forms.PictureBox Browse_md_Btn;
        private System.Windows.Forms.TextBox fileAddress_txt;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox Proccess_Btn;
        private System.Windows.Forms.PictureBox Proccess_h_Btn;
        private System.Windows.Forms.PictureBox Proccess_md_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Plate_lbl;
    }
}

