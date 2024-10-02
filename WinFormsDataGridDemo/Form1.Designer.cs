using System.Windows.Forms;

namespace WinFormsDataGrid
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
            propertyGrid1 = new PropertyGrid();
            dataGrid1 = new DataGrid();
            ((System.ComponentModel.ISupportInitialize)dataGrid1).BeginInit();
            SuspendLayout();
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Right;
            propertyGrid1.Location = new Point(568, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.SelectedObject = dataGrid1;
            propertyGrid1.Size = new Size(232, 450);
            propertyGrid1.TabIndex = 0;
            // 
            // dataGrid1
            // 
            dataGrid1.BorderStyle = BorderStyle.None;
            dataGrid1.CaptureInternal = false;
            dataGrid1.DataMember = "";
            dataGrid1.Dock = DockStyle.Fill;
            dataGrid1.HeaderForeColor = SystemColors.ControlText;
            dataGrid1.Location = new Point(0, 0);
            dataGrid1.Name = "dataGrid1";
            dataGrid1.Size = new Size(568, 450);
            dataGrid1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGrid1);
            Controls.Add(propertyGrid1);
            Name = "Form1";
            Text = ".Net DataGrid";
            ((System.ComponentModel.ISupportInitialize)dataGrid1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid propertyGrid1;
        private DataGrid dataGrid1;
    }
}
