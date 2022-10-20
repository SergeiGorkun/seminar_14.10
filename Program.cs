// I раздел. Реализовать следующие функции для работы с массивами
int[] array = { 12, 13, -19, 23, 1, 176, -134, 234, -190, 12, 12 };


int getMinimumValue(int[] arr)
{
    int Min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < Min)
        {
            Min = arr[i];
        }
    }
    return Min;
}

int getMaximumValue(int[] arr)
{
    int Max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > Max)
        {
            Max = arr[i];
        }
    }
    return Max;
}

int sumArrayElements(int[] arr)
{
    int Sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Sum = Sum + arr[i];
    }
    return Sum;
}

int productArrayElements(int[] arr)
{
    int Prod = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        Prod = Prod * arr[i];
    }
    return Prod;
}

int searchIndexOfElement(int[] arr, int Number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == Number)
        {
            return i;
        }
    }
    return -1;
}

bool checkingElement(int[] arr, int Element)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == Element)
        {
            return true;
        }
    }
    return false;
}

void PrintingArrayScreen(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int arithmeticMeanElements(int[] arr)
{
    int Sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Sum = Sum + arr[i];
    }
    return Sum / arr.Length;
}

int countingNegativeElements(int[] arr)
{
    int Negativ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] < 0)
        {
            Negativ = Negativ + 1;
        }
    }
    return Negativ;
}

int countingNumberElements(int[] arr)
{
    int Honest = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Honest = Honest + 1;
        }
    }
    return Honest;
}

int CountingNumberoccurrences(int[] arr, int Number)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Number == arr[i])
        {
            count = count + 1;
        }
    }
    return count;
}

int countingNumberPositiv(int[] arr)
{
    int Positiv = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] > 0)
        {
            Positiv = Positiv + 1;
        }
    }
    return Positiv;
}

int coutingNumberOddElements(int[] arr)
{
    int Odd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            Odd = Odd + 1;
        }
    }
    return Odd;
}

bool SortAscending(int [] arr){
    for(int i = 1; i < arr.Length; i ++) {
        if(arr[i - 1] > arr[i]) {
            return false;
        }
    }
    return true;
}

// II раздел. Реализовать следующие функции

int NumberPower(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * a;
    }
    return result;
}

int FactorialCalcul(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}


int SumDigits(int n)
{
    int Sum = 0;
    string str = Convert.ToString(n);
    for (int i = 0; i < str.Length; i++)
    {
        Sum = Sum + int.Parse(Convert.ToString(str[i]));
    }
    return Sum;
}


bool Palindrome(int n){
    string str = Convert.ToString(n);
    for(int i = 0; i < str.Length && i <= str.Length - i; i++){
        if(str[i] != str[str.Length - i - 1]) {
            return false;
        }
    }
    return true;
}

int foldingTwoNumbers(int a, int b){
    int Sum;
    Sum = a + b;
    return Sum;
}

bool justNumber(int n){
    for(int i = 2; i < n; i++) {
        if(n % i == 0) {
            return false;
        }
    }
    return true;
}

bool NumberEven(int n){
    return n % 2 == 0;
}

// III раздел


Console.WriteLine(getMinimumValue(array));
Console.WriteLine(getMaximumValue(array));
Console.WriteLine(sumArrayElements(array));
Console.WriteLine(productArrayElements(array));
Console.WriteLine(searchIndexOfElement(array, 8));
Console.WriteLine(checkingElement(array, 134));
Console.WriteLine();
PrintingArrayScreen(array);
Console.WriteLine();
Console.WriteLine(arithmeticMeanElements(array));
Console.WriteLine();
Console.WriteLine(countingNegativeElements(array));
Console.WriteLine();
Console.WriteLine(countingNumberElements(array));
Console.WriteLine();
Console.WriteLine(CountingNumberoccurrences(array, 12));
Console.WriteLine();
Console.WriteLine(countingNumberPositiv(array));
Console.WriteLine();
Console.WriteLine(coutingNumberOddElements(array));
Console.WriteLine();
Console.WriteLine(SortAscending(array));

Console.WriteLine(NumberPower(3, 3));
Console.WriteLine(FactorialCalcul(2));
Console.WriteLine(SumDigits(134));
Console.WriteLine(Palindrome(1001));
Console.WriteLine(foldingTwoNumbers(28, 13));
Console.WriteLine(justNumber(11));
Console.WriteLine(NumberEven(156));