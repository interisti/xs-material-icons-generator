
// This file has been generated by the GUI designer. Do not modify.
namespace MaterialIconsGenerator
{
	public partial class MainDialog
	{
		private global::Gtk.Table container;
		
		private global::Gtk.CheckButton checkhdpi;
		
		private global::Gtk.CheckButton checkmdpi;
		
		private global::Gtk.CheckButton checkxhdpi;
		
		private global::Gtk.CheckButton checkxxhdpi;
		
		private global::Gtk.CheckButton checkxxxhdpi;
		
		private global::Gtk.ComboBox comboColor;
		
		private global::Gtk.ComboBox comboIcon;
		
		private global::Gtk.ComboBox comboSize;
		
		private global::Gtk.Entry entryName;
		
		private global::Gtk.Image imagePreview;
		
		private global::Gtk.Label label13;
		
		private global::Gtk.Label label14;
		
		private global::Gtk.Label label15;
		
		private global::Gtk.Label label16;
		
		private global::Gtk.Button buttonSource;
		
		private global::Gtk.Button buttonOk;
		
		private global::Gtk.Button buttonCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MaterialIconsGenerator.MainDialog
			this.Name = "MaterialIconsGenerator.MainDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Material Icon Generator");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Resizable = false;
			// Internal child MaterialIconsGenerator.MainDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.container = new global::Gtk.Table (((uint)(7)), ((uint)(6)), false);
			this.container.WidthRequest = 500;
			this.container.Name = "container";
			this.container.RowSpacing = ((uint)(6));
			this.container.ColumnSpacing = ((uint)(6));
			this.container.BorderWidth = ((uint)(9));
			// Container child container.Gtk.Table+TableChild
			this.checkhdpi = new global::Gtk.CheckButton ();
			this.checkhdpi.CanFocus = true;
			this.checkhdpi.Name = "checkhdpi";
			this.checkhdpi.Label = global::Mono.Unix.Catalog.GetString ("hdpi");
			this.checkhdpi.Active = true;
			this.checkhdpi.DrawIndicator = true;
			this.checkhdpi.UseUnderline = true;
			this.container.Add (this.checkhdpi);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.container [this.checkhdpi]));
			w2.TopAttach = ((uint)(4));
			w2.BottomAttach = ((uint)(5));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.checkmdpi = new global::Gtk.CheckButton ();
			this.checkmdpi.CanFocus = true;
			this.checkmdpi.Name = "checkmdpi";
			this.checkmdpi.Label = global::Mono.Unix.Catalog.GetString ("mdpi");
			this.checkmdpi.Active = true;
			this.checkmdpi.DrawIndicator = true;
			this.checkmdpi.UseUnderline = true;
			this.container.Add (this.checkmdpi);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.container [this.checkmdpi]));
			w3.TopAttach = ((uint)(4));
			w3.BottomAttach = ((uint)(5));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.checkxhdpi = new global::Gtk.CheckButton ();
			this.checkxhdpi.CanFocus = true;
			this.checkxhdpi.Name = "checkxhdpi";
			this.checkxhdpi.Label = global::Mono.Unix.Catalog.GetString ("xhdpi");
			this.checkxhdpi.Active = true;
			this.checkxhdpi.DrawIndicator = true;
			this.checkxhdpi.UseUnderline = true;
			this.container.Add (this.checkxhdpi);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.container [this.checkxhdpi]));
			w4.TopAttach = ((uint)(5));
			w4.BottomAttach = ((uint)(6));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.checkxxhdpi = new global::Gtk.CheckButton ();
			this.checkxxhdpi.CanFocus = true;
			this.checkxxhdpi.Name = "checkxxhdpi";
			this.checkxxhdpi.Label = global::Mono.Unix.Catalog.GetString ("xxhdpi");
			this.checkxxhdpi.Active = true;
			this.checkxxhdpi.DrawIndicator = true;
			this.checkxxhdpi.UseUnderline = true;
			this.container.Add (this.checkxxhdpi);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.container [this.checkxxhdpi]));
			w5.TopAttach = ((uint)(5));
			w5.BottomAttach = ((uint)(6));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.checkxxxhdpi = new global::Gtk.CheckButton ();
			this.checkxxxhdpi.CanFocus = true;
			this.checkxxxhdpi.Name = "checkxxxhdpi";
			this.checkxxxhdpi.Label = global::Mono.Unix.Catalog.GetString ("xxxhdpi");
			this.checkxxxhdpi.DrawIndicator = true;
			this.checkxxxhdpi.UseUnderline = true;
			this.container.Add (this.checkxxxhdpi);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.container [this.checkxxxhdpi]));
			w6.TopAttach = ((uint)(6));
			w6.BottomAttach = ((uint)(7));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.comboColor = global::Gtk.ComboBox.NewText ();
			this.comboColor.Name = "comboColor";
			this.container.Add (this.comboColor);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.container [this.comboColor]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.comboIcon = global::Gtk.ComboBox.NewText ();
			this.comboIcon.Name = "comboIcon";
			this.container.Add (this.comboIcon);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.container [this.comboIcon]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.comboSize = global::Gtk.ComboBox.NewText ();
			this.comboSize.CanFocus = true;
			this.comboSize.Name = "comboSize";
			this.container.Add (this.comboSize);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.container [this.comboSize]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.container.Add (this.entryName);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.container [this.entryName]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(3));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.imagePreview = new global::Gtk.Image ();
			this.imagePreview.Name = "imagePreview";
			this.container.Add (this.imagePreview);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.container [this.imagePreview]));
			w11.BottomAttach = ((uint)(7));
			w11.LeftAttach = ((uint)(3));
			w11.RightAttach = ((uint)(6));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Icon:");
			this.container.Add (this.label13);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.container [this.label13]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Color:");
			this.container.Add (this.label14);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.container [this.label14]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Size");
			this.container.Add (this.label15);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.container [this.label15]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child container.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.container.Add (this.label16);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.container [this.label16]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.container);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(w1 [this.container]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Internal child MaterialIconsGenerator.MainDialog.ActionArea
			global::Gtk.HButtonBox w17 = this.ActionArea;
			w17.Name = "dialog1_ActionArea";
			w17.Spacing = 10;
			w17.BorderWidth = ((uint)(5));
			w17.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonSource = new global::Gtk.Button ();
			this.buttonSource.CanFocus = true;
			this.buttonSource.Name = "buttonSource";
			this.buttonSource.UseUnderline = true;
			this.buttonSource.Label = global::Mono.Unix.Catalog.GetString ("Icons Source");
			w17.Add (this.buttonSource);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17 [this.buttonSource]));
			w18.Expand = false;
			w18.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = global::Mono.Unix.Catalog.GetString ("Add");
			w17.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w19 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17 [this.buttonOk]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w20 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17 [this.buttonCancel]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 550;
			this.DefaultHeight = 293;
			this.Show ();
			this.comboSize.Changed += new global::System.EventHandler (this.OnComboSizeChanged);
			this.comboIcon.Changed += new global::System.EventHandler (this.OnComboIconChanged);
			this.comboColor.Changed += new global::System.EventHandler (this.OnComboColorChanged);
			this.buttonSource.Clicked += new global::System.EventHandler (this.OnButtonSourceClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonAddClicked);
		}
	}
}
