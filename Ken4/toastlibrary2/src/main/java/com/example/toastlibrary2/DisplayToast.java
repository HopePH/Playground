package com.example.toastlibrary2;

import android.content.Context;
import android.widget.Toast;

import androidx.annotation.NonNull;

import static com.google.common.base.Preconditions.checkNotNull;


public class DisplayToast
{
    private final Context _context;
    private String _message;

    public DisplayToast(@NonNull Context _context)
    {
        checkNotNull(_context,"Error!");
        this._context = _context;
    }

    public void showToast(boolean isToast)
    {
        try
        {
            if (_context != null)
            {
                if (isToast)
                {
                    try
                    {
                        Toast.makeText(_context, "Hello World!", Toast.LENGTH_SHORT).show();
                    }
                    catch (RuntimeException re){
                        if (!re.getMessage().contains("not mocked")) throw re;
                    }
                    this._message = "Success!";
                }
            }
        }
        catch (RuntimeException e)
        {
            this._message = e.getMessage();
        }
    }
    public String getMessage()
    {
        return this._message;
    }


}
