namespace photobox_alpha
{
  partial class Form1
  {
    /// <summary>
    /// 設計工具所需的變數。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清除任何使用中的資源。
    /// </summary>
    /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 設計工具產生的程式碼

    /// <summary>
    /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
    /// 修改這個方法的內容。
    /// </summary>
    private void InitializeComponent()
    {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.label3 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(3, 1);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(287, 274);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.textBox2);
      this.tabPage1.Controls.Add(this.label6);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.linkLabel2);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.button3);
      this.tabPage1.Controls.Add(this.button2);
      this.tabPage1.Controls.Add(this.textBox1);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(279, 248);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "主設定";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 56);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(33, 12);
      this.label3.TabIndex = 4;
      this.label3.Text = "label3";
      this.label3.Visible = false;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(197, 215);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 3;
      this.button3.Text = "儲存設定";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(197, 29);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "選擇目錄";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(113, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "請選擇要監視的目錄";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.button1);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Controls.Add(this.linkLabel1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(279, 248);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "關於";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Enabled = false;
      this.button1.Location = new System.Drawing.Point(8, 32);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(92, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "購買付費空間";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 17);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(146, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "您已經使用 %d / %d 的空間";
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(6, 140);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(121, 12);
      this.linkLabel1.TabIndex = 0;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "http://ha2.tw/photo_drop";
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Location = new System.Drawing.Point(6, 104);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(55, 12);
      this.linkLabel2.TabIndex = 5;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "linkLabel2";
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 83);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 12);
      this.label4.TabIndex = 6;
      this.label4.Text = "您的相本主頁";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(8, 130);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(161, 12);
      this.label5.TabIndex = 7;
      this.label5.Text = "您也可以選用您想要的名稱：";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.label6.Location = new System.Drawing.Point(4, 149);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(193, 19);
      this.label6.TabIndex = 8;
      this.label6.Text = "http://ha2.tw/photo_drop/";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(197, 149);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 22);
      this.textBox2.TabIndex = 9;
      // 
      // textBox1
      // 
      this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::photobox_alpha.Properties.Settings.Default, "WatchDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.textBox1.Location = new System.Drawing.Point(8, 31);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(183, 22);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = global::photobox_alpha.Properties.Settings.Default.WatchDirectory;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Controls.Add(this.tabControl1);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "photoDrop";
      this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
  }
}

