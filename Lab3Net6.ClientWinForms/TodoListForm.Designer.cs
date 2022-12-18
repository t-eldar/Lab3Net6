namespace Lab3Net6.ClientWinForms;

partial class TodoListForm
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
			this.todosDataGridView = new System.Windows.Forms.DataGridView();
			this.deleteButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.todosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// todosDataGridView
			// 
			this.todosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.todosDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
			this.todosDataGridView.Location = new System.Drawing.Point(12, 12);
			this.todosDataGridView.MultiSelect = false;
			this.todosDataGridView.Name = "todosDataGridView";
			this.todosDataGridView.RowHeadersWidth = 51;
			this.todosDataGridView.RowTemplate.Height = 29;
			this.todosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.todosDataGridView.Size = new System.Drawing.Size(431, 356);
			this.todosDataGridView.TabIndex = 0;
			this.todosDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.todosDataGridView_CellValueChanged);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(12, 383);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(117, 55);
			this.deleteButton.TabIndex = 1;
			this.deleteButton.Text = "Удалить";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// TodoListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 450);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.todosDataGridView);
			this.Name = "TodoListForm";
			this.Text = "TodoListForm";
			this.Load += new System.EventHandler(this.TodoListForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.todosDataGridView)).EndInit();
			this.ResumeLayout(false);

	}

	#endregion

	private DataGridView todosDataGridView;
	private Button deleteButton;
}