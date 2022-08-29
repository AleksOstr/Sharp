// Неповторяющиеся случайные числа в трехмерном массиве
Console.Clear();
void PrintMatrix(int[,,] matrix)                             
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int newRandomValue(int[,,] matrix)
{
    int randomValue = new Random().Next(10, 100);
    bool numExists = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] != randomValue) numExists = false;
                else
                {
                    numExists = true;
                    return newRandomValue(matrix);
                }
            }
        }
    }
    if (!numExists) return randomValue;
    else return newRandomValue(matrix);
}
var rand = new Random();
int x = rand.Next(2, 5);
int y = rand.Next(2, 5);
int z = rand.Next(2, 5);
int[,,] nums = new int[x, y, z];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        for (int k = 0; k < nums.GetLength(2); k++)
        {
            nums[i, j, k] = newRandomValue(nums);
        }
    }
}
PrintMatrix(nums);