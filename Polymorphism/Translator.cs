using System.Runtime.InteropServices;
using System.Text;
namespace Translator
{
    public struct TranslateWord
    {
        public string originalWord;
        public string[] languages = { "Russian", "Spanish", "Franch" };
        public string[] translates = new string[3];
        public TranslateWord(string orig, string[] str)
        {
            this.originalWord = orig;
            translates = str;
        }
        public string? this[string lang]
        {
            get
            {
                //Console.WriteLine("Im here");
                int i = 0;
                lang.ToLower();
                foreach (var item in languages)
                {
                    if (lang == item.ToLower())
                    {
                        return translates[i];
                    }
                    i++;
                }
                return null;
            }
        }
    }
    public abstract class Translators
    {
        protected string language;
        public abstract void Translate(string word,  TranslateWord[] arr);


    }
    public class Russian : Translators
    {

        public Russian()
        {
            language = "russian";
        }

        public override void Translate(string word, TranslateWord[] arr)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].originalWord.ToLower() == word.ToLower())
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                Console.WriteLine($"{arr[index][language]}");

            }

        }
    }
    public class Spanish : Translators
    {

        public Spanish()
        {
            language = "spanish";
        }

        public override void Translate(string word, TranslateWord[] arr)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].originalWord.ToLower() == word.ToLower())
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                Console.WriteLine($"{arr[index][language]}");

            }

        }
    }
    public class French : Translators
    {

        public French()
        {
            language = "franch";
        }

        public override void Translate(string word, TranslateWord[] arr)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].originalWord.ToLower() == word.ToLower())
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                Console.WriteLine($"{arr[index][language]}");

            }

        }
    }
    internal class Translator
    {
        static void Main(string[] args)
        {
            TranslateWord[] arr = new TranslateWord[3]
           {
                new TranslateWord("Hello", new string[] { "Privet", "Hola", "Bonjour" }),
                new TranslateWord("Goodbye", new string[] { "Do svidania", "Adiós", "Au revoir" }),
                new TranslateWord("Thank you", new string[] { "Spasibo", "Gracias", "Merci" })
            };
            Translators russiantranslator = new Russian();
            Translators frenchtranslator = new French();
            Translators Spanishtranslator = new Spanish();

            Translators[] t = {russiantranslator,frenchtranslator,Spanishtranslator};
            foreach(Translators item in t)
            {
                item.Translate("hello",arr);
            }

        }
    }

}


