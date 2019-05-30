package com.example.messageviewer;

import android.annotation.SuppressLint;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.support.annotation.NonNull;
import android.widget.Toast;

import static android.support.v4.util.Preconditions.checkNotNull;

public class Message {

    private final Context _context;
    private String _message;

    @SuppressLint("RestrictedApi")
    public Message(@NonNull Context context) {
        checkNotNull(context, "context == null");
        this._context = context;
    }

    public void ShowMessage(boolean isToast){
        try{
            if(this._context != null){
                if(isToast)
                    try {
                        Toast.makeText(this._context, "Thank you for choosing us!", Toast.LENGTH_SHORT).show();
                    }
                    catch (RuntimeException re){
                        if(!re.getMessage().contains("Something wrong, Try again!")) throw re;
                    }
                else{
                    try{
                        AlertDialog alertDialog = new AlertDialog.Builder(this._context).create();
                        alertDialog.setTitle("Alert");
                        alertDialog.setMessage("Thank you for choosing us!");
                        alertDialog.setButton(AlertDialog.BUTTON_NEUTRAL, "OK",
                                new DialogInterface.OnClickListener() {
                                    @Override
                                    public void onClick(DialogInterface dialog, int which) {
                                        dialog.dismiss();
                                    }
                                });
                        alertDialog.show();
                    }
                    catch (RuntimeException re){
                        if(!re.getMessage().contains("Something wrong, Try again!")) throw re;
                    }
                }
            }

            this._message = "Toast success!";
        } catch (Exception e){
            this._message = e.getMessage();
        }
    }

    public String getMessage() {return this._message;}
}
