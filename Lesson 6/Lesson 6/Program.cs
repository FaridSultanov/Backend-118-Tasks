using System.Linq.Expressions;
using System.Xml;

int x = 100;
int y = x;
console.writeline(x);
console.writeline(y);
x = 200;
console.writeline(x);
console.writeline(y);

// x ve y stack yaddasda yerlesdiyinden yalniz deyer saxlayirlar. Ona gore de x deyisdikde
// y deyismir.

int[] arr = { 1, 2, 3, 4 };
int[] mas = arr;
Console.WriteLine(arr[0]);
Console.WriteLine(mas[0]);

arr[0] = 100;
Console.WriteLine(arr[0]);
Console.WriteLine(mas[0]);

// array-ler  reference type oldugundan onlafr heap yaddasda yerlesir. Buna gore de 
// onlar deyer yox adres saxlayirlar. Yeni arr[0]-in qiymeti deyisdikde eslinde hemin
// yaddas sahesine baxan mas[0]-in da qiymeti deyisecek.




// Upcasting

byte a = 100;
int b = a;
Console.WriteLine(a);
Console.WriteLine(b);

// Bu process , yeni kicik tutumlu deyisenin boyuk tutumlu deyisene menimsedilmesi 
// Upcasting adlanir.


// Downcasting
int v1 = 1000;
byte v2 = (byte)v1;
Console.WriteLine(v1);
Console.WriteLine(v2);


// Boyuk tutumlu deyisenin kicik tutumlu deyisene meniimsedilesi Downcasting adlanir.
// Qeyd edek ki yuxaridaki kodda v2 1000 olaraq yox 1000-256-256-256=232 olaraq 
// ekrana cixacaq. Yeni oz maksimum serhedini asmayaraq.





// Method overloading

// Methodlar bir-birlerinden asagidaki 3 xusiyyetden birine gore mutleq ferqlenmelidirler

//1. Method's name
//2. Method's parametrs type
//3. Method's parametrs count

static int M1(int a,int b)
{
    return a + b;
}


static int M2(int a,Int32 b)
{
    return a * b;

}

static int M5(double a,int b)
{
    return (int)(a * b);
}