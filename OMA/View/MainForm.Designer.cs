namespace OrderMakingApp
{
    partial class MainForm
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
            this.MenuGridView = new System.Windows.Forms.DataGridView();
            this.OrderButton = new System.Windows.Forms.Button();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuisineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightInGramsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDishOrdered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuGridView
            // 
            this.MenuGridView.AutoGenerateColumns = false;
            this.MenuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.cuisineDataGridViewTextBoxColumn,
            this.cookingTimeDataGridViewTextBoxColumn,
            this.weightInGramsDataGridViewTextBoxColumn,
            this.IsDishOrdered});
            this.MenuGridView.DataSource = this.dishBindingSource;
            this.MenuGridView.Location = new System.Drawing.Point(12, 12);
            this.MenuGridView.Name = "MenuGridView";
            this.MenuGridView.RowHeadersWidth = 51;
            this.MenuGridView.RowTemplate.Height = 24;
            this.MenuGridView.Size = new System.Drawing.Size(1127, 377);
            this.MenuGridView.TabIndex = 0;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(489, 405);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(170, 60);
            this.OrderButton.TabIndex = 1;
            this.OrderButton.Text = "Замовити";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataSource = typeof(OrderMakingApp.Dish);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Страва";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cuisineDataGridViewTextBoxColumn
            // 
            this.cuisineDataGridViewTextBoxColumn.DataPropertyName = "Cuisine";
            this.cuisineDataGridViewTextBoxColumn.HeaderText = "Кухня";
            this.cuisineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cuisineDataGridViewTextBoxColumn.Name = "cuisineDataGridViewTextBoxColumn";
            this.cuisineDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuisineDataGridViewTextBoxColumn.Width = 125;
            // 
            // cookingTimeDataGridViewTextBoxColumn
            // 
            this.cookingTimeDataGridViewTextBoxColumn.DataPropertyName = "CookingTime";
            this.cookingTimeDataGridViewTextBoxColumn.HeaderText = "Час приготування";
            this.cookingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cookingTimeDataGridViewTextBoxColumn.Name = "cookingTimeDataGridViewTextBoxColumn";
            this.cookingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cookingTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightInGramsDataGridViewTextBoxColumn
            // 
            this.weightInGramsDataGridViewTextBoxColumn.DataPropertyName = "WeightInGrams";
            this.weightInGramsDataGridViewTextBoxColumn.HeaderText = "Вага (г.)";
            this.weightInGramsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightInGramsDataGridViewTextBoxColumn.Name = "weightInGramsDataGridViewTextBoxColumn";
            this.weightInGramsDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightInGramsDataGridViewTextBoxColumn.Width = 125;
            // 
            // IsDishOrdered
            // 
            this.IsDishOrdered.HeaderText = "Замовити";
            this.IsDishOrdered.MinimumWidth = 6;
            this.IsDishOrdered.Name = "IsDishOrdered";
            this.IsDishOrdered.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 477);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.MenuGridView);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MenuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dishBindingSource;
        private System.Windows.Forms.DataGridView MenuGridView;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuisineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightInGramsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDishOrdered;
    }
}

