
namespace DosyaBul
{
    partial class DosyaBulFrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secilendizinbtn = new System.Windows.Forms.Button();
            this.secilensurucucmb = new System.Windows.Forms.ComboBox();
            this.secilendizinrb = new System.Windows.Forms.RadioButton();
            this.secilensurucurb = new System.Windows.Forms.RadioButton();
            this.tumsurucurb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.arabtn = new System.Windows.Forms.Button();
            this.aratxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.durumlbl = new System.Windows.Forms.Label();
            this.sonuclarlst = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uzantilarlst = new System.Windows.Forms.ListBox();
            this.uzantieklebtn = new System.Windows.Forms.Button();
            this.uzantilarcmb = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secilendizinbtn);
            this.groupBox1.Controls.Add(this.secilensurucucmb);
            this.groupBox1.Controls.Add(this.secilendizinrb);
            this.groupBox1.Controls.Add(this.secilensurucurb);
            this.groupBox1.Controls.Add(this.tumsurucurb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // secilendizinbtn
            // 
            this.secilendizinbtn.Location = new System.Drawing.Point(145, 125);
            this.secilendizinbtn.Name = "secilendizinbtn";
            this.secilendizinbtn.Size = new System.Drawing.Size(65, 23);
            this.secilendizinbtn.TabIndex = 2;
            this.secilendizinbtn.Text = "Seç";
            this.secilendizinbtn.UseVisualStyleBackColor = true;
            this.secilendizinbtn.Click += new System.EventHandler(this.secilendizinbtn_Click);
            // 
            // secilensurucucmb
            // 
            this.secilensurucucmb.FormattingEnabled = true;
            this.secilensurucucmb.Location = new System.Drawing.Point(145, 80);
            this.secilensurucucmb.Name = "secilensurucucmb";
            this.secilensurucucmb.Size = new System.Drawing.Size(65, 24);
            this.secilensurucucmb.TabIndex = 3;
            // 
            // secilendizinrb
            // 
            this.secilendizinrb.AutoSize = true;
            this.secilendizinrb.Location = new System.Drawing.Point(15, 126);
            this.secilendizinrb.Name = "secilendizinrb";
            this.secilendizinrb.Size = new System.Drawing.Size(110, 21);
            this.secilendizinrb.TabIndex = 2;
            this.secilendizinrb.TabStop = true;
            this.secilendizinrb.Text = "Seçilen Dizin";
            this.secilendizinrb.UseVisualStyleBackColor = true;
            // 
            // secilensurucurb
            // 
            this.secilensurucurb.AutoSize = true;
            this.secilensurucurb.Location = new System.Drawing.Point(15, 81);
            this.secilensurucurb.Name = "secilensurucurb";
            this.secilensurucurb.Size = new System.Drawing.Size(124, 21);
            this.secilensurucurb.TabIndex = 1;
            this.secilensurucurb.TabStop = true;
            this.secilensurucurb.Text = "Seçilen Sürücü";
            this.secilensurucurb.UseVisualStyleBackColor = true;
            this.secilensurucurb.CheckedChanged += new System.EventHandler(this.secilensurucurb_CheckedChanged);
            // 
            // tumsurucurb
            // 
            this.tumsurucurb.AutoSize = true;
            this.tumsurucurb.Location = new System.Drawing.Point(15, 35);
            this.tumsurucurb.Name = "tumsurucurb";
            this.tumsurucurb.Size = new System.Drawing.Size(122, 21);
            this.tumsurucurb.TabIndex = 0;
            this.tumsurucurb.TabStop = true;
            this.tumsurucurb.Text = "Tüm Sürücüler";
            this.tumsurucurb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.arabtn);
            this.groupBox2.Controls.Add(this.aratxt);
            this.groupBox2.Location = new System.Drawing.Point(234, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aranan";
            // 
            // arabtn
            // 
            this.arabtn.Location = new System.Drawing.Point(607, 34);
            this.arabtn.Name = "arabtn";
            this.arabtn.Size = new System.Drawing.Size(75, 23);
            this.arabtn.TabIndex = 1;
            this.arabtn.Text = "Ara";
            this.arabtn.UseVisualStyleBackColor = true;
            this.arabtn.Click += new System.EventHandler(this.arabtn_Click);
            // 
            // aratxt
            // 
            this.aratxt.Location = new System.Drawing.Point(23, 33);
            this.aratxt.Name = "aratxt";
            this.aratxt.Size = new System.Drawing.Size(560, 22);
            this.aratxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.durumlbl);
            this.groupBox3.Controls.Add(this.sonuclarlst);
            this.groupBox3.Location = new System.Drawing.Point(234, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 345);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sonuçlar";
            // 
            // durumlbl
            // 
            this.durumlbl.AutoSize = true;
            this.durumlbl.Location = new System.Drawing.Point(20, 307);
            this.durumlbl.Name = "durumlbl";
            this.durumlbl.Size = new System.Drawing.Size(0, 17);
            this.durumlbl.TabIndex = 1;
            // 
            // sonuclarlst
            // 
            this.sonuclarlst.FormattingEnabled = true;
            this.sonuclarlst.ItemHeight = 16;
            this.sonuclarlst.Location = new System.Drawing.Point(23, 28);
            this.sonuclarlst.Name = "sonuclarlst";
            this.sonuclarlst.Size = new System.Drawing.Size(665, 260);
            this.sonuclarlst.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uzantilarlst);
            this.groupBox4.Controls.Add(this.uzantieklebtn);
            this.groupBox4.Controls.Add(this.uzantilarcmb);
            this.groupBox4.Location = new System.Drawing.Point(12, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 238);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dosya Uzantısı";
            // 
            // uzantilarlst
            // 
            this.uzantilarlst.FormattingEnabled = true;
            this.uzantilarlst.ItemHeight = 16;
            this.uzantilarlst.Location = new System.Drawing.Point(15, 101);
            this.uzantilarlst.Name = "uzantilarlst";
            this.uzantilarlst.Size = new System.Drawing.Size(183, 116);
            this.uzantilarlst.TabIndex = 2;
            // 
            // uzantieklebtn
            // 
            this.uzantieklebtn.Location = new System.Drawing.Point(123, 60);
            this.uzantieklebtn.Name = "uzantieklebtn";
            this.uzantieklebtn.Size = new System.Drawing.Size(75, 23);
            this.uzantieklebtn.TabIndex = 1;
            this.uzantieklebtn.Text = "Ekle";
            this.uzantieklebtn.UseVisualStyleBackColor = true;
            this.uzantieklebtn.Click += new System.EventHandler(this.uzantieklebtn_Click);
            // 
            // uzantilarcmb
            // 
            this.uzantilarcmb.FormattingEnabled = true;
            this.uzantilarcmb.Items.AddRange(new object[] {
            ".AIF ",
            ".AU ",
            ".AVI ",
            ".BAT",
            ".BMP ",
            ".CLASS",
            ".CSV ",
            ".CVS ",
            ".DAT",
            ".DBF ",
            ".DIF ",
            ".DOC",
            ".DOCX ",
            ".EPS ",
            ".EXE ",
            ".FM3 ",
            ".GIF ",
            ".HQX ",
            ".HTM ",
            ".HTML",
            ".JPG",
            ".JPEG",
            ".MAC ",
            ".MAP ",
            ".MDB ",
            ".MID ",
            ".MOV",
            ".MTB ",
            ".PDF",
            ".P65",
            ".T65 ",
            ".PNG ",
            ".PPT ",
            ".PPTX ",
            ".PSD \t",
            ".PSP \t",
            ".QXD \t",
            ".RA \t",
            ".RTF \t",
            ".SIT \t",
            ".TAR \t",
            ".TIF ",
            ".TXT ",
            ".WAV ",
            ".WK3 ",
            ".WKS ",
            "WPD ",
            ".XLS",
            ".XLSX \t",
            ".ZIP "});
            this.uzantilarcmb.Location = new System.Drawing.Point(15, 30);
            this.uzantilarcmb.Name = "uzantilarcmb";
            this.uzantilarcmb.Size = new System.Drawing.Size(183, 24);
            this.uzantilarcmb.TabIndex = 0;
            // 
            // DosyaBulFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DosyaBulFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Bul V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button arabtn;
        private System.Windows.Forms.TextBox aratxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button secilendizinbtn;
        private System.Windows.Forms.ComboBox secilensurucucmb;
        private System.Windows.Forms.RadioButton secilendizinrb;
        private System.Windows.Forms.RadioButton secilensurucurb;
        private System.Windows.Forms.RadioButton tumsurucurb;
        private System.Windows.Forms.ListBox uzantilarlst;
        private System.Windows.Forms.Button uzantieklebtn;
        private System.Windows.Forms.ComboBox uzantilarcmb;
        private System.Windows.Forms.ListBox sonuclarlst;
        private System.Windows.Forms.Label durumlbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

