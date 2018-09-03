
function BOMCalculation(dr, txtparam, txtord, txtcomsum, txtwst, txtreq, txtRate, txtvalue, txtttqty, txtActQty,txtUnitParam) {  
        var ddlBran = document.getElementById(dr);
        var SelVal = ddlBran.options[ddlBran.selectedIndex].text;
        var ttq = document.getElementById(txtttqty).value
        document.getElementById(txtord).value = ttq;
        if (SelVal == "PCS") {

            document.getElementById(txtparam).value = "1";
        }
        else if (SelVal == "DOZ") {
            document.getElementById(txtparam).value = "12";
        }
        else {
            document.getElementById(txtparam).value = "";
        }
        var UnitParam = document.getElementById(txtUnitParam).value;
        var param = document.getElementById(txtparam).value;
        var com = document.getElementById(txtcomsum).value;
        var ordqty = document.getElementById(txtord).value;
        var wast = document.getElementById(txtwst).value;
        var comord = eval(com) * eval(ordqty);
        var Wastage;
        var withwast;
        var tl;
        var witt;
        if (parseFloat(wast) > 0) {
            Wastage = eval(wast);
            withwast = eval(comord) * eval(Wastage);
            tl = eval(withwast) / eval(100);
            witt = Math.round(eval(tl) + eval(comord), 4);
        }
        else {
            withwast = eval(comord);
            tl = eval(withwast);
            witt = Math.round(eval(tl), 4);
            }     

        var tt = eval(witt) / eval(UnitParam);     
        var totalReq = parseFloat(tt) / parseFloat(eval(param));
        var roundtotal = totalReq.toFixed(2);        
        if (!isNaN(totalReq)) {
            document.getElementById(txtreq).value = roundtotal;
            document.getElementById(txtActQty).value = roundtotal;
        }
        var rate = document.getElementById(txtRate).value;

        var _Uprice = 0;
        if (rate.length > 0) {
            _Uprice = rate;
        }
        var req = document.getElementById(txtreq).value;
        var WithoutFixed = (eval(totalReq) * eval(_Uprice));
        var val = WithoutFixed.toFixed(2);      
        if (!isNaN(val)) {
            document.getElementById(txtvalue).value = val;
        }
    }
    function BOMCalculationforEBOM(dr, txtparam, txtord, txtcomsum, txtwst, txtreq, txtRate, txtvalue, txtttqty, txtUnitParam) {
        var ddlBran = document.getElementById(dr);
        var SelVal = ddlBran.options[ddlBran.selectedIndex].text;
        var ttq = document.getElementById(txtttqty).value
        document.getElementById(txtord).value = ttq;
        if (SelVal == "PCS") {

            document.getElementById(txtparam).value = "1";
        }
        else if (SelVal == "DOZ") {
            document.getElementById(txtparam).value = "12";
        }
        else {
            document.getElementById(txtparam).value = "";
        }
        var UnitParam = document.getElementById(txtUnitParam).value;
        var param = document.getElementById(txtparam).value;
        var com = document.getElementById(txtcomsum).value;
        var ordqty = document.getElementById(txtord).value;
        var wast = document.getElementById(txtwst).value;
        var comord = eval(com) * eval(ordqty);
        var Wastage;
        var withwast;
        var tl;
        var witt;

        if (parseFloat(wast) > 0) {
            Wastage = eval(wast);
            withwast = eval(comord) * eval(Wastage);
            tl = eval(withwast) / eval(100);
            witt = Math.round(eval(tl) + eval(comord), 2);
        }
        else {
            withwast = eval(comord);
            tl = eval(withwast);
            witt = Math.round(eval(tl), 2);
        }

        var tt = eval(witt) / eval(UnitParam);
        var totalReq = parseFloat(tt) / parseFloat(eval(param));
        var roundtotal = totalReq.toFixed(2);
        if (!isNaN(totalReq)) {
            document.getElementById(txtreq).value = roundtotal;
            //document.getElementById(txtActQty).value = roundtotal;
        }
        var rate = document.getElementById(txtRate).value;

        var _Uprice = 0;
        if (rate.length > 0) {
            _Uprice = rate;
        }
        var req = document.getElementById(txtreq).value;
        var WithoutFixed = (eval(totalReq) * eval(_Uprice));
        var val = WithoutFixed.toFixed(2);
        if (!isNaN(val)) {
            document.getElementById(txtvalue).value = val;
        }
    }
    function BOMCalculationforQuickcosting(dr, txtparam, txtord, txtcomsum, txtwst, txtreq, txtRate, txtvalue, txtttqty, txtUnitParam, gridview, txtvalttl, txtNoperhr, txtcostperhr, manufcst, txtTtlcost, txtCommercialcost, txtBuyercomission, txtFreightcost, txtTtlfob, txtOther, txtqty, txtFobpc, txtFobdz, txtProfit, txtcommercialcstdlr, txtBuyercomissiondlr) {
        var ddlBran = document.getElementById(dr);
        var SelVal = ddlBran.options[ddlBran.selectedIndex].text;
        var ttq = document.getElementById(txtttqty).value
        document.getElementById(txtord).value = ttq;
        if (SelVal == "PCS") {

            document.getElementById(txtparam).value = "1";
        }
        else if (SelVal == "DOZ") {
            document.getElementById(txtparam).value = "12";
        }
        else {
            document.getElementById(txtparam).value = "";
        }
        var UnitParam = document.getElementById(txtUnitParam).value;
        var param = document.getElementById(txtparam).value;
        var com = document.getElementById(txtcomsum).value;
        var ordqty = document.getElementById(txtord).value;
        var wast = document.getElementById(txtwst).value;
        var comord = eval(com) * eval(ordqty);
        var Wastage;
        var withwast;
        var tl;
        var witt;

        if (parseFloat(wast) > 0) {
            Wastage = eval(wast);
            withwast = eval(comord) * eval(Wastage);
            tl = eval(withwast) / eval(100);
            witt = Math.round(eval(tl) + eval(comord), 2);
        }
        else {
            withwast = eval(comord);
            tl = eval(withwast);
            witt = Math.round(eval(tl), 2);
        }

        var tt = eval(witt) / eval(UnitParam);
        var totalReq = parseFloat(tt) / parseFloat(eval(param));
        var roundtotal = totalReq.toFixed(2);
        if (!isNaN(totalReq)) {
            document.getElementById(txtreq).value = roundtotal;
            //document.getElementById(txtActQty).value = roundtotal;
        }
        var rate = document.getElementById(txtRate).value;
        var _Uprice = 0;
        if (rate.length > 0) {
            _Uprice = rate;
        }
        var req = document.getElementById(txtreq).value;
        var WithoutFixed = (eval(totalReq) * eval(_Uprice));
        var val = WithoutFixed.toFixed(2);
        if (!isNaN(val)) {
            document.getElementById(txtvalue).value = val;
        }
        calcCmforQuickcosting(gridview, txtvalttl);
        EcostquickmCost(txtNoperhr, txtcostperhr, manufcst, txtvalttl, txtTtlcost, txtCommercialcost, txtBuyercomission, txtFreightcost, txtTtlfob, txtOther, txtqty, txtFobpc, txtFobdz, txtProfit, txtcommercialcstdlr, txtBuyercomissiondlr);   
      }

    function calcCmforQuickcosting(gridview,txtvalttl) {
        var ttval = 0;
        var gvDrv = document.getElementById(gridview);
        for (i = 1; i < gvDrv.rows.length; i++) {
            var l00pcell = gvDrv.rows[i].cells;
            var loopcellvalue = l00pcell[11].getElementsByTagName("input")[0].value;
            ttval = parseFloat(ttval) + parseFloat(loopcellvalue);
            //var looplastcellvalue = l00pcell[l00pcell.length - 1].getElementsByTagName("input")[0].value;
        }
        document.getElementById(txtvalttl).value = ttval.toFixed(4);
    }
    function ClickCommercialcost(txtTtlcost, txtCommercialcost, txtBuyercomission, txtFreightcost, txtTtlfob, txtOther, txtqty, txtFobpc, txtFobdz, txtcommercialcstdlr, txtBuyercomissiondlr) {
        var _xttcost = document.getElementById(txtTtlcost).value;
        var _xcomcost = document.getElementById(txtCommercialcost).value;
        var _xbircst = document.getElementById(txtBuyercomission).value;
        var _xfrtcst = document.getElementById(txtFreightcost).value;
        var _xother = document.getElementById(txtOther).value;
        var _yttcst = "0";
        var _ycomcost = "0";
        var _ybircst = "0";
        var _yfrtcst = "0";
        var _yother = "0";
        if (_xttcost.length > 0) {
            _yttcst = _xttcost;
        }
        if (_xcomcost.length > 0) {
            _ycomcost = _xcomcost;
        }
        if (_xbircst.length > 0) {
            _ybircst = _xbircst;
        }
        if (_xfrtcst.length > 0) {
            _yfrtcst = _xfrtcst;
        }
        if (_xother.length > 0) {
            _yother = _xother;
        }
        var _tCalcttlval = 0;
        var cmrclcst = (parseFloat(_xttcost) * parseFloat(_xcomcost)) / 100;
        var bircomsn = (parseFloat(_xttcost) * parseFloat(_xbircst)) / 100;
        if (!isNaN(cmrclcst)) {
            document.getElementById(txtcommercialcstdlr).value = cmrclcst.toFixed(4);
        }
        var _cmcst = document.getElementById(txtcommercialcstdlr).value;
        var _xcmcst = "0";
        if (_cmcst.length > 0) {
            _xcmcst = _cmcst;
        }
        if (!isNaN(bircomsn)) {
            document.getElementById(txtBuyercomissiondlr).value = bircomsn.toFixed(4);
        }
        var _brcmn = document.getElementById(txtBuyercomissiondlr).value;
        var _xbrcmn = "0";
        if (_brcmn.length > 0) {
            _xbrcmn = _brcmn;
        }
        _tCalcttlval = parseFloat(_yttcst) + parseFloat(_xcmcst) + parseFloat(_xbrcmn) + parseFloat(_yfrtcst) + parseFloat(_yother);
        if (!isNaN(_tCalcttlval)) {
            document.getElementById(txtTtlfob).value = _tCalcttlval.toFixed(4);
        }
        ecstingPc(txtqty, txtTtlfob, txtFobpc, txtFobdz);
    }
    function ecstingPc(txtqty, txtTtlfob, txtFobpc, txtFobdz) {        
        var _xtt = document.getElementById(txtTtlfob).value;
        var ttqty=document.getElementById(txtqty).value;        
        var _pc = 0;
        var _dz = 0;
        _pc = parseFloat(_xtt) / parseFloat(ttqty);
        if (!isNaN(_pc)) {
            document.getElementById(txtFobpc).value = _pc.toFixed(4);
        }
        _dz = _pc * 12;
        if (!isNaN(_dz)) {
            document.getElementById(txtFobdz).value = _dz.toFixed(4);
        }    
    }
    function Pchr(txtNoperhr, txtcostperhr, manufcst, ttStyleval, txtTtlcost, txtCommercialcost, txtBuyercomission, txtFreightcost, txtTtlfob, txtOther, txtqty, txtFobpc, txtFobdz, txtProfit, txtProfit)
    {
    var pcprhr=document.getElementById(txtNoperhr).value;
    var qty=document.getElementById(txtqty).value;
    if(pcprhr.length>0)
     {
        document.getElementById(txtProfit).value=((30/parseFloat(pcprhr))*parseFloat(qty)).toFixed(4);
        EcostquickmCost(txtNoperhr, txtcostperhr, manufcst, ttStyleval, txtTtlcost, txtCommercialcost, txtBuyercomission, txtFreightcost, txtTtlfob, txtOther, txtqty, txtFobpc, txtFobdz, txtProfit);
     }
    }
    function EcostquickmCost(txtNoperhr, txtcostperhr, manufcst, ttStyleval, txtTtlcost, txtCommercialcost, txtBuyercomission, txtFreightcost, txtTtlfob, txtOther, txtqty, txtFobpc, txtFobdz, txtProfit, txtcommercialcstdlr, txtBuyercomissiondlr) {
        document.getElementById(manufcst).value = "0";
        document.getElementById(txtTtlcost).value = "0";
        document.getElementById(txtProfit).value = "0";
        var noperhr = document.getElementById(txtNoperhr).value;
        var cstperhr = document.getElementById(txtcostperhr).value;
        var stvalttl = document.getElementById(ttStyleval).value;
        var ttl = 0;
        var prfit = 0;
        var orqty=document.getElementById(txtqty).value;
        if (noperhr.length > 0 && cstperhr.length > 0) {
            orqty = document.getElementById(txtqty).value;
            prfit = (30 / parseFloat(noperhr)) * parseFloat(orqty);
            document.getElementById(txtProfit).value = prfit.toFixed(4);
            //ttl = (parseFloat(cstperhr) / parseFloat(noperhr)) + prfit;
            ttl = ((parseFloat(cstperhr) / parseFloat(noperhr)) + (30/parseFloat(noperhr)))*parseFloat(orqty);
            document.getElementById(manufcst).value = ttl.toFixed(4);
            document.getElementById(txtTtlcost).value = (parseFloat(ttl) + parseFloat(stvalttl)).toFixed(4);
            ClickCommercialcost(txtTtlcost, txtCommercialcost, txtBuyercomission, txtFreightcost, txtTtlfob, txtOther, txtqty, txtFobpc, txtFobdz, txtcommercialcstdlr, txtBuyercomissiondlr);
       }
    }


    $(document).ready(function () {
        $(".btPOPUP").live("click", function () {
            $(".POPUPPanel").hide();
            var v = $(this).val();
            if (v == "Sub Category") {
                $(".POPUPHeaderText").html("Create Sub Category");
                $("#POPUPIFrame").attr("src", "Master_Setup/frmSupCategory.aspx?C=M");
            }
            if (v == "Construction") {
                $(".POPUPHeaderText").html("Create Construction/Article");
                $("#POPUPIFrame").attr("src", "Master_Setup/frmArticle.aspx?C=M");
            }
            if (v == "Dimension") {
                $(".POPUPHeaderText").html("Create Dimension");
                $("#POPUPIFrame").attr("src", "Master_Setup/frmDimension.aspx?C=M");
            }
            if (v == "Color") {
                $(".POPUPHeaderText").html("Create New Color");
                $("#POPUPIFrame").attr("src", "Master_Setup/frmColor.aspx");
            }

            if (v == "Copy BOM") {
                $(".POPUPHeaderText").html("Copy BOM");
                var SID = $("[id*='drpStyleno'] :selected").val();
                $("#POPUPIFrame").attr("src", "Master_Setup/frmBOMPaste.aspx?SSID=" + SID + "");
                $("#ContentPlaceHolder1_C1TabControl1_C1TabPage6_btnPasteBOM").attr("style", "display:none");

            }
            if (v == "Copy Estimate BOM") {
                $(".POPUPHeaderText").html("Copy BOM");
                var SID = $("[id*='drpStyleno'] :selected").val();
                $("#POPUPIFrame").attr("src", "Master_Setup/frmEstimateBOMCopy.aspx?SSID=" + SID + "");
                //$("#ContentPlaceHolder1_C1TabControl1_C1TabPage6_btnPasteBOM").attr("style", "display:none");
            }
            if (v == "Supplier") {
                $(".POPUPHeaderText").html("Add New Supplier");
                $("#POPUPIFrame").attr("src", "Master_Setup/frmSupplier.aspx");
            }
            //        if (v == "New") {
            //            $(".POPUPHeaderText").html("New");
            //            $("#POPUPIFrame").attr("src", "Master_Setup/frmSupplier.aspx");
            //        }   

            $(".POPUPPanel").toggle("slow");
            return false;
        });

        $(".POPUPClose").click(function () {
            $(".POPUPPanel").toggle("slow");
        });
        $(".timnew").live("click", function () {
            $(".ppr").toggle("slow");
            return false;
        });
        $(".gg").live("click", function () {
            $("#ifitmadd").attr("src", "Master_Setup/Bmitm.aspx");
            $(".tpitm").toggle("slow");
            return false;
        });
        $("#Button2").live("click", function () {
            $(".srvbtn").click();
            //$("#ifitmadd").attr("src", "Master_Setup/Bmitm.aspx");
            // $(".tpitm").toggle("slow");
            //return false;
        });
    });

//CALCULATE WHEN AUTOGENERATED SAVE
function CalculateActualQty(lblreqQty, txtAjsQty, lblActualqty, txtValue, txtRate) {
    var Total = 0;
    var ReqQty = document.getElementById(lblreqQty).value;
    var AjsQty = document.getElementById(txtAjsQty).value;
    var ActualQty = document.getElementById(lblActualqty).value;
    var Rat = document.getElementById(txtRate).innerText;
    document.getElementById(lblActualqty).value = ReqQty;
    var Rate = 0;
    if (Rat.length > 0) {
        Rate = Rat;
    }
    var sVal = ReqQty * Rate;
    document.getElementById(txtValue).value = sVal.toFixed(2);
    if (AjsQty.length > 0) {
        if (!isNaN(AjsQty)) {
            Total = parseFloat(ReqQty) + parseFloat(AjsQty);
            document.getElementById(lblActualqty).value = Total.toFixed(2);
            var ToralVal = Total * Rate;
            document.getElementById(txtValue).value = ToralVal.toFixed(2);
        }
    }
}

//CALCULATE WHEN BOM SAVE
function CalculateActualQty1(txtreqqty, txtAjsQty, txtactual,txtValue,txtRate) {
    var Total = 0;
    var ReqQty = document.getElementById(txtreqqty).value;
    var AjsQty = document.getElementById(txtAjsQty).value;
    document.getElementById(txtactual).value = ReqQty;
    var Rat = document.getElementById(txtRate).value;   
    var Rate = 0;
    if (Rat.length > 0) {
        Rate = Rat;
    }
    var sVal = ReqQty * Rate;
    document.getElementById(txtValue).value = sVal.toFixed(2);
    if (AjsQty.length > 0) {
        Total = parseFloat(ReqQty) + parseFloat(AjsQty);
        document.getElementById(txtactual).value = Total;
        var ToralVal = Total * Rate;
        document.getElementById(txtValue).value = ToralVal.toFixed(2);
    }
}

//GetUnitParameter
//function PageMethodGetParam(fn, Param, errorFn,ValueField) {
//    var pagePath = window.location.pathname;
//    $.ajax({
//        type: "POST",
//        url: pagePath + "/" + fn,
//        contentType: "application/json; charset=utf-8",
//        data: "{ unitCode: '" + Param + "'}",
//        dataType: "json",
//        success: function (result) {
//            $(ValueField).val(result.d);
//        },
//        error: errorFn
//    });
//}
//function AjaxFailed(result) {
//    alert("SERVICE Failed : " + result.d);
//}
//function GetUnitParam(dropdownlist, ValueField) {
//    PageMethodGetParam("getUnitConvertParam", $(dropdownlist).val(), AjaxFailed, ValueField);
//}      



