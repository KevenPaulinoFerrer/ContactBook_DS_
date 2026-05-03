
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ContactBookApp;

public class ContactBook
{
    public const string NEXT_PAGE = "+";
    public const string PREV_PAGE = "-";
    public const string GOTO_PAGE = "G";
    public const string PAGE_SIZE = "S";
    public const string CREATE_CONTACT = "C";
    public const string REVIEW_CONTACT = "R";
    public const string UPDATE_CONTACT = "U";
    public const string DELETE_CONTACT = "D";
    public const string FIND_CONTACT = "F";
    public const string ORDER_CONTACT = "O";
    public const string DUPLICATE_CONTACT = "M";
    public const string EXIT = "X";

    public readonly string[] COMMANDS = new string[]
    {
        NEXT_PAGE ,
        PREV_PAGE ,
        GOTO_PAGE ,
        PAGE_SIZE ,
        CREATE_CONTACT ,
        REVIEW_CONTACT ,
        UPDATE_CONTACT ,
        DELETE_CONTACT,
        FIND_CONTACT,
        ORDER_CONTACT ,
        DUPLICATE_CONTACT ,
        EXIT

};
    private List<Contact> allContacts;

    public ContactBook(List<Contact> contacts = null)
    {
        allContacts = (contacts == null) ? new List<Contact>() : contacts;
    }
    public void Start()
    {
        ShowWelcomeScreen();
        string input;

        do
        {
            ShowContacts();
            do
            {
                ShowInputOptions();
                input = GetInput();
            } while (!IsValidInput(input));
            ProcessInput(input);

        } while (!ConfirmExit());
        ShowExitScreen();
    }

    private void ShowWelcomeScreen()
    {
        Console.WriteLine("Wecome to Contack Book App");
        PressEnterToContinue();
    }


    private void ShowContacts()
    {
        Console.Clear();
        if (allContacts.Count <= 0)
        {
            Console.WriteLine("No Contacts found");
        }
        else
        {
            int indexCol = Math.Max("#".Length, allContacts.Count.ToString().Length);
            int fnameCol = Math.Max("First Name".Length, allContacts.Max(c => c.GetFName()?.Length ?? 0));
            int lnameCol = Math.Max("Last Name".Length, allContacts.Max(c => c.GetLName()?.Length ?? 0));
            int phoneCol = Math.Max("Phone".Length, allContacts.Max(c => c.GetPhone()?.Length ?? 0));
            int emailCol = Math.Max("Email".Length, allContacts.Max(c => c.GetEmail()?.Length ?? 0));


            Console.WriteLine(""
                + "{0, " + -indexCol + "}  "
                + "{1, " + -fnameCol + "}  "
                + "{2, " + -lnameCol + "}  "
                + "{3, " + -phoneCol + "}  "
                + "{4, " + -emailCol + "}  ",
                "#", "First Name", "Last Name", "Phone", "Email");

            Console.WriteLine(new string('─', (indexCol + 2 + fnameCol + 2 + lnameCol + 2 + phoneCol + 2 + emailCol)));

            int n = allContacts.Count;
            int page = 1;
            int size = 10;
            int pageCount = (int)Math.Max(1, Math.Ceiling(n / (double)size));
            int firsResultIndex = Math.Clamp(page - 1 * size, 0, n);
            int lastResultIndex = Math.Clamp(firsResultIndex + size, 0, n);
            for (int i = firsResultIndex; i < lastResultIndex; i++)
            {
                Contact c = allContacts[i];
                Console.WriteLine(""
                    + "{0, " + -indexCol + "}  "
                    + "{1, " + -fnameCol + "}  "
                    + "{2, " + -lnameCol + "}  "
                    + "{3, " + -phoneCol + "}  "
                    + "{4, " + -emailCol + "}  ",
                    i + 1, c.GetFName(), c.GetLName(), c.GetPhone(), c.GetEmail());
            }
            Console.WriteLine();
            Console.WriteLine($"Page {page} of {pageCount} ({firsResultIndex + 1} - {lastResultIndex} of {n})");
        }

    }

    private void ShowInputOptions()
    {
    }

    private string GetInput()
    {
        return "";
    }

    private bool IsValidInput(string input)
    {
        return true;
    }
    private void ProcessInput(string input)
    {

    }

    private bool ConfirmExit()
    {
        return true;
    }

    private void ShowExitScreen()
    {

    }
    private void PressEnterToContinue()
    {
        Console.WriteLine("Press ENTER To Continue");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    }

}