namespace ImLewel_Notepad {
  public partial class Form1 : Form {
    OpenFileDialog fd;
    FindWindow findWindow;

    string caption = "ImLewel Notebook";

    string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
    string path;

    private bool saved = false;
    public bool Saved {
      get { return (saved); }
      set { saved = value; Text = saved == false ? $"{caption} (не збережено)" : caption; }
    }

    public Form1() {
      InitializeComponent();
      loadFonts();
      fd = new() {
        InitialDirectory = @"C:\Users\" + user + @"\Desktop",
        RestoreDirectory = true,
      };
      findWindow = new(textField);
      numericUpDown1.ValueChanged += FontAtributesChanged;

    }

    void loadFonts() {
      foreach (FontFamily font in FontFamily.Families)
        comboBox1.Items.Add(font.Name);
    }

    Font Update_Font(FontStyle style) => new Font(comboBox1.Text, (float)numericUpDown1.Value, style);
    Font Update_Font() => new Font(comboBox1.Text, (float)numericUpDown1.Value);

    private void Form1_Resize(object sender, EventArgs e) {
      panel.Width = this.Width;
      textField.Height = this.Height - panel.Height;
      textField.Width = this.Width;
    }

    private void FontAtributesChanged(object sender, EventArgs e) {
      textField.SelectionFont = Update_Font();
      Saved = false;
    }
    private void styleBtns_Click(object sender, EventArgs e) {
      Button btn = sender as Button;
      if (btn == regularBtn)
        textField.SelectionFont = Update_Font(FontStyle.Regular);
      if (btn == italicBtn)
        textField.SelectionFont = Update_Font(FontStyle.Italic);
      if (btn == boldBtn)
        textField.SelectionFont = Update_Font(FontStyle.Bold);
      if (btn == underlineBtn)
        textField.SelectionFont = Update_Font(FontStyle.Underline);
      if (btn == clearBtn)
        textField.Clear();
      if (btn == markBtn) {
        if (textField.SelectionBullet == false) {
          textField.SelectionBullet = true;
          textField.SelectionIndent = 20;
          textField.BulletIndent = 10;
        }
        else {
          textField.SelectionBullet = default;
          textField.SelectionIndent = default;
          textField.BulletIndent = default;
        }
      }
      Saved = false;
    }
    private void saveBtn_Click(object sender, EventArgs e) => Save();

    void Save() {
      if (path != null && File.Exists(path)) {
        textField.SaveFile(path);
        Saved = true;
      }
      else {
        if (fd.ShowDialog() == DialogResult.OK) {
          path = fd.FileName;
          textField.SaveFile(path);
          Saved = true;
        }
      }
    }

    private void loadBtn_Click(object sender, EventArgs e) {
      if (fd.ShowDialog() == DialogResult.OK) {
        path = fd.FileName;
        textField.LoadFile(path);
        Saved = true;
      }
    }

    private void findBtn_Click(object sender, EventArgs e) {
      if (!findWindow.Visible)
        findWindow.Show();
      else
        findWindow.Hide();
    }

    private void colorBtn_Click(object sender, EventArgs e) {
      if (colorDialog1.ShowDialog() == DialogResult.OK) {
        textField.SelectionColor = colorDialog1.Color;
        Saved = false;
      }
    }

    private void comboBox1_DrawItem(object sender, DrawItemEventArgs e) {
      Font font = new Font(comboBox1.Items[e.Index].ToString(), 9);
      if (e.Font != font)
        e.Graphics.DrawString(comboBox1.Items[e.Index].ToString(), font, Brushes.Black, e.Bounds);

    }

    private void textField_SomethingChanged(object sender, EventArgs e) => Saved = false;

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
      if (Saved == false) {
        if (MessageBox.Show("Файл не збережено, бажаєте зберегти?", "Увага!", MessageBoxButtons.OKCancel) == DialogResult.OK) {
          Save();
        }
      }
    }

  }
}