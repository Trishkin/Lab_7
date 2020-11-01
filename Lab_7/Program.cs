using System;
using Lab_7.Controllers;
using Lab_7.Exceptions;
using Laba_7.Controllers;
using System.Diagnostics;

namespace Laba_7
{
  
    public interface IPerson
    {
        bool Person();

    }
  
  
    partial class Class1
    { 
    public void ICanRun()
        { 
            Console.WriteLine($"I Run");
        }
    }

     

    class Program
    {
        public static void TestLibraryIsEmptyException()
        {
            try
            {
                LibraryController library = new LibraryController();
                //  library.FillLibrary();
                library.PrintLibrary();
                //    library.PrintPriceOfBooks();
                // library.CountOfTextBooks();
            }
            catch (LibraryIsEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"I'm all");
            }
        }
        public static void TestPriceException()
        {
            Library library1 = new Library();

            try
            {
                library1.listOfBooks.Add(new Textbook() { Price = -4 });
            }

            catch (PriceShouldBePositiveException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"I'm all");
            }
        }

        static void Main(string[] args)
        {
            //TestLibraryIsEmptyException();
            //TestPriceException();
            //TestNoNameOfBookException();
            //ZeroDivideException();
            IndexException();
            int[] aa = null; Debug.Assert(aa != null, "Values array cannot be null");
        }
    }
}

