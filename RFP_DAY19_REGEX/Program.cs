// See https://aka.ms/new-console-template for more information
using RFP_DAY19_REGEX;
Console.WriteLine("Welcome to VALIDATE_NAME program!\n");
ValidFirstName nameObj = new ValidFirstName();
if(nameObj.Validate_Name("Ankush"))
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Invalid");
}
