namespace Proiect
{
    partial class AgendaFormular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaFormular));
            this.panelBara_sus = new System.Windows.Forms.Panel();
            this.Bara_Meniu = new System.Windows.Forms.Panel();
            this.panel_Meniu = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label_Agenda = new System.Windows.Forms.Label();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.control_Search1 = new Proiect.Control_Search();
            this.control_Display1 = new Proiect.Control_Display();
            this.control_Insert1 = new Proiect.Control_Insert();
            this.controlHome1 = new Proiect.ControlHome();
            this.Bara_Meniu.SuspendLayout();
            this.panel_Meniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBara_sus
            // 
            this.panelBara_sus.BackColor = System.Drawing.Color.DimGray;
            this.panelBara_sus.Location = new System.Drawing.Point(280, 0);
            this.panelBara_sus.Name = "panelBara_sus";
            this.panelBara_sus.Size = new System.Drawing.Size(1171, 27);
            this.panelBara_sus.TabIndex = 2;
            // 
            // Bara_Meniu
            // 
            this.Bara_Meniu.BackColor = System.Drawing.Color.DimGray;
            this.Bara_Meniu.Controls.Add(this.panel_Meniu);
            this.Bara_Meniu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bara_Meniu.Location = new System.Drawing.Point(0, 0);
            this.Bara_Meniu.Name = "Bara_Meniu";
            this.Bara_Meniu.Size = new System.Drawing.Size(283, 701);
            this.Bara_Meniu.TabIndex = 0;
            // 
            // panel_Meniu
            // 
            this.panel_Meniu.BackColor = System.Drawing.Color.DimGray;
            this.panel_Meniu.Controls.Add(this.button1);
            this.panel_Meniu.Controls.Add(this.panelLeft);
            this.panel_Meniu.Controls.Add(this.buttonSearch);
            this.panel_Meniu.Controls.Add(this.label_Agenda);
            this.panel_Meniu.Controls.Add(this.buttonDisplay);
            this.panel_Meniu.Controls.Add(this.buttonInsert);
            this.panel_Meniu.Controls.Add(this.buttonHome);
            this.panel_Meniu.Location = new System.Drawing.Point(0, 0);
            this.panel_Meniu.Name = "panel_Meniu";
            this.panel_Meniu.Size = new System.Drawing.Size(280, 701);
            this.panel_Meniu.TabIndex = 4;
            this.panel_Meniu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Meniu_Paint);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Location = new System.Drawing.Point(68, 136);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(8, 77);
            this.panelLeft.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.Location = new System.Drawing.Point(68, 438);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(151, 77);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label_Agenda
            // 
            this.label_Agenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Agenda.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Agenda.ForeColor = System.Drawing.Color.Black;
            this.label_Agenda.Location = new System.Drawing.Point(21, 38);
            this.label_Agenda.Name = "label_Agenda";
            this.label_Agenda.Size = new System.Drawing.Size(227, 66);
            this.label_Agenda.TabIndex = 3;
            this.label_Agenda.Text = "Agenda";
            this.label_Agenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.FlatAppearance.BorderSize = 0;
            this.buttonDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisplay.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisplay.Image")));
            this.buttonDisplay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDisplay.Location = new System.Drawing.Point(68, 342);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(151, 77);
            this.buttonDisplay.TabIndex = 4;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.AccessibleName = "Insert_Button";
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Image = ((System.Drawing.Image)(resources.GetObject("buttonInsert.Image")));
            this.buttonInsert.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInsert.Location = new System.Drawing.Point(68, 246);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(151, 77);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = " Insert";
            this.buttonInsert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AccessibleName = "Home_Button";
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHome.Location = new System.Drawing.Point(68, 136);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(151, 77);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = " Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(119, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 36);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // control_Search1
            // 
            this.control_Search1.BackColor = System.Drawing.Color.Silver;
            this.control_Search1.Location = new System.Drawing.Point(280, 23);
            this.control_Search1.Name = "control_Search1";
            this.control_Search1.Size = new System.Drawing.Size(1171, 678);
            this.control_Search1.TabIndex = 6;
            // 
            // control_Display1
            // 
            this.control_Display1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.control_Display1.Location = new System.Drawing.Point(280, 23);
            this.control_Display1.Name = "control_Display1";
            this.control_Display1.Size = new System.Drawing.Size(1174, 679);
            this.control_Display1.TabIndex = 5;
            // 
            // control_Insert1
            // 
            this.control_Insert1.BackColor = System.Drawing.Color.Silver;
            this.control_Insert1.Location = new System.Drawing.Point(280, 23);
            this.control_Insert1.Name = "control_Insert1";
            this.control_Insert1.Size = new System.Drawing.Size(1174, 679);
            this.control_Insert1.TabIndex = 4;
            // 
            // controlHome1
            // 
            this.controlHome1.Location = new System.Drawing.Point(280, 23);
            this.controlHome1.Name = "controlHome1";
            this.controlHome1.Size = new System.Drawing.Size(1171, 678);
            this.controlHome1.TabIndex = 3;
            // 
            // AgendaFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 701);
            this.Controls.Add(this.control_Search1);
            this.Controls.Add(this.control_Display1);
            this.Controls.Add(this.control_Insert1);
            this.Controls.Add(this.controlHome1);
            this.Controls.Add(this.panelBara_sus);
            this.Controls.Add(this.Bara_Meniu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaFormular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AgendaFormular_Load);
            this.Bara_Meniu.ResumeLayout(false);
            this.panel_Meniu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBara_sus;
        private System.Windows.Forms.Panel Bara_Meniu;
        private ControlHome controlHome1;
        private Control_Insert control_Insert1;
        private Control_Display control_Display1;
        private System.Windows.Forms.Panel panel_Meniu;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label_Agenda;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonHome;
        private Control_Search control_Search1;
        private System.Windows.Forms.Button button1;
    }
}