using INQ.Inquisitor.App.Extensions;
using INQ.Inquisitor.App.Functional.Search.Article.NewsAPI.Extensions;
using INQ.Inquisitor.App.Functional.Search.Image.Pixabay;
using INQ.Inquisitor.App.Functional.Search.Telephone.TelSearch;
using INQ.Inquisitor.App.Functional.Search.Username.Facebook;
using INQ.Inquisitor.App.Functional.Search.Username.Twitter;
using INQ.Inquisitor.App.Technical.Extensions;
using INQ.Inquisitor.Model.Article;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            var response = await App.Functional.Search.Article.NewsAPI.NewsAPI_Searcher.SearchArticles(
                new ArticleSearchQuestion
                {
                    QuestionText = query
                });

            lbl_News_ResultFoundAmount.Text = $@"{response.Articles?.Count ?? 0} results found";

            var filteredArticles = response.Articles?.WhereContainsQuery(query).ToList();

            lbl_News_ResultFilteredAmount.Text = $@"{response.Articles?.Count ?? 0 - filteredArticles?.Count ?? 0} results filtered";
            txtBox_News_Results.Text = filteredArticles?.ToText();
        }
    }

    private async void TxtBox_Image_Query_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            var query = txtBox_News_Query.Text;
            var images = await Pixabay_Searcher.SearchImages(query);

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

    private async void TxtBox_Telephone_Query_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            var query = txtBox_Telephone_Query.Text;
            // TODO: validate if telephone number + feedback to user
            var data = await TelSearch.Search_PhoneNumber(query);

            txtBox_Telephone_Results.Text = JsonConvert.SerializeObject(data, formatting: Formatting.Indented);
        }
    }

    private async void txtBox_Twitter_Query_KeyPress(object sender, KeyPressEventArgs e)
    {

        if (e.KeyChar == (char)Keys.Enter)
        {
            var query = txtBox_Twitter_Query.Text;

            var users = await Twitter_Searcher.Search_User(query);

            txtBox_Twitter_Results.Text = JsonConvert.SerializeObject(users, formatting: Formatting.Indented); 
        }
    }

    private void txtBox_FB_Query_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            var query = txtBox_FB_Query.Text;

            var users = Facebook_Searcher.Search_Users(query);

            txtBox_FB_Results.Text = JsonConvert.SerializeObject(users, formatting: Formatting.Indented); 
        }
    }
}
