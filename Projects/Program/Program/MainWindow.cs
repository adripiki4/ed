using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private Random random = new Random();
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnSaludarClicked(object sender, EventArgs e)
    {
        MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Error, ButtonsType.YesNo, "HOLA "+texto1.Text);
        md.Run();
        md.Destroy();
    }

    protected void OnBSalirClicked(object sender, EventArgs e)
    {
        this.Destroy();
    }

    protected void OnAleatorioClicked(object sender, EventArgs e)
    {
        int indexAleatorio = random.Next(1, 10);
        MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Question, ButtonsType.Close, "Número Aleatorio: " + indexAleatorio);
        md.Run();
        md.Destroy();
    }
}
