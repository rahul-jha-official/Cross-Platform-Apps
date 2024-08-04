using ContactManager.Interfaces;
using ContactManager.Models;
using ContactManager.Services;
using System.Collections.ObjectModel;

namespace ContactManager.Pages;

public partial class PhoneContactUI : ContentPage
{
	private readonly IContactsRepository _contactsRepository;
    public PhoneContactUI()
	{
        _contactsRepository = new LocalContactsRepository();

        InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadContacts(_contactsRepository.GetAll());
    }

    private void LoadContacts(IEnumerable<PhoneContact> contacts)
	{
		var observableContacts = new ObservableCollection<PhoneContact>(contacts);
		listContacts.ItemsSource = observableContacts;
	}

    private void SearchContact(object sender, TextChangedEventArgs e)
    {
        LoadContacts(_contactsRepository.Find(((SearchBar)sender).Text.Trim()));
    }

    private void ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listContacts.SelectedItem != null)
        {
            var contact = listContacts.SelectedItem as PhoneContact;
            var path = $"{nameof(EditPhoneContactUI)}?Id={contact!.Id}";
            Shell.Current.GoToAsync(path);
        }
    }

    private void ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listContacts.SelectedItem = null;
    }

    private void CreateContact(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddPhoneContactUI));
    }
}