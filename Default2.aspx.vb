﻿Partial Class Default2
    Inherits System.Web.UI.Page

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load

        Dim Flagimageurl(10) As String ' creating the flag image url array'
        Flagimageurl(0) =
        Flagimageurl(1) =
        Flagimageurl(2) =
        Flagimageurl(3) =
        Flagimageurl(4) =
        Flagimageurl(5) =
        Flagimageurl(6) =
        Flagimageurl(7) =
        Flagimageurl(8) =
        Flagimageurl(9) =
        Flagimageurl(10) =
        Flagimageurl(11) =
        Flagimageurl(12) =
        Flagimageurl(13) =
        Flagimageurl(14) =
        Flagimageurl(15) =
        Flagimageurl(16) =
        Flagimageurl(17) =
        Flagimageurl(18) =
        Flagimageurl(19) =
        Flagimageurl(20) =
        Flagimageurl(21) =
        Flagimageurl(22) =
        Flagimageurl(23) =
        Flagimageurl(24) =
        Flagimageurl(25) =
        Flagimageurl(26) =
        Flagimageurl(27) =
        Flagimageurl(28) =
        Flagimageurl(29) =
        Flagimageurl(30) =
        Flagimageurl(31) =
        Flagimageurl(32) =
        Flagimageurl(33) =
        Flagimageurl(34) =
        Flagimageurl(35) =
        Flagimageurl(36) =
        Flagimageurl(37) =
        Flagimageurl(38) =
        Flagimageurl(39) =
        Flagimageurl(40) =
        Flagimageurl(41) =
        Flagimageurl(42) =
        Flagimageurl(43) =
        Flagimageurl(44) =
        Flagimageurl(45) =
        Flagimageurl(46) =
        Flagimageurl(47) =
        Flagimageurl(48) =
        Flagimageurl(49) =
        Flagimageurl(50) =







        Flagimageurl(0) = "https://www.cia.gov/library/publications/the-world-factbook/graphics/flags/large/uk-lgflag.gif"
        Flagimageurl(1) = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/800px-Flag_of_France.svg.png"
        Flagimageurl(2) = "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/720px-Flag_of_Brazil.svg.png"
        Flagimageurl(3) = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/Flag_of_Spain.svg/750px-Flag_of_Spain.svg.png"
        Flagimageurl(4) = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/1235px-Flag_of_the_United_States.svg.png"
        Flagimageurl(5) = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Flag_of_Russia_%28Kremlin.ru%29.svg/1024px-Flag_of_Russia_%28Kremlin.ru%29.svg.png"
        Flagimageurl(6) = "https://upload.wikimedia.org/wikipedia/commons/6/6d/Japan_flag_-_variant.png"
        Flagimageurl(7) = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Flag_of_China.png"
        Flagimageurl(8) = "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Flag_of_Italy.svg/1280px-Flag_of_Italy.svg.png"
        Flagimageurl(9) = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Flag_of_Canada.png"
        Flagimageurl(10) = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Germany.svg/800px-Flag_of_Germany.svg.png"
        Flagimageurl(11) = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Flag_of_South_Africa.svg/1024px-Flag_of_South_Africa.svg.png"
        Flagimageurl(12) = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Flag_of_Australia.svg/1024px-Flag_of_Australia.svg.png"
        Flagimageurl(13) = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/768px-Flag_of_Switzerland.svg.png"

        Dim CountryNames(10) As String 'creating the country names array'
        CountryNames(0) = "Afghanistan"
        CountryNames(1) = "Albania"
        CountryNames(2) = "Algeria"
        CountryNames(3) = "Andorra"
        CountryNames(4) = "Angola"
        CountryNames(5) = "Antigua and Barbuda"
        CountryNames(6) = "Argentina"
        CountryNames(7) = "Armenia"
        CountryNames(8) = "Australia"
        CountryNames(9) = "Austria"
        CountryNames(10) = "Azerbaijan"
        'countries listed in alphabetical order'
        CountryNames(11) = "Bahamas"
        CountryNames(12) = "Bahrain"
        CountryNames(13) = "Bangladesh"
        CountryNames(14) = "Barbados"
        CountryNames(15) = "Belarus"
        CountryNames(16) = "Belgium"
        CountryNames(17) = "Belize"
        CountryNames(18) = "Benin"
        CountryNames(19) = "Bhutan"
        CountryNames(20) = "Bolivia"
        CountryNames(21) = "Bosnia and Herzegovina"
        CountryNames(22) = "Botswana"
        CountryNames(23) = "Brazil"
        CountryNames(24) = "Brunei"
        CountryNames(25) = "Bulgaria"
        CountryNames(26) = "Burkina Faso"
        CountryNames(27) = "Burma (Myanmar)"
        CountryNames(28) = "Burundi"
        'countries listed in alphabetical order'
        CountryNames(29) = "Cambodia"
        CountryNames(30) = "Cameroon"
        CountryNames(31) = "Canada"
        CountryNames(32) = "Cape Verde"
        CountryNames(33) = "Central African Republic"
        CountryNames(34) = "Chad"
        CountryNames(35) = "Chile"
        CountryNames(36) = "China"
        CountryNames(37) = "Colombia"
        CountryNames(38) = "Comoros"
        CountryNames(39) = "The Democratic Republic of the Congo"
        CountryNames(40) = "Republic of Congo"
        CountryNames(41) = "Costa Rica"
        CountryNames(42) = "Côte d’Ivoire"
        CountryNames(43) = "Croatia"
        CountryNames(44) = "Cuba"
        CountryNames(45) = "Cyprus"
        CountryNames(46) = "Czech Republic"
        'countries listed in alphabetical order'
        CountryNames(47) = "Denmark"
        CountryNames(48) = "Djibouti"
        CountryNames(49) = "Dominica"
        CountryNames(50) = "Dominican Republic"
        'countries listed in alphabetical order'
        CountryNames(51) = "East Timor"
        CountryNames(52) = "Ecuador"
        CountryNames(53) = "Egypt"
        CountryNames(54) = "El Salvador"








        CountryNames(0) = "United Kingdom"
        CountryNames(1) = "France"
        CountryNames(3) = "Spain"
        CountryNames(4) = "United States of America (USA)"
        CountryNames(5) = "Russia"
        CountryNames(6) = "Japan"
        CountryNames(8) = "Italy"
        CountryNames(10) = "Germany"
        CountryNames(11) = "South Africa"
        CountryNames(13) = "Switzerland"




        flag.ImageUrl = Flagimageurl(9 * Rnd()) 'Choosing a random flag'
        RadioButton1.Text = CountryNames(9 * Rnd()) 'Randomly picks the country according to the CountryNames array'
        RadioButton2.Text = CountryNames(9 * Rnd())  ' with random * 10 you get blanks so you need to use random * 9'
        RadioButton3.Text = CountryNames(9 * Rnd())
        RadioButton4.Text = CountryNames(9 * Rnd())

        If RadioButton2.Text = RadioButton1.Text Or RadioButton2.Text = RadioButton3.Text Or RadioButton2.Text = RadioButton4.Text Then  'Makes sure that the radiobuttons don't show duplicate answers'
            RadioButton1.Text = CountryNames(9 * Rnd())

            If RadioButton3.Text = RadioButton2.Text Or RadioButton3.Text = RadioButton1.Text Or RadioButton3.Text = RadioButton4.Text Then  'Makes sure that the radiobuttons don't show duplicate answers'
                RadioButton1.Text = CountryNames(9 * Rnd())

                If RadioButton4.Text = RadioButton2.Text Or RadioButton4.Text = RadioButton3.Text Or RadioButton4.Text = RadioButton1.Text Then  'Makes sure that the radiobuttons don't show duplicate answers'
                    RadioButton1.Text = CountryNames(9 * Rnd())
                End If
            End If
        End If

    End Sub
End Class



