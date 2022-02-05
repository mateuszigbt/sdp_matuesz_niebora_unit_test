
namespace ConsoleApp1
{
    public static class Program
    {
        public static bool CzyJest(int liczba)
        {
            
            if (liczba == 0 || liczba == 1)
            {
                return false;
            }
            if (liczba < 0)
            {
                throw new ArgumentException("Under 0");
            }
            for (int i = 2; i < liczba; i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
