Partial Class Report1
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report1))
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group3 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter5 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter6 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter7 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter8 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.DateRange2Report1 = New ClassSalesAnalysisSummary.DateRange2Report()
        Me.sales_rep_assoc_nbrGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.sales_rep_assoc_nbrGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.cust_nbrGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.sales_item_qtySumFunctionTextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.SubReport1 = New Telerik.Reporting.SubReport()
        Me.cust_nbrDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.cust_nbrGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        Me.SqlDataSource3 = New Telerik.Reporting.SqlDataSource()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.sales_item_qtySumFunctionTextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.sales_item_qtyCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.sales_dtCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.sales_dtDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_inv_idDataTextBox = New Telerik.Reporting.TextBox()
        Me.item_nbrDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_rep_assoc_nbrDataTextBox1 = New Telerik.Reporting.TextBox()
        Me.sales_item_qtyDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_costDataTextBox = New Telerik.Reporting.TextBox()
        Me.sales_item_priceDataTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        CType(Me.DateRange2Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DateRange2Report1
        '
        Me.DateRange2Report1.Name = "DateRange2Report"
        '
        'sales_rep_assoc_nbrGroupFooterSection
        '
        Me.sales_rep_assoc_nbrGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.23282153904438019R)
        Me.sales_rep_assoc_nbrGroupFooterSection.Name = "sales_rep_assoc_nbrGroupFooterSection"
        Me.sales_rep_assoc_nbrGroupFooterSection.Style.BorderColor.Default = System.Drawing.SystemColors.GrayText
        Me.sales_rep_assoc_nbrGroupFooterSection.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.sales_rep_assoc_nbrGroupFooterSection.Style.Visible = False
        '
        'sales_rep_assoc_nbrGroupHeaderSection
        '
        Me.sales_rep_assoc_nbrGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.10000015050172806R)
        Me.sales_rep_assoc_nbrGroupHeaderSection.Name = "sales_rep_assoc_nbrGroupHeaderSection"
        Me.sales_rep_assoc_nbrGroupHeaderSection.Style.Visible = False
        '
        'cust_nbrGroupFooterSection
        '
        Me.cust_nbrGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44378918409347534R)
        Me.cust_nbrGroupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_item_qtySumFunctionTextBox1, Me.TextBox9, Me.TextBox11, Me.TextBox12, Me.TextBox15, Me.SubReport1, Me.cust_nbrDataTextBox, Me.TextBox23, Me.TextBox25})
        Me.cust_nbrGroupFooterSection.Name = "cust_nbrGroupFooterSection"
        Me.cust_nbrGroupFooterSection.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.cust_nbrGroupFooterSection.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.cust_nbrGroupFooterSection.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.cust_nbrGroupFooterSection.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        '
        'sales_item_qtySumFunctionTextBox1
        '
        Me.sales_item_qtySumFunctionTextBox1.CanGrow = True
        Me.sales_item_qtySumFunctionTextBox1.Format = "{0:N0}"
        Me.sales_item_qtySumFunctionTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0012688636779785R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_qtySumFunctionTextBox1.Name = "sales_item_qtySumFunctionTextBox1"
        Me.sales_item_qtySumFunctionTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.sales_item_qtySumFunctionTextBox1.Style.BackgroundColor = System.Drawing.Color.White
        Me.sales_item_qtySumFunctionTextBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.sales_item_qtySumFunctionTextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.sales_item_qtySumFunctionTextBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.sales_item_qtySumFunctionTextBox1.Style.Font.Name = "Arial"
        Me.sales_item_qtySumFunctionTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_qtySumFunctionTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_qtySumFunctionTextBox1.StyleName = "Data"
        Me.sales_item_qtySumFunctionTextBox1.Value = "=Sum(Fields.sales_item_qty)"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = True
        Me.TextBox9.Format = "{0:N2}"
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.31442403793335R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.68541860580444336R), Telerik.Reporting.Drawing.Unit.Inch(0.19213905930519104R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox9.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox9.StyleName = "Data"
        Me.TextBox9.Value = "=Sum(Fields.ExtCost)"
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = True
        Me.TextBox11.Format = "{0:N2}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3619303703308105R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.63067322969436646R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox11.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox11.StyleName = "Data"
        Me.TextBox11.Value = "=Sum(Fields.ExtPrice)"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Format = "{0:N2}"
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.1587882041931152R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.666947603225708R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox12.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox12.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox12.StyleName = "Data"
        Me.TextBox12.Value = "=Sum(Fields.Markup)"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = True
        Me.TextBox15.Format = "{0:P2}"
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0072383880615234R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49992063641548157R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.TextBox15.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox15.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox15.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox15.StyleName = "Data"
        Me.TextBox15.Value = "=Sum(Fields.Markup) / SUM(fields.ExtPrice)"
        '
        'SubReport1
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Parameters.showDate2.Value", Telerik.Reporting.FilterOperator.Equal, "FALSE"))
        FormattingRule1.Style.Visible = False
        Me.SubReport1.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.SubReport1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.18368785083293915R))
        Me.SubReport1.Name = "SubReport1"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("dSalesmanNBR", "=Parameters.SalesmanNBR.Value"))
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("dCustomerNBR", "=Fields.cust_nbr"))
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("dStartDate", "=Parameters.dStartDate.Value"))
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("dEndDate", "=Parameters.dEndDate.Value"))
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("dCustomerClass", "=Parameters.CustomerClass.Value"))
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("dDetail", "=Parameters.ShowDetail.Value"))
        InstanceReportSource1.ReportDocument = Me.DateRange2Report1
        Me.SubReport1.ReportSource = InstanceReportSource1
        Me.SubReport1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(9.6071577072143555R), Telerik.Reporting.Drawing.Unit.Inch(0.24367082118988037R))
        Me.SubReport1.Style.Visible = True
        '
        'cust_nbrDataTextBox
        '
        Me.cust_nbrDataTextBox.CanGrow = True
        Me.cust_nbrDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6976197957992554R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.cust_nbrDataTextBox.Name = "cust_nbrDataTextBox"
        Me.cust_nbrDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9023803472518921R), Telerik.Reporting.Drawing.Unit.Inch(0.19217847287654877R))
        Me.cust_nbrDataTextBox.Style.Font.Bold = False
        Me.cust_nbrDataTextBox.Style.Font.Name = "Arial"
        Me.cust_nbrDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.cust_nbrDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.cust_nbrDataTextBox.StyleName = "Data"
        Me.cust_nbrDataTextBox.Value = "=Fields.cust_nbr"
        '
        'TextBox23
        '
        Me.TextBox23.Format = "{0:P2}"
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.199920654296875R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.50000065565109253R), Telerik.Reporting.Drawing.Unit.Inch(0.18360891938209534R))
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox23.Value = "=Sum(Fields.Markup) / SUM(fields.ExtCost)"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.18360891938209534R))
        Me.TextBox25.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox25.Style.Color = System.Drawing.Color.Black
        Me.TextBox25.Style.Font.Name = "Arial"
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox25.StyleName = "Title"
        Me.TextBox25.Value = "= Format(""{0:MM/dd/yyyy}"",Parameters.StartDate.Value.Date) + "" to "" + Format(""{0:" & _
    "MM/dd/yyyy}"",Parameters.EndDate.Value.Date) "
        '
        'cust_nbrGroupHeaderSection
        '
        Me.cust_nbrGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.058372586965560913R)
        Me.cust_nbrGroupHeaderSection.Name = "cust_nbrGroupHeaderSection"
        Me.cust_nbrGroupHeaderSection.Style.Visible = False
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.17657122015953064R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.116705983877182R)
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        Me.labelsGroupHeaderSection.Style.Visible = False
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionString = "ClassSalesAnalysis.My.MySettings.ConvTest"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.SelectCommand = "SELECT DISTINCT sales_rep_assoc_nbr" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            dwh_sales_detail"
        '
        'SqlDataSource3
        '
        Me.SqlDataSource3.ConnectionString = "ClassSalesAnalysis.My.MySettings.ConvTest"
        Me.SqlDataSource3.Name = "SqlDataSource3"
        Me.SqlDataSource3.SelectCommand = "SELECT DISTINCT cust_grp_nbr " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "FROM dwh_sales_detail  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY cust_grp_nbr AS" & _
    "C"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.CalculatedFields.AddRange(New Telerik.Reporting.CalculatedField() {New Telerik.Reporting.CalculatedField("ExtCost", GetType(Double), "=Fields.sales_item_cost * Fields.Sales_item_Qty"), New Telerik.Reporting.CalculatedField("ExtPrice", GetType(Double), "=Fields.sales_item_price * Fields.Sales_item_qty"), New Telerik.Reporting.CalculatedField("Markup", GetType(Double), "=Fields.ExtPrice - Fields.ExtCost"), New Telerik.Reporting.CalculatedField("MarginPct", GetType(Double), "=IIf(Fields.ExtPrice> 0, Fields.Markup/(IIF((Fields.ExtPrice> 0), Fields.ExtPrice" & _
                    ",1)), 0)")})
        Me.SqlDataSource1.ConnectionString = "ClassSalesAnalysis.My.MySettings.ConvTest"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@SalesmanNBR", System.Data.DbType.[String], "=Parameters.SalesmanNBR.Value")})
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.61847472190856934R)
        Me.reportFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_item_qtySumFunctionTextBox2, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox21, Me.TextBox20, Me.TextBox22, Me.Shape2})
        Me.reportFooter.Name = "reportFooter"
        Me.reportFooter.Style.Visible = True
        '
        'sales_item_qtySumFunctionTextBox2
        '
        Me.sales_item_qtySumFunctionTextBox2.CanGrow = True
        Me.sales_item_qtySumFunctionTextBox2.Format = "{0:N0}"
        Me.sales_item_qtySumFunctionTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0012688636779785R), Telerik.Reporting.Drawing.Unit.Inch(0.24791686236858368R))
        Me.sales_item_qtySumFunctionTextBox2.Name = "sales_item_qtySumFunctionTextBox2"
        Me.sales_item_qtySumFunctionTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.898809552192688R), Telerik.Reporting.Drawing.Unit.Inch(0.37055787444114685R))
        Me.sales_item_qtySumFunctionTextBox2.Style.BackgroundColor = System.Drawing.Color.White
        Me.sales_item_qtySumFunctionTextBox2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.sales_item_qtySumFunctionTextBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.sales_item_qtySumFunctionTextBox2.Style.Font.Bold = False
        Me.sales_item_qtySumFunctionTextBox2.Style.Font.Name = "Arial"
        Me.sales_item_qtySumFunctionTextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_qtySumFunctionTextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_qtySumFunctionTextBox2.StyleName = "Data"
        Me.sales_item_qtySumFunctionTextBox2.Value = "=Sum(Fields.sales_item_qty)"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0214290618896484R), Telerik.Reporting.Drawing.Unit.Inch(0.30668291449546814R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.97857093811035156R), Telerik.Reporting.Drawing.Unit.Inch(0.23278205096721649R))
        Me.TextBox17.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox17.Style.Font.Bold = False
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "Grand Total"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = True
        Me.TextBox18.Format = "{0:N2}"
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2891883850097656R), Telerik.Reporting.Drawing.Unit.Inch(0.24791686236858368R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.68549680709838867R), Telerik.Reporting.Drawing.Unit.Inch(0.37055787444114685R))
        Me.TextBox18.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox18.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox18.Style.Font.Bold = False
        Me.TextBox18.Style.Font.Name = "Arial"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox18.StyleName = "Data"
        Me.TextBox18.Value = "=Sum(Fields.ExtCost)"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = True
        Me.TextBox19.Format = "{0:N2}"
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3335952758789062R), Telerik.Reporting.Drawing.Unit.Inch(0.24791686236858368R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6590082049369812R), Telerik.Reporting.Drawing.Unit.Inch(0.37055784463882446R))
        Me.TextBox19.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox19.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox19.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox19.Style.Font.Bold = False
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox19.StyleName = "Data"
        Me.TextBox19.Value = "=Sum(Fields.ExtPrice)"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = True
        Me.TextBox21.Format = "{0:P2}"
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.0072383880615234R), Telerik.Reporting.Drawing.Unit.Inch(0.24791686236858368R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49992063641548157R), Telerik.Reporting.Drawing.Unit.Inch(0.37055784463882446R))
        Me.TextBox21.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox21.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox21.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox21.Style.Font.Bold = False
        Me.TextBox21.Style.Font.Name = "Arial"
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.StyleName = "Data"
        Me.TextBox21.Value = "=Sum(Fields.Markup) / SUM(fields.ExtPrice)"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = True
        Me.TextBox20.Format = "{0:N2}"
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.2257351875305176R), Telerik.Reporting.Drawing.Unit.Inch(0.24791686236858368R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60000032186508179R), Telerik.Reporting.Drawing.Unit.Inch(0.37055784463882446R))
        Me.TextBox20.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox20.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox20.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox20.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox20.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox20.Style.Font.Bold = False
        Me.TextBox20.Style.Font.Name = "Arial"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox20.StyleName = "Data"
        Me.TextBox20.Value = "=Sum(Fields.Markup)"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = True
        Me.TextBox22.Format = "{0:P2}"
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.24791686236858368R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49992063641548157R), Telerik.Reporting.Drawing.Unit.Inch(0.37055784463882446R))
        Me.TextBox22.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox22.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox22.Style.Font.Bold = False
        Me.TextBox22.Style.Font.Name = "Arial"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox22.StyleName = "Data"
        Me.TextBox22.Value = "=Sum(Fields.Markup) / SUM(fields.ExtCost)"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10715866088867188R), Telerik.Reporting.Drawing.Unit.Inch(0.10660394281148911R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(9.40000057220459R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.9583336114883423R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1, Me.TextBox14, Me.titleTextBox, Me.TextBox13, Me.TextBox16, Me.Shape1, Me.TextBox10, Me.TextBox5, Me.TextBox4, Me.TextBox2, Me.TextBox3, Me.sales_item_qtyCaptionTextBox, Me.sales_dtCaptionTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.097698211669921875R), Telerik.Reporting.Drawing.Unit.Inch(0.099960647523403168R))
        Me.PictureBox1.MimeType = "image/jpeg"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9023020267486572R), Telerik.Reporting.Drawing.Unit.Inch(1.200039267539978R))
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'TextBox14
        '
        Me.TextBox14.Format = "{0:D}"
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6388295888900757R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox14.StyleName = "PageInfo"
        Me.TextBox14.Value = "= NOW()"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0770037174224854R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7229175567626953R), Telerik.Reporting.Drawing.Unit.Inch(0.34986215829849243R))
        Me.titleTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.titleTextBox.Style.Color = System.Drawing.Color.Black
        Me.titleTextBox.Style.Font.Name = "Arial"
        Me.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Sales Analysis Report - Summary"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4000003337860107R), Telerik.Reporting.Drawing.Unit.Inch(0.501122772693634R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.8302350044250488R), Telerik.Reporting.Drawing.Unit.Inch(0.35192576050758362R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox13.Style.Color = System.Drawing.Color.Black
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.StyleName = "Title"
        Me.TextBox13.Value = "=""For Dates  "" + Format(""{0:MM/dd/yyyy}"",Parameters.StartDate.Value.Date) + "" to " & _
    """ + Format(""{0:MM/dd/yyyy}"",Parameters.EndDate.Value.Date) "
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = True
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.70000004768371582R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.033052921295166R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox16.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox16.Style.Font.Bold = False
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.StyleName = "Data"
        Me.TextBox16.Value = "=""Salesman: "" + Parameters.SalesmanNBR.Value"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10715866088867188R), Telerik.Reporting.Drawing.Unit.Inch(1.3000000715255737R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(9.40000057220459R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        '
        'TextBox10
        '
        Me.TextBox10.CanGrow = True
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.8020834922790527R), Telerik.Reporting.Drawing.Unit.Inch(1.5R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.87410670518875122R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.StyleName = "Caption"
        Me.TextBox10.Value = "Markup%"
        '
        'TextBox5
        '
        Me.TextBox5.CanGrow = True
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.6770830154418945R), Telerik.Reporting.Drawing.Unit.Inch(1.5R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80715876817703247R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.StyleName = "Caption"
        Me.TextBox5.Value = "Margin%"
        '
        'TextBox4
        '
        Me.TextBox4.CanGrow = True
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.96875R), Telerik.Reporting.Drawing.Unit.Inch(1.5R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8330535888671875R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.StyleName = "Caption"
        Me.TextBox4.Value = "Markup"
        '
        'TextBox2
        '
        Me.TextBox2.CanGrow = True
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.96875R), Telerik.Reporting.Drawing.Unit.Inch(1.5R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.992682158946991R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.StyleName = "Caption"
        Me.TextBox2.Value = "Ext Price"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = True
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.875R), Telerik.Reporting.Drawing.Unit.Inch(1.5R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0996850728988647R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.StyleName = "Caption"
        Me.TextBox3.Value = "Ext Cost"
        '
        'sales_item_qtyCaptionTextBox
        '
        Me.sales_item_qtyCaptionTextBox.CanGrow = True
        Me.sales_item_qtyCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.875R), Telerik.Reporting.Drawing.Unit.Inch(1.5R))
        Me.sales_item_qtyCaptionTextBox.Name = "sales_item_qtyCaptionTextBox"
        Me.sales_item_qtyCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992114305496216R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_item_qtyCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_qtyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_item_qtyCaptionTextBox.StyleName = "Caption"
        Me.sales_item_qtyCaptionTextBox.Value = " Shipped Qty" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'sales_dtCaptionTextBox
        '
        Me.sales_dtCaptionTextBox.CanGrow = True
        Me.sales_dtCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.5R))
        Me.sales_dtCaptionTextBox.Name = "sales_dtCaptionTextBox"
        Me.sales_dtCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.9000391960144043R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.sales_dtCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.sales_dtCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_dtCaptionTextBox.StyleName = "Caption"
        Me.sales_dtCaptionTextBox.Value = "Customer"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.42083334922790527R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.pageInfoTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.058372985571622849R)
        Me.reportHeader.Name = "reportHeader"
        Me.reportHeader.Style.Visible = False
        '
        'detail
        '
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("= Parameters.ShowDetail.Value", Telerik.Reporting.FilterOperator.Equal, "FALSE"))
        FormattingRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        FormattingRule2.Style.Visible = False
        Me.detail.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule2})
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.24834984540939331R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_dtDataTextBox, Me.sales_inv_idDataTextBox, Me.item_nbrDataTextBox, Me.sales_rep_assoc_nbrDataTextBox1, Me.sales_item_qtyDataTextBox, Me.sales_item_costDataTextBox, Me.sales_item_priceDataTextBox, Me.TextBox1, Me.TextBox6, Me.TextBox7, Me.TextBox8})
        Me.detail.KeepTogether = False
        Me.detail.Name = "detail"
        '
        'sales_dtDataTextBox
        '
        Me.sales_dtDataTextBox.CanGrow = True
        Me.sales_dtDataTextBox.Format = "{0:d}"
        Me.sales_dtDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039378803194267675R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.sales_dtDataTextBox.Name = "sales_dtDataTextBox"
        Me.sales_dtDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69996070861816406R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.sales_dtDataTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.sales_dtDataTextBox.Style.Font.Name = "Arial"
        Me.sales_dtDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_dtDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_dtDataTextBox.StyleName = "Data"
        Me.sales_dtDataTextBox.Value = "=Fields.sales_dt"
        '
        'sales_inv_idDataTextBox
        '
        Me.sales_inv_idDataTextBox.CanGrow = True
        Me.sales_inv_idDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.sales_inv_idDataTextBox.Name = "sales_inv_idDataTextBox"
        Me.sales_inv_idDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.68999981880187988R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.sales_inv_idDataTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.sales_inv_idDataTextBox.Style.Font.Name = "Arial"
        Me.sales_inv_idDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_inv_idDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_inv_idDataTextBox.StyleName = "Data"
        Me.sales_inv_idDataTextBox.Value = "=Fields.sales_inv_id"
        '
        'item_nbrDataTextBox
        '
        Me.item_nbrDataTextBox.CanGrow = True
        Me.item_nbrDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5188097953796387R), Telerik.Reporting.Drawing.Unit.Inch(0.016745248809456825R))
        Me.item_nbrDataTextBox.Name = "item_nbrDataTextBox"
        Me.item_nbrDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5788884162902832R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.item_nbrDataTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.item_nbrDataTextBox.Style.Font.Name = "Arial"
        Me.item_nbrDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.item_nbrDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.item_nbrDataTextBox.StyleName = "Data"
        Me.item_nbrDataTextBox.Value = "=Fields.item_nbr"
        '
        'sales_rep_assoc_nbrDataTextBox1
        '
        Me.sales_rep_assoc_nbrDataTextBox1.CanGrow = True
        Me.sales_rep_assoc_nbrDataTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4000785350799561R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.sales_rep_assoc_nbrDataTextBox1.Name = "sales_rep_assoc_nbrDataTextBox1"
        Me.sales_rep_assoc_nbrDataTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.sales_rep_assoc_nbrDataTextBox1.Style.BackgroundColor = System.Drawing.Color.White
        Me.sales_rep_assoc_nbrDataTextBox1.Style.Font.Name = "Arial"
        Me.sales_rep_assoc_nbrDataTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_rep_assoc_nbrDataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.sales_rep_assoc_nbrDataTextBox1.StyleName = "Data"
        Me.sales_rep_assoc_nbrDataTextBox1.Value = "=Fields.sales_rep_assoc_nbr"
        '
        'sales_item_qtyDataTextBox
        '
        Me.sales_item_qtyDataTextBox.CanGrow = True
        Me.sales_item_qtyDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.20007848739624R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.sales_item_qtyDataTextBox.Name = "sales_item_qtyDataTextBox"
        Me.sales_item_qtyDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.sales_item_qtyDataTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.sales_item_qtyDataTextBox.Style.Font.Name = "Arial"
        Me.sales_item_qtyDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_qtyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_qtyDataTextBox.StyleName = "Data"
        Me.sales_item_qtyDataTextBox.Value = "=Fields.sales_item_qty"
        '
        'sales_item_costDataTextBox
        '
        Me.sales_item_costDataTextBox.CanGrow = True
        Me.sales_item_costDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.1000785827636719R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.sales_item_costDataTextBox.Name = "sales_item_costDataTextBox"
        Me.sales_item_costDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.sales_item_costDataTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.sales_item_costDataTextBox.Style.Font.Name = "Arial"
        Me.sales_item_costDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_costDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_costDataTextBox.StyleName = "Data"
        Me.sales_item_costDataTextBox.Value = "=Fields.sales_item_cost"
        '
        'sales_item_priceDataTextBox
        '
        Me.sales_item_priceDataTextBox.CanGrow = True
        Me.sales_item_priceDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.1999211311340332R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.sales_item_priceDataTextBox.Name = "sales_item_priceDataTextBox"
        Me.sales_item_priceDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60000038146972656R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.sales_item_priceDataTextBox.Style.BackgroundColor = System.Drawing.Color.White
        Me.sales_item_priceDataTextBox.Style.Font.Name = "Arial"
        Me.sales_item_priceDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.sales_item_priceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.sales_item_priceDataTextBox.StyleName = "Data"
        Me.sales_item_priceDataTextBox.Value = "=Fields.sales_item_price"
        '
        'TextBox1
        '
        Me.TextBox1.Format = "{0:N2}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.047635555267334R), Telerik.Reporting.Drawing.Unit.Inch(0.016745248809456825R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60000038146972656R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "=Fields.ExtCost"
        '
        'TextBox6
        '
        Me.TextBox6.Format = "{0:N2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.8926835060119629R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60723811388015747R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox6.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "=Fields.ExtPrice"
        '
        'TextBox7
        '
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.6256570816040039R), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.57426434755325317R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox7.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "=Fields.Markup"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0:P2}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.4072380065917969R), Telerik.Reporting.Drawing.Unit.Inch(0.016745248809456825R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.499920517206192R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "=Fields.MarginPct"
        '
        'Report1
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.sales_rep_assoc_nbr", Telerik.Reporting.FilterOperator.Equal, "=Parameters.SalesmanNBR.Value"))
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.sales_dt", Telerik.Reporting.FilterOperator.LessOrEqual, "=Parameters.EndDate.Value"))
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.sales_dt", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=Parameters.StartDate.Value"))
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.cust_grp_nbr", Telerik.Reporting.FilterOperator.[In], "=Parameters.CustomerClass.Value"))
        Group1.GroupFooter = Me.sales_rep_assoc_nbrGroupFooterSection
        Group1.GroupHeader = Me.sales_rep_assoc_nbrGroupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.sales_rep_assoc_nbr"))
        Group1.Name = "sales_rep_assoc_nbrGroup"
        Group2.GroupFooter = Me.cust_nbrGroupFooterSection
        Group2.GroupHeader = Me.cust_nbrGroupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.cust_nbr"))
        Group2.Name = "cust_nbrGroup"
        Group3.GroupFooter = Me.labelsGroupFooterSection
        Group3.GroupHeader = Me.labelsGroupHeaderSection
        Group3.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2, Group3})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.sales_rep_assoc_nbrGroupHeaderSection, Me.sales_rep_assoc_nbrGroupFooterSection, Me.cust_nbrGroupHeaderSection, Me.cust_nbrGroupFooterSection, Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.reportFooter, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.detail})
        Me.Name = "Report1"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.AllowBlank = False
        ReportParameter1.Name = "StartDate"
        ReportParameter1.Text = "1st From Date:"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Value = "=now()"
        ReportParameter1.Visible = True
        ReportParameter2.AllowBlank = False
        ReportParameter2.Name = "EndDate"
        ReportParameter2.Text = "1st To Date:"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Value = "=now()"
        ReportParameter2.Visible = True
        ReportParameter3.AllowBlank = False
        ReportParameter3.Name = "dStartDate"
        ReportParameter3.Text = "2nd From Date:"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Value = "=now()"
        ReportParameter3.Visible = True
        ReportParameter4.AllowBlank = False
        ReportParameter4.Name = "dEndDate"
        ReportParameter4.Text = "2nd To Date:"
        ReportParameter4.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter4.Value = "=now()"
        ReportParameter4.Visible = True
        ReportParameter5.AllowBlank = False
        ReportParameter5.AvailableValues.DataSource = Me.SqlDataSource2
        ReportParameter5.AvailableValues.DisplayMember = "= Fields.sales_rep_assoc_nbr"
        ReportParameter5.AvailableValues.ValueMember = "= Fields.sales_rep_assoc_nbr"
        ReportParameter5.Name = "SalesmanNBR"
        ReportParameter5.Text = "Salesman nbr"
        ReportParameter5.Value = ""
        ReportParameter5.Visible = True
        ReportParameter6.AllowBlank = False
        ReportParameter6.AvailableValues.DataSource = Me.SqlDataSource3
        ReportParameter6.AvailableValues.DisplayMember = "= Fields.cust_grp_nbr"
        ReportParameter6.AvailableValues.ValueMember = "= Fields.cust_grp_nbr"
        ReportParameter6.MultiValue = True
        ReportParameter6.Name = "CustomerClass"
        ReportParameter6.Text = "Customer Class"
        ReportParameter6.Value = "A"
        ReportParameter6.Visible = True
        ReportParameter7.AllowBlank = False
        ReportParameter7.Name = "ShowDetail"
        ReportParameter7.Text = "Show Detail?"
        ReportParameter7.Type = Telerik.Reporting.ReportParameterType.[Boolean]
        ReportParameter7.Value = "FALSE"
        ReportParameter8.Name = "ShowDate2"
        ReportParameter8.Text = "Show 2nd Date Data"
        ReportParameter8.Type = Telerik.Reporting.ReportParameterType.[Boolean]
        ReportParameter8.Value = "FALSE"
        ReportParameter8.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.ReportParameters.Add(ReportParameter5)
        Me.ReportParameters.Add(ReportParameter6)
        Me.ReportParameters.Add(ReportParameter7)
        Me.ReportParameters.Add(ReportParameter8)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.000000953674316R)
        CType(Me.DateRange2Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents sales_rep_assoc_nbrGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents sales_rep_assoc_nbrGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents cust_nbrGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents cust_nbrGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents sales_item_qtySumFunctionTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents sales_item_qtySumFunctionTextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents sales_dtDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_inv_idDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents item_nbrDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_rep_assoc_nbrDataTextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_qtyDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_costDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_priceDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource3 As Telerik.Reporting.SqlDataSource
    Friend WithEvents SubReport1 As Telerik.Reporting.SubReport
    Friend WithEvents DateRange2Report1 As ClassSalesAnalysisSummary.DateRange2Report
    Friend WithEvents cust_nbrDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents sales_item_qtyCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents sales_dtCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
End Class