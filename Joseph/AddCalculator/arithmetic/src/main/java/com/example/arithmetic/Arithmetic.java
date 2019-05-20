package com.example.arithmetic;

public class Arithmetic {

    public int _number1;

    public Arithmetic(){
    }

    public void SetNumber1( int number) {
        _number1 = number;
    }

    public int GetNumber1(){
        return _number1;
    }

    public int _number2;

    public void SetNumber2(int number) {
        _number2 = number;
    }

    public int GetNumber2() {
        return _number2;
    }

   public int Add(){
        int result = _number1 + _number2;
        return result;
   }
}


