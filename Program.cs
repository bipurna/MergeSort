internal class Program
{
    private static void Main(string[] args)
    {
        int[] givenArray = new int[] { 5, 8, 3, 9, 4, 2 };
        int[] result = MergeSort(givenArray);
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
    private static int[] MergeSort(int[] givenArray)
    {
        if (givenArray.Length == 1)
            return givenArray;

        int mid = givenArray.Length / 2;
        int[] left = new int[mid];
        for (int i = 0; i < mid; i++)
        {
            left[i] = givenArray[i];
        }
        int[] right = new int[givenArray.Length - mid];
        int startIndex = 0;
        for (int i = mid; i < givenArray.Length; i++)
        {
            right[startIndex] = givenArray[i];
            startIndex++;
        }
        left = MergeSort(left);
        right = MergeSort(right);
        return merge(left, right);
    }
    private static int[] merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int resultIndex = 0;
        int leftIndex = 0;
        int rightIndex = 0;
        while (leftIndex < left.Length || rightIndex < right.Length)
        {
            if (leftIndex == left.Length)
            {
                result[resultIndex] = right[rightIndex];
                rightIndex++;
                resultIndex++;
            }
            else if (rightIndex == right.Length)
            {
                result[resultIndex] = left[leftIndex];
                leftIndex++;
                resultIndex++;

            }
            else
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                    resultIndex++;
                }
                else if (left[leftIndex] >= right[rightIndex])
                {
                    result[resultIndex] = right[rightIndex];
                    rightIndex++;
                    resultIndex++;
                }
            }

        }

        return result;


    }
}