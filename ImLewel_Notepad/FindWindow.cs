
namespace ImLewel_Notepad {
  public partial class FindWindow : Form {
    RichTextBox rtb;
    int lastPos = 0;
    RichTextBoxFinds type;
    public FindWindow(RichTextBox _rtb) {
      InitializeComponent();
      rtb = _rtb;
    }
    void SearchOrReplace(object sender, EventArgs e) {
      if (replacePrompt.Text != "")
        Replace(searchPrompt.Text, replacePrompt.Text);
      else
        Selector(ref lastPos);
    }

    void Selector(ref int start) {
      if (start >= rtb.TextLength)
        start = 0;
      if (checkBox1.Checked)
        start = 0;

      rtb.SelectAll();
      rtb.SelectionBackColor = Color.Beige;
      rtb.DeselectAll();

      for (int index = start; index < rtb.TextLength; ++index) {
        if (checkBox1.Checked) {
          rtb.Find(searchPrompt.Text, index, rtb.TextLength, type);
          rtb.SelectionBackColor = Color.Yellow;
        }
        else {
          int res = rtb.Find(searchPrompt.Text, index, index + searchPrompt.Text.Length, type);
          rtb.SelectionBackColor = Color.Yellow;
          start = index + 1;
          if (res != -1)
            return;
        }
      }
    }

    private void Replace(string from, string to) {
      for (int index = 0; index < rtb.TextLength; ++index) {
        int start = rtb.Find(from, index, RichTextBoxFinds.None);
        if (start != -1) {
          rtb.Select(start, from.Length);
          rtb.SelectedText = to;
        }
      }
    }

    private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e) {
      switch (comboBox1.Text) {
        case "Пусто":
          type = RichTextBoxFinds.None;
          break;
        case "Ціле слово":
          type = RichTextBoxFinds.WholeWord;
          break;
        case "Враховувати регістр":
          type = RichTextBoxFinds.MatchCase;
          break;
      }
    }

    private void FindWindow_VisibleChanged(object sender, EventArgs e) {
      rtb.SelectAll();
      rtb.SelectionBackColor = Color.Beige;
      rtb.DeselectAll();
    }
  }
}
