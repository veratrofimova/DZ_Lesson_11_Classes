namespace DZ_Lesson_11_Classes
{
    public static class StackExtensions
    {
        public static void Merge(this Stack stack1, Stack stack2)
        {
            int count = stack2.Size;

            for (int i = 0; i < count; i++)
            {
                stack1.Add(stack2.Top ?? string.Empty);
                stack2.Pop();
            }
        }
    }
}
