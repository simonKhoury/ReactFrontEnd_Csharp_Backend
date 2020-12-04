Imports Primitives
Imports Newtonsoft.Json


Public Class Form1

    Public csharpPrimitives As Json_To_Class
    Private mData As Data
    Private mControls As SortedDictionary(Of Integer, TextBox)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initialize_Form()
    End Sub

    Public Sub Initialize_Form()
        Initialize_Members()
        Initialize_Collection()
    End Sub

    Public Sub Initialize_Members()
        csharpPrimitives = New Json_To_Class
        mData = New Data

    End Sub
    Public Sub Initialize_Collection()
        mControls = New SortedDictionary(Of Integer, TextBox)
        With mControls
            .Add(0, txtBox_About)
            .Add(1, txt_Resume)
        End With
    End Sub

    Private Sub menuItem_Get_Data_Click(sender As Object, e As EventArgs) Handles menuItem_Get_Data.Click
        get_Data()
    End Sub

    Public Sub get_Data()
        Dim package As String = csharpPrimitives.get2()

        mData = JsonConvert.DeserializeObject(Of Data)(package)

        If Not IsNothing(mData) Then
            Display_Data()
        End If

        TextBox1.Text = mData.main.description
    End Sub

    Public Sub Display_Data()

        Display_Data_About()
        Display_Data_Resume()
    End Sub

    Public Sub Display_Data_About()
        Dim output As New System.Text.StringBuilder
        If Not IsNothing(mData) Then



            output.AppendLine(mData.main.name)
            output.AppendLine(mData.main.bio)
            output.AppendLine(mData.main.description)
            output.AppendLine(mData.main.email)
            output.AppendLine("Address : ")
            output.AppendLine(mData.main.address.street)
            output.AppendLine(mData.main.address.city)
            output.AppendLine(mData.main.address.state)
            output.AppendLine(mData.main.address.zip)
            output.AppendLine(mData.main.contactmessage)


        End If
        mControls(TabControl1.TabPages.IndexOf(TabPage1)).Text = output.ToString
    End Sub

    Public Sub Display_Data_Resume()


        Dim output As New System.Text.StringBuilder
        If Not IsNothing(mData) Then



            output.AppendLine(mData.resumes.skillmessage)
            output.AppendLine()
            output.AppendLine("Education : ")
            For Each edu In mData.resumes.education

                output.AppendLine(edu.school)
                output.AppendLine(edu.degree)
                output.AppendLine(edu.description)
                output.AppendLine(edu.graduated)
                output.AppendLine()

            Next


            For Each skill In mData.resumes.skills

                output.AppendLine(skill.name)
                output.AppendLine(skill.level)

                output.AppendLine()

            Next


            output.AppendLine("Work : ")
            For Each work In mData.resumes.work

                output.AppendLine(work.company)
                output.AppendLine(work.description)
                output.AppendLine(work.title)
                output.AppendLine(work.years)

                output.AppendLine()

            Next





        End If


        mControls(TabControl1.TabPages.IndexOf(TabPage2)).Text = output.ToString

    End Sub



End Class
