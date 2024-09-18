# SQA Data Extractor
A simple program to take one CSV of data and turn it into a formatted one for SQA SOLAR upload. 

Provide the data in whatever format, e.g.:
<table>
  <tr>
    <td>
      SQA Number
    </td>
    <td>
      Surname
    </td>
    <td>
      Date of birth
    </td>
    <td>
      Forename
    </td>
    <td>
      Gender
    </td>
  </tr>
</table>

And provide the titles in the original CSV in the first row. Once you've done that, the program will run through the data and extract what it needs and produces a CSV in 
the format expected on the SQA SOLAR upload.
