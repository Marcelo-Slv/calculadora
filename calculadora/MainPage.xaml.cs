namespace calculadora
{
    public partial class MainPage : ContentPage
    {
        private double _total;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBillChanged(object? sender, TextChangedEventArgs e)
        {
            CalcularGorjeta();
        }

        private void Gorjeta15PorcentoButton_Clicked(object? sender, EventArgs e)
        {
            PorcentagemGorjetaSlider.Value = 15;
        }

        private void Gorjeta20PorcentoButton_Clicked(object? sender, EventArgs e)
        {
            PorcentagemGorjetaSlider.Value = 20;
        }

        private void ArredondarParaCimaButton_Clicked(object? sender, EventArgs e)
        {
            ValorTotaldaCompraLabel.Text = Math.Ceiling(_total).ToString("F2");
        }

        private void ArredondarParaBaixoButton_Clicked(object? sender, EventArgs e)
        {
            ValorTotaldaCompraLabel.Text = Math.Floor(_total).ToString("F2");
        }

        private void CalcularGorjeta()
        {
            if (double.TryParse(billInput.Text, out double conta))
            {
                double percentual = PorcentagemGorjetaSlider.Value;
                double gorjeta = conta * (percentual / 100);
                _total = conta + gorjeta;

                tipOutput.Text = gorjeta.ToString("F2");
                ValorTotaldaCompraLabel.Text = _total.ToString("F2");
            }
        }

        private void PorcentagemGorjetaSlider_ValueChanged(object? sender, ValueChangedEventArgs e)
        {
            tipPercent.Text = $"{Math.Round(e.NewValue)}%";
            CalcularGorjeta();
        }
    }
}