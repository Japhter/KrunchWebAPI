using KrunchWebAPI.Helpers;
using System.Text;

namespace KrunchWebAPI.KrunchService
{
    public class KrunchService:IkrunchService
    {
        public KrunchService()
        {

        }
        public string CrunchPhrase(string input)
        {
            StringBuilder krunchOutput = new StringBuilder();
            bool blankBeforePunctuation = false;

            foreach (char c in input)
            {
                if (Char.IsLetter(c))
                {
                    if (KrunchHelperService.IsVowel(c) || krunchOutput.ToString().Contains(c.ToString()))
                    {
                        continue; 
                    }
                    krunchOutput.Append(c);
                }
                else if (c == ' ')
                {
                    if (!blankBeforePunctuation && (krunchOutput.Length == 0 || krunchOutput[krunchOutput.Length - 1] != ' '))
                    {
                        krunchOutput.Append(c);
                    }
                }
                else if (c == '.' || c == ',' || c == '?')
                {
                    krunchOutput.Append(c);
                    blankBeforePunctuation = true;
                }
                else
                {
                    krunchOutput.Append(c);
                    blankBeforePunctuation = false;
                }
            }

            if (krunchOutput.Length > 0 && krunchOutput[krunchOutput.Length - 1] == ' ')
            {
                krunchOutput.Remove(krunchOutput.Length - 1, 1);
                krunchOutput.Append('_');
            }

            return krunchOutput.ToString();
        }
    }
}
