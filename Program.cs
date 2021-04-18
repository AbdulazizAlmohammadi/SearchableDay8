using System;

namespace SearchableDay8
{
    class Program
    {
        class Searchable
        {
            public string value;

            public Searchable(String val)
            {
                this.value = val;
            }

            public int numOfWords()
            {
                int result = 0;
                int i = 0;
                while (i < value.Length)
                {
                    if (char.IsLetter(value[i]))
                    {
                        while(i < value.Length)
                        {
                            if (char.IsWhiteSpace(value[i])) { 
                                result++;
                                break;
                            }
                            i++;
                        }
                    }
                    i++;
                }
                return result;
            }

            public int numOfchars()
            {
                return value.Length;
            }

            public int numOfXWordl(String word) {
                int result = 0;
                String xWord = "";
                int i = 0;
                while (i < value.Length)
                {
                    xWord = "";
                    if (char.IsLetter(value[i]))
                    {
                        while (i < value.Length)
                        {
                            if (char.IsWhiteSpace(value[i]))
                            {
                                
                                break;
                            }
                            else
                            {
                                xWord += value[i];
                            }
                            i++;
                        }
                        
                        if (xWord.Equals(word)) result++;
                    }
                    i++;
                }
                return result;
            }


            public int numOfXChar(char c) {
                int result = 0;
                foreach(char ch in this.value)
                {
                    if (ch.Equals(c)) result++;
                }
                return result;
            }

            public int lastIndexOf(char c)
            {
                int result = -1;
                int i = 0;
                foreach(char ch in this.value)
                {
                    if (ch.Equals(c)) result = i;
                    i++;
                }

                return result;
            }

            public string swipeWords()
            {
                string result = "";
                string temp = "";
               
                String[] splits = this.value.Split(" ");
                for (int i = 0; i < splits.Length; i++)
                {
                 
                    temp = splits[i];
                    if(i!=splits.Length-1)
                    result += splits[i + 1]+" ";

                    result +=temp+" ";
                    i++;
                    
                }
                return result;
            }



        }




        static void Main(string[] args)
        {
            Searchable s = new Searchable("Hello world hey there one two three four");
            Console.WriteLine(s.lastIndexOf('w'));
            Console.WriteLine(s.numOfchars());
            Console.WriteLine(s.numOfWords());
            Console.WriteLine(s.numOfXChar('w'));
            Console.WriteLine(s.numOfXWordl("world"));
            Console.WriteLine(s.swipeWords());
        }
    }
}
