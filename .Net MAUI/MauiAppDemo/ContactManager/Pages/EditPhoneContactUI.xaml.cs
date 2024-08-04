using ContactManager.Interfaces;
using ContactManager.Services;
using ContactManager.Models;

namespace ContactManager.Pages;

[QueryProperty("ContactId","Id")]
public partial class EditPhoneContactUI : ContentPage
{
    private readonly IContactsRepository _contactsRepository;
    private int _id;
    public int ContactId
    {
        set
        {
            _id = value;
            var contact = _contactsRepository.Get(_id);
            if (contact != null)
            {
                ContactOperation.Name = contact.Name;
                ContactOperation.PhoneNumber = contact.PhoneNumber;
            }
            else
            {
                TriggerBack();
            }
        }
    }
	public EditPhoneContactUI()
	{
		InitializeComponent();
        _contactsRepository = new LocalContactsRepository();
	}

    private void Save(object sender, EventArgs e)
    {
        var name = ContactOperation.Name;
        var phone = ContactOperation.PhoneNumber;

        _contactsRepository.Update(new PhoneContact { Id =  _id, Name = name, PhoneNumber = phone });

        DisplayAlert("Phone Contact", "Updated Successfully", "Okay").ContinueWith((t) => TriggerBack());
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