using System;
using System.Collections.Generic;
using Gtk;

namespace BingoPiquero
{
    public class panelbingo
    {
        private static uint rows = 9;
        private static uint columns = 10;
        private IList<Button> buttons = new List<Button>();
        public panelbingo(VBox vBox1)
        {
            Table table = new Table(10, 9, true);
            int index = 0;
            for (int row = 0; row < rows; row++)
                for (int column = 0; column < columns; column++)
                {
                    index++;
                    Button button = new Button();
                    table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                    //button.Label = "Button ";
                    buttons.Add(button);
                    button.Label = index.ToString();

                }
            vBox1.Add(table);
            table.ShowAll();
        }
        public void Marcar (int numero)
        {
            buttons[numero - 1].ModifyBg(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
    }

}