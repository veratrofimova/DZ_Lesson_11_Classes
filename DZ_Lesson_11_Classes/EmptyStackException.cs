namespace DZ_Lesson_11_Classes
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException() : base("\r\nСтек пустой") {}
    }
}
