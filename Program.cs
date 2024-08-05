using static ListGeneratorNameSpace.ListGenerator;
namespace Assignment_LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators

            #region Q1
            //var productsAreNotInStock = ProductsList.Where(p => p.UnitsInStock == 0);
            //Console.WriteLine("Prouct that are out of stock");
            //foreach (var product in productsAreNotInStock)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q2
            //var productCostMoreThan3 = ProductsList.Where(p => p.UnitPrice > 3 && p.UnitsInStock > 0);
            //Console.WriteLine("Product that are in Stock and cost more than 3 pounds");
            //foreach (var product in productCostMoreThan3)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shorterThanNames = Arr.Select((name, index) => new { Name = name, Value = index })
            //    .Where(d => d.Name.Length < d.Value);
            //Console.WriteLine("digits whose name is shorter than their value");
            //foreach (var product in shorterThanNames)
            //{
            //    Console.WriteLine(product.Name);
            //}
            #endregion

            #endregion


            #region Ordering Operators

            #region Q1
            //var SortedProductsByName = ProductsList.OrderBy(p => p.ProductName);
            //Console.WriteLine("sorted Products by name");
            //foreach (var product in SortedProductsByName)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedArrInsensitive = Arr.OrderBy(s => s, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine("Sorted Wpords in Array insensitive_case");
            //foreach (var product in SortedArrInsensitive)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q3
            //var SortedProductsByStock = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //Console.WriteLine("sorted Products by stock Descending");
            //foreach (var product in SortedProductsByStock)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var SortedDigitsByLenghtAndAlpha = Arr.OrderBy(s => s.Length).ThenBy(name => name);
            //Console.WriteLine("Sorted array by name length and then alphabetically:");
            //foreach (var arr in SortedDigitsByLenghtAndAlpha)
            //{
            //    Console.WriteLine(arr);
            //}
            #endregion

            #region Q5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedDigitsByLenghtAndInsensitive = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine("sorted words by length and insensitive case");
            //foreach (var word in SortedDigitsByLenghtAndInsensitive)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region Q6
            //var SortedProductsByCategoryAndUnitPrice = ProductsList.OrderBy(p => p.Category).ThenBy(p => p.UnitPrice);
            //Console.WriteLine("sorted products by category and unit price");
            //foreach (var product in SortedProductsByCategoryAndUnitPrice)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedWordsByLengthandInsensitive = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine("Sorted words by length and Insensitive case");
            //foreach (var word in SortedWordsByLengthandInsensitive)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region Q8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var ReversedListOfDigitsStartWithI = Arr.Where(w=> w.Length > 1 && w.ElementAt(1) == 'i' ).Reverse();
            //Console.WriteLine("Reversed list of the words that the second letter is 'i'");
            //foreach (var word in ReversedListOfDigitsStartWithI)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #endregion

        }
    }
}
