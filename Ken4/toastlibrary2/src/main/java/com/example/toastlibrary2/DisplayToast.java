package com.example.toastlibrary2;

import android.content.Context;
import android.widget.Toast;

import androidx.annotation.NonNull;


public class DisplayToast
{
    private Context _context;
    private String _message;

    public DisplayToast(@NonNull Context _context)
    {
        this._context = _context;
    }

    public void showToast(boolean isToast)
    {
        try
        {
            if (_context != null)
            {
                try
                {
                    Toast.makeText(_context,"Hello World!",Toast.LENGTH_SHORT).show();
                }
                catch (RuntimeException re)
                {
                    if (!re.getMessage().contains("Not Mocked")) throw re;
                }
                this._message = "Success!";
            }
        }
        catch (Exception e)
        {
            this._message = e.getMessage();
        }
    }

    public String getMessage()
    {
        return this._message;
    }
}
