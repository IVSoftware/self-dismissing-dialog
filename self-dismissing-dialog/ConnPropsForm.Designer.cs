namespace self_dismissing_dialog
{
    partial class ConnPropsForm
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(458, 224);
            label1.TabIndex = 0;
            label1.Text = "Closing in 10";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConnPropsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(label1);
            Name = "ConnPropsForm";
            Padding = new Padding(10);
            Text = "ConnPropsForm";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}