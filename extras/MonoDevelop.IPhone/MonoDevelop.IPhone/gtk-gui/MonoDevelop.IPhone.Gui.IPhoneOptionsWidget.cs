
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.IPhone.Gui
{
	internal partial class IPhoneOptionsWidget
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Table table1;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Label iPadInterfaceFileLabel;

		private global::Gtk.Entry bundleIdEntry;

		private global::Gtk.Entry bundleVersionEntry;

		private global::Gtk.Entry devRegionEntry;

		private global::Gtk.Entry displayNameEntry;

		private global::Gtk.Label ipadIconLabel;

		private global::MonoDevelop.Projects.Gui.ProjectFileEntry ipadIconPicker;

		private global::Gtk.Label ipadIconSizeLabel;

		private global::MonoDevelop.Projects.Gui.ProjectFileEntry iPadNibPicker;

		private global::Gtk.Label ipadSpotlightIconLabel;

		private global::MonoDevelop.Projects.Gui.ProjectFileEntry ipadSpotlightIconPicker;

		private global::Gtk.Label ipadSpotlightIconSizeLabel;

		private global::Gtk.Label iphoneIconLabel;

		private global::MonoDevelop.Projects.Gui.ProjectFileEntry iphoneIconPicker;

		private global::Gtk.Label iphoneIconSizeLabel;

		private global::Gtk.Label label1;

		private global::Gtk.Label label10;

		private global::Gtk.Label label15;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		private global::MonoDevelop.Projects.Gui.ProjectFileEntry mainNibPicker;

		private global::Gtk.Label settingsIconLabel;

		private global::MonoDevelop.Projects.Gui.ProjectFileEntry settingsIconPicker;

		private global::Gtk.Label settingsIconSizeLabel;

		private global::Gtk.Table table2;

		private global::Gtk.Label ipadOrientationLabel;

		private global::Gtk.ComboBox iPadOrientationsCombo;

		private global::Gtk.Label ipadSpotlightIconLabel1;

		private global::Gtk.ComboBox supportedOrientationsCombo;

		private global::Gtk.ComboBox targetDevicesCombo;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.IPhone.Gui.IPhoneOptionsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.IPhone.Gui.IPhoneOptionsWidget";
			// Container child MonoDevelop.IPhone.Gui.IPhoneOptionsWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 12;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(16)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(4));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.alignment2 = new global::Gtk.Alignment (0f, 0.5f, 1f, 1f);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.iPadInterfaceFileLabel = new global::Gtk.Label ();
			this.iPadInterfaceFileLabel.Name = "iPadInterfaceFileLabel";
			this.iPadInterfaceFileLabel.Xalign = 0f;
			this.iPadInterfaceFileLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("i_Pad interface file:");
			this.iPadInterfaceFileLabel.UseUnderline = true;
			this.alignment2.Add (this.iPadInterfaceFileLabel);
			this.table1.Add (this.alignment2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.alignment2]));
			w2.TopAttach = ((uint)(6));
			w2.BottomAttach = ((uint)(7));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.bundleIdEntry = new global::Gtk.Entry ();
			this.bundleIdEntry.CanFocus = true;
			this.bundleIdEntry.Name = "bundleIdEntry";
			this.bundleIdEntry.IsEditable = true;
			this.bundleIdEntry.InvisibleChar = '●';
			this.table1.Add (this.bundleIdEntry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.bundleIdEntry]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(4));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.bundleVersionEntry = new global::Gtk.Entry ();
			this.bundleVersionEntry.CanFocus = true;
			this.bundleVersionEntry.Name = "bundleVersionEntry";
			this.bundleVersionEntry.IsEditable = true;
			this.bundleVersionEntry.InvisibleChar = '●';
			this.table1.Add (this.bundleVersionEntry);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.bundleVersionEntry]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.devRegionEntry = new global::Gtk.Entry ();
			this.devRegionEntry.CanFocus = true;
			this.devRegionEntry.Name = "devRegionEntry";
			this.devRegionEntry.IsEditable = true;
			this.devRegionEntry.InvisibleChar = '●';
			this.table1.Add (this.devRegionEntry);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.devRegionEntry]));
			w5.TopAttach = ((uint)(7));
			w5.BottomAttach = ((uint)(8));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(4));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.displayNameEntry = new global::Gtk.Entry ();
			this.displayNameEntry.CanFocus = true;
			this.displayNameEntry.Name = "displayNameEntry";
			this.displayNameEntry.IsEditable = true;
			this.displayNameEntry.InvisibleChar = '●';
			this.table1.Add (this.displayNameEntry);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.displayNameEntry]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(2));
			w6.RightAttach = ((uint)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table1.Gtk.Table+TableChild
			this.ipadIconLabel = new global::Gtk.Label ();
			this.ipadIconLabel.Name = "ipadIconLabel";
			this.ipadIconLabel.Xalign = 0f;
			this.ipadIconLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("iP_ad:");
			this.ipadIconLabel.UseUnderline = true;
			this.table1.Add (this.ipadIconLabel);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.ipadIconLabel]));
			w7.TopAttach = ((uint)(10));
			w7.BottomAttach = ((uint)(11));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ipadIconPicker = new global::MonoDevelop.Projects.Gui.ProjectFileEntry ();
			this.ipadIconPicker.Name = "ipadIconPicker";
			this.ipadIconPicker.EntryIsEditable = false;
			this.table1.Add (this.ipadIconPicker);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.ipadIconPicker]));
			w8.TopAttach = ((uint)(10));
			w8.BottomAttach = ((uint)(11));
			w8.LeftAttach = ((uint)(2));
			w8.RightAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ipadIconSizeLabel = new global::Gtk.Label ();
			this.ipadIconSizeLabel.Name = "ipadIconSizeLabel";
			this.ipadIconSizeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("(72x72)");
			this.table1.Add (this.ipadIconSizeLabel);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.ipadIconSizeLabel]));
			w9.TopAttach = ((uint)(10));
			w9.BottomAttach = ((uint)(11));
			w9.LeftAttach = ((uint)(3));
			w9.RightAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.iPadNibPicker = new global::MonoDevelop.Projects.Gui.ProjectFileEntry ();
			this.iPadNibPicker.Name = "iPadNibPicker";
			this.iPadNibPicker.EntryIsEditable = false;
			this.table1.Add (this.iPadNibPicker);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.iPadNibPicker]));
			w10.TopAttach = ((uint)(6));
			w10.BottomAttach = ((uint)(7));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(4));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ipadSpotlightIconLabel = new global::Gtk.Label ();
			this.ipadSpotlightIconLabel.Name = "ipadSpotlightIconLabel";
			this.ipadSpotlightIconLabel.Xalign = 0f;
			this.ipadSpotlightIconLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("iPad Sp_otlight:");
			this.ipadSpotlightIconLabel.UseUnderline = true;
			this.table1.Add (this.ipadSpotlightIconLabel);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.ipadSpotlightIconLabel]));
			w11.TopAttach = ((uint)(12));
			w11.BottomAttach = ((uint)(13));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ipadSpotlightIconPicker = new global::MonoDevelop.Projects.Gui.ProjectFileEntry ();
			this.ipadSpotlightIconPicker.Name = "ipadSpotlightIconPicker";
			this.ipadSpotlightIconPicker.EntryIsEditable = false;
			this.table1.Add (this.ipadSpotlightIconPicker);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.ipadSpotlightIconPicker]));
			w12.TopAttach = ((uint)(12));
			w12.BottomAttach = ((uint)(13));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ipadSpotlightIconSizeLabel = new global::Gtk.Label ();
			this.ipadSpotlightIconSizeLabel.Name = "ipadSpotlightIconSizeLabel";
			this.ipadSpotlightIconSizeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("(50x50)");
			this.table1.Add (this.ipadSpotlightIconSizeLabel);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.ipadSpotlightIconSizeLabel]));
			w13.TopAttach = ((uint)(12));
			w13.BottomAttach = ((uint)(13));
			w13.LeftAttach = ((uint)(3));
			w13.RightAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.iphoneIconLabel = new global::Gtk.Label ();
			this.iphoneIconLabel.Name = "iphoneIconLabel";
			this.iphoneIconLabel.Xalign = 0f;
			this.iphoneIconLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("iPh_one:");
			this.iphoneIconLabel.UseUnderline = true;
			this.table1.Add (this.iphoneIconLabel);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.iphoneIconLabel]));
			w14.TopAttach = ((uint)(9));
			w14.BottomAttach = ((uint)(10));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.iphoneIconPicker = new global::MonoDevelop.Projects.Gui.ProjectFileEntry ();
			this.iphoneIconPicker.Name = "iphoneIconPicker";
			this.iphoneIconPicker.EntryIsEditable = false;
			this.table1.Add (this.iphoneIconPicker);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.iphoneIconPicker]));
			w15.TopAttach = ((uint)(9));
			w15.BottomAttach = ((uint)(10));
			w15.LeftAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.iphoneIconSizeLabel = new global::Gtk.Label ();
			this.iphoneIconSizeLabel.Name = "iphoneIconSizeLabel";
			this.iphoneIconSizeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("(57x57)");
			this.table1.Add (this.iphoneIconSizeLabel);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.iphoneIconSizeLabel]));
			w16.TopAttach = ((uint)(9));
			w16.BottomAttach = ((uint)(10));
			w16.LeftAttach = ((uint)(3));
			w16.RightAttach = ((uint)(4));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0f;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Application Bundle</b>");
			this.label1.UseMarkup = true;
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w17.RightAttach = ((uint)(4));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 0f;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Orientation</b>");
			this.label10.UseMarkup = true;
			this.table1.Add (this.label10);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.label10]));
			w18.TopAttach = ((uint)(13));
			w18.BottomAttach = ((uint)(14));
			w18.RightAttach = ((uint)(4));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.WidthRequest = 12;
			this.label15.Name = "label15";
			this.table1.Add (this.label15);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.label15]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0f;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Main _interface file:");
			this.label2.UseUnderline = true;
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w20.TopAttach = ((uint)(5));
			w20.BottomAttach = ((uint)(6));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0f;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Development _region:");
			this.label3.UseUnderline = true;
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w21.TopAttach = ((uint)(7));
			w21.BottomAttach = ((uint)(8));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0f;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Bundle _version:");
			this.label5.UseUnderline = true;
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w22.TopAttach = ((uint)(3));
			w22.BottomAttach = ((uint)(4));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0f;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("_Display name:");
			this.label6.UseUnderline = true;
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0f;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Bundle _identifier:");
			this.label7.UseUnderline = true;
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(3));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0f;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Application Icons</b>");
			this.label8.UseMarkup = true;
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.label8]));
			w25.TopAttach = ((uint)(8));
			w25.BottomAttach = ((uint)(9));
			w25.RightAttach = ((uint)(4));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0f;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("_Target devices:");
			this.label9.UseUnderline = true;
			this.table1.Add (this.label9);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1[this.label9]));
			w26.TopAttach = ((uint)(4));
			w26.BottomAttach = ((uint)(5));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.mainNibPicker = new global::MonoDevelop.Projects.Gui.ProjectFileEntry ();
			this.mainNibPicker.Name = "mainNibPicker";
			this.mainNibPicker.EntryIsEditable = false;
			this.table1.Add (this.mainNibPicker);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1[this.mainNibPicker]));
			w27.TopAttach = ((uint)(5));
			w27.BottomAttach = ((uint)(6));
			w27.LeftAttach = ((uint)(2));
			w27.RightAttach = ((uint)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table1.Gtk.Table+TableChild
			this.settingsIconLabel = new global::Gtk.Label ();
			this.settingsIconLabel.Name = "settingsIconLabel";
			this.settingsIconLabel.Xalign = 0f;
			this.settingsIconLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("_Settings/Spotlight:");
			this.settingsIconLabel.UseUnderline = true;
			this.table1.Add (this.settingsIconLabel);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1[this.settingsIconLabel]));
			w28.TopAttach = ((uint)(11));
			w28.BottomAttach = ((uint)(12));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.settingsIconPicker = new global::MonoDevelop.Projects.Gui.ProjectFileEntry ();
			this.settingsIconPicker.Name = "settingsIconPicker";
			this.settingsIconPicker.EntryIsEditable = false;
			this.table1.Add (this.settingsIconPicker);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1[this.settingsIconPicker]));
			w29.TopAttach = ((uint)(11));
			w29.BottomAttach = ((uint)(12));
			w29.LeftAttach = ((uint)(2));
			w29.RightAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.settingsIconSizeLabel = new global::Gtk.Label ();
			this.settingsIconSizeLabel.Name = "settingsIconSizeLabel";
			this.settingsIconSizeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("(29x29)");
			this.table1.Add (this.settingsIconSizeLabel);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1[this.settingsIconSizeLabel]));
			w30.TopAttach = ((uint)(11));
			w30.BottomAttach = ((uint)(12));
			w30.LeftAttach = ((uint)(3));
			w30.RightAttach = ((uint)(4));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.ipadOrientationLabel = new global::Gtk.Label ();
			this.ipadOrientationLabel.Name = "ipadOrientationLabel";
			this.ipadOrientationLabel.Xalign = 0f;
			this.ipadOrientationLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("iPad Ori_entations:");
			this.ipadOrientationLabel.UseUnderline = true;
			this.table2.Add (this.ipadOrientationLabel);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2[this.ipadOrientationLabel]));
			w31.TopAttach = ((uint)(1));
			w31.BottomAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.iPadOrientationsCombo = global::Gtk.ComboBox.NewText ();
			this.iPadOrientationsCombo.Name = "iPadOrientationsCombo";
			this.table2.Add (this.iPadOrientationsCombo);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table2[this.iPadOrientationsCombo]));
			w32.TopAttach = ((uint)(1));
			w32.BottomAttach = ((uint)(2));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.ipadSpotlightIconLabel1 = new global::Gtk.Label ();
			this.ipadSpotlightIconLabel1.Name = "ipadSpotlightIconLabel1";
			this.ipadSpotlightIconLabel1.Xalign = 0f;
			this.ipadSpotlightIconLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("Supported _Orientations:");
			this.ipadSpotlightIconLabel1.UseUnderline = true;
			this.table2.Add (this.ipadSpotlightIconLabel1);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table2[this.ipadSpotlightIconLabel1]));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.supportedOrientationsCombo = global::Gtk.ComboBox.NewText ();
			this.supportedOrientationsCombo.Name = "supportedOrientationsCombo";
			this.table2.Add (this.supportedOrientationsCombo);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table2[this.supportedOrientationsCombo]));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add (this.table2);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table1[this.table2]));
			w35.TopAttach = ((uint)(14));
			w35.BottomAttach = ((uint)(15));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table1.Gtk.Table+TableChild
			this.targetDevicesCombo = global::Gtk.ComboBox.NewText ();
			this.targetDevicesCombo.Name = "targetDevicesCombo";
			this.table1.Add (this.targetDevicesCombo);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table1[this.targetDevicesCombo]));
			w36.TopAttach = ((uint)(4));
			w36.BottomAttach = ((uint)(5));
			w36.LeftAttach = ((uint)(2));
			w36.RightAttach = ((uint)(4));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
			w37.Position = 0;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.ipadIconLabel.MnemonicWidget = this.ipadIconPicker;
			this.ipadSpotlightIconLabel.MnemonicWidget = this.ipadSpotlightIconPicker;
			this.iphoneIconLabel.MnemonicWidget = this.iphoneIconPicker;
			this.settingsIconLabel.MnemonicWidget = this.settingsIconPicker;
			this.ipadOrientationLabel.MnemonicWidget = this.iPadOrientationsCombo;
			this.ipadSpotlightIconLabel1.MnemonicWidget = this.supportedOrientationsCombo;
			this.Hide ();
		}
	}
}
