package com.example.helloworld;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

import com.example.messageviewer.Message;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void clickBtn(View view){
        try {
            Message message = new Message(this);
            message.ShowMessage(true);
        } catch (Exception e){
            System.out.println("Something wrong, Try again!");
        }
    }
}
