using Microsoft.Extensions.DependencyInjection;
using Prototipo_App_Financeiro.Views;

namespace Prototipo_App_Financeiro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new TransactionList()));
        }
    }
}