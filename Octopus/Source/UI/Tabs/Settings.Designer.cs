﻿namespace Octopus
{
    partial class Settings
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_hotkey = new System.Windows.Forms.Label();
            this.checkbox_hidehotkey = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.checkbox_hide = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_topmost = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.SuspendLayout();
            // 
            // label_hotkey
            // 
            this.label_hotkey.AutoSize = true;
            this.label_hotkey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hotkey.ForeColor = System.Drawing.Color.White;
            this.label_hotkey.Location = new System.Drawing.Point(38, 12);
            this.label_hotkey.Name = "label_hotkey";
            this.label_hotkey.Size = new System.Drawing.Size(142, 20);
            this.label_hotkey.TabIndex = 28;
            this.label_hotkey.Text = "Hide Hotkey [None]";
            // 
            // checkbox_hidehotkey
            // 
            this.checkbox_hidehotkey.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_hidehotkey.CheckedState.BorderRadius = 0;
            this.checkbox_hidehotkey.CheckedState.BorderThickness = 1;
            this.checkbox_hidehotkey.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_hidehotkey.CheckedState.Parent = this.checkbox_hidehotkey;
            this.checkbox_hidehotkey.Location = new System.Drawing.Point(12, 12);
            this.checkbox_hidehotkey.Name = "checkbox_hidehotkey";
            this.checkbox_hidehotkey.ShadowDecoration.Parent = this.checkbox_hidehotkey;
            this.checkbox_hidehotkey.Size = new System.Drawing.Size(20, 20);
            this.checkbox_hidehotkey.TabIndex = 27;
            this.checkbox_hidehotkey.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_hidehotkey.UncheckedState.BorderRadius = 0;
            this.checkbox_hidehotkey.UncheckedState.BorderThickness = 1;
            this.checkbox_hidehotkey.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_hidehotkey.UncheckedState.Parent = this.checkbox_hidehotkey;
            this.checkbox_hidehotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkbox_hidehotkey_KeyDown);
            // 
            // checkbox_hide
            // 
            this.checkbox_hide.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_hide.CheckedState.BorderRadius = 0;
            this.checkbox_hide.CheckedState.BorderThickness = 1;
            this.checkbox_hide.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_hide.CheckedState.Parent = this.checkbox_hide;
            this.checkbox_hide.Location = new System.Drawing.Point(378, 12);
            this.checkbox_hide.Name = "checkbox_hide";
            this.checkbox_hide.ShadowDecoration.Parent = this.checkbox_hide;
            this.checkbox_hide.Size = new System.Drawing.Size(20, 20);
            this.checkbox_hide.TabIndex = 29;
            this.checkbox_hide.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_hide.UncheckedState.BorderRadius = 0;
            this.checkbox_hide.UncheckedState.BorderThickness = 1;
            this.checkbox_hide.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_hide.UncheckedState.Parent = this.checkbox_hide;
            this.checkbox_hide.Visible = false;
            this.checkbox_hide.CheckedChanged += new System.EventHandler(this.checkbox_hide_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Top Most";
            // 
            // checkbox_topmost
            // 
            this.checkbox_topmost.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_topmost.CheckedState.BorderRadius = 0;
            this.checkbox_topmost.CheckedState.BorderThickness = 1;
            this.checkbox_topmost.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_topmost.CheckedState.Parent = this.checkbox_topmost;
            this.checkbox_topmost.Location = new System.Drawing.Point(12, 38);
            this.checkbox_topmost.Name = "checkbox_topmost";
            this.checkbox_topmost.ShadowDecoration.Parent = this.checkbox_topmost;
            this.checkbox_topmost.Size = new System.Drawing.Size(20, 20);
            this.checkbox_topmost.TabIndex = 30;
            this.checkbox_topmost.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.checkbox_topmost.UncheckedState.BorderRadius = 0;
            this.checkbox_topmost.UncheckedState.BorderThickness = 1;
            this.checkbox_topmost.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkbox_topmost.UncheckedState.Parent = this.checkbox_topmost;
            this.checkbox_topmost.CheckedChanged += new System.EventHandler(this.checkbox_topmost_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbox_topmost);
            this.Controls.Add(this.checkbox_hide);
            this.Controls.Add(this.label_hotkey);
            this.Controls.Add(this.checkbox_hidehotkey);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(410, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_hotkey;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_hidehotkey;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_hide;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox checkbox_topmost;
    }
}
