using ContactManager.Pages;

namespace ContactManager
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PhoneContactUI), typeof(PhoneContactUI));
            Routing.RegisterRoute(nameof(EditPhoneContactUI), typeof(EditPhoneContactUI));
            Routing.RegisterRoute(nameof(AddPhoneContactUI), typeof(AddPhoneContactUI));
        }
    }
}
