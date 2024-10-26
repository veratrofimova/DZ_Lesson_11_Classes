namespace DZ_Lesson_11_Classes
{
    public class AdditionalMethods
    {
        public static string[] Reverse(string[] elements)
        {
            string[] result = new string[elements.Length];

            for (int i = elements.Length - 1, j = 0; i >= 0; i--, j++)
            {
                result[j] = elements[i];
            }

            return result;
        }

        public static Stack[] GetStackArray(string[] collections)
        {
            Stack[] stacks = new Stack[collections.Length];
            for (int i = 0; i < collections.Length; i++)
            {
                stacks[i] = new Stack(Reverse(collections[i].Split(',')));
            }
            return stacks;
        }
    }
}
