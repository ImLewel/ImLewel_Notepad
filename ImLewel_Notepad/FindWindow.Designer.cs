namespace ImLewel_Notepad
{
  partial class FindWindow
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
      this.searchPrompt = new System.Windows.Forms.TextBox();
      this.replacePrompt = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.runBtn = new System.Windows.Forms.Button();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // searchPrompt
      // 
      this.searchPrompt.Location = new System.Drawing.Point(12, 32);
      this.searchPrompt.Name = "searchPrompt";
      this.searchPrompt.Size = new System.Drawing.Size(401, 27);
      this.searchPrompt.TabIndex = 0;
      // 
      // replacePrompt
      // 
      this.replacePrompt.Location = new System.Drawing.Point(12, 115);
      this.replacePrompt.Name = "replacePrompt";
      this.replacePrompt.Size = new System.Drawing.Size(401, 27);
      this.replacePrompt.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Знайти";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 92);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(94, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Замінити на";
      // 
      // runBtn
      // 
      this.runBtn.Location = new System.Drawing.Point(12, 148);
      this.runBtn.Name = "runBtn";
      this.runBtn.Size = new System.Drawing.Size(94, 29);
      this.runBtn.TabIndex = 6;
      this.runBtn.Text = "Виконати";
      this.runBtn.UseVisualStyleBackColor = true;
      this.runBtn.Click += new System.EventHandler(this.SearchOrReplace);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(12, 65);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(123, 24);
      this.checkBox1.TabIndex = 7;
      this.checkBox1.Text = "Показати все";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Пусто",
            "Ціле слово",
            "Враховувати регістр"});
      this.comboBox1.Location = new System.Drawing.Point(152, 65);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(199, 28);
      this.comboBox1.TabIndex = 8;
      this.comboBox1.Text = "Пусто";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
      this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
      this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
      // 
      // FindWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(430, 191);
      this.ControlBox = false;
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.runBtn);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.replacePrompt);
      this.Controls.Add(this.searchPrompt);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FindWindow";
      this.Text = "Знайти (та замінити)";
      this.VisibleChanged += new System.EventHandler(this.FindWindow_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox searchPrompt;
    private TextBox replacePrompt;
    private Label label1;
    private Label label2;
    private Button runBtn;
    private CheckBox checkBox1;
    private ComboBox comboBox1;
  }
}