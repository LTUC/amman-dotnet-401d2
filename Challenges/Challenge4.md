# Challenge 4

1. *Without using Visual Studio* - Writeout the output of this method.  

```csharp
        static void DebugChallenge(int[] myArray)
        {
            int temp = 0;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i; j < myArray.Length - 1; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                        temp = 0;
                    }
                }
                Console.WriteLine(myArray[i]);

            }
        } 
```