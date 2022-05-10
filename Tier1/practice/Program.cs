using System;
using System.Collections.Generic;
namespace ForgetCode{
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Add a list item.");
    String input = Console.ReadLine();
    List<String> userList = new List<String>();
    userList.Add(input);
    Console.WriteLine("Add another value:");
    String inputNewUser = Console.ReadLine();
    userList.Add(inputNewUser);
    Console.WriteLine();
    Console.WriteLine("These are the values in your list:");
    foreach(var user in userList){
      Console.WriteLine(user);
    }
   
  }
}
}
