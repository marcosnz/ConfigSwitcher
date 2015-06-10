using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConfigSwitcher
{
  public class TextCreator
  {
    private enum Words
    {
      // ReSharper disable UnusedMember.Local
      Aqua,
      Azure,
      Beige,
      Black,
      Blue,
      Brown,
      Coral,
      Crimson,
      Gold,
      Gray,
      Green,
      Indigo,
      Ivory,
      Khaki,
      Lime,
      Magenta,
      Maroon,
      Navy,
      Orange,
      Pink,
      Plum,
      Purple,
      Red,
      Silver,
      Snow,
      Tan,
      Teal,
      Violet,
      White,
      Yellow,
      Zero,
      One,
      Two,
      Three,
      Four,
      Five,
      Six,
      Seven,
      Eight,
      Nine,
      Ten,
      Car,
      Truck,
      Bike,
      Skate,
      Scoot,
      Key,
      Mouse,
      Rat,
      Poison,
      Potion,
      Chemist,
      Life,
      Living,
      Room,
      Class,
      Object,
      New,
      Old,
      Aged,
      Pension,
      Saving,
      Money,
      Dollar,
      Cent,
      Century,
      Year,
      Day,
      Month,
      Week,
      Pay,
      Pal,
      Mate,
      Bud,
      Flower,
      Bloom,
      Boom,
      Blast,
      Zap,
      Down,
      Up,
      MaxValue
    }

    private const string ExtraText = "1234567890qwertyuiopasdfghjklasdfghjklzxcvbnm";
    private const string SpecialCharacters = ")!@#$%^&*(";
    private static readonly Random RandomGenerator = new Random();
    private static List<string> _alreadyUsed = ReadAlreadyUsed();
    private static readonly string FileName = Assembly.GetExecutingAssembly().Location + ".txt";

    private static List<string> ReadAlreadyUsed()
    {
      List<string> alreadyUsed = new List<string>();

      try
      {
        if (File.Exists(FileName))
        {
          alreadyUsed.AddRange(File.ReadAllLines(FileName));
        }
      }
      catch (Exception)
      {
        // ne'er mind
      }

      return alreadyUsed;
    }

    public string CreateText(int length = 12, IEnumerable<string> dontDuplicate = null)
    {
      if (length < 8 || length > 15)
      {
        throw new ArgumentOutOfRangeException("length", length, "Can only generate text between 8 and 15 characters in length");
      }
      string text;
      const int maxRetry = 1000;
      int retryCount = 0;
      bool exists;
      if (dontDuplicate != null)
      {
        _alreadyUsed = _alreadyUsed.Union(dontDuplicate).ToList();
      }

      do
      {
        text = GetText(length);
        retryCount++;
        exists = _alreadyUsed.Contains(text);
      }
      while (retryCount < maxRetry && exists);

      if (!exists)
      {
        _alreadyUsed.Add(text);
        WriteTextToFile(text);
      }

      return text;
    }

    private static void WriteTextToFile(string text)
    {
      try
      {
        File.AppendAllText(FileName, text + "\r\n");
      }
      catch (Exception)
      {
        // ne'er mind
      }
    }

    private static string GetText(int length)
    {
      string firstWord = null;
      string secondWord = null;
      int number = 0;
      string specialCharacter = null;

      int extraNeeded = -1;
      while (extraNeeded != 0)
      {
        List<int> randomNumbers = GetRandomNumbers((int)Words.MaxValue, (int)Words.MaxValue, 10);
        firstWord = ((Words)randomNumbers[0]).ToString();
        secondWord = ((Words)randomNumbers[1]).ToString();
        number = randomNumbers[2];
        specialCharacter = SpecialCharacters.Substring(number, 1);
        int currentLength = (firstWord.Length + secondWord.Length + 2);

        extraNeeded = length - currentLength;
      }

      string text = firstWord + secondWord + number + specialCharacter; //// + extraText;
      return text;
    }

    private static List<int> GetRandomNumbers(params int[] maxForEach)
    {
      List<int> numbers = new List<int>(maxForEach.Length);
      while (numbers.Count < maxForEach.Length)
      {
        int number = RandomGenerator.Next(maxForEach[numbers.Count]);
        if (!numbers.Contains(number))
        {
          numbers.Add(number);
        }
      }

      return numbers;
    }

  }
}
