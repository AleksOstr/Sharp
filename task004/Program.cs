double[] array1 = new double[150];
double[] array2 = new double[150];
for (int i = 0; i < 150; i++)
{
    array1[i] = Math.Pow(i, 5);
    array2[i] = i;
}

for (int x = 1; x < 150; x++)
{
    for (int y = 1; y < 150; y++)
    {
        for (int z = 1; z < 150; z++)
        {
            for (int q = 1; q < 150; q++)
            {
                for (int w = 1; w < 150; w++)
                {
                    if (array1[x] + array1[y] + array1[z] + array1[q] == array1[w]) Console.WriteLine($"{array2[x]}^5 + {array2[y]}^5 + {array2[z]}^5 + {array2[q]}^5 = {array2[w]}^5");
                }
            }
        }
    }
}