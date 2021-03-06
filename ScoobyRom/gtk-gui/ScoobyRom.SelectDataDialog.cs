
// This file has been generated by the GUI designer. Do not modify.
namespace ScoobyRom
{
	public partial class SelectDataDialog
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.Label label2DAnnotated;
		
		private global::Gtk.Label label2DCountTotal;
		
		private global::Gtk.Label label2DSelected;
		
		private global::Gtk.Label label3DAnnotated;
		
		private global::Gtk.Label label3DCountTotal;
		
		private global::Gtk.Label label3DSelected;
		
		private global::Gtk.Label labelCol2D;
		
		private global::Gtk.Label labelCol3D;
		
		private global::Gtk.RadioButton radiobuttonAll;
		
		private global::Gtk.RadioButton radiobuttonAnnotated;
		
		private global::Gtk.RadioButton radiobuttonSelected;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ScoobyRom.SelectDataDialog
			this.Name = "ScoobyRom.SelectDataDialog";
			this.Title = "Select what data to export";
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(2));
			this.Modal = true;
			this.Resizable = false;
			this.AllowShrink = true;
			// Internal child ScoobyRom.SelectDataDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label2DAnnotated = new global::Gtk.Label ();
			this.label2DAnnotated.Name = "label2DAnnotated";
			this.label2DAnnotated.LabelProp = "-";
			this.table1.Add (this.label2DAnnotated);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2DAnnotated]));
			w2.TopAttach = ((uint)(3));
			w2.BottomAttach = ((uint)(4));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2DCountTotal = new global::Gtk.Label ();
			this.label2DCountTotal.Name = "label2DCountTotal";
			this.label2DCountTotal.LabelProp = "-";
			this.table1.Add (this.label2DCountTotal);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2DCountTotal]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2DSelected = new global::Gtk.Label ();
			this.label2DSelected.Name = "label2DSelected";
			this.label2DSelected.LabelProp = "-";
			this.table1.Add (this.label2DSelected);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2DSelected]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3DAnnotated = new global::Gtk.Label ();
			this.label3DAnnotated.Name = "label3DAnnotated";
			this.label3DAnnotated.LabelProp = "-";
			this.table1.Add (this.label3DAnnotated);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3DAnnotated]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3DCountTotal = new global::Gtk.Label ();
			this.label3DCountTotal.Name = "label3DCountTotal";
			this.label3DCountTotal.LabelProp = "-";
			this.table1.Add (this.label3DCountTotal);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3DCountTotal]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(2));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3DSelected = new global::Gtk.Label ();
			this.label3DSelected.Name = "label3DSelected";
			this.label3DSelected.LabelProp = "-";
			this.table1.Add (this.label3DSelected);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3DSelected]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(2));
			w7.RightAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCol2D = new global::Gtk.Label ();
			this.labelCol2D.Name = "labelCol2D";
			this.labelCol2D.LabelProp = "2D Tables";
			this.table1.Add (this.labelCol2D);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelCol2D]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCol3D = new global::Gtk.Label ();
			this.labelCol3D.Name = "labelCol3D";
			this.labelCol3D.LabelProp = "3D Tables";
			this.table1.Add (this.labelCol3D);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelCol3D]));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonAll = new global::Gtk.RadioButton ("_All");
			this.radiobuttonAll.CanFocus = true;
			this.radiobuttonAll.Name = "radiobuttonAll";
			this.radiobuttonAll.Active = true;
			this.radiobuttonAll.DrawIndicator = true;
			this.radiobuttonAll.UseUnderline = true;
			this.radiobuttonAll.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.table1.Add (this.radiobuttonAll);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.radiobuttonAll]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonAnnotated = new global::Gtk.RadioButton ("A_nnotated");
			this.radiobuttonAnnotated.CanFocus = true;
			this.radiobuttonAnnotated.Name = "radiobuttonAnnotated";
			this.radiobuttonAnnotated.DrawIndicator = true;
			this.radiobuttonAnnotated.UseUnderline = true;
			this.radiobuttonAnnotated.Group = this.radiobuttonAll.Group;
			this.table1.Add (this.radiobuttonAnnotated);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.radiobuttonAnnotated]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobuttonSelected = new global::Gtk.RadioButton ("_Selected");
			this.radiobuttonSelected.CanFocus = true;
			this.radiobuttonSelected.Name = "radiobuttonSelected";
			this.radiobuttonSelected.DrawIndicator = true;
			this.radiobuttonSelected.UseUnderline = true;
			this.radiobuttonSelected.Group = this.radiobuttonAll.Group;
			this.table1.Add (this.radiobuttonSelected);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.radiobuttonSelected]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(w1 [this.table1]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Internal child ScoobyRom.SelectDataDialog.ActionArea
			global::Gtk.HButtonBox w14 = this.ActionArea;
			w14.Name = "dialog1_ActionArea";
			w14.Spacing = 10;
			w14.BorderWidth = ((uint)(5));
			w14.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14 [this.buttonCancel]));
			w15.Expand = false;
			w15.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14 [this.buttonOk]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 292;
			this.DefaultHeight = 206;
			this.Show ();
		}
	}
}
