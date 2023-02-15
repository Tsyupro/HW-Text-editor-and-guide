namespace HW_Text_editor_and_guide
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
            this.TextEditor = new System.Windows.Forms.Button();
            this.Conductor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextEditor
            // 
            this.TextEditor.Location = new System.Drawing.Point(44, 21);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(75, 23);
            this.TextEditor.TabIndex = 0;
            this.TextEditor.Text = "Text Editor";
            this.TextEditor.UseVisualStyleBackColor = true;
            this.TextEditor.Click += new System.EventHandler(this.TextEditor_Click);
            // 
            // Conductor
            // 
            this.Conductor.Location = new System.Drawing.Point(44, 74);
            this.Conductor.Name = "Conductor";
            this.Conductor.Size = new System.Drawing.Size(75, 23);
            this.Conductor.TabIndex = 1;
            this.Conductor.Text = "Conductor";
            this.Conductor.UseVisualStyleBackColor = true;
            this.Conductor.Click += new System.EventHandler(this.Conductor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 125);
            this.Controls.Add(this.Conductor);
            this.Controls.Add(this.TextEditor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button TextEditor;
        private Button Conductor;
    }
}