string number = "seven";
string valueNull = null;
var valueLong = long.MaxValue.ToString();

try
{
    var formatException = int.Parse(number);
    var argumentNullException = int.Parse(valueNull);
    var overflowException = int.Parse(valueLong);
}
catch (FormatException formatException)
{
    Console.WriteLine($"formatException: {formatException.Message}");
}
catch (ArgumentNullException argumentNullException)
{
    Console.WriteLine($"argumentNullException: {argumentNullException.Message}");
}
catch (OverflowException overflowException)
{
    Console.WriteLine($"overflowException: {overflowException.Message}");
}
finally
{
    Console.WriteLine("Ever.");
}