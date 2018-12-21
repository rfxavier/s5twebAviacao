<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="AspNet5t.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
        <%--<script src='<%=Page.ResolveUrl("~/Content/jQuery-webcam-master/jquery.webcam.js") %>' type="text/javascript"></script>--%>
        <script src='<%=ResolveUrl("~/Webcam_Plugin/jquery.webcam.js") %>' type="text/javascript"></script>


</head>
    <script type="text/javascript">
        
        
        var pageUrl = "WebForm1.aspx";
         
        $(function () {
            jQuery("#webcam").webcam({
                width: 320,
                height: 240,
                mode: "save",
                swffile: '<%=ResolveUrl("~/Webcam_Plugin/jscam.swf") %>',
                debug: function (type, status) {
                    $('#camStatus').append(type + ": " + status + '<br /><br />');
                },
                //onSave: function (data) {
                //    $.ajax({
                //        type: "POST",
                //        url: pageUrl + "/GetCapturedImage",
                //        data: '',
                //        contentType: "application/json; charset=utf-8",
                //        dataType: "json",
                //        success: function (r) {
                //            $("[id*=imgCapture]").css("visibility", "visible");
                //            $("[id*=imgCapture]").attr("src", r.d);
                //        },
                //        failure: function (response) {
                //            alert(response.d);
                //        }
                //    });
                //},

                onSave: function(data) {

                    var col = data.split(";");
                    var img = image;

                    for(var i = 0; i < 320; i++) {
                        var tmp = parseInt(col[i]);
                        img.data[pos + 0] = (tmp >> 16) & 0xff;
                        img.data[pos + 1] = (tmp >> 8) & 0xff;
                        img.data[pos + 2] = tmp & 0xff;
                        img.data[pos + 3] = 0xff;
                        pos+= 4;
                    }

                    if (pos >= 4 * 320 * 240) {
                        ctx.putImageData(img, 0, 0);
                        pos = 0;
                    }
                },


                onCapture: function () {
                    webcam.save(pageUrl);
                }
            });
        });
        function Capture() {
            webcam.capture();
            return false;
        }
        function exec() {
            var oShell = new ActiveXObject("Shell.Application");

            var commandtoRun = "Notepad.exe";
            if (inputparms != "") {
                var commandParms = document.Form1.filename.value;
            }

            // Invoke the execute method.  
            oShell.ShellExecute(commandtoRun, commandParms, "", "open", "1");
  
  
            app.doScript(scpt, language);  
            var a = new ActiveXObject("WScript.Shell");
            a.Run("C:\\4TWebCam\\S5TWebCam.exe", "1 1",1,true);
        }


     </script>    
<body>

   <form id="form1"  action="#" method="post" runat="server">
<table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td align="center">
            <u>Live Camera</u>
        </td>
        <td>
        </td>
        <td align="center">
            <u>Captured Picture</u>
        </td>
    </tr>
    <tr>
        <td>
            <div id="webcam">
            </div>
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            <asp:Image ID="imgCapture" runat="server" Style="visibility: hidden; width: 320px;
                height: 240px" />
        </td>
    </tr>
</table>
<br />
<asp:Button ID="Button1" Text="Capture" runat="server" OnClientClick="return exec();" />
 <br />  <div>  <a href = "C:\4TWebCam\S5TWebCam.exe"></a></div> 
<%--<asp:Button ID="btnCapture" Text="Capture" runat="server" OnClientClick="return Capture();" />--%>

       
<br />
<span id="camStatus"></span>
</form>
</body>
</html>
