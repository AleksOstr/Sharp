// Задача с гирями

int firstWeight = new Random().Next(1, 101);
int secondWeight = new Random().Next(1, 101);
int thirdWeight = new Random().Next(1, 101);
int fourthWeight = new Random().Next(1, 101);
int fifthWeight = new Random().Next(1, 101);
Console.WriteLine($"{firstWeight}, {secondWeight}, {thirdWeight}, {fourthWeight}, {fifthWeight}");
int maxWeight = firstWeight;
if(firstWeight > maxWeight) 
{
    maxWeight = firstWeight;
}
if(secondWeight > maxWeight) 
{
    maxWeight = secondWeight;
}
if(thirdWeight > maxWeight) 
{
    maxWeight = thirdWeight;
}
if(fourthWeight > maxWeight) 
{
    maxWeight = fourthWeight;
}
if(fifthWeight > maxWeight) 
{
    maxWeight = fifthWeight;
}
Console.WriteLine(maxWeight);