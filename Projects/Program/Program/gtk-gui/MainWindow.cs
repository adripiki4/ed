
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.Label label2;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Entry texto1;

	private global::Gtk.Button Saludar;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Entry entry2;

	private global::Gtk.Button Aleatorio;

	private global::Gtk.Button BSalir;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Mi primer programa");
		this.vbox1.Add(this.label2);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label2]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.texto1 = new global::Gtk.Entry();
		this.texto1.CanFocus = true;
		this.texto1.Name = "texto1";
		this.texto1.IsEditable = true;
		this.texto1.InvisibleChar = '•';
		this.hbox3.Add(this.texto1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.texto1]));
		w2.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.Saludar = new global::Gtk.Button();
		this.Saludar.CanFocus = true;
		this.Saludar.Name = "Saludar";
		this.Saludar.UseUnderline = true;
		this.Saludar.Label = global::Mono.Unix.Catalog.GetString("Saludar");
		this.hbox3.Add(this.Saludar);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.Saludar]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox1.Add(this.hbox3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = false;
		this.entry2.InvisibleChar = '•';
		this.hbox1.Add(this.entry2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entry2]));
		w5.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.Aleatorio = new global::Gtk.Button();
		this.Aleatorio.CanFocus = true;
		this.Aleatorio.Name = "Aleatorio";
		this.Aleatorio.UseUnderline = true;
		this.Aleatorio.Label = global::Mono.Unix.Catalog.GetString("Aleatorio");
		this.hbox1.Add(this.Aleatorio);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Aleatorio]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.BSalir = new global::Gtk.Button();
		this.BSalir.CanFocus = true;
		this.BSalir.Name = "BSalir";
		this.BSalir.UseUnderline = true;
		this.BSalir.Label = global::Mono.Unix.Catalog.GetString("Salir");
		this.hbox1.Add(this.BSalir);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.BSalir]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 514;
		this.DefaultHeight = 335;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.Saludar.Clicked += new global::System.EventHandler(this.OnSaludarClicked);
		this.Aleatorio.Clicked += new global::System.EventHandler(this.OnAleatorioClicked);
		this.BSalir.Clicked += new global::System.EventHandler(this.OnBSalirClicked);
	}
}