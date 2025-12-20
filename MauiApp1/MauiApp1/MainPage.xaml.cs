namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTaskCheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            if (e.Value)
            {
                TaskLabel.TextDecorations = TextDecorations.Strikethrough;

                await DisplayAlert("Task Completa", "Você concluiu a tarefa, parabens!", "OK");
            }
            else
            {
                TaskLabel.TextDecorations = TextDecorations.None;
            }
        }
    }
}
