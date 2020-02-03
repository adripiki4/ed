using System;
using Gtk;
using BingoPiquero;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        panelbingo panelbingo = new panelbingo(vbox1);
        Bombo bombo = new Bombo();
        bJugar.Clicked += delegate {

            int numero = bombo.sacarBola();
            };

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

   
}
