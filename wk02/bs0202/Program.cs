using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Hello world 周重石 092012!");
                        方法1();
                  類別2.方法1();
            命名2.類別2.方法1();
            類別2 物件1 = new 類別2();
                  物件1.物件方法1();
        }
        public static void 方法1(){
            Console.WriteLine("Program 方法1 周重石 092012!");
        }
    }
    class 類別2{
        public 類別2() {
            Console.WriteLine("類別2 建構元方法 周重石 092012!");
        }
        public static void 方法1(){
            Console.WriteLine("類別2 方法1 周重石 092012!");
        }
        public void 物件方法1(){
            Console.WriteLine("類別2 物件方法1 周重石    092012!");
        }
    }
}
namespace 命名2{
    class 類別2{
        public static void 方法1(){
            Console.WriteLine("命名2 類別2 方法1 周重石 092012!");
        }
    }
}