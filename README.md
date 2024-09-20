# SQA Data Extractor
<p>
  This simple program takes one CSV of data and turns it into a formatted one for SQA SOLAR upload. 
</p>
<p>
  Sometimes, the data you get from SEEMIS has too much or too little. Sometimes, you need to reduce or filter the results 
  of a custom report to affect just one group of pupils. This program can seriously help with this.
</p>
<p>
  To use it, provide the data in any format, provided the forename is first and the surname is second, e.g:
</p>
<table>
  <tr>
    <td>
      Forename
    </td>
    <td>
      Surname
    </td>
    <td>
      SQA Number
    </td>
    <td>
      Date of birth
    </td>    
    <td>
      Gender
    </td>
  </tr>
</table>

> [!NOTE]
> Ensure you provide the original CSV titles in the first row. Once you've done that, you'll need to provide a second CSV file which contains the list of forenames and surnames of the pupils you want the information for in the following format:


<table>
  <tr>
    <td>
      Forename
    </td>
    <td>
      Surname
    </td>
  </tr>
</table>

<p>
  Finally, click the final button to generate the output. The program will run through the data, extracting what it needs and producing a CSV in the format expected on the SQA SOLAR upload.
</p>
