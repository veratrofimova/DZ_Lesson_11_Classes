namespace DZ_Lesson_11_Classes
{
    public class Stack
    {
        List<string> stack = new List<string>();

        public int Size
        {
            get { return stack.Count; }
        }

        public string? Top
        {
            get
            {
                if (stack.Count == 0)
                    return null;
                else
                    return stack[0];
            }
        }

        public Stack(params string[] elements)
        {
            elements.ToList().ForEach(x => Add(x));           
        }

        public void Add(string element)
        {
            stack.Insert(0, element);
        }

        public string Pop()
        {
            if (!stack.Any())
                throw new EmptyStackException();

            string firstElement = stack[0]; 
            stack.RemoveAt(0);
             return firstElement;
        }

        public static Stack Concat(params Stack[] collection)
        {
            if (collection[0].Size == 0)
                throw new EmptyStackException();

            Stack stack = new Stack();

            stack = collection[0];
            
            return stack;
        }
    }
}
