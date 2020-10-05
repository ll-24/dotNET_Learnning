Dim theDay = Datetime.Now
'Sart date / first day of month
Dim startDate = New Datetime.(theDay.Year, theDay.Month, 1)
'End date / End day of month
Dim endDate = startDate.AddMonths(1).AddDays(-1)
