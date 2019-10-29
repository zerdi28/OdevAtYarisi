namespace AtYarisi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYarisiStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnYarisiYenidenBaşlat = new System.Windows.Forms.Button();
            this.lbGüncelSiralama = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pcFinish = new System.Windows.Forms.PictureBox();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1664, 10);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1667, 10);
            this.label2.TabIndex = 1;
            // 
            // btnYarisiStart
            // 
            this.btnYarisiStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYarisiStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYarisiStart.ForeColor = System.Drawing.Color.White;
            this.btnYarisiStart.Location = new System.Drawing.Point(3, 12);
            this.btnYarisiStart.Name = "btnYarisiStart";
            this.btnYarisiStart.Size = new System.Drawing.Size(377, 56);
            this.btnYarisiStart.TabIndex = 5;
            this.btnYarisiStart.Text = "Yarışı Başlat";
            this.btnYarisiStart.UseVisualStyleBackColor = true;
            this.btnYarisiStart.Click += new System.EventHandler(this.btnYarisiStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-3, 690);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1667, 10);
            this.label3.TabIndex = 6;
            // 
            // btnYarisiYenidenBaşlat
            // 
            this.btnYarisiYenidenBaşlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYarisiYenidenBaşlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYarisiYenidenBaşlat.ForeColor = System.Drawing.Color.White;
            this.btnYarisiYenidenBaşlat.Location = new System.Drawing.Point(1217, 12);
            this.btnYarisiYenidenBaşlat.Name = "btnYarisiYenidenBaşlat";
            this.btnYarisiYenidenBaşlat.Size = new System.Drawing.Size(377, 56);
            this.btnYarisiYenidenBaşlat.TabIndex = 7;
            this.btnYarisiYenidenBaşlat.Text = "Yarışı Yeniden Başlat";
            this.btnYarisiYenidenBaşlat.UseVisualStyleBackColor = true;
            this.btnYarisiYenidenBaşlat.Click += new System.EventHandler(this.btnYarisiYenidenBaşlat_Click);
            // 
            // lbGüncelSiralama
            // 
            this.lbGüncelSiralama.BackColor = System.Drawing.Color.Black;
            this.lbGüncelSiralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbGüncelSiralama.ForeColor = System.Drawing.Color.White;
            this.lbGüncelSiralama.Location = new System.Drawing.Point(400, 12);
            this.lbGüncelSiralama.Name = "lbGüncelSiralama";
            this.lbGüncelSiralama.Size = new System.Drawing.Size(794, 71);
            this.lbGüncelSiralama.TabIndex = 8;
            this.lbGüncelSiralama.Text = "Güncel Sıralama";
            this.lbGüncelSiralama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-3, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1667, 10);
            this.label6.TabIndex = 10;
            // 
            // pcFinish
            // 
            this.pcFinish.Image = global::AtYarisi.Properties.Resources.Finish_jpg1;
            this.pcFinish.Location = new System.Drawing.Point(1515, 95);
            this.pcFinish.Name = "pcFinish";
            this.pcFinish.Size = new System.Drawing.Size(160, 605);
            this.pcFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcFinish.TabIndex = 11;
            this.pcFinish.TabStop = false;
            // 
            // pc3
            // 
            this.pc3.Image = global::AtYarisi.Properties.Resources.horse5;
            this.pc3.Location = new System.Drawing.Point(3, 531);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(281, 156);
            this.pc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc3.TabIndex = 4;
            this.pc3.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.Image = global::AtYarisi.Properties.Resources.horse3;
            this.pc2.Location = new System.Drawing.Point(0, 329);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(281, 156);
            this.pc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc2.TabIndex = 3;
            this.pc2.TabStop = false;
            // 
            // pc1
            // 
            this.pc1.Image = global::AtYarisi.Properties.Resources.horse1;
            this.pc1.Location = new System.Drawing.Point(3, 130);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(281, 156);
            this.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc1.TabIndex = 2;
            this.pc1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1665, 784);
            this.Controls.Add(this.pcFinish);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbGüncelSiralama);
            this.Controls.Add(this.btnYarisiYenidenBaşlat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYarisiStart);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pc1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.Button btnYarisiStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYarisiYenidenBaşlat;
        private System.Windows.Forms.Label lbGüncelSiralama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcFinish;
    }
}

