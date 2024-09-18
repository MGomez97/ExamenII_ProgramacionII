namespace ExamenII__ProgramacionII
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public object CounterBtn { get; private set; }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn = $"Clicked {count} time";
            else
                CounterBtn = $"Clicked {count} times";

            SemanticScreenReader.Announce((string)CounterBtn);
        }
    }

}
