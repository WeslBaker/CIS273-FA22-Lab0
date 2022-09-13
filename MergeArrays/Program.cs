namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            List<int> list1 = array1.ToList();
            List<int> list2 = array2.ToList();
            List<int> mergedList = new List<int>();

            foreach(int num in list1)
            {
                mergedList.Add(num);
            }
            
            foreach(int num in list2)
            {
                mergedList.Add(num);
            }

            mergedList.Sort();
            int[] mergedArray = new int[0];

            foreach(int num in mergedList)
            {
                Array.Resize(ref mergedArray, mergedArray.Length + 1);
                mergedArray[mergedArray.Length - 1] = num;
            }
            return mergedArray;

        }
    }

}