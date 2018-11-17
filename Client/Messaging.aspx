<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Messaging.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style type="text/css">
        #Text2 {
            height: 230px;
            width: 564px;
        }
        #Text13 {
            width: 55px;
        }
        #Text14 {
            width: 87px;
        }
        #Text15 {
            width: 55px;
        }
        #Text16 {
            width: 87px;
        }
        #Text17 {
            width: 55px;
        }
        #Text18 {
            width: 87px;
        }
        #Text19 {
            width: 55px;
        }
        #Text20 {
            width: 87px;
        }
        #Text21 {
            width: 55px;
        }
        #Text22 {
            width: 87px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Messaging System<br />
            <br />
            Compose Message<br />
            </strong><br />
            To (User):&nbsp;&nbsp;&nbsp; <input id="Text1" type="text" /><br />
            Subject:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input id="Text23" type="text" /><br />
            <br />
            Message:<br />
            <br />
            <input id="Text2" type="text" /><br />
            <br />
            * required information<br />
            <strong>
            <input id="Submit1" type="submit" value="Send" /></strong></div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
