namespace GraphicsEditor2
{
    partial class CreateProjectParameters
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
            this.labelProjectName = new System.Windows.Forms.Label();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.labelProjectPlacement = new System.Windows.Forms.Label();
            this.comboBoxProjectPlacement = new System.Windows.Forms.ComboBox();
            this.textBoxCanvasWidth = new System.Windows.Forms.TextBox();
            this.labelCanvasWidth = new System.Windows.Forms.Label();
            this.textBoxCanvasHeight = new System.Windows.Forms.TextBox();
            this.labelCanvasHeight = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(7, 35);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(73, 13);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Имя проекта";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(139, 32);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(187, 20);
            this.textBoxProjectName.TabIndex = 0;
            this.textBoxProjectName.TextChanged += new System.EventHandler(this.textBoxProjectName_TextChanged);
            // 
            // labelProjectPlacement
            // 
            this.labelProjectPlacement.AutoSize = true;
            this.labelProjectPlacement.Location = new System.Drawing.Point(7, 74);
            this.labelProjectPlacement.Name = "labelProjectPlacement";
            this.labelProjectPlacement.Size = new System.Drawing.Size(126, 13);
            this.labelProjectPlacement.TabIndex = 2;
            this.labelProjectPlacement.Text = "Расположение проекта";
            // 
            // comboBoxProjectPlacement
            // 
            this.comboBoxProjectPlacement.FormattingEnabled = true;
            this.comboBoxProjectPlacement.Items.AddRange(new object[] {
            "Обзор..."});
            this.comboBoxProjectPlacement.Location = new System.Drawing.Point(139, 71);
            this.comboBoxProjectPlacement.Name = "comboBoxProjectPlacement";
            this.comboBoxProjectPlacement.Size = new System.Drawing.Size(187, 21);
            this.comboBoxProjectPlacement.TabIndex = 3;
            this.comboBoxProjectPlacement.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjectPlacement_SelectedIndexChanged);
            // 
            // textBoxCanvasWidth
            // 
            this.textBoxCanvasWidth.Location = new System.Drawing.Point(65, 112);
            this.textBoxCanvasWidth.Name = "textBoxCanvasWidth";
            this.textBoxCanvasWidth.Size = new System.Drawing.Size(87, 20);
            this.textBoxCanvasWidth.TabIndex = 4;
            this.textBoxCanvasWidth.TextChanged += new System.EventHandler(this.textBoxProjectName_TextChanged);
            this.textBoxCanvasWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCanvasWidth_KeyPress);
            // 
            // labelCanvasWidth
            // 
            this.labelCanvasWidth.AutoSize = true;
            this.labelCanvasWidth.Location = new System.Drawing.Point(7, 115);
            this.labelCanvasWidth.Name = "labelCanvasWidth";
            this.labelCanvasWidth.Size = new System.Drawing.Size(46, 13);
            this.labelCanvasWidth.TabIndex = 5;
            this.labelCanvasWidth.Text = "Ширина";
            // 
            // textBoxCanvasHeight
            // 
            this.textBoxCanvasHeight.Location = new System.Drawing.Point(233, 112);
            this.textBoxCanvasHeight.Name = "textBoxCanvasHeight";
            this.textBoxCanvasHeight.Size = new System.Drawing.Size(93, 20);
            this.textBoxCanvasHeight.TabIndex = 6;
            this.textBoxCanvasHeight.TextChanged += new System.EventHandler(this.textBoxProjectName_TextChanged);
            this.textBoxCanvasHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCanvasWidth_KeyPress);
            // 
            // labelCanvasHeight
            // 
            this.labelCanvasHeight.AutoSize = true;
            this.labelCanvasHeight.Location = new System.Drawing.Point(175, 115);
            this.labelCanvasHeight.Name = "labelCanvasHeight";
            this.labelCanvasHeight.Size = new System.Drawing.Size(45, 13);
            this.labelCanvasHeight.TabIndex = 7;
            this.labelCanvasHeight.Text = "Высота";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Location = new System.Drawing.Point(251, 171);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 9;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(170, 171);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CreateProjectParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 206);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxCanvasHeight);
            this.Controls.Add(this.labelCanvasHeight);
            this.Controls.Add(this.textBoxCanvasWidth);
            this.Controls.Add(this.labelCanvasWidth);
            this.Controls.Add(this.comboBoxProjectPlacement);
            this.Controls.Add(this.labelProjectPlacement);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.labelProjectName);
            this.Name = "CreateProjectParameters";
            this.Text = "CreateProjectParameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Label labelProjectPlacement;
        private System.Windows.Forms.ComboBox comboBoxProjectPlacement;
        private System.Windows.Forms.TextBox textBoxCanvasWidth;
        private System.Windows.Forms.Label labelCanvasWidth;
        private System.Windows.Forms.TextBox textBoxCanvasHeight;
        private System.Windows.Forms.Label labelCanvasHeight;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
    }
}