using System;

namespace WpfApplication1
{
    public class Checking
    {
        private String Content;
        private String _field;

        public Checking(String field, String content)
        {
            Content = content;
            _field = field;
        }

        public bool EmptyCheck()
        {
            if (Content==null || Content.Equals("") )
            {
                Errors errors = new Errors(_field+" can not be empty !");
                errors.Show();
                return false;
                
            }

            return true;
        }

        public bool IdCheck()
        {
            bool containsLetter = true;
            for (int i = 0; i < Content.Length; i++)
            {
                if (!(Content[i].Equals('0') || Content[i].Equals('1') || Content[i].Equals('2') ||
                      Content[i].Equals('3') || Content[i].Equals('4') || Content[i].Equals('5') ||
                      Content[i].Equals('6') || Content[i].Equals('7') || Content[i].Equals('8') ||
                      Content[i].Equals('9')))
                {
                    containsLetter = false;
                    break;
                }
            }

            if (!containsLetter)
            {
                Errors errors = new Errors(_field + " should only contain digits !");
                errors.Show();
            }
            return containsLetter;
        }

        public bool IdLength()
        {
            if (Content.Length == 10)
            {
                return true;
            }
            else
            {
                Errors errors = new Errors(_field+" should be 10 digits long !!");
                errors.Show();
                return false;
            }
        }

        public bool AgeCheck()
        {
            if (Int32.Parse(Content) >= 1 && Int32.Parse(Content) <= 120)
            {
                return true;
            }
            else 
            {
                Errors errors = new Errors(_field+" age not acceptable !!");
                errors.Show();
                return false;
            }
        }
    }
}