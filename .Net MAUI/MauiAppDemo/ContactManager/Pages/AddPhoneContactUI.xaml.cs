using ContactManager.Interfaces;
using ContactManager.Services;

namespace ContactManager.Pages;
public partial class AddPhoneContactUI : ContentPage
{
    private readonly IContactsRepository _contactsRepository;

	public AddPhoneContactUI()
	{
		InitializeComponent();
        _contactsRepository = new LocalContactsRepository();
	}

    private void Save(object sender, EventArgs e)
    {
        var name = ContactOperation.Name;
        var phone = ContactOperation.PhoneNumber;

        _contactsRepository.Add(name, phone);

        DisplayAlert("Phone Contact", "Created Successfully", "Okay").ContinueWith((t) => TriggerBack());
    }

    private void GoBack(object sender, EventArgs e)
    {
        TriggerBack();
    }

    private static void TriggerBack()
    {
        Shell.Current.GoToAsync("..");
    }

    private void LogError(object sender, IEnumerable<string> errors)
    {
        foreach (var error in errors)
        {
            DisplayAlert("Error", error, "Close");
        }
    }
}