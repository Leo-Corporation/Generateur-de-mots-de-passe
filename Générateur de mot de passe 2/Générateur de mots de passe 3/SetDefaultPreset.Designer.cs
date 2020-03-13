﻿namespace Générateur_de_mots_de_passe_3
{
    partial class SetDefaultPreset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetDefaultPreset));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton5 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 33);
            this.panel1.TabIndex = 0;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(215, 2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(7, 5);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(187, 23);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Préréglage par défaut";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gunaLabel2.Location = new System.Drawing.Point(10, 38);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(197, 20);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Sélectionnez un préréglage";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Simple",
            "Complexe",
            "Personnalisé"});
            this.gunaComboBox1.Location = new System.Drawing.Point(13, 74);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.CornflowerBlue;
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 5;
            this.gunaComboBox1.Size = new System.Drawing.Size(240, 28);
            this.gunaComboBox1.TabIndex = 4;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::Générateur_de_mots_de_passe_3.Properties.Resources.icons8_multiply_100px;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.CornflowerBlue;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(143, 116);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Crimson;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 15;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(109, 30);
            this.gunaAdvenceButton1.TabIndex = 8;
            this.gunaAdvenceButton1.Text = "Annuler";
            this.gunaAdvenceButton1.TextOffsetX = -4;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // gunaAdvenceButton5
            // 
            this.gunaAdvenceButton5.Animated = true;
            this.gunaAdvenceButton5.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton5.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton5.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.gunaAdvenceButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton5.CheckedImage")));
            this.gunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton5.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.Image = global::Générateur_de_mots_de_passe_3.Properties.Resources.icons8_checkmark_100px;
            this.gunaAdvenceButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton5.LineColor = System.Drawing.Color.CornflowerBlue;
            this.gunaAdvenceButton5.Location = new System.Drawing.Point(14, 116);
            this.gunaAdvenceButton5.Name = "gunaAdvenceButton5";
            this.gunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.gunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.OnHoverImage = null;
            this.gunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.Radius = 15;
            this.gunaAdvenceButton5.Size = new System.Drawing.Size(123, 30);
            this.gunaAdvenceButton5.TabIndex = 9;
            this.gunaAdvenceButton5.Text = "Enregistrer";
            this.gunaAdvenceButton5.TextOffsetX = -4;
            this.gunaAdvenceButton5.Click += new System.EventHandler(this.gunaAdvenceButton5_Click);
            // 
            // SetDefaultPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(266, 158);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.gunaAdvenceButton5);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetDefaultPreset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetDefaultPreset";
            this.Load += new System.EventHandler(this.SetDefaultPreset_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton5;
    }
}