using System;
using Gtk;
using BingoPiquero;
using System.Reflection.Emit;

public partial class MainWindow : Gtk.Window
{
    Bombo bombo = new Bombo();
    panelbingo panelbingo;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        panelbingo = new panelbingo(vbox1);
      /*  panelbingo panelbingo = new panelbingo(vbox1);*/
       /* Bombo bombo = new Bombo();
        bJugar.Clicked += delegate {

            int numero = bombo.sacarBola();
            };
            */
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBJugarClicked(object sender, EventArgs e)
    {
        int numero = bombo.SacarBola();
        panelbingo.Marcar(numero);
        
    }
}
