namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Her nesnenin sadece 1 sorumlulu?u vard?r:
         * - Bir nesnede de?i?iklik (yeni bir metot yazmak veya metodun i�ini de?i?tirmek) i�in birden fazla motivasyonunuz varsa bu ilkeyi ihlal ediyordunuz
         */

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            decimal price = decimal.Parse(textBox2.Text);

            ProductService productService = new ProductService();
            productService.AddProduct(name, price);
            /*B�t�n �r�n ekleme i?lemleri burada yap?l?yor*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Mail at?l?yor*/
        }

        public void RaporOlustur()
        {

        }
    }
}