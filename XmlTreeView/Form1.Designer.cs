namespace XmlTreeView
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(32, 83);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(472, 435);
            this.treeView.TabIndex = 8;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.Click += new System.EventHandler(this.treeView_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(550, 23);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(106, 28);
            this.buttonBrowse.TabIndex = 7;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textPath
            // 
            this.textPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPath.Location = new System.Drawing.Point(98, 23);
            this.textPath.Multiline = true;
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(406, 28);
            this.textPath.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(28, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 20);
            this.label.TabIndex = 5;
            this.label.Text = "Path:";
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.Location = new System.Drawing.Point(550, 83);
            this.textInput.MaxLength = 10;
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(106, 29);
            this.textInput.TabIndex = 9;
            this.textInput.Text = "Enter Text";
            this.textInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textInput_MouseClick);
            // 
            // buttonFind
            // 
            this.buttonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFind.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFind.FlatAppearance.BorderSize = 10;
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(550, 214);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(106, 29);
            this.buttonFind.TabIndex = 10;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 10;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(550, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 29);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEdit.FlatAppearance.BorderSize = 10;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(550, 313);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(106, 29);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDel.FlatAppearance.BorderSize = 10;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(550, 364);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(106, 29);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.FlatAppearance.BorderSize = 10;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(550, 489);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 29);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.SystemColors.Control;
            this.textStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.textStatus.Enabled = false;
            this.textStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textStatus.Location = new System.Drawing.Point(527, 118);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(158, 29);
            this.textStatus.TabIndex = 15;
            this.textStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 552);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textStatus;
    }
}

