namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            textOne = new TextBox();
            textTwo = new TextBox();
            textSum = new Button();
            result = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(669, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // textOne
            // 
            textOne.Location = new Point(149, 62);
            textOne.Name = "textOne";
            textOne.Size = new Size(100, 23);
            textOne.TabIndex = 2;
            textOne.TextChanged += textBox1_TextChanged;
            // 
            // textTwo
            // 
            textTwo.Location = new Point(309, 62);
            textTwo.Name = "textTwo";
            textTwo.Size = new Size(100, 23);
            textTwo.TabIndex = 3;
            textTwo.TextChanged += textBox1_TextChanged_1;
            // 
            // textSum
            // 
            textSum.Location = new Point(283, 139);
            textSum.Name = "textSum";
            textSum.Size = new Size(75, 23);
            textSum.TabIndex = 4;
            textSum.Text = "SUM";
            textSum.UseVisualStyleBackColor = true;
            textSum.Click += button1_Click;
            // 
            // result
            // 
            result.Location = new Point(461, 62);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 5;
            result.TextChanged += result_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 393);
            Controls.Add(result);
            Controls.Add(textSum);
            Controls.Add(textTwo);
            Controls.Add(textOne);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "My App";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private TextBox textOne;
        private TextBox textTwo;
        private Button textSum;
        private TextBox result;
    }
}
