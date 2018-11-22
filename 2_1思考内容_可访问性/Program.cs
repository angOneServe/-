using _2_1思考内容_可访问性_附件;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_1思考内容_可访问性
{
    class DefautClassWQT
    {
        int defaultZiduan;                  //默认private
        int defaultShuxing { set; get; }    //默认private
        DefautClass()
        { }
        void DefaultMethod()                //默认private
        {
            Console.WriteLine("DefaultMethod");
        }
    }
    struct DefaultStructWQT
    {
        int defaultZiduan;                  //默认private
        int defaultShuxing { set; get; }    //默认private

        void DefaultMethod()                //默认private
        {
            Console.WriteLine("DefaultMethod");
        }
    }

    // private class PrivateBaseclassWQT          //非嵌套的类只能使用internal 、public,默认为internal
    //{ }                                     //private、 protected 、 protected internal只能适用于嵌套的类，默认为private
    public class publicClassWQT {
      
    }
    internal class internalClassWQT{}
    public class QT
    {
        //嵌套的一些类
        internal class internalClass { }
        protected internal class protInterClass { }
        public class publicClass { }

        class defaultClass { }          //默认private
        private class privateClass { }
        protected class protectedClass { }
        
    }
    class Program
    {
       //使用非嵌套的类
        DefautClassWQT defautClassWQT;
        DefaultStructWQT defaultStructWQT;
        //使用另一程序集非嵌套的类
        fujianpublicClass fujianpublicClass;        //另一程序集的public 类
        //Class1 class1;                               //另一程序集的默认 类
        //fujianInternalClass fujianInternalClass;    //另一程序集的internal 类

        //在使用另一个类中的嵌套类
        QT.internalClass internalClass;         //internal
        QT.publicClass publicClass;             //public
        QT.protInterClass protInterClass;       //protected internal
        //QT.defaultClass defaultClass;           //private
        //QT.privateClass privateClass;           //private
        //QT.protectedClass protectedClass;       //prootected
       
        static void Main(string[] args)
        {
            
        }
    }
}
