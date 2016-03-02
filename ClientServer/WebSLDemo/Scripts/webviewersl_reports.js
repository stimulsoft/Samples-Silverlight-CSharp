function buildReportTree()
{
    d = new dTree('d');

    // Categories
    d.add(0, -1, ' Reports');
    d.add(1, 0, 'Basic Reports', null, null, null, null, null, true);
    d.add(2, 0, 'Reports with Columns');
    d.add(3, 0, 'Master-Detail Reports');
    d.add(4, 0, 'Reports with Groups');
    d.add(5, 0, 'Hierarchical Reports');
    d.add(6, 0, 'Parameters');
    d.add(7, 0, 'Interactive Reports');
    d.add(8, 0, 'Charts');
    d.add(9, 0, 'Reports with EmptyBand');
    d.add(10, 0, 'Containers');
//    d.add(11, 0, 'SubReports');

    // Basic Reports
    d.add(12, 1, 'Simple List', '?reportname=SimpleList');
    d.add(13, 1, 'Two Simple Lists', '?reportname=TwoSimpleLists');
    d.add(14, 1, 'Highlight Condition', '?reportname=HighlightCondition');
    d.add(15, 1, 'Shapes', '?reportname=Shapes');
    d.add(16, 1, 'Images', '?reportname=Images');
    d.add(18, 1, 'Watermark', '?reportname=Watermark');
    d.add(19, 1, 'BarCodes', '?reportname=BarCodes');
    d.add(20, 1, 'Invoice', '?reportname=Invoice');
    d.add(21, 1, 'Indicators', '?reportname=Indicators');
    
    // Reports with Columns
    d.add(22, 2, 'Multi-Column List', '?reportname=MultiColumnList');
    d.add(23, 2, 'Multi-Column Bands, Across-Down', '?reportname=MultiColumnBandsAcrossThenDown');
    d.add(24, 2, 'Multi-Column Bands, Down-Across', '?reportname=MultiColumnBandsDownThenAcross');
    d.add(25, 2, 'Labels', '?reportname=Labels');
    
    // Master-Detail Reports
	d.add(26, 3, 'Master-Detail', '?reportname=MasterDetail');
	d.add(27, 3, 'Master-Detail-Subdetail', '?reportname=MasterDetailSubdetail');
	d.add(28, 3, 'Master-Detail with Columns', '?reportname=MasterDetailWithColumns');
    d.add(29, 3, 'Two Masters on One Detail', '?reportname=TwoMastersOnOneDetail');
    d.add(30, 3, 'Master-Detail with zero Height', '?reportname=MasterDetailWithZeroHeight');
    d.add(31, 3, 'Master-Detail on DataBand', '?reportname=MasterDetailOnDataBand');
    
    // Reports with Groups
    d.add(32, 4, 'Simple Group', '?reportname=SimpleGroup');
    d.add(33, 4, 'Nested Groups', '?reportname=NestedGroups');
    d.add(34, 4, 'Top Sales', '?reportname=GroupsTopSales');
    d.add(35, 4, 'Master-Detail with Groups', '?reportname=MasterDetailWithGroups');
    d.add(36, 4, 'Multi-Column Group', '?reportname=MultiColumnGroup');
    d.add(37, 4, 'Groups with Ranges', '?reportname=GroupsWithRanges');
    d.add(38, 4, 'Simple Group with Columns', '?reportname=SimpleGroupWithColumns');
    d.add(39, 4, 'All Group Footers at End', '?reportname=AllGroupFootersAtEnd');
    d.add(40, 4, 'Invoice with Groups', '?reportname=InvoiceWithGroups');
    d.add(41, 4, 'Sales Invoice', '?reportname=SalesInvoice');
    
    // Hierarchical Reports
    d.add(42, 5, 'Tree', '?reportname=Tree');
    d.add(43, 5, 'Tree with Headers and Footers', '?reportname=TreeWithHeadersFooters');
    d.add(44, 5, 'Tree with Totals', '?reportname=TreeWithTotals');
    d.add(45, 5, 'Tree with Totals, All Levels', '?reportname=TreeWithTotalsAllLevels');
    d.add(46, 5, 'Tree with Locked Components', '?reportname=TreeWithLockedComponents');

    // Parameters
    d.add(47, 6, 'Detailed Categories', '?reportname=ParametersDetailedCategories');
    d.add(48, 6, 'Detailed Orders', '?reportname=ParametersDetailedOrders');
    d.add(49, 6, 'Highlight Condition', '?reportname=ParametersHighlightCondition');
//    d.add(50, 6, 'Selecting Country', '?reportname=ParametersSelectingCountry');
//    d.add(51, 6, 'Date Range', '?reportname=ParametersDateRange');
    d.add(52, 6, 'Invoice', '?reportname=ParametersInvoice');

    // Interactive Reports
    d.add(53, 7, 'List of Products', '?reportname=DrillDownListOfProducts');
    d.add(54, 7, 'Interactive Sorting', '?reportname=DrillDownSorting');
    d.add(55, 7, 'Group with Collapsing', '?reportname=DrillDownGroupWithCollapsing');
    d.add(56, 7, 'Group with Collapsing without Footers', '?reportname=DrillDownGroupWithCollapsingWithoutFooter');
    d.add(57, 7, 'Master-Detail with Collapsing', '?reportname=DrillDownMasterDetailWithCollapsing');
    d.add(58, 7, 'Editable Report', '?reportname=EditableReport');
    d.add(59, 7, 'Bookmarks, Hyperlinks', '?reportname=BookmarksHyperlinks');
    d.add(60, 7, 'Anchors', '?reportname=Anchors');
    
    // Charts
    d.add(61, 8, 'Chart Columns and Bars', '?reportname=ChartColumnsAndBars');
    d.add(62, 8, 'Chart Lines and Splines', '?reportname=ChartLinesAndSplines');
    d.add(63, 8, 'Chart Areas', '?reportname=ChartAreas');
    d.add(64, 8, 'Chart Pie and Doughnut', '?reportname=ChartPieAndDoughnut');
    d.add(65, 8, 'Chart Styles', '?reportname=ChartStyles');
    d.add(66, 8, 'Chart on Databand', '?reportname=ChartOnDataband');
   
    // Reports with EmptyBand
    d.add(67, 9, 'Simple List with Empty Lines', '?reportname=SimpleListWithEmptyLines');
    d.add(68, 9, 'Master-Detail with Empty Lines', '?reportname=MasterDetailWithEmptyLines');
    d.add(69, 9, 'Invoice with Empty Band', '?reportname=InvoiceWithEmptyBand');
    
    // Containers
    d.add(70, 10, 'Side by Side List', '?reportname=SideBySideListWithContainers');
    d.add(71, 10, 'Side by Side Group', '?reportname=SideBySideGroupWithContainers');
    d.add(72, 10, 'Multi-Column List', '?reportname=MultiColumnListContainers');
    d.add(73, 10, 'Master-Detail Cards', '?reportname=MasterDetailCards');
    
//    // SubReports
//    d.add(74, 11, 'Side by Side List', '?reportname=SideBySideListWithSubReports');
//    d.add(75, 11, 'Side by Side Group', '?reportname=SideBySideGroupWithSubReports');
//    d.add(76, 11, 'Master-Detail', '?reportname=MasterDetailWithSubReports');

    document.write(d);
}