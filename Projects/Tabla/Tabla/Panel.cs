using System;
using Gtk;

namespace Tabla
{
    public class Panel
    {

        public Panel (VBox vBox1) 
        {
            Table table = new Table(3, 3, true);
            int index = 0;
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 3; column++)
                {
                    index++;
                    Button button = new Button();
                    table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                    //button.Label = "Button ";
                    button.Label = "Button " + index.ToString();
                    button.Clicked += delegate {

                        button.ModifyBg(StateType.Normal, new Gdk.Color(100, 200, 250));
                    };
                }
            vBox1.Add(table);
            table.ShowAll();
        }
    }

}