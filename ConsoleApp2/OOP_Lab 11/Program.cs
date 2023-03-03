using System;
using System.Collections.Generic;

namespace OOP_Lab_11
{
	public static class Extensions
	{
		public static K FindKey<K, V>(this Dictionary<K, V> dict, V value)
		{
			foreach (KeyValuePair<K, V> pair in dict)
			{
				if (EqualityComparer<V>.Default.Equals(pair.Value, value))
				{
					return pair.Key;
				}
			}
			return default;
		}
		public static V FindValue<K, V>(this Dictionary<K, V> dict, K key)
		{
			foreach (KeyValuePair<K, V> pair in dict)
			{
				if (EqualityComparer<K>.Default.Equals(pair.Key, key))
				{
					return pair.Value;
				}
			}
			return default;
		}

		public static string RemoveEnd(this string str, int length)
		{
			if (str.Length < length)
			{
				return string.Empty;
			}
			return str.Remove(str.Length - length);
		}
	}

	internal class Program
	{
		static void Task1()
		{
			string name, surname, lastname;
			int lenght;

			Console.WriteLine("\nEnter your surname: ");
			surname = Console.ReadLine();
			Console.WriteLine("Length of this string is: " + surname.Length + " symbols");

			Console.WriteLine("\nEnter your name: ");
			name = Console.ReadLine();
			Console.WriteLine("Length of this string is: " + name.Length + " symbols");

			Console.WriteLine("\nEnter your lastname: ");
			lastname = Console.ReadLine();
			Console.WriteLine("Length of this string is: " + lastname.Length + " symbols");

			lenght = name.Length + surname.Length + lastname.Length;
			Console.WriteLine("Length of all strings is: " + lenght + " symbols");

			Console.WriteLine("\nThis task has been completed: " + surname + " " + name[0] + "."
				+ lastname[0] + ". \nSpeciality: Software Engineering\nGroup: SE-21008-b");
		}

		static void Task2()
		{
			string userText, key;
			string[] dictionaryKeys;
			char[] charArray;
			char value;
			bool cycleCondition = true;
			string encryptedText = "", decryptedText = "";
			int choiseNumber;

			Dictionary<string, char> encryptionBook = new Dictionary<string, char> 
			{   
				{ "00", 'a' }, { "01", 'b' }, { "02", 'c' }, { "03", 'd' }, { "04", 'e' },
				{ "05", 'f' }, { "06", 'g' }, { "07", 'h' }, { "08", 'i' }, { "09", 'j' },
				{ "10", 'k' }, { "11", 'l' }, { "12", 'm' }, { "13", 'n' }, { "14", 'o' },
				{ "15", 'p' }, { "16", 'q' }, { "17", 'r' }, { "18", 's' }, { "19", 't' },
				{ "20", 'u' }, { "21", 'v' }, { "22", 'w' }, { "23", 'x' }, { "24", 'y' },
				{ "25", 'z' }, { "26", 'A' }, { "27", 'B' }, { "28", 'C' }, { "29", 'D' },
				{ "30", 'E' }, { "31", 'F' }, { "32", 'G' }, { "33", 'H' }, { "34", 'I' },
				{ "35", 'J' }, { "36", 'K' }, { "37", 'L' }, { "38", 'M' }, { "39", 'N' },
				{ "40", 'O' }, { "41", 'P' }, { "42", 'Q' }, { "43", 'R' }, { "44", 'S' },
				{ "45", 'T' }, { "46", 'U' }, { "47", 'V' }, { "48", 'W' }, { "49", 'X' },                
				{ "50", 'Y' }, { "51", 'Z' }, { "52", ' '}
			};

			while(cycleCondition)
			{
				Console.WriteLine("\nWhat do you want entered? Phrace(0) or code(1) or show encryption" +
					" book(2) or end program(3)");
				choiseNumber = Convert.ToInt32(Console.ReadLine());

				switch (choiseNumber)
				{
					case 0:
						Console.WriteLine("\nEnter your text for encryption: ");
						userText = Console.ReadLine();
						charArray = userText.ToCharArray();

						for (int i = 0; i < charArray.Length; i++)
						{
							value = charArray[i];
							key = encryptionBook.FindKey(value);

							encryptedText = encryptedText + key + ".";
						}

						Console.WriteLine("\nEncrypted message: " + encryptedText.RemoveEnd(1));
						break;

					case 1:
                        Console.WriteLine("\nEnter code separated by dots for decryption: ");
                        userText = Console.ReadLine();
                        dictionaryKeys = userText.Split('.');

						for (int i = 0; i < dictionaryKeys.Length; i++)
						{
							key = dictionaryKeys[i];
							value = encryptionBook.FindValue(key);

							decryptedText = decryptedText + value;
						}
                        Console.WriteLine("\nDecripted message: " + decryptedText);
                        break;

					case 2:
						Console.WriteLine("\n{ \"00\", 'a' }, { \"01\", 'b' }, { \"02\", 'c' }," +
							" { \"03\", 'd' }, { \"04\", 'e' },\n{ \"05\", 'f' }," +
							" { \"06\", 'g' }, { \"07\", 'h' }, { \"08\", 'i' }, { \"09\", 'j' }," +
							"\n{ \"10\", 'k' }, { \"11\", 'l' }, { \"12\", 'm' }," +
							" { \"13\", 'n' }, { \"14\", 'o' },\n{ \"15\", 'p' }," +
							" { \"16\", 'q' }, { \"17\", 'r' }, { \"18\", 's' }, { \"19\", 't' }," +
							"\n{ \"20\", 'u' }, { \"21\", 'v' }, { \"22\", 'w' }," +
							" { \"23\", 'x' }, { \"24\", 'y' },\n{ \"25\", 'z' }," +
							" { \"26\", 'A' }, { \"27\", 'B' }, { \"28\", 'C' }," +
							" { \"29\", 'D' },\n{ \"30\", 'E' }, { \"31\", 'F' }," +
							" { \"32\", 'G' }, { \"33\", 'H' }, { \"34\", 'I' }," +
							"\n{ \"35\", 'J' }, { \"36\", 'K' }, { \"37\", 'L' }," +
							" { \"38\", 'M' }, { \"39\", 'N' },\n{ \"40\", 'O' }," +
							" { \"41\", 'P' }, { \"42\", 'Q' }, { \"43\", 'R' }, { \"44\", 'S' }," +
							"\n{ \"45\", 'T' }, { \"46\", 'U' }, { \"47\", 'V' }, " +
							"{ \"48\", 'W' }, { \"49\", 'X' },\n{ \"50\", 'Y' }," +
							" { \"51\", 'Z' }, { \"52\", ' '}\n");
						break;

					case 3:
                        Console.WriteLine("\nProgram ending...\n");
                        cycleCondition = false;
						break;

					default:
                        Console.WriteLine("\nProgram ending...\n");
                        cycleCondition = false;
                        break;
                }
			}
		}

		static void Main(string[] args)
		{
            Console.WriteLine("---------------------Task1--------------------");
            Task1();

            Console.WriteLine("\n---------------------Task2--------------------");
            Task2();
		}
	}
}
