using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ConfigSwitcher
{
  public class TextCreator
  {
    private enum Colour
    {
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
      MaxValue
    }
    private enum NumberWords
    {
      Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine
    }

    private const string ExtraText = "1234567890qwertyuiopasdfghjklasdfghjklzxcvbnm";
    private const string SpecialCharacters = ")!@#$%^&*(";
    private static readonly Random RandomGenerator = new Random();
    private static readonly List<string> AlreadyUsed = ReadAlreadyUsed();
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

    public string CreateText(int length = 12)
    {
      string text;
      const int maxRetry = 1000;
      int retryCount = 0;
      bool exists=false;
      do
      {
        text = GetText(length);
        retryCount++;
       // exists = AlreadyUsed.Contains(text);
      }
      while (retryCount < maxRetry && exists);

      if (!exists)
      {
        //AlreadyUsed.Add(text);
        //WriteTextToFile(text);
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
      string specialCharacter = null;
      string numberWord = null;
      int number = 0;
      string colour = null;
      int extraNeeded = -1;
      while (extraNeeded < 0 || extraNeeded > 1)
      {
        colour = ((Colour)RandomGenerator.Next((int)Colour.MaxValue)).ToString();
        number = RandomGenerator.Next(10);
        numberWord = ((NumberWords)number).ToString();
        specialCharacter = SpecialCharacters.Substring(number, 1);
        int currentLength = (colour.Length + numberWord.Length + 2);

        extraNeeded = length - currentLength;
      }

      string extraText = String.Empty;
      if (extraNeeded > 0)
      {
        while (extraText.Length < extraNeeded)
        {
          extraText += ExtraText;
        }

        if (extraText.Length > extraNeeded)
        {
          int rndint = RandomGenerator.Next(extraText.Length - extraNeeded);
          extraText = extraText.Substring(rndint, extraNeeded);
        }
      }

      ////string[] parts =
      ////{
      ////  colour,
      ////  numberWord,
      ////  number + specialCharacter,
      ////  extraText
      ////};

      ////int index = RandomGenerator.Next(3);
      ////string part1 = parts[index];
      ////index++;
      ////if (index > 3)
      ////{
      ////  index = 0;
      ////}

      ////string part2 = parts[index];
      ////index++;
      ////if (index > 3)
      ////{
      ////  index = 0;
      ////}

      ////string part3 = parts[index];
      ////index++;
      ////if (index > 3)
      ////{
      ////  index = 0;
      ////}

      ////string part4 = parts[index];

      ////string text = part1 + part2 + part3 + part4;
      string text = colour + numberWord + number + specialCharacter + extraText;
      return text;
    }
  }
}
