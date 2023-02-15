namespace HW_Text_editor_and_guide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextEditor_Click(object sender, EventArgs e)
        {
            TextEditor text = new TextEditor();
            text.ShowDialog();
        }

        private void Conductor_Click(object sender, EventArgs e)
        {
            Conductor conductor = new Conductor();
            conductor.ShowDialog();
        }
    }
}