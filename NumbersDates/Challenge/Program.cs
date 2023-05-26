
while (true)
{
  string userInput = "";

  Console.WriteLine("Which date? (or 'exit')");

  userInput = Console.ReadLine();
  if (userInput == "exit")
  {
    break;
  }

  DateTime userDate;

  bool isDate = DateTime.TryParse(userInput, out userDate);

  if (isDate)
  {
    TimeSpan timeDifference = userDate - DateTime.Now;
    int daysDifference = timeDifference.Days;
    if (daysDifference < 0)
    {
      Console.WriteLine($"That date went by {daysDifference * -1} days ago.");
    }
    else if (daysDifference > 0)
    {
      Console.WriteLine($"That date is in {daysDifference} days.");
    }
    else if (daysDifference == 0)
    {
      Console.WriteLine($"That is today's date.");
    }
  }
  else
  {
    Console.WriteLine($"'{userInput}' is not a valid date");
  }
}