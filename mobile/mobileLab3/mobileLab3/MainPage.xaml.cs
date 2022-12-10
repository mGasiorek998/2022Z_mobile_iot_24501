namespace mobileLab3;

public partial class MainPage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public MainPage()
	{
		InitializeComponent();
        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }
    }

    void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Delete Clicked !");
    }
    void OnSaveButtonClicked(object sender, EventArgs e)
    {
        Console.WriteLine("Save Clicked !");
    }

}


