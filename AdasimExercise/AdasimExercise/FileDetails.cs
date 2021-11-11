using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdasimExercise
{
    class FileDetails
    {
        public string FileContent { get; set; }

        public FileDetails(string fileContent)
        {
            FileContent = fileContent;
        }

        public int GetLinesCount()
        {
            try
            {
                string[] lines = FileContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                return lines.Length;
            }
            catch
            {
                return 0;
            }

        }

        public int GetWordsCount()
        {
            try
            {
                string[] words = Regex.Split(FileContent, @"\W+");
                return words.Length;
            }
            catch
            {
                return 0;
            }

        }

        public int GetUniqueWordsCount()
        {
            try
            {
                IEnumerable<string> allWords = Regex.Split(FileContent, @"\W+");
                IEnumerable<string> uniqueWords = allWords.GroupBy(w => w).Where(g => g.Count() == 1).Select(g => g.Key);
                return uniqueWords.Count();
            }
            catch
            {
                return 0;
            }

        }

        public double GetAvgSentenceLength()
        {
            try
            {
                string FileContentTemp = FileContent.Replace("\r\n", " ");
                string[] sentences = FileContentTemp.Split(new string[] { ".", ",", ";" }, StringSplitOptions.None);
                return sentences.Average(x => x.Length);
            }
            catch
            {
                return 0;
            }

        }

        public int GetMaxSentenceLength()
        {
            try
            {
                string FileContentTemp = FileContent.Replace("\r\n", " ");
                string[] sentences = FileContentTemp.Split(new string[] { ".", ",", ";" }, StringSplitOptions.None);
                string longest = sentences.OrderByDescending(s => s.Length).First();
                return longest.Length;
            }
            catch
            {
                return 0;
            }

        }


        public Dictionary<string, int> GetColors()
        {
            try
            {
                string[] words = FileContent.Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.None);
                List<string> onlyColors = new List<string>();
                for (int i = 0; i < words.Length; i++)
                {
                    Color c = Color.FromName(words[i]);
                    if (c.IsKnownColor)
                    {
                        onlyColors.Add(words[i]);
                    }

                }

                Dictionary<string, int> colorsDic = onlyColors.GroupBy(c => c).ToDictionary(k => k.Key, k => k.Count());

                return colorsDic;
            }
            catch
            {
                return null;
            }

        }

        public string GetMostPopularWord()
        {
            try
            {
                Dictionary<string, int> pop = Regex.Split(FileContent.ToLower(), @"\W+")
                .GroupBy(s => s)
                .OrderByDescending(g => g.Count())
                .ToDictionary(k => k.Key, k => k.Count());
                return pop.First().Key;
            }
            catch
            {
                return string.Empty;
            }

        }

        public Dictionary<string, int> GetCharacters()
        {
            try
            {
                NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();

                oDict.DictionaryFile = "en-US.dic";
                oDict.Initialize();
                NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();
                oSpell.Dictionary = oDict;

                string[] words = Regex.Split(FileContent, @"\W+");
                List<string> list = new List<string>();

                for (int i = 0; i < words.Length; i++)
                {
                    if (!oSpell.TestWord(words[i]) && words[i] != string.Empty && char.IsUpper(words[i][0]))
                    {
                        list.Add(words[i]);
                    }
                }

                Dictionary<string, int> characters = list.GroupBy(x => x).ToDictionary(k => k.Key, k => k.Count());

                return characters;
            }
            catch
            {
                return null;
            }

        }
    }
}
