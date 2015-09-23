// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BfaTeamRepositoryTests.cs" company="">
//   
// </copyright>
// <summary>
//   The bfa team repository tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UnitTests.Persistence.Repositories
{
    using System;
    using System.Linq;

    using Doggy.Persistence.Entities.Bfa;
    using Doggy.Persistence.Repositories;

    using GenericRepository.Fakes;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The bfa team repository tests.
    /// </summary>
    [TestClass]
    public class BfaTeamRepositoryTests
    {
        #region Page source

        /// <summary>
        /// The page source.
        /// </summary>
        private const string PageSource =
            @"<html><!-- InstanceBegin template=""/Templates/bfa_main.dwt"" codeOutsideHTMLIsLocked=""false"" -->
<head>
<!-- InstanceBeginEditable name=""doctitle"" -->
<title>British Flyball Association - Teams</title>
<!-- InstanceEndEditable -->
<meta http-equiv=""Content-Type"" content=""text/html; charset=iso-8859-1"">
<script language=""JavaScript"" src=""../scripts/bfa_main.js""></script>
<link href=""../bfacss.css"" rel=""stylesheet"" type=""text/css"">
<!-- InstanceBeginEditable name=""head"" -->
<meta name=""distribution"" content=""global"">
<meta name=""revisit-after"" content=""30 days"">
<meta name=""description"" content=""The British Flyball Association Database of Teams, their Fastest Times, Seed Times and Racing History."">
<meta name=""keywords"" content=""database, flyball, fly, ball, dog, dogs, canine, sports, athlete, pet, BFA, british, association, NAFA, north, american, beligian, federation, europe, european, france, germany, holland, netherlands, croatia, australia, training, activities, games, products, points, awards, results, seedings, news, letters, world, rankings, forms, rules"">
<meta name=""robots"" content=""index,follow"">
<meta name=""rating"" content=""safe for kids"">
<meta name=""Author"" content=""DBTD Services Limited (admin@dbtd.net)"">

<!-- InstanceEndEditable -->
<script language=""JavaScript"" src=""mm_menu.js""></script>
</head>

<body onLoad=""MM_preloadImages('../arrows.gif')"">

<div class=""BFAmainContainer"">

<div class=""BFAheaderContainer1""><img src=""../images/headings/heading_01.jpg"" width=""760"" height=""200""></div>
<div class=""BFAheaderContainer2""><script language=""JavaScript"">mmLoadMenus();</script>
<img src=""../images/headings/heading_01_r3_c1.jpg"" name=""image1"" width=""760"" height=""35"" border=""0"" usemap=""#m_heading_01_r3_c1"" id=""image1"">
<map name=""m_heading_01_r3_c1"">
<area shape=""poly"" coords=""674,2,745,2,745,30,674,30,674,2"" href=""#"" alt="""" onMouseOut=""MM_startTimeout();""  onMouseOver=""MM_showMenu(window.mm_menu_0010231925_0,742,27,null,'image1')""  >
<area shape=""poly"" coords=""595,1,661,1,661,30,595,30,595,1"" href=""#"" alt="""" onMouseOut=""MM_startTimeout();""  onMouseOver=""MM_showMenu(window.mm_menu_0010231848_1,658,27,null,'image1')""  >
<area shape=""poly"" coords=""538,2,585,2,585,30,538,30,538,2"" href=""#"" alt="""" onMouseOut=""MM_startTimeout();""  onMouseOver=""MM_showMenu(window.mm_menu_0010231829_2,582,27,null,'image1')""  >
<area shape=""poly"" coords=""483,1,526,1,526,29,483,29,483,1"" href=""#"" alt="""" onMouseOut=""MM_startTimeout();""  onMouseOver=""MM_showMenu(window.mm_menu_0010231807_3,523,26,null,'image1')""  >
<area shape=""poly"" coords=""416,1,471,1,471,29,416,29,416,1"" href=""#"" alt="""" onMouseOut=""MM_startTimeout();""  onMouseOver=""MM_showMenu(window.mm_menu_0010231724_4,468,26,null,'image1')""  >
</map>

</div>
<div class=""BFApageContainer"">
<!-- InstanceBeginEditable name=""main_text"" -->
		  
          
          		
            <p class=largeheadingcent>Bristol Ball-istics</p><p class=gentextcent>
			<table width=585 border=0 align=center cellpadding=3>
            <tr><td colspan=2 class=tableHeader>Details for BFA Registered Team No - 018</td></tr>
			<tr><td width=287 class=tableData>Team Captain - <b>Louise Perkins</td><td width=286 class=tableData>Current Seed Time - <b>16.64</b></td></tr><tr><td colspan=2 class=tableData>Fastest Ever Recorded Time - <b>16.49</b></td></tr></table><p align=center class=gentextcent><font size=3><strong>Dogs having raced with this team since 1st January 2015
			</strong></font></span><br>(Click on a Dogs Name for individual history)</p>
			<table align=center border=0 cellpadding=3>
			<tr><td width=50 class=tableHeader>No</td>
			<td width=70 class=tableHeader>BFA No</td>
			<td width=150 class=tableHeader>Dogs Name</td>
			<td width=150 class=tableHeader>Breed</td></tr><tr><td class=tableData>1</td>
			<td class=tableData>0157C</td>
			<td class=tableData><a href=""points.php?dbfa=0157C"">Jamie</a></td>
			<td class=tableData>Cross-Breed</td></tr><tr><td class=tableData>2</td>
			<td class=tableData>0734B</td>
			<td class=tableData><a href=""points.php?dbfa=0734B"">Asher</a></td>
			<td class=tableData>Border Collie/WSD</td></tr><tr><td class=tableData>3</td>
			<td class=tableData>0734C </td>
			<td class=tableData><a href=""points.php?dbfa=0734C "">Laika </a></td>
			<td class=tableData>Border Collie/WSD</td></tr><tr><td class=tableData>4</td>
			<td class=tableData>2908B</td>
			<td class=tableData><a href=""points.php?dbfa=2908B"">Luna</a></td>
			<td class=tableData>Border Collie/WSD</td></tr><tr><td class=tableData>5</td>
			<td class=tableData>3492A</td>
			<td class=tableData><a href=""points.php?dbfa=3492A"">Dug</a></td>
			<td class=tableData>Border Collie/WSD</td></tr><tr><td class=tableData>6</td>
			<td class=tableData>3985A </td>
			<td class=tableData><a href=""points.php?dbfa=3985A "">Shani </a></td>
			<td class=tableData>Border Collie/WSD</td></tr><tr><td class=tableData>7</td>
			<td class=tableData>4014B </td>
			<td class=tableData><a href=""points.php?dbfa=4014B "">Loki </a></td>
			<td class=tableData>Border Collie/WSD</td></tr><tr><td class=tableData>8</td>
			<td class=tableData>6650A</td>
			<td class=tableData><a href=""points.php?dbfa=6650A"">Storm</a></td>
			<td class=tableData>Staffordshire Bull Terrier</td></tr><tr><td class=tableData>9</td>
			<td class=tableData>8266A</td>
			<td class=tableData><a href=""points.php?dbfa=8266A"">Sasha</a></td>
			<td class=tableData>Border Collie/WSD</td></tr></table><p class=gentextcent><font size=3><strong>Racing (Fastest Times) History</strong></font></p></p><table align=center border=0 cellpadding=3>
<tr><td width=170 class=tableHeader>Date</td>
			<td width=250 class=tableHeader>Venue</td>
			<td width=150 class=tableHeader>Fastest Time</td></tr>
<tr><td class=tableData>6th September 2015</td>
			<td class=tableData>Padworth</td>
			<td class=tableData>17.12</td></tr><tr><td class=tableData>23rd August 2015</td>
			<td class=tableData>BFA Championships Catton Hall</td>
			<td class=tableData>16.64</td></tr><tr><td class=tableData>9th August 2015</td>
			<td class=tableData>Wokingham</td>
			<td class=tableData>17.73</td></tr><tr><td class=tableData>19th July 2015</td>
			<td class=tableData>Muswell Leys Farm</td>
			<td class=tableData>17.06</td></tr><tr><td class=tableData>11th July 2015</td>
			<td class=tableData>Mapledurham</td>
			<td class=tableData>16.84</td></tr><tr><td class=tableData>21st June 2015</td>
			<td class=tableData>Frome</td>
			<td class=tableData>16.93</td></tr><tr><td class=tableData>6th June 2015</td>
			<td class=tableData>Great Somerford</td>
			<td class=tableData>17.06</td></tr><tr><td class=tableData>24th May 2015</td>
			<td class=tableData>Padworth</td>
			<td class=tableData>16.50</td></tr><tr><td class=tableData>10th May 2015</td>
			<td class=tableData>Ryton</td>
			<td class=tableData>16.83</td></tr><tr><td class=tableData>19th April 2015</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.54</td></tr><tr><td class=tableData>12th April 2015</td>
			<td class=tableData>Newbury Showground</td>
			<td class=tableData>16.79</td></tr><tr><td class=tableData>3rd April 2015</td>
			<td class=tableData>Brookfield</td>
			<td class=tableData>16.98</td></tr><tr><td class=tableData>31st January 2015</td>
			<td class=tableData>Ryton</td>
			<td class=tableData>17.12</td></tr><tr><td class=tableData>14th September 2014</td>
			<td class=tableData>Port of Bristol</td>
			<td class=tableData>16.59</td></tr><tr><td class=tableData>24th August 2014</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.56</td></tr><tr><td class=tableData>17th August 2014</td>
			<td class=tableData>BFA Championships</td>
			<td class=tableData>16.63</td></tr><tr><td class=tableData>9th August 2014</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>17.86</td></tr><tr><td class=tableData>13th July 2014</td>
			<td class=tableData>Mapledurham</td>
			<td class=tableData>16.71</td></tr><tr><td class=tableData>22nd June 2014</td>
			<td class=tableData>Imber Court</td>
			<td class=tableData>17.40</td></tr><tr><td class=tableData>8th June 2014</td>
			<td class=tableData>Frome</td>
			<td class=tableData>16.89</td></tr><tr><td class=tableData>25th May 2014</td>
			<td class=tableData>Englefield</td>
			<td class=tableData>17.55</td></tr><tr><td class=tableData>11th May 2014</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.05</td></tr><tr><td class=tableData>4th May 2014</td>
			<td class=tableData>Evesham</td>
			<td class=tableData>17.16</td></tr><tr><td class=tableData>18th April 2014</td>
			<td class=tableData>Brookfield</td>
			<td class=tableData>17.23</td></tr><tr><td class=tableData>13th April 2014</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.28</td></tr><tr><td class=tableData>15th September 2013</td>
			<td class=tableData>Hatton</td>
			<td class=tableData>17.29</td></tr><tr><td class=tableData>1st September 2013</td>
			<td class=tableData>Padworth</td>
			<td class=tableData>17.57</td></tr><tr><td class=tableData>14th July 2013</td>
			<td class=tableData>Mapledurham</td>
			<td class=tableData>17.00</td></tr><tr><td class=tableData>6th July 2013</td>
			<td class=tableData>Barbury Castle</td>
			<td class=tableData>18.88</td></tr><tr><td class=tableData>16th June 2013</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.21</td></tr><tr><td class=tableData>2nd June 2013</td>
			<td class=tableData>Frome</td>
			<td class=tableData>17.11</td></tr><tr><td class=tableData>26th May 2013</td>
			<td class=tableData>Mapledurham</td>
			<td class=tableData>17.19</td></tr><tr><td class=tableData>19th May 2013</td>
			<td class=tableData>Padworth</td>
			<td class=tableData>17.14</td></tr><tr><td class=tableData>4th May 2013</td>
			<td class=tableData>Hedsor Golf Course</td>
			<td class=tableData>17.17</td></tr><tr><td class=tableData>31st March 2013</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>17.54</td></tr><tr><td class=tableData>23rd September 2012</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.37</td></tr><tr><td class=tableData>1st September 2012</td>
			<td class=tableData>Padworth</td>
			<td class=tableData>17.45</td></tr><tr><td class=tableData>19th August 2012</td>
			<td class=tableData>BFA Championships</td>
			<td class=tableData>16.83</td></tr><tr><td class=tableData>12th August 2012</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>17.50</td></tr><tr><td class=tableData>21st July 2012</td>
			<td class=tableData>Chalfont Heights</td>
			<td class=tableData>16.59</td></tr><tr><td class=tableData>15th July 2012</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>16.71</td></tr><tr><td class=tableData>17th June 2012</td>
			<td class=tableData>Basingstoke</td>
			<td class=tableData>16.99</td></tr><tr><td class=tableData>20th May 2012</td>
			<td class=tableData>Frome</td>
			<td class=tableData>17.45</td></tr><tr><td class=tableData>13th May 2012</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.61</td></tr><tr><td class=tableData>22nd April 2012</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.23</td></tr><tr><td class=tableData>7th April 2012</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>17.40</td></tr><tr><td class=tableData>2nd October 2011</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.31</td></tr><tr><td class=tableData>18th September 2011</td>
			<td class=tableData>Hatton</td>
			<td class=tableData>16.93</td></tr><tr><td class=tableData>4th September 2011</td>
			<td class=tableData>Becketts Farm</td>
			<td class=tableData>16.97</td></tr><tr><td class=tableData>28th August 2011</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>16.80</td></tr><tr><td class=tableData>21st August 2011</td>
			<td class=tableData>BFA Championships</td>
			<td class=tableData>16.49</td></tr><tr><td class=tableData>13th August 2011</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>16.71</td></tr><tr><td class=tableData>6th August 2011</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>16.66</td></tr><tr><td class=tableData>17th July 2011</td>
			<td class=tableData>Kilnsea, Reading</td>
			<td class=tableData>16.70</td></tr><tr><td class=tableData>10th July 2011</td>
			<td class=tableData>Barbury Castle</td>
			<td class=tableData>16.63</td></tr><tr><td class=tableData>26th June 2011</td>
			<td class=tableData>Farnham Park</td>
			<td class=tableData>16.94</td></tr><tr><td class=tableData>19th June 2011</td>
			<td class=tableData>Basingstoke</td>
			<td class=tableData>16.85</td></tr><tr><td class=tableData>12th June 2011</td>
			<td class=tableData>Padworth</td>
			<td class=tableData>17.16</td></tr><tr><td class=tableData>29th May 2011</td>
			<td class=tableData>Becketts Farm</td>
			<td class=tableData>16.85</td></tr><tr><td class=tableData>22nd May 2011</td>
			<td class=tableData>Farnham Park</td>
			<td class=tableData>16.96</td></tr><tr><td class=tableData>15th May 2011</td>
			<td class=tableData>Anstey Park</td>
			<td class=tableData>17.17</td></tr><tr><td class=tableData>1st May 2011</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.14</td></tr><tr><td class=tableData>24th April 2011</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>17.13</td></tr><tr><td class=tableData>17th April 2011</td>
			<td class=tableData>Acremead</td>
			<td class=tableData>17.17</td></tr><tr><td class=tableData>26th September 2010</td>
			<td class=tableData>Beckett's Farm</td>
			<td class=tableData>17.05</td></tr><tr><td class=tableData>19th September 2010</td>
			<td class=tableData>Acremead Kennels</td>
			<td class=tableData>17.43</td></tr><tr><td class=tableData>5th September 2010</td>
			<td class=tableData>Shackerstone</td>
			<td class=tableData>17.52</td></tr><tr><td class=tableData>15th August 2010</td>
			<td class=tableData>British Championships</td>
			<td class=tableData>17.18</td></tr><tr><td class=tableData>8th August 2010</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>17.43</td></tr><tr><td class=tableData>31st July 2010</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>17.63</td></tr><tr><td class=tableData>18th July 2010</td>
			<td class=tableData>Chilterns Show</td>
			<td class=tableData>17.42</td></tr><tr><td class=tableData>11th July 2010</td>
			<td class=tableData>Frimley Lodge Park</td>
			<td class=tableData>17.38</td></tr><tr><td class=tableData>20th June 2010</td>
			<td class=tableData>Hearing Dogs Centre</td>
			<td class=tableData>18.12</td></tr><tr><td class=tableData>6th June 2010</td>
			<td class=tableData>Hearing Dogs Centre</td>
			<td class=tableData>18.22</td></tr><tr><td class=tableData>30th May 2010</td>
			<td class=tableData>Frimley Lodge Park</td>
			<td class=tableData>18.30</td></tr><tr><td class=tableData>22nd May 2010</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>18.30</td></tr><tr><td class=tableData>2nd May 2010</td>
			<td class=tableData>Acremead Kennels</td>
			<td class=tableData>18.28</td></tr><tr><td class=tableData>18th April 2010</td>
			<td class=tableData>Acremead Kennels</td>
			<td class=tableData>18.58</td></tr><tr><td class=tableData>4th October 2009</td>
			<td class=tableData>Beckett's Farm</td>
			<td class=tableData>17.57</td></tr><tr><td class=tableData>19th September 2009</td>
			<td class=tableData>Acremead Kennels</td>
			<td class=tableData>17.77</td></tr><tr><td class=tableData>6th September 2009</td>
			<td class=tableData>Shackerstone</td>
			<td class=tableData>17.64</td></tr><tr><td class=tableData>30th August 2009</td>
			<td class=tableData>Stoneleigh Park</td>
			<td class=tableData>18.11</td></tr><tr><td class=tableData>16th August 2009</td>
			<td class=tableData>British Championships</td>
			<td class=tableData>17.65</td></tr><tr><td class=tableData>2nd August 2009</td>
			<td class=tableData>Fair View Farm</td>
			<td class=tableData>17.37</td></tr><tr><td class=tableData>18th July 2009</td>
			<td class=tableData>Chilterns Show</td>
			<td class=tableData>17.71</td></tr><tr><td class=tableData>12th July 2009</td>
			<td class=tableData>Beckett's Farm</td>
			<td class=tableData>17.72</td></tr><tr><td class=tableData>5th July 2009</td>
			<td class=tableData>Millets Farm</td>
			<td class=tableData>18.86</td></tr><tr><td class=tableData>27th June 2009</td>
			<td class=tableData>Frimley Lodge Park</td>
			<td class=tableData>17.84</td></tr><tr><td class=tableData>20th June 2009</td>
			<td class=tableData>Middlesex Show</td>
			<td class=tableData>19.43</td></tr><tr><td class=tableData>7th June 2009</td>
			<td class=tableData>Cornbury Park</td>
			<td class=tableData>18.14</td></tr><tr><td class=tableData>25th May 2009</td>
			<td class=tableData>Acremead Kennels</td>
			<td class=tableData>18.80</td></tr><tr><td class=tableData>17th May 2009</td>
			<td class=tableData>Arbury Hall</td>
			<td class=tableData>18.46</td></tr><tr><td class=tableData>3rd May 2009</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>18.78</td></tr><tr><td class=tableData>12th April 2009</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>18.00</td></tr><tr><td class=tableData>5th October 2008</td>
			<td class=tableData>Brinkworth</td>
			<td class=tableData>18.21</td></tr><tr><td class=tableData>21st September 2008</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>18.40</td></tr><tr><td class=tableData>6th September 2008</td>
			<td class=tableData>Imber Court</td>
			<td class=tableData>17.80</td></tr><tr><td class=tableData>25th August 2008</td>
			<td class=tableData>Sellindge</td>
			<td class=tableData>18.52</td></tr><tr><td class=tableData>19th July 2008</td>
			<td class=tableData>Chilterns Show</td>
			<td class=tableData>18.21</td></tr><tr><td class=tableData>6th July 2008</td>
			<td class=tableData>Frimley Lodge Park</td>
			<td class=tableData>18.07</td></tr><tr><td class=tableData>29th June 2008</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>18.19</td></tr><tr><td class=tableData>22nd June 2008</td>
			<td class=tableData>Middlesex Town & Country Show</td>
			<td class=tableData>18.61</td></tr><tr><td class=tableData>7th June 2008</td>
			<td class=tableData>Hearing Dogs</td>
			<td class=tableData>18.90</td></tr><tr><td class=tableData>26th May 2008</td>
			<td class=tableData>Frimley Lodge Park</td>
			<td class=tableData>19.22</td></tr><tr><td class=tableData>3rd May 2008</td>
			<td class=tableData>Fairview Farm</td>
			<td class=tableData>18.87</td></tr><tr><td class=tableData>20th April 2008</td>
			<td class=tableData>Portway</td>
			<td class=tableData>18.91</td></tr><tr><td class=tableData>23rd March 2008</td>
			<td class=tableData>Maddoxford Farm</td>
			<td class=tableData>19.31</td></tr><tr><td class=tableData>17th February 2008</td>
			<td class=tableData>Newark Showground</td>
			<td class=tableData>19.83</td></tr><tr><td class=tableData>3rd February 2008</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>19.74</td></tr><tr><td class=tableData>25th November 2007</td>
			<td class=tableData>Newark Showground</td>
			<td class=tableData>20.07</td></tr><tr><td class=tableData>2nd September 2007</td>
			<td class=tableData>Brinkworth</td>
			<td class=tableData>19.29</td></tr><tr><td class=tableData>19th August 2007</td>
			<td class=tableData>Summer Championships</td>
			<td class=tableData>19.52</td></tr><tr><td class=tableData>17th June 2007</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>19.39</td></tr><tr><td class=tableData>27th May 2007</td>
			<td class=tableData>European Championships</td>
			<td class=tableData>19.16</td></tr><tr><td class=tableData>5th May 2007</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>18.98</td></tr><tr><td class=tableData>9th April 2007</td>
			<td class=tableData>Portway</td>
			<td class=tableData>19.09</td></tr><tr><td class=tableData>11th February 2007</td>
			<td class=tableData>Newark Showground</td>
			<td class=tableData>19.35</td></tr><tr><td class=tableData>3rd February 2007</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>18.91</td></tr><tr><td class=tableData>26th November 2006</td>
			<td class=tableData>Newark Showground</td>
			<td class=tableData>19.02</td></tr><tr><td class=tableData>8th October 2006</td>
			<td class=tableData>Portway</td>
			<td class=tableData>18.80</td></tr><tr><td class=tableData>19th August 2006</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>19.39</td></tr><tr><td class=tableData>13th August 2006</td>
			<td class=tableData>Whitewater</td>
			<td class=tableData>19.49</td></tr><tr><td class=tableData>29th July 2006</td>
			<td class=tableData>Tai Lawr, Anglesey</td>
			<td class=tableData>20.06</td></tr><tr><td class=tableData>27th July 2006</td>
			<td class=tableData>Tai Lawr, Anglesey</td>
			<td class=tableData>19.46</td></tr><tr><td class=tableData>23rd July 2006</td>
			<td class=tableData>Tai Lawr, Anglesey</td>
			<td class=tableData>19.57</td></tr><tr><td class=tableData>8th July 2006</td>
			<td class=tableData>Saul</td>
			<td class=tableData>19.25</td></tr><tr><td class=tableData>1st July 2006</td>
			<td class=tableData>Moreton Morrell</td>
			<td class=tableData>20.10</td></tr><tr><td class=tableData>18th June 2006</td>
			<td class=tableData>Nuneaton Rugby Club</td>
			<td class=tableData>19.54</td></tr><tr><td class=tableData>11th June 2006</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>19.87</td></tr><tr><td class=tableData>4th June 2006</td>
			<td class=tableData>Frimley Lodge Park</td>
			<td class=tableData>21.10</td></tr><tr><td class=tableData>23rd April 2006</td>
			<td class=tableData>Portway</td>
			<td class=tableData>18.56</td></tr><tr><td class=tableData>17th April 2006</td>
			<td class=tableData>Old Warden Park, Biggleswade</td>
			<td class=tableData>18.64</td></tr><tr><td class=tableData>26th March 2006</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>19.41</td></tr><tr><td class=tableData>29th January 2006</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>18.85</td></tr><tr><td class=tableData>8th October 2005</td>
			<td class=tableData>Portway</td>
			<td class=tableData>18.99</td></tr><tr><td class=tableData>25th September 2005</td>
			<td class=tableData>Paws in the Park</td>
			<td class=tableData>18.73</td></tr><tr><td class=tableData>28th August 2005</td>
			<td class=tableData>Stoneleigh</td>
			<td class=tableData>19.50</td></tr><tr><td class=tableData>21st August 2005</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>18.71</td></tr><tr><td class=tableData>13th August 2005</td>
			<td class=tableData>Nuneaton Rugby Club</td>
			<td class=tableData>19.98</td></tr><tr><td class=tableData>30th July 2005</td>
			<td class=tableData>Tai Lawr</td>
			<td class=tableData>18.83</td></tr><tr><td class=tableData>24th July 2005</td>
			<td class=tableData>Tai Lawr</td>
			<td class=tableData>18.31</td></tr><tr><td class=tableData>9th July 2005</td>
			<td class=tableData>Saul</td>
			<td class=tableData>18.91</td></tr><tr><td class=tableData>2nd July 2005</td>
			<td class=tableData>Moreton Morrell</td>
			<td class=tableData>18.93</td></tr><tr><td class=tableData>19th June 2005</td>
			<td class=tableData>Nuneaton Rugby Club</td>
			<td class=tableData>18.15</td></tr><tr><td class=tableData>12th June 2005</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>18.39</td></tr><tr><td class=tableData>4th June 2005</td>
			<td class=tableData>Royal Bath & West Show</td>
			<td class=tableData>18.37</td></tr><tr><td class=tableData>1st May 2005</td>
			<td class=tableData>Knebworth</td>
			<td class=tableData>18.45</td></tr><tr><td class=tableData>16th April 2005</td>
			<td class=tableData>Portway</td>
			<td class=tableData>19.20</td></tr><tr><td class=tableData>27th March 2005</td>
			<td class=tableData>Thame</td>
			<td class=tableData>19.20</td></tr><tr><td class=tableData>20th March 2005</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>19.44</td></tr><tr><td class=tableData>13th February 2005</td>
			<td class=tableData>Newark Showground</td>
			<td class=tableData>19.67</td></tr><tr><td class=tableData>14th November 2004</td>
			<td class=tableData>Newark Showground</td>
			<td class=tableData>19.02</td></tr><tr><td class=tableData>16th October 2004</td>
			<td class=tableData>Canford Park</td>
			<td class=tableData>18.67</td></tr><tr><td class=tableData>9th October 2004</td>
			<td class=tableData>Portway</td>
			<td class=tableData>18.42</td></tr><tr><td class=tableData>5th September 2004</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>18.59</td></tr><tr><td class=tableData>22nd August 2004</td>
			<td class=tableData>Whitewater</td>
			<td class=tableData>19.31</td></tr><tr><td class=tableData>10th July 2004</td>
			<td class=tableData>Saul</td>
			<td class=tableData>18.80</td></tr><tr><td class=tableData>3rd July 2004</td>
			<td class=tableData>Portway</td>
			<td class=tableData>19.32</td></tr><tr><td class=tableData>13th June 2004</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>18.82</td></tr><tr><td class=tableData>6th June 2004</td>
			<td class=tableData>Whitewater</td>
			<td class=tableData>19.28</td></tr><tr><td class=tableData>30th May 2004</td>
			<td class=tableData>Broadlands</td>
			<td class=tableData>19.42</td></tr><tr><td class=tableData>2nd May 2004</td>
			<td class=tableData>Knebworth</td>
			<td class=tableData>18.98</td></tr><tr><td class=tableData>21st March 2004</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>19.32</td></tr><tr><td class=tableData>15th February 2004</td>
			<td class=tableData>Newark Showground</td>
			<td class=tableData>20.22</td></tr><tr><td class=tableData>31st August 2003</td>
			<td class=tableData>Odiham, Hampshire</td>
			<td class=tableData>19.27</td></tr><tr><td class=tableData>30th July 2003</td>
			<td class=tableData>Anglesey</td>
			<td class=tableData>19.51</td></tr><tr><td class=tableData>27th July 2003</td>
			<td class=tableData>Anglesey</td>
			<td class=tableData>19.25</td></tr><tr><td class=tableData>5th July 2003</td>
			<td class=tableData>Saul</td>
			<td class=tableData>19.07</td></tr><tr><td class=tableData>14th June 2003</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>19.43</td></tr><tr><td class=tableData>7th June 2003</td>
			<td class=tableData>Sharnford</td>
			<td class=tableData>20.27</td></tr><tr><td class=tableData>17th May 2003</td>
			<td class=tableData>Andover Open</td>
			<td class=tableData>19.97</td></tr><tr><td class=tableData>10th May 2003</td>
			<td class=tableData>Brentwood Open</td>
			<td class=tableData>20.16</td></tr><tr><td class=tableData>19th April 2003</td>
			<td class=tableData>Thame Open</td>
			<td class=tableData>19.55</td></tr><tr><td class=tableData>23rd March 2003</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>19.29</td></tr><tr><td class=tableData>2nd March 2003</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>19.21</td></tr><tr><td class=tableData>9th February 2003</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>19.21</td></tr><tr><td class=tableData>26th January 2003</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>18.83</td></tr><tr><td class=tableData>19th January 2003</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>19.34</td></tr><tr><td class=tableData>7th December 2002</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>19.17</td></tr><tr><td class=tableData>10th November 2002</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>19.37</td></tr><tr><td class=tableData>27th October 2002</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>19.72</td></tr><tr><td class=tableData>22nd September 2002</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>19.55</td></tr><tr><td class=tableData>18th August 2002</td>
			<td class=tableData>Meer End</td>
			<td class=tableData>19.57</td></tr><tr><td class=tableData>31st July 2002</td>
			<td class=tableData>Tai Lawr</td>
			<td class=tableData>19.35</td></tr><tr><td class=tableData>28th July 2002</td>
			<td class=tableData>Tai Lawr</td>
			<td class=tableData>19.18</td></tr><tr><td class=tableData>20th July 2002</td>
			<td class=tableData>Moss End</td>
			<td class=tableData>19.67</td></tr><tr><td class=tableData>7th July 2002</td>
			<td class=tableData>Saul</td>
			<td class=tableData>20.03</td></tr><tr><td class=tableData>7th July 2002</td>
			<td class=tableData>Saul</td>
			<td class=tableData>18.83</td></tr><tr><td class=tableData>30th June 2002</td>
			<td class=tableData>Newbury</td>
			<td class=tableData>18.95</td></tr><tr><td class=tableData>16th June 2002</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>19.59</td></tr><tr><td class=tableData>2nd June 2002</td>
			<td class=tableData>Sharnford</td>
			<td class=tableData>19.35</td></tr><tr><td class=tableData>12th May 2002</td>
			<td class=tableData>Brentwood</td>
			<td class=tableData>19.06</td></tr><tr><td class=tableData>6th May 2002</td>
			<td class=tableData>Knebworth</td>
			<td class=tableData>19.44</td></tr><tr><td class=tableData>23rd March 2002</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>19.01</td></tr><tr><td class=tableData>10th February 2002</td>
			<td class=tableData>Newark</td>
			<td class=tableData>19.34</td></tr><tr><td class=tableData>19th January 2002</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>19.42</td></tr><tr><td class=tableData>10th November 2001</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>19.12</td></tr><tr><td class=tableData>26th August 2001</td>
			<td class=tableData>Stoneleigh Town & Country Show</td>
			<td class=tableData>20.20</td></tr><tr><td class=tableData>22nd July 2001</td>
			<td class=tableData>Walsall Summer Show</td>
			<td class=tableData>19.83</td></tr><tr><td class=tableData>10th June 2001</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>18.89</td></tr><tr><td class=tableData>28th April 2001</td>
			<td class=tableData>Ryton</td>
			<td class=tableData>19.36</td></tr><tr><td class=tableData>18th February 2001</td>
			<td class=tableData>Slough</td>
			<td class=tableData>19.18</td></tr><tr><td class=tableData>21st January 2001</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>19.62</td></tr><tr><td class=tableData>19th November 2000</td>
			<td class=tableData>Thetford</td>
			<td class=tableData>20.17</td></tr><tr><td class=tableData>17th September 2000</td>
			<td class=tableData>Christchurch</td>
			<td class=tableData>21.04</td></tr><tr><td class=tableData>27th August 2000</td>
			<td class=tableData>Stoneleigh</td>
			<td class=tableData>20.71</td></tr><tr><td class=tableData>26th August 2000</td>
			<td class=tableData>Charlton Park</td>
			<td class=tableData>20.65</td></tr><tr><td class=tableData>19th August 2000</td>
			<td class=tableData>Althorne</td>
			<td class=tableData>21.04</td></tr><tr><td class=tableData>22nd July 2000</td>
			<td class=tableData>Walsall Summer Show</td>
			<td class=tableData>21.28</td></tr><tr><td class=tableData>18th June 2000</td>
			<td class=tableData>Moss End, Barkshire</td>
			<td class=tableData>20.73</td></tr><tr><td class=tableData>11th June 2000</td>
			<td class=tableData>Daventry</td>
			<td class=tableData>21.21</td></tr><tr><td class=tableData>22nd April 2000</td>
			<td class=tableData>Thame Country Show</td>
			<td class=tableData>20.53</td></tr><tr><td class=tableData>26th March 2000</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>20.86</td></tr><tr><td class=tableData>20th February 2000</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>20.49</td></tr><tr><td class=tableData>13th February 2000</td>
			<td class=tableData>MDS Complex, Petersfield</td>
			<td class=tableData>20.55</td></tr><tr><td class=tableData>23rd January 2000</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>20.95</td></tr><tr><td class=tableData>28th November 1999</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>20.84</td></tr><tr><td class=tableData>24th October 1999</td>
			<td class=tableData>Market Harborough</td>
			<td class=tableData>20.36</td></tr><tr><td class=tableData>2nd October 1999</td>
			<td class=tableData>Blake Hall, Essex</td>
			<td class=tableData>21.44</td></tr><tr><td class=tableData>29th August 1999</td>
			<td class=tableData>Stoneleigh</td>
			<td class=tableData>21.32</td></tr><tr><td class=tableData>24th July 1999</td>
			<td class=tableData>Dartford</td>
			<td class=tableData>20.65</td></tr><tr><td class=tableData>3rd July 1999</td>
			<td class=tableData>RVC, Hatfield</td>
			<td class=tableData>19.80</td></tr><tr><td class=tableData>30th May 1999</td>
			<td class=tableData>Broadlands</td>
			<td class=tableData>20.21</td></tr><tr><td class=tableData>2nd May 1999</td>
			<td class=tableData>Knebworth</td>
			<td class=tableData>20.09</td></tr><tr><td class=tableData>24th April 1999</td>
			<td class=tableData>Ryton-on-Dunsmore</td>
			<td class=tableData>21.10</td></tr><tr><td class=tableData>28th March 1999</td>
			<td class=tableData>Stopsley, Luton</td>
			<td class=tableData>21.24</td></tr><tr><td class=tableData>20th February 1999</td>
			<td class=tableData>Stopsley, Luton</td>
			<td class=tableData>20.78</td></tr><tr><td class=tableData>23rd January 1999</td>
			<td class=tableData>Stopsley, Luton</td>
			<td class=tableData>20.41</td></tr><tr><td class=tableData>5th December 1998</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>20.12</td></tr><tr><td class=tableData>24th October 1998</td>
			<td class=tableData>Petersfield</td>
			<td class=tableData>19.99</td></tr><tr><td class=tableData>3rd October 1998</td>
			<td class=tableData>Blake Hall</td>
			<td class=tableData>19.85</td></tr><tr><td class=tableData>30th August 1998</td>
			<td class=tableData>Charlton Park</td>
			<td class=tableData>19.44</td></tr><tr><td class=tableData>9th August 1998</td>
			<td class=tableData>Petworth</td>
			<td class=tableData>19.59</td></tr><tr><td class=tableData>11th July 1998</td>
			<td class=tableData>Codicote</td>
			<td class=tableData>19.48</td></tr><tr><td class=tableData>28th June 1998</td>
			<td class=tableData>Middlesex County Show</td>
			<td class=tableData>19.32</td></tr><tr><td class=tableData>14th June 1998</td>
			<td class=tableData>Sherborne Castle</td>
			<td class=tableData>19.14</td></tr><tr><td class=tableData>6th June 1998</td>
			<td class=tableData>Longleat (CH)</td>
			<td class=tableData>19.02</td></tr><tr><td class=tableData>12th April 1998</td>
			<td class=tableData>Taunton</td>
			<td class=tableData>19.73</td></tr><tr><td class=tableData>21st March 1998</td>
			<td class=tableData>Luton</td>
			<td class=tableData>20.36</td></tr><tr><td class=tableData>21st February 1998</td>
			<td class=tableData>Luton</td>
			<td class=tableData>22.11</td></tr><tr><td class=tableData>24th January 1998</td>
			<td class=tableData>Luton</td>
			<td class=tableData>21.08</td></tr><tr><td class=tableData>13th December 1997</td>
			<td class=tableData>Newark-on-Trent</td>
			<td class=tableData>20.45</td></tr><tr><td class=tableData>20th September 1997</td>
			<td class=tableData>Hayling Island</td>
			<td class=tableData>20.33</td></tr><tr><td class=tableData>24th August 1997</td>
			<td class=tableData>Charlton Park</td>
			<td class=tableData>24.17</td></tr><tr><td class=tableData>27th July 1997</td>
			<td class=tableData>Chard</td>
			<td class=tableData>24.46</td></tr></table>
<p>&nbsp;</p>                
          <!-- InstanceEndEditable -->
</div>
</div>
</body>
<!-- InstanceEnd --></html>
";

        #endregion

        /// <summary>
        /// The team id.
        /// </summary>
        private const string TeamId = "018";

        /// <summary>
        /// The test get by id current seed time.
        /// </summary>
        [TestMethod]
        public void TestGetByIdIdentifier()
        {
            var expected = TeamId;

            var team = GetTeam();

            Assert.AreEqual(expected, team.Id);
        }

        /// <summary>
        /// The test get by id current seed time.
        /// </summary>
        [TestMethod]
        public void TestGetByIdCurrentSeedTime()
        {
            var expected = 16.64M;

            var team = GetTeam();

            Assert.AreEqual(expected, team.CurrentSeedTime);
        }

        /// <summary>
        /// The test get by id current seed time.
        /// </summary>
        [TestMethod]
        public void TestGetByIdTournamentHistoryCount()
        {
            var expectedCount = 245;

            var team = GetTeam();

            Assert.AreEqual(expectedCount, team.RacingHistory.Count());
        }

        /// <summary>
        /// The test get by id current seed time.
        /// </summary>
        [TestMethod]
        public void TestGetByIdTournamentHistoryExpectedFirst()
        {
            var expectedDate = new DateTime(2015, 9, 6);
            var expectedVenue = "Padworth";
            var expectedTime = 17.12M;

            var team = GetTeam();

            var firstResult = team.RacingHistory.FirstOrDefault();

            Assert.AreEqual(expectedDate, firstResult.Date.Date);
            Assert.AreEqual(expectedTime, firstResult.FastestTime);
            Assert.AreEqual(expectedVenue, firstResult.Venue);
        }

        /// <summary>
        /// The test get by id current seed time.
        /// </summary>
        [TestMethod]
        public void TestGetByIdTournamentHistoryExpectedLast()
        {
            var expectedDate = new DateTime(1997, 7, 27);
            var expectedVenue = "Chard";
            var expectedTime = 24.46M;

            var team = GetTeam();

            var lastResult = team.RacingHistory.LastOrDefault();

            Assert.AreEqual(expectedDate, lastResult.Date.Date);
            Assert.AreEqual(expectedTime, lastResult.FastestTime);
            Assert.AreEqual(expectedVenue, lastResult.Venue);

        }

        /// <summary>
        /// Gets the team.
        /// </summary>
        /// <returns>
        /// The team
        /// </returns>
        private static Team GetTeam()
        {
            var fakeWebpageLoader = new FakeWebpageLoader(PageSource);
            var stubEntityRepository = new StubIEntityRepository<Team, string>();

            var repository = new BfaTeamRepository(fakeWebpageLoader);

            var task = repository.GetByIdAsync(TeamId);

            var team = task.Result;
            return team;
        }
    }
}
