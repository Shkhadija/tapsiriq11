namespace tapsiriq11
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            txtPanelSay.Text = "0";
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is PictureBox pb && pb != pictureBox1)
                {
                    this.Controls.RemoveAt(i);
                }
            }

            txtPanelSay.Text = "0";
        }

        private void btnPanelYarat_Click(object sender, EventArgs e)
        {

            int say = int.Parse(txtPanelSay.Text);
            say++; 

            
            PictureBox bomba = new PictureBox();
            bomba.Size = new Size(50, 50);
            bomba.Image = pictureBox1.Image; 
            bomba.SizeMode = PictureBoxSizeMode.Zoom;

            Random rnd = new Random();
            bomba.Left = rnd.Next(0, this.ClientSize.Width - bomba.Width);
            bomba.Top = rnd.Next(0, this.ClientSize.Height - bomba.Height - 100);

            this.Controls.Add(bomba);

          
            txtPanelSay.Text = say.ToString();
        }

      
    }
}
