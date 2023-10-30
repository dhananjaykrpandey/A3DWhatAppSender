namespace A3DWhatAppSender
{
    partial class FrmCreateContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmCreateContact));
            TableViewDefinition tableViewDefinition1 = new TableViewDefinition();
            radBindingNavigator1 = new RadBindingNavigator();
            commandBarRowElement1 = new CommandBarRowElement();
            commandBarStripElement2 = new CommandBarStripElement();
            commandBarButton5 = new CommandBarButton();
            commandBarSeparator5 = new CommandBarSeparator();
            commandBarButton8 = new CommandBarButton();
            commandBarSeparator6 = new CommandBarSeparator();
            commandBarButton7 = new CommandBarButton();
            commandBarSeparator7 = new CommandBarSeparator();
            commandBarButton6 = new CommandBarButton();
            commandBarSeparator8 = new CommandBarSeparator();
            commandBarButton9 = new CommandBarButton();
            commandBarStripElement1 = new CommandBarStripElement();
            commandBarButton1 = new CommandBarButton();
            commandBarSeparator1 = new CommandBarSeparator();
            commandBarButton2 = new CommandBarButton();
            commandBarSeparator2 = new CommandBarSeparator();
            commandBarTextBox1 = new CommandBarTextBox();
            commandBarLabel1 = new CommandBarLabel();
            commandBarSeparator3 = new CommandBarSeparator();
            commandBarButton3 = new CommandBarButton();
            commandBarSeparator4 = new CommandBarSeparator();
            commandBarButton4 = new CommandBarButton();
            radGridView1 = new RadGridView();
            ((ISupportInitialize)radBindingNavigator1).BeginInit();
            ((ISupportInitialize)radGridView1).BeginInit();
            ((ISupportInitialize)radGridView1.MasterTemplate).BeginInit();
            ((ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radBindingNavigator1
            // 
            radBindingNavigator1.Dock = DockStyle.Top;
            radBindingNavigator1.Location = new Point(0, 0);
            radBindingNavigator1.Name = "radBindingNavigator1";
            radBindingNavigator1.Rows.AddRange(new CommandBarRowElement[] { commandBarRowElement1 });
            radBindingNavigator1.Size = new Size(866, 31);
            radBindingNavigator1.TabIndex = 1;
            // 
            // commandBarRowElement1
            // 
            commandBarRowElement1.CommandRole = RadCommandBarRole.RowElement;
            commandBarRowElement1.MinSize = new Size(25, 25);
            commandBarRowElement1.Name = "commandBarRowElement1";
            commandBarRowElement1.Strips.AddRange(new CommandBarStripElement[] { commandBarStripElement2, commandBarStripElement1 });
            // 
            // commandBarStripElement2
            // 
            commandBarStripElement2.CommandRole = RadCommandBarRole.SecondStrip;
            commandBarStripElement2.DisplayName = "commandBarStripElement2";
            commandBarStripElement2.EnableDragging = false;
            // 
            // 
            // 
            commandBarStripElement2.Grip.Visibility = ElementVisibility.Collapsed;
            commandBarStripElement2.Items.AddRange(new RadCommandBarBaseItem[] { commandBarButton5, commandBarSeparator5, commandBarButton8, commandBarSeparator6, commandBarButton7, commandBarSeparator7, commandBarButton6, commandBarSeparator8, commandBarButton9 });
            commandBarStripElement2.MinSize = new Size(0, 0);
            // 
            // 
            // 
            commandBarStripElement2.OverflowButton.Visibility = ElementVisibility.Collapsed;
            ((RadCommandBarGrip)commandBarStripElement2.GetChildAt(0)).Visibility = ElementVisibility.Collapsed;
            ((RadCommandBarOverflowButton)commandBarStripElement2.GetChildAt(2)).Visibility = ElementVisibility.Collapsed;
            // 
            // commandBarButton5
            // 
            commandBarButton5.CommandRole = RadCommandBarRole.NewItem;
            commandBarButton5.Image = (Image)resources.GetObject("commandBarButton5.Image");
            commandBarButton5.Margin = new Padding(3, 0, 0, 0);
            commandBarButton5.Name = "commandBarButton5";
            commandBarButton5.SvgImageXml = resources.GetString("commandBarButton5.SvgImageXml");
            // 
            // commandBarSeparator5
            // 
            commandBarSeparator5.Name = "commandBarSeparator5";
            commandBarSeparator5.VisibleInOverflowMenu = false;
            // 
            // commandBarButton8
            // 
            commandBarButton8.DisplayName = "commandBarButton8";
            commandBarButton8.Image = (Image)resources.GetObject("commandBarButton8.Image");
            commandBarButton8.Name = "commandBarButton8";
            commandBarButton8.Text = "commandBarButton8";
            // 
            // commandBarSeparator6
            // 
            commandBarSeparator6.DisplayName = "commandBarSeparator6";
            commandBarSeparator6.Name = "commandBarSeparator6";
            commandBarSeparator6.VisibleInOverflowMenu = false;
            // 
            // commandBarButton7
            // 
            commandBarButton7.DisplayName = "commandBarButton7";
            commandBarButton7.Image = (Image)resources.GetObject("commandBarButton7.Image");
            commandBarButton7.Name = "commandBarButton7";
            commandBarButton7.Text = "commandBarButton7";
            // 
            // commandBarSeparator7
            // 
            commandBarSeparator7.DisplayName = "commandBarSeparator7";
            commandBarSeparator7.Name = "commandBarSeparator7";
            commandBarSeparator7.VisibleInOverflowMenu = false;
            // 
            // commandBarButton6
            // 
            commandBarButton6.CommandRole = RadCommandBarRole.DeleteItem;
            commandBarButton6.Image = (Image)resources.GetObject("commandBarButton6.Image");
            commandBarButton6.Name = "commandBarButton6";
            commandBarButton6.SvgImageXml = resources.GetString("commandBarButton6.SvgImageXml");
            // 
            // commandBarSeparator8
            // 
            commandBarSeparator8.DisplayName = "commandBarSeparator8";
            commandBarSeparator8.Name = "commandBarSeparator8";
            commandBarSeparator8.VisibleInOverflowMenu = false;
            // 
            // commandBarButton9
            // 
            commandBarButton9.DisplayName = "commandBarButton9";
            commandBarButton9.Image = (Image)resources.GetObject("commandBarButton9.Image");
            commandBarButton9.Name = "commandBarButton9";
            commandBarButton9.Text = "commandBarButton9";
            // 
            // commandBarStripElement1
            // 
            commandBarStripElement1.CommandRole = RadCommandBarRole.FirstStrip;
            commandBarStripElement1.DisplayName = "commandBarStripElement1";
            commandBarStripElement1.EnableDragging = false;
            // 
            // 
            // 
            commandBarStripElement1.Grip.Visibility = ElementVisibility.Collapsed;
            commandBarStripElement1.Items.AddRange(new RadCommandBarBaseItem[] { commandBarButton1, commandBarSeparator1, commandBarButton2, commandBarSeparator2, commandBarTextBox1, commandBarLabel1, commandBarSeparator3, commandBarButton3, commandBarSeparator4, commandBarButton4 });
            commandBarStripElement1.MinSize = new Size(0, 0);
            // 
            // 
            // 
            commandBarStripElement1.OverflowButton.Visibility = ElementVisibility.Collapsed;
            ((RadCommandBarGrip)commandBarStripElement1.GetChildAt(0)).Visibility = ElementVisibility.Collapsed;
            ((RadCommandBarOverflowButton)commandBarStripElement1.GetChildAt(2)).Visibility = ElementVisibility.Collapsed;
            // 
            // commandBarButton1
            // 
            commandBarButton1.CommandRole = RadCommandBarRole.FirstItem;
            commandBarButton1.Image = (Image)resources.GetObject("commandBarButton1.Image");
            commandBarButton1.Margin = new Padding(3, 0, 0, 0);
            commandBarButton1.Name = "commandBarButton1";
            commandBarButton1.SvgImageXml = resources.GetString("commandBarButton1.SvgImageXml");
            // 
            // commandBarSeparator1
            // 
            commandBarSeparator1.Name = "commandBarSeparator1";
            commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // commandBarButton2
            // 
            commandBarButton2.CommandRole = RadCommandBarRole.PreviousItem;
            commandBarButton2.Image = (Image)resources.GetObject("commandBarButton2.Image");
            commandBarButton2.Name = "commandBarButton2";
            commandBarButton2.SvgImageXml = resources.GetString("commandBarButton2.SvgImageXml");
            // 
            // commandBarSeparator2
            // 
            commandBarSeparator2.Name = "commandBarSeparator2";
            commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // commandBarTextBox1
            // 
            commandBarTextBox1.CommandRole = RadCommandBarRole.PositionItem;
            commandBarTextBox1.Name = "commandBarTextBox1";
            // 
            // commandBarLabel1
            // 
            commandBarLabel1.CommandRole = RadCommandBarRole.CountItem;
            commandBarLabel1.Name = "commandBarLabel1";
            commandBarLabel1.Text = "of {0}";
            // 
            // commandBarSeparator3
            // 
            commandBarSeparator3.Name = "commandBarSeparator3";
            commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // commandBarButton3
            // 
            commandBarButton3.CommandRole = RadCommandBarRole.NextItem;
            commandBarButton3.Image = (Image)resources.GetObject("commandBarButton3.Image");
            commandBarButton3.Name = "commandBarButton3";
            commandBarButton3.SvgImageXml = resources.GetString("commandBarButton3.SvgImageXml");
            // 
            // commandBarSeparator4
            // 
            commandBarSeparator4.Name = "commandBarSeparator4";
            commandBarSeparator4.VisibleInOverflowMenu = false;
            // 
            // commandBarButton4
            // 
            commandBarButton4.CommandRole = RadCommandBarRole.LastItem;
            commandBarButton4.Image = (Image)resources.GetObject("commandBarButton4.Image");
            commandBarButton4.Name = "commandBarButton4";
            commandBarButton4.SvgImageXml = resources.GetString("commandBarButton4.SvgImageXml");
            // 
            // radGridView1
            // 
            radGridView1.Dock = DockStyle.Fill;
            radGridView1.Location = new Point(0, 31);
            // 
            // 
            // 
            radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            radGridView1.Name = "radGridView1";
            radGridView1.Size = new Size(866, 243);
            radGridView1.TabIndex = 2;
            // 
            // FrmCreateContact
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 274);
            Controls.Add(radGridView1);
            Controls.Add(radBindingNavigator1);
            Name = "FrmCreateContact";
            Text = "Create Contact";
            Load += FrmCreateContact_Load;
            ((ISupportInitialize)radBindingNavigator1).EndInit();
            ((ISupportInitialize)radGridView1.MasterTemplate).EndInit();
            ((ISupportInitialize)radGridView1).EndInit();
            ((ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadBindingNavigator radBindingNavigator1;
        private CommandBarRowElement commandBarRowElement1;
        private CommandBarStripElement commandBarStripElement2;
        private CommandBarButton commandBarButton5;
        private CommandBarSeparator commandBarSeparator5;
        private CommandBarButton commandBarButton8;
        private CommandBarSeparator commandBarSeparator6;
        private CommandBarButton commandBarButton7;
        private CommandBarSeparator commandBarSeparator7;
        private CommandBarButton commandBarButton6;
        private CommandBarSeparator commandBarSeparator8;
        private CommandBarButton commandBarButton9;
        private CommandBarStripElement commandBarStripElement1;
        private CommandBarButton commandBarButton1;
        private CommandBarSeparator commandBarSeparator1;
        private CommandBarButton commandBarButton2;
        private CommandBarSeparator commandBarSeparator2;
        private CommandBarTextBox commandBarTextBox1;
        private CommandBarLabel commandBarLabel1;
        private CommandBarSeparator commandBarSeparator3;
        private CommandBarButton commandBarButton3;
        private CommandBarSeparator commandBarSeparator4;
        private CommandBarButton commandBarButton4;
        private RadGridView radGridView1;
    }
}