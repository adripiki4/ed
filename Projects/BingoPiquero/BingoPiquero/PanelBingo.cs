using System;
using Gtk;

namespace BingoPiquero
{
    public class panelbingo
    {

        public panelbingo(VBox vBox1)
        {
            Table table = new Table(10, 9, true);
            int index = 0;
            for (int row = 0; row < 10; row++)
                for (int column = 0; column < 9; column++)
                {
                    index++;
                    Button button = new Button();
                    table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                    //button.Label = "Button ";
                    button.Label = index.ToString();
                    button.Clicked += delegate {

                        button.ModifyBg(StateType.Normal, new Gdk.Color(100, 200, 250));
                    };
                }
            vBox1.Add(table);
            table.ShowAll();
        }
    }

}