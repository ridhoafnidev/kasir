Public Class FormPersonalManagement
	Private Sub Tb_barangBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_barangBindingNavigatorSaveItem.Click
		' Save
		' Me.Validate()
		' Me.Tb_barangBindingSource.EndEdit()
		' Me.TableAdapterManager.UpdateAll(Me.DbPenjualanDataSet)
		' TODO :)

		ButtonSimpanBarang.PerformClick()

	End Sub

	Private Sub FormPersonalManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'DbPenjualanDataSet.tb_barang' table. You can move, or remove it, as needed.
		 Me.Tb_barangTableAdapter.Fill(Me.DbPenjualanDataSet.tb_barang)

	End Sub

	Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
		ButtonTambahBarang.PerformClick()

	End Sub

	Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
		ButtonHapusBarang.PerformClick()

	End Sub

	Private Sub Tb_barangBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles Tb_barangBindingNavigator.RefreshItems

	End Sub

	Private Sub ButtonKeluarBarang_Click(sender As Object, e As EventArgs) Handles ButtonKeluarBarang.Click
		' Application.Exit()
		Me.Close()
	End Sub

	Private Sub ButtonSimpanBarang_Click(sender As Object, e As EventArgs) Handles ButtonSimpanBarang.Click
		' Save | Update
		' MsgBox("You pressed Save New Button")
		Try
			Dim result As DialogResult
			result = MessageBox.Show("Apakah kamu ingin menyimpan data ini?", "Save Data :",
									MessageBoxButtons.YesNo, MessageBoxIcon.Question)

			If (result = DialogResult.Yes) Then
				Validate()
				Tb_barangBindingSource.EndEdit()
				TableAdapterManager.UpdateAll(Me.DbPenjualanDataSet)

				MessageBox.Show("Data berhasil tersimpan",
							"Save Data : iBasskung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information)

				RefreshData()
			Else
				' Exit sub
			End If
		Catch ex As Exception
			MessageBox.Show("Simpan & Update data gagal" & ex.Message.ToString(),
							"Save Data : iBasskung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub ButtonTambahBarang_Click(sender As Object, e As EventArgs) Handles ButtonTambahBarang.Click
		' Save
		' MsgBox("Kamu mengklik tombol")
		Try
			With ButtonTambahBarang
				If .Text = "Tambah" Then
					Tb_barangBindingSource.AddNew()
					.Text = "Cancel"
				Else
					RefreshData()
					.Text = "Tambah"
				End If
			End With

			With Kode_barangTextBox
				If (.CanSelect) Then
					.Text = String.Empty
					.Select()
				End If
			End With

		Catch ex As Exception
			MsgBox("Ada kesalahan: " & ex.Message.ToString,
					MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Gagal menambahkan data barang.")
		End Try

	End Sub

	Private Sub RefreshData()
		Try
			Me.Tb_barangBindingSource.Filter = Nothing
			Me.Tb_barangTableAdapter.Fill(Me.DbPenjualanDataSet.tb_barang)
		Catch ex As Exception
			MsgBox("Refesh Data Error!")
		End Try
	End Sub


	Private Sub ButtonHapusBarang_Click(sender As Object, e As EventArgs) Handles ButtonHapusBarang.Click
		' MsgBox("You pressed Delete New Button")

		Try
			If MessageBox.Show("Apakah anda yakin ingin menghapus data ini?",
							   "Hapus data :", MessageBoxButtons.YesNo,
								MessageBoxIcon.Question) Then

				Tb_barangBindingSource.RemoveCurrent()

				Tb_barangBindingSource.EndEdit()
				Tb_barangTableAdapter.Update(DbPenjualanDataSet.tb_barang)

				RefreshData()

				MessageBox.Show("Data berhasil dihapus",
							"Hapus Data : iBasskung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information)

			End If
		Catch ex As Exception
			MessageBox.Show("Hapus data gagal" & ex.Message.ToString(),
							"Hapus Data : iBasskung Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try


	End Sub

	Private Sub ButtonCariBarang_Click(sender As Object, e As EventArgs) Handles ButtonCariBarang.Click
		MsgBox("You pressed Search New Button")
	End Sub
End Class
