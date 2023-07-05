

string? idText;

do
{

    Dictionary<int, string> employees = new Dictionary<int, string>();

    employees.Add(1, "Ayoub");
    employees.Add(2, "Fahd");
    employees.Add(3, "Chahido");

    Console.Write("Enter a valid id (or exit to exit the app): ");

    idText = Console.ReadLine();

    bool isValid = int.TryParse(idText, out int id);

    if (!isValid || !employees.Keys.Contains(id))
    {
        Console.WriteLine("Please enter a valid number");
    }

    if (isValid && employees.Keys.Contains(id))
    {
        Console.WriteLine($"The employee with id {id} is {employees[id]}");
    }
} while (idText != "exit");