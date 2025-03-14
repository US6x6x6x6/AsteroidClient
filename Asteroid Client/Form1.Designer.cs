using System.Drawing;
using System.Windows.Forms;

namespace Asteroid_Client
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.executebutton = new Guna.UI2.WinForms.Guna2Button();
            this.injectbutton = new Guna.UI2.WinForms.Guna2Button();
            this.savefilebutton = new Guna.UI2.WinForms.Guna2Button();
            this.loadbutton = new Guna.UI2.WinForms.Guna2Button();
            this.clearbutton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Editor = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(101, 30);
            this.Title.TabIndex = 0;
            this.Title.Text = "Asteroid";
            // 
            // executebutton
            // 
            this.executebutton.BorderRadius = 5;
            this.executebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.executebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.executebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.executebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.executebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.executebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executebutton.ForeColor = System.Drawing.Color.White;
            this.executebutton.Location = new System.Drawing.Point(15, 352);
            this.executebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.executebutton.Name = "executebutton";
            this.executebutton.Size = new System.Drawing.Size(104, 27);
            this.executebutton.TabIndex = 1;
            this.executebutton.Text = "Execute";
            this.executebutton.Click += new System.EventHandler(this.executebutton_Click);
            // 
            // injectbutton
            // 
            this.injectbutton.BorderRadius = 5;
            this.injectbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.injectbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.injectbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.injectbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.injectbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.injectbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectbutton.ForeColor = System.Drawing.Color.White;
            this.injectbutton.Location = new System.Drawing.Point(702, 352);
            this.injectbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.injectbutton.Name = "injectbutton";
            this.injectbutton.Size = new System.Drawing.Size(104, 27);
            this.injectbutton.TabIndex = 2;
            this.injectbutton.Text = "Attach";
            this.injectbutton.Click += new System.EventHandler(this.injectbutton_Click);
            // 
            // savefilebutton
            // 
            this.savefilebutton.BorderRadius = 5;
            this.savefilebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.savefilebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.savefilebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.savefilebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.savefilebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.savefilebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savefilebutton.ForeColor = System.Drawing.Color.White;
            this.savefilebutton.Location = new System.Drawing.Point(235, 352);
            this.savefilebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savefilebutton.Name = "savefilebutton";
            this.savefilebutton.Size = new System.Drawing.Size(104, 27);
            this.savefilebutton.TabIndex = 3;
            this.savefilebutton.Text = "Save File";
            this.savefilebutton.Click += new System.EventHandler(this.savefilebutton_Click);
            // 
            // loadbutton
            // 
            this.loadbutton.BorderRadius = 5;
            this.loadbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loadbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.loadbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbutton.ForeColor = System.Drawing.Color.White;
            this.loadbutton.Location = new System.Drawing.Point(345, 352);
            this.loadbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(104, 27);
            this.loadbutton.TabIndex = 4;
            this.loadbutton.Text = "Load File";
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BorderRadius = 5;
            this.clearbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.clearbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.White;
            this.clearbutton.Location = new System.Drawing.Point(125, 352);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(104, 27);
            this.clearbutton.TabIndex = 5;
            this.clearbutton.Text = "Clear";
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 49);
            this.panel1.TabIndex = 7;
            // 
            // CloseButton
            // 
            this.CloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(772, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(36, 33);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Editor
            // 
            this.Editor.AllowExternalDrop = true;
            this.Editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Editor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Editor.CreationProperties = null;
            this.Editor.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.Editor.ForeColor = System.Drawing.Color.Transparent;
            this.Editor.Location = new System.Drawing.Point(15, 52);
            this.Editor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(791, 296);
            this.Editor.TabIndex = 8;
            this.Editor.ZoomFactor = 1D;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(818, 390);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.savefilebutton);
            this.Controls.Add(this.injectbutton);
            this.Controls.Add(this.executebutton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Asteroid Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label Title;
        private Guna.UI2.WinForms.Guna2Button executebutton;
        private Guna.UI2.WinForms.Guna2Button clearbutton;
        private Guna.UI2.WinForms.Guna2Button loadbutton;
        private Guna.UI2.WinForms.Guna2Button savefilebutton;
        private Guna.UI2.WinForms.Guna2Button injectbutton;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Microsoft.Web.WebView2.WinForms.WebView2 Editor;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
    }
}

