using System.Text.RegularExpressions;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }
        private void  Slider
        private void OnQuinzeClicked(object sender, EventArgs e)
        {

        }
        private void OnBtnVinteClicked(object sender, EventArgs e)
        {

        }
        private void  OnBtnRoundDownClicked(object sender, EventArgs e)
        {
            //arredonda pra baixo
            double result = CalculateTip();
            double roundedResult = Math.Floor(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            //exibir a gorjeta
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();

        }
        private void  OntnRoundUpClicked (object sender, EventArgs e)
        {
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double totalValue = roundedResult + amount;
            //exibir a gorjeta
            LabelTipValue.Text = roundedResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();

        }
        private double CalculateTip()
        {
            //1- Programar uma função que calcula
            //2- Preciso receber o valor do pedido  digitado pelo o usuário
            //3- Receber o valor da % para calcular a gorjeta
            //4- Realizar o calculo da gorjeta
            //5- Realizar o calculo da gorjeta considerando o tipo
            //6-Exibir o valor na Label TotalTip

            double amount = Convert.ToDouble(ValueEntry.Text.ToString()); // ou double.Parse(hkkh());
            double percent = SliderTipPercent.Value;

            //calculo a gorjeta
            double result = amount * (percent / 100);

        //exibir gorjeta
        return result;


        }


    }

}
