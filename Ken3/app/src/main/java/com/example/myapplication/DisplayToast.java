package com.example.myapplication;

import android.content.Context;
import android.widget.Toast;

public class DisplayToast
{
    private Context _context;

    public DisplayToast(Context context)
    {
        _context = context;
    }
    public void showToast()
    {
        Toast.makeText(_context, "Hello World!", Toast.LENGTH_SHORT).show();
    }
}
