Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        loadRecords()
    End Sub

    Sub loadRecords()
        dbconn()

        sql = "SELECT medical_records.medicalNo, medical_records.diagnosis, medical_records.petID, medical_records.doctorID, medical_records.date_created, pet.pet_name, client.complete_name, doctors.drcomplete_name, pet.note, pet.gender, pet.type, pet.pet_owner, 	client.address, " &
            "client.phone, client.email_address FROM medical_records INNER JOIN pet ON medical_records.petID = pet.pet_id INNER JOIN doctors ON medical_records.doctorID = doctors.dr_id INNER JOIN client ON pet.pet_owner = client.client_id"

        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader

        recordsList.Items.Clear()

        While dr.Read
            newLine = recordsList.Items.Add(dr("medicalNo"))
            newLine.SubItems.Add(dr("pet_name"))
            newLine.SubItems.Add(dr("type"))
            newLine.SubItems.Add(dr("gender"))
            newLine.SubItems.Add(dr("Diagnosis"))
            newLine.SubItems.Add(dr("note"))
            newLine.SubItems.Add(dr("complete_name"))
            newLine.SubItems.Add(dr("drcomplete_name"))
            newLine.SubItems.Add(dr("date_created"))
        End While

        cmd.Dispose()
        dr.Close()
        cn.Close()
    End Sub

    Private Sub recordsList_Click(sender As Object, e As EventArgs) Handles recordsList.Click
        If recordsList.SelectedItems.Count > 0 Then
            Dim selectedID As Integer = recordsList.SelectedItems(0).Text

            dbconn()

            sql = "SELECT medical_records.medicalNo, medical_records.prescription, medical_records.diagnosis, medical_records.petID, medical_records.doctorID, medical_records.date_created, pet.pet_name, client.complete_name, doctors.drcomplete_name, pet.note, pet.gender, pet.type, pet.pet_owner, 	client.address, client.phone, client.email_address FROM medical_records INNER JOIN pet ON medical_records.petID = pet.pet_id INNER JOIN doctors ON medical_records.doctorID = doctors.dr_id INNER JOIN client ON pet.pet_owner = client.client_id WHERE medicalNo=" & selectedID

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            Dim ownerName As String = ""
            Dim ownerAdd As String = ""
            Dim ownerPhone As String = ""
            Dim ownerEmail As String = ""
            Dim petName As String = ""
            Dim note As String = ""
            Dim diagnosis As String = ""
            Dim dateCreated As String = ""
            Dim gender As String = ""
            Dim drvet As String = ""
            Dim prescription As String = ""

            While dr.Read
                ownerName = dr("complete_name").ToString()
                ownerAdd = dr("address").ToString()
                ownerPhone = dr("phone").ToString()
                ownerEmail = dr("email_address").ToString()
                petName = dr("pet_name").ToString()
                note = dr("note").ToString()
                gender = dr("gender").ToString()
                diagnosis = dr("diagnosis").ToString()
                dateCreated = dr("date_created").ToString()
                drvet = dr("drcomplete_name").ToString()
                prescription = dr("prescription")
            End While

            dr.Close()
            cmd.Dispose()
            cn.Close()

            Dim medrecord As New medrecord()

            With medrecord
                .txtClientName.Text = ownerName
                .txtClientAddress.Text = ownerAdd
                .txtClientPhone.Text = ownerPhone
                .txtClientEmail.Text = ownerEmail
                .petName.Text = petName
                .petSpecies.Text = diagnosis
                .petGender.Text = gender
                .petNote.Text = note
                .txtFindings.Text = diagnosis
                .txtPrescription.Text = prescription
                .txtDoctor.Text = drvet
                .txtDate.Text = dateCreated
            End With
            medrecord.Show()
        End If
    End Sub

End Class
