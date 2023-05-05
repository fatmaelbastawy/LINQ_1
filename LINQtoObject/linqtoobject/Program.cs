using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Xml.Linq;

namespace LINQtoObject
{
    class Program
    {
        static void Main(string[] args)
        {

            #region problem_1

            //Display book title and its ISBN.// 

            //var Query =
            //    from b in SampleData.Books
            //    select new { title = b.Title, isbn = b.Isbn };
            //foreach (var item in Query)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region proplem_2

            //Display the first 3 books with price more than 25.//

            //var Query2 =
            //    from b in SampleData.Books.Take(4)
            //    where b.Price > 25
            //    select b.Title;
            //foreach (var item in Query2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



            #region problem_3  

            //Display Book title along with its publisher name. (Using 2 methods).// 
            //subquery//
            //var Query3 =
            //    from b in SampleData.Books
            //    select new
            //    {
            //        bname = b.Title,
            //        pubname =
            //        from p in SampleData.Publishers
            //        where p.Name == b.Publisher.Name
            //        select p.Name
            //    };

            //foreach (var item in Query3)
            //{
            //    Console.WriteLine("Book title : " + item.bname);
            //    foreach (var p in item.pubname)
            //    {
            //        Console.WriteLine("Publisher : " + p);
            //    }


            //var query33 = SampleData.Books.Select(B => new
            //{
            //    title = B.Title,
            //    nameOfpub =
            //      from p in SampleData.Publishers
            //      where p.Name == B.Publisher.Name
            //      select new { p_name = p.Name }
            //});



            //foreach (var item in query33)
            //{
            //    Console.WriteLine(item.title);
            //    Console.WriteLine("---------------------");

            //    foreach (var item2 in item.nameOfpub)
            //    {
            //        Console.WriteLine(item2.p_name);
            //        Console.WriteLine();
            //        Console.WriteLine();
            //    }
            //}
            #endregion


            #region problem_4

            //Find the number of books which cost more than 20.//


            //var Query4 =
            //(from b in SampleData.Books
            // where b.Price > 20
            // select b).Count();
            //Console.WriteLine(Query4);

            #endregion


            #region problem_5

            /*Display book title, price and subject name//  
            sorted by its subject name ascending and by its price descending.*/

            /*query expression*///
            //var Query5 =
            //    from b in SampleData.Books
            //    orderby b.Title, b.Price descending, b.Subject ascending
            //    select b;
            //foreach (var item in Query5)
            //{
            //    Console.WriteLine("Book title: " + item);
            //    Console.WriteLine("Book price: " + item.Price);
            //    Console.WriteLine("Book subject: " + item.Subject);
            //    Console.WriteLine("--------------------------");
            //}
            #endregion


            #region problem_6

            //Display All subjects with books related to this subject. (Using 2 methods).//
            //subQuery//
            //Query Expression//
            //var query6 =
            //    from s in SampleData.Subjects
            //    select new
            //    {
            //        subject = s,
            //        books =
            //       from b in SampleData.Books
            //       where s.Name == b.Subject.Name
            //       select b

            //    };

            //foreach (var item in query6)
            //{
            //    Console.WriteLine("Subject name: " + item.subject);
            //    Console.WriteLine("-------------------------");

            //    foreach (var b in item.books)
            //    {

            //        Console.WriteLine("Book title: " + b);
            //        Console.WriteLine();
            //        Console.WriteLine();
            //    }
            //}


            // //Query Operator//
            // var query66 = SampleData.Subjects.Select(s =>
            //new
            //{
            //    subject = s,
            //    books =
            //       from B in SampleData.Books
            //       where s.Name == B.Subject.Name
            //       select B
            //});

            // foreach (var item in query66)
            // {
            //     Console.WriteLine("Subject name: " + item.subject);

            //     foreach (var b in item.books)
            //     {
            //         Console.WriteLine("Book title: " + b);
            //     }
            // }
            #endregion


            #region problem_7

            /*Try to display book title & price(from book objects)
             returned from GetBooks Function.*/

            //var Query7 =
            //    from b in SampleData.GetBooks().Cast<Book>()
            //    select new { title = b.Title, price = b.Price };
            //foreach (var item in Query7)
            //{
            //    Console.WriteLine(item);
            //}

            ////IEnumerable<ArrayList> res = SampleData.Books.Choose.GetBooks();
            ////foreach (var item in res)
            ////{
            ////    Console.WriteLine(item.Title);
            ////    Console.WriteLine(item.Price);
            ////}


            #endregion



            #region problem_8

            //var Query8 = SampleData.Books.GroupBy(b => b.Publisher);
            ////from b in SampleData.Books

            ////group by b.Publishr
            ////select b;
            //foreach (var item in Query8)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            Console.ReadLine();

        }

        private static object GetBooks(object arg)
        {
            throw new NotImplementedException();
        }
    }
}   
