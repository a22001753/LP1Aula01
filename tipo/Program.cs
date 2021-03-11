using System; // comando para fazer isto foi "dotnet new console -n tipo", dot net sln add tipo

namespace tipo
{
    class Program
    {
        static void Main(string[] args)
        {  Console.OutputEnconding.UTF8;
             // int types, sao usados na maioria das vezes embora, longs e assim sejam mais úteis
            int a = 5;
            uint b = 5u; //------------> valor literal, por "U" ou "u" no fim.
            long c = 5l; //------------>  unit cabe em long porque, long sustenta mais info
            byte d = 3; 

            Console.WriteLine(c);

            char copySym = 'u00A9'; // copyright symbol
            Console.WriteLine(copySym);


        }
    }
}


/* ou seja se fosse: 

int a = 5l; // o programa nao funcionária

copSym e um nome dado por min


PARA ADD SLN 

git commit -m "Add VariasStrings"

*/
