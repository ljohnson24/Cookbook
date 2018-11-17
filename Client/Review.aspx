<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Review.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style type="text/css">
        #Text2 {
            height: 108px;
            width: 216px;
        }
        #Text3 {
            height: 29px;
            width: 173px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Review Submission<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1&nbsp;&nbsp;&nbsp; 2&nbsp;&nbsp;&nbsp; 3&nbsp;&nbsp;&nbsp; 4&nbsp;&nbsp;&nbsp; 5</strong><br />
            <strong>Rating:</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input id="Radio1" type="radio" />&nbsp;&nbsp; <input id="Radio2" type="radio" />&nbsp;&nbsp; <input id="Radio3" type="radio" />&nbsp; <input id="Radio4" type="radio" />&nbsp;&nbsp; <input id="Radio5" type="radio" /><br />
            <br />
            Comment:&nbsp;&nbsp;&nbsp;<br />
&nbsp;<input id="Text2" type="text" /><br />
            <br />
            Author:&nbsp;&nbsp;&nbsp;
            <input id="Text1" type="text" /><br />
            <br />
            * required information<br />
            <strong>
            <input id="Submit1" type="submit" value="Submit" /></strong></div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
