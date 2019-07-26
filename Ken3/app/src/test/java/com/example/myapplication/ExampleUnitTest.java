package com.example.myapplication;

import android.content.Context;

import org.junit.Test;
import org.mockito.Mock;
import static org.junit.Assert.*;

/**
 * Example local unit test, which will execute on the development machine (host).
 *
 * @see <a href="http://d.android.com/tools/testing">Testing documentation</a>
 */
public class ExampleUnitTest {

    @Mock
    Context mockContext;

    @Test
    public void test()
    {
        DisplayToast displayToast = new DisplayToast(mockContext);
        displayToast.showToast();

        assertEquals("Success!", displayToast.getMessage());
    }
}