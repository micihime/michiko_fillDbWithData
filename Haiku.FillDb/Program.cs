using Haiku.DataAccessLayer.DBAccess;
using Haiku.DataAccessLayer.Data;
using Haiku.WordApi;
using Haiku.WordApi.WordApiData;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Haiku.FillDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert path (containing also file name) to word list file:");
            string wordFile = Console.ReadLine();
            Console.WriteLine("Please, insert path (containing also file name) to model list file:");
            string modelFile = Console.ReadLine();
            //Console.WriteLine("Please, insert connection string:");
            //string connectionString = Console.ReadLine();
            //TODO use connection string
            bool wordsLoaded = LoadWords(@wordFile);
            bool modelsLoaded = LoadModels(@modelFile);
            //TODO write success or fail
        }

        private static bool LoadWords(string fileName)
        {
            List<string> words = null;
            try
            {
                words = new List<string>();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                List<string> withDuplicates = lines.ToList();
                words = withDuplicates.Distinct().ToList();
                List<HaikuWord> haikuWords = new List<HaikuWord>();

                foreach (var word in words)
                {
                    HaikuWord haikuWord = new HaikuWord();
                    if (!HaikuDBAccess.IsAlreadyInDatabase(word))
                    {
                        haikuWord = MakeHaikuWordFromWordString(word);
                        if (haikuWord != null)
                            HaikuDBAccess.SaveHaikuWord(haikuWord);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        private static HaikuWord MakeHaikuWordFromWordString(string word)
        {
            try
            {
                HaikuWord haikuWord = new HaikuWord();
                string response = WordApiResponse.GetResponseStream(WordApiRequest.CreateGetWordRequest(word));

                if (response != null)
                {
                    WordApiWord wordApiWord = JsonConvert.DeserializeObject<WordApiWord>(response);
                    haikuWord.WordString = word;
                    haikuWord.WordPartOfSpeech = wordApiWord.results[0].partOfSpeech;
                    haikuWord.NumberOfSyllables = (Int16)wordApiWord.syllables.count;
                    return haikuWord;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }

        private static bool LoadModels(string fileName)
        {
            List<string> models = null;
            try
            {
                models = new List<string>();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                int i = 0;
                while (i <= lines.Length)
                {
                    HaikuModel model = new HaikuModel();
                    model.FirstVerseModel = lines[i];
                    model.SecondVerseModel = lines[i + 1];
                    model.ThirdVerseModel = lines[i + 2];

                    HaikuDBAccess.SaveHaikuModel(model);
                    i += 4;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
    }
}
