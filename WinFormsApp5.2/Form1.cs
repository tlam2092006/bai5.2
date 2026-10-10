namespace WinFormsApp5._2
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, List<ServiceItem>> servicesByCategory = new()
        {
            ["Khám bệnh"] =
            [
                new("Khám tổng quát", 150_000m),
                new("Khám chuyên khoa", 250_000m),
                new("Tái khám", 100_000m)
            ],
            ["Xét nghiệm"] =
            [
                new("Xét nghiệm máu", 120_000m),
                new("Xét nghiệm nước tiểu", 80_000m),
                new("Xét nghiệm sinh hóa", 200_000m)
            ],
            ["Chụp X-Quang"] =
            [
                new("X-Quang phổi", 250_000m),
                new("X-Quang xương", 300_000m),
                new("Chụp CT", 1_200_000m)
            ],
            ["Vắc-xin"] =
            [
                new("Vắc-xin cúm", 350_000m),
                new("Vắc-xin viêm gan B", 200_000m),
                new("Vắc-xin HPV", 1_500_000m)
            ]
        };
        private decimal discountRate;

        public Form1()
        {
            InitializeComponent();
            lstAvailableServices.Items.Clear();
            lstSelectedServices.Items.Clear();
            cboCategory.Items.AddRange(servicesByCategory.Keys.Cast<object>().ToArray());
            cboCategory.SelectedIndexChanged += (_, _) => LoadAvailableServices();
            lstAvailableServices.DoubleClick += (_, _) => SelectService();
            lstSelectedServices.DoubleClick += (_, _) => RemoveService();
            btnSelect.Click += (_, _) => SelectService();
            btnRemove.Click += (_, _) => RemoveService();
            btnClearAll.Click += (_, _) => ClearSelectedServices();
            btnApplyDiscount.Click += (_, _) => ApplyDiscountCode();
            btnClearDiscount.Click += (_, _) => ClearDiscountCode();
            cboCategory.SelectedIndex = 0;
            UpdateTotals();
        }

        private void LoadAvailableServices()
        {
            lstAvailableServices.Items.Clear();
            if (cboCategory.SelectedItem is not string category || !servicesByCategory.TryGetValue(category, out var services))
            {
                return;
            }

            foreach (var service in services)
            {
                if (!lstSelectedServices.Items.Cast<ServiceItem>().Any(selected => selected.Equals(service)))
                {
                    lstAvailableServices.Items.Add(service);
                }
            }
        }

        private void SelectService()
        {
            if (lstAvailableServices.SelectedItem is not ServiceItem service)
            {
                return;
            }

            lstSelectedServices.Items.Add(service);
            LoadAvailableServices();
            UpdateTotals();
        }

        private void RemoveService()
        {
            if (lstSelectedServices.SelectedItem is not ServiceItem service)
            {
                return;
            }

            lstSelectedServices.Items.Remove(service);
            LoadAvailableServices();
            UpdateTotals();
        }

        private void ClearSelectedServices()
        {
            lstSelectedServices.Items.Clear();
            LoadAvailableServices();
            UpdateTotals();
        }

        private void ApplyDiscountCode()
        {
            var code = txtDiscountCode.Text.Trim();
            var rate = code.ToUpperInvariant() switch
            {
                "GIAM10" => 10m,
                "GIAM20" => 20m,
                _ => -1m
            };

            if (rate < 0)
            {
                lblCouponStatus.ForeColor = Color.Firebrick;
                lblCouponStatus.Text = "Mã không hợp lệ (GIAM10 hoặc GIAM20).";
                return;
            }

            discountRate = rate;
            lblCouponStatus.ForeColor = Color.DarkGreen;
            lblCouponStatus.Text = $"Đã áp dụng mã {code.ToUpperInvariant()}.";
            UpdateTotals();
        }

        private void ClearDiscountCode()
        {
            txtDiscountCode.Clear();
            discountRate = 0;
            lblCouponStatus.ForeColor = SystemColors.ControlText;
            lblCouponStatus.Text = "";
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            var subtotal = lstSelectedServices.Items.Cast<ServiceItem>().Sum(service => service.Price);
            var discount = subtotal * discountRate / 100m;

            lblSubtotalValue.Text = FormatCurrency(subtotal);
            lblDiscountRateValue.Text = $"{discountRate:0.##}%";
            lblDiscountValue.Text = FormatCurrency(discount);
            lblTotalValue.Text = FormatCurrency(subtotal - discount);
        }

        private static string FormatCurrency(decimal amount) => $"{amount:N0} ₫";

        private sealed record ServiceItem(string Name, decimal Price)
        {
            public override string ToString() => $"{Name} - {FormatCurrency(Price)}";
        }
    }
}
