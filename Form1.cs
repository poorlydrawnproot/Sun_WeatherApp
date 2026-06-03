namespace Sun_WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var sunwx = new SunWxService();
            InitializeComponent();
            int temp = sunwx.getSunTemp();
            string tempStr = temp.ToString();
            currTemp.Text = tempStr + "K";
            locName.Text = "The Sun";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
