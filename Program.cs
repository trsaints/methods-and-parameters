string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com",
       corporateDomain = "contoso.com";

ListEmployeeAddresses();
Console.WriteLine();
ListEmployeeAddresses(externalDomain);

void ListEmployeeAddresses(string optionalDomain = "")
{
    ListInternalAddresses();

    if (optionalDomain != "")
        ListExternalAddresses();
}

void ListInternalAddresses()
{
    for (int i = 0; i < corporate.GetLength(0); i++)
    {
        // display internal email addresses
        string firstLetters = corporate[i, 0].Remove(2),
               lastName = corporate[i, 1];

        Console.WriteLine($"{firstLetters.ToLower()}{lastName.ToLower()}@{corporateDomain}");
    }
}

void ListExternalAddresses()
{
    for (int i = 0; i < external.GetLength(0); i++)
    {
        // display external email addresses
        string firstLetters = external[i, 0].Remove(2),
              lastName = external[i, 1];

        Console.WriteLine($"{firstLetters.ToLower()}{lastName.ToLower()}@{externalDomain}");
    }
}
