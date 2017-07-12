Partial Class Default2
    Inherits System.Web.UI.Page

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load

        Dim Flagimageurl(10) As String ' creating the flag image url array'
        Flagimageurl(0) = "https://en.wikipedia.org/wiki/Flag_of_Afghanistan#/media/File:Flag_of_Afghanistan.svg"
        Flagimageurl(1) = "https://en.wikipedia.org/wiki/Flag_of_Albania#/media/File:Flag_of_Albania.svg"
        Flagimageurl(2) = "https://commons.wikimedia.org/wiki/File:Flag_of_Algeria.svg"
        Flagimageurl(3) = "https://en.wikipedia.org/wiki/Flag_of_Andorra#/media/File:Flag_of_Andorra.svg"
        Flagimageurl(4) = "https://en.wikipedia.org/wiki/Flag_of_Angola#/media/File:Flag_of_Angola.svg"
        Flagimageurl(5) = "https://en.wikipedia.org/wiki/Antigua_and_Barbuda#/media/File:Flag_of_Antigua_and_Barbuda.svg"
        Flagimageurl(6) = "https://en.wikipedia.org/wiki/Argentina#/media/File:Flag_of_Argentina.svg"
        Flagimageurl(7) = "https://en.wikipedia.org/wiki/Flag_of_Armenia#/media/File:Flag_of_Armenia.svg"
        Flagimageurl(8) = "https://en.wikipedia.org/wiki/Flag_of_Australia#/media/File:Flag_of_Australia.svg"
        Flagimageurl(9) = "https://en.wikipedia.org/wiki/Austria#/media/File:Flag_of_Austria.svg"
        Flagimageurl(10) = "https://en.wikipedia.org/wiki/Azerbaijan#/media/File:Flag_of_Azerbaijan.svg"
        Flagimageurl(11) = "https://en.wikipedia.org/wiki/The_Bahamas#/media/File:Flag_of_the_Bahamas.svg"
        Flagimageurl(12) = "https://en.wikipedia.org/wiki/Bahrain#/media/File:Flag_of_Bahrain.svg"
        Flagimageurl(13) = "https://en.wikipedia.org/wiki/Bangladesh#/media/File:Flag_of_Bangladesh.svg"
        Flagimageurl(14) = "https://en.wikipedia.org/wiki/Barbados#/media/File:Flag_of_Barbados.svg"
        Flagimageurl(15) = "https://en.wikipedia.org/wiki/Belarus#/media/File:Flag_of_Belarus.svg"
        Flagimageurl(16) = "https://en.wikipedia.org/wiki/Belgium#/media/File:Flag_of_Belgium.svg"
        Flagimageurl(17) = "https://en.wikipedia.org/wiki/Belize#/media/File:Flag_of_Belize.svg"
        Flagimageurl(18) = "https://en.wikipedia.org/wiki/Benin#/media/File:Flag_of_Benin.svg"
        Flagimageurl(19) = "https://en.wikipedia.org/wiki/Bhutan#/media/File:Flag_of_Bhutan.svg"
        Flagimageurl(20) = "https://en.wikipedia.org/wiki/Bolivia#/media/File:Flag_of_Bolivia_(state).svg"
        Flagimageurl(21) = "https://en.wikipedia.org/wiki/Bosnia_and_Herzegovina#/media/File:Flag_of_Bosnia_and_Herzegovina.svg"
        Flagimageurl(22) = "https://en.wikipedia.org/wiki/Botswana#/media/File:Flag_of_Botswana.svg"
        Flagimageurl(23) = "https://en.wikipedia.org/wiki/Brazil#/media/File:Flag_of_Brazil.svg"
        Flagimageurl(24) = "https://en.wikipedia.org/wiki/Flag_of_Brunei#/media/File:Flag_of_Brunei.svg"
        Flagimageurl(25) = "https://en.wikipedia.org/wiki/Flag_of_Bulgaria#/media/File:Flag_of_Bulgaria.svg"
        Flagimageurl(26) = "https://en.wikipedia.org/wiki/Flag_of_Burkina_Faso#/media/File:Flag_of_Burkina_Faso.svg"
        Flagimageurl(27) = "https://en.wikipedia.org/wiki/Myanmar#/media/File:Flag_of_Myanmar.svg"
        Flagimageurl(28) = "https://en.wikipedia.org/wiki/Burundi#/media/File:Flag_of_Burundi.svg"
        Flagimageurl(29) = "https://upload.wikimedia.org/wikipedia/commons/8/83/Flag_of_Cambodia.svg"
        Flagimageurl(30) = "https://en.wikipedia.org/wiki/Cameroon#/media/File:Flag_of_Cameroon.svg"
        Flagimageurl(31) = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Flag_of_Canada.svg"
        Flagimageurl(32) = "https://en.wikipedia.org/wiki/Cape_Verde#/media/File:Flag_of_Cape_Verde.svg"
        Flagimageurl(33) = "https://en.wikipedia.org/wiki/Central_African_Republic#/media/File:Flag_of_the_Central_African_Republic.svg"
        Flagimageurl(34) = "https://en.wikipedia.org/wiki/Chad#/media/File:Flag_of_Chad.svg"
        Flagimageurl(35) = "https://en.wikipedia.org/wiki/Chile#/media/File:Flag_of_Chile.svg"
        Flagimageurl(36) = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Flag_of_China.png"
        Flagimageurl(37) = "https://en.wikipedia.org/wiki/Flag_of_Colombia#/media/File:Flag_of_Colombia.svg"
        Flagimageurl(38) = "https://en.wikipedia.org/wiki/Flag_of_the_Comoros#/media/File:Flag_of_the_Comoros.svg"
        Flagimageurl(39) = "https://en.wikipedia.org/wiki/Democratic_Republic_of_the_Congo#/media/File:Flag_of_the_Democratic_Republic_of_the_Congo.svg"
        Flagimageurl(40) = "https://en.wikipedia.org/wiki/Flag_of_the_Republic_of_the_Congo#/media/File:Flag_of_the_Republic_of_the_Congo.svg"
        Flagimageurl(41) = "https://en.wikipedia.org/wiki/Flag_of_Costa_Rica#/media/File:Flag_of_Costa_Rica_(state).svg"
        Flagimageurl(42) = "https://en.wikipedia.org/wiki/Ivory_Coast#/media/File:Flag_of_C%C3%B4te_d%27Ivoire.svg"
        Flagimageurl(43) = "https://en.wikipedia.org/wiki/Croatia#/media/File:Flag_of_Croatia.svg"
        Flagimageurl(44) = "https://en.wikipedia.org/wiki/Cuba#/media/File:Flag_of_Cuba.svg"
        Flagimageurl(45) = "https://upload.wikimedia.org/wikipedia/commons/d/d4/Flag_of_Cyprus.svg"
        Flagimageurl(46) = "https://en.wikipedia.org/wiki/Czech_Republic#/media/File:Flag_of_the_Czech_Republic.svg"
        Flagimageurl(47) = "https://en.wikipedia.org/wiki/Denmark#/media/File:Flag_of_Denmark.svg"
        Flagimageurl(48) = "https://en.wikipedia.org/wiki/Djibouti#/media/File:Flag_of_Djibouti.svg"
        Flagimageurl(49) = "https://en.wikipedia.org/wiki/Flag_of_Dominica#/media/File:Flag_of_Dominica.svg"
        Flagimageurl(50) = "https://en.wikipedia.org/wiki/Dominican_Republic#/media/File:Flag_of_the_Dominican_Republic.svg"
        Flagimageurl(51) = "https://en.wikipedia.org/wiki/East_Timor#/media/File:Flag_of_East_Timor.svg"
        Flagimageurl(52) = "https://en.wikipedia.org/wiki/Ecuador#/media/File:Flag_of_Ecuador.svg"
        Flagimageurl(53) = "https://en.wikipedia.org/wiki/Egypt#/media/File:Flag_of_Egypt.svg"
        Flagimageurl(54) = "https://en.wikipedia.org/wiki/El_Salvador#/media/File:Flag_of_El_Salvador.svg"
        Flagimageurl(55) = "https://en.wikipedia.org/wiki/Equatorial_Guinea#/media/File:Flag_of_Equatorial_Guinea.svg"
        Flagimageurl(56) = "https://en.wikipedia.org/wiki/Eritrea#/media/File:Flag_of_Eritrea.svg"
        Flagimageurl(57) = "https://en.wikipedia.org/wiki/Estonia#/media/File:Flag_of_Estonia.svg"
        Flagimageurl(58) = "https://en.wikipedia.org/wiki/Ethiopia#/media/File:Flag_of_Ethiopia.svg"
        Flagimageurl(59) = "https://en.wikipedia.org/wiki/Fiji#/media/File:Flag_of_Fiji.svg"
        Flagimageurl(60) = "https://en.wikipedia.org/wiki/Finland#/media/File:Flag_of_Finland.svg"
        Flagimageurl(61) = "https://en.wikipedia.org/wiki/France#/media/File:Flag_of_France.svg"
        Flagimageurl(62) = "https://en.wikipedia.org/wiki/Gabon#/media/File:Flag_of_Gabon.svg"
        Flagimageurl(63) = "https://en.wikipedia.org/wiki/The_Gambia#/media/File:Flag_of_The_Gambia.svg"
        Flagimageurl(64) = "https://en.wikipedia.org/wiki/Georgia_(country)#/media/File:Flag_of_Georgia.svg"
        Flagimageurl(65) = "https://en.wikipedia.org/wiki/Germany#/media/File:Flag_of_Germany.svg"
        Flagimageurl(66) = "https://en.wikipedia.org/wiki/Ghana#/media/File:Flag_of_Ghana.svg"
        Flagimageurl(67) = "https://en.wikipedia.org/wiki/Greece#/media/File:Flag_of_Greece.svg"
        Flagimageurl(68) = "https://en.wikipedia.org/wiki/Grenada#/media/File:Flag_of_Grenada.svg"
        Flagimageurl(69) = "https://en.wikipedia.org/wiki/Guatemala#/media/File:Flag_of_Guatemala.svg"
        Flagimageurl(70) = "https://en.wikipedia.org/wiki/Guinea#/media/File:Flag_of_Guinea.svg"
        Flagimageurl(71) =
        Flagimageurl(72) =
        Flagimageurl(73) =
        Flagimageurl(74) =
        Flagimageurl(75) =
        Flagimageurl(76) =
        Flagimageurl(77) =
        Flagimageurl(78) =
        Flagimageurl(79) =
        Flagimageurl(80) =
        Flagimageurl(81) =
        Flagimageurl(82) =
        Flagimageurl(83) =
        Flagimageurl(84) =
        Flagimageurl(85) =
        Flagimageurl(86) =
        Flagimageurl(87) =
        Flagimageurl(88) =
        Flagimageurl(89) =
        Flagimageurl(90) =
        Flagimageurl(91) =
        Flagimageurl(92) =
        Flagimageurl(93) =
        Flagimageurl(94) =
        Flagimageurl(95) =
        Flagimageurl(96) =
        Flagimageurl(97) =
        Flagimageurl(98) =
        Flagimageurl(99) =
        Flagimageurl(100) =
        Flagimageurl(101) =
        Flagimageurl(102) =
        Flagimageurl(103) =
        Flagimageurl(104) =
        Flagimageurl(105) =
        Flagimageurl(106) =
        Flagimageurl(107) =
        Flagimageurl(108) =
        Flagimageurl(109) =
        Flagimageurl(110) =
        Flagimageurl(111) =
        Flagimageurl(112) =
        Flagimageurl(113) =
        Flagimageurl(114) =
        Flagimageurl(115) =
        Flagimageurl(116) =
        Flagimageurl(117) =
        Flagimageurl(118) =
        Flagimageurl(119) =
        Flagimageurl(120) =
        Flagimageurl(121) =
        Flagimageurl(122) =
        Flagimageurl(123) =
        Flagimageurl(124) =
        Flagimageurl(125) =
        Flagimageurl(126) =
        Flagimageurl(127) =
        Flagimageurl(128) =
        Flagimageurl(129) =
        Flagimageurl(130) =
        Flagimageurl(131) =
        Flagimageurl(132) =
        Flagimageurl(133) =
        Flagimageurl(134) =
        Flagimageurl(135) =
        Flagimageurl(136) =
        Flagimageurl(137) =
        Flagimageurl(138) =
        Flagimageurl(139) =
        Flagimageurl(140) =
        Flagimageurl(141) =
        Flagimageurl(142) =
        Flagimageurl(143) =
        Flagimageurl(144) =
        Flagimageurl(145) =
        Flagimageurl(146) =
        Flagimageurl(147) =
        Flagimageurl(148) =
        Flagimageurl(149) =
        Flagimageurl(150) =
        Flagimageurl(151) =
        Flagimageurl(152) =
        Flagimageurl(153) =
        Flagimageurl(154) =
        Flagimageurl(155) =
        Flagimageurl(156) =
        Flagimageurl(157) =
        Flagimageurl(158) =
        Flagimageurl(159) =
        Flagimageurl(160) =
        Flagimageurl(161) =
        Flagimageurl(162) =
        Flagimageurl(163) =
        Flagimageurl(164) =
        Flagimageurl(165) =
        Flagimageurl(166) =
        Flagimageurl(167) =
        Flagimageurl(168) =
        Flagimageurl(169) =
        Flagimageurl(170) =
        Flagimageurl(171) =
        Flagimageurl(172) =
        Flagimageurl(173) =
        Flagimageurl(174) =
        Flagimageurl(175) =
        Flagimageurl(176) =
        Flagimageurl(177) =
        Flagimageurl(178) =
        Flagimageurl(179) =
        Flagimageurl(180) =
        Flagimageurl(181) =
        Flagimageurl(182) =
        Flagimageurl(183) =
        Flagimageurl(184) =
        Flagimageurl(185) =
        Flagimageurl(186) =
        Flagimageurl(187) =
        Flagimageurl(188) =
        Flagimageurl(189) =
        Flagimageurl(190) =
        Flagimageurl(191) =
        Flagimageurl(192) =
        Flagimageurl(193) =
        Flagimageurl(194) =
        Flagimageurl(195) =
        Flagimageurl(196) =


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
        CountryNames(27) = "Mayanmar (Burma)"
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
        CountryNames(55) = "Equatorial Guinea"
        CountryNames(56) = "Eritrea"
        CountryNames(57) = "Estonia"
        CountryNames(58) = "Ethiopia"

        'countries listed in alphabetial order'
        CountryNames(59) = "Fiji"
        CountryNames(60) = "Finland"
        CountryNames(61) = "France"

        'countries listed in alphabetial order'
        CountryNames(62) = "Gabon"
        CountryNames(63) = "Gambia"
        CountryNames(64) = "Georgia"
        CountryNames(65) = "Germany"
        CountryNames(66) = "Ghana"
        CountryNames(67) = "Greece"
        CountryNames(68) = "Grenada"
        CountryNames(69) = "Guatemala"
        CountryNames(70) = "Guinea"
        CountryNames(71) = "Guinea-Bissau"
        CountryNames(72) = "Guyana"

        'countries listed in alphabetial order'
        CountryNames(73) = "Haiti"
        CountryNames(74) = "Honduras"
        CountryNames(75) = "Hungary"

        'countries listed in alphabetial order'
        CountryNames(76) = "Iceland"
        CountryNames(77) = "India"
        CountryNames(78) = "Indonesia"
        CountryNames(79) = "Iran"
        CountryNames(80) = "Iraq"
        CountryNames(81) = "Ireland"
        CountryNames(82) = "Israel"
        CountryNames(83) = "Italy"

        'countries listed in alphabetial order'
        CountryNames(84) = "Jamaica"
        CountryNames(85) = "Japan"
        CountryNames(86) = "Jordan"

        'countries listed in alphabetial order'
        CountryNames(87) = "Kazakhstan"
        CountryNames(88) = "Kenya"
        CountryNames(89) = "Kiribati"
        CountryNames(90) = "North Korea"
        CountryNames(91) = "South Korea"
        CountryNames(92) = "Kuwait"
        CountryNames(93) = "Kyrgyzstan"

        'countries listed in alphabetial order'
        CountryNames(94) = "Laos"
        CountryNames(95) = "Latvia"
        CountryNames(96) = "Lebanon"
        CountryNames(97) = "Lesotho"
        CountryNames(98) = "Liberia"
        CountryNames(99) = "Libya"
        CountryNames(100) = "Liechtenstein"
        CountryNames(101) = "Lithuania"
        CountryNames(102) = "Luxembourg"

        'countries listed in alphabetial order'
        CountryNames(103) = "Macedonia"
        CountryNames(104) = "Madagascar"
        CountryNames(105) = "Malawi"
        CountryNames(106) = "Malaysia"
        CountryNames(107) = "Maldives"
        CountryNames(108) = "Mali"
        CountryNames(109) = "Malta"
        CountryNames(110) = "Marshall Islands"
        CountryNames(111) = "Mauritania"
        CountryNames(112) = "Mauritius"
        CountryNames(113) = "Mexico"
        CountryNames(114) = "Micronesia"
        CountryNames(115) = "Moldova"
        CountryNames(116) = "Monaco"
        CountryNames(117) = "Mongolia"
        CountryNames(118) = "Montenegro"
        CountryNames(119) = "Morocco"
        CountryNames(120) = "Mozambique"


        'countries listed in alphabetial order'
        CountryNames(122) = "Namibia"
        CountryNames(123) = "Nauru"
        CountryNames(124) = "Nepal"
        CountryNames(125) = "Netherlands"
        CountryNames(126) = "New Zealand"
        CountryNames(127) = "Nicaragua"
        CountryNames(128) = "Nigeria"
        CountryNames(129) = "Northern Ireland"
        CountryNames(130) = "Norway"

        'countries listed in alphabetial order'
        CountryNames(131) = "Oman"

        'countries listed in alphabetial order'
        CountryNames(132) = "Pakistan"
        CountryNames(133) = "Palau"
        CountryNames(134) = "Palestinian State (proposed)"
        CountryNames(135) = "Panama"
        CountryNames(136) = "Papua New Guinea"
        CountryNames(137) = "Paraguay"
        CountryNames(138) = "Peru"
        CountryNames(139) = "Philippines"
        CountryNames(140) = "Poland"
        CountryNames(141) = "Portugal"

        'countries listed in alphabetial order'
        CountryNames(142) = "Qatar"

        'countries listed in alphabetial order'
        CountryNames(143) = "Romania"
        CountryNames(144) = "Russia"
        CountryNames(145) = "Rwanda"

        'countries listed in alphabetial order'
        CountryNames(146) = "Samoa"
        CountryNames(147) = "San Marino"
        CountryNames(148) = "São Tomé and Príncipe"
        CountryNames(149) = "Saudi Arabia"
        CountryNames(150) = "Senegal"
        CountryNames(151) = "Serbia"
        CountryNames(152) = "Seychelles"
        CountryNames(153) = "Sierra Leone"
        CountryNames(154) = "Singapore"
        CountryNames(155) = "Slovakia"
        CountryNames(156) = "Slovenia"
        CountryNames(157) = "Solomon Islands"
        CountryNames(158) = "Somalia"
        CountryNames(159) = "South Africa"
        CountryNames(160) = "Spain"
        CountryNames(161) = "Sri Lanka"
        CountryNames(162) = "St. Kitts and Nevis"
        CountryNames(163) = "St. Lucia"
        CountryNames(164) = "St. Vincent and the Grenadines"
        CountryNames(165) = "Sudan"
        CountryNames(166) = "Suriname"
        CountryNames(167) = "Swaziland"
        CountryNames(168) = "Sweden"
        CountryNames(169) = "Switzerland"
        CountryNames(170) = "Syria"

        'countries listed in alphabetial order'
        CountryNames(171) = "Taiwan"
        CountryNames(172) = "Tajikistan"
        CountryNames(173) = "Tanzania"
        CountryNames(174) = "Thailand"
        CountryNames(175) = "Togo"
        CountryNames(176) = "Tonga"
        CountryNames(177) = "Trinidad and Tobago"
        CountryNames(178) = "Tunisia"
        CountryNames(179) = "Turkey"
        CountryNames(180) = "Turkmenistan"
        CountryNames(181) = "Tuvalu"

        'countries listed in alphabetial order'
        CountryNames(182) = "Uganda"
        CountryNames(183) = "Ukraine"
        CountryNames(184) = "United Arab Emirates"
        CountryNames(185) = "United Kingdom"
        CountryNames(186) = "United States"
        CountryNames(187) = "Uruguay"
        CountryNames(188) = "Uzbekistan"

        'countries listed in alphabetial order'
        CountryNames(189) = "Vanuatu"
        CountryNames(190) = "Vatican City"
        CountryNames(191) = "Venezuela"
        CountryNames(192) = "Vietnam"

        'countries listed in alphabetial order'
        CountryNames(193) = "Western Sahara"

        'countries listed in alphabetial order'
        CountryNames(194) = "Yemen"

        'countries listed in alphabetial order'
        CountryNames(195) = "Zambia"
        CountryNames(196) = "Zimbabwe"



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



