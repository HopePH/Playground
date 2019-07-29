package com.example.myapplication;

import android.content.Context;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.runners.MockitoJUnitRunner;
import static org.junit.Assert.*;

@RunWith(MockitoJUnitRunner.class)
public class ExampleUnitTest {

    @Mock
    Context mockContext;

    @Test
    public void test()
    {
        DisplayToast displayToast = new DisplayToast(mockContext);
        displayToast.showToast(true);
        assertEquals("Success!", displayToast.getMessage());
    }
}