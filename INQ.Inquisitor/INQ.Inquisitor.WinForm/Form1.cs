using INQ.Inquisitor.App.Extensions;

namespace INQ.Inquisitor.WinForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void TxtBox_News_Query_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            var query = txtBox_News_Query.Text;
            var articles = await App.Inquisitor.SearchNewsArticles(query);

            lbl_News_ResultFoundAmount.Text = $@"{articles.Count} results found";

            var filteredArticles = articles.WhereContainsQuery(query).ToList();


            lbl_News_ResultFilteredAmount.Text = $@"{articles.Count - filteredArticles.Count} results filtered";
            txtBox_News_Results.Text = filteredArticles.ToText();
        }
    }

    private async void RichTextBox1_KeyPressAsync(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            var query = txtBox_News_Query.Text;
            var images = await App.Inquisitor.SearchImages(query);

            lbl_News_ResultFoundAmount.Text = $@"{images.Count} results found";

            var imageIndex = 0;
            foreach (var image in images)
            {
                imageIndex++;
                var tabPage = new TabPage("Image " + imageIndex);
                var picBox = new PictureBox { SizeMode = PictureBoxSizeMode.AutoSize};
                picBox.LoadAsync(image.LargeImageURL);
                if (picBox.Width > tabPage.Width) tabPage.Width = picBox.Width;
                if (picBox.Height > tabPage.Height) tabPage.Height = picBox.Height;
                if (tabPage.Width > tabControl_Images.Width) tabControl_Images.Width = tabPage.Width;
                if (tabPage.Height > tabControl_Images.Height) tabControl_Images.Height = tabPage.Height;
                var activeForm = ActiveForm;
                if (activeForm != null)
                {
                    if (tabControl_Images.Width > activeForm.Width) activeForm.Width = tabControl_Images.Width;
                    if (tabControl_Images.Height > activeForm.Height) activeForm.Height = tabControl_Images.Height;
                }
                tabPage.Controls.Add(picBox);
                tabControl_Images.TabPages.Add(tabPage);
                //TODO: Perhaps add some resizing logic
            }
        }
    }
}
