namespace WinFormsApp5._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ComboBox cboCategory;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Label lblSubtotalValue;
        private Label lblDiscountValue;
        private Label lblTotalValue;
        private Label lblDiscountRateValue;
        private TextBox txtDiscountCode;
        private Label lblCouponStatus;
        private GroupBox grpPayment;
        private Label lblCategory;
        private Label lblAvailableServices;
        private Label lblSelectedServices;
        private Label lblSubtotal;
        private Label lblDiscountCode;
        private Label lblDiscountRate;
        private Label lblDiscountAmount;
        private Label lblTotal;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private Button btnApplyDiscount;
        private Button btnClearDiscount;

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
            components = new System.ComponentModel.Container();
            cboCategory = new ComboBox();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            lblSubtotalValue = new Label();
            lblDiscountValue = new Label();
            lblTotalValue = new Label();
            lblDiscountRateValue = new Label();
            txtDiscountCode = new TextBox();
            lblCouponStatus = new Label();
            grpPayment = new GroupBox();
            lblCategory = new Label();
            lblAvailableServices = new Label();
            lblSelectedServices = new Label();
            lblSubtotal = new Label();
            lblDiscountCode = new Label();
            lblDiscountRate = new Label();
            lblDiscountAmount = new Label();
            lblTotal = new Label();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            btnApplyDiscount = new Button();
            btnClearDiscount = new Button();
            grpPayment.SuspendLayout();
            SuspendLayout();

            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(30, 25);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(93, 20);
            lblCategory.Text = "Loại dịch vụ:";

            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(160, 22);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(320, 28);
            cboCategory.TabIndex = 0;

            lblAvailableServices.AutoSize = true;
            lblAvailableServices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvailableServices.Location = new Point(30, 75);
            lblAvailableServices.Name = "lblAvailableServices";
            lblAvailableServices.Size = new Size(132, 19);
            lblAvailableServices.Text = "Dịch vụ hiện có";

            lblSelectedServices.AutoSize = true;
            lblSelectedServices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelectedServices.Location = new Point(590, 75);
            lblSelectedServices.Name = "lblSelectedServices";
            lblSelectedServices.Size = new Size(136, 19);
            lblSelectedServices.Text = "Dịch vụ đã chọn";

            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.HorizontalScrollbar = true;
            lstAvailableServices.ItemHeight = 20;
            lstAvailableServices.Items.AddRange(new object[] { "Khám tổng quát - 150.000 ₫" });
            lstAvailableServices.Location = new Point(30, 108);
            lstAvailableServices.Name = "lstDichVuHienCo";
            lstAvailableServices.Size = new Size(380, 324);
            lstAvailableServices.TabIndex = 1;

            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.HorizontalScrollbar = true;
            lstSelectedServices.ItemHeight = 20;
            lstSelectedServices.Items.AddRange(new object[] { "Chưa có dịch vụ được chọn" });
            lstSelectedServices.Location = new Point(590, 108);
            lstSelectedServices.Name = "lstDichVuDaChon";
            lstSelectedServices.Size = new Size(380, 324);
            lstSelectedServices.TabIndex = 2;

            btnSelect.Location = new Point(435, 165);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(110, 34);
            btnSelect.TabIndex = 3;
            btnSelect.Text = "Chọn >";
            btnSelect.UseVisualStyleBackColor = true;

            btnRemove.Location = new Point(435, 215);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(110, 34);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Bỏ <";
            btnRemove.UseVisualStyleBackColor = true;

            btnClearAll.Location = new Point(435, 265);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(110, 34);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "Xóa hết <<";
            btnClearAll.UseVisualStyleBackColor = true;

            grpPayment.Controls.Add(lblSubtotal);
            grpPayment.Controls.Add(lblSubtotalValue);
            grpPayment.Controls.Add(lblDiscountCode);
            grpPayment.Controls.Add(txtDiscountCode);
            grpPayment.Controls.Add(btnApplyDiscount);
            grpPayment.Controls.Add(btnClearDiscount);
            grpPayment.Controls.Add(lblDiscountRate);
            grpPayment.Controls.Add(lblDiscountRateValue);
            grpPayment.Controls.Add(lblDiscountAmount);
            grpPayment.Controls.Add(lblDiscountValue);
            grpPayment.Controls.Add(lblTotal);
            grpPayment.Controls.Add(lblTotalValue);
            grpPayment.Controls.Add(lblCouponStatus);
            grpPayment.Location = new Point(30, 455);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(940, 210);
            grpPayment.TabIndex = 6;
            grpPayment.TabStop = false;
            grpPayment.Text = "Thanh toán";

            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(20, 37);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(150, 20);
            lblSubtotal.Text = "Tổng tiền chưa giảm:";
            lblSubtotalValue.Location = new Point(220, 32);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(190, 30);
            lblSubtotalValue.TextAlign = ContentAlignment.MiddleLeft;

            lblDiscountCode.AutoSize = true;
            lblDiscountCode.Location = new Point(20, 77);
            lblDiscountCode.Name = "lblDiscountCode";
            lblDiscountCode.Size = new Size(102, 20);
            lblDiscountCode.Text = "Mã giảm giá:";
            txtDiscountCode.Location = new Point(160, 72);
            txtDiscountCode.MaxLength = 20;
            txtDiscountCode.Name = "txtDiscountCode";
            txtDiscountCode.PlaceholderText = "Nhập mã giảm giá";
            txtDiscountCode.Size = new Size(150, 27);
            txtDiscountCode.TabIndex = 7;

            btnApplyDiscount.Location = new Point(320, 71);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(100, 34);
            btnApplyDiscount.TabIndex = 8;
            btnApplyDiscount.Text = "Áp dụng";
            btnApplyDiscount.UseVisualStyleBackColor = true;
            btnClearDiscount.Location = new Point(430, 71);
            btnClearDiscount.Name = "btnClearDiscount";
            btnClearDiscount.Size = new Size(90, 34);
            btnClearDiscount.TabIndex = 9;
            btnClearDiscount.Text = "Xóa mã";
            btnClearDiscount.UseVisualStyleBackColor = true;

            lblDiscountRate.AutoSize = true;
            lblDiscountRate.Location = new Point(20, 121);
            lblDiscountRate.Name = "lblDiscountRate";
            lblDiscountRate.Size = new Size(129, 20);
            lblDiscountRate.Text = "Tỷ lệ chiết khấu:";
            lblDiscountRateValue.Location = new Point(220, 116);
            lblDiscountRateValue.Name = "lblDiscountRateValue";
            lblDiscountRateValue.Size = new Size(190, 30);
            lblDiscountRateValue.TextAlign = ContentAlignment.MiddleLeft;
            lblDiscountAmount.AutoSize = true;
            lblDiscountAmount.Location = new Point(430, 121);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(120, 20);
            lblDiscountAmount.Text = "Tiền được giảm:";
            lblDiscountValue.Location = new Point(585, 116);
            lblDiscountValue.Name = "lblDiscountValue";
            lblDiscountValue.Size = new Size(180, 30);
            lblDiscountValue.TextAlign = ContentAlignment.MiddleLeft;

            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(20, 162);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(176, 19);
            lblTotal.Text = "Thành tiền thanh toán:";
            lblTotalValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalValue.Location = new Point(220, 155);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(350, 30);
            lblTotalValue.TextAlign = ContentAlignment.MiddleLeft;
            lblCouponStatus.Location = new Point(530, 73);
            lblCouponStatus.Name = "lblCouponStatus";
            lblCouponStatus.Size = new Size(380, 28);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 710);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblAvailableServices);
            Controls.Add(lblSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(lstSelectedServices);
            Controls.Add(btnSelect);
            Controls.Add(btnRemove);
            Controls.Add(btnClearAll);
            Controls.Add(grpPayment);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(900, 680);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng tính tiền dịch vụ và chiết khấu đơn hàng";
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
