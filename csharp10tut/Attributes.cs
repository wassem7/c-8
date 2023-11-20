

public class Attributes {

    static void Main (){

        Calculator.Add(new List<int>() { 3,4,5,7});

    }
     
    public class Calculator {

        [Obsolete("Use Add (List<int> Numbers Method")]
        public static void Add(int FN,int SN){
            System.Console.WriteLine($"Sum : {FN +SN}");
        }

        public static void Add (List<int> Numbers){
         int Sum=0;

            foreach (int number in Numbers){
                Sum+=number;
            }

            System.Console.WriteLine("Sum : {0}",Sum);
        }
    }
}