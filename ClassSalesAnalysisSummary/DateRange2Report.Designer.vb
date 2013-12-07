Partial Class DateRange2Report
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DateRange2Report))
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter5 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.sales_rep_assoc_nbrCaptionTextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.sales_rep_assoc_nbrGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.sales_rep_assoc_nbrGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.cust_nbrGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.sales_item_qtySumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.sales_dtCountFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.cust_nbrGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.sales_dtDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_inv_idDataTextBox = New Telerik.Reporting.TextBox()
        Me.item_nbrDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_costDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_priceDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_qtyDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Parameters.dDetail.Value", Telerik.Reporting.FilterOperator.Equal, "FALSE"))
        FormattingRule1.Style.Visible = False
        Me.labelsGroupHeaderSection.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox19, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.sales_rep_assoc_nbrCaptionTextBox1, Me.TextBox17, Me.TextBox18, Me.TextBox9})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        Me.labelsGroupHeaderSection.Style.Visible = False
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.00088262557983398438R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69996076822280884R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = "Caption"
        Me.TextBox19.Value = "  Invoice Date" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.5000391006469727R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69996136426925659R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.StyleName = "Caption"
        Me.TextBox11.Value = "Markup"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.5937895774841309R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.StyleName = "Caption"
        Me.TextBox12.Value = "Ext Price"
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = True
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7917060852050781R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7998422384262085R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.StyleName = "Caption"
        Me.TextBox13.Value = "Ext Cost"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = True
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.7917060852050781R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99976414442062378R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.StyleName = "Caption"
        Me.TextBox14.Value = "Item Price"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8958725929260254R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89575493335723877R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.StyleName = "Caption"
        Me.TextBox15.Value = "Item Cost"
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9000003337860107R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99579322338104248R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.StyleName = "Caption"
        Me.TextBox16.Value = " Shipped Qty" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'sales_rep_assoc_nbrCaptionTextBox1
        '
        Me.sales_rep_assoc_nbrCaptionTextBox1.CanGrow = True
        Me.sales_rep_assoc_nbrCaptionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1985111236572266R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_rep_assoc_nbrCaptionTextBox1.Name = "sales_rep_assoc_nbrCaptionTextBox1"
        Me.sales_rep_assoc_nbrCaptionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.700556218624115R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_rep_assoc_nbrCaptionTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_rep_assoc_nbrCaptionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_rep_assoc_nbrCaptionTextBox1.StyleName = "Caption"
        Me.sales_rep_assoc_nbrCaptionTextBox1.Value = " Sales Rep"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = True
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4896227121353149R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.708809494972229R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.StyleName = "Caption"
        Me.TextBox17.Value = "Item "
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6878771185874939R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.StyleName = "Caption"
        Me.TextBox18.Value = "Invoice"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.2000007629394531R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70511370897293091R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.StyleName = "Caption"
        Me.TextBox9.Value = "Margin%"
        '
        'sales_rep_assoc_nbrGroupFooterSection
        '
        Me.sales_rep_assoc_nbrGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125R)
        Me.sales_rep_assoc_nbrGroupFooterSection.Name = "sales_rep_assoc_nbrGroupFooterSection"
        Me.sales_rep_assoc_nbrGroupFooterSection.Style.Visible = False
        '
        'sales_rep_assoc_nbrGroupHeaderSection
        '
        Me.sales_rep_assoc_nbrGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.10843158513307571R)
        Me.sales_rep_assoc_nbrGroupHeaderSection.Name = "sales_rep_assoc_nbrGroupHeaderSection"
        Me.sales_rep_assoc_nbrGroupHeaderSection.Style.Visible = False
        '
        'cust_nbrGroupFooterSection
        '
        Me.cust_nbrGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20628936588764191R)
        Me.cust_nbrGroupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox6, Me.TextBox8, Me.sales_item_qtySumFunctionTextBox1, Me.sales_dtCountFunctionTextBox1, Me.TextBox7, Me.TextBox10})
        Me.cust_nbrGroupFooterSection.Name = "cust_nbrGroupFooterSection"
        Me.cust_nbrGroupFooterSection.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.cust_nbrGroupFooterSection.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = True
        Me.TextBox1.Format = "{0:P2}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49992063641548157R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TextBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.StyleName = "Data"
        Me.TextBox1.Value = "=Sum(Fields.Markup2) / SUM(fields.ExtPrice2)"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = True
        Me.TextBox6.Format = "{0:N2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.1604170799255371R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.666947603225708R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.TextBox6.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TextBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox6.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.StyleName = "Data"
        Me.TextBox6.Value = "=Sum(Fields.Markup2)"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = True
        Me.TextBox8.Format = "{0:N2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.68541860580444336R), Telerik.Reporting.Drawing.Unit.Inch(0.19213905930519104R))
        Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TextBox8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox8.StyleName = "Data"
        Me.TextBox8.Value = "=Sum(Fields.ExtCost2)"
        '
        'sales_item_qtySumFunctionTextBox1
        '
        Me.sales_item_qtySumFunctionTextBox1.CanGrow = True
        Me.sales_item_qtySumFunctionTextBox1.Format = "{0:N0}"
        Me.sales_item_qtySumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0104165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_qtySumFunctionTextBox1.Name = "sales_item_qtySumFunctionTextBox1"
        Me.sales_item_qtySumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.sales_item_qtySumFunctionTextBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.sales_item_qtySumFunctionTextBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.sales_item_qtySumFunctionTextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.sales_item_qtySumFunctionTextBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.sales_item_qtySumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.sales_item_qtySumFunctionTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_qtySumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_qtySumFunctionTextBox1.StyleName = "Data"
        Me.sales_item_qtySumFunctionTextBox1.Value = "=Sum(Fields.sales_item_qty)"
        '
        'sales_dtCountFunctionTextBox1
        '
        Me.sales_dtCountFunctionTextBox1.CanGrow = True
        Me.sales_dtCountFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000000894069672R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_dtCountFunctionTextBox1.Name = "sales_dtCountFunctionTextBox1"
        Me.sales_dtCountFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999606370925903R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.sales_dtCountFunctionTextBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.sales_dtCountFunctionTextBox1.Style.Font.Name = "Arial"
        Me.sales_dtCountFunctionTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_dtCountFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.sales_dtCountFunctionTextBox1.StyleName = "Data"
        Me.sales_dtCountFunctionTextBox1.Value = "= Format(""{0:MM/dd/yyyy}"",Parameters.dStartDate.Value.Date) + "" to "" + Format(""{0" & _
    ":MM/dd/yyyy}"",Parameters.dEndDate.Value.Date) "
        '
        'TextBox7
        '
        Me.TextBox7.CanGrow = True
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.63067322969436646R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.TextBox7.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TextBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox7.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox7.StyleName = "Data"
        Me.TextBox7.Value = "=Sum(Fields.ExtPrice2)"
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Format = "{0:P2}"
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1000003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.000078837074397597462R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49992063641548157R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.TextBox10.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TextBox10.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox10.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox10.StyleName = "Data"
        Me.TextBox10.Value = "=Sum(Fields.Markup2) / SUM(fields.ExtCost2)"
        '
        'cust_nbrGroupHeaderSection
        '
        Me.cust_nbrGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052083343267440796R)
        Me.cust_nbrGroupHeaderSection.Name = "cust_nbrGroupHeaderSection"
        Me.cust_nbrGroupHeaderSection.Style.Visible = False
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.CalculatedFields.AddRange(New Telerik.Reporting.CalculatedField() {New Telerik.Reporting.CalculatedField("ExtCost2", GetType(Double), "=Fields.sales_item_qty* Fields.sales_item_cost"), New Telerik.Reporting.CalculatedField("ExtPrice2", GetType(Double), "= Fields.sales_item_qty* Fields.sales_item_price"), New Telerik.Reporting.CalculatedField("Markup2", GetType(Double), "= Fields.ExtPrice2- Fields.ExtCost2"), New Telerik.Reporting.CalculatedField("MarginPct2", GetType(Double), "=IIF(fields.ExtPrice2 > 0, Fields.Markup2/(IIF((fields.ExtPrice2>0), Fields.ExtPr" & _
                    "ice2,1)),0)")})
        Me.SqlDataSource2.ConnectionString = "ClassSalesAnalysis.My.MySettings.ConvTest"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.SelectCommand = resources.GetString("SqlDataSource2.SelectCommand")
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463R)
        Me.pageHeader.Name = "pageHeader"
        Me.pageHeader.Style.Visible = False
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R)
        Me.reportHeader.Name = "reportHeader"
        Me.reportHeader.Style.Visible = False
        '
        'detail
        '
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("= Parameters.dDetail.Value", Telerik.Reporting.FilterOperator.Equal, "FALSE"))
        FormattingRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormattingRule2.Style.Visible = False
        Me.detail.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule2})
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20632879436016083R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_dtDataTextBox, Me.sales_inv_idDataTextBox, Me.item_nbrDataTextBox, Me.sales_item_costDataTextBox, Me.sales_item_priceDataTextBox, Me.sales_item_qtyDataTextBox, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox20})
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = False
        '
        'sales_dtDataTextBox
        '
        Me.sales_dtDataTextBox.CanGrow = True
        Me.sales_dtDataTextBox.Format = "{0:d}"
        Me.sales_dtDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.096016407012939453R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_dtDataTextBox.Name = "sales_dtDataTextBox"
        Me.sales_dtDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70394438505172729R), Telerik.Reporting.Drawing.Unit.Inch(0.20628936588764191R))
        Me.sales_dtDataTextBox.Style.Font.Name = "Arial"
        Me.sales_dtDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_dtDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_dtDataTextBox.StyleName = "Data"
        Me.sales_dtDataTextBox.Value = "=Fields.sales_dt"
        '
        'sales_inv_idDataTextBox
        '
        Me.sales_inv_idDataTextBox.CanGrow = True
        Me.sales_inv_idDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.91208350658416748R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_inv_idDataTextBox.Name = "sales_inv_idDataTextBox"
        Me.sales_inv_idDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.57579374313354492R), Telerik.Reporting.Drawing.Unit.Inch(0.20628936588764191R))
        Me.sales_inv_idDataTextBox.Style.Font.Name = "Arial"
        Me.sales_inv_idDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_inv_idDataTextBox.StyleName = "Data"
        Me.sales_inv_idDataTextBox.Value = "=Fields.sales_inv_id"
        '
        'item_nbrDataTextBox
        '
        Me.item_nbrDataTextBox.CanGrow = True
        Me.item_nbrDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.item_nbrDataTextBox.Name = "item_nbrDataTextBox"
        Me.item_nbrDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.598432183265686R), Telerik.Reporting.Drawing.Unit.Inch(0.20628936588764191R))
        Me.item_nbrDataTextBox.Style.Font.Name = "Arial"
        Me.item_nbrDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.item_nbrDataTextBox.StyleName = "Data"
        Me.item_nbrDataTextBox.Value = "=Fields.item_nbr"
        '
        'sales_item_costDataTextBox
        '
        Me.sales_item_costDataTextBox.CanGrow = True
        Me.sales_item_costDataTextBox.Format = "{0:N4}"
        Me.sales_item_costDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8958725929260254R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_costDataTextBox.Name = "sales_item_costDataTextBox"
        Me.sales_item_costDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992141723632813R), Telerik.Reporting.Drawing.Unit.Inch(0.20632877945899963R))
        Me.sales_item_costDataTextBox.Style.Font.Name = "Arial"
        Me.sales_item_costDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_costDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_costDataTextBox.StyleName = "Data"
        Me.sales_item_costDataTextBox.Value = "=Fields.sales_item_cost"
        '
        'sales_item_priceDataTextBox
        '
        Me.sales_item_priceDataTextBox.CanGrow = True
        Me.sales_item_priceDataTextBox.Format = "{0:N4}"
        Me.sales_item_priceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_priceDataTextBox.Name = "sales_item_priceDataTextBox"
        Me.sales_item_priceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89146995544433594R), Telerik.Reporting.Drawing.Unit.Inch(0.20632877945899963R))
        Me.sales_item_priceDataTextBox.Style.Font.Name = "Arial"
        Me.sales_item_priceDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_priceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_priceDataTextBox.StyleName = "Data"
        Me.sales_item_priceDataTextBox.Value = "=Fields.sales_item_price"
        '
        'sales_item_qtyDataTextBox
        '
        Me.sales_item_qtyDataTextBox.CanGrow = True
        Me.sales_item_qtyDataTextBox.Format = "{0:N0}"
        Me.sales_item_qtyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.89914608001709R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_qtyDataTextBox.Name = "sales_item_qtyDataTextBox"
        Me.sales_item_qtyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99664819240570068R), Telerik.Reporting.Drawing.Unit.Inch(0.20628936588764191R))
        Me.sales_item_qtyDataTextBox.Style.Font.Name = "Arial"
        Me.sales_item_qtyDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_qtyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_qtyDataTextBox.StyleName = "Data"
        Me.sales_item_qtyDataTextBox.Value = "=Fields.sales_item_qty"
        '
        'TextBox2
        '
        Me.TextBox2.Format = "{0:N2}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.82844877243042R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.76309967041015625R), Telerik.Reporting.Drawing.Unit.Inch(0.20632877945899963R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "=Fields.ExtCost2"
        '
        'TextBox3
        '
        Me.TextBox3.Format = "{0:N2}"
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.59162712097168R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90216255187988281R), Telerik.Reporting.Drawing.Unit.Inch(0.20632877945899963R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "=Fields.ExtPrice2"
        '
        'TextBox4
        '
        Me.TextBox4.Format = "{0:N2}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.5000391006469727R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699920654296875R), Telerik.Reporting.Drawing.Unit.Inch(0.20632877945899963R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "=Fields.Markup2"
        '
        'TextBox5
        '
        Me.TextBox5.Format = "{0:P2}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.20003890991211R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70507556200027466R), Telerik.Reporting.Drawing.Unit.Inch(0.20632877945899963R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "=Fields.MarginPct2"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1985108852386475R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.70055645704269409R), Telerik.Reporting.Drawing.Unit.Inch(0.20624998211860657R))
        Me.TextBox20.Value = "=Fields.sales_rep_assoc_nbr"
        '
        'DateRange2Report
        '
        Me.DataSource = Me.SqlDataSource2
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.sales_rep_assoc_nbr", Telerik.Reporting.FilterOperator.Equal, "=Parameters.dSalesmanNBR.Value"))
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.sales_dt", Telerik.Reporting.FilterOperator.LessOrEqual, "=Parameters.dEndDate.Value"))
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.sales_dt", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=Parameters.dStartDate.Value"))
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.cust_nbr", Telerik.Reporting.FilterOperator.Equal, "=Parameters.dCustomerNBR.Value"))
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Group2.GroupFooter = Me.sales_rep_assoc_nbrGroupFooterSection
        Group2.GroupHeader = Me.sales_rep_assoc_nbrGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.sales_rep_assoc_nbr"))
        Group2.Name = "sales_rep_assoc_nbrGroup"
        Group3.GroupFooter = Me.cust_nbrGroupFooterSection
        Group3.GroupHeader = Me.cust_nbrGroupHeaderSection
        Group3.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.cust_nbr"))
        Group3.Name = "cust_nbrGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.sales_rep_assoc_nbrGroupHeaderSection, Me.sales_rep_assoc_nbrGroupFooterSection, Me.cust_nbrGroupHeaderSection, Me.cust_nbrGroupFooterSection, Me.pageHeader, Me.reportHeader, Me.detail})
        Me.Name = "DateRange2Report"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.MultiValue = True
        ReportParameter1.Name = "dCustomerClass"
        ReportParameter2.Name = "dStartDate"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Name = "dEndDate"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter4.Name = "dCustomerNBR"
        ReportParameter5.AllowBlank = False
        ReportParameter5.Name = "dDetail"
        ReportParameter5.Type = Telerik.Reporting.ReportParameterType.[Boolean]
        ReportParameter5.Value = "False"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.ReportParameters.Add(ReportParameter5)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(74, Byte), Integer))
        StyleRule1.Style.Font.Name = "Georgia"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(173, Byte), Integer))
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(212, Byte), Integer))
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dotted
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        StyleRule2.Style.Font.Name = "Georgia"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule3.Style.Font.Name = "Georgia"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule4.Style.Font.Name = "Georgia"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(9.9999618530273437R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents sales_rep_assoc_nbrGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents sales_rep_assoc_nbrGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents cust_nbrGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents cust_nbrGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents sales_dtDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_inv_idDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_nbrDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_costDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_priceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_qtyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents sales_rep_assoc_nbrCaptionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_qtySumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents sales_dtCountFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
End Class