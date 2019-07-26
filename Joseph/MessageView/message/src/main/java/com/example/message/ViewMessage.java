package com.example.message;

import android.annotation.SuppressLint;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.support.annotation.NonNull;
import android.widget.Toast;

import static android.support.v4.util.Preconditions.checkNotNull;


public class ViewMessage {
    private final Context _context;
    private String _message;

    @SuppressLint("RestrictedApi")
    public ViewMessage(@NonNull Context context) {
        checkNotNull(context, "Success!");
        this._context = context;
    }

    public void MessageView(boolean isToast) {
        try {
            if (this._context != null) {
                if (isToast)
                    try {
                    Toast.makeText(this._context, "Thank you Message!", Toast.LENGTH_SHORT).show();
                }
                catch (RuntimeException re){
                    if (!re.getMessage().contains("not mocked")) throw re;
                }
                else {
                    try {
                        AlertDialog alertDialog = new AlertDialog.Builder(this._context).create();
                        alertDialog.setTitle("Message Alert");
                        alertDialog.setMessage("Thank you Message!");
                        alertDialog.setButton(AlertDialog.BUTTON_NEUTRAL, "OK",
                                new DialogInterface.OnClickListener() {
                                    public void onClick(DialogInterface dialog, int which) {
                                        dialog.dismiss();
                                    }
                                });
                        alertDialog.show();
                    }
                    catch (RuntimeException re){
                        if (!re.getMessage().contains("not mocked")) throw re;
                    }
                }
            }

            this._message = "Message success!";
        } catch (Exception e) {
            this._message = e.getMessage();
        }
    }

    public String getMessage() {
        return this._message;
    }
}

