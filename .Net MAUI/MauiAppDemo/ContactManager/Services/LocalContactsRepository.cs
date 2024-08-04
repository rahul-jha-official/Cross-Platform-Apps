using ContactManager.Interfaces;
using ContactManager.Models;

namespace ContactManager.Services;

public class LocalContactsRepository : IContactsRepository
{
    private static readonly List<PhoneContact> _contacts = new List<PhoneContact>()
    {
        new PhoneContact
        {
            Id = 1,
            Name = "Rahul Jha",
            PhoneNumber = "7649053211"
        },
        new PhoneContact
        {
            Id = 2,
            Name = "Ajay Puri",
            PhoneNumber = "9340454575"
        },
        new PhoneContact
        {
            Id = 3,
            Name = "Priyansh Chaturvedi",
            PhoneNumber = "7292044008"
        }
    };

    public LocalContactsRepository()
    {
    }

    public void Add(string name, string phone)
    {
        _contacts.Add(new PhoneContact
        {
            Id = _contacts.Count + 1,
            Name = name,
            PhoneNumber = phone
        });
    }

    public void Delete(PhoneContact contact)
    {
        if (contact.Id <= 0) return;
        _contacts.Remove(_contacts.First(e => e.Id == contact.Id));
    }

    public IEnumerable<PhoneContact> Find(string initials)
    {
        if (string.IsNullOrWhiteSpace(initials)) return GetAll();
        var list = new HashSet<PhoneContact>();
        var namesLike = _contacts.Where(e => e.Name.ToLower().Contains(initials.ToLower()));
        var contactsLike = _contacts.Where(e => e.PhoneNumber.Contains(initials));
        
        foreach ( var contact in namesLike)
        {
            list.Add(contact);
        }

        foreach (var contact in contactsLike)
        {
            list.Add(contact);
        }
        return list;
    }

    //Returning a copy of contact
    public PhoneContact Get(int id)
    {
        var contact = _contacts.First(e => e.Id == id);
        
        return new PhoneContact
        {
            Id = contact.Id,
            Name = contact.Name,
            PhoneNumber = contact.PhoneNumber
        };
    }

    //Returning a readonly collection
    public IEnumerable<PhoneContact> GetAll()
    {
        return _contacts;
    }

    public void Update(PhoneContact contact)
    {
        var _contact = _contacts.First(e => e.Id == contact.Id);
        _contact.Name = contact.Name;
        _contact.PhoneNumber = contact.PhoneNumber;
    }
}
