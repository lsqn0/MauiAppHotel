using MauiAppHotel.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> Lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Standard",
                ValorDiarioAdulto = 100.00,
                ValorDiarioCrianca = 50.00
            },
            new Quarto()
            {
                Descricao = "Suíte Premium",
                ValorDiarioAdulto = 200.00,
                ValorDiarioCrianca = 100.00
            },
            new Quarto()
            {
                Descricao = "Suíte Netuno",
                ValorDiarioAdulto = 300.00,
                ValorDiarioCrianca = 150.00
            }

        };

        public App()
        {
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
