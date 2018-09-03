function CalculateGRNValue(lblPrice,txtGRNQty,lblGRNValue,lblRest,txtFoc) {
    var Price = document.getElementById(lblPrice).value;
    var GrnQty = document.getElementById(txtGRNQty).value;
    var txtFocQty = document.getElementById(txtFoc).value;
    var RestQty=document.getElementById(lblRest).innerText;
    var Total = 0;
    var Foc = 0;
    var Uprice = 0;
    if (Price.length > 0) {
        Uprice = Price;
    }
    if (GrnQty.length > 0) {
        if (parseFloat(GrnQty) > parseFloat(RestQty)) {
            Foc = parseFloat(GrnQty) - parseFloat(RestQty);
            document.getElementById(txtGRNQty).value = RestQty;
            var GrnValue = 0;
            GrnValue = parseFloat(RestQty) * parseFloat(Uprice);
            document.getElementById(lblGRNValue).value = GrnValue.toFixed(2);
            document.getElementById(txtFoc).value =Foc.toFixed(2);
        }
        else {
            Total = parseFloat(Uprice) * parseFloat(GrnQty);
            document.getElementById(lblGRNValue).value = Total.toFixed(2);
            document.getElementById(txtFoc).value = "0";
        }
    }
    else {
        document.getElementById(lblGRNValue).value = "0";
        document.getElementById(txtFoc).value = "0";
    }
}


//factory Purchase
function CalculateFactoryPurchaseValue(txtReqQty, txtUprice, txtValue) {
   
    var ReqQty = document.getElementById(txtReqQty).value;
    var Uprice = document.getElementById(txtUprice).value;
    var RQty = 0;
    var UnitPrice = 0;
    var Total = 0;
    if (ReqQty.length > 0) {
        RQty = ReqQty;
    }
    if (Uprice.length > 0) {
        UnitPrice = Uprice;
    }
    Total = parseFloat(RQty) * parseFloat(UnitPrice);
    document.getElementById(txtValue).value = Total.toFixed(2);
}



//Goods Issue Calculate
function CalculateIssueValue(txtStock, tbUprice, tbItmParam, tbIssueParam, tbIssueQty, tbValue, tbCalculateValue) {
    document.getElementById(tbValue).value = "0";
    document.getElementById(tbValue).value = "0";
    document.getElementById(tbCalculateValue).value = "0";
    var Stock = document.getElementById(txtStock).value;
    var Uprce = document.getElementById(tbUprice).value;
    var ItmPrm = document.getElementById(tbItmParam).value;
    var IssuPrm = document.getElementById(tbIssueParam).value;
    var issueQty = document.getElementById(tbIssueQty).value;
    var IssueQuantity = 0;
    var CalculatePrice = 0;
    var Stk = 0;
    var Balance = 0;
    var prce = 0;
    var totalalue = 0;
    if (Uprce.length > 0) {
        prce = Uprce;
    }
    if (Stock.length > 0) {
        Stk = Stock;
    }   
    if(issueQty.length>0)
    {
        if (IssuPrm.length > 0) {
            IssueQuantity = (parseFloat(issueQty) * parseFloat(IssuPrm)) / parseFloat(ItmPrm);
            CalculatePrice =  (parseFloat(IssuPrm) * parseFloat(prce)) / parseFloat(ItmPrm);
        }
        else {
            IssueQuantity = parseFloat(issueQty);
            CalculatePrice = parseFloat(prce);
        }
        if (parseFloat(IssueQuantity) > parseFloat(Stk)) {
            document.getElementById(txtStock).style.background = '#E60000';
            alert("Quantity Cannot Exceed Stock");
            document.getElementById(tbIssueQty).value = "";
            document.getElementById(tbValue).value = "";
            document.getElementById(tbCalculateValue).value = "";
            document.getElementById(txtStock).style.background = '';
            document.getElementById(txtStock).focus();
        }
        else {
            document.getElementById(tbCalculateValue).value = IssueQuantity.toFixed(2);
            totalalue = parseFloat(issueQty) * parseFloat(CalculatePrice);
            document.getElementById(tbValue).value = totalalue.toFixed(2);
       }

    }

}
function CalculateReturnValue(txtStock, tbUprice, tbItmParam, tbIssueParam, tbIssueQty, tbValue, tbCalculateValue) {
    document.getElementById(tbValue).value = "0";
    document.getElementById(tbValue).value = "0";
    document.getElementById(tbCalculateValue).value = "0";
    var Stock = document.getElementById(txtStock).value;
    var Uprce = document.getElementById(tbUprice).value;
    var ItmPrm = document.getElementById(tbItmParam).value;
    var IssuPrm = document.getElementById(tbIssueParam).value;
    var issueQty = document.getElementById(tbIssueQty).value;
    var IssueQuantity = 0;
    var CalculatePrice = 0;
    var Stk = 0;
    var Balance = 0;
    var prce = 0;
    var totalalue = 0;
    if (Uprce.length > 0) {
        prce = Uprce;
    }
    if (Stock.length > 0) {
        Stk = Stock;
    }
    if (issueQty.length > 0) {
        if (IssuPrm.length > 0) {
            IssueQuantity = (parseFloat(issueQty) * parseFloat(IssuPrm)) / parseFloat(ItmPrm);
            CalculatePrice = (parseFloat(IssuPrm) * parseFloat(prce)) / parseFloat(ItmPrm);
        }
        else {
            IssueQuantity = parseFloat(issueQty);
            CalculatePrice = parseFloat(prce);
        }    
            document.getElementById(tbCalculateValue).value = IssueQuantity.toFixed(2);
            totalalue = parseFloat(issueQty) * parseFloat(CalculatePrice);
            document.getElementById(tbValue).value = totalalue.toFixed(2);       

    }

}



function CalculateReturnValue(txtStock, tbUprice, tbItmParam, tbIssueParam, tbIssueQty, tbValue, tbCalculateValue) {
    document.getElementById(tbValue).value = "0";
    var Stock = document.getElementById(txtStock).value;
    var Uprce = document.getElementById(tbUprice).value;
    var ItmPrm = document.getElementById(tbItmParam).value;
    var IssuPrm = document.getElementById(tbIssueParam).value;
    var issueQty = document.getElementById(tbIssueQty).value;
    var IssueQuantity = 0;
    var CalculatePrice = 0;
    var Stk = 0;
    var Balance = 0;
    var prce = 0;
    var totalalue = 0;
    if (Uprce.length > 0) {
        prce = Uprce;
    }
    if (Stock.length > 0) {
        Stk = Stock;
    }
    if (issueQty.length > 0) {
        if (IssuPrm.length > 0) {
            IssueQuantity = (parseFloat(issueQty) * parseFloat(IssuPrm)) / parseFloat(ItmPrm);
            CalculatePrice = (parseFloat(IssuPrm) * parseFloat(prce)) / parseFloat(ItmPrm);
        }
        else {
            IssueQuantity = parseFloat(issueQty);
            CalculatePrice = parseFloat(prce);
        }
        if (parseFloat(IssueQuantity)<0) {
            document.getElementById(txtStock).style.background = '#E60000';
            alert("Quantity should positive");
            document.getElementById(tbIssueQty).value = "";
            document.getElementById(tbValue).value = "";
            document.getElementById(txtStock).style.background = '';
            document.getElementById(txtStock).focus();
        }
        else {
            document.getElementById(tbCalculateValue).value = IssueQuantity.toFixed(2);
            totalalue = parseFloat(issueQty) * parseFloat(CalculatePrice);
            document.getElementById(tbValue).value = totalalue.toFixed(2);
        }

    }

}




function popupWindowTest(width, height) {
    if (window.innerWidth) {
        LeftPosition = (window.innerWidth - width) / 2;
        TopPosition = ((window.innerHeight - height) / 4) - 50;
    }
    else {
        LeftPosition = (parseInt(window.screen.width) - width) / 2;
        TopPosition = ((parseInt(window.screen.height) - height) / 2) - 50;
    }
    attr = 'resizable=no,scrollbars=yes,width=' + width + ',height=' +
	height + ',screenX=300,screenY=200,left=' + LeftPosition + ',top=' +
	TopPosition + '';
    popWin = open('', 'new_window', attr);
    popWin.document.write('<head><title>Test Popup</title></head>');
    popWin.document.write('<body><div align=center>');
    popWin.document.write('<b>This is a test popup window</b><br><br>');
    popWin.document.write('Content goes here<br>');
    popWin.document.write('Content goes here<br>');
    popWin.document.write('Content goes here<br>');
    popWin.document.write('</div></body></html>');
}
