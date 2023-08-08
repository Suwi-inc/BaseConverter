namespace BaseConverter
{
    public partial class Form1 : Form
    {
        public string InputBaseTen { get; set; }
        public string OutputBaseTwo { get; set; }
        public string OutputHexidecimal { get; set; }
        Hexidecimal hexidecimal { get; set; } = new Hexidecimal();
        BaseTwo baseTwo { get; set; } = new BaseTwo();
        public Form1()
        {
            InitializeComponent();
        }
        private void InnitValues()
        {
            InputBaseTen = TextBox_Input.Text;
        }

        private void Btn_Convert_Click(object sender, EventArgs e)
        {
            InnitValues();
            TextBox_output_basetwo.Text = baseTwo.Convert(double.Parse(InputBaseTen)).ToString();
            TextBox_output_hexidecimal.Text = hexidecimal.Convert(double.Parse(InputBaseTen)).ToString();

        }
    }
}