namespace ultimateBrokerage
{
    partial class addrequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addrequest));
            System.Windows.Forms.Label referenceLabel;
            System.Windows.Forms.Label exchangeLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label areanameLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label bedroomsLabel;
            System.Windows.Forms.Label bathroomsLabel;
            System.Windows.Forms.Label floorLabel;
            System.Windows.Forms.Label parkingLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label photoLabel;
            this.ultimatebrockrageDataSet1 = new ultimateBrokerage.UltimatebrockrageDataSet1();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyTableAdapter = new ultimateBrokerage.UltimatebrockrageDataSet1TableAdapters.propertyTableAdapter();
            this.tableAdapterManager = new ultimateBrokerage.UltimatebrockrageDataSet1TableAdapters.TableAdapterManager();
            this.propertyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.propertyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.exchangeTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.areanameTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.bedroomsTextBox = new System.Windows.Forms.TextBox();
            this.bathroomsTextBox = new System.Windows.Forms.TextBox();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.parkingTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.ultimatebrockrageDataSet2 = new ultimateBrokerage.UltimatebrockrageDataSet2();
            this.propertyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.propertyTableAdapter1 = new ultimateBrokerage.UltimatebrockrageDataSet2TableAdapters.propertyTableAdapter();
            this.tableAdapterManager1 = new ultimateBrokerage.UltimatebrockrageDataSet2TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            referenceLabel = new System.Windows.Forms.Label();
            exchangeLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            areanameLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            bedroomsLabel = new System.Windows.Forms.Label();
            bathroomsLabel = new System.Windows.Forms.Label();
            floorLabel = new System.Windows.Forms.Label();
            parkingLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ultimatebrockrageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingNavigator)).BeginInit();
            this.propertyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultimatebrockrageDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultimatebrockrageDataSet1
            // 
            this.ultimatebrockrageDataSet1.DataSetName = "UltimatebrockrageDataSet1";
            this.ultimatebrockrageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataMember = "property";
            this.propertyBindingSource.DataSource = this.ultimatebrockrageDataSet1;
            // 
            // propertyTableAdapter
            // 
            this.propertyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.propertyTableAdapter = this.propertyTableAdapter;
            this.tableAdapterManager.requestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ultimateBrokerage.UltimatebrockrageDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // propertyBindingNavigator
            // 
            this.propertyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.propertyBindingNavigator.BindingSource = this.propertyBindingSource;
            this.propertyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propertyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.propertyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.propertyBindingNavigatorSaveItem});
            this.propertyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.propertyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propertyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propertyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propertyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propertyBindingNavigator.Name = "propertyBindingNavigator";
            this.propertyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertyBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.propertyBindingNavigator.TabIndex = 0;
            this.propertyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // propertyBindingNavigatorSaveItem
            // 
            this.propertyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.propertyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("propertyBindingNavigatorSaveItem.Image")));
            this.propertyBindingNavigatorSaveItem.Name = "propertyBindingNavigatorSaveItem";
            this.propertyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.propertyBindingNavigatorSaveItem.Text = "Save Data";
            this.propertyBindingNavigatorSaveItem.Click += new System.EventHandler(this.propertyBindingNavigatorSaveItem_Click);
            // 
            // referenceLabel
            // 
            referenceLabel.AutoSize = true;
            referenceLabel.Location = new System.Drawing.Point(82, 83);
            referenceLabel.Name = "referenceLabel";
            referenceLabel.Size = new System.Drawing.Size(55, 13);
            referenceLabel.TabIndex = 1;
            referenceLabel.Text = "reference:";
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "reference", true));
            this.referenceTextBox.Location = new System.Drawing.Point(147, 80);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.referenceTextBox.TabIndex = 2;
            // 
            // exchangeLabel
            // 
            exchangeLabel.AutoSize = true;
            exchangeLabel.Location = new System.Drawing.Point(82, 109);
            exchangeLabel.Name = "exchangeLabel";
            exchangeLabel.Size = new System.Drawing.Size(57, 13);
            exchangeLabel.TabIndex = 3;
            exchangeLabel.Text = "exchange:";
            // 
            // exchangeTextBox
            // 
            this.exchangeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "exchange", true));
            this.exchangeTextBox.Location = new System.Drawing.Point(147, 106);
            this.exchangeTextBox.Name = "exchangeTextBox";
            this.exchangeTextBox.Size = new System.Drawing.Size(100, 20);
            this.exchangeTextBox.TabIndex = 4;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(82, 135);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(30, 13);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(147, 132);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 6;
            // 
            // areanameLabel
            // 
            areanameLabel.AutoSize = true;
            areanameLabel.Location = new System.Drawing.Point(82, 161);
            areanameLabel.Name = "areanameLabel";
            areanameLabel.Size = new System.Drawing.Size(57, 13);
            areanameLabel.TabIndex = 7;
            areanameLabel.Text = "areaname:";
            // 
            // areanameTextBox
            // 
            this.areanameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "areaname", true));
            this.areanameTextBox.Location = new System.Drawing.Point(147, 158);
            this.areanameTextBox.Name = "areanameTextBox";
            this.areanameTextBox.Size = new System.Drawing.Size(100, 20);
            this.areanameTextBox.TabIndex = 8;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(82, 187);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(28, 13);
            sizeLabel.TabIndex = 9;
            sizeLabel.Text = "size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(147, 184);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 10;
            // 
            // bedroomsLabel
            // 
            bedroomsLabel.AutoSize = true;
            bedroomsLabel.Location = new System.Drawing.Point(82, 213);
            bedroomsLabel.Name = "bedroomsLabel";
            bedroomsLabel.Size = new System.Drawing.Size(56, 13);
            bedroomsLabel.TabIndex = 11;
            bedroomsLabel.Text = "bedrooms:";
            // 
            // bedroomsTextBox
            // 
            this.bedroomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "bedrooms", true));
            this.bedroomsTextBox.Location = new System.Drawing.Point(147, 210);
            this.bedroomsTextBox.Name = "bedroomsTextBox";
            this.bedroomsTextBox.Size = new System.Drawing.Size(100, 20);
            this.bedroomsTextBox.TabIndex = 12;
            // 
            // bathroomsLabel
            // 
            bathroomsLabel.AutoSize = true;
            bathroomsLabel.Location = new System.Drawing.Point(82, 239);
            bathroomsLabel.Name = "bathroomsLabel";
            bathroomsLabel.Size = new System.Drawing.Size(59, 13);
            bathroomsLabel.TabIndex = 13;
            bathroomsLabel.Text = "bathrooms:";
            // 
            // bathroomsTextBox
            // 
            this.bathroomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "bathrooms", true));
            this.bathroomsTextBox.Location = new System.Drawing.Point(147, 236);
            this.bathroomsTextBox.Name = "bathroomsTextBox";
            this.bathroomsTextBox.Size = new System.Drawing.Size(100, 20);
            this.bathroomsTextBox.TabIndex = 14;
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Location = new System.Drawing.Point(82, 265);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(30, 13);
            floorLabel.TabIndex = 15;
            floorLabel.Text = "floor:";
            // 
            // floorTextBox
            // 
            this.floorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "floor", true));
            this.floorTextBox.Location = new System.Drawing.Point(147, 262);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(100, 20);
            this.floorTextBox.TabIndex = 16;
            // 
            // parkingLabel
            // 
            parkingLabel.AutoSize = true;
            parkingLabel.Location = new System.Drawing.Point(82, 291);
            parkingLabel.Name = "parkingLabel";
            parkingLabel.Size = new System.Drawing.Size(45, 13);
            parkingLabel.TabIndex = 17;
            parkingLabel.Text = "parking:";
            // 
            // parkingTextBox
            // 
            this.parkingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "parking", true));
            this.parkingTextBox.Location = new System.Drawing.Point(147, 288);
            this.parkingTextBox.Name = "parkingTextBox";
            this.parkingTextBox.Size = new System.Drawing.Size(100, 20);
            this.parkingTextBox.TabIndex = 18;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(82, 317);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 19;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertyBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(147, 314);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 20;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(82, 340);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(38, 13);
            photoLabel.TabIndex = 21;
            photoLabel.Text = "Photo:";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.propertyBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(114, 340);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(215, 171);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 22;
            this.photoPictureBox.TabStop = false;
            // 
            // ultimatebrockrageDataSet2
            // 
            this.ultimatebrockrageDataSet2.DataSetName = "UltimatebrockrageDataSet2";
            this.ultimatebrockrageDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyBindingSource1
            // 
            this.propertyBindingSource1.DataMember = "property";
            this.propertyBindingSource1.DataSource = this.ultimatebrockrageDataSet2;
            // 
            // propertyTableAdapter1
            // 
            this.propertyTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AreaTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PhotosTableAdapter = null;
            this.tableAdapterManager1.propertyTableAdapter = this.propertyTableAdapter1;
            this.tableAdapterManager1.requestTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ultimateBrokerage.UltimatebrockrageDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            this.tableAdapterManager1.UserTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "LOAD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addrequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(referenceLabel);
            this.Controls.Add(this.referenceTextBox);
            this.Controls.Add(exchangeLabel);
            this.Controls.Add(this.exchangeTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(areanameLabel);
            this.Controls.Add(this.areanameTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(bedroomsLabel);
            this.Controls.Add(this.bedroomsTextBox);
            this.Controls.Add(bathroomsLabel);
            this.Controls.Add(this.bathroomsTextBox);
            this.Controls.Add(floorLabel);
            this.Controls.Add(this.floorTextBox);
            this.Controls.Add(parkingLabel);
            this.Controls.Add(this.parkingTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.propertyBindingNavigator);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "addrequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addrequest";
            this.Load += new System.EventHandler(this.addrequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultimatebrockrageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingNavigator)).EndInit();
            this.propertyBindingNavigator.ResumeLayout(false);
            this.propertyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultimatebrockrageDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UltimatebrockrageDataSet1 ultimatebrockrageDataSet1;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private UltimatebrockrageDataSet1TableAdapters.propertyTableAdapter propertyTableAdapter;
        private UltimatebrockrageDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator propertyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton propertyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.Windows.Forms.TextBox exchangeTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox areanameTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox bedroomsTextBox;
        private System.Windows.Forms.TextBox bathroomsTextBox;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.TextBox parkingTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private UltimatebrockrageDataSet2 ultimatebrockrageDataSet2;
        private System.Windows.Forms.BindingSource propertyBindingSource1;
        private UltimatebrockrageDataSet2TableAdapters.propertyTableAdapter propertyTableAdapter1;
        private UltimatebrockrageDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}