namespace Project_2.Move_Images
{
    partial class AddLabelForm
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
            this.labelKey = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonChoosePath = new System.Windows.Forms.Button();
            this.buttonAddLabel = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKey = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPath = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPath)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(12, 43);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(28, 13);
            this.labelKey.TabIndex = 1;
            this.labelKey.Text = "Key:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 81);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(32, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "Path:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(56, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(56, 40);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxKey.TabIndex = 4;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(56, 78);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(100, 20);
            this.textBoxPath.TabIndex = 4;
            // 
            // buttonChoosePath
            // 
            this.buttonChoosePath.Location = new System.Drawing.Point(162, 76);
            this.buttonChoosePath.Name = "buttonChoosePath";
            this.buttonChoosePath.Size = new System.Drawing.Size(90, 23);
            this.buttonChoosePath.TabIndex = 5;
            this.buttonChoosePath.Text = "Choose Path";
            this.buttonChoosePath.UseVisualStyleBackColor = true;
            this.buttonChoosePath.Click += new System.EventHandler(this.buttonChoosePath_Click);
            // 
            // buttonAddLabel
            // 
            this.buttonAddLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddLabel.Location = new System.Drawing.Point(0, 113);
            this.buttonAddLabel.Name = "buttonAddLabel";
            this.buttonAddLabel.Size = new System.Drawing.Size(266, 23);
            this.buttonAddLabel.TabIndex = 6;
            this.buttonAddLabel.Text = "Add Label";
            this.buttonAddLabel.UseVisualStyleBackColor = true;
            this.buttonAddLabel.Click += new System.EventHandler(this.buttonAddLabel_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderKey
            // 
            this.errorProviderKey.ContainerControl = this;
            // 
            // errorProviderPath
            // 
            this.errorProviderPath.ContainerControl = this;
            // 
            // AddLabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 136);
            this.Controls.Add(this.buttonAddLabel);
            this.Controls.Add(this.buttonChoosePath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelKey);
            this.Name = "AddLabelForm";
            this.Text = "AddLabelForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonChoosePath;
        private System.Windows.Forms.Button buttonAddLabel;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderKey;
        private System.Windows.Forms.ErrorProvider errorProviderPath;
    }
}