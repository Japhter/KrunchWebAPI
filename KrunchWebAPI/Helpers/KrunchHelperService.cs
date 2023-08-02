namespace KrunchWebAPI.Helpers
{
    public static class KrunchHelperService
    {
        public static bool IsVowel(char c)
        {
            return c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        }
    }
}
