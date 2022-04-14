using System;
using System.Linq;

class StringToFloat {
  static void Main(string[] args) {
    string[] myArray = {
      "a",
      "b",
      "c",
      "d",
      "e"
    };
    Console.WriteLine("Array before deletion");
    foreach(string value in myArray) {
      Console.WriteLine(value);
    }
    int indexToRemove = 3;
    myArray = myArray.Where((source, index) =>index != indexToRemove).ToArray();
    Console.WriteLine("Array after deletion");

    foreach(string value in myArray) {
      Console.WriteLine(value);
    }
  }
}
