namespace IFSPStore.App.Cadastros
{
    partial class SaleForm
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
            txtSaleDate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboUser = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCustomer = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox1 = new GroupBox();
            dataGridViewItens = new DataGridView();
            btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            txtTotalPrice = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAmount = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSaleUnit = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboProduct = new ReaLTaiizor.Controls.MaterialComboBox();
            lblQtdItens = new ReaLTaiizor.Controls.MaterialLabel();
            lblTotalPrice = new ReaLTaiizor.Controls.MaterialLabel();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Size = new Size(790, 450);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblTotalPrice);
            tabPage1.Controls.Add(lblQtdItens);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(cboCustomer);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(cboUser);
            tabPage1.Controls.Add(txtSaleDate);
            tabPage1.Controls.SetChildIndex(txtSaleDate, 0);
            tabPage1.Controls.SetChildIndex(cboUser, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(cboCustomer, 0);
            tabPage1.Controls.SetChildIndex(groupBox1, 0);
            tabPage1.Controls.SetChildIndex(lblQtdItens, 0);
            tabPage1.Controls.SetChildIndex(lblTotalPrice, 0);
            // 
            // txtSaleDate
            // 
            txtSaleDate.AllowPromptAsInput = true;
            txtSaleDate.AnimateReadOnly = false;
            txtSaleDate.AsciiOnly = false;
            txtSaleDate.BackgroundImageLayout = ImageLayout.None;
            txtSaleDate.BeepOnError = false;
            txtSaleDate.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSaleDate.Depth = 0;
            txtSaleDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSaleDate.HidePromptOnLeave = false;
            txtSaleDate.HideSelection = true;
            txtSaleDate.Hint = "Sale Date";
            txtSaleDate.InsertKeyMode = InsertKeyMode.Default;
            txtSaleDate.LeadingIcon = null;
            txtSaleDate.Location = new Point(6, 6);
            txtSaleDate.Mask = "99/99/9999";
            txtSaleDate.MaxLength = 32767;
            txtSaleDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSaleDate.Name = "txtSaleDate";
            txtSaleDate.PasswordChar = '\0';
            txtSaleDate.PrefixSuffixText = null;
            txtSaleDate.PromptChar = '_';
            txtSaleDate.ReadOnly = false;
            txtSaleDate.RejectInputOnFirstFailure = false;
            txtSaleDate.ResetOnPrompt = true;
            txtSaleDate.ResetOnSpace = true;
            txtSaleDate.RightToLeft = RightToLeft.No;
            txtSaleDate.SelectedText = "";
            txtSaleDate.SelectionLength = 0;
            txtSaleDate.SelectionStart = 0;
            txtSaleDate.ShortcutsEnabled = true;
            txtSaleDate.Size = new Size(353, 48);
            txtSaleDate.SkipLiterals = true;
            txtSaleDate.TabIndex = 3;
            txtSaleDate.TabStop = false;
            txtSaleDate.Text = "  /  /";
            txtSaleDate.TextAlign = HorizontalAlignment.Left;
            txtSaleDate.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSaleDate.TrailingIcon = null;
            txtSaleDate.UseSystemPasswordChar = false;
            txtSaleDate.ValidatingType = null;
            // 
            // cboUser
            // 
            cboUser.AutoResize = false;
            cboUser.BackColor = Color.FromArgb(255, 255, 255);
            cboUser.Depth = 0;
            cboUser.DrawMode = DrawMode.OwnerDrawVariable;
            cboUser.DropDownHeight = 174;
            cboUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUser.DropDownWidth = 121;
            cboUser.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboUser.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboUser.FormattingEnabled = true;
            cboUser.Hint = "User";
            cboUser.IntegralHeight = false;
            cboUser.ItemHeight = 43;
            cboUser.Location = new Point(365, 7);
            cboUser.MaxDropDownItems = 4;
            cboUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUser.Name = "cboUser";
            cboUser.Size = new Size(281, 49);
            cboUser.StartIndex = 0;
            cboUser.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(652, 7);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(132, 48);
            txtId.TabIndex = 5;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboCustomer
            // 
            cboCustomer.AutoResize = false;
            cboCustomer.BackColor = Color.FromArgb(255, 255, 255);
            cboCustomer.Depth = 0;
            cboCustomer.DrawMode = DrawMode.OwnerDrawVariable;
            cboCustomer.DropDownHeight = 174;
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomer.DropDownWidth = 121;
            cboCustomer.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Hint = "Customer";
            cboCustomer.IntegralHeight = false;
            cboCustomer.ItemHeight = 43;
            cboCustomer.Location = new Point(6, 60);
            cboCustomer.MaxDropDownItems = 4;
            cboCustomer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(778, 49);
            cboCustomer.StartIndex = 0;
            cboCustomer.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewItens);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtTotalPrice);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(txtSaleUnit);
            groupBox1.Controls.Add(cboProduct);
            groupBox1.Location = new Point(6, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 281);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridViewItens
            // 
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Location = new Point(6, 77);
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.Size = new Size(766, 182);
            dataGridViewItens.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdd.Location = new Point(707, 25);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.AnimateReadOnly = false;
            txtTotalPrice.AutoCompleteMode = AutoCompleteMode.None;
            txtTotalPrice.AutoCompleteSource = AutoCompleteSource.None;
            txtTotalPrice.BackgroundImageLayout = ImageLayout.None;
            txtTotalPrice.CharacterCasing = CharacterCasing.Normal;
            txtTotalPrice.Depth = 0;
            txtTotalPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalPrice.HideSelection = true;
            txtTotalPrice.Hint = "Total Price";
            txtTotalPrice.LeadingIcon = null;
            txtTotalPrice.Location = new Point(554, 22);
            txtTotalPrice.MaxLength = 32767;
            txtTotalPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.PasswordChar = '\0';
            txtTotalPrice.PrefixSuffixText = null;
            txtTotalPrice.ReadOnly = false;
            txtTotalPrice.RightToLeft = RightToLeft.No;
            txtTotalPrice.SelectedText = "";
            txtTotalPrice.SelectionLength = 0;
            txtTotalPrice.SelectionStart = 0;
            txtTotalPrice.ShortcutsEnabled = true;
            txtTotalPrice.Size = new Size(146, 48);
            txtTotalPrice.TabIndex = 3;
            txtTotalPrice.TabStop = false;
            txtTotalPrice.TextAlign = HorizontalAlignment.Left;
            txtTotalPrice.TrailingIcon = null;
            txtTotalPrice.UseSystemPasswordChar = false;
            // 
            // txtAmount
            // 
            txtAmount.AnimateReadOnly = false;
            txtAmount.AutoCompleteMode = AutoCompleteMode.None;
            txtAmount.AutoCompleteSource = AutoCompleteSource.None;
            txtAmount.BackgroundImageLayout = ImageLayout.None;
            txtAmount.CharacterCasing = CharacterCasing.Normal;
            txtAmount.Depth = 0;
            txtAmount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAmount.HideSelection = true;
            txtAmount.Hint = "amount";
            txtAmount.LeadingIcon = null;
            txtAmount.Location = new Point(402, 22);
            txtAmount.MaxLength = 32767;
            txtAmount.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '\0';
            txtAmount.PrefixSuffixText = null;
            txtAmount.ReadOnly = false;
            txtAmount.RightToLeft = RightToLeft.No;
            txtAmount.SelectedText = "";
            txtAmount.SelectionLength = 0;
            txtAmount.SelectionStart = 0;
            txtAmount.ShortcutsEnabled = true;
            txtAmount.Size = new Size(146, 48);
            txtAmount.TabIndex = 2;
            txtAmount.TabStop = false;
            txtAmount.TextAlign = HorizontalAlignment.Left;
            txtAmount.TrailingIcon = null;
            txtAmount.UseSystemPasswordChar = false;
            txtAmount.Leave += txtQuantity_Leave;
            // 
            // txtSaleUnit
            // 
            txtSaleUnit.AnimateReadOnly = false;
            txtSaleUnit.AutoCompleteMode = AutoCompleteMode.None;
            txtSaleUnit.AutoCompleteSource = AutoCompleteSource.None;
            txtSaleUnit.BackgroundImageLayout = ImageLayout.None;
            txtSaleUnit.CharacterCasing = CharacterCasing.Normal;
            txtSaleUnit.Depth = 0;
            txtSaleUnit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSaleUnit.HideSelection = true;
            txtSaleUnit.Hint = "SaleUnit";
            txtSaleUnit.LeadingIcon = null;
            txtSaleUnit.Location = new Point(250, 22);
            txtSaleUnit.MaxLength = 32767;
            txtSaleUnit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSaleUnit.Name = "txtSaleUnit";
            txtSaleUnit.PasswordChar = '\0';
            txtSaleUnit.PrefixSuffixText = null;
            txtSaleUnit.ReadOnly = false;
            txtSaleUnit.RightToLeft = RightToLeft.No;
            txtSaleUnit.SelectedText = "";
            txtSaleUnit.SelectionLength = 0;
            txtSaleUnit.SelectionStart = 0;
            txtSaleUnit.ShortcutsEnabled = true;
            txtSaleUnit.Size = new Size(146, 48);
            txtSaleUnit.TabIndex = 1;
            txtSaleUnit.TabStop = false;
            txtSaleUnit.TextAlign = HorizontalAlignment.Left;
            txtSaleUnit.TrailingIcon = null;
            txtSaleUnit.UseSystemPasswordChar = false;
            // 
            // cboProduct
            // 
            cboProduct.AutoResize = false;
            cboProduct.BackColor = Color.FromArgb(255, 255, 255);
            cboProduct.Depth = 0;
            cboProduct.DrawMode = DrawMode.OwnerDrawVariable;
            cboProduct.DropDownHeight = 174;
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.DropDownWidth = 121;
            cboProduct.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProduct.FormattingEnabled = true;
            cboProduct.Hint = "Product";
            cboProduct.IntegralHeight = false;
            cboProduct.ItemHeight = 43;
            cboProduct.Location = new Point(0, 22);
            cboProduct.MaxDropDownItems = 4;
            cboProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(244, 49);
            cboProduct.StartIndex = 0;
            cboProduct.TabIndex = 0;
            // 
            // lblQtdItens
            // 
            lblQtdItens.AutoSize = true;
            lblQtdItens.Depth = 0;
            lblQtdItens.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblQtdItens.Location = new Point(12, 377);
            lblQtdItens.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblQtdItens.Name = "lblQtdItens";
            lblQtdItens.Size = new Size(141, 19);
            lblQtdItens.TabIndex = 8;
            lblQtdItens.Text = "Amount Products: 0";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Depth = 0;
            lblTotalPrice.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalPrice.Location = new Point(350, 377);
            lblTotalPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(94, 19);
            lblTotalPrice.TabIndex = 9;
            lblTotalPrice.Text = "Total Price: 0";
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 552);
            Location = new Point(0, 0);
            Name = "SaleForm";
            Text = "SaleForm";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboUser;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtSaleDate;
        private ReaLTaiizor.Controls.MaterialComboBox cboCustomer;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotalPrice;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAmount;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSaleUnit;
        private ReaLTaiizor.Controls.MaterialComboBox cboProduct;
        private DataGridView dataGridViewItens;
        private ReaLTaiizor.Controls.MaterialLabel lblTotalPrice;
        private ReaLTaiizor.Controls.MaterialLabel lblQtdItens;
    }
}