// matrisin elementlerini 2ye vur ekrana ver
int[,] numbers =
{
    {2,4,6,8 },
    {1,3,5,7 },
    {1,2,3,5 },
    {4,6,9,10 }
};
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.WriteLine(numbers[i, j]*2);
    }
}