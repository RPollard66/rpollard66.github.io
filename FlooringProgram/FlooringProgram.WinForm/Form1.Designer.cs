namespace FlooringProgram.WinForm
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataOrdersView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateToLoad = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProdType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upDownArea = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrdersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownArea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(37, 62);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.loadOrders_Click);
            // 
            // dataOrdersView
            // 
            this.dataOrdersView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOrdersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrdersView.Location = new System.Drawing.Point(12, 191);
            this.dataOrdersView.Name = "dataOrdersView";
            this.dataOrdersView.Size = new System.Drawing.Size(1143, 220);
            this.dataOrdersView.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(678, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addOrders_Click);
            // 
            // dateToLoad
            // 
            this.dateToLoad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToLoad.Location = new System.Drawing.Point(118, 65);
            this.dateToLoad.Name = "dateToLoad";
            this.dateToLoad.Size = new System.Drawing.Size(110, 20);
            this.dateToLoad.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(678, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.textBox_EnterName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // cmbProdType
            // 
            this.cmbProdType.FormattingEnabled = true;
            this.cmbProdType.Location = new System.Drawing.Point(678, 59);
            this.cmbProdType.Name = "cmbProdType";
            this.cmbProdType.Size = new System.Drawing.Size(152, 21);
            this.cmbProdType.TabIndex = 7;
            this.cmbProdType.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProdSelector);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Type:";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(678, 86);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(59, 21);
            this.cmbState.TabIndex = 9;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.comboBox_StateSelector);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "State:";
            // 
            // upDownArea
            // 
            this.upDownArea.Location = new System.Drawing.Point(678, 114);
            this.upDownArea.Name = "upDownArea";
            this.upDownArea.Size = new System.Drawing.Size(120, 20);
            this.upDownArea.TabIndex = 11;
            this.upDownArea.ValueChanged += new System.EventHandler(this.updown_AreaNumeric);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Area (sq ft):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upDownArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProdType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dateToLoad);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataOrdersView);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataOrdersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataOrdersView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateToLoad;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProdType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upDownArea;
        private System.Windows.Forms.Label label4;
    }
}

