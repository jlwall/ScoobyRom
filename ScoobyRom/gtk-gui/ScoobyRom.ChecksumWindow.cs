
// This file has been generated by the GUI designer. Do not modify.
namespace ScoobyRom
{
	public partial class ChecksumWindow
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Frame frameChecksums;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeviewCSums;
		
		private global::Gtk.Label GtkLabelChecksumTable;
		
		private global::Gtk.Frame frameCVN;
		
		private global::Gtk.Alignment GtkAlignment1;
		
		private global::Gtk.Table tableCVN;
		
		private global::Gtk.Label labelCVN8;
		
		private global::Gtk.Label labelTitleCVN8;
		
		private global::Gtk.Label GtkLabel1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ScoobyRom.ChecksumWindow
			this.Name = "ScoobyRom.ChecksumWindow";
			this.Title = "Checksum Window";
			this.AllowShrink = true;
			this.DestroyWithParent = true;
			// Container child ScoobyRom.ChecksumWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frameChecksums = new global::Gtk.Frame ();
			this.frameChecksums.Name = "frameChecksums";
			this.frameChecksums.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameChecksums.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewCSums = new global::Gtk.TreeView ();
			this.treeviewCSums.CanFocus = true;
			this.treeviewCSums.Name = "treeviewCSums";
			this.GtkScrolledWindow.Add (this.treeviewCSums);
			this.GtkAlignment.Add (this.GtkScrolledWindow);
			this.frameChecksums.Add (this.GtkAlignment);
			this.GtkLabelChecksumTable = new global::Gtk.Label ();
			this.GtkLabelChecksumTable.Name = "GtkLabelChecksumTable";
			this.GtkLabelChecksumTable.LabelProp = "<b>Checksum Table</b>";
			this.GtkLabelChecksumTable.UseMarkup = true;
			this.frameChecksums.LabelWidget = this.GtkLabelChecksumTable;
			this.vbox2.Add (this.frameChecksums);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frameChecksums]));
			w4.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frameCVN = new global::Gtk.Frame ();
			this.frameCVN.Name = "frameCVN";
			this.frameCVN.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frameCVN.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.tableCVN = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.tableCVN.Name = "tableCVN";
			this.tableCVN.RowSpacing = ((uint)(6));
			this.tableCVN.ColumnSpacing = ((uint)(6));
			// Container child tableCVN.Gtk.Table+TableChild
			this.labelCVN8 = new global::Gtk.Label ();
			this.labelCVN8.Name = "labelCVN8";
			this.labelCVN8.Selectable = true;
			this.tableCVN.Add (this.labelCVN8);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.tableCVN [this.labelCVN8]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableCVN.Gtk.Table+TableChild
			this.labelTitleCVN8 = new global::Gtk.Label ();
			this.labelTitleCVN8.Name = "labelTitleCVN8";
			this.labelTitleCVN8.LabelProp = "CVN8 (diesel):";
			this.tableCVN.Add (this.labelTitleCVN8);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.tableCVN [this.labelTitleCVN8]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment1.Add (this.tableCVN);
			this.frameCVN.Add (this.GtkAlignment1);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = "<b>Calibration Verification Number (CVN)</b>";
			this.GtkLabel1.UseMarkup = true;
			this.frameCVN.LabelWidget = this.GtkLabel1;
			this.vbox2.Add (this.frameCVN);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frameCVN]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 394;
			this.DefaultHeight = 543;
			this.Show ();
		}
	}
}
