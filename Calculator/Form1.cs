namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            KetQua = a + b;
            txtKetQua.Text= KetQua.ToString();
        }
    }
}