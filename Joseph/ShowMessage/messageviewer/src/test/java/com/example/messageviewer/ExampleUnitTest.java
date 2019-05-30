package com.example.messageviewer;

import android.content.Context;
import org.junit.Test;
import static org.junit.Assert.*;


public class ExampleUnitTest {

    Context mockContext;

    @Test
    public void testShowToast(){
        Message message = new Message(mockContext);
        message.ShowMessage(true);
        assertEquals("Something wrong, Try again!", message.getMessage());
    }

}