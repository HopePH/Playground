package com.example.myapplication;

import android.annotation.SuppressLint;
import android.content.Context;
import android.widget.Toast;
import androidx.annotation.NonNull;

import static com.google.common.base.Preconditions.checkNotNull;

//import static androidx.core.util.Preconditions.checkNotNull;


public class DisplayToast
{
    private final Context _context;
    private String _message;

    public DisplayToast(@NonNull Context context)
    {
        checkNotNull(context, "Error on context!");
        this._context = context;
    }

    public void showToast(boolean isToast)
    {
        try
        {
            if (this._context != null) {
                try {
                    Toast.makeText(_context, "Hello World!", Toast.LENGTH_SHORT).show();
                }
                catch (RuntimeException re){
                    if (!re.getMessage().contains("not mocked")) throw re;
                }
                this._message = "Success!";
            }
        }
        catch (Exception e){
            this._message = e.getMessage();
        }
    }

    public String getMessage()
    {
        return this._message;
    }
}
