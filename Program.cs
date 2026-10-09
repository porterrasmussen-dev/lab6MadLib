Console.Clear();

Console.WriteLine("Welcome to Mad Libs! \n I will ask you for various words and then create a funny story for you.\n");
string baseStory = "One day, my (adjective) friend and I discovered a (adjective) map hidden inside a (noun). \nThe map pointed toward a mysterious castle located beyond the (plural_noun) and across a (adjective) river. \nWe packed a (noun), a (noun), and several (plural_noun) before beginning our adventure. \nAs we traveled, we spent hours (verb_ending_in_ing) and (verb_ending_in_ing) through the wilderness. \nSuddenly, a (adjective) creature jumped out from behind a (noun) and let out a loud (sound)! \nLuckily, my friend used a (noun) to scare it away. \nWhen we finally reached the castle, we found a giant room filled with (plural_noun) made of (material). \nIn the center stood a/an (adjective) treasure chest. \nI carefully opened it and discovered (number) (verb_ending_in_ing) (plural_noun) and a magical (noun). \nJust then, the castle began (verb_ending_in_ing). \nWe grabbed the treasure and ran (adverb) toward the exit. \nOutside, we celebrated by eating (plural_food) and playing (game) until sunset. \nIt was the most (adjective) adventure of my life, and I can't wait to go (verb_ending_in_ing) again!";
//I had AI come up with a different base story than the one on the assignment.
string[] words = baseStory.Split(" ");
Console.WriteLine(baseStory);
for (int i = 0; i < words.Length; i++)
{
    if (words[i][0] == '(' )
    {
        string temp = words[i];

//check punctuation and be ready to put it back in
        (char, bool) punctuation = (' ', false);
        if (temp.Contains('.'))
        {
            punctuation.Item2 = true;
            punctuation.Item1 = '.';
            temp = words[i].Trim('.');
        }
                if (temp.Contains('!'))
        {
            punctuation.Item2 = true;
            punctuation.Item1 = '!';
            temp = words[i].Trim('!');
        }
        if (temp.Contains(','))
        {
            punctuation.Item2 = true;
            punctuation.Item1 = ',';
            temp = words[i].Trim(',');
        }

//back to 
        temp = temp.Trim('(', ')');
        if (temp[0] == 'a'|| temp[0] == 'e'|| temp[0] == 'i'|| temp[0] == 'o'|| temp[0] == 'u')
        {
            Console.Write($"Please give me an {temp}. ");
        }
        else
        {
            Console.Write($"Please give me a {temp}. ");
        }
        if (punctuation.Item2)
        {
            words[i] = Console.ReadLine() + punctuation.Item1;
        }
        else words[i] = Console.ReadLine();
    }
}

for (int i = 0; i<words.Length; i++)
{
    Console.Write($"{words[i]} ");
}