Partial Class Default2
    Inherits System.Web.UI.Page

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load

            Dim Flagimageurl(6) As String ' creating the flag image url array'
            Flagimageurl(0) = "https://www.cia.gov/library/publications/the-world-factbook/graphics/flags/large/uk-lgflag.gif"
            Flagimageurl(1) = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/800px-Flag_of_France.svg.png"
            Flagimageurl(2) = "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/720px-Flag_of_Brazil.svg.png"
            Flagimageurl(3) = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/Flag_of_Spain.svg/750px-Flag_of_Spain.svg.png"
            Flagimageurl(4) = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/1235px-Flag_of_the_United_States.svg.png"
            Flagimageurl(5) = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Flag_of_Russia_%28Kremlin.ru%29.svg/1024px-Flag_of_Russia_%28Kremlin.ru%29.svg.png"


            Dim CountryNames(6) As String 'creating the country names array'
            CountryNames(0) = "United Kingdom"
            CountryNames(1) = "France"
            CountryNames(2) = "Brazil"
            CountryNames(3) = "Spain"
            CountryNames(4) = "United States of America (USA)"
            CountryNames(5) = "Russia"

            flag.ImageUrl = Flagimageurl(6 * Rnd()) 'Choosing a random flag'
            RadioButton1.Text = CountryNames(5 * Rnd()) 'Randomly picks the country according to the CountryNames array'
            RadioButton2.Text = CountryNames(5 * Rnd())  ' with random * 6 you get blanks so you need to use random * 5'
            RadioButton3.Text = CountryNames(5 * Rnd())
            RadioButton4.Text = CountryNames(5 * Rnd())

            If RadioButton1.Text = RadioButton2.Text Then 'Makes sure that the radiobuttons don't show duplicate answers'
                RadioButton2.Text = CountryNames(5 * Rnd())
            End If

        If RadioButton3.Text = RadioButton1.Text Or RadioButton3.Text = RadioButton2.Text Then
                RadioButton3.Text = CountryNames(5 * Rnd())
            End If

            If RadioButton4.Text = RadioButton1.Text Or RadioButton2.Text = RadioButton3.Text Then
                RadioButton4.Text = CountryNames(5 * Rnd())
            End If

        End Sub
    End Class

    End Sub
End Class
