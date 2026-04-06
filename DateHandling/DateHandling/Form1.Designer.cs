namespace DateHandling;

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
        label1 = new Label();
        txtFutureDate = new TextBox();
        btnCalculateDays = new Button();
        btnCalculateAge = new Button();
        txtBirthDate = new TextBox();
        label2 = new Label();
        btnExit = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(21, 20);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(107, 15);
        label1.TabIndex = 0;
        label1.Text = "Enter a future date:";
        // 
        // txtFutureDate
        // 
        txtFutureDate.Location = new Point(155, 18);
        txtFutureDate.Margin = new Padding(2);
        txtFutureDate.Name = "txtFutureDate";
        txtFutureDate.Size = new Size(106, 23);
        txtFutureDate.TabIndex = 1;
        txtFutureDate.Text = "12/31/2026";
        // 
        // btnCalculateDays
        // 
        btnCalculateDays.Location = new Point(283, 17);
        btnCalculateDays.Margin = new Padding(2);
        btnCalculateDays.Name = "btnCalculateDays";
        btnCalculateDays.Size = new Size(148, 23);
        btnCalculateDays.TabIndex = 2;
        btnCalculateDays.Text = "Calculate &Due Days ";
        btnCalculateDays.UseVisualStyleBackColor = true;
        btnCalculateDays.Click += btnCalculateDays_Click;
        // 
        // btnCalculateAge
        // 
        btnCalculateAge.Location = new Point(283, 50);
        btnCalculateAge.Margin = new Padding(2);
        btnCalculateAge.Name = "btnCalculateAge";
        btnCalculateAge.Size = new Size(148, 23);
        btnCalculateAge.TabIndex = 5;
        btnCalculateAge.Text = "Calculate &Age";
        btnCalculateAge.UseVisualStyleBackColor = true;
        btnCalculateAge.Click += btnCalculateAge_Click;
        // 
        // txtBirthDate
        // 
        txtBirthDate.Location = new Point(155, 51);
        txtBirthDate.Margin = new Padding(2);
        txtBirthDate.Name = "txtBirthDate";
        txtBirthDate.Size = new Size(106, 23);
        txtBirthDate.TabIndex = 4;
        txtBirthDate.Text = "10/24/1952";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(21, 53);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(100, 15);
        label2.TabIndex = 3;
        label2.Text = "Enter a birth date:";
        // 
        // btnExit
        // 
        btnExit.DialogResult = DialogResult.Cancel;
        btnExit.Location = new Point(283, 83);
        btnExit.Margin = new Padding(2);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(148, 23);
        btnExit.TabIndex = 6;
        btnExit.Text = "E&xit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnExit;
        ClientSize = new Size(469, 122);
        Controls.Add(btnExit);
        Controls.Add(btnCalculateAge);
        Controls.Add(txtBirthDate);
        Controls.Add(label2);
        Controls.Add(btnCalculateDays);
        Controls.Add(txtFutureDate);
        Controls.Add(label1);
        Margin = new Padding(2);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Date Handling";
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox txtFutureDate;
    private Button btnCalculateDays;
    private Button btnCalculateAge;
    private TextBox txtBirthDate;
    private Label label2;
    private Button btnExit;
}
