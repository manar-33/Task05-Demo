namespace Task05_Demo
{
    internal class Program
    {
        //static void SWAP (int x, int y)
        //{ int temp = x; x = y; y = temp; }
        //static void SWAP( ref int x,ref int y)
        //{ int temp = x; x = y; y = temp; }
        //static int sumofarr(int[]arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        //static void  summul (int x, int y , out int sum , out int mul)
        //{
        //    sum = x + y;
        //    mul = x * y;
        //}
        //static int sumarray(params int[] arr)
        //{
        //    int sum = 0;
        //    if (arr != null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];
        //    }
        //    return sum;
        //}
        static void Main(string[] args)
        {
            #region Boxing,Unboxing
            ////boxing => casting from value type to reference type

            //object O1;
            // O1 = 1; //[casting] boxing safe casting
            //int x = 10;
            //object obj = x;
            ////unboxing => casting from reference type to value type
            //object obj2 = 10;
            //// int y = obj2; //[unsafe casting]
            //int y = (int)obj2; //unboing
            #endregion
            #region Nullable types
            //null as a value is valid only with reference type
            // int x = null; //invalid
            // int? y = null; //allow null and int
            // int x = 10;
            //// int? z = y; //valid
            //// int? z = x; //valid
            //int? k = null;
            // int l;
            // // l = (int)k;//unsafe casting
            // //if (k != null)
            // //{
            // //    l = (int)k;
            // //}else l = 0;
            // if (k.HasValue)
            // {
            //     l = k.Value;
            // }
            // else 
            //     l = 0;

            // l=k.HasValue ? k.Value : 0;
            /////////////////////////////////////
            //reference type
            //string message = "Hi";
            //message = null; //valid with warning
            //message = null!; //!=> null forgiveness operator
            //string ? message02 = null!;//valid without warning
            //Console.WriteLine(message);
            //Console.WriteLine(message02);


            #endregion
            #region null propagation operator ?
            //int[] numbers = default;
            ////foreach (var num in numbers)
            ////{
            ////    Console.WriteLine(num);
            ////}
            ////for (int i = 0;(numbers!=null)&&( i < numbers.Length); i++)
            ////{
            ////    Console.WriteLine(numbers[i]);
            ////}
            //if (numbers != null)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}//safe code
            //int length = numbers?.Length??0;

            #endregion
            #region function
            //int a=10 , b=20 ;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // SWAP(a, b);
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // //same result

            #endregion
            #region passing value by ref
            //int a=10 , b=20 ;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // SWAP(ref a,ref  b);
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            //output 10
            //20
            //20
            //10
            #endregion
            #region pass by reference type
            //int[] numbers = { 1, 2, 3, 4 };
            //int result = sumofarr(numbers);
            //Console.WriteLine(result);

            #endregion
            #region passing out
            //int a = 10; int b = 20; int sum;
            //int mul;
            //summul(a, b, out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);
            #endregion
            #region params
            //int result = sumarray(1, 2, 3, 4, 5, 6, 7);
            //Console.WriteLine(result);
            #endregion
        }
    }
}
