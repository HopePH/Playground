package com.example.messageview;

import android.content.Context;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.runners.MockitoJUnitRunner;
import static org.junit.Assert.assertEquals;

@RunWith(MockitoJUnitRunner.class)
public class ExampleUnitTest {
    @Mock
    Context mockContext;

    @Test
    public void testShowToast() {
        ViewMessage viewMessage = new ViewMessage(mockContext);
        viewMessage.MessageView(true);
        assertEquals("Message success!",viewMessage.getMessage());
    }
}