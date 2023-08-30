/*
 




*/
 
string firstName = "Joacim";
string lastName = "Edlund";

string sentence_1 = "Jag heter Joacim och jag är \"bäst\"";

string url_1 = "c:\\education\\cms23-csharp";
string url_2 = @"c:\\education\\cms23-csharp";

//string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
string placeholder_2 = $"Hej jag heter  {firstName} {lastName}.";
string placeholder_3 = string.Format("Hej jag heter {0} {1}.", firstName, lastName);
Console.WriteLine(sentence_1);
Console.WriteLine(url_1);
Console.WriteLine(url_2);  
