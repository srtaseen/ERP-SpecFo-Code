


$(document).ready(function () {
    $(document).bind("contextmenu", function (e) {
        return false;

    });
  //  $(window).unload(function () { alert("Bye now!"); });
});
//clear errormessage on focus
function clearlabel(labelid) {
    document.getElementById(labelid).innerHTML = '';
}   
   
    //model popup open close
    function modelwindowok(btnok) {
        window.parent.document.getElementById(btnok).click();
    }
    function modelwindowcancel(cnclbtn) {
        window.parent.document.getElementById(cnclbtn).click();
    }
//****----------------gridview fixed header---------****
    function CreateGridHeader(DataDiv, GridView1, HeaderDiv) {
        var DataDivObj = document.getElementById(DataDiv);
        var DataGridObj = document.getElementById(GridView1);
        var HeaderDivObj = document.getElementById(HeaderDiv);
        var HeadertableObj = HeaderDivObj.appendChild(document.createElement('table'));
        DataDivObj.style.paddingTop = '0px';
        var DataDivWidth = DataDivObj.clientWidth;
        DataDivObj.style.width = '5000px';
        HeaderDivObj.className = DataDivObj.className;
        HeaderDivObj.style.cssText = DataDivObj.style.cssText;      
        HeaderDivObj.style.overflow = 'auto';       
        HeaderDivObj.style.overflowX = 'hidden';       
        HeaderDivObj.style.overflowY = 'hidden';
        HeaderDivObj.style.height = DataGridObj.rows[0].clientHeight + 'px';      
        HeaderDivObj.style.borderBottomWidth = '0px';
        HeadertableObj.className = DataGridObj.className;      
        HeadertableObj.style.cssText = DataGridObj.style.cssText;
        HeadertableObj.border = '1px';
        HeadertableObj.rules = 'all';
        HeadertableObj.cellPadding = DataGridObj.cellPadding;
        HeadertableObj.cellSpacing = DataGridObj.cellSpacing;
        var Row = HeadertableObj.insertRow(0);
        Row.className = DataGridObj.rows[0].className;
        Row.style.cssText = DataGridObj.rows[0].style.cssText;
        Row.style.fontWeight = 'bold';
        for (var iCntr = 0; iCntr < DataGridObj.rows[0].cells.length; iCntr++) {
            var spanTag = Row.appendChild(document.createElement('td'));
            spanTag.innerHTML = DataGridObj.rows[0].cells[iCntr].innerHTML;
            var width = 0;          
            if (spanTag.clientWidth > DataGridObj.rows[1].cells[iCntr].clientWidth) {
                width = spanTag.clientWidth;
            }
            else {
                width = DataGridObj.rows[1].cells[iCntr].clientWidth;
            }
            if (iCntr <= DataGridObj.rows[0].cells.length - 2) {
                spanTag.style.width = width + 'px';
            }
            else {
                spanTag.style.width = width + 20 + 'px';
            }
            DataGridObj.rows[1].cells[iCntr].style.width = width + 'px';
        }
        var tableWidth = DataGridObj.clientWidth;       
        DataGridObj.rows[0].style.display = 'none';   
        HeaderDivObj.style.width = DataDivWidth + 'px';
        DataDivObj.style.width = DataDivWidth + 'px';
        DataGridObj.style.width = tableWidth + 'px';
        HeadertableObj.style.width = tableWidth + 20 + 'px';
        return false;
    }
    function Onscrollfnction(DataDiv, HeaderDiv) {
        var div = document.getElementById(DataDiv);
        var div2 = document.getElementById(HeaderDiv);    
        div2.scrollLeft = div.scrollLeft;
        return false;
    }
    //****----------------gridview fixed header---------****
    function openPopupfull(strOpen) {        //alert(strOpen);
        open(strOpen, "Info", "status=1,scrollbars=yes,width=920, height=500, top=70, left=50");
    }

    function CalculateOtherBookingAmount(txtQty, txtRate, txtvalue) {
        var Qty = document.getElementById(txtQty).value;
        var Rate = document.getElementById(txtRate).value;
        
        var Quantity = 0;
        var Uprice = 0;
        var TotllAmt = 0;
        if (Qty.length > 0) {
            Quantity = Qty;
        }
        if (Rate.length > 0) {
            Uprice = Rate;
        }
        TotllAmt = parseFloat(Quantity) * parseFloat(Uprice);
        document.getElementById(txtvalue).value = TotllAmt.toFixed(2);

    }
    function gridrowcolor(gridview, rowid) {
        var gvDrv = document.getElementById(gridview);
        for (i = 1; i < gvDrv.rows.length; i++) {
            gvDrv.rows[i].style.backgroundColor = "";
            gvDrv.rows[i].style.color = "";
           // gvDrv.rows[i].cells[10].style.backgroundColor = "#E5FED3";   
        }
        gvDrv.rows[rowid].style.backgroundColor = "#00AEE8";
        gvDrv.rows[rowid].style.color = "white";
        }
        function gridrowcolorwclm(gridview, rowid,clm) {
            var gvDrv = document.getElementById(gridview);
            for (i = 1; i < gvDrv.rows.length; i++) {
                gvDrv.rows[i].style.backgroundColor = "";
                //gvDrv.rows[i].cells[clm].style.backgroundColor = "#E5FED3";
            }
            gvDrv.rows[rowid].style.backgroundColor = "#E5FED3";
        }

        //*****mhpsexpdtxt***
//        var sessionTimeoutWarning = "<%= System.Configuration.ConfigurationSettings.AppSettings["SessionWarning"].ToString()%>";
//        var sessionTimeout = "<%= Session.Timeout %>";
//        var timeOnPageLoad = new Date();
//        var sessionWarningTimer = null;
//        var redirectToWelcomePageTimer = null;
//        //For warning
//        var sessionWarningTimer = setTimeout('SessionWarning()', parseInt(sessionTimeoutWarning) * 60 * 1000);
//        //To redirect to the welcome page
//        var redirectToWelcomePageTimer = setTimeout('RedirectToWelcomePage()',parseInt(sessionTimeout) * 60 * 1000);
//        //Session Warning
//        function SessionWarning() {
//            //minutes left for expiry
//            var minutesForExpiry =  (parseInt(sessionTimeout) - parseInt(sessionTimeoutWarning));
//            var message = "Your session will expire in another " + minutesForExpiry + " mins. Do you want to extend the session?";
//            //Confirm the user if he wants to extend the session
//            answer = confirm(message);

//            //if yes, extend the session.
//            if(answer)
//            {
//                var img = new Image(1, 1);
//                img.src = 'Smt_Login.aspx?date=' + escape(new Date());

//                //Clear the RedirectToWelcomePage method
//                if (redirectToWelcomePageTimer != null) {
//                    clearTimeout(redirectToWelcomePageTimer);
//                }
//                timeOnPageLoad =  new Date();
//                sessionWarningTimer = setTimeout('SessionWarning()', parseInt(sessionTimeoutWarning) * 60 * 1000);
//                //To redirect to the welcome page
//                redirectToWelcomePageTimer = setTimeout('RedirectToWelcomePage()',parseInt(sessionTimeout) * 60 * 1000);
//            }

//            //*************************
//            //Even after clicking ok(extending session) or cancel button, if the session time is over. Then exit the session.
//            var currentTime = new Date();
//            //time for expiry
//            var timeForExpiry = timeOnPageLoad.setMinutes(timeOnPageLoad.getMinutes() + parseInt(sessionTimeout)); 

//            //Current time is greater than the expiry time
//            if(Date.parse(currentTime) > timeForExpiry)
//            {
//                alert("Session expired. You will be redirected to Login page");
//                window.location = "../Smt_Login.aspx";
//            }
//            //**************************
//        }

//        //Session timeout
//        function RedirectToWelcomePage(){
//            alert("Session expired. You will be redirected to Login page");
//            window.location = "../Smt_Login.aspx";
        //        }

        function validatespace(e) {
            var unicode = e.charCode ? e.charCode : e.keyCode;
            if (unicode == 32) {
                return false;
            }
            else {
                return true;
            }
        }



        ////
        function showNotificationBar(message, duration, bgColor, txtColor, height) {
            /*set default values*/
            duration = typeof duration !== 'undefined' ? duration : 3000;
            bgColor = typeof bgColor !== 'undefined' ? bgColor : "#F4E0E1";
            txtColor = typeof txtColor !== 'undefined' ? txtColor : "#A42732";
            height = typeof height !== 'undefined' ? height : 40;
            /*create the notification bar div if it doesn't exist*/
            if ($('#notification-bar').size() == 0) {
                var HTMLmessage = "<div class='notification-message' style='text-align:center; line-height: " + height + "px;'> " + message + " </div>";
                //$('body').prepend("<div id='notification-bar' style='display:none; width:100%;border:1px solid #4D92B2;position:fixed;bottom:200px;left:100px;min-width:200px; max-width:500px; min-height:10px; max-height:300px; height:" + height + "px; background-color: " + bgColor + "; position: fixed; z-index: 100; color: " + txtColor + ";border-bottom: 1px solid " + txtColor + ";'>" + HTMLmessage + "</div>");
                $('body').append("<div id='notification-bar' class='alertmsg'><div onmouseover='sh();' class='alertmsgheader'><div class='alertmsgheaderlft'>headerinfo</div><div class='alertmsgheaderrit'><img onclick='clsalrt();' src='../gridimage/grdRemove.png' /></div></div>" + HTMLmessage + "</div>");
          }
            /*animate the bar*/
//            $('.alertmsg').slideDown(function () {
//               setTimeout(function () {
//                   $('.alertmsg').slideUp(function () { });
//                }, duration);
            //            });
            $('.alertmsg').fadeIn(duration);
          var s= setTimeout('hiddd()', 3000);        
        }
        function hiddd() {
            $('.alertmsg').fadeOut(1500);
        }
//        function tdsf() { 
//        clearTimeout(
//        }
        function sh() {
        clearTimeout(s);
           // $('.alertmsg').show();
        }
       function clsalrt() {
           //$('.alertmsg').hide();
           $('.alertmsg').slideDown(function () {
               setTimeout(function () {
                   $('.alertmsg').slideUp(function () { });
               }, 100);
           });
       }


       function get_MonthsNum(Nm) {
           var valu;
           if (Nm == "Jan") {
               valu = "01";
           }
           if (Nm == "Feb") {
               valu = "02";
           }
           if (Nm == "Mar") {
               valu = "03";
           }
           if (Nm == "Apr") {
               valu = "04";
           }
           if (Nm == "May") {
               valu = "05";
           }
           if (Nm == "Jun") {
               valu = "06";
           }
           if (Nm == "Jul") {
               valu = "07";
           }
           if (Nm == "Aug") {
               valu = "08";
           }
           if (Nm == "Sep") {
               valu = "09";
           }
           if (Nm == "Oct") {
               valu = "10";
           }
           if (Nm == "Nov") {
               valu = "11";
           }
           if (Nm == "Dec") {
               valu = "12";
           }
           return valu;
       }
       function get_Monthsstring(Nm) {
           var valu;
           if (Nm == "01" || Nm == "1") {
               valu = "Jan";
           }
           if (Nm == "02" || Nm == "2") {
               valu = "Feb";
           }
           if (Nm == "03" || Nm == "3") {
               valu = "Mar";
           }
           if (Nm == "04" || Nm == "4") {
               valu = "Apr";
           }
           if (Nm == "05" || Nm == "5") {
               valu = "May";
           }
           if (Nm == "06" || Nm == "6") {
               valu = "Jun";
           }
           if (Nm == "07" || Nm == "7") {
               valu = "Jul";
           }
           if (Nm == "08" || Nm == "8") {
               valu = "Aug";
           }
           if (Nm == "09" || Nm == "9") {
               valu = "Sep";
           }
           if (Nm == "10" || Nm == "10") {
               valu = "Oct";
           }
           if (Nm == "11" || Nm == "11") {
               valu = "Nov";
           }
           if (Nm == "12" || Nm == "12") {
               valu = "Dec";
           }
           return valu;
       }
        

            

        

