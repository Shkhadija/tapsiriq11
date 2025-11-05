namespace panel_yaratma
{
    public partial class Form1 : Form
    {
        int panelSayi = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPanelYarat_Click(object sender, EventArgs e)
        {
            Panel p = new Panel();
            p.Size = new Size(50, 50);
            p.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            p.Left = rnd.Next(0, this.ClientSize.Width - p.Width);
            p.Top = rnd.Next(0, this.ClientSize.Height - p.Height - 100);

            this.Controls.Add(p);
            panelSayi++;
            panel.Text = panelSayi.ToString();


            if (p.Bounds.IntersectsWith(picBomba.Bounds))
            {
                MessageBox.Show("💥 Oyun bitdi!");
                OyunuDayandir();
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is Panel && this.Controls[i].Name != "picBomba")
                {
                    this.Controls.RemoveAt(i);
                }
            }

            panelSayi = 0;
            panel.Text = "0";

            picBomba.Left = rnd.Next(0, this.ClientSize.Width - picBomba.Width);
            picBomba.Top = rnd.Next(0, this.ClientSize.Height - picBomba.Height - 100);
        }

        private void OyunuDayandir()
        {
            btnPanelYarat.Enabled = false;
        }
    }

}
