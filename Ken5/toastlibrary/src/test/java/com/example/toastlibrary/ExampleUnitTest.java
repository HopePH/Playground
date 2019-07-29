package com.example.toastlibrary;

import android.content.Context;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.runners.MockitoJUnitRunner;

import static org.junit.Assert.*;

/**
 * Example local unit test, which will execute on the development machine (host).
 *
 * @see <a href="http://d.android.com/tools/testing">Testing documentation</a>
 */

@RunWith(MockitoJUnitRunner.class)
public class ExampleUnitTest
{
    @Mock
    Context mockContext;

    @Test
    public void TestToast()
    {
        DisplayToast displayToast = new DisplayToast(mockContext);
        displayToast.showToast();
        assertEquals("Success!",displayToast.getMessage());
    }

}