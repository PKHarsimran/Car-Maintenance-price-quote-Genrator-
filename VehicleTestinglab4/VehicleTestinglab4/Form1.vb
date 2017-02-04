Public Class Form1
    Dim selection As String 'Variable for car selection

    Dim TAX As Double ' Tax variable


    Dim EngineTest As Double 'Enginetest variable
    Dim ExhuastSTest As Double 'exhuast system test variable
    Dim ElectricalTest As Double 'electrical test variable
    Dim BatteryTestOnlyHybrid As Double 'battery test for hybrid variable
    Dim IncludeDD As Double 'diagonostic test variabe

    Dim IncludeDDiagonostic As Boolean 'boolean so if condition could determine user has selected the diagnostic test

    Dim HourlyCost As Integer 'hourly cost variable


    Dim Subtotal As Double 'subtotal varible
    Dim Total As Double ' Total variable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' form load up
        CHHybrid.Visible = False 'make the hybrid option visible false 

        TAX = 0 ' make TAX variable zero

    End Sub
    Private Sub vehicleList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vehicleList.SelectedIndexChanged

        EngineTest = 3.0 'engine test will take 3 hours
        ElectricalTest = 2 'electrical test will take 2 hours
        ExhuastSTest = 1 'exhuast test 1 hour
        BatteryTestOnlyHybrid = 2 'Battery test only for hybrid will take 2 hours

        selection = vehicleList.Text 'put the selection or text when user picks from listbox in selection variable

        Select Case selection ' select case condition on selection variable
            Case "Tesla Model S" 'if this condition matches
                CKEngineTest.Text = "Battery Test" 'make engine test label show battery test for electrical vehicle
                CHHybrid.Visible = False 'make hybrid only varible visible false
                CHHybrid.Checked = False 'and uncheck the battery test for hybrid check box
                CHExhuastST.Text = "Auto Drive System Test" 'make exhuast test label to auto drive test for smart cars or TESLA
                PictureBox1.Image = My.Resources.CW7whm 'show logo of Tesla on picture box


                HourlyCost = 80 ' assign hourly cost 
            Case "Tesla Model X"
                CKEngineTest.Text = "Battery Test" 'make engine test label show battery test for electrical vehicle
                CHExhuastST.Text = "Auto Drive System Test" 'make exhuast test label to auto drive test for smart cars or TESLA
                CHHybrid.Visible = False 'make hybrid only varible visible false
                CHHybrid.Checked = False
                PictureBox1.Image = My.Resources.CW7whm 'show logo of Tesla on picture box

                HourlyCost = 150' assign hourly cost 
            Case "Tesla Model 3"
                CKEngineTest.Text = "Battery Test" 'make engine test label show battery test for electrical vehicle
                CHExhuastST.Text = "Auto Drive System Test" 'make exhuast test label to auto drive test for smart cars or TESLA
                CHHybrid.Visible = False 'make hybrid only varible visible false
                CHHybrid.Checked = False
                PictureBox1.Image = My.Resources.CW7whm 'show logo of Tesla on picture box


                HourlyCost = 100' assign hourly cost 
            Case "Ford Mustang"
                CKEngineTest.Text = "Engine Test" 'only show engine test label to cars with engine 
                CHExhuastST.Text = "Exhaust System Test" 'show exhaust test label for car with exhuast available 
                CHHybrid.Visible = False 'make hybrid only varible visible false
                CHHybrid.Checked = False
                PictureBox1.Image = My.Resources.images 'show logo of Mustang on picture box


                HourlyCost = 80' assign hourly cost 
            Case "Honda Civic"
                CKEngineTest.Text = "Engine Test" 'only show engine test label To cars With engine 
                CHHybrid.Visible = False 'make hybrid only varible visible false
                CHHybrid.Checked = False
                CHExhuastST.Text = "Exhaust System Test" 'show exhaust test label for car with exhuast available 
                PictureBox1.Image = My.Resources.HondaLogo 'show logo of Honda on picture box


                HourlyCost = 90' assign hourly cost 
            Case "Toyota Camry (Hybrid)"
                CKEngineTest.Text = " Engine Test" 'only show engine test label To cars With engine 
                CHExhuastST.Text = "Exhaust System Test" 'show exhaust test label for car with exhuast available 
                CHHybrid.Visible = True 'make hybrid only varible visible true for hybrid cars
                CHHybrid.Checked = False
                PictureBox1.Image = My.Resources.download 'show logo of Toyota on picture box


                HourlyCost = 200' assign hourly cost 
            Case "Toyota Camry"
                CKEngineTest.Text = " Engine Test" 'only show engine test label To cars With engine 
                CHExhuastST.Text = "Exhaust System Test" 'show exhaust test label for car with exhuast available 
                CHHybrid.Visible = False 'make hybrid only varible visible false
                CHHybrid.Checked = False
                PictureBox1.Image = My.Resources.download 'show logo of Toyota on picture box


                HourlyCost = 200 ' assign hourly cost 
        End Select
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' close the form once button is clicked
    End Sub

    Private Sub btnGetQuote_Click(sender As Object, e As EventArgs) Handles btnGetQuote.Click
        IncludeDDiagonostic = False ' make sure includeDDiagonostic bollean is false before checking for any check boxes are checked
        Subtotal = 0 'make subtotal 0 every time get qoute button is pressed . so it doesnt addup with previous value
        Select Case selection ' Do a Case condition on selection variable again to check which vehicle is selected
            Case "Tesla Model S"
                If CKEngineTest.Checked = True Then ' if user select battery test option for tesla then..
                    Subtotal = Subtotal + (EngineTest * HourlyCost) 'first add subtotal with hourly pay

                End If
                If CHElectricalT.Checked = True Then 'if user select option for electrical system test...
                    Subtotal = Subtotal + (ElectricalTest * HourlyCost) 'add up the cost by adding prices to subtotal

                End If
                If CHExhuastST.Checked = True Then ' and so on...
                    Subtotal = Subtotal + (ExhuastSTest * HourlyCost) ' calculations forexhuast system test.

                End If

                If CHIncludeDD.Checked = True Then 'if user checked the include diagnostic test then
                    IncludeDDiagonostic = True 'make this value true for future
                    Subtotal = Subtotal * 2 'double up the subtotal
                    IncludeDD = 50 ' add extra 50 on the price

                End If
            Case "Tesla Model X" ' and so on..
                If CKEngineTest.Checked = True Then
                    Subtotal = Subtotal + (EngineTest * HourlyCost)

                End If
                If CHElectricalT.Checked = True Then
                    Subtotal = Subtotal + (ElectricalTest * HourlyCost)

                End If
                If CHExhuastST.Checked = True Then
                    Subtotal = Subtotal + (ExhuastSTest * HourlyCost)

                End If

                If CHIncludeDD.Checked = True Then
                    IncludeDDiagonostic = True
                    Subtotal = Subtotal * 2
                    IncludeDD = 50

                End If
                If CHIncludeDD.Checked = True Then
                    IncludeDDiagonostic = True
                    IncludeDD = 50
                End If
            Case "Tesla Model 3"
                If CKEngineTest.Checked = True Then
                    Subtotal = Subtotal + (EngineTest * HourlyCost)

                End If
                If CHElectricalT.Checked = True Then
                    Subtotal = Subtotal + (ElectricalTest * HourlyCost)

                End If
                If CHExhuastST.Checked = True Then
                    Subtotal = Subtotal + (ExhuastSTest * HourlyCost)

                End If

                If CHIncludeDD.Checked = True Then
                    IncludeDDiagonostic = True
                    Subtotal = Subtotal * 2
                    IncludeDD = 50

                End If
                If CHIncludeDD.Checked = True Then
                    IncludeDDiagonostic = True
                    IncludeDD = 50
                End If
            Case "Ford Mustang"
                If CKEngineTest.Checked = True Then
                    Subtotal = Subtotal + (EngineTest * HourlyCost)

                End If
                If CHElectricalT.Checked = True Then
                    Subtotal = Subtotal + (ElectricalTest * HourlyCost)

                End If
                If CHExhuastST.Checked = True Then
                    Subtotal = Subtotal + (ExhuastSTest * HourlyCost)

                End If

                If CHIncludeDD.Checked = True Then
                    IncludeDDiagonostic = True
                    Subtotal = Subtotal * 2
                    IncludeDD = 50

                End If
                If CHIncludeDD.Checked = True Then
                    IncludeDDiagonostic = True
                    IncludeDD = 50
                End If
            Case "Honda Civic"
                If CKEngineTest.Checked = True Then
                    Subtotal = Subtotal + (EngineTest * HourlyCost)

                End If
                If CHElectricalT.Checked = True Then
                    Subtotal = Subtotal + (ElectricalTest * HourlyCost)

                End If
                If CHExhuastST.Checked = True Then
                    Subtotal = Subtotal + (ExhuastSTest * HourlyCost)

                End If

                If CHIncludeDD.Checked = True Then
                    IncludeDDiagonostic = True
                    Subtotal = Subtotal * 2
                    IncludeDD = 50

                End If
            Case "Toyota Camry (Hybrid)"
                If CKEngineTest.Checked = True Then
                    Subtotal = Subtotal + (EngineTest * HourlyCost)

                End If
                If CHElectricalT.Checked = True Then
                    Subtotal = Subtotal + (ElectricalTest * HourlyCost)

                End If
                If CHExhuastST.Checked = True Then
                    Subtotal = Subtotal + (ExhuastSTest * HourlyCost)

                End If
                If CHHybrid.Checked = True Then ' if battery test for hybrid option is checked then...
                    Subtotal = Subtotal + (BatteryTestOnlyHybrid * HourlyCost) ' do the same calculation and add up the price
                End If
                If CHIncludeDD.Checked = True Then
                    IncludeDDiagonostic = True
                    Subtotal = Subtotal * 2
                    IncludeDD = 50

                End If
            Case "Toyota Camry"
                If CKEngineTest.Checked = True Then
                    Subtotal = Subtotal + (EngineTest * HourlyCost)

                End If
                If CHElectricalT.Checked = True Then
                    Subtotal = Subtotal + (ElectricalTest * HourlyCost)

                End If
                If CHExhuastST.Checked = True Then
                    Subtotal = Subtotal + (ExhuastSTest * HourlyCost)

                End If

                If CHIncludeDD.Checked = True Then
                    IncludeDDiagonostic = True
                    Subtotal = Subtotal * 2
                    IncludeDD = 50

                End If

        End Select



        If RDOntario.Checked = True Then ' if check box for Ontario tax is selected then..
            TAX = 0.13 'make TAX variable 13 % or 0.13 in this case 
        End If
        If RDAlberta.Checked = True Then ' same thing with Alberta..
            TAX = 0.05 'TAX = 5 % or 0.05
        End If
        If RDBritishC.Checked = True Then 'Same thing with BC..
            TAX = 0.07
        End If
        If RDAlberta.Checked = False AndAlso RDBritishC.Checked = False AndAlso RDOntario.Checked = False Then ' if no option for tax is selected warn user with a msg box
            Call MsgBox("ERROR", 0, "Please Select TAX option") ' show msg box with Title Error. and wearning showing Please choose a region
        End If


        txtReport.Text = " Vehicle Testing Quote" & vbCrLf 'Print Title first in the text box
        txtReport.Text += " " & vbCrLf ' Space
        txtReport.Text += "Vehicle: " & selection & vbCrLf 'Show which vehicle is selected
        txtReport.Text += " " & vbCrLf 'space
        If CKEngineTest.Checked = True Then ' if engine test check box is checked then
            If selection = "Ford Mustang" Or selection = "Toyota Camry (Hybrid)" Or selection = "Toyota Camry" Or selection = "Honda Civic" Then ' if any of cars with engine is selected
                txtReport.Text += "Engine Test:" & FormatCurrency(EngineTest * HourlyCost, 2) ' make sure print engine test in text box
                If IncludeDDiagonostic = False Then ' and if Diagonostic test is not selected
                    txtReport.Text += vbCrLf 'skip the line
                End If
            Else
                txtReport.Text += "Battery Test:" & FormatCurrency(EngineTest * HourlyCost, 2) ' else print the following for Electrical cars
                If IncludeDDiagonostic = False Then 'and if Diagonostic test is not selected
                    txtReport.Text += vbCrLf ' skip this line
                End If
            End If
            If IncludeDDiagonostic = True Then ' if it is true then
                txtReport.Text += Space(25) & "With Detailed Diagnostics: " & FormatCurrency(EngineTest * HourlyCost, 2) & vbCrLf 'space it out 25 times and display with how many cost will it take for single test
            End If
        End If

        If CHExhuastST.Checked = True Then
            If selection = "Ford Mustang" Or selection = "Toyota Camry (Hybrid)" Or selection = "Toyota Camry" Or selection = "Honda Civic" Then
                txtReport.Text += "Exhaust System Tests:" & FormatCurrency(ExhuastSTest * HourlyCost, 2)
                If IncludeDDiagonostic = False Then
                    txtReport.Text += vbCrLf
                End If
            Else
                txtReport.Text += "AutoDrive System Test:" & FormatCurrency(ExhuastSTest * HourlyCost, 2)
                If IncludeDDiagonostic = False Then
                    txtReport.Text += vbCrLf
                End If
            End If
            If IncludeDDiagonostic = True Then
                txtReport.Text += Space(10) & "With Detailed Diagnostics: " & FormatCurrency(ExhuastSTest * HourlyCost, 2) & vbCrLf
            End If
        End If


        If CHExhuastST.Checked = True Then
            txtReport.Text += "Electrical System Tests:" & FormatCurrency(ElectricalTest * HourlyCost, 2)
            If IncludeDDiagonostic = False Then
                txtReport.Text += vbCrLf
            Else
                txtReport.Text += Space(9) & "With Detailed Diagnostics: " & FormatCurrency(ElectricalTest * HourlyCost, 2) & vbCrLf
            End If
        End If

        If CHHybrid.Checked = True Then
            txtReport.Text += "Battery Tests:" & FormatCurrency(BatteryTestOnlyHybrid * HourlyCost, 2)
            If IncludeDDiagonostic = False Then
                txtReport.Text += vbCrLf
            End If
            If IncludeDDiagonostic = True Then
                txtReport.Text += Space(25) & "With Detailed Diagnostics: " & FormatCurrency(BatteryTestOnlyHybrid * HourlyCost, 2) & vbCrLf
            End If
        End If

        If CHIncludeDD.Checked = True Then
            txtReport.Text += Space(70) & "Diagnostics Set Up Fee:" & FormatCurrency(IncludeDD) & vbCrLf
            If IncludeDDiagonostic = False Then
                txtReport.Text += vbCrLf
            End If
        End If
        txtReport.Text += vbCrLf
        txtReport.Text += "Subtotal:" & Space(16) & FormatCurrency(Subtotal, 2) & vbCrLf 'show subtotal without tax added
        txtReport.Text += FormatPercent(TAX) & " Tax:" & Space(10) & FormatCurrency(Subtotal * TAX, 2) & vbCrLf ' show which option for tax was choosen and how much you will be taxed
        Total = Subtotal + (Subtotal * TAX) ' do the calculation with tax added to subtotal and saved into total variable
        txtReport.Text += "Final Total:" & Space(13) & FormatCurrency(Total, 2) & vbCrLf 'show user with total
    End Sub
End Class
