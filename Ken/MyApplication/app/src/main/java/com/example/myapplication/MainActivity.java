package com.example.myapplication;

import android.os.Bundle;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;

import com.example.messageview.ViewMessage;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void displayToast(View view)
    {
        try {
            ViewMessage viewMessage = new ViewMessage(this);
            viewMessage.MessageView(true);
        } catch (Exception e){
            System.out.println("Try again!");
        }

    }
}
