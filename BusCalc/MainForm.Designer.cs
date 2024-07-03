namespace BusCalc
{
    partial class MainForm
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
            this.ReceiptDisplay = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PaymentTxtBox = new System.Windows.Forms.TextBox();
            this.AmountTxt = new System.Windows.Forms.Label();
            this.QuantityTxt = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.FareTxt = new System.Windows.Forms.Label();
            this.CategoryTxt = new System.Windows.Forms.Label();
            this.DiscountedTxt = new System.Windows.Forms.Label();
            this.ChangeTxt = new System.Windows.Forms.Label();
            this.PWDBtn = new System.Windows.Forms.Button();
            this.StudentBtn = new System.Windows.Forms.Button();
            this.CitizenBtn = new System.Windows.Forms.Button();
            this.SeniorBtn = new System.Windows.Forms.Button();
            this.AvidaBtn = new System.Windows.Forms.Button();
            this.DelRoBtn = new System.Windows.Forms.Button();
            this.DoloresBtn = new System.Windows.Forms.Button();
            this.IntersectionBtn = new System.Windows.Forms.Button();
            this.PalengkeBtn = new System.Windows.Forms.Button();
            this.SanAgustineBtn = new System.Windows.Forms.Button();
            this.SanMiguelBtn = new System.Windows.Forms.Button();
            this.JBLBtn = new System.Windows.Forms.Button();
            this.QuebiauanBtn = new System.Windows.Forms.Button();
            this.SanIsidroBtn = new System.Windows.Forms.Button();
            this.SMTerminalBtn = new System.Windows.Forms.Button();
            this.MaimpisBtn = new System.Windows.Forms.Button();
            this.SakopBtn = new System.Windows.Forms.Button();
            this.SanFernandoBtn = new System.Windows.Forms.Button();
            this.WalterBtn = new System.Windows.Forms.Button();
            this.AmountTxtBox = new System.Windows.Forms.TextBox();
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.Discounttxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReceiptDisplay
            // 
            this.ReceiptDisplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ReceiptDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.ReceiptDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceiptDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceiptDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptDisplay.ForeColor = System.Drawing.Color.White;
            this.ReceiptDisplay.Location = new System.Drawing.Point(0, 649);
            this.ReceiptDisplay.Name = "ReceiptDisplay";
            this.ReceiptDisplay.Size = new System.Drawing.Size(375, 50);
            this.ReceiptDisplay.TabIndex = 0;
            this.ReceiptDisplay.Text = "Get Receipt";
            this.ReceiptDisplay.UseVisualStyleBackColor = false;
            this.ReceiptDisplay.Click += new System.EventHandler(this.ReceiptDisplay_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(282, 26);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(80, 40);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PaymentTxtBox
            // 
            this.PaymentTxtBox.Location = new System.Drawing.Point(0, 0);
            this.PaymentTxtBox.Name = "PaymentTxtBox";
            this.PaymentTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PaymentTxtBox.TabIndex = 0;
            // 
            // AmountTxt
            // 
            this.AmountTxt.AutoSize = true;
            this.AmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTxt.Location = new System.Drawing.Point(19, 499);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(69, 20);
            this.AmountTxt.TabIndex = 4;
            this.AmountTxt.Text = "Amount:";
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.AutoSize = true;
            this.QuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTxt.Location = new System.Drawing.Point(19, 304);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(72, 20);
            this.QuantityTxt.TabIndex = 6;
            this.QuantityTxt.Text = "Quantity:";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(100, 304);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(170, 20);
            this.Quantity.TabIndex = 5;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // FareTxt
            // 
            this.FareTxt.AutoSize = true;
            this.FareTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FareTxt.Location = new System.Drawing.Point(19, 342);
            this.FareTxt.Name = "FareTxt";
            this.FareTxt.Size = new System.Drawing.Size(46, 20);
            this.FareTxt.TabIndex = 7;
            this.FareTxt.Text = "Fare:";
            // 
            // CategoryTxt
            // 
            this.CategoryTxt.AutoSize = true;
            this.CategoryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTxt.Location = new System.Drawing.Point(19, 377);
            this.CategoryTxt.Name = "CategoryTxt";
            this.CategoryTxt.Size = new System.Drawing.Size(77, 20);
            this.CategoryTxt.TabIndex = 8;
            this.CategoryTxt.Text = "Category:";
            // 
            // DiscountedTxt
            // 
            this.DiscountedTxt.AutoSize = true;
            this.DiscountedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountedTxt.Location = new System.Drawing.Point(19, 461);
            this.DiscountedTxt.Name = "DiscountedTxt";
            this.DiscountedTxt.Size = new System.Drawing.Size(131, 20);
            this.DiscountedTxt.TabIndex = 9;
            this.DiscountedTxt.Text = "Discounted Fare:";
            // 
            // ChangeTxt
            // 
            this.ChangeTxt.AutoSize = true;
            this.ChangeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTxt.Location = new System.Drawing.Point(19, 539);
            this.ChangeTxt.Name = "ChangeTxt";
            this.ChangeTxt.Size = new System.Drawing.Size(69, 20);
            this.ChangeTxt.TabIndex = 10;
            this.ChangeTxt.Text = "Change:";
            // 
            // PWDBtn
            // 
            this.PWDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.PWDBtn.ForeColor = System.Drawing.Color.White;
            this.PWDBtn.Location = new System.Drawing.Point(102, 377);
            this.PWDBtn.Name = "PWDBtn";
            this.PWDBtn.Size = new System.Drawing.Size(48, 23);
            this.PWDBtn.TabIndex = 11;
            this.PWDBtn.Text = "PWD";
            this.PWDBtn.UseVisualStyleBackColor = false;
            this.PWDBtn.Click += new System.EventHandler(this.PWDBtn_Click);
            // 
            // StudentBtn
            // 
            this.StudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.StudentBtn.ForeColor = System.Drawing.Color.White;
            this.StudentBtn.Location = new System.Drawing.Point(156, 377);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.Size = new System.Drawing.Size(59, 23);
            this.StudentBtn.TabIndex = 12;
            this.StudentBtn.Text = "Student";
            this.StudentBtn.UseVisualStyleBackColor = false;
            this.StudentBtn.Click += new System.EventHandler(this.StudentBtn_Click);
            // 
            // CitizenBtn
            // 
            this.CitizenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.CitizenBtn.ForeColor = System.Drawing.Color.White;
            this.CitizenBtn.Location = new System.Drawing.Point(221, 377);
            this.CitizenBtn.Name = "CitizenBtn";
            this.CitizenBtn.Size = new System.Drawing.Size(59, 23);
            this.CitizenBtn.TabIndex = 13;
            this.CitizenBtn.Text = "Citizen";
            this.CitizenBtn.UseVisualStyleBackColor = false;
            this.CitizenBtn.Click += new System.EventHandler(this.CitizenBtn_Click);
            // 
            // SeniorBtn
            // 
            this.SeniorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.SeniorBtn.ForeColor = System.Drawing.Color.White;
            this.SeniorBtn.Location = new System.Drawing.Point(286, 377);
            this.SeniorBtn.Name = "SeniorBtn";
            this.SeniorBtn.Size = new System.Drawing.Size(59, 23);
            this.SeniorBtn.TabIndex = 14;
            this.SeniorBtn.Text = "Senior";
            this.SeniorBtn.UseVisualStyleBackColor = false;
            this.SeniorBtn.Click += new System.EventHandler(this.SeniorBtn_Click);
            // 
            // AvidaBtn
            // 
            this.AvidaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.AvidaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvidaBtn.ForeColor = System.Drawing.Color.White;
            this.AvidaBtn.Location = new System.Drawing.Point(11, 79);
            this.AvidaBtn.Name = "AvidaBtn";
            this.AvidaBtn.Size = new System.Drawing.Size(110, 30);
            this.AvidaBtn.TabIndex = 15;
            this.AvidaBtn.Text = "Avida";
            this.AvidaBtn.UseVisualStyleBackColor = false;
            this.AvidaBtn.Click += new System.EventHandler(this.AvidaBtn_Click);
            // 
            // DelRoBtn
            // 
            this.DelRoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.DelRoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelRoBtn.ForeColor = System.Drawing.Color.White;
            this.DelRoBtn.Location = new System.Drawing.Point(128, 79);
            this.DelRoBtn.Name = "DelRoBtn";
            this.DelRoBtn.Size = new System.Drawing.Size(118, 30);
            this.DelRoBtn.TabIndex = 16;
            this.DelRoBtn.Text = "Del Rosario";
            this.DelRoBtn.UseVisualStyleBackColor = false;
            this.DelRoBtn.Click += new System.EventHandler(this.DelRoBtn_Click);
            // 
            // DoloresBtn
            // 
            this.DoloresBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.DoloresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoloresBtn.ForeColor = System.Drawing.Color.White;
            this.DoloresBtn.Location = new System.Drawing.Point(252, 79);
            this.DoloresBtn.Name = "DoloresBtn";
            this.DoloresBtn.Size = new System.Drawing.Size(110, 30);
            this.DoloresBtn.TabIndex = 17;
            this.DoloresBtn.Text = "Dolores";
            this.DoloresBtn.UseVisualStyleBackColor = false;
            this.DoloresBtn.Click += new System.EventHandler(this.DoloresBtn_Click);
            // 
            // IntersectionBtn
            // 
            this.IntersectionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.IntersectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntersectionBtn.ForeColor = System.Drawing.Color.White;
            this.IntersectionBtn.Location = new System.Drawing.Point(11, 115);
            this.IntersectionBtn.Name = "IntersectionBtn";
            this.IntersectionBtn.Size = new System.Drawing.Size(110, 30);
            this.IntersectionBtn.TabIndex = 18;
            this.IntersectionBtn.Text = "Intersection";
            this.IntersectionBtn.UseVisualStyleBackColor = false;
            this.IntersectionBtn.Click += new System.EventHandler(this.IntersectionBtn_Click);
            // 
            // PalengkeBtn
            // 
            this.PalengkeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.PalengkeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalengkeBtn.ForeColor = System.Drawing.Color.White;
            this.PalengkeBtn.Location = new System.Drawing.Point(11, 151);
            this.PalengkeBtn.Name = "PalengkeBtn";
            this.PalengkeBtn.Size = new System.Drawing.Size(110, 30);
            this.PalengkeBtn.TabIndex = 19;
            this.PalengkeBtn.Text = "Palengke";
            this.PalengkeBtn.UseVisualStyleBackColor = false;
            this.PalengkeBtn.Click += new System.EventHandler(this.PalengkeBtn_Click);
            // 
            // SanAgustineBtn
            // 
            this.SanAgustineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.SanAgustineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanAgustineBtn.ForeColor = System.Drawing.Color.White;
            this.SanAgustineBtn.Location = new System.Drawing.Point(11, 187);
            this.SanAgustineBtn.Name = "SanAgustineBtn";
            this.SanAgustineBtn.Size = new System.Drawing.Size(110, 30);
            this.SanAgustineBtn.TabIndex = 20;
            this.SanAgustineBtn.Text = "SanAgustine";
            this.SanAgustineBtn.UseVisualStyleBackColor = false;
            this.SanAgustineBtn.Click += new System.EventHandler(this.SanAgustineBtn_Click);
            // 
            // SanMiguelBtn
            // 
            this.SanMiguelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.SanMiguelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanMiguelBtn.ForeColor = System.Drawing.Color.White;
            this.SanMiguelBtn.Location = new System.Drawing.Point(11, 223);
            this.SanMiguelBtn.Name = "SanMiguelBtn";
            this.SanMiguelBtn.Size = new System.Drawing.Size(110, 30);
            this.SanMiguelBtn.TabIndex = 21;
            this.SanMiguelBtn.Text = "San Miguel";
            this.SanMiguelBtn.UseVisualStyleBackColor = false;
            this.SanMiguelBtn.Click += new System.EventHandler(this.SanMiguelBtn_Click);
            // 
            // JBLBtn
            // 
            this.JBLBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.JBLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JBLBtn.ForeColor = System.Drawing.Color.White;
            this.JBLBtn.Location = new System.Drawing.Point(128, 115);
            this.JBLBtn.Name = "JBLBtn";
            this.JBLBtn.Size = new System.Drawing.Size(118, 30);
            this.JBLBtn.TabIndex = 22;
            this.JBLBtn.Text = "JBL";
            this.JBLBtn.UseVisualStyleBackColor = false;
            this.JBLBtn.Click += new System.EventHandler(this.JBLBtn_Click);
            // 
            // QuebiauanBtn
            // 
            this.QuebiauanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.QuebiauanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuebiauanBtn.ForeColor = System.Drawing.Color.White;
            this.QuebiauanBtn.Location = new System.Drawing.Point(128, 151);
            this.QuebiauanBtn.Name = "QuebiauanBtn";
            this.QuebiauanBtn.Size = new System.Drawing.Size(118, 30);
            this.QuebiauanBtn.TabIndex = 23;
            this.QuebiauanBtn.Text = "Quebiauan";
            this.QuebiauanBtn.UseVisualStyleBackColor = false;
            this.QuebiauanBtn.Click += new System.EventHandler(this.QuebiauanBtn_Click);
            // 
            // SanIsidroBtn
            // 
            this.SanIsidroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.SanIsidroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanIsidroBtn.ForeColor = System.Drawing.Color.White;
            this.SanIsidroBtn.Location = new System.Drawing.Point(128, 187);
            this.SanIsidroBtn.Name = "SanIsidroBtn";
            this.SanIsidroBtn.Size = new System.Drawing.Size(118, 30);
            this.SanIsidroBtn.TabIndex = 24;
            this.SanIsidroBtn.Text = "San Isidro";
            this.SanIsidroBtn.UseVisualStyleBackColor = false;
            this.SanIsidroBtn.Click += new System.EventHandler(this.SanIsidroBtn_Click);
            // 
            // SMTerminalBtn
            // 
            this.SMTerminalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.SMTerminalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMTerminalBtn.ForeColor = System.Drawing.Color.White;
            this.SMTerminalBtn.Location = new System.Drawing.Point(128, 223);
            this.SMTerminalBtn.Name = "SMTerminalBtn";
            this.SMTerminalBtn.Size = new System.Drawing.Size(118, 30);
            this.SMTerminalBtn.TabIndex = 25;
            this.SMTerminalBtn.Text = "SM Terminal";
            this.SMTerminalBtn.UseVisualStyleBackColor = false;
            this.SMTerminalBtn.Click += new System.EventHandler(this.SMTerminalBtn_Click);
            // 
            // MaimpisBtn
            // 
            this.MaimpisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.MaimpisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaimpisBtn.ForeColor = System.Drawing.Color.White;
            this.MaimpisBtn.Location = new System.Drawing.Point(252, 115);
            this.MaimpisBtn.Name = "MaimpisBtn";
            this.MaimpisBtn.Size = new System.Drawing.Size(110, 30);
            this.MaimpisBtn.TabIndex = 26;
            this.MaimpisBtn.Text = "Maimpis";
            this.MaimpisBtn.UseVisualStyleBackColor = false;
            this.MaimpisBtn.Click += new System.EventHandler(this.MaimpisBtn_Click);
            // 
            // SakopBtn
            // 
            this.SakopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.SakopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SakopBtn.ForeColor = System.Drawing.Color.White;
            this.SakopBtn.Location = new System.Drawing.Point(252, 151);
            this.SakopBtn.Name = "SakopBtn";
            this.SakopBtn.Size = new System.Drawing.Size(110, 30);
            this.SakopBtn.TabIndex = 27;
            this.SakopBtn.Text = "Sakop";
            this.SakopBtn.UseVisualStyleBackColor = false;
            this.SakopBtn.Click += new System.EventHandler(this.SakopBtn_Click);
            // 
            // SanFernandoBtn
            // 
            this.SanFernandoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.SanFernandoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanFernandoBtn.ForeColor = System.Drawing.Color.White;
            this.SanFernandoBtn.Location = new System.Drawing.Point(252, 187);
            this.SanFernandoBtn.Name = "SanFernandoBtn";
            this.SanFernandoBtn.Size = new System.Drawing.Size(110, 30);
            this.SanFernandoBtn.TabIndex = 28;
            this.SanFernandoBtn.Text = "SanFernando";
            this.SanFernandoBtn.UseVisualStyleBackColor = false;
            this.SanFernandoBtn.Click += new System.EventHandler(this.SanFernandoBtn_Click);
            // 
            // WalterBtn
            // 
            this.WalterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.WalterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalterBtn.ForeColor = System.Drawing.Color.White;
            this.WalterBtn.Location = new System.Drawing.Point(252, 223);
            this.WalterBtn.Name = "WalterBtn";
            this.WalterBtn.Size = new System.Drawing.Size(110, 30);
            this.WalterBtn.TabIndex = 29;
            this.WalterBtn.Text = "Walter";
            this.WalterBtn.UseVisualStyleBackColor = false;
            this.WalterBtn.Click += new System.EventHandler(this.WalterBtn_Click);
            // 
            // AmountTxtBox
            // 
            this.AmountTxtBox.Location = new System.Drawing.Point(104, 499);
            this.AmountTxtBox.Multiline = true;
            this.AmountTxtBox.Name = "AmountTxtBox";
            this.AmountTxtBox.Size = new System.Drawing.Size(170, 20);
            this.AmountTxtBox.TabIndex = 31;
            this.AmountTxtBox.TextChanged += new System.EventHandler(this.AmountTxtBox_TextChanged);
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.Calculatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculatebtn.ForeColor = System.Drawing.Color.White;
            this.Calculatebtn.Location = new System.Drawing.Point(128, 589);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(114, 39);
            this.Calculatebtn.TabIndex = 33;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.UseVisualStyleBackColor = false;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click);
            // 
            // Discounttxt
            // 
            this.Discounttxt.AutoSize = true;
            this.Discounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discounttxt.Location = new System.Drawing.Point(19, 423);
            this.Discounttxt.Name = "Discounttxt";
            this.Discounttxt.Size = new System.Drawing.Size(76, 20);
            this.Discounttxt.TabIndex = 34;
            this.Discounttxt.Text = "Discount:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 699);
            this.Controls.Add(this.Discounttxt);
            this.Controls.Add(this.Calculatebtn);
            this.Controls.Add(this.AmountTxtBox);
            this.Controls.Add(this.WalterBtn);
            this.Controls.Add(this.SanFernandoBtn);
            this.Controls.Add(this.SakopBtn);
            this.Controls.Add(this.MaimpisBtn);
            this.Controls.Add(this.SMTerminalBtn);
            this.Controls.Add(this.SanIsidroBtn);
            this.Controls.Add(this.QuebiauanBtn);
            this.Controls.Add(this.JBLBtn);
            this.Controls.Add(this.SanMiguelBtn);
            this.Controls.Add(this.SanAgustineBtn);
            this.Controls.Add(this.PalengkeBtn);
            this.Controls.Add(this.IntersectionBtn);
            this.Controls.Add(this.DoloresBtn);
            this.Controls.Add(this.DelRoBtn);
            this.Controls.Add(this.AvidaBtn);
            this.Controls.Add(this.SeniorBtn);
            this.Controls.Add(this.CitizenBtn);
            this.Controls.Add(this.StudentBtn);
            this.Controls.Add(this.PWDBtn);
            this.Controls.Add(this.ChangeTxt);
            this.Controls.Add(this.DiscountedTxt);
            this.Controls.Add(this.CategoryTxt);
            this.Controls.Add(this.FareTxt);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ReceiptDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReceiptDisplay;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox Payment;
        private System.Windows.Forms.Label AmountTxt;
        private System.Windows.Forms.Label QuantityTxt;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label FareTxt;
        private System.Windows.Forms.Label CategoryTxt;
        private System.Windows.Forms.Label DiscountedTxt;
        private System.Windows.Forms.Label ChangeTxt;
        private System.Windows.Forms.Button PWDBtn;
        private System.Windows.Forms.Button StudentBtn;
        private System.Windows.Forms.Button CitizenBtn;
        private System.Windows.Forms.Button SeniorBtn;
        private System.Windows.Forms.Button AvidaBtn;
        private System.Windows.Forms.Button DelRoBtn;
        private System.Windows.Forms.Button DoloresBtn;
        private System.Windows.Forms.Button IntersectionBtn;
        private System.Windows.Forms.Button PalengkeBtn;
        private System.Windows.Forms.Button SanAgustineBtn;
        private System.Windows.Forms.Button SanMiguelBtn;
        private System.Windows.Forms.Button JBLBtn;
        private System.Windows.Forms.Button QuebiauanBtn;
        private System.Windows.Forms.Button SanIsidroBtn;
        private System.Windows.Forms.Button SMTerminalBtn;
        private System.Windows.Forms.Button MaimpisBtn;
        private System.Windows.Forms.Button SakopBtn;
        private System.Windows.Forms.Button SanFernandoBtn;
        private System.Windows.Forms.Button WalterBtn;
        private System.Windows.Forms.TextBox AmountTxtBox;
        private System.Windows.Forms.TextBox PaymentTxtBox;
        private System.Windows.Forms.Button Calculatebtn;
        private System.Windows.Forms.Label Discounttxt;
    }
}

