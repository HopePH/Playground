package com.example.toastapp;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

 import com.example.toastlibrary.DisplayToast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void btnShowToast(View view)
    {
        DisplayToast displayToast = new DisplayToast(this);
        displayToast.showToast();
    }
}
