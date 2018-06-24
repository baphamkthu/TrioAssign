namespace TrionaAssignment
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
            this.button_clearFields = new System.Windows.Forms.Button();
            this.button_addNewPerson = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_getAllUsers = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textbox_search = new System.Windows.Forms.TextBox();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_phone = new System.Windows.Forms.TextBox();
            this.textbox_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_clearFields
            // 
            this.button_clearFields.Location = new System.Drawing.Point(12, 242);
            this.button_clearFields.Name = "button_clearFields";
            this.button_clearFields.Size = new System.Drawing.Size(117, 23);
            this.button_clearFields.TabIndex = 1;
            this.button_clearFields.Text = "Clear Fields";
            this.button_clearFields.UseVisualStyleBackColor = true;
            this.button_clearFields.Click += new System.EventHandler(this.button_clearFields_click);
            // 
            // button_addNewPerson
            // 
            this.button_addNewPerson.Location = new System.Drawing.Point(135, 213);
            this.button_addNewPerson.Name = "button_addNewPerson";
            this.button_addNewPerson.Size = new System.Drawing.Size(98, 23);
            this.button_addNewPerson.TabIndex = 2;
            this.button_addNewPerson.Text = "Save Person";
            this.button_addNewPerson.UseVisualStyleBackColor = true;
            this.button_addNewPerson.Click += new System.EventHandler(this.button_writePerson_click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(RestServer.models.Person);
            // 
            // button_getAllUsers
            // 
            this.button_getAllUsers.Location = new System.Drawing.Point(13, 213);
            this.button_getAllUsers.Name = "button_getAllUsers";
            this.button_getAllUsers.Size = new System.Drawing.Size(116, 23);
            this.button_getAllUsers.TabIndex = 4;
            this.button_getAllUsers.Text = "Search for User";
            this.button_getAllUsers.UseVisualStyleBackColor = true;
            this.button_getAllUsers.Click += new System.EventHandler(this.button_getAllUsers_click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textbox_search, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textbox_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textbox_email, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textbox_phone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textbox_address, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 195);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // textbox_search
            // 
            this.textbox_search.Location = new System.Drawing.Point(129, 3);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(100, 22);
            this.textbox_search.TabIndex = 0;
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(129, 42);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(100, 22);
            this.textbox_name.TabIndex = 1;
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(129, 81);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(100, 22);
            this.textbox_email.TabIndex = 2;
            // 
            // textbox_phone
            // 
            this.textbox_phone.Location = new System.Drawing.Point(129, 120);
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.Size = new System.Drawing.Size(100, 22);
            this.textbox_phone.TabIndex = 3;
            // 
            // textbox_address
            // 
            this.textbox_address.Location = new System.Drawing.Point(129, 159);
            this.textbox_address.Name = "textbox_address";
            this.textbox_address.Size = new System.Drawing.Size(100, 22);
            this.textbox_address.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_getAllUsers);
            this.Controls.Add(this.button_addNewPerson);
            this.Controls.Add(this.button_clearFields);
            this.Name = "Form1";
            this.Text = "SimpleUI";
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_clearFields;
        private System.Windows.Forms.Button button_addNewPerson;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button button_getAllUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textbox_search;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.TextBox textbox_phone;
        private System.Windows.Forms.TextBox textbox_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

