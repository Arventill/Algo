package com.company;

class Exercise5 {

    static  void checkPalindrome(String word){

      char[] input = word.toCharArray();
      char[] swapedTable = new char[input.length];

      for(int i = 0; i < swapedTable.length; i++){
        swapedTable[i] = input[(input.length -1) - i];
      }
      String swapedString = new String(swapedTable);

      System.out.println("Input string: " + word + "\n" + "Swaped string: " + swapedString);

      if(word.equals(swapedString)){
        System.out.println("Given string is palindrome!");
      } else{
        System.out.println("Given string is not palindrome");
      }


  }

}
