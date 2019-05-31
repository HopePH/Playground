package com.example.messageviewer;

import android.content.Context;
import org.junit.Test;
        import static org.junit.Assert.*;


public class ExampleUnitTest {

    @Test
    public void testNullContext(){
        try {
            Message message = new Message(null);
        }
        catch (Exception e){
            assertEquals("context == null", e.getMessage());
        }
    }
}