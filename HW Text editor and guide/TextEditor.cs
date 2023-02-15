using TextBox = System.Windows.Forms.TextBox;

namespace HW_Text_editor_and_guide
{
    public partial class TextEditor : Form
    {
        string openedPath = "";
        private TextBox textBoxCansel=new TextBox();
        public TextEditor()
        {
            InitializeComponent();
            this.Text = "Later, the path to the file will appear here";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.Text = openedPath = ofd.FileName;
                StreamReader reader = File.OpenText(ofd.FileName);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }
        void SaveFileAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(*.txt) | *.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                openedPath = sfd.FileName;
                SaveFile(sfd.FileName);
            }
        }
        private void SaveFile(string path)
        {
            StreamWriter write = new StreamWriter(path);
            write.Write(textBox1.Text);
            write.Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openedPath == "")
            {
                SaveFileAs();
            }
            else SaveFile(openedPath);
        }

        private void NewDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCansel.Text = textBox1.Text;
            openedPath = "";
            textBox1.Text = "";
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.SelectedText.ToString());
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCansel.Text = textBox1.Text;
            textBox1.Text += Clipboard.GetText();
        }

        private void CutOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCansel.Text = textBox1.Text;
            Clipboard.SetText(textBox1.SelectedText.ToString());
            string text = textBox1.Text;
            string del = Clipboard.GetText();
            textBox1.Text = text.Remove(text.IndexOf(del), del.Length);
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBoxCansel.Text;
        }

        private void GreenTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Green;
        }

        private void YellowTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Yellow;

        }

        private void BlueTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Blue;
        }

        private void GreenBackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.Green;
        }

        private void YellowBackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.Yellow;

        }

        private void BlueBackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.Blue;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();

        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void BestUAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        private void BanderaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Italic);
        }
    }
}
