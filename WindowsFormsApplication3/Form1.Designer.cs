namespace WindowsFormsApplication3
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
            this.btnCNN = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnSBS = new System.Windows.Forms.Button();
            this.btnReuters = new System.Windows.Forms.Button();
            this.btnBBC = new System.Windows.Forms.Button();
            this.btnNYT = new System.Windows.Forms.Button();
            this.btnABS = new System.Windows.Forms.Button();
            this.btnGMA = new System.Windows.Forms.Button();
            this.btnInquirer = new System.Windows.Forms.Button();
            this.btnPhilstar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnMB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.summaryText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCNN
            // 
            this.btnCNN.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCNN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCNN.Location = new System.Drawing.Point(15, 54);
            this.btnCNN.Name = "btnCNN";
            this.btnCNN.Size = new System.Drawing.Size(53, 27);
            this.btnCNN.TabIndex = 1;
            this.btnCNN.Text = "CNN";
            this.btnCNN.UseVisualStyleBackColor = false;
            this.btnCNN.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(16, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 289);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(6, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(728, 541);
            this.webBrowser1.TabIndex = 4;
            // 
            // btnNews
            // 
            this.btnNews.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNews.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNews.Location = new System.Drawing.Point(74, 54);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(92, 27);
            this.btnNews.TabIndex = 5;
            this.btnNews.Text = "NEWS.COM";
            this.btnNews.UseVisualStyleBackColor = false;
            this.btnNews.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSBS
            // 
            this.btnSBS.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSBS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSBS.Location = new System.Drawing.Point(172, 54);
            this.btnSBS.Name = "btnSBS";
            this.btnSBS.Size = new System.Drawing.Size(64, 27);
            this.btnSBS.TabIndex = 6;
            this.btnSBS.Text = "SBS";
            this.btnSBS.UseVisualStyleBackColor = false;
            this.btnSBS.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReuters
            // 
            this.btnReuters.BackColor = System.Drawing.Color.AliceBlue;
            this.btnReuters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReuters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReuters.Location = new System.Drawing.Point(242, 54);
            this.btnReuters.Name = "btnReuters";
            this.btnReuters.Size = new System.Drawing.Size(64, 27);
            this.btnReuters.TabIndex = 7;
            this.btnReuters.Text = "Reuters";
            this.btnReuters.UseVisualStyleBackColor = false;
            this.btnReuters.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBBC
            // 
            this.btnBBC.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBBC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBC.Location = new System.Drawing.Point(312, 54);
            this.btnBBC.Name = "btnBBC";
            this.btnBBC.Size = new System.Drawing.Size(64, 27);
            this.btnBBC.TabIndex = 8;
            this.btnBBC.Text = "BBC";
            this.btnBBC.UseVisualStyleBackColor = false;
            this.btnBBC.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnNYT
            // 
            this.btnNYT.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNYT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNYT.Location = new System.Drawing.Point(382, 54);
            this.btnNYT.Name = "btnNYT";
            this.btnNYT.Size = new System.Drawing.Size(82, 27);
            this.btnNYT.TabIndex = 9;
            this.btnNYT.Text = "NY Times";
            this.btnNYT.UseVisualStyleBackColor = false;
            this.btnNYT.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnABS
            // 
            this.btnABS.BackColor = System.Drawing.Color.AliceBlue;
            this.btnABS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnABS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABS.Location = new System.Drawing.Point(382, 92);
            this.btnABS.Name = "btnABS";
            this.btnABS.Size = new System.Drawing.Size(82, 27);
            this.btnABS.TabIndex = 10;
            this.btnABS.Text = "ABS-CBN";
            this.btnABS.UseVisualStyleBackColor = false;
            this.btnABS.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnGMA
            // 
            this.btnGMA.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGMA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGMA.Location = new System.Drawing.Point(15, 92);
            this.btnGMA.Name = "btnGMA";
            this.btnGMA.Size = new System.Drawing.Size(53, 27);
            this.btnGMA.TabIndex = 11;
            this.btnGMA.Text = "GMA";
            this.btnGMA.UseVisualStyleBackColor = false;
            this.btnGMA.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnInquirer
            // 
            this.btnInquirer.BackColor = System.Drawing.Color.AliceBlue;
            this.btnInquirer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInquirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquirer.Location = new System.Drawing.Point(74, 92);
            this.btnInquirer.Name = "btnInquirer";
            this.btnInquirer.Size = new System.Drawing.Size(92, 27);
            this.btnInquirer.TabIndex = 12;
            this.btnInquirer.Text = "Inquirer";
            this.btnInquirer.UseVisualStyleBackColor = false;
            this.btnInquirer.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnPhilstar
            // 
            this.btnPhilstar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPhilstar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhilstar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhilstar.Location = new System.Drawing.Point(172, 92);
            this.btnPhilstar.Name = "btnPhilstar";
            this.btnPhilstar.Size = new System.Drawing.Size(92, 27);
            this.btnPhilstar.TabIndex = 13;
            this.btnPhilstar.Text = "Philstar";
            this.btnPhilstar.UseVisualStyleBackColor = false;
            this.btnPhilstar.Click += new System.EventHandler(this.button10_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // btnMB
            // 
            this.btnMB.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMB.Location = new System.Drawing.Point(270, 92);
            this.btnMB.Name = "btnMB";
            this.btnMB.Size = new System.Drawing.Size(106, 27);
            this.btnMB.TabIndex = 15;
            this.btnMB.Text = "Manila Bulletin";
            this.btnMB.UseVisualStyleBackColor = false;
            this.btnMB.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(520, 13);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 544);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(342, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Read More";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // summaryText
            // 
            this.summaryText.BackColor = System.Drawing.SystemColors.Info;
            this.summaryText.Location = new System.Drawing.Point(16, 439);
            this.summaryText.Name = "summaryText";
            this.summaryText.Size = new System.Drawing.Size(448, 79);
            this.summaryText.TabIndex = 18;
            this.summaryText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1263, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.summaryText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPhilstar);
            this.Controls.Add(this.btnInquirer);
            this.Controls.Add(this.btnGMA);
            this.Controls.Add(this.btnABS);
            this.Controls.Add(this.btnNYT);
            this.Controls.Add(this.btnBBC);
            this.Controls.Add(this.btnReuters);
            this.Controls.Add(this.btnSBS);
            this.Controls.Add(this.btnNews);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCNN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "RSS News Reader by Jason Penafiel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCNN;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnSBS;
        private System.Windows.Forms.Button btnReuters;
        private System.Windows.Forms.Button btnBBC;
        private System.Windows.Forms.Button btnNYT;
        private System.Windows.Forms.Button btnABS;
        private System.Windows.Forms.Button btnGMA;
        private System.Windows.Forms.Button btnInquirer;
        private System.Windows.Forms.Button btnPhilstar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox summaryText;
        private System.Windows.Forms.Label label2;
    }
}

