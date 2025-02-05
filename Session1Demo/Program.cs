using static Session1Demo.ListGenerator;

namespace Session1Demo
{
    internal class Program
    {

        //public static var Print(int x)
        //{
        //    return x;
        //}

        //public static dynamic Print(int x)
        //{
        //    return x;
        //}

        

        static void Main(string[] args)
        {

            #region Implicitly - Type local variavle[var - dynamic]
            ////Implicitly - Type local variavle[var - dynamic]

            //var

            //var Data01 = "Ahmed";


            //Compiler can detect the datatype of the local variable based on initial value,In compilation Time
            //Must be Initialized
            //Can't be Initialized the local variable with null
            //Can't change the datatype of the local variable after Initialization
            //Can't use var as parameter or return type


            //Data01 = 12; //Invalid



            //dynamic : Like var in javascript
            //dynamic Data02 = null;

            //CLR detect the datatype of the local variable based on the last value.in Run Time
            //Don't need to be initialized
            //Can Inintialize the local variable with null
            //Can change datatype of the local variable after initialized
            //Can use dynamic as parameter or return type
            //Be carfull when use dynamic 
            //Like var in js or object in c#

            //Console.WriteLine(Data02.GetType().Name);


            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.2;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4f;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = true;
            //Console.WriteLine(Data02.GetType().Name);

            //var x = 12;
            //var x = () => Console.WriteLine("Hello world"); 
            //dynamic x = delegate () { Console.WriteLine("Hello world"); };  
            #endregion

            #region Anonymous Type
            ////Anonymous Type
            ////Employee E01 = new Employee() { Id =1 , Name="ahmed",Salary=12000};
            //var E01 = new { Id =1 , Name="ahmed",Salary=12000.0m};
            ////var E02 = new { Id =1 , Name="ahmed",Salary=12000.0m};

            //var E02 = E01 with { Id =2 };//Newe feature c@ 10.0

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);

            ////E01.Id = 12;//Invalid : immutable can't change it's valuse after creation

            //Console.WriteLine(E01.GetType().Name); //<>f__AnonymousType0`3
            //Console.WriteLine(E01.GetType().Name); //<>f__AnonymousType0`3
            ////The same Anonymous Type as long as
            ////1.the same propenrty name {case senstive}
            ////2.the same property order

            ////Console.WriteLine(E01);
            ////compiler will override on ToString

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            ////if (E01.Equals(E02)) //Compiler will overridr on equals
            ////{
            ////    Console.WriteLine("E01==E02");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("E01!=E02");
            ////} 
            #endregion

            #region Extention Methods
            ////Extention Methods

            //long Number = 12345;

            ////var result = IntExtention.Reverse(Number);//class member method

            //var result = Number.Reverse();//Extention method(class static ,non-generic)

            //Console.WriteLine(result);//54321 
            #endregion

            #region What is LINQ
            //LINQ : Language Integrated Query 
            //     : 40+ Extention (LINQ Operator ) aganist any [data in sequence]
            //     : Regardless Data store
            //     : 13 Category
            //     :LINQ operator Exists in builr-in class "Enumerable"

            //Sequence : Object from class implement Interface "IEnumerable"
            //Local Sequence  : L2O , L2XML
            //Remote Sequence : L2EF

            //Input Sequence -> LINQ operator -> Output Sequence
            //Input Sequence -> LINQ operator -> One value
            //               -> LINQ operator -> Output Sequence

            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //var result =Enumerable.Where(Numbers, N => N % 2 == 0);
            //var result =Enumerable.Any(Numbers, N => N % 2 == 0);
            //var result = Enumerable.Range(1, 100);

            //Console.WriteLine(result);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //} 
            #endregion

            #region LINQ syntax
            ////LINQ syntax

            //1.Fluent Syntax
            //Use LINQ Methods
            //1.1.LINQ Operator as => Class Member method through class Enumerable

            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //var result = Enumerable.Where(Numbers, X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //     Console.WriteLine($"{item} ");
            //}

            //1.2.LINQ operator as => Extention Method Through Sequence[Recommended]
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = Numbers.Where( X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}




            //2.Query Syntax [Query Expression ] Like SQL style
            //start  from
            //end select ,group by
            //Query syntax easier than fluent(join , group by , let , Into)

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = from N in Numbers
            //             where N % 2 == 0
            //             select N;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            /*
             seslect N
            from numbers
            where N%2 = 0
            select N;
             */
            #endregion

            #region LINQ Execution ways
            //LINQ Execution ways
            //1.Differed Execution way  : 10 Category
            //2.Immediate Execution way : 3 Category [elements operator , casting operator , aggregate operator]


            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //var result = Numbers.Where(X=> X % 2 ==0 ); //Differed 

            //Numbers.AddRange(new int[]{ 11,12,13,14,15});

            //foreach (var item in result) //here
            //{
            //    Console.WriteLine($"{item} ");
            //}


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0).ToList(); //Immediatee 

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result) 
            //{
            //    Console.WriteLine($"{item} ");
            //} 
            #endregion

            #region Setup Data
            ////Setup Data
            //Console.WriteLine(ListGenerator.ProductList[0]);
            //Console.WriteLine(ListGenerator.CustomerList[0]);

            //var result = ProductList.Where(P => P.UnitsInStock == 0);
            //var result = CustomerList.Where(C => C.City == "Berlin");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

        }
    }
}
