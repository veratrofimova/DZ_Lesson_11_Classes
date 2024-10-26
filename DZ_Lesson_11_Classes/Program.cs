using DZ_Lesson_11_Classes;

Console.WriteLine("Добро пожаловать в программу: Реализация класс коллекции - Стэк!");
Console.WriteLine("Создадим коллекцию. Можно добавить несколько значений через запятую. Например: первый,второй,третий");
Console.WriteLine("Коллекция добавляется методом LIFO");

Console.WriteLine("\r\nВведите значения");
string textFromConsole = Console.ReadLine();
string[] elementsFromConsole = textFromConsole.Split(',');

var stack = new Stack(elementsFromConsole);

Console.WriteLine($"Size = {stack.Size}, Top = '{stack.Top}'");

Console.WriteLine("\r\nВам доступны следующие команды: /Add, /Pop, /MergeStack, /Concat, /Exit");
Console.WriteLine("Команда /Add - добавит значение в стек. Например: /Add новый");
Console.WriteLine("Команда /Pop - извлечет верхний элемент и удалит его из стека. ");
Console.WriteLine("Команда /MergeStack - добавит коллекцию в стек в прямом порядке в конец стека. Например: /MergeStack четвертый,пятый,шестой");
Console.WriteLine("Команда /Concat - добавит коллекции в стек в порядке параметров, но сами элементы записаны в обратном порядке. Например: /Concat 2,3;4,5;6,7");

try
{
    do
    {
        Console.WriteLine("\r\nВведите команду:");

        textFromConsole = Console.ReadLine().Trim();
        string[] commandText = textFromConsole.Split(new char[] { ' ' });

        switch (commandText[0])
        {
            case "/Add":
                string elementFromConsole = textFromConsole.Replace(commandText[0], "").Trim();

                stack.Add(elementFromConsole);

                Console.WriteLine($"Size = {stack.Size}, Top = '{stack.Top}'");
                break;
            case "/Pop":
                var deleted = stack.Pop();
                Console.WriteLine($"Извлечен верхний элемент '{deleted}' Size = {stack.Size}");
                Console.WriteLine($"Size = {stack.Size}, Top = '{stack.Top}'");
                break;
            case "/MergeStack":
                textFromConsole = textFromConsole.Replace(commandText[0], "").Trim();
                elementsFromConsole = textFromConsole.Split(',');

                var stack2 = new Stack(AdditionalMethods.Reverse(elementsFromConsole));
                stack.Merge(stack2);

                Console.WriteLine($"Size = {stack.Size}, Top = '{stack.Top}'");
                break;
            case "/Concat":
                textFromConsole = textFromConsole.Replace(commandText[0], "").Trim();
                string[] collections = textFromConsole.Split(';');

                Stack[] stacks = AdditionalMethods.GetStackArray(collections);

                var stackConcat = Stack.Concat(stacks);

                Console.WriteLine($"Size = {stackConcat.Size}, Top = '{stackConcat.Top}'");

                break;
        }
    } while (!textFromConsole.Contains("/Exit"));

    Console.WriteLine("\r\nРабота программы завершена");
}
catch (EmptyStackException ex)
{
    Console.WriteLine(ex.Message);
}
catch
{
    throw;
}