//using System;
//using collection;

//namespace practice_cases
//{
//    class player
//    {
//        public int runs { get; set; }
//    }

//    class partnership_runs
//    {
//        public int runs { get; set; }

//        public static partnership_runs operator ++(player pl1, player pl2)
//        {
//            partnership_runs rs = new partnership_runs();
//            rs.runs = pl1.runs + pl2.runs;
//            return rs;
//        }
//    }

//    class operator_overloaded
//    {
//        public static void Main()
//        {
//            player pl1 = new player();
//            player pl2 = new player();
//            pl1.runs = 50;
//            pl2.runs = 50;
//            partnership_runs total = pl1 + pl2;
//            Console.WriteLine("The total partnership is : " + total.runs);
//            Console.Read();
//        }
//    }
//}