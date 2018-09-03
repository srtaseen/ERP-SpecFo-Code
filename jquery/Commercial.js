function CalculateContMasterComission(txtContValue, txtCommission, txtCalculataVal,txtpercent) {
    var Comission = document.getElementById(txtCommission).value;
    var ContValue = document.getElementById(txtContValue).value;
    document.getElementById(txtCalculataVal).value = "0";
    //var WithCommision = 0;
    var CalcValue = 0;
    if (Comission.length > 0) {
        //document.getElementById(txtCalculataVal).value = Comission;
       // WithCommision = (parseFloat(ContValue) * parseFloat(Comission) / 100);
        CalcValue = parseFloat(ContValue) - parseFloat(Comission);
        document.getElementById(txtCalculataVal).value = CalcValue;
        var prcnt = (parseFloat(Comission) * 100) / parseFloat(ContValue);
        document.getElementById(txtpercent).value = prcnt.toFixed(1);

    }
//    else {
//        document.getElementById(txtCalculataVal).value = ContValue;
//    }
}

function ValidateLCValue(txtLCValue, txtBalance) {
    var LcValue = document.getElementById(txtLCValue).value;
    if (LcValue.length > 0) {
        var Balance = document.getElementById(txtBalance).value;       
        if (parseFloat(LcValue) > parseFloat(Balance)) {
            document.getElementById(txtBalance).style.border = '1px solid red';
            document.getElementById(txtLCValue).style.border = '1px solid red';
            alert("LC Value Cann't Exceed Balance");
            document.getElementById(txtLCValue).value = '';
            document.getElementById(txtBalance).style.border = '';
            document.getElementById(txtLCValue).style.border = '';
        }
    }
}

function CalculateLimit(bblcvalue, LCLimit) {
    var bblc = document.getElementById(bblcvalue).value;
    var LCLimit = document.getElementById(LCLimit).value;
    if (bblc.length > 0) {
        if (parseFloat(bblc) > parseFloat(LCLimit)) {
            document.getElementById(bblcvalue).style.border = '1px solid red';
            //document.getElementById(LCLimit).style.border = '1px solid red';
            alert("Back To Back LC Value Cannot Exceed Limit");
            document.getElementById(bblcvalue).value = '';
            document.getElementById(bblcvalue).style.border = '';
            document.getElementById(LCLimit).style.border = '';
        }
    }
}