function calcmasterlcvalue1() {
    $("[id$='tbbunitpricedz']").val('0.000');
    var qty = $("[id$='txtordqty']").val();
    var uprice = $("[id$='txtUpriceset']").val();
    var qt = '0.000';
    var up = '0.000';
    if (qty.length > 0) {
        qt = qty;
    }
    if (uprice.length > 0) {
        up = uprice;
    }
    var tt = qt * up;
    if (parseFloat(tt) > 0) {
        $("[id$='tmstrlcvalue']").val(tt.toFixed(3));
    }
    else {
        $("[id$='tmstrlcvalue']").val("0.000");
    }
    var updz = parseFloat(up) * 12;
    if (parseFloat(updz) > 0) {
        $("[id$='tbbunitpricedz']").val(updz.toFixed(3));
    }
    else {
        $("[id$='tbbunitpricedz']").val("0.000");
    }
    $("[id$='tbballover']").val('0.000');
    $("[id$='tbballoverprc']").val('0.000');
    
}
function calculatedying1() {
    var dynfinishcon = '0.000';
    var dynfinishprce ='0.000';
    var dynfinishttl = '0.000';
    var _dynfinishcon = $("[id$='txtDyingconsm']").val();
    if (_dynfinishcon.length > 0) {
        dynfinishcon = _dynfinishcon;
    }
    var _dynfinishprce = $("[id$='txtDyinguprice']").val();
    if (_dynfinishprce.length > 0) {
        dynfinishprce = _dynfinishprce;
    }
    dynfinishttl = parseFloat(dynfinishcon) * parseFloat(dynfinishprce);
    $("[id$='txtDyingamnt']").val(dynfinishttl.toFixed(3));

    // washfinishing
    var wshfinishcon = '0.000';
    var washfinishup = '0.000';
    var washfinishttl = '0.000';
    var _wshfinishcon = $("[id$='txtWashconsm']").val();
    if (_wshfinishcon.length > 0) {
        wshfinishcon = _wshfinishcon;
    }

    var _washfinishup = $("[id$='txtwashuprice']").val();
    if (_washfinishup.length > 0) {
        washfinishup = _washfinishup;
    }
    washfinishttl = parseFloat(wshfinishcon) * parseFloat(washfinishup);
    $("[id$='txtwashfinishamt']").val(washfinishttl.toFixed(3));

    //yarndying charge
    var yrndyingcon = '0.000';
    var yrndyingup = '0.000';
    var yrndyingttl = '0.000';
    var _yrndyingcon = $("[id$='txtyarnconsm']").val();
    if (_yrndyingcon.length > 0) {
        yrndyingcon = _yrndyingcon;
    }

    var _yrndyingup = $("[id$='txtyarnuprice']").val();
    if (_yrndyingup.length > 0) {
        yrndyingup = _yrndyingup;
    }
    yrndyingttl = parseFloat(yrndyingcon) * parseFloat(yrndyingup);
    $("[id$='txtYrndyingamt']").val(yrndyingttl.toFixed(3));

    var totaldyingcharge = parseFloat(dynfinishttl) + parseFloat(washfinishttl) + parseFloat(yrndyingttl);
    $("[id$='txtTotaldyingcharge']").val(totaldyingcharge.toFixed(3));

    var yrnknig = '0.000';
    var _yrnknit = $("[id$='txtyarnknitting']").val();
    if (_yrnknit.length > 0) {
        yrnknig = _yrnknit;
    }


    var TOTALCOSTOFDYEDFAB = 0.000;
    TOTALCOSTOFDYEDFAB = parseFloat(yrnknig) + parseFloat(totaldyingcharge);
    $("[id$='txttotaldyingfabric']").val(TOTALCOSTOFDYEDFAB.toFixed(3));


    var qty = '0.000';
    var _qty = $("[id$='txtordqty']").val();
    if (_qty > 0) {
        qty = _qty;
    }

    var dyinnDZ = '0.000';
    dyinnDZ = (parseFloat(TOTALCOSTOFDYEDFAB) / parseFloat(qty)) * 12;
    if (parseFloat(dyinnDZ) > 0) {
        $("[id$='txtdcostdz']").val(dyinnDZ.toFixed(3));
    }
    else {
        $("[id$='txtdcostdz']").val('0.000');
    }
   
}

function Accris() {
    var Acris = '0.000';
    var _acris = $("[id$='txtAccess5percent']").val();
    if (_acris.length > 0) {
        Acris = _acris;
    }

    var grfac = '0.000';
    var _grfac = $("[id$='txtdcostdz']").val();
    if (_grfac.length > 0) {
        grfac = _grfac;
    }
    var ttlacs = parseFloat(Acris) + parseFloat(grfac);
    if (parseFloat(ttlacs) > 0) {
        $("[id$='txtGrandtotal']").val(ttlacs.toFixed(3));
    }
    else {
        $("[id$='txtGrandtotal']").val('0.000');
    }
   
}

function bblc() {
    var masterlcttl = '0.000';
    var _masterlc = $("[id$='tmstrlcvalue']").val();
    if (_masterlc.length > 0) {
        masterlcttl = _masterlc;
    }
    var yrn = '0.000';
    var _yrn = $("[id$='txtyearntotal']").val();
    if (_yrn.length > 0) {
        yrn = _yrn
    }
    if (parseFloat(yrn) > 0) {
        $("[id$='tbbyrn']").val(yrn);
    }
    else {
        $("[id$='tbbyrn']").val('0.000');
    }
   
    var yrnprcnt = '0.000';
    if (parseFloat(yrn) > 0) {
        yrnprcnt = (parseFloat(yrn) / parseFloat(masterlcttl)) * 100;
        $("[id$='tbbyrnprc']").val(yrnprcnt.toFixed(3));
    }
    else {
        $("[id$='tbbyrnprc']").val('0.000');
    }
    
  
    //knit
    var knitval = $("[id$='txtTotalknitting']").val();
    var _knitval = '0.000';
    var knitprnct = '0.000';
    if (knitval.length > 0) {
        _knitval = knitval;
    }
    if (parseFloat(_knitval) > 0) {
        $("[id$='tbbknit']").val(_knitval);
    }
    else {
        $("[id$='tbbknit']").val("0.000");
    }

    if (parseFloat(_knitval) > 0) {
        knitprnct = (parseFloat(_knitval) / parseFloat(masterlcttl)) * 100;
        $("[id$='tbbknitprc']").val(knitprnct.toFixed(3));
       
    }
    else {
        $("[id$='tbbknitprc']").val('0.000');
    }
   

//    //Accris
    var acrs = $("[id$='txtTtlaccesrs']").val();
    var _acrs = '0.000';
    var acrsprcnt = '0.000';
    if (acrs.length > 0) {
        _acrs = acrs;
    }
    $("[id$='tbbacc']").val('0.000');
    if (parseFloat(_acrs) > 0) {
        $("[id$='tbbacc']").val(_acrs);
        acrsprcnt = (parseFloat(_acrs) / parseFloat(masterlcttl)) * 100;
    }
    //alert("alkjd");
    if (parseFloat(acrsprcnt) > 0) {
        $("[id$='tbbaccprc']").val(acrsprcnt.toFixed(3));
    }
    else {
        $("[id$='tbbaccprc']").val("0.000");
    }
   
    
    //chemical and ete
    var dyfinish = '0.000';
    var _dyfinish = $("[id$='txtDyingamnt']").val();
    if (_dyfinish.length > 0) {
        dyfinish = _dyfinish;
    }
    var wfinish = '0.000';
    var _wfinish = $("[id$='txtwashfinishamt']").val();
    if (_wfinish.length > 0) {
        wfinish = _wfinish;
    }
    var chmcl = parseFloat(dyfinish) + parseFloat(wfinish);
    if (parseFloat(chmcl) > 0) {
        $("[id$='tbbdynchmicl']").val(chmcl.toFixed(3));
    }
    else {
        $("[id$='tbbdynchmicl']").val("0.000");
    }
   
    var chmclprc = '0.000';
    if (parseFloat(chmcl) > 0) {
        chmclprc = (parseFloat(chmcl) / parseFloat(masterlcttl)) * 100;
    }
    if (parseFloat(chmclprc) > 0) {
        $("[id$='tbbdynchmiclprc']").val(chmclprc.toFixed(3));
    }
    else {
        $("[id$='tbbdynchmiclprc']").val("0.000");
    }
//    //yrndying
    var ydcharge = '0.000';
    var _ydcharge = $("[id$='txtYrndyingamt']").val();
    if (_ydcharge.length > 0) {
        ydcharge = _ydcharge;
    }
    $("[id$='tbbyrnding']").val('0.000');
    var ydchrgprc = '0.000';
    if (parseFloat(ydcharge) > 0) {
        $("[id$='tbbyrnding']").val(ydcharge);
        ydchrgprc = (parseFloat(ydcharge) / parseFloat(masterlcttl)) * 100;
    }
    if (parseFloat(ydchrgprc) > 0) {
        $("[id$='tbbyrndingprc']").val(ydchrgprc.toFixed(3));
    }
    else {
        $("[id$='tbbyrndingprc']").val("0.000");
    }


    var ttlbblc = parseFloat(yrn) + parseFloat(_knitval) + parseFloat(_acrs) + parseFloat(chmcl) + parseFloat(ydcharge);
    if (parseFloat(ttlbblc) > 0) {
        $("[id$='tbbttl']").val(ttlbblc.toFixed(3));
    }
    else {
        $("[id$='tbbttl']").val("0.000");
    }
    var ttlbblcprc = parseFloat(yrnprcnt) + parseFloat(knitprnct) + parseFloat(acrsprcnt) + parseFloat(chmclprc) + parseFloat(ydchrgprc);
    if (parseFloat(ttlbblcprc) > 0) {
        $("[id$='tbbttlprc']").val(ttlbblcprc.toFixed(3));
    }
    else {
        $("[id$='tbbttlprc']").val("0.000");
    }
   
           
}

function fobval() {
    $("[id$='tFob']").val('0.000');
    var accs = '0.000';
    var _accs = $("[id$='txtGrandtotal']").val();
    if (_accs.length > 0) {
        accs = _accs;
    }

    var extfab = '0.000';
    var _extfab = $("[id$='txtExtrafabcost']").val();
    if (_extfab.length > 0) {
        extfab = _extfab;
    }
    var extaccr = '0.000';
    var _extaccr = $("[id$='texacccost']").val();
    if (_extaccr.length > 0) {
        extaccr = _extaccr;
    }
    var cmcst = '0.000';
    var _cmcst = $("[id$='tCm']").val();
    if (_cmcst.length > 0) {
        cmcst = _cmcst;
    }
    var emb = '0.000';
    var _emb = $("[id$='tEmbdry']").val();
    if (_emb.length > 0) {
        emb = _emb;
    }
    var prnt = '0.000';
    var _prnt = $("[id$='tPrnt']").val();
    if (_prnt.length > 0) {
        prnt = _prnt;
    }
    var wsh = '0.000';
    var _wsh = $("[id$='tWsh']").val();
    if (_wsh.length > 0) {
        wsh = _wsh;
    }
    var ttl = parseFloat(accs) + parseFloat(extaccr) + parseFloat(extfab) + parseFloat(cmcst) + parseFloat(emb) + parseFloat(prnt) + parseFloat(wsh);
    if (parseFloat(ttl) > 0) {
        $("[id$='tFob']").val(ttl.toFixed(3));
    }
    else {
        $("[id$='tFob']").val('0.000');
    }
   

    var costperdz = parseFloat(accs) + parseFloat(prnt) + parseFloat(wsh);
    if (parseFloat(costperdz) > 0) {
        $("[id$='tcostdz']").val(costperdz.toFixed(3));
    }
    else {
        $("[id$='tcostdz']").val('0.000');
    }
}

function others()
{

    var upperdz = '0.000';
    var _updz = $("[id$='tbbunitpricedz']").val();
    if (_updz.length > 0) {
        upperdz = _updz;
    }
    var cstdz = '0.000';
    var _cstdz = $("[id$='tcostdz']").val();
    if (_cstdz.length > 0) {
        cstdz = _cstdz;
    }
    var cmdz = parseFloat(upperdz) - parseFloat(cstdz);
    if (parseFloat(cmdz) > 0) {
        $("[id$='tcmperdzprcnt']").val(cmdz.toFixed(3));
        $("[id$='tCm']").val(cmdz.toFixed(3));
    }

    var qty = '0.000';
    var _qty = $("[id$='txtordqty']").val();
    if (_qty.length > 0) {
        qty = _qty;
    }
    var cmm = (parseFloat(qty) / 12) * parseFloat(cmdz);
    $("[id$='tcmperdz']").val(cmm.toFixed(3));
    var cmperset = parseFloat(cmdz) / 12;
    $("[id$='tcostset']").val(cmperset.toFixed(3));

    var tk = '0.000';
    var _tk = $("[id$='cmtk']").val();
    if (_tk.length > 0) {
        tk = _tk;
    }
    var convrt = parseFloat(cmperset) * parseFloat(_tk);
    if (!isNaN(convrt)) {
        $("[id$='tcostsettk']").val(convrt.toFixed(3));
    }


}
function gangnumstyle() {
    var mstrlcval = $("[id$='tmstrlcvalue']").val();
    var mstrlc = '1.000';
    if (mstrlcval.length > 0) {
        mstrlc = mstrlcval;
    }   
    var prevprclossttl = '0.000';
    var prcsttl = $("[id$='txtamntporcessloss']").val();
    if (prcsttl.length > 0) {
        prevprclossttl = prcsttl;
        $("[id$='txtamntporcessloss']").val('0.000');
    }
    var ttl = $("[id$='tPlossconsttl']").val();
    var _ttl = '0.000';
    if (ttl.length > 0) {
        _ttl = ttl;
    }
    var up = $("[id$='txtupporcessloss']").val();
    var _up = '0.000';
    if (up.length > 0) {
        _up = up;
    }
    var _yrt = $("[id$='txtyearntotal']").val();
    var yrt = '0.000';
    if (_yrt.length > 0) {
        yrt = _yrt;
    }

    var _prcnt = $("[id$='txtupporcesslossprcnt']").val();
    var prcnt = '0.000';
    if (_prcnt.length > 0) {
        prcnt = _prcnt
    }
    var calc = (parseFloat(_ttl) / 100) * parseFloat(prcnt);
    if (parseFloat(calc) > 0) {
        $("[id$='txtconsprocessloss']").val(calc.toFixed(3));
    }
    else {
        $("[id$='txtconsprocessloss']").val("0.000");
    }
    var amnt = parseFloat(calc) * parseFloat(_up);
    var prlosscalcamt = parseFloat(yrt) - parseFloat(prevprclossttl);
    if (parseFloat(amnt) > 0) {
        $("[id$='txtamntporcessloss']").val(amnt.toFixed(3));
    }
    else {
        $("[id$='txtamntporcessloss']").val("0.000");
    }
    var yrnttl = parseFloat(amnt) + parseFloat(prlosscalcamt);
    if (parseFloat(yrnttl) > 0) {
        $("[id$='txtyearntotal']").val(yrnttl.toFixed(3));
    }
    else {
        $("[id$='txtyearntotal']").val("0.000");
    }
    //knitting
    var knitttl = $("[id$='txtTotalknitting']").val();
    var _ntttl = '0.000';
    if (knitttl.length > 0) {
        _ntttl = knitttl;
    }
    //YARN KNIT TOTAL
    var _yrnknit = parseFloat(yrnttl) + parseFloat(_ntttl);
    if (parseFloat(_yrnknit) > 0) {
        $("[id$='txtyarnknitting']").val(_yrnknit.toFixed(3));
    }
    else {
        $("[id$='txtyarnknitting']").val("0.000");
    }

   

            


}
function yarn() {
    var _yrt = $("[id$='txtyearntotal']").val();
    var yrt = '0.000';
    if (_yrt.length > 0) {
        yrt = _yrt;
    }
    var _processamt = $("[id$='txtamntporcessloss']").val();
    var processamnt = '0.000';
    if (_processamt.length > 0) {
        processamnt = _processamt;
    }
    var ttl = parseFloat(yrt) + parseFloat(processamnt);
    $("[id$='txtyearntotal']").val(ttl.toFixed(3));

    //KNITTING
    var _knt = '0.000';
    var knt = $("[id$='txtyearntotal']").val();
    if (knt.length > 0) {
        _knt = knt;
    }
    var yrnknit = parseFloat(ttl) + parseFloat(_knt);
    $("[id$='txtyarnknitting']").val(yrnknit.toFixed(3));
}

function Callttl() {
    gangnumstyle();   
    calcmasterlcvalue1();   
    calculatedying1();
    Accris();
    bblc();
    others();
    fobval();


}
function edit(lbltype, txtdesc, txtfabcon, txtprcnt, txtcons, txtunit, txtunitprice, txtamount, lblttlcost, txtsuptype, txtunitparam, lblsl) {

    $("[id$='drpConsunit']").val("0");
    $("[id$='drpSuppliertype']").val("0");
    //$("[id$='drpConsunit']").attr("disabled", "disabled");
    //$("[id$='txtpercent']").attr("disabled", "disabled");
    $("[id$='txtpercent']").val('');
    //$("[id$='txtFabconsm']").attr("disabled", "disabled");
   // $("[id$='txtConsumption']").attr("disabled", "disabled");
   // $("[id$='txtuprice']").attr("disabled", "disabled");
    $("[id$='txtFabconsm']").val('');
    $("[id$='txtConsumption']").val('');
    $("[id$='txtuprice']").val('');
    $("[id$='txtAmount']").val('');
    $("[id$='txtunitparam']").val('');
    var type = $("[id$='" + lbltype + "']").text();
    var desc = $("[id$='" + txtdesc + "']").text();
    var fabcon = $("[id$='" + txtfabcon + "']").text();
    var fabprcnt = $("[id$='" + txtprcnt + "']").text();
    var cons = $("[id$='" + txtcons + "']").text();
    var units = $("[id$='" + txtunit + "']").text();
    var unitparam = $("[id$='" + txtunitparam + "']").val();
    var unitprice = $("[id$='" + txtunitprice + "']").text();
    var suptype = $("[id$='" + txtsuptype + "']").text();
    var Amount = $("[id$='" + txtamount + "']").text();
    var ttlcost = $("[id$='" + lblttlcost + "']").text();
    var gsl = $("[id$='" + lblsl + "']").text();

    $("[id$='Tyarnttl']").val(Amount);

    $("[id$='drpType']").val(type);
    $("[id$='txtDescription']").val(desc);
    $("[id$='txtFabconsm']").val(fabcon);
    $("[id$='txtpercent']").val(fabprcnt);
    $("[id$='txtConsumption']").val(cons);
    $("[id$='txtuprice']").val(unitprice);
    $("[id$='txtAmount']").val(Amount);
    $("[id$='txtTotalcost']").val(ttlcost);
    $("[id$='txtunitparam']").val(unitparam);
    $("[id$='drpSuppliertype']").val(suptype);
    $("[id$='drpConsunit']").val(units);
    $("[id$='txtorno']").val(gsl);
    var SID = $("[id*='drpType'] :selected").val();
//    if (SID.length > 0) {
//        if (SID == 'YARN') {
//            $("[id$='txtpercent']").removeAttr("disabled");
//            $("[id$='txtFabconsm']").removeAttr("disabled");
//            $("[id$='txtConsumption']").attr("disabled", "disabled");

//        }
//        ///yarn
//        if (SID == 'KNITTING') {
//            $("[id$='txtConsumption']").attr("disabled", "disabled");
//            $("[id$='txtpercent']").attr("disabled", "disabled");
//            $("[id$='txtFabconsm']").removeAttr("disabled");
//        }

//        if (SID == 'FABRIC') {
//            $("[id$='txtConsumption']").removeAttr("disabled");
//            $("[id$='drpConsunit']").attr("disabled", "disabled");
//            $("[id$='drpSuppliertype']").attr("disabled", "disabled");
//            $("[id$='txtpercent']").attr("disabled", "disabled");
//            $("[id$='txtFabconsm']").attr("disabled", "disabled");
//        }
//        if (SID == 'ACCESSORIES') {
//            $("[id$='drpConsunit']").removeAttr("disabled");
//            $("[id$='txtConsumption']").removeAttr("disabled");
//            $("[id$='drpSuppliertype']").removeAttr("disabled");
//        }
//        $("[id$='txtuprice']").removeAttr("disabled");
//    }



}
function vdtlreq(tval) {
    onunload();
    document.getElementById("txtchkjv").value = "1";
    $("#hdrtxt").html("Details");
    $("#ifupldfile").attr("src", "Report_Merchandising/MECview.aspx?x=" + tval + "");
    var bid = $find('ppadditm');
    bid.show();
    //alert("shalkayen H Islam");
}
function Mcs_rpt(tval) {
    onunload();
    document.getElementById("txtchkjv").value = "1";
    $("#hdrtxt").html("Details");
    $("#ifupldfile").attr("src", "Report_Merchandising/MCS_Rpt.aspx?x=" + tval + "");
    var bid = $find('ppadditm');
    bid.show();
    //alert("shalkayen H Islam");
}
function Mcs_addimg() {
    var val = $("[id$='txtStyle']").val();
    if (val.length > 0) {
        onunload();
        document.getElementById("txtchkjv").value = "3";
        $("#hdrtxt").html("Add Image");

        $("#ifupldfile").attr("src", "Master_Setup/nazcostimg.aspx?x=" + val + "");
        var bid = $find('ppadditm');
        bid.show();
    }
    else {
        alert("Enter Style First");
     }
    //alert("shalkayen H Islam");
}
function refreshgpo() {
    var val = document.getElementById("txtchkjv").value;
    if (val == "3") {
        var ss = $("[id$='txtimgsrc']").val();
        $("[id$='txtimgslno']").val(ss);
        $("[id$='imgStyle']").attr("src", "StyleFile/" + ss);
        //$("#my_image").attr("src", "second.jpg");
        //document.getElementById("Image1").src = "images/ky.png";
        
       
    }    
    onunload();
}


function hideLoading() {
    document.getElementById('divLoading').style.display = "none";
    document.getElementById('divFrameHolder').style.display = "block";
}
function onunload() {
    document.getElementById('divLoading').style.display = "block";
    document.getElementById('divFrameHolder').style.display = "none";
}
function ttlcal(cnsom, txtuprice, txtamount) {
    var consval = $("[id$='" + cnsom + "']").val();
    var uprice = $("[id$='" + txtuprice + "']").val();
    var cons = 0;
    var upc = 0;
    if (consval.length > 0) {
        cons = consval;
    }
    if (uprice.length > 0) {
        upc = uprice;
    }
    var ttl = 0;
    ttl = parseFloat(cons) * parseFloat(upc);
    if (!isNaN(ttl)) {
        $("[id$='" + txtamount + "']").val(ttl.toFixed(3));
    }
}
function calculateamount(txtconsumption, txtunitprce, txtamount, txtunitparam) {
    var SID = $("[id*='drpType'] :selected").val();
    if (SID.length > 0) {
        if (SID == 'YARN') {
            ttlcal(txtconsumption, txtunitprce, txtamount);
        }
        if (SID == 'KNITTING') {
            ttlcal(txtconsumption, txtunitprce, txtamount);
        }
        if (SID == 'FABRIC') {
            ttlcal(txtconsumption, txtunitprce, txtamount);
        }
        if (SID == 'ACCESSORIES') {
            var consval = $("[id$='" + txtconsumption + "']").val();
            var uprice = $("[id$='" + txtunitprce + "']").val();
            // var uparam = $("[id$='" + txtunitparam + "']").val();
            var cons = 0;
            var upc = 0;
            if (consval.length > 0) {
                cons = consval;
            }
            if (uprice.length > 0) {
                upc = uprice;
            }
            var ttl = 0;
            ttl = parseFloat(cons) * parseFloat(upc);
            if (!isNaN(ttl)) {
                $("[id$='" + txtamount + "']").val(ttl.toFixed(3));
                var ordqty = $("[id$='txtordqty']").val();
                var ttcost = (parseFloat(ordqty) / 12) * parseFloat(ttl) * 1.05;
                $("[id$='txtTotalcost']").val(ttcost.toFixed(3));
                // txtTotalcost
            }
        }
    }
}




function gettype(fabcons, prcnt, cnsom, txtordqty, totqty, txtuprice, txtamount) {
    var SID = $("[id*='drpType'] :selected").val();
    $("[id$='" + txtamount + "']").val("0");
    $("[id$='" + totqty + "']").val("0");
    var fabriccons = document.getElementById(fabcons).value;
    var parc = document.getElementById(prcnt).value;
    var ordqty = document.getElementById(txtordqty).value;
    if (SID.length > 0) {
        if (SID == 'YARN') {
            var sttl = 0;
            if (parc.length > 0) {
                var total = (parseFloat(ordqty) / 12) * parseFloat(fabriccons);
                var prcent = (parseFloat(total) * parseFloat(parc)) / 100;
                //sttl = total + prcent;
                if (!isNaN(prcent)) {
                    document.getElementById(cnsom).value = prcent.toFixed(3);
                }
            }
            else {
                var tot = (parseFloat(ordqty) / 12) * parseFloat(fabriccons);
                document.getElementById(cnsom).value = tot.toFixed(3);
            }
            ttlcal(cnsom, txtuprice, txtamount);

        }
        ///yarn
        if (SID == 'KNITTING') {
            var prcent = (parseFloat(ordqty) / 12) * parseFloat(fabriccons);
            document.getElementById(cnsom).value = prcent.toFixed(3);
            ttlcal(cnsom, txtuprice, txtamount);
        }

        if (SID == 'FABRIC') {
            var cons = $("[id$='" + cnsom + "']").val();
            var cns = 0;
            if (cons.length > 0) {
                cns = cons;
            }
            var prc = $("[id$='" + txtuprice + "']").val();
            var upr = 0;
            if (pre.length > 0) {
                upr = prc;
            }
            var tl = parseFloat(cns) * parseFloat(upr);
            $("[id$='" + txtamount + "']").val(tl.toFixed(3));

        }
        if (SID == 'ACCESSORIES') {
            // var unittst = $("[id*='drpConsunit'] :selected").text();
            // if (unittst != '-') {
            var consval = $("[id$='" + cnsom + "']").val();
            var uprice = $("[id$='" + txtuprice + "']").val();
            //var uparam = $("[id$='txtunitparam']").val();
            var cons = 0;
            var upc = 0;
            if (consval.length > 0) {
                cons = consval;
            }
            if (uprice.length > 0) {
                upc = uprice;
            }
            var ttl = 0;
            ttl = parseFloat(cons) * parseFloat(upc);
            if (!isNaN(ttl)) {
                $("[id$='" + txtamount + "']").val(ttl.toFixed(3));
                var ordqty = $("[id$='txtordqty']").val();
                var ttcost = (parseFloat(ordqty) / 12) * parseFloat(ttl) * 1.05;
                $("[id$='txtTotalcost']").val(ttcost.toFixed(3));
                //                          var ordqty = $("[id$='"+ordqty+"']").val();
                //                          var ttcost = (parseFloat(ordqty) / 12) * parseFloat(ttl) * 1.05;
                //                          $("[id$='"+totqty+"']").val(ttcost.toFixed(2));
            }
            // }                   
        }
    }
}

function drptype(fabcons, prcnt, cnsom, txtordqty, totqty, txtuprice, txtamount) {
    $("[id$='drpConsunit']").val("0");
    $("[id$='drpSuppliertype']").val("0");
   // $("[id$='drpConsunit']").attr("disabled", "disabled");
   // $("[id$='" + prcnt + "']").attr("disabled", "disabled");
    $("[id$='" + prcnt + "']").val('');
   // $("[id$='" + fabcons + "']").attr("disabled", "disabled");
   // $("[id$='" + cnsom + "']").attr("disabled", "disabled");
   // $("[id$='" + txtuprice + "']").attr("disabled", "disabled");
    $("[id$='" + fabcons + "']").val('');
    $("[id$='" + cnsom + "']").val('');
    $("[id$='" + txtuprice + "']").val('');
    $("[id$='" + txtamount + "']").val('');
    $("[id$='" + totqty + "']").val('');
    $("[id$='txtunitparam']").val('');
    var qty = $("[id$='txtordqty']").val();
    if (qty.length > 0) {
//        var SID = $("[id*='drpType'] :selected").val();

//        if (SID.length > 0) {
//            if (SID == 'YARN') {
//                $("[id$='" + prcnt + "']").removeAttr("disabled");
//                $("[id$='" + fabcons + "']").removeAttr("disabled");

//                $("[id$='" + cnsom + "']").attr("disabled", "disabled");
//            }
//            ///yarn
//            if (SID == 'KNITTING') {
//                $("[id$='" + cnsom + "']").attr("disabled", "disabled");
//                $("[id$='" + prcnt + "']").attr("disabled", "disabled");
//                $("[id$='" + fabcons + "']").removeAttr("disabled");
//            }

//            if (SID == 'FABRIC') {
//                $("[id$='" + cnsom + "']").removeAttr("disabled");
//                $("[id$='drpConsunit']").attr("disabled", "disabled");
//                $("[id$='drpSuppliertype']").attr("disabled", "disabled");
//                $("[id$='" + prcnt + "']").attr("disabled", "disabled");
//                $("[id$='" + fabcons + "']").attr("disabled", "disabled");
//            }
//            if (SID == 'ACCESSORIES') {
//                $("[id$='drpConsunit']").removeAttr("disabled");
//                $("[id$='" + cnsom + "']").removeAttr("disabled");
//                $("[id$='drpSuppliertype']").removeAttr("disabled");
//            }
//            $("[id$='" + txtuprice + "']").removeAttr("disabled");
//        }
    }
    else {
        alert("First Enter Qty");
        $("[id$='drpType']").val("0");
    }
}