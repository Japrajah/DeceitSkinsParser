
using System.Drawing;
using System.Windows.Forms;

namespace DeceitCheatController
{
    public class shortmode
    {


      public  static bool Shortedstate = true;


    }

    public class ComboBoxCustom : ComboBox
    {
        public ComboBoxCustom()
        {
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            e.DrawBackground();
            if (-1 != e.Index)
            {



                ComboBoxItem item = (ComboBoxItem)this.Items[e.Index];
                Brush brush = new SolidBrush(item.ForeColor);
                
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                { brush = Brushes.Yellow; }
                e.Graphics.DrawString(item.Text, this.Font, brush, e.Bounds.X, e.Bounds.Y);
            }
        }
    }
    public class ComboBoxItem
    {
        public ComboBoxItem() { }

        public ComboBoxItem(string pText, object pValue)
        {
            text = pText; val = pValue;
        }

        public ComboBoxItem(string pText, object pValue, Color pColor)
        {
            text = pText; val = pValue; foreColor = pColor;
        }

        string text = "";
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        object val;
        public object Value
        {
            get { return val; }
            set { val = value; }
        }

        Color foreColor = Color.Black;
        public Color ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; }
        }

        public override string ToString()
        {
            return text;
        }
    }
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.alexKnife = new ComboBoxCustom();
            this.alexPistol = new ComboBoxCustom();
            this.alexWristband = new ComboBoxCustom();
            this.alexBodyBox = new ComboBoxCustom();
            this.alexMaskBox = new ComboBoxCustom();
            this.alexHeadBox = new ComboBoxCustom();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.changKnife = new ComboBoxCustom();
            this.changPistol = new ComboBoxCustom();
            this.changWist = new ComboBoxCustom();
            this.changBody = new ComboBoxCustom();
            this.changMask = new ComboBoxCustom();
            this.changHead = new ComboBoxCustom();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LisaKnife = new ComboBoxCustom();
            this.lisaPistol = new ComboBoxCustom();
            this.lisaWist = new ComboBoxCustom();
            this.lisaBody = new ComboBoxCustom();
            this.lisaMask = new ComboBoxCustom();
            this.lisaHead = new ComboBoxCustom();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RachelKnife = new ComboBoxCustom();
            this.RachelMask = new ComboBoxCustom();
            this.RachelPistol = new ComboBoxCustom();
            this.RachelHead = new ComboBoxCustom();
            this.RachelWist = new ComboBoxCustom();
            this.RachelBody = new ComboBoxCustom();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.HansKnife = new ComboBoxCustom();
            this.HansPistol = new ComboBoxCustom();
            this.HansWist = new ComboBoxCustom();
            this.HansBody = new ComboBoxCustom();
            this.HansMask = new ComboBoxCustom();
            this.HansHead = new ComboBoxCustom(); ;
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.NinaKnife = new ComboBoxCustom();
            this.NinaPistol = new ComboBoxCustom();
            this.NinaWist = new ComboBoxCustom();
            this.NinaBody = new ComboBoxCustom();
            this.NinaMask = new ComboBoxCustom();
            this.NinaHead = new ComboBoxCustom();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkboxShorted = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 428);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Navy;
            this.tabPage1.Controls.Add(alexKnife); 
            this.tabPage1.Controls.Add(alexPistol);
            this.tabPage1.Controls.Add(alexWristband);
            this.tabPage1.Controls.Add(alexBodyBox);
            this.tabPage1.Controls.Add(alexMaskBox);
            this.tabPage1.Controls.Add(alexHeadBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(822, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alex";
            // 
            // alexKnife
            // 
            this.alexKnife.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.alexKnife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alexKnife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alexKnife.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alexKnife.ForeColor = System.Drawing.Color.Gold;
            this.alexKnife.FormattingEnabled = true;
            this.alexKnife.Location = new System.Drawing.Point(683, 6);
            this.alexKnife.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alexKnife.Name = "alexKnife";
            this.alexKnife.Size = new System.Drawing.Size(127, 21);
            this.alexKnife.Sorted = true;
            this.alexKnife.TabIndex = 5;
            
            // 
            // alexPistol
            // 
            this.alexPistol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.alexPistol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alexPistol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alexPistol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alexPistol.ForeColor = System.Drawing.Color.Gold;
            this.alexPistol.FormattingEnabled = true;
            this.alexPistol.Location = new System.Drawing.Point(549, 6);
            this.alexPistol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alexPistol.Name = "alexPistol";
            this.alexPistol.Size = new System.Drawing.Size(127, 21);
            this.alexPistol.Sorted = true;
            this.alexPistol.TabIndex = 4;
            // 
            // alexWristband
            // 
            this.alexWristband.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.alexWristband.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alexWristband.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alexWristband.DropDownWidth = 137;
            this.alexWristband.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alexWristband.ForeColor = System.Drawing.Color.Gold;
            this.alexWristband.FormattingEnabled = true;
            this.alexWristband.Location = new System.Drawing.Point(413, 6);
            this.alexWristband.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alexWristband.Name = "alexWristband";
            this.alexWristband.Size = new System.Drawing.Size(127, 21);
            this.alexWristband.Sorted = true;
            this.alexWristband.TabIndex = 3;
            // 
            // alexBodyBox
            // 
            this.alexBodyBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.alexBodyBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alexBodyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alexBodyBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alexBodyBox.ForeColor = System.Drawing.Color.Gold;
            this.alexBodyBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.alexBodyBox.Location = new System.Drawing.Point(277, 6);
            this.alexBodyBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alexBodyBox.Name = "alexBodyBox";
            this.alexBodyBox.Size = new System.Drawing.Size(127, 21);
            this.alexBodyBox.Sorted = true;
            this.alexBodyBox.TabIndex = 2;
            // 
            // alexMaskBox
            // 
            this.alexMaskBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.alexMaskBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alexMaskBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alexMaskBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alexMaskBox.ForeColor = System.Drawing.Color.Gold;
            this.alexMaskBox.FormattingEnabled = true;
            this.alexMaskBox.Location = new System.Drawing.Point(143, 6);
            this.alexMaskBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alexMaskBox.Name = "alexMaskBox";
            this.alexMaskBox.Size = new System.Drawing.Size(127, 21);
            this.alexMaskBox.Sorted = true;
            this.alexMaskBox.TabIndex = 1;
            this.alexMaskBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // alexHeadBox
            // 
            this.alexHeadBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.alexHeadBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alexHeadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alexHeadBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alexHeadBox.ForeColor = System.Drawing.Color.Gold;
            this.alexHeadBox.FormattingEnabled = true;
            this.alexHeadBox.Location = new System.Drawing.Point(7, 6);
            this.alexHeadBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.alexHeadBox.Name = "alexHeadBox";
            this.alexHeadBox.Size = new System.Drawing.Size(127, 21);
            this.alexHeadBox.Sorted = true;
            this.alexHeadBox.TabIndex = 0;
            this.alexHeadBox.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Navy;
            this.tabPage2.Controls.Add(changKnife);
            this.tabPage2.Controls.Add(this.changPistol);
            this.tabPage2.Controls.Add(this.changWist);
            this.tabPage2.Controls.Add(this.changBody);
            this.tabPage2.Controls.Add(this.changMask);
            this.tabPage2.Controls.Add(this.changHead);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(822, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chang";
            // 
            // changKnife
            // 
            this.changKnife.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.changKnife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changKnife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changKnife.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changKnife.ForeColor = System.Drawing.Color.Gold;
            this.changKnife.FormattingEnabled = true;
            this.changKnife.Location = new System.Drawing.Point(683, 6);
            this.changKnife.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changKnife.Name = "changKnife";
            this.changKnife.Size = new System.Drawing.Size(127, 21);
            this.changKnife.Sorted = true;
            this.changKnife.TabIndex = 9;
            this.changKnife.Tag = "";
            // 
            // changPistol
            // 
            this.changPistol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.changPistol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changPistol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changPistol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changPistol.ForeColor = System.Drawing.Color.Gold;
            this.changPistol.FormattingEnabled = true;
            this.changPistol.Location = new System.Drawing.Point(549, 6);
            this.changPistol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changPistol.Name = "changPistol";
            this.changPistol.Size = new System.Drawing.Size(127, 21);
            this.changPistol.Sorted = true;
            this.changPistol.TabIndex = 10;
            this.changPistol.Tag = "";
            // 
            // changWist
            // 
            this.changWist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.changWist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changWist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changWist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changWist.ForeColor = System.Drawing.Color.Gold;
            this.changWist.FormattingEnabled = true;
            this.changWist.Location = new System.Drawing.Point(413, 6);
            this.changWist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changWist.Name = "changWist";
            this.changWist.Size = new System.Drawing.Size(127, 21);
            this.changWist.Sorted = true;
            this.changWist.TabIndex = 11;
            this.changWist.Tag = "";
            // 
            // changBody
            // 
            this.changBody.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.changBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changBody.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changBody.ForeColor = System.Drawing.Color.Gold;
            this.changBody.FormattingEnabled = true;
            this.changBody.Location = new System.Drawing.Point(277, 6);
            this.changBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changBody.Name = "changBody";
            this.changBody.Size = new System.Drawing.Size(127, 21);
            this.changBody.Sorted = true;
            this.changBody.TabIndex = 12;
            this.changBody.Tag = "";
            // 
            // changMask
            // 
            this.changMask.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.changMask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changMask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changMask.ForeColor = System.Drawing.Color.Gold;
            this.changMask.FormattingEnabled = true;
            this.changMask.Location = new System.Drawing.Point(143, 6);
            this.changMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changMask.Name = "changMask";
            this.changMask.Size = new System.Drawing.Size(127, 21);
            this.changMask.Sorted = true;
            this.changMask.TabIndex = 8;
            this.changMask.Tag = "";
            // 
            // changHead
            // 
            this.changHead.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.changHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changHead.ForeColor = System.Drawing.Color.Gold;
            this.changHead.FormattingEnabled = true;
            this.changHead.Location = new System.Drawing.Point(7, 6);
            this.changHead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changHead.Name = "changHead";
            this.changHead.Size = new System.Drawing.Size(127, 21);
            this.changHead.Sorted = true;
            this.changHead.TabIndex = 7;
            this.changHead.Tag = "";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Navy;
            this.tabPage3.Controls.Add((Control)this.LisaKnife);
            this.tabPage3.Controls.Add(this.lisaPistol);
            this.tabPage3.Controls.Add(this.lisaWist);
            this.tabPage3.Controls.Add(this.lisaBody);
            this.tabPage3.Controls.Add(this.lisaMask);
            this.tabPage3.Controls.Add(this.lisaHead);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(822, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lisa";
            // 
            // LisaKnife
            // 
            this.LisaKnife.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LisaKnife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LisaKnife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LisaKnife.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LisaKnife.ForeColor = System.Drawing.Color.Gold;
            this.LisaKnife.FormattingEnabled = true;
            this.LisaKnife.Location = new System.Drawing.Point(683, 6);
            this.LisaKnife.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LisaKnife.Name = "LisaKnife";
            this.LisaKnife.Size = new System.Drawing.Size(127, 21);
            this.LisaKnife.Sorted = true;
            this.LisaKnife.TabIndex = 9;
            this.LisaKnife.Tag = "";
            // 
            // lisaPistol
            // 
            this.lisaPistol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lisaPistol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lisaPistol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lisaPistol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lisaPistol.ForeColor = System.Drawing.Color.Gold;
            this.lisaPistol.FormattingEnabled = true;
            this.lisaPistol.Location = new System.Drawing.Point(549, 6);
            this.lisaPistol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lisaPistol.Name = "lisaPistol";
            this.lisaPistol.Size = new System.Drawing.Size(127, 21);
            this.lisaPistol.Sorted = true;
            this.lisaPistol.TabIndex = 10;
            this.lisaPistol.Tag = "";
            // 
            // lisaWist
            // 
            this.lisaWist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lisaWist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lisaWist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lisaWist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lisaWist.ForeColor = System.Drawing.Color.Gold;
            this.lisaWist.FormattingEnabled = true;
            this.lisaWist.Location = new System.Drawing.Point(413, 6);
            this.lisaWist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lisaWist.Name = "lisaWist";
            this.lisaWist.Size = new System.Drawing.Size(127, 21);
            this.lisaWist.Sorted = true;
            this.lisaWist.TabIndex = 11;
            this.lisaWist.Tag = "";
            // 
            // lisaBody
            // 
            this.lisaBody.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lisaBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lisaBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lisaBody.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lisaBody.ForeColor = System.Drawing.Color.Gold;
            this.lisaBody.FormattingEnabled = true;
            this.lisaBody.Location = new System.Drawing.Point(277, 6);
            this.lisaBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lisaBody.Name = "lisaBody";
            this.lisaBody.Size = new System.Drawing.Size(127, 21);
            this.lisaBody.Sorted = true;
            this.lisaBody.TabIndex = 12;
            this.lisaBody.Tag = "";
            // 
            // lisaMask
            // 
            this.lisaMask.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lisaMask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lisaMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lisaMask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lisaMask.ForeColor = System.Drawing.Color.Gold;
            this.lisaMask.FormattingEnabled = true;
            this.lisaMask.Location = new System.Drawing.Point(143, 6);
            this.lisaMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lisaMask.Name = "lisaMask";
            this.lisaMask.Size = new System.Drawing.Size(127, 21);
            this.lisaMask.Sorted = true;
            this.lisaMask.TabIndex = 8;
            this.lisaMask.Tag = "";
            // 
            // lisaHead
            // 
            this.lisaHead.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lisaHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lisaHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lisaHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lisaHead.ForeColor = System.Drawing.Color.Gold;
            this.lisaHead.FormattingEnabled = true;
            this.lisaHead.Location = new System.Drawing.Point(7, 6);
            this.lisaHead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lisaHead.Name = "lisaHead";
            this.lisaHead.Size = new System.Drawing.Size(127, 21);
            this.lisaHead.Sorted = true;
            this.lisaHead.TabIndex = 7;
            this.lisaHead.Tag = "";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Navy;
            this.tabPage4.Controls.Add(this.RachelKnife);
            this.tabPage4.Controls.Add(this.RachelMask);
            this.tabPage4.Controls.Add(this.RachelPistol);
            this.tabPage4.Controls.Add(this.RachelHead);
            this.tabPage4.Controls.Add(this.RachelWist);
            this.tabPage4.Controls.Add(this.RachelBody);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Size = new System.Drawing.Size(822, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rachel";
            // 
            // RachelKnife
            // 
            this.RachelKnife.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RachelKnife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RachelKnife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RachelKnife.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RachelKnife.ForeColor = System.Drawing.Color.Gold;
            this.RachelKnife.FormattingEnabled = true;
            this.RachelKnife.Location = new System.Drawing.Point(683, 6);
            this.RachelKnife.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RachelKnife.Name = "RachelKnife";
            this.RachelKnife.Size = new System.Drawing.Size(127, 21);
            this.RachelKnife.Sorted = true;
            this.RachelKnife.TabIndex = 9;
            this.RachelKnife.Tag = "";
            // 
            // RachelMask
            // 
            this.RachelMask.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RachelMask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RachelMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RachelMask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RachelMask.ForeColor = System.Drawing.Color.Gold;
            this.RachelMask.FormattingEnabled = true;
            this.RachelMask.Location = new System.Drawing.Point(143, 6);
            this.RachelMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RachelMask.Name = "RachelMask";
            this.RachelMask.Size = new System.Drawing.Size(127, 21);
            this.RachelMask.Sorted = true;
            this.RachelMask.TabIndex = 8;
            this.RachelMask.Tag = "";
            // 
            // RachelPistol
            // 
            this.RachelPistol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RachelPistol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RachelPistol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RachelPistol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RachelPistol.ForeColor = System.Drawing.Color.Gold;
            this.RachelPistol.FormattingEnabled = true;
            this.RachelPistol.Location = new System.Drawing.Point(549, 6);
            this.RachelPistol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RachelPistol.Name = "RachelPistol";
            this.RachelPistol.Size = new System.Drawing.Size(127, 21);
            this.RachelPistol.Sorted = true;
            this.RachelPistol.TabIndex = 10;
            this.RachelPistol.Tag = "";
            // 
            // RachelHead
            // 
            this.RachelHead.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RachelHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RachelHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RachelHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RachelHead.ForeColor = System.Drawing.Color.Gold;
            this.RachelHead.FormattingEnabled = true;
            this.RachelHead.Location = new System.Drawing.Point(7, 6);
            this.RachelHead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RachelHead.Name = "RachelHead";
            this.RachelHead.Size = new System.Drawing.Size(127, 21);
            this.RachelHead.Sorted = true;
            this.RachelHead.TabIndex = 7;
            this.RachelHead.Tag = "";
            // 
            // RachelWist
            // 
            this.RachelWist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RachelWist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RachelWist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RachelWist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RachelWist.ForeColor = System.Drawing.Color.Gold;
            this.RachelWist.FormattingEnabled = true;
            this.RachelWist.Location = new System.Drawing.Point(413, 6);
            this.RachelWist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RachelWist.Name = "RachelWist";
            this.RachelWist.Size = new System.Drawing.Size(127, 21);
            this.RachelWist.Sorted = true;
            this.RachelWist.TabIndex = 11;
            this.RachelWist.Tag = "";
            // 
            // RachelBody
            // 
            this.RachelBody.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RachelBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RachelBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RachelBody.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RachelBody.ForeColor = System.Drawing.Color.Gold;
            this.RachelBody.FormattingEnabled = true;
            this.RachelBody.Location = new System.Drawing.Point(277, 6);
            this.RachelBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RachelBody.Name = "RachelBody";
            this.RachelBody.Size = new System.Drawing.Size(127, 21);
            this.RachelBody.Sorted = true;
            this.RachelBody.TabIndex = 12;
            this.RachelBody.Tag = "";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Navy;
            this.tabPage5.Controls.Add(this.HansKnife);
            this.tabPage5.Controls.Add(this.HansPistol);
            this.tabPage5.Controls.Add(this.HansWist);
            this.tabPage5.Controls.Add(this.HansBody);
            this.tabPage5.Controls.Add(this.HansMask);
            this.tabPage5.Controls.Add(this.HansHead);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage5.Size = new System.Drawing.Size(822, 402);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hans";
            // 
            // HansKnife
            // 
            this.HansKnife.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HansKnife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HansKnife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HansKnife.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HansKnife.ForeColor = System.Drawing.Color.Gold;
            this.HansKnife.FormattingEnabled = true;
            this.HansKnife.Location = new System.Drawing.Point(683, 6);
            this.HansKnife.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HansKnife.Name = "HansKnife";
            this.HansKnife.Size = new System.Drawing.Size(127, 21);
            this.HansKnife.Sorted = true;
            this.HansKnife.TabIndex = 9;
            this.HansKnife.Tag = "";
            // 
            // HansPistol
            // 
            this.HansPistol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HansPistol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HansPistol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HansPistol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HansPistol.ForeColor = System.Drawing.Color.Gold;
            this.HansPistol.FormattingEnabled = true;
            this.HansPistol.Location = new System.Drawing.Point(549, 6);
            this.HansPistol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HansPistol.Name = "HansPistol";
            this.HansPistol.Size = new System.Drawing.Size(127, 21);
            this.HansPistol.Sorted = true;
            this.HansPistol.TabIndex = 10;
            this.HansPistol.Tag = "";
            // 
            // HansWist
            // 
            this.HansWist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HansWist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HansWist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HansWist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HansWist.ForeColor = System.Drawing.Color.Gold;
            this.HansWist.FormattingEnabled = true;
            this.HansWist.Location = new System.Drawing.Point(413, 6);
            this.HansWist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HansWist.Name = "HansWist";
            this.HansWist.Size = new System.Drawing.Size(127, 21);
            this.HansWist.Sorted = true;
            this.HansWist.TabIndex = 11;
            this.HansWist.Tag = "";
            // 
            // HansBody
            // 
            this.HansBody.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HansBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HansBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HansBody.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HansBody.ForeColor = System.Drawing.Color.Gold;
            this.HansBody.FormattingEnabled = true;
            this.HansBody.Location = new System.Drawing.Point(277, 6);
            this.HansBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HansBody.Name = "HansBody";
            this.HansBody.Size = new System.Drawing.Size(127, 21);
            this.HansBody.Sorted = true;
            this.HansBody.TabIndex = 12;
            this.HansBody.Tag = "";
            // 
            // HansMask
            // 
            this.HansMask.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HansMask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HansMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HansMask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HansMask.ForeColor = System.Drawing.Color.Gold;
            this.HansMask.FormattingEnabled = true;
            this.HansMask.Location = new System.Drawing.Point(143, 6);
            this.HansMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HansMask.Name = "HansMask";
            this.HansMask.Size = new System.Drawing.Size(127, 21);
            this.HansMask.Sorted = true;
            this.HansMask.TabIndex = 8;
            this.HansMask.Tag = "";
            // 
            // HansHead
            // 
            this.HansHead.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HansHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HansHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HansHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HansHead.ForeColor = System.Drawing.Color.Gold;
            this.HansHead.FormattingEnabled = true;
            this.HansHead.Location = new System.Drawing.Point(7, 6);
            this.HansHead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HansHead.Name = "HansHead";
            this.HansHead.Size = new System.Drawing.Size(127, 21);
            this.HansHead.Sorted = true;
            this.HansHead.TabIndex = 7;
            this.HansHead.Tag = "";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Navy;
            this.tabPage6.Controls.Add(this.NinaKnife);
            this.tabPage6.Controls.Add(this.NinaPistol);
            this.tabPage6.Controls.Add(this.NinaWist);
            this.tabPage6.Controls.Add(this.NinaBody);
            this.tabPage6.Controls.Add(this.NinaMask);
            this.tabPage6.Controls.Add(this.NinaHead);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage6.Size = new System.Drawing.Size(822, 402);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Nina";
            // 
            // NinaKnife
            // 
            this.NinaKnife.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NinaKnife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NinaKnife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NinaKnife.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NinaKnife.ForeColor = System.Drawing.Color.Gold;
            this.NinaKnife.FormattingEnabled = true;
            this.NinaKnife.Location = new System.Drawing.Point(683, 6);
            this.NinaKnife.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NinaKnife.Name = "NinaKnife";
            this.NinaKnife.Size = new System.Drawing.Size(127, 21);
            this.NinaKnife.Sorted = true;
            this.NinaKnife.TabIndex = 9;
            this.NinaKnife.Tag = "";
            // 
            // NinaPistol
            // 
            this.NinaPistol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NinaPistol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NinaPistol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NinaPistol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NinaPistol.ForeColor = System.Drawing.Color.Gold;
            this.NinaPistol.FormattingEnabled = true;
            this.NinaPistol.Location = new System.Drawing.Point(549, 6);
            this.NinaPistol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NinaPistol.Name = "NinaPistol";
            this.NinaPistol.Size = new System.Drawing.Size(127, 21);
            this.NinaPistol.Sorted = true;
            this.NinaPistol.TabIndex = 10;
            this.NinaPistol.Tag = "";
            // 
            // NinaWist
            // 
            this.NinaWist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NinaWist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NinaWist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NinaWist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NinaWist.ForeColor = System.Drawing.Color.Gold;
            this.NinaWist.FormattingEnabled = true;
            this.NinaWist.Location = new System.Drawing.Point(413, 6);
            this.NinaWist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NinaWist.Name = "NinaWist";
            this.NinaWist.Size = new System.Drawing.Size(127, 21);
            this.NinaWist.Sorted = true;
            this.NinaWist.TabIndex = 11;
            this.NinaWist.Tag = "";
            // 
            // NinaBody
            // 
            this.NinaBody.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NinaBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NinaBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NinaBody.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NinaBody.ForeColor = System.Drawing.Color.Gold;
            this.NinaBody.FormattingEnabled = true;
            this.NinaBody.Location = new System.Drawing.Point(277, 6);
            this.NinaBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NinaBody.Name = "NinaBody";
            this.NinaBody.Size = new System.Drawing.Size(127, 21);
            this.NinaBody.Sorted = true;
            this.NinaBody.TabIndex = 12;
            this.NinaBody.Tag = "";
            // 
            // NinaMask
            // 
            this.NinaMask.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NinaMask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NinaMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NinaMask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NinaMask.ForeColor = System.Drawing.Color.Gold;
            this.NinaMask.FormattingEnabled = true;
            this.NinaMask.Location = new System.Drawing.Point(143, 6);
            this.NinaMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NinaMask.Name = "NinaMask";
            this.NinaMask.Size = new System.Drawing.Size(127, 21);
            this.NinaMask.Sorted = true;
            this.NinaMask.TabIndex = 8;
            this.NinaMask.Tag = "";
            // 
            // NinaHead
            // 
            this.NinaHead.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NinaHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NinaHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NinaHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NinaHead.ForeColor = System.Drawing.Color.Gold;
            this.NinaHead.FormattingEnabled = true;
            this.NinaHead.Location = new System.Drawing.Point(7, 6);
            this.NinaHead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NinaHead.Name = "NinaHead";
            this.NinaHead.Size = new System.Drawing.Size(127, 21);
            this.NinaHead.Sorted = true;
            this.NinaHead.TabIndex = 7;
            this.NinaHead.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.FormattingEnabled = true;
            this.label1.Location = new System.Drawing.Point(158, 451);

            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.Sorted = true;
            this.label1.TabIndex = 9;
            this.label1.Tag = "";
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.MaxLength = 0;
            this.label1.Visible = false;

            this.label1.TabIndex = 2;
            this.label1.Text = "Output Here!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(846, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Text = "Made By Japrajah!";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // checkboxShorted
            // 
            this.checkboxShorted.AutoSize = true;
            this.checkboxShorted.Checked = true;
            this.checkboxShorted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxShorted.Enabled = false;
            this.checkboxShorted.ForeColor = System.Drawing.Color.Yellow;
            this.checkboxShorted.Location = new System.Drawing.Point(318, 12);
            this.checkboxShorted.Name = "checkboxShorted";
            this.checkboxShorted.Size = new System.Drawing.Size(70, 17);
            this.checkboxShorted.TabIndex = 4;
            this.checkboxShorted.Text = "Shorted";
            this.checkboxShorted.UseVisualStyleBackColor = true;
            this.checkboxShorted.CheckedChanged += new System.EventHandler(this.checkboxShorted_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1068, 481);
            this.Controls.Add(this.checkboxShorted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "skinchanger.cfg editor by Japrajah";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ComboBoxCustom alexHeadBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private ComboBoxCustom alexKnife;
        private ComboBoxCustom alexPistol;
        private ComboBoxCustom alexWristband;
        private ComboBoxCustom alexBodyBox;
        private ComboBoxCustom alexMaskBox;
        private ComboBoxCustom changKnife;
        private ComboBoxCustom changPistol;
        private ComboBoxCustom changWist;
        private ComboBoxCustom changBody;
        private ComboBoxCustom changMask;
        private ComboBoxCustom changHead;
        private ComboBoxCustom LisaKnife;
        private ComboBoxCustom lisaPistol;
        private ComboBoxCustom lisaWist;
        private ComboBoxCustom lisaBody;
        private ComboBoxCustom lisaMask;
        private ComboBoxCustom lisaHead;
        private ComboBoxCustom RachelKnife;
        private ComboBoxCustom RachelMask;
        private ComboBoxCustom RachelPistol;
        private ComboBoxCustom RachelHead;
        private ComboBoxCustom RachelWist;
        private ComboBoxCustom RachelBody;
        private ComboBoxCustom HansKnife;
        private ComboBoxCustom HansPistol;
        private ComboBoxCustom HansWist;
        private ComboBoxCustom HansBody;
        private ComboBoxCustom HansMask;
        private ComboBoxCustom HansHead;
        private ComboBoxCustom NinaKnife;
        private ComboBoxCustom NinaPistol;
        private ComboBoxCustom NinaWist;
        private ComboBoxCustom NinaBody;
        private ComboBoxCustom NinaMask;
        private ComboBoxCustom NinaHead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkboxShorted;
    }
    
}


