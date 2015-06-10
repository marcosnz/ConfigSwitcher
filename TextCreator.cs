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
      Fred,
      Mary,
      Dave,
      John,
      Might,
      Power,
      Electric,
      Light,
      Dark,
      Night,
      Sun,
      Moon,
      Planet,
      Earth,
      Soil,
      Plant,
      Wheat,
      Barley,
      Remote,
      Radio,
      Star,
      Mercury,
      Venus,
      Mars,
      Jupiter,
      Saturn,
      Uranus,
      Neptune,

      MaxValue
    }

    private const string ExtraText = "1234567890qwertyuiopasdfghjklasdfghjklzxcvbnm";
    private const string SpecialCharacters = ")!@#$%^&*(";
    private static readonly Random RandomGenerator = new Random();
    private static List<string> _alreadyUsed = ReadAlreadyUsed();
    private static readonly string FileName = Assembly.GetExecutingAssembly().Location + ".txt";

    /// <summary>
    /// Reads in a list of text strings that have previously been used - so we can avooid duplicating.
    /// </summary>
    /// <returns>A list of already used strings</returns>
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

    /// <summary>
    /// Creates some pseudo random text made up of at least 2 words and a number and a special character
    /// </summary>
    /// <param name="minimumLength">The minimum length</param>
    /// <param name="maximumLength">The maximum length</param>
    /// <param name="dontDuplicate">List of past used text that shouldn't be used again</param>
    /// <returns>Some pseudo random text</returns>
    public string CreateText(int minimumLength = 12, int? maximumLength = null, IEnumerable<string> dontDuplicate = null)
    {
      maximumLength = maximumLength ?? minimumLength;
      if (minimumLength < 8 || minimumLength > 15)
      {
        throw new ArgumentOutOfRangeException("minimumLength", minimumLength, "Can only generate text between 8 and 15 characters in length");
      }

      if (maximumLength < 8 || maximumLength > 15)
      {
        throw new ArgumentOutOfRangeException("maximumLength", maximumLength, "Can only generate text between 8 and 15 characters in length");
      }

      if (minimumLength > maximumLength)
      {
        throw new ArgumentOutOfRangeException("maximumLength", maximumLength, "Maximum length must be greater than minimum length.");
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
        text = GetText(minimumLength, maximumLength.Value);
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

    /// <summary>
    /// Writes the text to a file so we can check if it has been used next time
    /// </summary>
    /// <param name="text">The text to write</param>
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
    /// <summary>
    /// Gets a string of text that is between the min and max values in lenght.
    /// </summary>
    /// <param name="minimumLength">The minimum length</param>
    /// <param name="maximumLength">The maximum length</param>
    /// <returns>A string of text</returns>
    private static string GetText(int minimumLength, int maximumLength)
    {
      string text = String.Empty;

      bool correctLength = false;
      while (!correctLength)
      {
        int length;
        text = String.Empty;
        do
        {
          text += GetRandomWord();
          length = text.Length + 2;
        } while (length < minimumLength);

        correctLength = minimumLength <= length && length <= maximumLength;
      }

      var number = RandomGenerator.Next(10);
      var specialCharacter = SpecialCharacters.Substring(number, 1);
      text += number + specialCharacter;
      return text;
    }
    /// <summary>
    /// Gets a word from the list in a random manner
    /// </summary>
    /// <returns>A word</returns>
    private static string GetRandomWord()
    {
      return ((Words)RandomGenerator.Next((int)Words.MaxValue)).ToString();
    }
  }
}
