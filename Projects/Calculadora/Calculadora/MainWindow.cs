using System;
using Gtk;
using Gdk;

public partial class MainWindow : Gtk.Window
{
    int contador;
    float display1;
    float display2;
    float v;
    int opcion;
    int igual = 0;
    Operaciones operaciones = new Operaciones();
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
     
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBotonvaciarClicked(object sender, EventArgs e)
    {
        pantalla.DeleteText(0, pantalla.Text.Length);
        contador = 0;
        igual = 0;

    }

    protected void OnBotonborraClicked(object sender, EventArgs e)
    {
        pantalla.DeleteText(pantalla.Text.Length - 1, pantalla.Text.Length);
        String display = pantalla.Text.ToString();
        if (!display.Contains(","))
        {
            contador = 0;
        }
    }

    protected void OnBoton7Clicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + "7");
        }
    }

    protected void OnBoton8Clicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + "8");
        }
    }

    protected void OnBoton9Clicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + "9");
        }
    }

    protected void OnBotondivClicked(object sender, EventArgs e)
    {
        contador = 0;
        display1 = Convert.ToSingle(pantalla.Text);
        pantalla.DeleteText(0, pantalla.Text.Length);
        opcion = 4;
    }

    protected void OnBoton4Clicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + "4");
        }
    }

    protected void OnBoton5Clicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + "5");
        }
    }

    protected void OnBoton6Clicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + "6");
        }
    }

    protected void OnBotonmultClicked(object sender, EventArgs e)
    {
        contador = 0;
        display1 = Convert.ToSingle(pantalla.Text);
        pantalla.DeleteText(0, pantalla.Text.Length);
        opcion = 3;
    }

    protected void OnBoton1Clicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + "1");
        }
    }

    protected void OnBoton2Clicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + "2");
        }
    }

    protected void OnBoton3Clicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            String display = pantalla.Text.ToString();
            pantalla.DeleteText(0, pantalla.Text.Length);
            pantalla.InsertText(display + "3");
        }
    }

    protected void OnBotonmenosClicked(object sender, EventArgs e)
    {
        contador = 0;
        display1 = Convert.ToSingle(pantalla.Text);
        pantalla.DeleteText(0, pantalla.Text.Length);
        opcion = 2;
    }

    protected void OnBotonClicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0,pantalla.Text.Length);
        pantalla.InsertText(display+"0");

    }

    protected void OnBotoncomaClicked(object sender, EventArgs e)
    {
        if (contador == 0)
        {
            String display = pantalla.Text.ToString();
            if (display.Equals(""))
            {
                pantalla.DeleteText(0, pantalla.Text.Length);
                pantalla.InsertText("0,");
                contador++;
            }
            else
            {
                pantalla.DeleteText(0, pantalla.Text.Length);
                pantalla.InsertText(display + ",");
                contador++;
            }

        }

    }

    protected void OnBotonsumaClicked(object sender, EventArgs e)
    {
        contador = 0;
        display1 = Convert.ToSingle(pantalla.Text);
        pantalla.DeleteText(0, pantalla.Text.Length);
        opcion = 1;
    }

    protected void OnBotonigualClicked(object sender, EventArgs e)
    {
        if (igual == 0)
        {
            display2 = Convert.ToSingle(pantalla.Text);
            pantalla.DeleteText(0, pantalla.Text.Length);
            igual++;

            switch (opcion)
            {
                case 1:
                    v = operaciones.suma(display1, display2);
                    pantalla.InsertText(Convert.ToString(v));
                    break;

                case 2:
                    v = operaciones.resta(display1, display2);
                    pantalla.InsertText(Convert.ToString(v));
                    break;

                case 3:
                    v = operaciones.multi(display1, display2);
                    pantalla.InsertText(Convert.ToString(v));
                    break;

                case 4:
                    v = operaciones.divi(display1, display2);
                    pantalla.InsertText(Convert.ToString(v));
                    break;

            }
        }

    }
}
