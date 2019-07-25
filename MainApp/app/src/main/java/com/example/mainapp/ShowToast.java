package com.example.mainapp;
import android.content.Context;
import android.widget.Toast;

public class ShowToast {
    private Context _context;

    public ShowToast(Context context){
        _context = context;
    }

    public void showMessage()    {
        Toast.makeText(_context,"Hello World!",Toast.LENGTH_SHORT).show();
    }

}
