package com.example.arithmetic;
import org.junit.Test;
import static org.junit.Assert.*;

public class ExampleUnitTest {
    @Test
    public void addition_isCorrect() {
        Arithmetic arithmetic = new Arithmetic();
        arithmetic.SetNumber1(3);
        arithmetic.SetNumber2(5);
        int result = arithmetic.Add();
        assertEquals(8,result);
    }

    @Test
    public void multi_isCorrect() {
        Multiply multi = new Multiply();
        multi.SetNumber1(3);
        multi.SetNumber2(5);
        int result = ((Multiply) multi).Multiply();
        assertEquals(15,result);
    }

    @Test
    public void div_isCorrect(){
        Divide div = new Divide();
        div.SetNumber1(2);
        div.SetNumber2(2);
        int result = ((Divide) div).Divide();
        assertEquals(1,result);
    }

    @Test
    public void subtract_isCorrect(){
        Subtract subtract = new Subtract();
        subtract.SetNumber1(5);
        subtract.SetNumber2(3);
        int result = subtract.Subtract();
        assertEquals(2,result);
    }
}