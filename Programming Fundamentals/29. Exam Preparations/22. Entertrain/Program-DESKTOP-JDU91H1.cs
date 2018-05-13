//----Regex----
abc…	Letters
123…	Digits
\d Any Digit
\D Any Non-digit character
.Any Character
\.	Period
[abc] Only a, b, or c
[^abc]  Not a, b, nor c
[a-z]   Characters a to z
[0-9]   Numbers 0 to 9
\w Any Alphanumeric character
\W Any Non-alphanumeric character
{ m}
m Repetitions
{ m,n }
m to n Repetitions
* Zero or more repetitions
+	One or more repetitions
? Optional character
\s Any Whitespace
\S Any Non-whitespace character
^…$	Starts and ends
(…) Capture Group
(a(bc)) Capture Sub-group
(.*)    Capture all
(abc|def)   Matches abc or def

// DateTime изписва колко дни има в даден месец от дадена година
int days = DateTime.DaysInMonth(2014, 9); // September.
Console.WriteLine(days);

//StringBuilder - повтаряне на определен стринг(str) няколко пъти(repetitions)
string temp = new StringBuilder().Insert(0, str, repetitions).ToString();

//Преобразува String to Char Array, но и дава числовите стойности по ASCII на char-овете
var stringToChar = Encoding.ASCII.GetBytes(currentPurchace);

// преобразува от десетична в двуична бройна система
string binary = Convert.ToString(value, 2);

//Substring
string input = "OneTwoThree";

// Get first three characters.
string sub = input.Substring(0, 3);
Console.WriteLine("Substring: {0}", sub);

//Printirane na array

Console.WriteLine(String.Join(" ", theArray));

//Отпечатва array като пропуска елементи
Console.WriteLine(String.Join(" ", patso.Skip(k - 1).ToArray()));

//Вкарва стринг в array като премахва излишните празни полета.
var participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

//string to int array;
var input1 = "a b c d e f".Split(' ').Select(x => (int)x[0]).ToArray(); //вима всички без празните поленца ' '
var input2 = "a b c d e f".Select(x => (int)x).ToArray(); // взима всички включеително и празните поленца


//Преобразува string в string array, който се получава от
//разделянето на стринг с празно поленце ' '.
var kangaroosData = Console.ReadLine().Split(' ');
var numberArray = Console.ReadLine().Split(',', ' '); //разделени с ',' и ' '

// Превръща стринг от разделени с ' ' char масив, а после го превръща в int масив
string[] types_temp = Console.ReadLine().Split(' ');
int[] types = Array.ConvertAll(types_temp, Int32.Parse); //Понякога това работи бавно и ако има цикъл е добре да го сложим въте.

// Въвежда Array от double разделени с ' '
var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

//Превръща string с произволен брой ' ' в array, като премахва(.Trim) излишните ' ' отпред и отзад
var array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

//Превръща string с различни сепаратори в array, като премахва(.Trim) излишните ' ' отпред и отзад
var inputArray = Console.ReadLine().Split(new[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

//Превръща string с произволен брой ',' в array, като премахва излишните празни полета
var array = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

//(LINQ)Преброява колко пъти се среща Char 'a' в string
var count_A = answers_row.Count(x => x == 'a');

//(LINQ)Намира индексите на всички елементи "Viki" в List/Array и ги вкарва в Array
var students = new List<string> { "Ani", "Viki", "Mimi", "Viki", "Pepi", "Gesha" };
var indexes = Enumerable.Range(0, students.Count).Where(j => students[j] == "Viki").ToArray();

//(LINQ)Преобразува String to Int32(element е произволно име)
int[] bytesAsInts = yourBytes.Select(x => (int)x).ToArray();

//(без LINQ)Преобразува String to Int32(element е произволно име)
stringToInt = Array.ConvertAll(stringToChar, (element => (int) element));

//String array от цифри в int array
int[] myInts = Array.ConvertAll(arr, s => int.Parse(s));
или
var numberArray = Array.ConvertAll(numberArrayString, Int32.Parse);

//Разделяне на стринг на различни части. Get first three characters.
string input = "OneTwoThree";
string sub = input.Substring(0, 3); //започва от нулевия и брои три char
Console.WriteLine("Substring: {0}", sub); // "One"

//Класът Path. (using System.IO;) - обработка на файлови адреси
string someFileAddress = "C:\\stagelist.txt";

string extension = Path.GetExtension(someFileAddress); //показва разширението
string filename = Path.GetFileName(someFileAddress);//показва името заедно с разширението
string filenameNoExtension = Path.GetFileNameWithoutExtension(someFileAddress);//показва само името
string root = Path.GetPathRoot(someFileAddress);//показва само root напр. "C:\"
char dirSlash = Path.DirectorySeparatorChar;//показва разделителя, който понякога е различен за различните операционни системи.

//Приравняване на две матрици
if (sArray2.Length == sArray1.Length)
        {
            sArray2.CopyTo(sArray1, 0);    
        }
		
//Switch case

int value = 5;
        switch (value)
        {
            case 1:
                Console.WriteLine(1);
                break;
            case 5:
                Console.WriteLine(5);
                break;
        }

//Проверява дали даден string съдържа определена комбинация от chars(дума).
//Връща int и ако той е <0 думата я няма в стринга:
	const string value = "Your dog is cute.";
	if (value.IndexOf("dog") != -1)
        {
            Console.WriteLine("string contains dog!");
        }
		
//Проверява дали даден string съдържа определена комбинация от chars(дума)
//като започва да проверява от определен индекс нататък.
const string value = "Your dog is cute.";
	if (value.IndexOf("dog",3) != -1)// value.IndexOf = 5
        {
            Console.WriteLine("string contains dog!"); 
        }

		
//Намира най-последното съвпадение на даден char ('N'):
int index1 = value.LastIndexOf('N');

//Отделя стринг след определен индекс(8):
string name = value.Substring(8);

//String Reverse, обръщане на string (два варианта)
var someString = "abcdefgh"
var somestringArray = someString.ToCharArray();
var someStringReversed = string.Join("", somestringArray.Reverse()); // "hgfedcba"
или
var firstTeam = new string (teams[0].ToCharArray().Reverse().ToArray());
//Проверява дали Foo се намира в стринг и на кое място е...
if (testString.IndexOf("Foo") == 0 && testString.LastIndexOf("Foo") == 0)
        // "Foo foo foo"
        return true;
    else if (testString.IndexOf("Foo") == 0 && testString.LastIndexOf("Foo") > 0)
        // "Foo foo Foo"
        return false;
    else if (testString.Contains("foo")  && testString.IndexOf("Foo") > 0)
        // "foo Foo foo" or "foo foo Foo"
        return false; 
    else if (testString.Contains("foo") && !testString.Contains("Foo"))
        // "foo foo foo"
        return true; 
		
//Заменя дадена дума("key") в string с друга дума("keyword")
string output = input.Replace("key ", "keyword ");

//Разделяне на стринг на различни части. Get first three characters.
string input = "OneTwoThree";
string sub = input.Substring(0, 3); //започва от нулевия и брои три char
Console.WriteLine("Substring: {0}", sub); // "One"

//Създава array използвайки стринг за delimiter 
string[] numbersLine = line.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

//Създава array от стрингове
string[] cardArray = { "2c", "3c", "4c", "5c", "6c", "7c" };

//Превръща decimal то binary
string binaryValue = Convert.ToString(decimalValue, 2).PadLeft(8, '0');

//Превръща binary то decimal
int decimalValue = Convert.ToInt32("1001101", 2);

//изрязва нулите в началото на binary
string shortValue = binaryStringValue.TrimStart(new Char[] { '0' });

//Превръща array в общ string
char[] somearray = new char[15]; //не само char array, може всякакъв array(string, int ...)
string someString = new string(someArray);

//Сумира елементи от масив като пропуска i-на брой елементи
array.Skip(i).Sum();

//копира определени поредни елементи от един масив в друг новосъздаден
int[] b = new int[3];
Array.Copy(a, 1, b, 0, 3);
a = source array
1 = start index in source array
b = destination array
0 = start index in destination array
3 = elements to copy

// Сумира m-на брой от елементите на масив, като започва с елемент[i]
var result = array.Skip(i).Take(m).Sum();

//Намира най-голямото или най-малкото .Min() в масив и после му вадин индекса.
int maxValue = anArray.Max();
int maxIndex = anArray.ToList().IndexOf(maxValue);

//Binary search:
public static object BinarySearchIterative(int[] inputArray, int key, int min, int max)
{
    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (key == inputArray[mid])
        {
            return ++mid;
        }
        else if (key < inputArray[mid])
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return -1;
}
//

switch (value)
                {
                    case 0:
                    case 1:
                    case 2:
                        {
                            System.Console.WriteLine("Low number");
                            break;
                        }
                    case 3:
                    case 4:
                    case 5:
                        {
                            System.Console.WriteLine("Medium number");
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Other number");
                            break;
                        }
				}
				
				
				
//Преобразува string в list от char
string data = "ABCDEFGHIJ1fFJKAL";
List<char> datalist = new List<char>();
datalist.AddRange(data);

//Взима един стринг и образува substring от определен брой chars като пропуска (skip) chars.
string temp = word.Substring(skip, take);

//Създаване на List
List<char> cleanString = new List<char>();

//Създава копие на част от List в други list или array. Стартира от Index 2 копира 3 на брой елемента.
string[] output = dinosaurs.GetRange(2, 3).ToArray();
var output = dinosaurs.GetRange(2, 3).ToList();

//Използване на ?:
Console.WriteLine("{0}", cleanString.Count == 0 ? "Empty String" : string.Join("", cleanString));

//Деклариране на array
var prices = new double[3, 3] { { 9.60, 7.20, 15 }, { 9.60, 7.20, 15 }, { 10, 9.50, 20 } };

var teamResult = new double[2] { teamPoints, teamScore };

var prices = new double[,] {{ 9.60,  7.20,  15 }, // [0]girls
                            { 9.60,  7.20,  15 }, // [1]boys
                            { 10.0,  9.50,  20 }};// [2]mixed

// Принтиране на array на един ред разделен с " "
Console.WriteLine(string.Join(" ", bucket.Select(v => v.ToString())));

//Принтиране на array масив в един стринг разделен със запетайки
string[] values = ...;

string concatenated = string.Join(",", values);

//PadLeft, PadRight
string s = "cat".PadRight(10);
Console.Write(s);
Console.WriteLine("feline");

Output:
0123456789|--->
cat feline

//Друг пример за PadLeft и PadRight със запълващи точки
Console.Write("Sam".PadRight(10, '.'));
        Console.WriteLine("535".PadLeft(4, '.'));

        Console.Write("Jason".PadRight(10, '.'));
        Console.WriteLine("1".PadLeft(4, '.'));
		
Output:

Sam........535
Jason........1

//Засичане на време Stopwatch
using System.Diagnostics;
Stopwatch stopwatch = new Stopwatch();

stopwatch.Start(); // начало на засичане

stopwatch.Stop(); //край на засичане

Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed); //отпечатване
//Проверява колко пъти определен char('a') се съдържа в string:
string test = "asdasd";
int count = test.Split('a').Length - 1;

//Regex - подменя N*t с NET
// This is the input string we are replacing parts from.
string input = "Dot Net Not Perls";

// Use Regex.Replace to replace the pattern in the input.
// ... The pattern N.t indicates three letters.
// ... N, any character, and t.
string output = Regex.Replace(input, "N.t", "NET");
Console.WriteLine(output); // -- > отпечатва Dot NET NET Perls
		
//Regex - подменя всички char различни от A-Za-z0-9 [^A-Za-z0-9] с нула;
		inputString = Regex.Replace(inputString, "([^A-Za-z0-9])","0");
		
//Regex 

Regex regex = new Regex(@"\d+");
Match match = regex.Match("Dot 55 Perls");
        if (match.Success)
        {
            Console.WriteLine(match.Value);
        }
		
//Regex пълнене в array
var match = Regex.Matches(input, pattern).Cast<Match>().Select(x => x.ToString().ToUpper()).ToArray();

//Regex named groups
var key = Regex.Escape(Console.ReadLine()); // подменя всички специални Regex chars като ги ескейпва, за да могат да се мачват
var patternTeams = $@"{key}(?<teams>[A-Za-z]+){key}"; //замества key в pattern, създава една regex група
var teams = Regex.Matches(input, patternTeams).Cast<Match>().Select(x => x.Groups["teams"].ToString().ToUpper()).ToArray(); //взима всички matches от група teams, прави ги ToUpper и ги пълни в array

//Regex мачва стринг "0:0", сплитва го  с ':' и пълни двете числа в int [] array goals
var patternGoals = $@"(\d+:\d+)";
var goals = Regex.Match(input, patternGoals).ToString().Split(':').Select(x => int.Parse(x)).ToArray();

//Regex вади индекса, на който е намерено съвпадение
var currentPattern = new Regex(@"[^A-Za-z-]+");
var currentMatch = currentPattern.Match(currentInput);
var index = currentMatch.Index;

//Regex групи с имена
// ... Input string.
string input = "Left12345Right";

// ... Use named group in regular expression.
var expression = new Regex(@"Left(?<middle>\d+)Right");

// ... See if we matched.
var match = expression.Match(input);
        if (match.Success)
        {
            // ... Get group by name.
            string result = match.Groups["middle"].Value;
Console.WriteLine("Middle: {0}", result);
        }

//|Regex NextMatch
string pattern = "a*";
string input = "abaabb";

Match m = Regex.Match(input, pattern);
      while (m.Success) {
         Console.WriteLine("'{0}' found at index {1}.", 
                           m.Value, m.Index);
	  m = m.NextMatch();}
		 // The example above displays the following output:
//       'a' found at index 0.
//       '' found at index 1.
//       'aa' found at index 2.
//       '' found at index 4.
//       '' found at index 5.
//       '' found at index 6.
		
//Изтрива всички празни полета от string;
		inputString = inputString.Replace(" ", String.Empty);

							ESCAPING EXAMPLES
=============================================================================
|		REGULAR LITERAL		|	VERBATIM LITERAL	|	RESULTING STRING	|
=============================================================================
|	"Hello"					|	@"Hello"			|	Hello				|
-----------------------------------------------------------------------------
|	"Backslash: \\"			|	@"Backslash: \"		|	Backslash: \		|
-----------------------------------------------------------------------------
|	"Quote: \""				|	@"Quote: """		|	Quote: "			|
-----------------------------------------------------------------------------
|	"CELF: \r\nPost CELF"	|	@"CRLF:				|	CRLF:				|	// CR-Carriage return
|							|	Post CRLF"			|	Post CRLF			|	// LF-Line feed
=============================================================================

string a = "hello, world";					// hello, world
string b = @"hello, world";					// hello, world
string c = "hello \t world";				// hello     world
string d = @"hello \t world";               // hello \t world
string e = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
string f = @"Joe said ""Hello"" to me";		// Joe said "Hello" to me
string g = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
string h = @"\\server\share\file.txt";      // \\server\share\file.txt
string i = "one\r\ntwo\r\nthree";
string j = @"one
two
three";

//Dictionary, директно инициализиране

            var students = new SortedDictionary<string, double>
            {
                { "Иван", 5.60},
                { "Киро", 5},
                { "Мария", 5.45}
            };

//Dictionary, инициализиране
			var students = new SortedDictionary<string, double>();
			
			students.Add("Митко", 5.45); //Първи начин
			students["Мария"] = 6; // втори начин
			
			var keys = students.Keys.ToArray(); //Вкарваме ключовете в array
			Console.WriteLine(String.Join(",", keys));//Изброяване на студентите
			
			var values = students.Values.ToArray(); //Вкарваме стойностите в array
			Console.WriteLine(String.Join(",", values));//Изброяване на стойностите
			
			
			
//Dictionary  дали речник "students" съдържа определен key "Митко"
		if 	(students.ContainsKey("Митко"))
			
		//Dictionary(someDic) разпечатване на Value, когато то е List 
Console.WriteLine($"{string.Join(", ", someDic.Value.ToArray())}");
			
//Dictionary  дали речник "students" съдържа определен value "5.45"
		if 	(students.ContainsValue("5.45"))
			
//Dictionary  да опита да върне стойност на ключ "Митко"
double grade;
students.TryGetValue("Митко", out grade); //grade ще приеме value на "Митко"

//Dictionary foreach loop
foreach (var item in students)

//Dictionary adding new key and value
 else
                    {
                        winners.Add(currentSinger, new List<string>());
                        winners[currentSinger].Add(award);
                    }

//Dictionary премахва всички елементи, съдържащи определенo value
foreach(var item in dic.Where(kvp => kvp.Value == value).ToList())
{
    dic.Remove(item.Key);
}
//Dictionary string, List
var Dictionary = new Dictionary<string , List<string>>();


//|Dictionary - проверява дали даден string го има в речника и ако го няма, го добавя със стойност 0.
                  IDictionary<string, int> words = new SortedDictionary<string, int>();
				  string input = Console.ReadLine();
				  if (!words.TryGetValue(input, out count)) // ако го няма дава false(затова е знакът "!") и влиза в скобите...
                  {
                        count = 0;							//добавяме го със стойност 0
                  }
//Dictionary и Lambda. K(участник),V(награди) от Dictionary(winners), сортира ги по брой награди, после по азбучен ред и ги отпечатва:
foreach (KeyValuePair<string, List<string>> pair in winners.OrderByDescending(a => a.Value.Distinct().ToList().Count).ThenBy(n => n.Key))
            {
                List<string> awards = pair.Value.Distinct().ToList();//пълни V(награди) за съответния участник(winner)от речника(winners) в List(awards);

                Console.WriteLine($"{pair.Key}: {awards.Count} awards");//Отпечатва броя награди
                foreach (string award in awards.OrderBy(n => n))//отпечатва вида награда
                {
                    Console.WriteLine($"--{award}");
                }

				
				
				
				counter++;
                if (counter >= maxCounter && array[i] > array[i - 1])
                {
                    maxCounter = counter;
                    start = i - 1;
                }
                else
                {
                    counter = 1;Re
                }
				
				
				
// Отпечатва чудеса

foreach (var pair in userLogs.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: ", pair.Key);
                
                foreach (var log in pair.Value) 
                {
                    Console.WriteLine("{0}=> {1}.", log.Key, log.Value);
                }
            }
			
		
		
=====================L I N Q============================
//LINQ който взима всичко по-голямо от 0 и пълни в array
var coll = leftArr.Where(x => x > 0).ToArray();

// LINQ взима първите 5 елемента от list или array, които са по-големи от 0 и по-малки от 9 и ги пълни в array
var sumLeft = (from item in items.Take(5) where item > 0 && item >= 9 select item).ToArray();

// LINQ пропуска първите 5 елемента от list или array, които са по-големи от 0 и по-малки от 9 и ги пълни в array
var sumLeft = (from item in items.Skip(5) where item > 0 && item >= 9 select item).ToArray();


============================Tuple====================
var tuple = new Tuple<string, int>("evolutionName", 11);
        var dict = new Dictionary<string, List<Tuple<string, int>>>();
        dict.Add("georgi", new List<Tuple<string, int>>());
        var theList = new List<Tuple<string, int>>();
        Console.WriteLine();
		
================================Class================

private class Dragon
    {
        public string name { get; set; } // без default value
        public long damage { get; set; } = 45; // с default value
        public long health { get; set; } = 250;
        public long armor { get; set; } = 10;
    }
	
//Foreach OrderBy

foreach (var dragon in type.Value.OrderBy(x => x.name))
            {
                Console.WriteLine($@"-{dragon.name} -> damage: {dragon.damage}, health: {dragon.health}, armor: {dragon.armor}");
            }
// TryParse
			long damage;
            var damageNotNull = long.TryParse(dragonData[2], out damage); //bool, който връща false ако не успее да парсне, а ако успее връща long damage;
            if (damageNotNull) currentDragon.damage = damage;