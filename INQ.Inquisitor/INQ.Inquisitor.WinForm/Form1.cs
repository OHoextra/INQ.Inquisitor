using INQ.Inquisitor.App.Extensions;

namespace INQ.Inquisitor.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void txtBox_News_Query_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var articles = await App.Inquisitor.SearchNewsArticles(txtBox_News_Query.Text);

                lbl_News_ResultAmount.Text = $@"{articles.Count} results";
                txtBox_News_Results.Text = articles.ToText();
            }
        }
    }
}