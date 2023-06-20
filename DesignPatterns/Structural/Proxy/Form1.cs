namespace Proxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //srvTcKimlik.KPSPublicSoapClient kPSPublicSoapClient = new srvTcKimlik.KPSPublicSoapClient();
            //var response = await kPSPublicSoapClient.TCKimlikNoDogrulaAsync(212121, "", "",1980);


            MathProxy mathProxy = new MathProxy(new RealMath());
            var result = mathProxy.Add(3, 5);
            MessageBox.Show(result.ToString());


        }
    }
}