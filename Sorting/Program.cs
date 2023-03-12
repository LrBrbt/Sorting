
//ОДНОМЕРНЫЙ МАССИВ

// Метод перестановки элементов
using Sorting;

static void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

//Сортировка пузырьком(Bubble Sort)

int[] arrayForBubble = { 3, 1, 83, 7, 6 };
static int[] BubbleSort(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                Swap(mas, i, j);
            }
        }
    }
    return mas;
}
Console.WriteLine("Сортировка пузырьком");
Console.Write("Массив: ");
for (int i = 0; i < arrayForBubble.Length; i++)
{
    Console.Write(arrayForBubble[i] + " ");
}
Console.WriteLine();

BubbleSort(arrayForBubble);

Console.Write("Отсортированный массив: ");
for (int i = 0; i < arrayForBubble.Length; i++)
{
    Console.Write(arrayForBubble[i] + " ");
}
Console.WriteLine();

//Сортировка перемешиванием (Шейкерная,коктейльная сортировка)

int[] arrayForCocktail = { 6, 5, 2, 0, 1, 32, 7, 31 };

static void CocktailSort(int[] mas)
{
    int left = 0;
    int right = mas.Length - 1;
    while (left < right)
    {
        for (int i = left; i < right; i++)
        {
            if (mas[i] > mas[i + 1])
                Swap(mas, i, i + 1);
        }
        right--;
        for (int i = right; i > left; i--)
        {
            if (mas[i - 1] > mas[i])
                Swap(mas, i - 1, i);
        }
        left++;
    }

}
Console.WriteLine();
Console.WriteLine("Сортировка перемешиванием");
Console.Write("Массив: ");
for (int i = 0; i < arrayForCocktail.Length; i++)
{
    Console.Write(arrayForCocktail[i] + " ");
}
Console.WriteLine();

CocktailSort(arrayForCocktail);

Console.Write("Отсортированный массив: ");
for (int i = 0; i < arrayForCocktail.Length; i++)
{
    Console.Write(arrayForCocktail[i] + " ");
}
Console.WriteLine();


//Сортировка вставками
int[] arrayForInserts = { -3, 7, 1, 9, -2, 8, 0 };

static int[] SortingByInserts(int[] mas)
{
    for (int i = 1; i < mas.Length; i++)
    {
        int k = mas[i];
        int j = i - 1;

        while (j >= 0 && mas[j] > k)
        {
            mas[j + 1] = mas[j];
            mas[j] = k;
            j--;
        }
    }
    return mas;
}

Console.WriteLine();
Console.WriteLine("Сортировка вставками");
Console.Write("Массив: ");
for (int i = 0; i < arrayForInserts.Length; i++)
{
    Console.Write(arrayForInserts[i] + " ");
}
Console.WriteLine();

CocktailSort(arrayForInserts);

Console.Write("Отсортированный массив: ");
for (int i = 0; i < arrayForInserts.Length; i++)
{
    Console.Write(arrayForInserts[i] + " ");
}
Console.WriteLine();

//Сортировка Шелла

int[] arrayForShell = { 3, 7, 2, 8, 9, 2, -6, 21 };

static int[] ShellSort(int[] mas)
{
    //расстояние между элементами, которые сравниваются
    var distance = mas.Length / 2;
    while (distance >= 1)
    {
        for (var i = distance; i < mas.Length; i++)
        {
            var j = i;
            while ((j >= distance) && (mas[j - distance] > mas[j]))
            {
                Swap(mas, mas[j], mas[j - distance]);
                j = j - distance;
            }
        }

        distance = distance / 2;
    }

    return mas;
}
Console.WriteLine();
Console.WriteLine("Сортировка Шелла");
Console.Write("Массив: ");
for (int i = 0; i < arrayForShell.Length; i++)
{
    Console.Write(arrayForShell[i] + " ");
}
Console.WriteLine();

CocktailSort(arrayForShell);

Console.Write("Отсортированный массив: ");
for (int i = 0; i < arrayForShell.Length; i++)
{
    Console.Write(arrayForShell[i] + " ");
}
Console.WriteLine();

//Сортировка выбором

int[] arrayForChoice = { 5, -7, 1, 5, 9, 21, 6 };

static int[] ChoiceSort(int[] mas)
{

    for (int i = 0; i < mas.Length - 1; i++)
    {
        //поиск минимального числа
        int min = i;
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[j] < mas[min])
            {
                min = j;
            }
        }

        Swap(mas, min, i);
    }
    return mas;
}
Console.WriteLine();
Console.WriteLine("Сортировка выбором");
Console.Write("Массив: ");
for (int i = 0; i < arrayForChoice.Length; i++)
{
    Console.Write(arrayForChoice[i] + " ");
}
Console.WriteLine();

CocktailSort(arrayForChoice);

Console.Write("Отсортированный массив: ");
for (int i = 0; i < arrayForChoice.Length; i++)
{
    Console.Write(arrayForChoice[i] + " ");
}
Console.WriteLine();

//Сортировка деревом

int[] arrayForTree = { 2, 8, 3, 1, -4, 2, 13 };



static int[] TreeSort(int[] array)
{
    var treeNode = new TreeNode(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        treeNode.Insert(new TreeNode(array[i]));
    }

    return treeNode.Transform();
}

TreeSort(arrayForTree);

Console.WriteLine();
Console.WriteLine("Сортировка деревом");
Console.Write("Массив: ");
for (int i = 0; i < arrayForTree.Length; i++)
{
    Console.Write(arrayForTree[i] + " ");
}
Console.WriteLine();

CocktailSort(arrayForTree);

Console.Write("Отсортированный массив: ");
for (int i = 0; i < arrayForTree.Length; i++)
{
    Console.Write(arrayForTree[i] + " ");
}
Console.WriteLine();

//Случайная сортировка 

int[] arrayForRandom = { 3, 9, 5, 2, 8, -6, 3 };

static bool IsSorted(int[] mas)
{
    for (int i = 0; i < mas.Length - 1; i++)
    {
        if (mas[i] > mas[i + 1])
            return false;
    }

    return true;
}
static int[] RandomMixing(int[] mas)
{
    Random random = new Random();
    var length = mas.Length;
    while (length > 1)
    {
        length--;
        var i = random.Next(length + 1);
        Swap(mas, i, length);
    }

    return mas;
}


static int[] BogoSort(int[] mas)
{
    while (!IsSorted(mas))
    {
        mas = RandomMixing(mas);
    }

    return mas;
}

Console.WriteLine();
Console.WriteLine("Случайная сортировка");
Console.Write("Массив: ");
for (int i = 0; i < arrayForRandom.Length; i++)
{
    Console.Write(arrayForRandom[i] + " ");
}
Console.WriteLine();

CocktailSort(arrayForRandom);

Console.Write("Отсортированный массив: ");
for (int i = 0; i < arrayForRandom.Length; i++)
{
    Console.Write(arrayForRandom[i] + " ");
}
Console.WriteLine();
Console.ReadKey();