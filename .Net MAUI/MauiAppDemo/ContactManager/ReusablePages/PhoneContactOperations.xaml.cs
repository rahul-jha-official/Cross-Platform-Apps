namespace ContactManager.ReusablePages;

public partial class PhoneContactOperations : ContentView
{
    public event EventHandler<IEnumerable<string>> ErrorEvent;
    public event EventHandler<EventArgs> SaveEvent;
    public event EventHandler<EventArgs> GoBackEvent;

    public string Name
    {
        get
        {
            return EntryName.Text;
        }
        set
        {
            EntryName.Text = value;
        }
    }

    public string PhoneNumber
    {
        get
        {
            return EntryPhone.Text;
        }
        set
        {
            EntryPhone.Text = value;
        }
    }

    public PhoneContactOperations()
	{
		InitializeComponent();
	}

    private void SaveContact(object sender, EventArgs e)
    {
        if (CheckName.IsNotValid ||  CheckPhone.IsNotValid)
        {
            var errors = new List<string>();
            if (CheckName.IsNotValid) errors.Add("Name is not valid, Please check again!");
            if (CheckPhone.IsNotValid) errors.Add("Phone Number is not valid, Please check again!");
            ErrorEvent?.Invoke(sender, errors);
            return;
        }

        SaveEvent?.Invoke(sender, e);
    }

    private void GoToMainManu(object sender, EventArgs e)
    {
        GoBackEvent?.Invoke(sender, e);
    }
}