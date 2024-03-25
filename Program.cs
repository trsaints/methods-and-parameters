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
    ListEmails(corporate, corporateDomain);
}

void ListExternalAddresses()
{
    ListEmails(external, externalDomain);
}

void ListEmails(string[,] userList,string domainName)
{
    for (int i = 0; i < userList.GetLength(0); i++)
    {
        // display internal email addresses
        string firstLetters = userList[i, 0].Remove(2),
               lastName = userList[i, 1];

        Console.WriteLine($"{firstLetters.ToLower()}{lastName.ToLower()}@{domainName}");
    }
}