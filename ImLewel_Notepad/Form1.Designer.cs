namespace ImLewel_Notepad
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.panel = new System.Windows.Forms.FlowLayoutPanel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileBtn = new System.Windows.Forms.ToolStripMenuItem();
      this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
      this.loadBtn = new System.Windows.Forms.ToolStripMenuItem();
      this.findBtn = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.markBtn = new System.Windows.Forms.Button();
      this.boldBtn = new System.Windows.Forms.Button();
      this.italicBtn = new System.Windows.Forms.Button();
      this.underlineBtn = new System.Windows.Forms.Button();
      this.regularBtn = new System.Windows.Forms.Button();
      this.colorBtn = new System.Windows.Forms.Button();
      this.clearBtn = new System.Windows.Forms.Button();
      this.textField = new System.Windows.Forms.RichTextBox();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.panel.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel
      // 
      this.panel.BackColor = System.Drawing.Color.BurlyWood;
      this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel.Controls.Add(this.menuStrip1);
      this.panel.Controls.Add(this.findBtn);
      this.panel.Controls.Add(this.comboBox1);
      this.panel.Controls.Add(this.numericUpDown1);
      this.panel.Controls.Add(this.markBtn);
      this.panel.Controls.Add(this.boldBtn);
      this.panel.Controls.Add(this.italicBtn);
      this.panel.Controls.Add(this.underlineBtn);
      this.panel.Controls.Add(this.regularBtn);
      this.panel.Controls.Add(this.colorBtn);
      this.panel.Controls.Add(this.clearBtn);
      this.panel.Location = new System.Drawing.Point(0, 0);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(900, 46);
      this.panel.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.Beige;
      this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileBtn});
      this.menuStrip1.Location = new System.Drawing.Point(6, 3);
      this.menuStrip1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
      this.menuStrip1.Size = new System.Drawing.Size(89, 36);
      this.menuStrip1.Stretch = false;
      this.menuStrip1.TabIndex = 8;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileBtn
      // 
      this.fileBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBtn,
            this.loadBtn});
      this.fileBtn.Image = ((System.Drawing.Image)(resources.GetObject("fileBtn.Image")));
      this.fileBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.fileBtn.Name = "fileBtn";
      this.fileBtn.Padding = new System.Windows.Forms.Padding(0);
      this.fileBtn.Size = new System.Drawing.Size(81, 36);
      this.fileBtn.Text = "Файл";
      this.fileBtn.ToolTipText = "Файл";
      // 
      // saveBtn
      // 
      this.saveBtn.BackColor = System.Drawing.Color.Cornsilk;
      this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(182, 26);
      this.saveBtn.Text = "Зберегти";
      this.saveBtn.ToolTipText = "Зберегти";
      this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
      // 
      // loadBtn
      // 
      this.loadBtn.BackColor = System.Drawing.Color.Cornsilk;
      this.loadBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadBtn.Image")));
      this.loadBtn.Name = "loadBtn";
      this.loadBtn.Size = new System.Drawing.Size(182, 26);
      this.loadBtn.Text = "Завантажити";
      this.loadBtn.ToolTipText = "Завантажити";
      this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
      // 
      // findBtn
      // 
      this.findBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.findBtn.BackColor = System.Drawing.Color.Cornsilk;
      this.findBtn.FlatAppearance.BorderSize = 0;
      this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.findBtn.Image = ((System.Drawing.Image)(resources.GetObject("findBtn.Image")));
      this.findBtn.Location = new System.Drawing.Point(101, 3);
      this.findBtn.Name = "findBtn";
      this.findBtn.Size = new System.Drawing.Size(36, 36);
      this.findBtn.TabIndex = 9;
      this.findBtn.UseVisualStyleBackColor = false;
      this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
      // 
      // comboBox1
      // 
      this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.comboBox1.BackColor = System.Drawing.Color.Beige;
      this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.comboBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.IntegralHeight = false;
      this.comboBox1.Location = new System.Drawing.Point(143, 7);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(265, 27);
      this.comboBox1.TabIndex = 3;
      this.comboBox1.Text = "Calibri";
      this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
      this.comboBox1.SelectedValueChanged += new System.EventHandler(this.FontAtributesChanged);
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.numericUpDown1.BackColor = System.Drawing.Color.Beige;
      this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.numericUpDown1.Location = new System.Drawing.Point(414, 8);
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(62, 26);
      this.numericUpDown1.TabIndex = 2;
      this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numericUpDown1.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.FontAtributesChanged);
      // 
      // markBtn
      // 
      this.markBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.markBtn.BackColor = System.Drawing.Color.Beige;
      this.markBtn.FlatAppearance.BorderSize = 0;
      this.markBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.markBtn.Image = ((System.Drawing.Image)(resources.GetObject("markBtn.Image")));
      this.markBtn.Location = new System.Drawing.Point(482, 3);
      this.markBtn.Name = "markBtn";
      this.markBtn.Size = new System.Drawing.Size(36, 36);
      this.markBtn.TabIndex = 10;
      this.markBtn.UseVisualStyleBackColor = false;
      this.markBtn.Click += new System.EventHandler(this.styleBtns_Click);
      // 
      // boldBtn
      // 
      this.boldBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.boldBtn.BackColor = System.Drawing.Color.Beige;
      this.boldBtn.FlatAppearance.BorderSize = 0;
      this.boldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.boldBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.boldBtn.Location = new System.Drawing.Point(524, 3);
      this.boldBtn.Name = "boldBtn";
      this.boldBtn.Size = new System.Drawing.Size(36, 36);
      this.boldBtn.TabIndex = 4;
      this.boldBtn.Text = "B";
      this.boldBtn.UseVisualStyleBackColor = false;
      this.boldBtn.Click += new System.EventHandler(this.styleBtns_Click);
      // 
      // italicBtn
      // 
      this.italicBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.italicBtn.BackColor = System.Drawing.Color.Beige;
      this.italicBtn.FlatAppearance.BorderSize = 0;
      this.italicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.italicBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
      this.italicBtn.Location = new System.Drawing.Point(566, 3);
      this.italicBtn.Name = "italicBtn";
      this.italicBtn.Size = new System.Drawing.Size(36, 36);
      this.italicBtn.TabIndex = 5;
      this.italicBtn.Text = "I";
      this.italicBtn.UseVisualStyleBackColor = false;
      this.italicBtn.Click += new System.EventHandler(this.styleBtns_Click);
      // 
      // underlineBtn
      // 
      this.underlineBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.underlineBtn.BackColor = System.Drawing.Color.Beige;
      this.underlineBtn.FlatAppearance.BorderSize = 0;
      this.underlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.underlineBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
      this.underlineBtn.Location = new System.Drawing.Point(608, 3);
      this.underlineBtn.Name = "underlineBtn";
      this.underlineBtn.Size = new System.Drawing.Size(36, 36);
      this.underlineBtn.TabIndex = 6;
      this.underlineBtn.Text = "U";
      this.underlineBtn.UseVisualStyleBackColor = false;
      this.underlineBtn.Click += new System.EventHandler(this.styleBtns_Click);
      // 
      // regularBtn
      // 
      this.regularBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.regularBtn.BackColor = System.Drawing.Color.Beige;
      this.regularBtn.FlatAppearance.BorderSize = 0;
      this.regularBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.regularBtn.Location = new System.Drawing.Point(650, 3);
      this.regularBtn.Name = "regularBtn";
      this.regularBtn.Size = new System.Drawing.Size(36, 36);
      this.regularBtn.TabIndex = 7;
      this.regularBtn.Text = "R";
      this.regularBtn.UseVisualStyleBackColor = false;
      this.regularBtn.Click += new System.EventHandler(this.styleBtns_Click);
      // 
      // colorBtn
      // 
      this.colorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.colorBtn.BackColor = System.Drawing.Color.Beige;
      this.colorBtn.FlatAppearance.BorderSize = 0;
      this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.colorBtn.Image = ((System.Drawing.Image)(resources.GetObject("colorBtn.Image")));
      this.colorBtn.Location = new System.Drawing.Point(692, 3);
      this.colorBtn.Name = "colorBtn";
      this.colorBtn.Size = new System.Drawing.Size(36, 36);
      this.colorBtn.TabIndex = 12;
      this.colorBtn.UseVisualStyleBackColor = false;
      this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
      // 
      // clearBtn
      // 
      this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.clearBtn.BackColor = System.Drawing.Color.Beige;
      this.clearBtn.FlatAppearance.BorderSize = 0;
      this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
      this.clearBtn.Location = new System.Drawing.Point(734, 3);
      this.clearBtn.Name = "clearBtn";
      this.clearBtn.Size = new System.Drawing.Size(36, 36);
      this.clearBtn.TabIndex = 11;
      this.clearBtn.UseVisualStyleBackColor = false;
      this.clearBtn.Click += new System.EventHandler(this.styleBtns_Click);
      // 
      // textField
      // 
      this.textField.AcceptsTab = true;
      this.textField.BackColor = System.Drawing.Color.Beige;
      this.textField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textField.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.textField.Location = new System.Drawing.Point(0, 46);
      this.textField.Name = "textField";
      this.textField.Size = new System.Drawing.Size(900, 409);
      this.textField.TabIndex = 1;
      this.textField.Text = "";
      this.textField.FontChanged += new System.EventHandler(this.textField_SomethingChanged);
      this.textField.TextChanged += new System.EventHandler(this.textField_SomethingChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.BurlyWood;
      this.ClientSize = new System.Drawing.Size(900, 450);
      this.Controls.Add(this.textField);
      this.Controls.Add(this.panel);
      this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "ImLewel Notebook";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.panel.ResumeLayout(false);
      this.panel.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private FlowLayoutPanel panel;
    internal RichTextBox textField;
    private ComboBox comboBox1;
    private NumericUpDown numericUpDown1;
    private Button boldBtn;
    private Button italicBtn;
    private Button underlineBtn;
    private Button regularBtn;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileBtn;
    private ToolStripMenuItem saveBtn;
    private ToolStripMenuItem loadBtn;
    private Button findBtn;
    private Button markBtn;
    private Button clearBtn;
    private Button colorBtn;
    private ColorDialog colorDialog1;
  }
}