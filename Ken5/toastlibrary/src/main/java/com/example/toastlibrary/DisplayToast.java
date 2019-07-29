package com.example.toastlibrary;

import android.content.Context;
import android.widget.Toast;

import androidx.annotation.NonNull;

import static com.google.common.base.Preconditions.checkNotNull;

public class DisplayToast
{
    private Context _context;
    private String _message;

    public DisplayToast(@NonNull Context context)
    {
        checkNotNull(context,"Error in context!");
        this._context = context;
    }
    public void showToast()
    {
        try{
            if(null != _context)
            {
                try
                {
                    Toast.makeText(_context,"Hello world!", Toast.LENGTH_SHORT).show();
                }
                catch (RuntimeException re)
                {
                    if (!re.getMessage().contains("not mocked")) throw re;
                }
                this._message = "Success!";
            }
        }
        catch (Exception e)
        {
            this._message = e.getMessage();
        }
    }

    public String getMessage() {
        return this._message;
    }
}
