package com.example.toast;


import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

import com.example.toastlibrary2.DisplayToast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void btnToast(View view)
    {
        DisplayToast displayToast = new DisplayToast(this);
        displayToast.showToast(true);
    }
}
