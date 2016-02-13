using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracExam3SemSPS
{
    class Tokenizer
    {
        private List<WordToken> words;
        private List<NumberToken> numbers;

        public List<WordToken> Words
        {
            get
            {
                return new List<WordToken>(words);
            }
        }

        public List<NumberToken> Numbers
        {
            get
            {
                return new List<NumberToken>(numbers);
            }
        }

        public void AddWord(Token word)
        {
            words.Add((WordToken)word);
        }

        public void AddNumber(Token number)
        {
            numbers.Add((NumberToken)number);
        }

        public void List()
        {
            Console.WriteLine("Принятые токены-слова:");
            foreach (WordToken word in Words)
            {
                Console.WriteLine("	" + word);
            }
            Console.WriteLine("Принятые токены-числа:");
            foreach (NumberToken number in Numbers)
            {
                Console.WriteLine("	" + number);
            }
        }

        public Tokenizer()
        {
            words = new List<WordToken>();
            numbers = new List<NumberToken>();
        }
    }

    class Token
    {
        private int startsAt;
        private int endsAt;

        public int StartsAt
        {
            get
            {
                return startsAt;
            }
            //сомневаюсь, что сеттеры вообще нужны
            //set {
            //	if (value >= 0) {
            //		startsAt = value;
            //	} else
            //		throw new ArgumentException();
            //}
        }

        public int EndsAt
        {
            get
            {
                return endsAt;
            }
            //сомневаюсь, что сеттеры вообще нужны
            //set {
            //	if (value >= startsAt) {
            //		endsAt = value;
            //	} else
            //		throw new ArgumentException();
            //}
        }

        public Token(string str, int startsAt)
        {
            this.startsAt = startsAt;
            this.endsAt = startsAt + str.Length - 1;
        }

        public override string ToString()
        {
            return StartsAt + "-" + EndsAt;
        }
    }

    class WordToken : Token
    {
        public int length;
        public int Length
        {
            get
            {
                return length;
            }
        }

        public WordToken(string word, int startsAt)
            : base(word, startsAt)
        {
            length = word.Length;
        }

        public override string ToString()
        {
            return base.ToString() + " длиной в " + this.Length;
        }
    }

    class NumberToken : Token
    {
        private bool even;

        public bool Even
        {
            get
            {
                return even;
            }
        }

        public NumberToken(int number, int startsAt)
            : base(number.ToString(), startsAt)
        {
            even = (number % 2 == 0);
        }

        public override string ToString()
        {
            if (this.Even)
            {
                return base.ToString() + " четное";
            }
            else
            {
                return base.ToString() + " нечетное";
            }
        }
    }

    class TextViewer
    {
        public delegate void TokenHandler(Token token);

        public event TokenHandler WordHandled;
        public event TokenHandler NumberHandled;

        public void OnWordHandled(WordToken word)
        {
            WordHandled(word);
        }

        public void OnNumberHandled(NumberToken number)
        {
            NumberHandled(number);
        }

        private bool IsNumber(string str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Explore(string str)
        {
            string[] tokens = str.Split(' ');
            int currentPosition = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                if (IsNumber(tokens[i]))
                {
                    int number = int.Parse(tokens[i]);
                    NumberToken numberToken = new NumberToken(number, currentPosition);
                    OnNumberHandled(numberToken);
                }
                else
                {
                    WordToken wordToken = new WordToken(tokens[i], currentPosition);
                    OnWordHandled(wordToken);
                }
                currentPosition += tokens[i].Length + 1;
            }
        }

        public TextViewer() { }

        public TextViewer(Tokenizer tokenizer)
        {
            WordHandled += tokenizer.AddWord;
            NumberHandled += tokenizer.AddNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tokenizer tokenizer = new Tokenizer();
            TextViewer viewer = new TextViewer(tokenizer);
            string str = Console.ReadLine();
            viewer.Explore(str);

            tokenizer.List();
            Console.ReadKey();
        }
    }
}
