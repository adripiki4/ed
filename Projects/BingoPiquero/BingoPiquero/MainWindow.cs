﻿using System;
using Gtk;
using BingoPiquero;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        panelbingo panelbingo = new panelbingo(vbox1);
        Bombo bombo = new Bombo();

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
