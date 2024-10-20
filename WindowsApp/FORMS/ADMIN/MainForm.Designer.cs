﻿namespace WindowsApp.FORMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productImageList = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Subtotallabl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PayBTN = new System.Windows.Forms.Button();
            this.GenerateBTN = new System.Windows.Forms.Button();
            this.PrintBUTTON = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.PurchaseListView = new System.Windows.Forms.ListView();
            this.ProductImages = new System.Windows.Forms.ImageList(this.components);
            this.flpProductMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Order = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.productImageList.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.productImageList);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 701);
            this.panel1.TabIndex = 0;
            // 
            // productImageList
            // 
            this.productImageList.BackColor = System.Drawing.Color.White;
            this.productImageList.Controls.Add(this.SearchBox);
            this.productImageList.Controls.Add(this.button1);
            this.productImageList.Controls.Add(this.panel5);
            this.productImageList.Controls.Add(this.lb_Order);
            this.productImageList.Location = new System.Drawing.Point(12, 12);
            this.productImageList.Name = "productImageList";
            this.productImageList.Size = new System.Drawing.Size(1326, 677);
            this.productImageList.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BackColor = System.Drawing.SystemColors.Menu;
            this.SearchBox.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchBox.Location = new System.Drawing.Point(52, 15);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SearchBox.Size = new System.Drawing.Size(487, 27);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(20, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 27);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.flpProductMain);
            this.panel5.Location = new System.Drawing.Point(7, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1316, 615);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(780, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 160);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblTax);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Subtotallabl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(293, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 124);
            this.panel2.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(113, 91);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 24);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "00.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(127, 48);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(47, 20);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "00.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOTAL:";
            // 
            // Subtotallabl
            // 
            this.Subtotallabl.AutoSize = true;
            this.Subtotallabl.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotallabl.Location = new System.Drawing.Point(127, 13);
            this.Subtotallabl.Name = "Subtotallabl";
            this.Subtotallabl.Size = new System.Drawing.Size(47, 20);
            this.Subtotallabl.TabIndex = 7;
            this.Subtotallabl.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tax:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subtotal: ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.PayBTN);
            this.panel6.Controls.Add(this.GenerateBTN);
            this.panel6.Controls.Add(this.PrintBUTTON);
            this.panel6.Location = new System.Drawing.Point(10, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(277, 132);
            this.panel6.TabIndex = 11;
            // 
            // PayBTN
            // 
            this.PayBTN.BackColor = System.Drawing.Color.Maroon;
            this.PayBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayBTN.FlatAppearance.BorderSize = 0;
            this.PayBTN.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PayBTN.Location = new System.Drawing.Point(6, 21);
            this.PayBTN.Name = "PayBTN";
            this.PayBTN.Size = new System.Drawing.Size(257, 44);
            this.PayBTN.TabIndex = 4;
            this.PayBTN.Text = "Pay";
            this.PayBTN.UseVisualStyleBackColor = false;
            this.PayBTN.Click += new System.EventHandler(this.PayBTN_Click);
            // 
            // GenerateBTN
            // 
            this.GenerateBTN.BackColor = System.Drawing.Color.Maroon;
            this.GenerateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateBTN.FlatAppearance.BorderSize = 0;
            this.GenerateBTN.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GenerateBTN.Location = new System.Drawing.Point(6, 71);
            this.GenerateBTN.Name = "GenerateBTN";
            this.GenerateBTN.Size = new System.Drawing.Size(127, 44);
            this.GenerateBTN.TabIndex = 15;
            this.GenerateBTN.Text = "Print Preview";
            this.GenerateBTN.UseVisualStyleBackColor = false;
            this.GenerateBTN.Click += new System.EventHandler(this.GenerateBTN_Click);
            // 
            // PrintBUTTON
            // 
            this.PrintBUTTON.BackColor = System.Drawing.Color.Maroon;
            this.PrintBUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBUTTON.FlatAppearance.BorderSize = 0;
            this.PrintBUTTON.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBUTTON.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrintBUTTON.Location = new System.Drawing.Point(139, 71);
            this.PrintBUTTON.Name = "PrintBUTTON";
            this.PrintBUTTON.Size = new System.Drawing.Size(124, 44);
            this.PrintBUTTON.TabIndex = 13;
            this.PrintBUTTON.Text = "Print";
            this.PrintBUTTON.UseVisualStyleBackColor = false;
            this.PrintBUTTON.Click += new System.EventHandler(this.PrintBUTTON_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btnClearAll);
            this.panel3.Controls.Add(this.PurchaseListView);
            this.panel3.Location = new System.Drawing.Point(780, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 440);
            this.panel3.TabIndex = 1;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAll.Location = new System.Drawing.Point(422, 398);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(97, 30);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "     Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click_1);
            // 
            // PurchaseListView
            // 
            this.PurchaseListView.HideSelection = false;
            this.PurchaseListView.Location = new System.Drawing.Point(8, 3);
            this.PurchaseListView.Name = "PurchaseListView";
            this.PurchaseListView.Size = new System.Drawing.Size(511, 389);
            this.PurchaseListView.SmallImageList = this.ProductImages;
            this.PurchaseListView.TabIndex = 4;
            this.PurchaseListView.UseCompatibleStateImageBehavior = false;
            this.PurchaseListView.View = System.Windows.Forms.View.List;
            // 
            // ProductImages
            // 
            this.ProductImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ProductImages.ImageSize = new System.Drawing.Size(16, 16);
            this.ProductImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flpProductMain
            // 
            this.flpProductMain.AutoScroll = true;
            this.flpProductMain.BackColor = System.Drawing.Color.Gainsboro;
            this.flpProductMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpProductMain.Location = new System.Drawing.Point(3, 3);
            this.flpProductMain.Name = "flpProductMain";
            this.flpProductMain.Size = new System.Drawing.Size(771, 606);
            this.flpProductMain.TabIndex = 0;
            // 
            // lb_Order
            // 
            this.lb_Order.AutoSize = true;
            this.lb_Order.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Order.Location = new System.Drawing.Point(799, 22);
            this.lb_Order.Name = "lb_Order";
            this.lb_Order.Size = new System.Drawing.Size(161, 24);
            this.lb_Order.TabIndex = 3;
            this.lb_Order.Text = "CURRENT ORDER";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.productImageList.ResumeLayout(false);
            this.productImageList.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel productImageList;
        private System.Windows.Forms.Label lb_Order;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
      
        private System.Windows.Forms.ListView PurchaseListView;
        private System.Windows.Forms.ImageList ProductImages;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PrintBUTTON;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PayBTN;
        private System.Windows.Forms.Label Subtotallabl;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button GenerateBTN;
        private System.Windows.Forms.FlowLayoutPanel flpProductMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}