Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        TextBox1.Visible = False


        cb4f2.Visible = False

        bedroom.Visible = True
        kitchen.Visible = False
        backyard.Visible = False
        shed.Visible = False
        ladder.Visible = False
        attic.Visible = False
        stair.Visible = False
        downstair.Visible = False
        mainentrance.Visible = False
        basement.Visible = False
        outside.Visible = False


    End Sub

    Private Function UpdateRoomData()
        If bedroom.Visible = True Then
            lbltitleofcontext.Text = "Bedroom"
            rbcontext.Text = "This is the room you wake up in, you don't know how you got here but you know you have to escape! You can see the three doors, they dont lead to the same space but connected throught these doors!"
            cb1f2.Text = "Door 1"
            cb2f2.Text = "Door 2"
            cb3f2.Text = "Door 3"
            cb1f2.Visible = True
            cb2f2.Visible = True
            cb3f2.Visible = True
            cb4f2.Visible = False

        ElseIf kitchen.Visible = True Then
            lbltitleofcontext.Text = "Kitchen"
            rbcontext.Text = "Messy and unusual looking kitchen!"
            cb1f2.Visible = True
            cb2f2.Visible = False
            cb3f2.Visible = False
            cb4f2.Visible = False
            cb1f2.Text = "Enter backyard"

        ElseIf backyard.Visible = True Then
            lbltitleofcontext.Text = "Backyard"
            rbcontext.Text = "You can feel the breeze.... the fog that cover teh forest seem pretty dangerous, escaping with a veichle throught the fog is a good idea!"
            cb1f2.Visible = True
            cb2f2.Visible = False
            cb3f2.Visible = False
            cb4f2.Visible = False
            cb1f2.Text = "Enter shed"

        ElseIf shed.Visible = True Then
            lbltitleofcontext.Text = "Shed"
            rbcontext.Text = "A shed with an old car that is out of fuel."
            cb1f2.Visible = False
            cb2f2.Visible = False
            cb3f2.Visible = False
            cb4f2.Visible = False


        ElseIf ladder.Visible = True Then
            lbltitleofcontext.Text = "Ladder"
            rbcontext.Text = "A ladder to the attic!"
            cb1f2.Visible = False
            cb4f2.Visible = True
            cb3f2.Visible = False
            cb4f2.Visible = False
            cb2f2.Text = "Climb"

        ElseIf attic.Visible = True Then
            lbltitleofcontext.Text = "Attic"
            rbcontext.Text = ""
            cb1f2.Visible = False
            cb2f2.Visible = False
            cb3f2.Visible = False
            cb4f2.Visible = False

        ElseIf stair.Visible = True Then
            lbltitleofcontext.Text = "Stair"
            rbcontext.Text = "A stair that's going down!"
            cb1f2.Visible = False
            cb2f2.Visible = False
            cb3f2.Visible = True
            cb4f2.Visible = False
            cb3f2.Text = "Go downstair"

        ElseIf downstair.Visible = True Then
            lbltitleofcontext.Text = "Downstair"
            rbcontext.Text = "Downstair of the house"
            cb1f2.Visible = False
            cb2f2.Visible = False
            cb3f2.Visible = True
            cb4f2.Visible = True
            cb3f2.Text = "Get close to door"

        ElseIf mainentrance.Visible = True Then
            lbltitleofcontext.Text = "Main Entrance"
            rbcontext.Text = "The main entrance door"
            cb1f2.Visible = False
            cb2f2.Visible = False
            cb3f2.Visible = False
            cb4f2.Visible = False

        ElseIf basement.Visible = True Then
            lbltitleofcontext.Text = "Basement"
            rbcontext.Text = ""
            cb1f2.Visible = False
            cb2f2.Visible = False
            cb3f2.Visible = False
            cb4f2.Visible = False

        ElseIf outside.Visible = True Then
            lbltitleofcontext.Text = "Outside"
            rbcontext.Text = ""
            cb1f2.Visible = False
            cb2f2.Visible = False
            cb3f2.Visible = False
            cb4f2.Visible = False

        End If

    End Function

    Private Function Function2()
        If kitchen.Visible = True Then
            kitchen.Visible = False
            bedroom.Visible = True
        ElseIf backyard.Visible = True Then
            backyard.Visible = False
            kitchen.Visible = True
        ElseIf shed.Visible = True Then
            shed.Visible = False
            backyard.Visible = True
        ElseIf ladder.Visible = True Then
            ladder.Visible = False
            bedroom.Visible = True
        ElseIf attic.Visible = True Then
            attic.Visible = False
            ladder.Visible = True
        ElseIf stair.Visible = True Then
            stair.Visible = False
            bedroom.Visible = True
        ElseIf downstair.Visible = True Then
            downstair.Visible = False
            stair.Visible = True
        ElseIf mainentrance.Visible = True Then
            mainentrance.Visible = False
            downstair.Visible = True
        ElseIf basement.Visible = True Then
            basement.Visible = False
            downstair.Visible = True
        End If
    End Function

    Private Function Search()
        If bedroom.Visible = True Then
            If TextBox1.Text = "flashlight" Then
                lblresult.Text = "you found a wooden cube"
                TextBox11.Text = "Wooden cube"


            Else
                TextBox1.Text = "flashlight"
                lblresult.Text = "You've found a flashlight but you didn't check some places because it is so dark."

            End If



        ElseIf kitchen.Visible = True Then
            If TextBox3.Text = "hammer" Then
                lblresult.Text = "You've found nothing more!"
            Else
                TextBox3.Text = "hammer"
                lblresult.Text = "You've found a hammer."
            End If


        ElseIf shed.Visible = True Then
            If TextBox5.Text = "car key" Then
                If TextBox6.Text = "furl" Then
                    Dim f4 As New Form4
                    f4.Show()
                    Me.Hide()

                End If
            End If


        ElseIf attic.Visible = True Then
            If TextBox3.Text = "hammer" Then
                TextBox4.Text = "safe key"
                lblresult.Text = "You've found a safe key. by breaking the suspicious pot"
            Else
                lblresult.Text = "You've found nothing but noticed a strange pot in the room"
            End If

        ElseIf downstair.Visible = True Then
            If TextBox1.Text = "flashlight" Then
                TextBox5.Text = "car key"
                lblresult.Text = "You've found a car key in teh darkcorner when u use ur flashlight"
            Else
                lblresult.Text = "You've found nothing!"
            End If


        ElseIf mainentrance.Visible = True Then
            If TextBox11.Text = "Wooden cube" Then
                If TextBox3.Text = "hammer" Then
                    TextBox7.Text = "main key"
                    lblresult.Text = "You smash the wooden cube with hammer cuz of ur gut feeling and fiund the main key!"
                    cbgobackf2.Visible = False
                    lbltitleofcontext.Visible = False
                    rbcontext.Visible = False
                    cbsearchf2.Visible = False
                    cbtheescape.Visible = True

                End If
            End If



        ElseIf basement.Visible = True Then
            If TextBox4.Text = "safe key" Then
                TextBox6.Text = "fuel"
                lblresult.Text = "you've found fuel"
            Else
                lblresult.Text = "you've found a safe but that's it"
            End If

        End If

    End Function


    Private Sub cb1f2_Click(sender As Object, e As EventArgs) Handles cb1f2.Click
        If bedroom.Visible = True Then
            bedroom.Visible = False
            kitchen.Visible = True
        ElseIf kitchen.Visible = True Then
            kitchen.Visible = False
            backyard.Visible = True
        ElseIf backyard.Visible = True Then
            backyard.Visible = False
            shed.Visible = True
        ElseIf shed.Visible = True Then

        End If


        UpdateRoomData()

    End Sub

    Private Sub cb2f2_Click(sender As Object, e As EventArgs) Handles cb2f2.Click

        If bedroom.Visible = True Then
            bedroom.Visible = False
            ladder.Visible = True
        ElseIf ladder.Visible = True Then
            ladder.Visible = False
            attic.Visible = True
        ElseIf attic.Visible = True Then
            attic.Visible = False
        End If

        UpdateRoomData()
    End Sub

    Private Sub cb3f2_Click(sender As Object, e As EventArgs) Handles cb3f2.Click
        If bedroom.Visible = True Then
            bedroom.Visible = False
            stair.Visible = True
        ElseIf stair.Visible = True Then
            stair.Visible = False
            downstair.Visible = True
        ElseIf downstair.Visible = True Then
            downstair.Visible = False
            mainentrance.Visible = True
        ElseIf mainentrance.Visible = True Then
            mainentrance.Visible = False

        End If
        UpdateRoomData()
    End Sub

    Private Sub cbgobackf2_Click(sender As Object, e As EventArgs) Handles cbgobackf2.Click
        Function2()

        UpdateRoomData()
    End Sub

    Private Sub cb4f2_Click(sender As Object, e As EventArgs) Handles cb4f2.Click
        If downstair.Visible = True Then
            downstair.Visible = False
            basement.Visible = True
            cb4f2.Visible = False
            cb3f2.Visible = False
        End If
    End Sub

    Private Sub cbsearchf2_Click(sender As Object, e As EventArgs) Handles cbsearchf2.Click

        Search()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cbtheescape.Click
        Dim f5 As New Form5
        f5.Show()
        Me.Hide()
    End Sub
End Class