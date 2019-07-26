package com.example.myapplication;
import android.content.Context;
import android.widget.Toast;
import androidx.annotation.NonNull;

public class DisplayToast
{
    private Context _context;
    private String _message;

    public DisplayToast(@NonNull Context context)
    {
        this._context = context;
    }

    public void showToast()
    {
        if (this._context != null) {
            Toast.makeText(_context, "Hello World!", Toast.LENGTH_SHORT).show();
        }

        this._message = "Success!";
    }

    public String getMessage()
    {
        return this._message;
    }
}
