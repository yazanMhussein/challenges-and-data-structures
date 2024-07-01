using System;

public class FindCommonElementsinTwoArrays
{ public static void Main()
    {
        int[] array1 = { 1, 2, 3, 0 };
        int[] array2 = { 2, 3, 4, 9 };

        int[] commonElements = CommonElements(array1, array2);
        Console.WriteLine("Common Elements: " + string.Join(", ", commonElements));
    }
    public static int[] CommonElements(int[] array1, int[] array2)
    {
        int[] tempCommon = new int[array1.Length];
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        { for (int j = 0; j < array2.Length; j++)
            { if (array1[i] == array2[j])
                {bool alreadyExists = false;
                 for (int k = 0; k < count; k++)
                    {
                      if (tempCommon[k] == array1[i])
                        {
                            alreadyExists = true;
                            break;
                        }
                    }
                    if (!alreadyExists)
                    {
                        tempCommon[count++] = array1[i];
                    }
                }
            }
        }
        int[] commonElements = new int[count];
        Array.Copy(tempCommon, commonElements, count);

        return commonElements;
    }
}
