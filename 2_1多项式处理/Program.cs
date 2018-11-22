using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1多项式处理
{
    //单项的节点
    //struct dxNode
    //{
    //    int e;          //每项的次方
    //    int xishu;      //每项的系数
    //    dxNode next;    //无法使用引用  在结构布局中导致循环
    //}

    ////单项的节点
    //public struct dxNode
    //{
    //    public int e;          //每项的次方
    //    public int xishu;      //每项的系数
    //    public object nextP;
    //    public dxNode next
    //    {
    //        set
    //        {
    //            nextP = value;
    //        }
    //        get
    //        {
    //            return (dxNode)nextP;
    //        }
    //    }
    //    public void SetNext(int e, int xishu)
    //    {
    //        ((dxNode)nextP).e = e;

    //    }

    //    public dxNode(int e, int xishu)
    //    {
    //        nextP = null;
    //        this.e = e;
    //        this.xishu = xishu;
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format(" {1}x^{0} ", e, xishu);
    //    }
    //}

    //单项的节点
    class dxNode
    {
        public int e;          //每项的次方
        public int xishu;      //每项的系数
        public dxNode next;

        public dxNode()
        {

        }
        public dxNode(int e, int xishu)
        {
            this.e = e;
            this.xishu = xishu;
        }

        public override string ToString()
        {
            return string.Format(" {1}x^{0} ", e, xishu);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //
            dxNode p1 = new dxNode(6, 3);
            dxNode temp = p1;
            temp.next = new dxNode(5, 3); temp = temp.next;
            temp.next = new dxNode(4, 3); temp = temp.next;
            temp.next = new dxNode(3, 3); temp = temp.next;
            temp.next = new dxNode(2, 3);

            dxNode p2 = new dxNode(6, 3);
            temp = p2;
            temp.next = new dxNode(5, -3); temp = temp.next;
            temp.next = new dxNode(4, 3); temp = temp.next;
            temp.next = new dxNode(3, 3); temp = temp.next;
            temp.next = new dxNode(1, 3);
            
            dxNode sum = DxnodeAdding(p1, p2);
            while (sum != null)
            {
                Console.WriteLine(sum);
                sum = sum.next;
            }
           
            Console.ReadKey();
        }
        // 每个二项式就是由多个dxNode连起来

        //两个二项式相加
        static dxNode DxnodeAdding(dxNode left, dxNode right)
        {
            dxNode front;   //组拼后的二项式头部
            dxNode rear;    //组拼的二项式尾部
            front = rear = new dxNode();

            //两个二项式都还有项
            while (left != null && right != null)
            {
                Console.WriteLine(1);
                if (left.e > right.e)        //如果left的次更高
                {
                    rear.next = left;
                    rear = rear.next;
                    left = left.next;
                }
                else if (left.e < right.e)   //如果right的次更
                {
                    rear.next = right;
                    rear = rear.next;
                    right = right.next;
                }
                else                         //如果right的次==left.e
                {
                    int xishu = left.xishu + right.xishu;
                    if (xishu != 0)
                    {
                        rear.next = new dxNode();
                        rear = rear.next;
                        rear.e = left.e;
                        rear.xishu = xishu;
                    }
                    left = left.next;
                    right = right.next;
                    //等于零就不将其放大组拼的二项式上

                }


            }

            //left与right有一个为空
            if (left != null)
            {
                rear.next = left;
            }
            if (right != null)
            {
                rear.next = right;
            }

            //将组拼的二项式首部放于后一个位置，尾部指针置空
            if (front.next != null)
            {
                front = front.next;
                rear = null;
            }
            return front;
        }

    }
}
