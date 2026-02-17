string c = Console.ReadLine();
string vowels = "aeiouAEIOU";

bool hasVowel = c.Any(c => vowels.Contains(c));
Console.WriteLine(hasVowel ? "vowel" : "consonant");
