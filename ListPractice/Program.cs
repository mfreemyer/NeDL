﻿using System;
using System.Collections.Generic;
namespace ForgetCode{
class MainClass {
  public static void Main (string[] args) {
    List<string> userList = new List<string>();
    Console.WriteLine("Add a list item.");
    string input = Console.ReadLine();
    userList.Add(input);
    Console.WriteLine("Add another value:");
    string inputNewUser = Console.ReadLine();
    userList.Add(inputNewUser);
    Console.WriteLine();
    Console.WriteLine("These are the values in your list:");
    foreach(var user in userList){
      Console.WriteLine(user);
    }
   
  }
}
}
