package com.example.messageview;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

import com.example.message.ViewMessage;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void thankMessage(View view) {
        try {
            ViewMessage viewMessage = new ViewMessage(this);
            viewMessage.MessageView(true);
        } catch (Exception e){
            System.out.println("Try again!");
        }
    }
}
