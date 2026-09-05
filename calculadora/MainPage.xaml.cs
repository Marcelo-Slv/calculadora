namespace calculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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

        }

        private void ArredondarParaBaixoButton_Clicked(object? sender, EventArgs e)
        {

            PorcentagemGorjetaLabel.Text = $"{Math.Round(PorcentagemGorjetaSlider.Value, 1)} %";
            double valorDaConta = Convert.ToDouble(ContaEntry.Text);
            double porcentagemDaGorjeta = PorcentagemGorjetaSlider.Value / 100;
            double valorDaGorjeta = valorDaConta * porcentagemDaGorjeta;
            GorjetaLabel.Text = Convert.ToString(valorDaGorjeta);
            double ValorTotal = valorDaConta + valorDaGorjeta;
            ValorTotalTeste.Text = ValorTotal.ToString();

            double ValorGorjeta = Convert.ToDouble(GorjetaLabel.Text);
            double ValorTotalMesmo = Convert.ToDouble(GorjetaLabel.Text) + Convert.ToDouble(ValorTotalTeste.Text);
            GorjetaLabel.Text = Math.Floor(ValorGorjeta).ToString();

            ValorTotalLabel.Text = Convert.ToString(ValorTotalMesmo);






        }



        private void PorcentagemGorjetaSlider_ValueChanged(object? sender, ValueChangedEventArgs e)
        {

            PorcentagemGorjetaLabel.Text = $"{Math.Round(PorcentagemGorjetaSlider.Value, 1)} %";
            double valorDaConta = Convert.ToDouble(ContaEntry.Text);
            double porcentagemDaGorjeta = PorcentagemGorjetaSlider.Value / 100;
            double valorDaGorjeta = valorDaConta * porcentagemDaGorjeta;
            GorjetaLabel.Text = Convert.ToString(valorDaGorjeta);
            double ValorTotal = valorDaConta + valorDaGorjeta;
            ValorTotalLabel.Text = ValorTotal.ToString();







            /*
            PorcentagemGorjetaLabel.Text = $"{e.NewValue} %";

            double valorDaConta = Convert.ToDouble(ContaEntry.Text);
            double valorDaGorjeta = valorDaConta * (e.NewValue / 100);
            GorjetaLabel.Text = valorDaGorjeta.ToString("F2");

            double valorTotal = valorDaConta + valorDaGorjeta;
            ValorTotalLabel.Text = valorTotal.ToString("F2");*/



        }
    }
}