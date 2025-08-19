namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int yPos = 70;

        private void sendbtn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Bitte geben Sie einen Text ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                RadioButton rb = new RadioButton();
                rb.Text = textBox1.Text;
                rb.Location = new Point(25, yPos);
                textBox1.Clear();

                Button bearb = new Button();
                bearb.Text = "Bearbeiten";
                bearb.Location = new Point(225, yPos);
                this.Controls.Add(bearb);
                bearb.Size = new Size(120, 30);
                bearb.BackColor = Color.OrangeRed;

                rb.Click += (s, ev) =>
                {
                    this.Controls.Remove(rb);
                    this.Controls.Remove(bearb);

                    // alle neu anordnen
                    int y = 70;
                    foreach (RadioButton r in this.Controls.OfType<RadioButton>())
                    {
                        r.Location = new Point(25, y);
                        y += 40;
                    }

                    foreach (Button bearb in this.Controls.OfType<Button>().Where(b => b.Name == "bearb").ToList())
                    {
                        bearb.Location = new Point(25, y);
                        y -= 40;
                    }
                    yPos = y;

                };

                this.Controls.Add(rb);
                yPos += 40;
            }
        }


    }
}
