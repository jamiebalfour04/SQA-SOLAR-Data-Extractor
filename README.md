# SQA Data Extractor
This is a simple program that takes one CSV of data and turns it into a formatted one for SQA SOLAR upload. 

Provide the data in any format, provided the forename is first and the surname is second, e.g.:
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

And provide the titles in the original CSV in the first row. Once you've done that, you'll need to provide a second CSV file which contains the list of forenames and surnames of the pupils you want the information for:

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
