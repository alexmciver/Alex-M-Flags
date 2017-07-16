Partial Class Default2
    Inherits System.Web.UI.Page

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load

        Dim Flagimageurl(10) As String ' creating the flag image url array'
        Flagimageurl(0) = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Flag_of_Afghanistan.svg" 'Afghanistan'
        Flagimageurl(1) = "https://upload.wikimedia.org/wikipedia/commons/3/36/Flag_of_Albania.svg" 'Albania'
        Flagimageurl(2) = "https://upload.wikimedia.org/wikipedia/commons/7/77/Flag_of_Algeria.svg" 'Algeria'
        Flagimageurl(3) = "https://upload.wikimedia.org/wikipedia/commons/1/19/Flag_of_Andorra.svg" 'Andorra'
        Flagimageurl(4) = "https://upload.wikimedia.org/wikipedia/commons/9/9d/Flag_of_Angola.svg" 'Angola'
        Flagimageurl(5) = "https://upload.wikimedia.org/wikipedia/commons/8/89/Flag_of_Antigua_and_Barbuda.svg" 'Antigua and Barbuda'
        Flagimageurl(6) = "https://upload.wikimedia.org/wikipedia/commons/1/1a/Flag_of_Argentina.svg" 'Argentina'
        Flagimageurl(7) = "https://upload.wikimedia.org/wikipedia/commons/2/2f/Flag_of_Armenia.svg" 'Armenia'
        Flagimageurl(8) = "https://upload.wikimedia.org/wikipedia/commons/8/88/Flag_of_Australia_%28converted%29.svg" 'Australia'
        Flagimageurl(9) = "https://upload.wikimedia.org/wikipedia/commons/4/41/Flag_of_Austria.svg" 'Austria'
        Flagimageurl(10) = "https://upload.wikimedia.org/wikipedia/commons/d/dd/Flag_of_Azerbaijan.svg" 'Azerbaijan'

        Flagimageurl(11) = "https://upload.wikimedia.org/wikipedia/commons/9/93/Flag_of_the_Bahamas.svg" 'Bahamas'
        Flagimageurl(12) = "https://upload.wikimedia.org/wikipedia/commons/2/2c/Flag_of_Bahrain.svg" 'Bahrain'
        Flagimageurl(13) = "https://upload.wikimedia.org/wikipedia/commons/f/f9/Flag_of_Bangladesh.svg" 'Bangladesh'
        Flagimageurl(14) = "https://upload.wikimedia.org/wikipedia/commons/e/ef/Flag_of_Barbados.svg" 'Barbados'
        Flagimageurl(15) = "https://upload.wikimedia.org/wikipedia/commons/8/85/Flag_of_Belarus.svg" 'Belarus'
        Flagimageurl(16) = "https://upload.wikimedia.org/wikipedia/commons/6/65/Flag_of_Belgium.svg" 'Belgium'
        Flagimageurl(17) = "https://upload.wikimedia.org/wikipedia/commons/e/e7/Flag_of_Belize.svg" 'Belize'
        Flagimageurl(18) = "https://upload.wikimedia.org/wikipedia/commons/0/0a/Flag_of_Benin.svg" 'Benin'
        Flagimageurl(19) = "https://upload.wikimedia.org/wikipedia/commons/9/91/Flag_of_Bhutan.svg" 'Bhutan'
        Flagimageurl(20) = "https://upload.wikimedia.org/wikipedia/commons/d/de/Flag_of_Bolivia_%28state%29.svg" 'Bolivia'
        Flagimageurl(21) = "https://upload.wikimedia.org/wikipedia/commons/b/bf/Flag_of_Bosnia_and_Herzegovina.svg" 'Bosnia and Herzegovina'
        Flagimageurl(22) = "https://upload.wikimedia.org/wikipedia/commons/f/fa/Flag_of_Botswana.svg" 'Botswana'
        Flagimageurl(23) = "https://upload.wikimedia.org/wikipedia/en/0/05/Flag_of_Brazil.svg" 'Brazil'
        Flagimageurl(24) = "https://upload.wikimedia.org/wikipedia/commons/9/9c/Flag_of_Brunei.svg" 'Brunei'
        Flagimageurl(25) = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Flag_of_Bulgaria.svg" 'Bulgaria'
        Flagimageurl(26) = "https://upload.wikimedia.org/wikipedia/commons/3/31/Flag_of_Burkina_Faso.svg" 'Burkina Faso'
        Flagimageurl(27) = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Flag_of_Myanmar.svg" 'Myanmar (Burma)'
        Flagimageurl(28) = "https://upload.wikimedia.org/wikipedia/commons/5/50/Flag_of_Burundi.svg" 'Burundi'

        Flagimageurl(29) = "https://upload.wikimedia.org/wikipedia/commons/8/83/Flag_of_Cambodia.svg" 'Cambodia'
        Flagimageurl(30) = "https://upload.wikimedia.org/wikipedia/commons/4/4f/Flag_of_Cameroon.svg" 'Cameroon'
        Flagimageurl(31) = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Flag_of_Canada.svg" 'Canada'
        Flagimageurl(32) = "https://upload.wikimedia.org/wikipedia/commons/3/38/Flag_of_Cape_Verde.svg" 'Cape Verde'
        Flagimageurl(33) = "https://upload.wikimedia.org/wikipedia/commons/6/6f/Flag_of_the_Central_African_Republic.svg" 'Central African Republic'
        Flagimageurl(34) = "https://upload.wikimedia.org/wikipedia/commons/4/4b/Flag_of_Chad.svg" 'Chad'
        Flagimageurl(35) = "https://upload.wikimedia.org/wikipedia/commons/7/78/Flag_of_Chile.svg" 'Chile'
        Flagimageurl(36) = "https://upload.wikimedia.org/wikipedia/commons/2/21/Flag_of_Colombia.svg" 'Colombia'
        Flagimageurl(38) = "https://upload.wikimedia.org/wikipedia/commons/9/94/Flag_of_the_Comoros.svg" 'Comoros'
        Flagimageurl(39) = "https://upload.wikimedia.org/wikipedia/commons/6/6f/Flag_of_the_Democratic_Republic_of_the_Congo.svg" 'The democratic republic of Congo'
        Flagimageurl(40) = "https://upload.wikimedia.org/wikipedia/commons/9/92/Flag_of_the_Republic_of_the_Congo.svg" 'Republic of the Congo'
        Flagimageurl(41) = "https://upload.wikimedia.org/wikipedia/commons/b/bc/Flag_of_Costa_Rica_%28state%29.svg" 'Costa Rica'
        Flagimageurl(42) = "https://upload.wikimedia.org/wikipedia/commons/f/fe/Flag_of_C%C3%B4te_d%27Ivoire.svg" 'Côte d'Ivoire'
        Flagimageurl(43) = "https://upload.wikimedia.org/wikipedia/commons/1/1b/Flag_of_Croatia.svg" 'Croatia'
        Flagimageurl(44) = "https://upload.wikimedia.org/wikipedia/commons/b/bd/Flag_of_Cuba.svg" 'Cuba'
        Flagimageurl(45) = "https://upload.wikimedia.org/wikipedia/commons/d/d4/Flag_of_Cyprus.svg" 'Cyprus'
        Flagimageurl(46) = "https://upload.wikimedia.org/wikipedia/commons/c/cb/Flag_of_the_Czech_Republic.svg" 'Czech Republic"

        Flagimageurl(47) = "https://upload.wikimedia.org/wikipedia/commons/9/9c/Flag_of_Denmark.svg" 'Denmark'
        Flagimageurl(48) = "https://upload.wikimedia.org/wikipedia/commons/3/34/Flag_of_Djibouti.svg" 'Djibouti'
        Flagimageurl(49) = "https://upload.wikimedia.org/wikipedia/commons/c/c4/Flag_of_Dominica.svg" 'Dominica'
        Flagimageurl(50) = "https://upload.wikimedia.org/wikipedia/commons/9/9f/Flag_of_the_Dominican_Republic.svg" 'Dominican Republic'

        Flagimageurl(51) = "https://upload.wikimedia.org/wikipedia/commons/2/26/Flag_of_East_Timor.svg" 'East Timor'
        Flagimageurl(52) = "https://upload.wikimedia.org/wikipedia/commons/e/e8/Flag_of_Ecuador.svg" 'Ecuador'
        Flagimageurl(53) = "https://upload.wikimedia.org/wikipedia/commons/f/fe/Flag_of_Egypt.svg" 'Egypt'
        Flagimageurl(54) = "https://upload.wikimedia.org/wikipedia/commons/3/34/Flag_of_El_Salvador.svg" 'El Salvador'
        Flagimageurl(55) = "https://upload.wikimedia.org/wikipedia/commons/3/31/Flag_of_Equatorial_Guinea.svg" 'Equatorial Guinea'
        Flagimageurl(56) = "https://upload.wikimedia.org/wikipedia/commons/2/29/Flag_of_Eritrea.svg" 'Eritrea'
        Flagimageurl(57) = "https://upload.wikimedia.org/wikipedia/commons/8/8f/Flag_of_Estonia.svg" 'Estonia'
        Flagimageurl(58) = "https://upload.wikimedia.org/wikipedia/commons/7/71/Flag_of_Ethiopia.svg" 'Ethiopia'

        Flagimageurl(59) = "https://upload.wikimedia.org/wikipedia/commons/b/ba/Flag_of_Fiji.svg" 'Fiji'
        Flagimageurl(60) = "https://upload.wikimedia.org/wikipedia/commons/b/bc/Flag_of_Finland.svg" 'Finland'
        Flagimageurl(61) = "https://upload.wikimedia.org/wikipedia/en/c/c3/Flag_of_France.svg" 'France'

        Flagimageurl(62) = "https://upload.wikimedia.org/wikipedia/commons/0/04/Flag_of_Gabon.svg" 'Gabon'
        Flagimageurl(63) = "https://upload.wikimedia.org/wikipedia/commons/7/77/Flag_of_The_Gambia.svg" 'Gambia'
        Flagimageurl(64) = "https://upload.wikimedia.org/wikipedia/commons/0/0f/Flag_of_Georgia.svg" 'Georgia'
        Flagimageurl(65) = "https://upload.wikimedia.org/wikipedia/en/b/ba/Flag_of_Germany.svg" 'Germany'
        Flagimageurl(66) = "https://upload.wikimedia.org/wikipedia/commons/1/19/Flag_of_Ghana.svg" 'Ghana'
        Flagimageurl(67) = "https://upload.wikimedia.org/wikipedia/commons/5/5c/Flag_of_Greece.svg" 'Greece'
        Flagimageurl(68) = "https://upload.wikimedia.org/wikipedia/commons/b/bc/Flag_of_Grenada.svg" 'Grenada'
        Flagimageurl(69) = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Flag_of_Guatemala.svg" 'Guatemala'
        Flagimageurl(70) = "https://upload.wikimedia.org/wikipedia/commons/e/ed/Flag_of_Guinea.svg" 'Guinea'
        Flagimageurl(71) = "https://upload.wikimedia.org/wikipedia/commons/0/01/Flag_of_Guinea-Bissau.svg" 'Guinea-Bissau'
        Flagimageurl(72) = "https://upload.wikimedia.org/wikipedia/commons/9/99/Flag_of_Guyana.svg" 'Guyana'

        Flagimageurl(73) = "https://upload.wikimedia.org/wikipedia/commons/5/56/Flag_of_Haiti.svg" 'Haiti'
        Flagimageurl(74) = "https://upload.wikimedia.org/wikipedia/commons/8/82/Flag_of_Honduras.svg" 'Honduras'
        Flagimageurl(75) = "https://upload.wikimedia.org/wikipedia/commons/c/c1/Flag_of_Hungary.svg" 'Hungary'

        Flagimageurl(76) = "https://upload.wikimedia.org/wikipedia/commons/c/ce/Flag_of_Iceland.svg" 'Iceland'
        Flagimageurl(77) = "https://upload.wikimedia.org/wikipedia/en/4/41/Flag_of_India.svg" 'India'
        Flagimageurl(78) = "https://upload.wikimedia.org/wikipedia/commons/9/9f/Flag_of_Indonesia.svg" 'Indonesia'
        Flagimageurl(79) = "https://upload.wikimedia.org/wikipedia/commons/c/ca/Flag_of_Iran.svg" 'Iran'
        Flagimageurl(80) = "https://upload.wikimedia.org/wikipedia/commons/f/f6/Flag_of_Iraq.svg" 'Iraq'
        Flagimageurl(81) = "https://upload.wikimedia.org/wikipedia/commons/4/45/Flag_of_Ireland.svg" 'Ireland'
        Flagimageurl(82) = "https://upload.wikimedia.org/wikipedia/commons/d/d4/Flag_of_Israel.svg" 'Israel'
        Flagimageurl(83) = "https://upload.wikimedia.org/wikipedia/en/0/03/Flag_of_Italy.svg" 'Italy'

        Flagimageurl(84) = "https://upload.wikimedia.org/wikipedia/commons/0/0a/Flag_of_Jamaica.svg" 'Jamaica'
        Flagimageurl(85) = "https://upload.wikimedia.org/wikipedia/en/9/9e/Flag_of_Japan.svg" 'Japan'
        Flagimageurl(86) = "https://upload.wikimedia.org/wikipedia/commons/c/c0/Flag_of_Jordan.svg" 'Jordan'

        Flagimageurl(87) = "https://en.wikipedia.org/wiki/Kazakhstan#/media/File:Flag_of_Kazakhstan.svg" 'Kazakhstan'
        Flagimageurl(88) = "https://en.wikipedia.org/wiki/Kenya#/media/File:Flag_of_Kenya.svg" 'Kenya'
        Flagimageurl(89) = "https://en.wikipedia.org/wiki/Kiribati#/media/File:Flag_of_Kiribati.svg" 'Kiribati'
        Flagimageurl(90) = "https://en.wikipedia.org/wiki/North_Korea#/media/File:Flag_of_North_Korea.svg" 'North Korea'
        Flagimageurl(91) = "https://en.wikipedia.org/wiki/South_Korea#/media/File:Flag_of_South_Korea.svg" 'South Korea'
        Flagimageurl(92) = "https://en.wikipedia.org/wiki/Kuwait#/media/File:Flag_of_Kuwait.svg" 'Kuwait'
        Flagimageurl(93) = "https://en.wikipedia.org/wiki/Kyrgyzstan#/media/File:Flag_of_Kyrgyzstan.svg" 'Kyrgyzstan'

        Flagimageurl(94) = "https://en.wikipedia.org/wiki/Laos#/media/File:Flag_of_Laos.svg" 'Laos'
        Flagimageurl(95) = "https://en.wikipedia.org/wiki/Latvia#/media/File:Flag_of_Latvia.svg" 'Latvia'
        Flagimageurl(96) = "https://en.wikipedia.org/wiki/Lebanon#/media/File:Flag_of_Lebanon.svg" 'Lebanon'
        Flagimageurl(97) = "https://upload.wikimedia.org/wikipedia/commons/4/4a/Flag_of_Lesotho.svg" 'Lesotho'
        Flagimageurl(98) = "https://en.wikipedia.org/wiki/Liberia#/media/File:Flag_of_Liberia.svg" 'Liberia'
        Flagimageurl(99) = "https://en.wikipedia.org/wiki/Libya#/media/File:Flag_of_Libya.svg" 'Libya'
        Flagimageurl(100) = "https://en.wikipedia.org/wiki/Flag_of_Liechtenstein#/media/File:Flag_of_Liechtenstein.svg" 'Liechtenstein'
        Flagimageurl(101) = "https://en.wikipedia.org/wiki/Lithuania#/media/File:Flag_of_Lithuania.svg" 'Lithuania'
        Flagimageurl(102) = "https://en.wikipedia.org/wiki/Luxembourg#/media/File:Flag_of_Luxembourg.svg" 'Luxembourg'

        Flagimageurl(103) = "https://en.wikipedia.org/wiki/Republic_of_Macedonia#/media/File:Flag_of_Macedonia.svg" 'Macedonia'
        Flagimageurl(104) = "https://en.wikipedia.org/wiki/Madagascar#/media/File:Flag_of_Madagascar.svg" 'Madagascar'
        Flagimageurl(105) = "https://en.wikipedia.org/wiki/Malawi#/media/File:Flag_of_Malawi.svg" 'Malawi'
        Flagimageurl(106) = "https://en.wikipedia.org/wiki/Malaysia#/media/File:Flag_of_Malaysia.svg" 'Malaysia'
        Flagimageurl(107) = "https://en.wikipedia.org/wiki/Maldives#/media/File:Flag_of_Maldives.svg" 'Maldives'
        Flagimageurl(108) = "https://upload.wikimedia.org/wikipedia/commons/9/92/Flag_of_Mali.svg" 'Mali'
        Flagimageurl(109) = "https://upload.wikimedia.org/wikipedia/commons/7/73/Flag_of_Malta.svg" 'Malta'
        Flagimageurl(110) = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Flag_of_the_Marshall_Islands.svg" 'Marshall Islands'
        Flagimageurl(111) = "https://upload.wikimedia.org/wikipedia/commons/4/43/Flag_of_Mauritania.svg" 'Mauritania'
        Flagimageurl(112) = "https://upload.wikimedia.org/wikipedia/commons/7/77/Flag_of_Mauritius.svg" 'Mauritius'
        Flagimageurl(113) = "https://upload.wikimedia.org/wikipedia/commons/f/fc/Flag_of_Mexico.svg" 'Mexico'
        Flagimageurl(114) = "https://upload.wikimedia.org/wikipedia/commons/e/e4/Flag_of_the_Federated_States_of_Micronesia.svg" 'Micronesia'
        Flagimageurl(115) = "https://upload.wikimedia.org/wikipedia/commons/2/27/Flag_of_Moldova.svg" 'Moldova'
        Flagimageurl(116) = "https://upload.wikimedia.org/wikipedia/commons/e/ea/Flag_of_Monaco.svg" 'Monaco'
        Flagimageurl(117) = "https://upload.wikimedia.org/wikipedia/commons/4/4c/Flag_of_Mongolia.svg" 'Mongolia'
        Flagimageurl(118) = "https://upload.wikimedia.org/wikipedia/commons/6/64/Flag_of_Montenegro.svg" 'Montenegro'
        Flagimageurl(119) = "https://upload.wikimedia.org/wikipedia/commons/2/2c/Flag_of_Morocco.svg" 'Morocco'
        Flagimageurl(120) = "https://upload.wikimedia.org/wikipedia/commons/d/d0/Flag_of_Mozambique.svg" 'Mozambique'
        
        Flagimageurl(121) = "https://upload.wikimedia.org/wikipedia/commons/0/00/Flag_of_Namibia.svg" 'Namibia'




        Dim CountryNames(10) As String 'creating the country names array'
        CountryNames(0) = "Afghanistan"
        CountryNames(1) = "Albania"
        CountryNames(2) = "Algeria"
        CountryNames(3) = "Andorra"
        CountryNames(4) = "Angola"
        CountryNames(5) = "Antigua And Barbuda"
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
        CountryNames(21) = "Bosnia And Herzegovina"
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
        CountryNames(39) = "The Democratic Republic Of the Congo"
        CountryNames(40) = "Republic Of Congo"
        CountryNames(41) = "Costa Rica"
        CountryNames(42) = "Côte d'Ivoire"
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
        CountryNames(129) = "Norway"

        'countries listed in alphabetial order'
        CountryNames(130) = "Oman"

        'countries listed in alphabetial order'
        CountryNames(131) = "Pakistan"
        CountryNames(132) = "Palau"
        CountryNames(133) = "Palestinian State (proposed)"
        CountryNames(134) = "Panama"
        CountryNames(135) = "Papua New Guinea"
        CountryNames(136) = "Paraguay"
        CountryNames(137) = "Peru"
        CountryNames(138) = "Philippines"
        CountryNames(139) = "Poland"
        CountryNames(140) = "Portugal"

        'countries listed in alphabetial order'
        CountryNames(140) = "Qatar"

        'countries listed in alphabetial order'
        CountryNames(141) = "Romania"
        CountryNames(142) = "Russia"
        CountryNames(143) = "Rwanda"

        'countries listed in alphabetial order'
        CountryNames(144) = "Samoa"
        CountryNames(145) = "San Marino"
        CountryNames(146) = "São Tomé and Príncipe"
        CountryNames(147) = "Saudi Arabia"
        CountryNames(148) = "Senegal"
        CountryNames(149) = "Serbia"
        CountryNames(150) = "Seychelles"
        CountryNames(151) = "Sierra Leone"
        CountryNames(152) = "Singapore"
        CountryNames(153) = "Slovakia"
        CountryNames(154) = "Slovenia"
        CountryNames(155) = "Solomon Islands"
        CountryNames(156) = "Somalia"
        CountryNames(157) = "South Africa"
        CountryNames(158) = "Spain"
        CountryNames(159) = "Sri Lanka"
        CountryNames(160) = "St. Kitts and Nevis"
        CountryNames(161) = "St. Lucia"
        CountryNames(162) = "St. Vincent and the Grenadines"
        CountryNames(163) = "Sudan"
        CountryNames(164) = "Suriname"
        CountryNames(165) = "Swaziland"
        CountryNames(166) = "Sweden"
        CountryNames(167) = "Switzerland"
        CountryNames(168) = "Syria"

        'countries listed in alphabetial order'
        CountryNames(169) = "Taiwan"
        CountryNames(170) = "Tajikistan"
        CountryNames(171) = "Tanzania"
        CountryNames(172) = "Thailand"
        CountryNames(173) = "Togo"
        CountryNames(174) = "Tonga"
        CountryNames(175) = "Trinidad and Tobago"
        CountryNames(176) = "Tunisia"
        CountryNames(177) = "Turkey"
        CountryNames(178) = "Turkmenistan"
        CountryNames(179) = "Tuvalu"

        'countries listed in alphabetial order'
        CountryNames(180) = "Uganda"
        CountryNames(181) = "Ukraine"
        CountryNames(182) = "United Arab Emirates"
        CountryNames(183) = "United Kingdom"
        CountryNames(184) = "United States"
        CountryNames(185) = "Uruguay"
        CountryNames(186) = "Uzbekistan"

        'countries listed in alphabetial order'
        CountryNames(187) = "Vanuatu"
        CountryNames(188) = "Vatican City"
        CountryNames(189) = "Venezuela"
        CountryNames(190) = "Vietnam"

        'countries listed in alphabetial order'
        CountryNames(191) = "Western Sahara"

        'countries listed in alphabetial order'
        CountryNames(192) = "Yemen"

        'countries listed in alphabetial order'
        CountryNames(193) = "Zambia"
        CountryNames(194) = "Zimbabwe"



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



