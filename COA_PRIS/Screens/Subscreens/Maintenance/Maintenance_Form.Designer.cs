﻿namespace COA_PRIS.Screens.Subscreens.Maintenance
{
    partial class Maintenance_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.top_Panel = new Guna.UI.WinForms.GunaPanel();
            this.control_Panel_Left = new System.Windows.Forms.FlowLayoutPanel();
            this.search_Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.right_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.delete_Btn = new Guna.UI.WinForms.GunaButton();
            this.view_Btn = new Guna.UI.WinForms.GunaButton();
            this.add_Btn = new Guna.UI.WinForms.GunaButton();
            this.table_Panel = new Guna.UI.WinForms.GunaPanel();
            this.data_View = new Guna.UI.WinForms.GunaDataGridView();
            this.top_Panel.SuspendLayout();
            this.control_Panel_Left.SuspendLayout();
            this.right_Panel.SuspendLayout();
            this.table_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 756);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(1346, 40);
            this.gunaPanel3.TabIndex = 2;
            // 
            // top_Panel
            // 
            this.top_Panel.Controls.Add(this.control_Panel_Left);
            this.top_Panel.Controls.Add(this.right_Panel);
            this.top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Panel.Location = new System.Drawing.Point(0, 0);
            this.top_Panel.Name = "top_Panel";
            this.top_Panel.Size = new System.Drawing.Size(1346, 58);
            this.top_Panel.TabIndex = 3;
            // 
            // control_Panel_Left
            // 
            this.control_Panel_Left.AutoSize = true;
            this.control_Panel_Left.BackColor = System.Drawing.Color.Transparent;
            this.control_Panel_Left.Controls.Add(this.search_Panel);
            this.control_Panel_Left.Controls.Add(this.gunaButton3);
            this.control_Panel_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Panel_Left.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.control_Panel_Left.Location = new System.Drawing.Point(0, 0);
            this.control_Panel_Left.Margin = new System.Windows.Forms.Padding(0);
            this.control_Panel_Left.Name = "control_Panel_Left";
            this.control_Panel_Left.Size = new System.Drawing.Size(954, 58);
            this.control_Panel_Left.TabIndex = 4;
            // 
            // search_Panel
            // 
            this.search_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_Panel.BackColor = System.Drawing.Color.Transparent;
            this.search_Panel.BaseColor = System.Drawing.Color.White;
            this.search_Panel.Location = new System.Drawing.Point(0, 0);
            this.search_Panel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.search_Panel.Name = "search_Panel";
            this.search_Panel.Size = new System.Drawing.Size(350, 50);
            this.search_Panel.TabIndex = 1;
            // 
            // gunaButton3
            // 
            this.gunaButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = global::COA_PRIS.Properties.Resources.refresh__1_;
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton3.Location = new System.Drawing.Point(358, 0);
            this.gunaButton3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 8;
            this.gunaButton3.Size = new System.Drawing.Size(50, 50);
            this.gunaButton3.TabIndex = 1;
            // 
            // right_Panel
            // 
            this.right_Panel.AutoSize = true;
            this.right_Panel.BackColor = System.Drawing.Color.Transparent;
            this.right_Panel.Controls.Add(this.delete_Btn);
            this.right_Panel.Controls.Add(this.view_Btn);
            this.right_Panel.Controls.Add(this.add_Btn);
            this.right_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_Panel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.right_Panel.Location = new System.Drawing.Point(954, 0);
            this.right_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.right_Panel.Name = "right_Panel";
            this.right_Panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.right_Panel.Size = new System.Drawing.Size(392, 58);
            this.right_Panel.TabIndex = 4;
            // 
            // delete_Btn
            // 
            this.delete_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_Btn.AnimationHoverSpeed = 0.07F;
            this.delete_Btn.AnimationSpeed = 0.03F;
            this.delete_Btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.delete_Btn.BorderColor = System.Drawing.Color.Black;
            this.delete_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.delete_Btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Btn.ForeColor = System.Drawing.Color.White;
            this.delete_Btn.Image = global::COA_PRIS.Properties.Resources.trash_bin;
            this.delete_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete_Btn.ImageOffsetX = 5;
            this.delete_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.delete_Btn.Location = new System.Drawing.Point(342, 0);
            this.delete_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.delete_Btn.Name = "delete_Btn";
            this.delete_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.delete_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.delete_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.delete_Btn.OnHoverImage = null;
            this.delete_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.delete_Btn.Radius = 8;
            this.delete_Btn.Size = new System.Drawing.Size(50, 50);
            this.delete_Btn.TabIndex = 3;
            this.delete_Btn.TextOffsetX = -5;
            // 
            // view_Btn
            // 
            this.view_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.view_Btn.AnimationHoverSpeed = 0.07F;
            this.view_Btn.AnimationSpeed = 0.03F;
            this.view_Btn.BackColor = System.Drawing.Color.Transparent;
            this.view_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.view_Btn.BorderColor = System.Drawing.Color.Black;
            this.view_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.view_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.view_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.view_Btn.ForeColor = System.Drawing.Color.White;
            this.view_Btn.Image = global::COA_PRIS.Properties.Resources.view_file;
            this.view_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.view_Btn.Location = new System.Drawing.Point(171, 0);
            this.view_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.view_Btn.Name = "view_Btn";
            this.view_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.view_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.view_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.view_Btn.OnHoverImage = null;
            this.view_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.view_Btn.Radius = 8;
            this.view_Btn.Size = new System.Drawing.Size(163, 50);
            this.view_Btn.TabIndex = 2;
            this.view_Btn.Text = "View Record";
            this.view_Btn.TextOffsetX = -5;
            // 
            // add_Btn
            // 
            this.add_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Btn.AnimationHoverSpeed = 0.07F;
            this.add_Btn.AnimationSpeed = 0.03F;
            this.add_Btn.BackColor = System.Drawing.Color.Transparent;
            this.add_Btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(115)))), ((int)(((byte)(87)))));
            this.add_Btn.BorderColor = System.Drawing.Color.Black;
            this.add_Btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add_Btn.FocusedColor = System.Drawing.Color.Empty;
            this.add_Btn.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_Btn.ForeColor = System.Drawing.Color.White;
            this.add_Btn.Image = global::COA_PRIS.Properties.Resources.add_file;
            this.add_Btn.ImageSize = new System.Drawing.Size(30, 30);
            this.add_Btn.Location = new System.Drawing.Point(8, 0);
            this.add_Btn.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.add_Btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add_Btn.OnHoverForeColor = System.Drawing.Color.White;
            this.add_Btn.OnHoverImage = null;
            this.add_Btn.OnPressedColor = System.Drawing.Color.Black;
            this.add_Btn.Radius = 8;
            this.add_Btn.Size = new System.Drawing.Size(155, 50);
            this.add_Btn.TabIndex = 1;
            this.add_Btn.Text = "Add Record";
            this.add_Btn.TextOffsetX = -5;
            // 
            // table_Panel
            // 
            this.table_Panel.BackColor = System.Drawing.Color.DimGray;
            this.table_Panel.Controls.Add(this.data_View);
            this.table_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_Panel.Location = new System.Drawing.Point(0, 58);
            this.table_Panel.Name = "table_Panel";
            this.table_Panel.Size = new System.Drawing.Size(1346, 698);
            this.table_Panel.TabIndex = 4;
            // 
            // data_View
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.data_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_View.BackgroundColor = System.Drawing.Color.White;
            this.data_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_View.EnableHeadersVisualStyles = false;
            this.data_View.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.data_View.Location = new System.Drawing.Point(0, 0);
            this.data_View.Name = "data_View";
            this.data_View.RowHeadersVisible = false;
            this.data_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_View.Size = new System.Drawing.Size(1346, 698);
            this.data_View.TabIndex = 0;
            this.data_View.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald;
            this.data_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.data_View.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_View.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.data_View.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.data_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.data_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_View.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data_View.ThemeStyle.HeaderStyle.Height = 23;
            this.data_View.ThemeStyle.ReadOnly = false;
            this.data_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.data_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_View.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.data_View.ThemeStyle.RowsStyle.Height = 22;
            this.data_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.data_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Maintenance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1346, 796);
            this.Controls.Add(this.table_Panel);
            this.Controls.Add(this.top_Panel);
            this.Controls.Add(this.gunaPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maintenance_Form";
            this.Text = "Maintenance_Form";
            this.Load += new System.EventHandler(this.Maintenance_Form_Load);
            this.top_Panel.ResumeLayout(false);
            this.top_Panel.PerformLayout();
            this.control_Panel_Left.ResumeLayout(false);
            this.right_Panel.ResumeLayout(false);
            this.table_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel top_Panel;
        private System.Windows.Forms.FlowLayoutPanel control_Panel_Left;
        private Guna.UI.WinForms.GunaElipsePanel search_Panel;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private System.Windows.Forms.FlowLayoutPanel right_Panel;
        private Guna.UI.WinForms.GunaButton delete_Btn;
        private Guna.UI.WinForms.GunaButton view_Btn;
        private Guna.UI.WinForms.GunaButton add_Btn;
        private Guna.UI.WinForms.GunaPanel table_Panel;
        private Guna.UI.WinForms.GunaDataGridView data_View;
    }
}