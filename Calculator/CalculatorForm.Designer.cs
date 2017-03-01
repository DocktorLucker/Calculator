using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.CeButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.OneDivideXButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ExpressionLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMenuItem,
            this.EditMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(47, 24);
            this.ViewMenuItem.Text = "Вид";
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(72, 24);
            this.EditMenuItem.Text = "Правка";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(79, 24);
            this.HelpMenuItem.Text = "Справка";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 45);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(299, 65);
            this.TextBox.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(12, 116);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(55, 35);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "⬅";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CeButton
            // 
            this.CeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CeButton.Location = new System.Drawing.Point(73, 116);
            this.CeButton.Name = "CeButton";
            this.CeButton.Size = new System.Drawing.Size(55, 35);
            this.CeButton.TabIndex = 4;
            this.CeButton.Text = "CE";
            this.CeButton.UseVisualStyleBackColor = true;
            // 
            // CButton
            // 
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CButton.Location = new System.Drawing.Point(134, 116);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(55, 35);
            this.CButton.TabIndex = 5;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusMinusButton.Location = new System.Drawing.Point(195, 116);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(55, 35);
            this.PlusMinusButton.TabIndex = 6;
            this.PlusMinusButton.Text = "+-";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            // 
            // SqrtButton
            // 
            this.SqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SqrtButton.Location = new System.Drawing.Point(256, 116);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(55, 35);
            this.SqrtButton.TabIndex = 7;
            this.SqrtButton.Text = "√";
            this.SqrtButton.UseVisualStyleBackColor = true;
            this.SqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SevenButton.Location = new System.Drawing.Point(12, 166);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(55, 35);
            this.SevenButton.TabIndex = 8;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EightButton.Location = new System.Drawing.Point(73, 166);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(55, 35);
            this.EightButton.TabIndex = 9;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NineButton.Location = new System.Drawing.Point(134, 166);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(55, 35);
            this.NineButton.TabIndex = 10;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivideButton.Location = new System.Drawing.Point(195, 166);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(55, 35);
            this.DivideButton.TabIndex = 11;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // PercentButton
            // 
            this.PercentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentButton.Location = new System.Drawing.Point(256, 166);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(55, 35);
            this.PercentButton.TabIndex = 12;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = true;
            this.PercentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourButton.Location = new System.Drawing.Point(12, 207);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(55, 35);
            this.FourButton.TabIndex = 13;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiveButton.Location = new System.Drawing.Point(73, 207);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(55, 35);
            this.FiveButton.TabIndex = 14;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixButton.Location = new System.Drawing.Point(134, 207);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(55, 35);
            this.SixButton.TabIndex = 15;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.Location = new System.Drawing.Point(195, 207);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(55, 35);
            this.MultiplyButton.TabIndex = 16;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // OneDivideXButton
            // 
            this.OneDivideXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneDivideXButton.Location = new System.Drawing.Point(257, 207);
            this.OneDivideXButton.Name = "OneDivideXButton";
            this.OneDivideXButton.Size = new System.Drawing.Size(55, 35);
            this.OneDivideXButton.TabIndex = 17;
            this.OneDivideXButton.Text = "1/x";
            this.OneDivideXButton.UseVisualStyleBackColor = true;
            this.OneDivideXButton.Click += new System.EventHandler(this.OneDivideXButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton.Location = new System.Drawing.Point(195, 248);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(55, 35);
            this.MinusButton.TabIndex = 21;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeButton.Location = new System.Drawing.Point(134, 248);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(55, 35);
            this.ThreeButton.TabIndex = 20;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoButton.Location = new System.Drawing.Point(73, 248);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(55, 35);
            this.TwoButton.TabIndex = 19;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneButton.Location = new System.Drawing.Point(12, 248);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(55, 35);
            this.OneButton.TabIndex = 18;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualButton.Location = new System.Drawing.Point(257, 248);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(55, 76);
            this.EqualButton.TabIndex = 27;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.Location = new System.Drawing.Point(195, 289);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(55, 35);
            this.PlusButton.TabIndex = 26;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DotButton.Location = new System.Drawing.Point(134, 289);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(55, 35);
            this.DotButton.TabIndex = 25;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroButton.Location = new System.Drawing.Point(12, 289);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(116, 35);
            this.ZeroButton.TabIndex = 23;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // ExpressionLabel
            // 
            this.ExpressionLabel.AutoSize = true;
            this.ExpressionLabel.Location = new System.Drawing.Point(17, 81);
            this.ExpressionLabel.Name = "ExpressionLabel";
            this.ExpressionLabel.Size = new System.Drawing.Size(0, 17);
            this.ExpressionLabel.TabIndex = 28;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 334);
            this.Controls.Add(this.ExpressionLabel);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.OneDivideXButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.PercentButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.CeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ViewMenuItem;
        private ToolStripMenuItem EditMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private TextBox TextBox;
        private Button backButton;
        private Button CeButton;
        private Button CButton;
        private Button PlusMinusButton;
        private Button SqrtButton;
        private Button SevenButton;
        private Button EightButton;
        private Button NineButton;
        private Button DivideButton;
        private Button PercentButton;
        private Button FourButton;
        private Button FiveButton;
        private Button SixButton;
        private Button MultiplyButton;
        private Button OneDivideXButton;
        private Button MinusButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button EqualButton;
        private Button PlusButton;
        private Button DotButton;
        private Button ZeroButton;
        private Label ExpressionLabel;
    }
}

