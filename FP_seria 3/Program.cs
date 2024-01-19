using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FP_seria_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            //P18();
            //P19();
            //P20();
            //P21();
            //P22();
            //P23();
            //P25();
            //P27();
            //P28();
            //P29();
            //P31();
        }
        private static void P1()
        {
           
            int n, i,suma=0;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a=new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for(i=0;i<n;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                suma = suma + a[i];
            }
           Console.WriteLine($"Suma este: {suma}");
        }
        private static void P2()
        {
            int n, i,k,poz=0,ok=0;
            Console.WriteLine("Dati n: ");
            n= int.Parse(Console.ReadLine());
            Console.WriteLine("Dati k: ");
            k= int.Parse(Console.ReadLine());
            int[] v=new int[n];
            Console.WriteLine("Dati elem vect: ");
            for(i=0;i<v.Length;i++)
            {
                v[i]=int.Parse(Console.ReadLine());
            }
            for (i = 0; i < v.Length; i++)
            {
                if (v[i]==k)
                {
                    poz = i;
                    ok = 1;
                    break;
                }
            }
            if (ok == 0)
                Console.WriteLine("-1");
            else
                Console.WriteLine($"Poz pe care se afla k este: {poz}");
        }

        private static void P3()
        {
            int n, i,min1=1000000,max1=0,poz1=0,poz2=0;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(i = 0; i < n;i++)
            {
                if (a[i]>=max1)
                {
                    max1= a[i];
                    poz1 = i;
                }
                if (a[i] <= min1)
                {
                    min1 = a[i];
                    poz2 = i;
                }
            }
            Console.WriteLine($"Nr cel mai mic se afla pe pozitia: {poz2}.Nr cel mai mare se afla pe pozitia: {poz1}");
        }
        private static void P4()
        {
            int n, i, ap1=1,ap2=1;
            
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i <n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int min1 = a[0], max1 = a[0];
            for (i = 1; i <n; i++)
            {
                if (a[i] > max1)
                {
                    max1 = a[i];
                    ap1 = 1;
                }
                else
                    if (a[i] == max1)
                        ap1++;
                if (a[i] < min1)
                {
                    min1 = a[i];
                    ap2 = 1;
                }
                else
                    if (a[i] == min1)
                        ap2++;
            }
            Console.WriteLine($"Nr cel mai mare este: {max1}, iar nr cel mai mic este: {min1}.Nr cel mai mare apare de: {ap1} ori, iar nr cel mai mic apare de {ap2} ori");
        }
        private static void P5()
        {
            int n, i,val,poz;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dati val: ");
            val= int.Parse(Console.ReadLine());
            Console.WriteLine("Dati poz: ");
            poz= int.Parse(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                if(i==poz)
                    a[i]= val;
            }
            for(i = 0; i < n;i++)
                Console.Write($"{a[i]} ");
        }
        private static void P6()
        {
            int n, i, poz;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dati poz: ");
            poz = int.Parse(Console.ReadLine());
            for (i = poz; i < n-1; i++)
            {
                    a[i] = a[i+1];
            }
            Array.Resize(ref a, n - 1);
            for (i = 0; i < a.Length; i++)
                Console.Write($"{a[i]} ");
        }
        private static void P7()
        {
            int n, i;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int aux;
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<n/2;i++)
            {
                aux = a[i];
                a[i] = a[n - i - 1];
                a[n-i-1] = aux;
            }
            for (i = 0; i < n; i++)
                Console.Write($"{a[i]} ");
        }
        private static void P8()
        {
            int n, i,aux;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            aux = a[0];
            for(i=0;i<n-1;i++)
            {
                a[i] = a[i + 1];
               
            }
            a[n - 1] = aux;
            for (i = 0; i < n; i++)
               Console.Write($"{a[i]} ");
        }
        private static void P9()
        {
            int n, i, aux;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] temp = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int k;
            Console.WriteLine("Dati k: ");
            k = int.Parse(Console.ReadLine());
            int j = 0;
            for (i = 0; i < n ; i++)
            {
                aux = a[j];
                if (i + k >= n)
                {
                    temp[i] = aux;
                    j++;
                }
                else
                    temp[i] = a[i + k];
            }
            for (i = 0; i < n; i++)
                Console.Write($"{temp[i]} ");
        }
        private static void P10()
        {
            int n, i, poz = -1;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int k;
            Console.WriteLine("Dati k: ");
            k = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                int st = 0, dr = n - 1;
                while (st <= dr)
                {
                    int mij = (st + dr) / 2;
                    if (a[mij] == k)
                    {
                        poz = mij;
                        break;
                    }
                    else
                        if (a[mij] > k)
                            dr = mij - 1;
                        else
                        st = mij + 1;

                }
            }
            if (poz != -1)
                Console.WriteLine($"Elem k se gaseste pe poz:{poz} ");
            else
                Console.WriteLine($"-1");

        }
        private static void P11()
        {
            int n,i,j;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            int[] a = new int[n];
            a[0] = 1;
            a[1] = 1;
            for(i=2;i<Math.Sqrt(n);i++)
            {
               for (j = 2; i*j<n; j++)
                    a[i * j] = 1;
            }
            for(i=0;i< n; i++)
            {
                if (a[i] == 0)
                    Console.Write($"{i} ");
            }
        }
        private static void P12()
        {
            int n, i, j,aux;
            Console.WriteLine("Dati n: ");
            n= int.Parse(Console.ReadLine());
            int[] a=new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for(i = 0; i < n;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            for(i=0;i<n;i++)
            {
                int k = i;
                for (j = i + 1; j < n; j++)
                    if (a[k] > a[j])
                        k = j;
                aux = a[i];
                a[i] = a[k];
                a[k] = aux;
            }
            for (i = 0; i < n; i++)
                Console.Write($"{a[i]} ");
        }
        private static void P13()
        {
            int n, i, aux,p;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(i=1;i<n;i++)
            {
                p = i;
                while(p>0 && a[p] < a[p-1])
                {
                    aux = a[p];
                    a[p] = a[p-1]; a[p-1]= aux;
                    p--;
                }
            }
            for (i = 0; i < n; i++)
                Console.Write($"{a[i]} ");
        }
        private static void P14()
        {
            int n, i,j;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            i = 0;
            j = 0;
            while(i<n)
            {
                if (a[i]!=0)
                {
                    interschimba(ref a[i], ref a[j]);
                    j++;
                }
                i++;
            }
            for (i = 0; i < n; i++)
                Console.Write($"{a[i]} ");
        }
        static void interschimba(ref int a, ref int b)
        {
            int aux = a;
            a = b; b = aux;
        }
        private static void P15()
        {
            int n, ap = 0, aux = 0;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati elem vect: ");
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int p;
            for (int i = 0; i < v.Length - 1; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                    if (v[i] == v[j])
                        aux = v[i];
            }
            for (p = v.Length - 1; p >= 0; p--)
            {

                if (v[p] == aux)
                {
                    for (int i = p; i < v.Length - 1; i++)
                    {
                        v[i] = v[i + 1];

                    }
                    ap++;
                }



            }
            Array.Resize(ref v, n - ap);
            for (int i = 0; i < v.Length; i++)
                Console.Write($"{v[i]} ");
        }
       
        private static void P16()
        {
            int n, i,x,y=0,z=0;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i <a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            x = a[0];
            for(i=1; i< a.Length;i++)
            {
                y = a[i];
               z= CMMDC(x, y);
            }
            Console.WriteLine(z);
        }
        private static int CMMDC(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        private static void P17()
        {
            int numar, b;
            Console.WriteLine("Dati nr in baza 10: ");
            numar= int.Parse(Console.ReadLine());
            Console.WriteLine("Dati b: ");
            b= int.Parse(Console.ReadLine());
            if (b < 1 || b > 17)
                Console.WriteLine("Introduceti alta baza");
            if (b < 10)
            {
                Stack<int> stack = new Stack<int>();
                while (numar > 0)
                {
                    stack.Push(numar % b);
                    numar /= b;
                }
                while (stack.Count > 0)
                {
                    Console.Write($"{stack.Pop()} ");
                }
            }
            else
            {
                 Stack<int> stack= new Stack<int>();
                 while(numar>0)
                {
                    stack.Push(numar % b);
                    numar = numar / b;
                }
                while(stack.Count > 0)
                {
                    int d= stack.Pop();
                    if (d < 10)
                        Console.Write(d);
                    else
                        switch(d)
                        {
                            case 10:
                                Console.Write("A");
                                break;
                            case 11:
                                Console.Write("B");
                                break;
                            case 12:
                                Console.Write("C");
                                break;
                            case 13:
                                Console.Write("D");
                                break;
                            case 14:
                                Console.Write("E");
                                break;
                            case 15:
                                Console.Write("F");
                                break;
                            default:
                                break;
                        }
                }
            }
        }
        private static void P18()
        {
            int n,i;
            double x,rez=0;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati vect cu coef polin: ");
            for(i=0;i<v.Length;i++)
                v[i]=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati x: ");
            x = double.Parse(Console.ReadLine());
            for(i=0 ;i<v.Length;i++)
            {
                if (i == 0)
                    rez = v[i];
                else
                    rez = rez + v[i]*Math.Pow(x,i);
            }
            Console.WriteLine(rez);
        }
        private static void P19()
        {
            int n, m, i;
            Console.WriteLine("Dati n: ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati m: ");
            m=int.Parse(Console.ReadLine());
            int[] s =new int[n];
            int[] p= new int[m];
            Console.WriteLine("Dati elem vect s: ");
            for(i=0; i<s.Length;i++)
                s[i]= int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elem vect p: ");
            for (i = 0; i < p.Length; i++)
                p[i] = int.Parse(Console.ReadLine());
            int count = numara_ap(s, p);
            Console.WriteLine(count);
        }

        private static int numara_ap(int[] s, int[] p)
        {
            int count = 0;

            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < p.Length; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    count++;
                }
            }

            return count;
        }
        private static void P20()
        {
            Console.WriteLine("Dati s1: ");
            string s1= Console.ReadLine();
            Console.WriteLine("Dati s2: ");
            string s2= Console.ReadLine();
            int nrsup = numara_sup(s1, s2);
            Console.WriteLine(nrsup);
        }

        private static int numara_sup(string s1, string s2)
        {
            int count = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (este_sup(s1, s2, i))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool este_sup(string s1, string s2, int shift)
        {
            for (int i = 0; i < s1.Length - shift; i++)
            {
                if (s1[i + shift] == s2[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        private static void P21()
        {
            Console.WriteLine("Dati str1: ");
           string str1= Console.ReadLine();
            Console.WriteLine("Dati str2: ");
            string str2= Console.ReadLine();
            int rez = string.Compare(str1, str2);
            if (rez < 0)
            {
                Console.WriteLine($"{str1} apare primul in ordine lexicografica.");
            }
            else if (rez > 0)
            {
                Console.WriteLine($"{str2} apare primul in ordine lexicografica.");
            }
            else
            {
                Console.WriteLine("Cele doua siruri sunt identice lexicografic.");
            }
        }
        private static void P22()
        {
            int n, m, i, j;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati m: ");
            m = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            int[] v2 = new int[m];
            Console.WriteLine("Dati elem vect v1: ");
            for (i = 0; i < v1.Length; i++)
                v1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elem vect v2: ");
            for (i = 0; i < v2.Length; i++)
                v2[i] = int.Parse(Console.ReadLine());
            HashSet<int> reuniune = new HashSet<int>(v1.Union(v2));
            Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));
            HashSet<int> intersectie = new HashSet<int>(v1.Intersect(v2));
            Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));
            HashSet<int> diferentaV1V2 = new HashSet<int>(v1.Except(v2));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1V2));
            HashSet<int> diferentaV2V1 = new HashSet<int>(v2.Except(v1));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2V1));
        }
        private static void P23() 
        {
            int n, m, i, j;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati m: ");
            m = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            int[] v2 = new int[m];
            Console.WriteLine("Dati elem vect v1: ");
            for (i = 0; i < v1.Length; i++)
                v1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elem vect v2: ");
            for (i = 0; i < v2.Length; i++)
                v2[i] = int.Parse(Console.ReadLine());
            i = 0;
            j = 0;
            //int k = 0;
            Console.WriteLine("Reuniunea: ");
            while(i<n  && j<m)
            {
                if (v1[i] != v2[j])
                    if (v1[i] < v2[j])
                    {
                        Console.Write($"{v1[i]} ");
                        i++;
                    }
                    else
                    {
                        Console.Write($"{v2[j]} ");
                        j++;
                    }
                else
                {
                    Console.Write($"{v1[i]} ");
                    i ++;
                    j++;
                }
            }
            while(i<n)
            {
                Console.Write($"{v1[i]} ");
                i++;
            }
            while(j<m)
            {
                Console.Write($"{v2[j]} ");
                j++;
            }
            Console.WriteLine();
            Console.WriteLine("Intersectia: ");
            i = 0;
            j = 0;
            while (i < n && j < m)
            {
                if (v1[i] == v2[j])
                {
                    Console.Write($"{v1[i]} ");
                    i++;
                    j++;
                }
                else
                    if (v1[i] < v2[j])
                         i++;
                    else
                         j++;
            }
            Console.WriteLine() ;
            Console.WriteLine("Dif v1-v2: ");
            for(i=0; i<v1.Length; i++)
            {
                int aux = v1[i];
                int ok = 1;
                for (j = 0; j < v2.Length; j++)
                    if (aux == v2[j])
                        ok = 0;
                if (ok == 1)
                    Console.Write($"{v1[i]} ");

            }
            Console.WriteLine();
            Console.WriteLine("Dif v2-v1: ");
            for (j = 0; j < v2.Length; j++)
            {
                int aux = v2[j];
                int ok = 1;
                for (i = 0; i < v1.Length; i++)
                    if (aux == v1[i])
                        ok = 0;
                if (ok == 1)
                    Console.Write($"{v2[j]} ");

            }
        }
        
        private static void P25()
        {
            int n, i, m, k, j; 
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            Console.WriteLine("Dati elem primului vector: ");
            for (i = 0; i < n; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dati m: ");
            m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            Console.WriteLine("Dati elem celui de-al doilea vector: ");
            for (i = 0; i < m; i++)
            {
                v2[i] = int.Parse(Console.ReadLine());
            }
            int[] v3= new int[n+m];
            i = 0;
            j = 0;
            k = 0;
            while( i <n && j<m)
            {
                if (v1[i] <= v2[j])
                {
                    v3[k] = v1[i];
                    i++;
                }
                else
                {
                    v3[k] = v2[j];
                    j++;
                }
                k++;
            }
            while(i<n)
            {
                
                v3[k] = v1[i];
                i++;
                k++;
            }
            while(j<m)
            {
                
                v3[k] = v2[j];
                j++;
                k++;
            }
                 
            for(i=0;i<n+m;i++)
            {
                Console.Write(v3[i]+" ");
            }

        }
        
        private static void P27()
        {
            int n, i, k;
            bool sortat;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dati indexul: ");
            k=int.Parse(Console.ReadLine());
            do
            {
                sortat = true;
                for (i = 0; i < v.Length - 1; i++)
                    if (v[i] > v[i + 1])
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        sortat = false;
                    }
            } while(!sortat);
            for(i = 0; i < v.Length;i++)
            {
                if(i==k)
                {
                    Console.WriteLine(v[i]);
                    break;
                }
            }
        }
        private static void P28()
        {
            int n, i;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Quicksort(a, 0, a.Length - 1);
            Console.WriteLine("Vect sortat: ");
            for(i=0; i < a.Length; i++)
            { Console.Write($"{a[i]} "); }
        }
        private static void Quicksort(int[] v, int st, int dr)
        {
            if (st < dr)
            {
                int pivotIndex = Partitie(v, st, dr);

                Quicksort(v, st, pivotIndex - 1);
                Quicksort(v, pivotIndex + 1, dr);
            }
        }
        static int Partitie(int[] v, int st, int dr)
        {
            int pivot = v[dr];
            int i = st - 1;

            for (int j = st; j < dr; j++)
            {
                if (v[j] < pivot)
                {
                    i++;
                    Schimba(v, i, j);
                }
            }

            Schimba(v, i + 1, dr);
            return i + 1;
        }
        static void Schimba(int[] v, int i, int j)
        {
            int aux = v[i];
            v[i] = v[j];
            v[j] = aux;
        }
        private static void P29()
        {
            int n, i;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            MergeSort(a, 0, a.Length - 1);
            Console.WriteLine("Vect sortat: ");
            for (i = 0; i < a.Length; i++)
            { Console.Write($"{a[i]} "); }
        }
        static void MergeSort(int[] v, int st, int dr)
        {
            if (st < dr)
            {
                int mijloc = (st + dr) / 2;

                MergeSort(v, st, mijloc);
                MergeSort(v, mijloc + 1, dr);

                Interclasare(v, st, mijloc, dr);
            }
        }
        static void Interclasare(int[] v, int st, int mijloc, int dr)
        {
            int n1 = mijloc - st + 1;
            int n2 = dr - mijloc;

            int[] vectorStanga = new int[n1];
            int[] vectorDreapta = new int[n2];

            Array.Copy(v, st, vectorStanga, 0, n1);
            Array.Copy(v, mijloc + 1, vectorDreapta, 0, n2);

            int i = 0, j = 0, k = st;

            while (i < n1 && j < n2)
            {
                if (vectorStanga[i] <= vectorDreapta[j])
                {
                    v[k] = vectorStanga[i];
                    i++;
                }
                else
                {
                    v[k] = vectorDreapta[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                v[k] = vectorStanga[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                v[k] = vectorDreapta[j];
                j++;
                k++;
            }
        }
        private static void P31()
        {
            int n, i,ok=0;
            Console.WriteLine("Dati n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Dati elem vectorului: ");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int m=0;
            for(i=0; i < a.Length; i++)
            {
                if (ok == 0)
                {
                    m = a[i];
                    ok = 1;
                }
                else
                   if (a[i] == m)
                       ok++;
                   else
                       ok--;
            }
            ok = 0;
            for(i=0; i < a.Length; i++) 
            {
                if (a[i] == m)
                    ok++;
            }
            if (ok > n / 2)
                Console.WriteLine($"Elem majoritate al vect este: {m}");
            else
                Console.WriteLine("Nu exista elem majoritate");
        }
    }
    
}
