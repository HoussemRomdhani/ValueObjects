using System.Text.RegularExpressions;

namespace ValueObjects;

public static class Validators
{
    public static bool IsValidEmail(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        Regex regex = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        Match match = regex.Match(value);

        return match.Success;
    }
}
