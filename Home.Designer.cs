namespace CorvusV2
{
    partial class CorvusHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.JoinGameButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AdministrationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.getActiveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(897, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corvus";
            // 
            // JoinGameButton
            // 
            this.JoinGameButton.Location = new System.Drawing.Point(1507, 1044);
            this.JoinGameButton.Name = "JoinGameButton";
            this.JoinGameButton.Size = new System.Drawing.Size(188, 58);
            this.JoinGameButton.TabIndex = 1;
            this.JoinGameButton.Text = "JoinGame";
            this.JoinGameButton.UseVisualStyleBackColor = true;
            this.JoinGameButton.Click += new System.EventHandler(this.JoinGameButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(189, 1029);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(188, 58);
            this.NewGameButton.TabIndex = 2;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(1293, 1305);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(188, 58);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AdministrationButton
            // 
            this.AdministrationButton.Location = new System.Drawing.Point(507, 1305);
            this.AdministrationButton.Name = "AdministrationButton";
            this.AdministrationButton.Size = new System.Drawing.Size(226, 58);
            this.AdministrationButton.TabIndex = 4;
            this.AdministrationButton.Text = "Administration";
            this.AdministrationButton.UseVisualStyleBackColor = true;
            this.AdministrationButton.Click += new System.EventHandler(this.AdministrationButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Players Online";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1498, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Active Games";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1293, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(600, 645);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(189, 327);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(784, 660);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // getActiveBtn
            // 
            this.getActiveBtn.Location = new System.Drawing.Point(426, 1030);
            this.getActiveBtn.Name = "getActiveBtn";
            this.getActiveBtn.Size = new System.Drawing.Size(237, 57);
            this.getActiveBtn.TabIndex = 9;
            this.getActiveBtn.Text = "Active Players";
            this.getActiveBtn.UseVisualStyleBackColor = true;
            this.getActiveBtn.Click += new System.EventHandler(this.getActiveBtn_Click);
            // 
            // CorvusHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2055, 1412);
            this.Controls.Add(this.getActiveBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdministrationButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.JoinGameButton);
            this.Controls.Add(this.label1);
            this.Name = "CorvusHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.CorvusHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button JoinGameButton;
        private Button NewGameButton;
        private Button LogoutButton;
        private Button AdministrationButton;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private Button getActiveBtn;
    }
}