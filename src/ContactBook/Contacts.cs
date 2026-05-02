namespace ContactBook;

public class Contact : IEquatable<Contact>
{
    private string fname = default!;
    private string lname = default!;
    private string phone = default!;
    private string email = default!;

    public Contact(string fname = "", string lname = "", string phone = "", string email = "")
    {
        SetFName(fname);
        SetLName(lname);
        SetPhone(phone);
        SetEmail(email);
    }

    public string GetFName() { return fname; }
    public string GetLName() { return lname; }
    public string GetEmail() { return email; }
    public string GetPhone() { return phone; }
    public void SetFName(string fn) { fname = fn; }
    public void SetLName(string ln) { lname = ln; }
    public void SetEmail(string e) { email = e; }
    public void SetPhone(string p) { phone = p; }

    public override string ToString()
    {
        return $"Contact[fname ={fname}, lname={lname}, phone={phone}, email={email}]";
    }
    public bool Equals(Contact? other)
    {
        if (other == null) { return false; }
        if (ReferenceEquals(this, other)) { return true; }

        return string.Equals(fname, other.fname)
            && string.Equals(lname, other.lname)
            && string.Equals(phone, other.phone)
            && string.Equals(email, other.email);
    }
    public override bool Equals(object? obj)
    {
        return Equals(obj as Contact);
    }

    public static bool operator ==(Contact? x, Contact? y)
    {
        return (x is null) ? (y is null) : x.Equals(y);
    }
    public static bool operator !=(Contact? x, Contact? y)
    {
        return !(x == y);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(fname, lname, phone, email);
        ;
    }

}