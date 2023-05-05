using LINQtoObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Reflection;
using System.Text;

internal static class SampleDataHelpers
{

    static public Author[] Authors =
    {
      new Author {FirstName="Johnny", LastName="Good"},
      new Author {FirstName="Graziella", LastName="Simplegame"},
      new Author {FirstName="Octavio", LastName="Prince"},
      new Author {FirstName="Jeremy", LastName="Legrand"}
    };

    //public static SampleData GetBooks(Book b)
    //{
    //    //return new ArrayList(Books);
    //    return new SampleData { Title = b.Title, Price = b.Price };
    //}

    // static public Data GetBooks(Book b)
    //{
    //        //return new ArrayList(Books);
    //        return new Data { Title = b.Title, Price = b.Price };
    //}
}