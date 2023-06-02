using MaterialSkin;
using MaterialSkin.Controls;

namespace DNSManager
{
    public partial class MessageForm : MaterialForm
    {
        public MessageForm(String Text, String BtnText)
        {
            InitializeComponent();
            InitializeSkin();

            materialLabel1.Text = Text;
            buttonDone.Text = BtnText;
        }

        public MessageForm(String Title, String Text, String BtnText)
        {
            InitializeComponent();
            InitializeSkin();

            materialLabel1.Text = Text;
            materialLabel2.Text = Title;
            buttonDone.Text = BtnText;

            materialLabel2.Visible = true;
        }

        Action _Btn1Click, _Btn2Click;
        public MessageForm(String Title, String Text, String Btn1Text, String Btn2Text, Action Btn1Click, Action Btn2Click)
        {
            InitializeComponent();
            InitializeSkin();

            materialLabel1.Text = Text;
            materialLabel2.Text = Title;
            buttonDone.Text = Btn1Text;
            buttonCancel.Text = Btn2Text;

            buttonCancel.Visible = true;
            materialLabel2.Visible = true;

            _Btn1Click = Btn1Click;
            _Btn2Click = Btn2Click;
        }


        private void InitializeSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple400, Primary.Purple900, Primary.Purple900, Accent.Purple200, TextShade.WHITE);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (_Btn1Click != null)
            {
                _Btn1Click();
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (_Btn2Click != null)
            {
                _Btn2Click();
            }
            this.Close();
        }
    }
}
