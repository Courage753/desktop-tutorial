using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp6
{


    internal class Program
    {

        static void Main(string[] args)
        {
            int counts = 0;
            string str = Console.ReadLine();
            string[] strs = str.Split(',');//输入一串数据,用逗号隔开
            double[] array1 = new double[strs.Length];//把输入的所有值赋值给array1数组
            for (; counts < strs.Length; counts++)
            {
                if (str != "")
                {
                    array1[counts] = double.Parse(strs[counts]);
                }
                else
                    break;
            }
            Console.WriteLine("数据个数为：" ,counts);
            function fc1 = new function();
            //double[] array = new double[function.count().array1.length];
            //int j = 0;
            //for (; j < function.count().array1.length; j++)
            //{
            //    array[j] = function.count().array1[j];
            //}
            fc1.sort(array1);
            fc1.average(array1);
            fc1.standarddeviation(array1);
            fc1.compare(array1);
            fc1.finalresult(array1);
            fc1.grubbs(array1);
        }

    }/// <summary>
    /// 函数类，包含接下来计算所需要的各种方法
    /// </summary>
    public class function
    {/// <summary>
    /// 计数，记录有多少个输入的数据，并把所有数据放入array1数组中
    /// </summary>
    /// <returns></returns>
    // public static (int i, double[] array1)count()//使用元组,为了返回array1和i(数据个数)
      //  {
           
            //return (i,array1);
       // }/// <summary>
        /// 采用冒泡算法，把array1中的数据从小到大排序
        /// </summary>
        /// <param name="array2"></param>
        public void sort(params double[] array2)
        {
            int i = 0;
            int j = 0;
            for (j=0;j<array2.Length-1;j++) //冒泡排序法
            {
                for (; i < array2.Length - 1; i++)
                {
                    if (array2[i] > array2[i + 1])
                    {
                        double temp;
                        temp = array2[i + 1];
                        array2[i + 1] = array2[j];
                        array2[i] = temp;
                    }

                }
            }
        }/// <summary>
        /// 求出array1数组的平均值
        /// </summary>
        /// <param name="array3"></param>
        /// <returns></returns>
        public double average(params double[] array3)
        {
            double sum=0;
            double ave;
            foreach (double for1 in array3)//遍历数组,求出数组中所有数据的总和
            {
                sum += for1;
            }
            ave = sum / array3.Length;//求出数组平均值
            return ave; 
        }/// <summary>
        /// 求array1数组的标准差
        /// </summary>
        /// <param name="array4"></param>
        /// <returns></returns>
        public double standarddeviation(params double[] array4)
        {
            double ave = average(array4);//获得之前求得的平均值
            double std = 0;//初始化标准差
            double sum = 0;
            foreach (double for2 in array4)//遍历数组,用数组中的每一个值减去平均值后求平方最后加总
            {   double Y = 0;
                double z = 0;
                Y = (for2 - ave);
                z=Math.Pow(Y, 2);
                sum+= z;
            }
            std = Math.Sqrt(sum / array4.Length);//用上面求得的总值除以数据个数最后开平方得到标准差
            return std;
        }/// <summary>
        /// 用最小值和最大值分别减去平均值再求绝对值，输出差值更大的差值，并且标记该差值的数组成员
        /// </summary>
        /// <param name="array5"></param>
        /// <returns></returns>
        public (double com,double larger)compare(params double[] array5)
        {
            double ave = average(array5);//获取之前求得的平均值
            double m ;//定义一个差值
            double n ;//定义一个差值
            m = array5[0] - ave;//用(排序后的第一个数组元素)最小值减去平均值
            m=Math.Abs(m);
            n = array5[array5.Length-1] - ave;//用(排序后的最后一个数组元素)最大值减去平均值
            n= Math.Abs(n);
            double com = 0;//定义一个com存放两个差值中更大的那个
            double larger = 0;//定义larger用来标记产生更大差值的那个数组元素
            if (m >= n)
            {
                com = m;
                larger = array5[0];
            }
            else
            {
                com = n;
                larger = array5[array5.Length-1];
            }
            return (com, larger);
        }/// <summary>
        /// 用更大的那个差值除以标准差，得到一个结果，再用这个结果比对格拉布斯表
        /// </summary>
        /// <param name="array7"></param>
        /// <returns></returns>
        public double finalresult(params double[] array7)
        {
            double thefinal = 0;//定义一个最终结果(格拉布斯算法)
           double x = compare(array7).com;//两者中更大的差值
           double y = standarddeviation(array7);//标准差
            thefinal = x / y;//用差值除以标准差得到结果
            return thefinal;
        }   /// <summary>
        /// 用最终算出来的值去比对格拉布斯表
        /// </summary>
        /// <param name="array6"></param>
        public void grubbs(params double[] array6)
        {
            double x1 = finalresult(array6);//x为最终值
            switch (array6.Length) //数据个数为几就对应几的格拉布斯表
            { case 3: { if (x1 > 1.153) { Console.WriteLine(compare(array6).larger + "是离群值"); } else Console.WriteLine("没有离群值");break; }
                case 4: { if (x1 > 1.463) { Console.WriteLine(compare(array6).larger + "是离群值"); } else Console.WriteLine("没有离群值"); break; }
                case 5: { if (x1 > 1.672) { Console.WriteLine(compare(array6).larger + "是离群值"); } else Console.WriteLine("没有离群值"); break; }
                case 6: { if (x1> 1.822) { Console.WriteLine(compare(array6).larger + "是离群值"); } else Console.WriteLine("没有离群值"); break; }
                case 7: { if (x1 > 1.938) { Console.WriteLine(compare(array6).larger + "是离群值"); } else Console.WriteLine("没有离群值"); break; }
                case 8: { if (x1 > 2.032) { Console.WriteLine(compare(array6).larger + "是离群值"); } else Console.WriteLine("没有离群值"); break; }
                case 9: { if (x1 > 2.110 ) { Console.WriteLine(compare(array6).larger + "是离群值"); } else Console.WriteLine("没有离群值"); break; }
                case 10: { if (x1 > 2.176) { Console.WriteLine(compare(array6).larger + "是离群值"); } else Console.WriteLine("没有离群值"); break; }
            }
        }
    }
}



