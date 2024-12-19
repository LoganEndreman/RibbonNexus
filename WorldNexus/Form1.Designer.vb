Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        BackstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        BackstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        BackstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(ribbonControl1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BackstageViewControl1, ComponentModel.ISupportInitialize).BeginInit()
        BackstageViewControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ribbonControl1
        ' 
        ribbonControl1.ApplicationButtonDropDownControl = BackstageViewControl1
        ribbonControl1.ExpandCollapseItem.Id = 0
        ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {ribbonControl1.ExpandCollapseItem, BarButtonItem1})
        ribbonControl1.Location = New Point(0, 0)
        ribbonControl1.MaxItemId = 2
        ribbonControl1.Name = "ribbonControl1"
        ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {ribbonPage1})
        ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        ribbonControl1.Size = New Size(758, 158)
        ' 
        ' BackstageViewControl1
        ' 
        BackstageViewControl1.Controls.Add(BackstageViewClientControl1)
        BackstageViewControl1.Items.Add(BackstageViewTabItem1)
        BackstageViewControl1.Location = New Point(124, 198)
        BackstageViewControl1.Name = "BackstageViewControl1"
        BackstageViewControl1.OwnerControl = ribbonControl1
        BackstageViewControl1.SelectedTab = BackstageViewTabItem1
        BackstageViewControl1.SelectedTabIndex = 0
        BackstageViewControl1.Size = New Size(480, 150)
        BackstageViewControl1.TabIndex = 1
        ' 
        ' BackstageViewClientControl1
        ' 
        BackstageViewClientControl1.Location = New Point(150, 63)
        BackstageViewClientControl1.Name = "BackstageViewClientControl1"
        BackstageViewClientControl1.Size = New Size(329, 86)
        BackstageViewClientControl1.TabIndex = 1
        ' 
        ' BackstageViewTabItem1
        ' 
        BackstageViewTabItem1.Caption = "New"
        BackstageViewTabItem1.ContentControl = BackstageViewClientControl1
        BackstageViewTabItem1.ImageOptions.ItemNormal.SvgImage = CType(resources.GetObject("BackstageViewTabItem1.ImageOptions.ItemNormal.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        BackstageViewTabItem1.Name = "BackstageViewTabItem1"
        BackstageViewTabItem1.Selected = True
        ' 
        ' BarButtonItem1
        ' 
        BarButtonItem1.Caption = "Create a Card"
        BarButtonItem1.Hint = "This creates a card."
        BarButtonItem1.Id = 1
        BarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        BarButtonItem1.ItemAppearance.Normal.Font = New Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        BarButtonItem1.Name = "BarButtonItem1"
        ' 
        ' ribbonPage1
        ' 
        ribbonPage1.Appearance.Font = New Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ribbonPage1.Appearance.Options.UseFont = True
        ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {ribbonPageGroup1})
        ribbonPage1.Name = "ribbonPage1"
        ribbonPage1.Text = "Cards and Decks"
        ' 
        ' ribbonPageGroup1
        ' 
        ribbonPageGroup1.ItemLinks.Add(BarButtonItem1)
        ribbonPageGroup1.Name = "ribbonPageGroup1"
        ribbonPageGroup1.Text = "Cards"
        ' 
        ' Form1
        ' 
        Appearance.Options.UseFont = True
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(758, 360)
        Controls.Add(BackstageViewControl1)
        Controls.Add(ribbonControl1)
        Font = New Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Ribbon = ribbonControl1
        Text = "Form1"
        CType(ribbonControl1, ComponentModel.ISupportInitialize).EndInit()
        CType(BackstageViewControl1, ComponentModel.ISupportInitialize).EndInit()
        BackstageViewControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BackstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents BackstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem

End Class
