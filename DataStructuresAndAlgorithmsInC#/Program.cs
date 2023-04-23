//Arrays
//Array Insertions & Deletions


// **Insert at the end of an array**

int[] intArray = new int[6];

//Make a variable to keep the length, because .Length is based off capacity and does not track the actual index
int length = 0;

// This adds data for us 
for (int i = 0; i < 3; i++)
{
    // 1 is optional
    intArray[length] = i + 1;
    length++;
}

//actual insertion at the end:
//intArray[length] = 8;
//length++;

Console.WriteLine();

foreach (var arrayElement in intArray)
{
    Console.WriteLine(arrayElement);
}

Console.WriteLine();

//// **Insert at the start of an array**
//for  (int i = 3;i >= 0; i--)
//{
//    //this is moving over all the values (shift)
//    intArray[i + 1] = intArray[i];
//}

////actual insertion at the beginning:
//intArray[0] = 20;


// **Insert anywhere in an array**

for  (int i = 4;i >= 2; i--)
{
    //shift each element one position to the right
    intArray[i + 1] = intArray[i];
}

intArray[2] = 8;