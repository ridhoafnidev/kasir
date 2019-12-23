Partial Class DbPenjualanDataSet
	Partial Public Class tb_barangDataTable
		Private Sub tb_barangDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
			If (e.Column.ColumnName = Me.kode_barangColumn.ColumnName) Then
				'Add user code here
			End If

		End Sub

	End Class
End Class
