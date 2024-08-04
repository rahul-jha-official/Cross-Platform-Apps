using ContactManager.Models;
namespace ContactManager.Interfaces;

public interface IContactsRepository
{
    IEnumerable<PhoneContact> GetAll();
    PhoneContact Get(int id);
    void Add(string name, string phone);
    void Update(PhoneContact contact);
    void Delete(PhoneContact contact);
    IEnumerable<PhoneContact> Find(string initials);
}
