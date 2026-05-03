using ContactBookApp;
public class Program
{
    public static void Main()
    {
        var contacts = new List<Contact>
{
    new Contact("John", "Doe", "787-555-1001", "john.doe@gmail.com"),
    new Contact("Jane", "Smith", "305-555-1002", "jane.smith@yahoo.com"),
    new Contact("Carlos", "Rivera", "939-555-1003", "carlos.rivera@hotmail.com"),
    new Contact("Maria", "Lopez", "212-555-1004", "maria.lopez@outlook.com"),
    new Contact("Luis", "Martinez", "646-555-1005", "luis.martinez@gmail.com"),
    new Contact("Ana", "Gonzalez", "718-555-1006", "ana.gonzalez@yahoo.com"),
    new Contact("Pedro", "Torres", "407-555-1007", "pedro.torres@hotmail.com"),
    new Contact("Sofia", "Ramirez", "786-555-1008", "sofia.ramirez@gmail.com"),
    new Contact("Miguel", "Flores", "213-555-1009", "miguel.flores@yahoo.com"),
    new Contact("Laura", "Perez", "310-555-1010", "laura.perez@hotmail.com"),

    new Contact("David", "Hernandez", "512-555-1011", "david.h@gmail.com"),
    new Contact("Isabella", "Diaz", "210-555-1012", "isabella.diaz@yahoo.com"),
    new Contact("Daniel", "Castro", "915-555-1013", "daniel.castro@hotmail.com"),
    new Contact("Camila", "Ortiz", "832-555-1014", "camila.ortiz@outlook.com"),
    new Contact("Jose", "Morales", "713-555-1015", "jose.morales@gmail.com"),
    new Contact("Valeria", "Ramos", "214-555-1016", "valeria.ramos@yahoo.com"),
    new Contact("Andres", "Reyes", "469-555-1017", "andres.reyes@hotmail.com"),
    new Contact("Elena", "Vargas", "972-555-1018", "elena.vargas@gmail.com"),
    new Contact("Jorge", "Mendoza", "281-555-1019", "jorge.mendoza@yahoo.com"),
    new Contact("Lucia", "Aguilar", "602-555-1020", "lucia.aguilar@hotmail.com"),

    new Contact("Kevin", "Rios", "480-555-1021", "kevin.rios@gmail.com"),
    new Contact("Natalia", "Guerrero", "623-555-1022", "natalia.g@yahoo.com"),
    new Contact("Victor", "Salazar", "520-555-1023", "victor.salazar@hotmail.com"),
    new Contact("Paula", "Cruz", "702-555-1024", "paula.cruz@outlook.com"),
    new Contact("Oscar", "Pena", "775-555-1025", "oscar.pena@gmail.com"),
    new Contact("Diana", "Soto", "503-555-1026", "diana.soto@yahoo.com"),
    new Contact("Ricardo", "Chavez", "971-555-1027", "ricardo.chavez@hotmail.com"),
    new Contact("Patricia", "Molina", "541-555-1028", "patricia.molina@gmail.com"),
    new Contact("Fernando", "Campos", "206-555-1029", "fernando.campos@yahoo.com"),
    new Contact("Gabriela", "Vega", "425-555-1030", "gabriela.vega@hotmail.com")};

        var cb = new ContactBook(contacts);
        cb.Start();
    }
}
