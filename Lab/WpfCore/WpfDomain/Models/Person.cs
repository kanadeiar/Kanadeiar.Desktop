using Kanadeiar.Desktop.Base;

namespace WpfDomain.Models;

public class Person : KndModelBase
{
    private string _lastName = string.Empty;
    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName
    {
        get => _lastName;
        set => Set(ref _lastName, value);
    }

    private string _firstName = string.Empty;
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName
    {
        get => _firstName;
        set => Set(ref _firstName, value);
    }

    private string _patronymic = string.Empty;
    /// <summary>
    /// Отчество
    /// </summary>
    public string Patronymic
    {
        get => _patronymic;
        set => Set(ref _patronymic, value);
    }

    private DateTime _birthDay;
    /// <summary>
    /// День рождения
    /// </summary>
    public DateTime BirthDay
    {
        get => _birthDay;
        set => Set(ref _birthDay, value);
    }
}