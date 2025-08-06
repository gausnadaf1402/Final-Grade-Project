namespace ClassesGradeApp
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
            this.components = new System.ComponentModel.Container();
            this.lblgrades = new System.Windows.Forms.Label();
            this.lblgradename = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblactivestatus = new System.Windows.Forms.Label();
            this.lblcreatedby = new System.Windows.Forms.Label();
            this.lblmodifiedby = new System.Windows.Forms.Label();
            this.lblisdeleted = new System.Windows.Forms.Label();
            this.txtgradename = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtcreatedby = new System.Windows.Forms.TextBox();
            this.txtmodifiedby = new System.Windows.Forms.TextBox();
            this.checkboxactiveststus = new System.Windows.Forms.CheckBox();
            this.checkboxisdeleted = new System.Windows.Forms.CheckBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.timerslide = new System.Windows.Forms.Timer(this.components);
            this.panelshowgrades = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblselect = new System.Windows.Forms.Label();
            this.checkBoxgetalldata = new System.Windows.Forms.CheckBox();
            this.datagridviewgrades = new System.Windows.Forms.DataGridView();
            this.btnhide = new System.Windows.Forms.Button();
            this.lblgrade = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panelshowgrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewgrades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblgrades
            // 
            this.lblgrades.AutoSize = true;
            this.lblgrades.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrades.Location = new System.Drawing.Point(306, 29);
            this.lblgrades.Name = "lblgrades";
            this.lblgrades.Size = new System.Drawing.Size(94, 27);
            this.lblgrades.TabIndex = 0;
            this.lblgrades.Text = "GRADES";
            // 
            // lblgradename
            // 
            this.lblgradename.AutoSize = true;
            this.lblgradename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgradename.Location = new System.Drawing.Point(63, 129);
            this.lblgradename.Name = "lblgradename";
            this.lblgradename.Size = new System.Drawing.Size(123, 25);
            this.lblgradename.TabIndex = 1;
            this.lblgradename.Text = "Grade Name";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(59, 198);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(109, 25);
            this.lbldescription.TabIndex = 2;
            this.lbldescription.Text = "Description";
            // 
            // lblactivestatus
            // 
            this.lblactivestatus.AutoSize = true;
            this.lblactivestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactivestatus.Location = new System.Drawing.Point(59, 286);
            this.lblactivestatus.Name = "lblactivestatus";
            this.lblactivestatus.Size = new System.Drawing.Size(127, 25);
            this.lblactivestatus.TabIndex = 3;
            this.lblactivestatus.Text = "Active Status";
            // 
            // lblcreatedby
            // 
            this.lblcreatedby.AutoSize = true;
            this.lblcreatedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatedby.Location = new System.Drawing.Point(439, 125);
            this.lblcreatedby.Name = "lblcreatedby";
            this.lblcreatedby.Size = new System.Drawing.Size(105, 25);
            this.lblcreatedby.TabIndex = 4;
            this.lblcreatedby.Text = "CreatedBy";
            // 
            // lblmodifiedby
            // 
            this.lblmodifiedby.AutoSize = true;
            this.lblmodifiedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodifiedby.Location = new System.Drawing.Point(439, 197);
            this.lblmodifiedby.Name = "lblmodifiedby";
            this.lblmodifiedby.Size = new System.Drawing.Size(109, 25);
            this.lblmodifiedby.TabIndex = 5;
            this.lblmodifiedby.Text = "ModifiedBy";
            // 
            // lblisdeleted
            // 
            this.lblisdeleted.AutoSize = true;
            this.lblisdeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisdeleted.Location = new System.Drawing.Point(439, 286);
            this.lblisdeleted.Name = "lblisdeleted";
            this.lblisdeleted.Size = new System.Drawing.Size(94, 25);
            this.lblisdeleted.TabIndex = 6;
            this.lblisdeleted.Text = "IsDeleted";
            // 
            // txtgradename
            // 
            this.txtgradename.Location = new System.Drawing.Point(237, 129);
            this.txtgradename.Name = "txtgradename";
            this.txtgradename.Size = new System.Drawing.Size(172, 22);
            this.txtgradename.TabIndex = 7;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(237, 201);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(172, 22);
            this.txtdescription.TabIndex = 8;
            // 
            // txtcreatedby
            // 
            this.txtcreatedby.Location = new System.Drawing.Point(585, 125);
            this.txtcreatedby.Name = "txtcreatedby";
            this.txtcreatedby.Size = new System.Drawing.Size(172, 22);
            this.txtcreatedby.TabIndex = 9;
            // 
            // txtmodifiedby
            // 
            this.txtmodifiedby.Location = new System.Drawing.Point(585, 197);
            this.txtmodifiedby.Name = "txtmodifiedby";
            this.txtmodifiedby.Size = new System.Drawing.Size(172, 22);
            this.txtmodifiedby.TabIndex = 10;
            // 
            // checkboxactiveststus
            // 
            this.checkboxactiveststus.AutoSize = true;
            this.checkboxactiveststus.Location = new System.Drawing.Point(237, 294);
            this.checkboxactiveststus.Name = "checkboxactiveststus";
            this.checkboxactiveststus.Size = new System.Drawing.Size(18, 17);
            this.checkboxactiveststus.TabIndex = 11;
            this.checkboxactiveststus.UseVisualStyleBackColor = true;
            // 
            // checkboxisdeleted
            // 
            this.checkboxisdeleted.AutoSize = true;
            this.checkboxisdeleted.Location = new System.Drawing.Point(585, 286);
            this.checkboxisdeleted.Name = "checkboxisdeleted";
            this.checkboxisdeleted.Size = new System.Drawing.Size(18, 17);
            this.checkboxisdeleted.TabIndex = 12;
            this.checkboxisdeleted.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(68, 458);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(131, 43);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnshow
            // 
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(636, 463);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(139, 40);
            this.btnshow.TabIndex = 14;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(869, 462);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(135, 43);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // timerslide
            // 
            this.timerslide.Interval = 10;
            // 
            // panelshowgrades
            // 
            this.panelshowgrades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelshowgrades.BackColor = System.Drawing.SystemColors.Control;
            this.panelshowgrades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelshowgrades.Controls.Add(this.cmbFilter);
            this.panelshowgrades.Controls.Add(this.txtsearch);
            this.panelshowgrades.Controls.Add(this.lblsearch);
            this.panelshowgrades.Controls.Add(this.lblselect);
            this.panelshowgrades.Controls.Add(this.checkBoxgetalldata);
            this.panelshowgrades.Controls.Add(this.datagridviewgrades);
            this.panelshowgrades.Controls.Add(this.btnhide);
            this.panelshowgrades.Controls.Add(this.lblgrade);
            this.panelshowgrades.Location = new System.Drawing.Point(664, 0);
            this.panelshowgrades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelshowgrades.Name = "panelshowgrades";
            this.panelshowgrades.Size = new System.Drawing.Size(439, 454);
            this.panelshowgrades.TabIndex = 16;
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(219, 381);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(186, 24);
            this.cmbFilter.TabIndex = 23;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(219, 421);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(186, 22);
            this.txtsearch.TabIndex = 22;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblsearch.Location = new System.Drawing.Point(155, 420);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(58, 21);
            this.lblsearch.TabIndex = 21;
            this.lblsearch.Text = "Search";
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselect.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblselect.Location = new System.Drawing.Point(155, 380);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(56, 21);
            this.lblselect.TabIndex = 20;
            this.lblselect.Text = "Select";
            // 
            // checkBoxgetalldata
            // 
            this.checkBoxgetalldata.AutoSize = true;
            this.checkBoxgetalldata.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxgetalldata.Location = new System.Drawing.Point(4, 376);
            this.checkBoxgetalldata.Name = "checkBoxgetalldata";
            this.checkBoxgetalldata.Size = new System.Drawing.Size(132, 25);
            this.checkBoxgetalldata.TabIndex = 19;
            this.checkBoxgetalldata.Text = "Get All Data";
            this.checkBoxgetalldata.UseVisualStyleBackColor = true;
            this.checkBoxgetalldata.CheckedChanged += new System.EventHandler(this.checkBoxgetalldata_CheckedChanged);
            // 
            // datagridviewgrades
            // 
            this.datagridviewgrades.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagridviewgrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewgrades.Location = new System.Drawing.Point(-1, 52);
            this.datagridviewgrades.Name = "datagridviewgrades";
            this.datagridviewgrades.RowHeadersWidth = 51;
            this.datagridviewgrades.RowTemplate.Height = 24;
            this.datagridviewgrades.Size = new System.Drawing.Size(420, 317);
            this.datagridviewgrades.TabIndex = 18;
            // 
            // btnhide
            // 
            this.btnhide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhide.Location = new System.Drawing.Point(3, 409);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(139, 40);
            this.btnhide.TabIndex = 17;
            this.btnhide.Text = "Hide";
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(197, 8);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(86, 20);
            this.lblgrade.TabIndex = 0;
            this.lblgrade.Text = "GRADES";
            // 
            // btnupdate
            // 
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(205, 458);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(131, 43);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Edit";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(342, 458);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(131, 43);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 511);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.panelshowgrades);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.checkboxisdeleted);
            this.Controls.Add(this.checkboxactiveststus);
            this.Controls.Add(this.txtmodifiedby);
            this.Controls.Add(this.txtcreatedby);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtgradename);
            this.Controls.Add(this.lblisdeleted);
            this.Controls.Add(this.lblmodifiedby);
            this.Controls.Add(this.lblcreatedby);
            this.Controls.Add(this.lblactivestatus);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblgradename);
            this.Controls.Add(this.lblgrades);
            this.Name = "Form1";
            this.Text = "GRADES";
            this.panelshowgrades.ResumeLayout(false);
            this.panelshowgrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewgrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgrades;
        private System.Windows.Forms.Label lblgradename;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblactivestatus;
        private System.Windows.Forms.Label lblcreatedby;
        private System.Windows.Forms.Label lblmodifiedby;
        private System.Windows.Forms.Label lblisdeleted;
        private System.Windows.Forms.TextBox txtgradename;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtcreatedby;
        private System.Windows.Forms.TextBox txtmodifiedby;
        private System.Windows.Forms.CheckBox checkboxactiveststus;
        private System.Windows.Forms.CheckBox checkboxisdeleted;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Timer timerslide;
        private System.Windows.Forms.Panel panelshowgrades;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Button btnhide;
        private System.Windows.Forms.DataGridView datagridviewgrades;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.CheckBox checkBoxgetalldata;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}

