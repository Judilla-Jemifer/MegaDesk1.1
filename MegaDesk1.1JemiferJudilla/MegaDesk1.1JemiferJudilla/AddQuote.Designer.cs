namespace MegaDesk_3_JemiferJudilla
{
    partial class AddQuote
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
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblNumDrawers = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtNumDrawers = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radLaminateMat = new System.Windows.Forms.RadioButton();
            this.radRoseWoodMat = new System.Windows.Forms.RadioButton();
            this.radOakMat = new System.Windows.Forms.RadioButton();
            this.radVeneerMat = new System.Windows.Forms.RadioButton();
            this.radPineMat = new System.Windows.Forms.RadioButton();
            this.rad3days = new System.Windows.Forms.RadioButton();
            this.rad7days = new System.Windows.Forms.RadioButton();
            this.rad5days = new System.Windows.Forms.RadioButton();
            this.rad14days = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelAddQuote = new System.Windows.Forms.Button();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(54, 66);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(45, 16);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(52, 111);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(47, 16);
            this.lblDepth.TabIndex = 4;
            this.lblDepth.Text = "Depth:";
            // 
            // lblNumDrawers
            // 
            this.lblNumDrawers.AutoSize = true;
            this.lblNumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDrawers.Location = new System.Drawing.Point(54, 149);
            this.lblNumDrawers.Name = "lblNumDrawers";
            this.lblNumDrawers.Size = new System.Drawing.Size(126, 16);
            this.lblNumDrawers.TabIndex = 6;
            this.lblNumDrawers.Text = "Number of Drawers:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(14, 17);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(108, 16);
            this.lblMaterial.TabIndex = 8;
            this.lblMaterial.Text = "Surface Material:";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(193, 60);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(193, 22);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Validating += new System.ComponentModel.CancelEventHandler(this.txtWidth_Validating);
            // 
            // txtDepth
            // 
            this.txtDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepth.Location = new System.Drawing.Point(193, 105);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(193, 22);
            this.txtDepth.TabIndex = 5;
            this.txtDepth.Validating += new System.ComponentModel.CancelEventHandler(this.txtDepth_Validating);
            // 
            // txtNumDrawers
            // 
            this.txtNumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDrawers.Location = new System.Drawing.Point(193, 146);
            this.txtNumDrawers.Name = "txtNumDrawers";
            this.txtNumDrawers.Size = new System.Drawing.Size(193, 22);
            this.txtNumDrawers.TabIndex = 7;
            this.txtNumDrawers.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumDrawers_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(54, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(193, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // radLaminateMat
            // 
            this.radLaminateMat.AutoSize = true;
            this.radLaminateMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLaminateMat.Location = new System.Drawing.Point(154, 17);
            this.radLaminateMat.Name = "radLaminateMat";
            this.radLaminateMat.Size = new System.Drawing.Size(81, 20);
            this.radLaminateMat.TabIndex = 9;
            this.radLaminateMat.TabStop = true;
            this.radLaminateMat.Text = "Laminate";
            this.radLaminateMat.UseVisualStyleBackColor = true;
            // 
            // radRoseWoodMat
            // 
            this.radRoseWoodMat.AutoSize = true;
            this.radRoseWoodMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRoseWoodMat.Location = new System.Drawing.Point(154, 50);
            this.radRoseWoodMat.Name = "radRoseWoodMat";
            this.radRoseWoodMat.Size = new System.Drawing.Size(92, 20);
            this.radRoseWoodMat.TabIndex = 12;
            this.radRoseWoodMat.TabStop = true;
            this.radRoseWoodMat.Text = "Rosewood";
            this.radRoseWoodMat.UseVisualStyleBackColor = true;
            // 
            // radOakMat
            // 
            this.radOakMat.AutoSize = true;
            this.radOakMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOakMat.Location = new System.Drawing.Point(291, 17);
            this.radOakMat.Name = "radOakMat";
            this.radOakMat.Size = new System.Drawing.Size(51, 20);
            this.radOakMat.TabIndex = 10;
            this.radOakMat.TabStop = true;
            this.radOakMat.Text = "Oak";
            this.radOakMat.UseVisualStyleBackColor = true;
            // 
            // radVeneerMat
            // 
            this.radVeneerMat.AutoSize = true;
            this.radVeneerMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVeneerMat.Location = new System.Drawing.Point(291, 50);
            this.radVeneerMat.Name = "radVeneerMat";
            this.radVeneerMat.Size = new System.Drawing.Size(70, 20);
            this.radVeneerMat.TabIndex = 13;
            this.radVeneerMat.TabStop = true;
            this.radVeneerMat.Text = "Veneer";
            this.radVeneerMat.UseVisualStyleBackColor = true;
            // 
            // radPineMat
            // 
            this.radPineMat.AutoSize = true;
            this.radPineMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPineMat.Location = new System.Drawing.Point(63, 50);
            this.radPineMat.Name = "radPineMat";
            this.radPineMat.Size = new System.Drawing.Size(53, 20);
            this.radPineMat.TabIndex = 11;
            this.radPineMat.TabStop = true;
            this.radPineMat.Text = "Pine";
            this.radPineMat.UseVisualStyleBackColor = true;
            // 
            // rad3days
            // 
            this.rad3days.AutoSize = true;
            this.rad3days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad3days.Location = new System.Drawing.Point(274, 14);
            this.rad3days.Name = "rad3days";
            this.rad3days.Size = new System.Drawing.Size(68, 20);
            this.rad3days.TabIndex = 17;
            this.rad3days.TabStop = true;
            this.rad3days.Text = "3 Days";
            this.rad3days.UseVisualStyleBackColor = true;
            // 
            // rad7days
            // 
            this.rad7days.AutoSize = true;
            this.rad7days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad7days.Location = new System.Drawing.Point(274, 66);
            this.rad7days.Name = "rad7days";
            this.rad7days.Size = new System.Drawing.Size(68, 20);
            this.rad7days.TabIndex = 19;
            this.rad7days.TabStop = true;
            this.rad7days.Text = "7 Days";
            this.rad7days.UseVisualStyleBackColor = true;
            // 
            // rad5days
            // 
            this.rad5days.AutoSize = true;
            this.rad5days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad5days.Location = new System.Drawing.Point(274, 40);
            this.rad5days.Name = "rad5days";
            this.rad5days.Size = new System.Drawing.Size(68, 20);
            this.rad5days.TabIndex = 18;
            this.rad5days.TabStop = true;
            this.rad5days.Text = "5 Days";
            this.rad5days.UseVisualStyleBackColor = true;
            // 
            // rad14days
            // 
            this.rad14days.AutoSize = true;
            this.rad14days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad14days.Location = new System.Drawing.Point(125, 14);
            this.rad14days.Name = "rad14days";
            this.rad14days.Size = new System.Drawing.Size(128, 20);
            this.rad14days.TabIndex = 15;
            this.rad14days.TabStop = true;
            this.rad14days.Text = "Normal (14 days)";
            this.rad14days.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Production Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rush Order Options:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rad14days);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rad3days);
            this.panel1.Controls.Add(this.rad7days);
            this.panel1.Controls.Add(this.rad5days);
            this.panel1.Location = new System.Drawing.Point(23, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 95);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radPineMat);
            this.panel2.Controls.Add(this.radVeneerMat);
            this.panel2.Controls.Add(this.radOakMat);
            this.panel2.Controls.Add(this.radRoseWoodMat);
            this.panel2.Controls.Add(this.radLaminateMat);
            this.panel2.Controls.Add(this.lblMaterial);
            this.panel2.Location = new System.Drawing.Point(23, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 81);
            this.panel2.TabIndex = 22;
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(99, 377);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(81, 35);
            this.btnAddQuote.TabIndex = 23;
            this.btnAddQuote.Text = "Add";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnCancelAddQuote
            // 
            this.btnCancelAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddQuote.Location = new System.Drawing.Point(240, 377);
            this.btnCancelAddQuote.Name = "btnCancelAddQuote";
            this.btnCancelAddQuote.Size = new System.Drawing.Size(81, 35);
            this.btnCancelAddQuote.TabIndex = 24;
            this.btnCancelAddQuote.Text = "Cancel";
            this.btnCancelAddQuote.UseVisualStyleBackColor = true;
            this.btnCancelAddQuote.Click += new System.EventHandler(this.btnCancelAddQuote_Click);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 424);
            this.Controls.Add(this.btnCancelAddQuote);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNumDrawers);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblNumDrawers);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.panel1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblNumDrawers;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtNumDrawers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radLaminateMat;
        private System.Windows.Forms.RadioButton radRoseWoodMat;
        private System.Windows.Forms.RadioButton radOakMat;
        private System.Windows.Forms.RadioButton radVeneerMat;
        private System.Windows.Forms.RadioButton radPineMat;
        private System.Windows.Forms.RadioButton rad3days;
        private System.Windows.Forms.RadioButton rad7days;
        private System.Windows.Forms.RadioButton rad5days;
        private System.Windows.Forms.RadioButton rad14days;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnCancelAddQuote;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}