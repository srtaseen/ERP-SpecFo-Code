
function Allinone() {
    var ordqty = $("[id$='txtOrdqty']").val();
    if (ordqty.length > 0) {
        if (parseFloat(ordqty) > 0) {          
           Calculateamount();
           commercialbank();
           Buyercommission();
           Tastingcharge();
           Cnfcost();                   
           totalbblc();
           totalbblcprcnt();
           other();
           totalcostfinal();
          // totalcostfinaldz();
           dyedfabkg();
           totaloutside();
           totalInside();
           insideprcnt();
           //CNFValuePerDozen();
           cmperdz();
        }       
    }
}


function Calculateamount() {
    var ordqty = $("[id$='txtOrdqty']").val();
    //$("[id$='txtGmtQty']").val('');
//    if (ordqty.length > 0) {
//        $("[id$='txtGmtQty']").val(ordqty);
//    }

//    var gm = $("[id$='txtGmtQty']").val();
//    if (gm.length > 0) {
//        //
//    }
//    else {
//        $("[id$='txtGmtQty']").val(ordqty);
//    }
    var gmtqty = $("[id$='txtGmtQty']").val();
    var consumption = $("[id$='txtConsumption']").val();
    var unitprice = $("[id$='txtUnitprice']").val();
    var amnt = 0;
    amnt = parseFloat(consumption) * parseFloat(unitprice);   
    var reqqty = 0;
    var prcnt = $("[id$='txtPercent']").val();
    reqqty = ((parseFloat(gmtqty) / 12) * parseFloat(consumption));
    if (prcnt.length > 0) {
        if (parseFloat(prcnt) > 0) {
            var percent = ((parseFloat(consumption) / 100)) * prcnt;
            reqqty = ((parseFloat(gmtqty) / 12) * parseFloat(percent));
            amnt = parseFloat(percent) * parseFloat(unitprice);
        }
    }
    if (!isNaN(amnt)) {
        $("[id$='txtAmount']").val(amnt.toFixed(2));
    }
    if (!isNaN(reqqty)) {
        $("[id$='txtReqqty']").val(reqqty.toFixed(2));
    }
    var totalcost1 = parseFloat(reqqty) * parseFloat(unitprice);
    
    if (!isNaN(totalcost1)) {
        $("[id$='txtTotalcost']").val(totalcost1.toFixed(2));
    }
    var mstrlcval = 0;
    var unitprice = $("[id$='tUnitprice']").val();
    mstrlcval = parseFloat(ordqty) * parseFloat(unitprice);
    $("[id$='tMasterlcval']").val('');
    if (!isNaN(mstrlcval)) {
        $("[id$='tMasterlcval']").val(mstrlcval.toFixed(2));
    }
    var upperdz = parseFloat(unitprice) * 12;
    $("[id$='tUpriceperdz']").val('');
    if (!isNaN(upperdz)) {
        $("[id$='tUpriceperdz']").val(upperdz.toFixed(2));
        //$("[id$='tCnfperdz']").val(upperdz.toFixed(2));
    }
}

function Calculateamount1() {    
    var gmtqty = $("[id$='txtGmtQty']").val();
    var consumption = $("[id$='txtConsumption']").val();
    var unitprice = $("[id$='txtUnitprice']").val();
    var amnt = 0;
    amnt = parseFloat(consumption) * parseFloat(unitprice);
    var reqqty = 0;
    var prcnt = $("[id$='txtPercent']").val();
    reqqty = ((parseFloat(gmtqty) / 12) * parseFloat(consumption));
    if (prcnt.length > 0) {
        if (parseFloat(prcnt) > 0) {
            var percent = ((parseFloat(consumption) / 100)) * prcnt;
            reqqty = ((parseFloat(gmtqty) / 12) * parseFloat(percent));
            amnt = parseFloat(percent) * parseFloat(unitprice);
        }
    }
    if (!isNaN(amnt)) {
        $("[id$='txtAmount']").val(amnt.toFixed(2));
    }
    if (!isNaN(reqqty)) {
        $("[id$='txtReqqty']").val(reqqty.toFixed(2));
    }
    var totalcost1 = parseFloat(reqqty) * parseFloat(unitprice);

    if (!isNaN(totalcost1)) {
        $("[id$='txtTotalcost']").val(totalcost1.toFixed(2));
    }
   
}
  function commercialbank() {
      $("[id$='tCommercialbnkamtttl']").val('');
      $("[id$='tLCcommercialbnk']").val('');
      $("[id$='tLCcommercialbnkprcnt']").val('');
    var ordqty = $("[id$='txtOrdqty']").val();
    var combankamt = $("[id$='tCommercialbnkamt']").val();
    var combankttl = ((parseFloat(ordqty) / 12) * parseFloat(combankamt));
    if (!isNaN(combankttl)) {
        $("[id$='tCommercialbnkamtttl']").val(combankttl.toFixed(2));
        $("[id$='tLCcommercialbnk']").val(combankttl.toFixed(2));
    }
     var mlcval = $("[id$='tMasterlcval']").val();
     var blcprcnt = (parseFloat(combankttl) / parseFloat(mlcval)) * 100;
     if (!isNaN(blcprcnt)) {
         $("[id$='tLCcommercialbnkprcnt']").val(blcprcnt.toFixed(2));
     } 

}
function Buyercommission() {
    $("[id$='tBuyercommissionttl']").val('');
    $("[id$='tLcbuyercommission']").val('');
    $("[id$='tLcbuyercommissionprcnt']").val('');
    var ordqty = $("[id$='txtOrdqty']").val();
    var Buyercommission = $("[id$='tBuyercommission']").val();
    var Buyercomttl = ((parseFloat(ordqty) / 12) * parseFloat(Buyercommission));
    if (!isNaN(Buyercomttl)) {
        $("[id$='tBuyercommissionttl']").val(Buyercomttl.toFixed(2));
        $("[id$='tLcbuyercommission']").val(Buyercomttl.toFixed(2));
    }

    var mlcval = $("[id$='tMasterlcval']").val();
    var blcprcnt = (parseFloat(Buyercomttl) / parseFloat(mlcval)) * 100;
    if (!isNaN(blcprcnt)) {
        $("[id$='tLcbuyercommissionprcnt']").val(blcprcnt.toFixed(2));
    }
    
}
function Tastingcharge() {
    $("[id$='tTestingchargettl']").val('');
    $("[id$='tLctstingcharge']").val('');
    $("[id$='tLctstingchargeprcnt']").val('');
    var ordqty = $("[id$='txtOrdqty']").val();
    var tstingcharge = $("[id$='tTestingchargeamt']").val();
    var tstingchrgttl = ((parseFloat(ordqty) / 12) * parseFloat(tstingcharge));
    if (!isNaN(tstingchrgttl)) {
        $("[id$='tTestingchargettl']").val(tstingchrgttl.toFixed(2));
        $("[id$='tLctstingcharge']").val(tstingchrgttl.toFixed(2));
    }

    var mlcval = $("[id$='tMasterlcval']").val();
    var blcprcnt = (parseFloat(tstingchrgttl) / parseFloat(mlcval)) * 100;
    if (!isNaN(blcprcnt)) {
        $("[id$='tLctstingchargeprcnt']").val(blcprcnt.toFixed(2));
    }
 }
 function Cnfcost() {
     $("[id$='tCnfttl']").val('');
     $("[id$='tLCcnf']").val('');
     $("[id$='tLCcnfprcnt']").val('');
    var ordqty = $("[id$='txtOrdqty']").val();
    var cnfamt = $("[id$='tCnfamt']").val();
    var cnfttl = ((parseFloat(ordqty) / 12) * parseFloat(cnfamt));
    if (!isNaN(cnfttl)) {
        $("[id$='tCnfttl']").val(cnfttl.toFixed(2));
        $("[id$='tLCcnf']").val(cnfttl.toFixed(2));
    }

    var mlcval = $("[id$='tMasterlcval']").val();
    var blcprcnt = (parseFloat(cnfttl) / parseFloat(mlcval)) * 100;
    if (!isNaN(blcprcnt)) {
        $("[id$='tLCcnfprcnt']").val(blcprcnt.toFixed(2));
    }
  
}
function CNFValuePerDozen() {
//    $("[id$='tCnfperdz']").val('');
//    var exfab = $("[id$='tExfabcost']").val();
//    var exacc = $("[id$='tExacccost']").val();
//    var cm = $("[id$='tCostofmacking']").val();
//    var combank = $("[id$='tCommercialbnkamt']").val();
//    var buyercom = $("[id$='tBuyercommission']").val();
//    var tstingchrg = $("[id$='tTestingchargeamt']").val();
//    var cnf = $("[id$='tCnfamt']").val();
//    var _exfab = 0;
//    var _exacc = 0;
//    var _cm = 0;
//    var _combank = 0;
//    var _buyercom = 0;
//    var _tstingchrg = 0;
//    var _cnf = 0;
//    if (exfab.length > 0) {
//        _exfab = exfab;
//    }
//    if (exacc.length > 0) {
//        _exacc = exacc;
//    }
//    if (cm.length > 0) {
//        _cm = cm;
//    }
//    if (combank.length > 0) {
//        _combank = combank;
//    }
//    if (buyercom.length > 0) {
//        _buyercom = buyercom;
//    }
//    if (tstingchrg.length > 0) {
//        _tstingchrg = tstingchrg;
//    }
//    if (cnf.length > 0) {
//        _cnf = cnf;
//    }
//    var cnfperdz = parseFloat(_buyercom) + parseFloat(_cm) + parseFloat(_cnf) + parseFloat(_combank) + parseFloat(_exacc) + parseFloat(_exfab) + parseFloat(_tstingchrg);
    //    $("[id$='tCnfperdz']").val(cnfperdz.toFixed(2));
   // var totalcostdz = $("[id$='tTotalcostdz']").val();
   // var costofmak = $("[id$='tCostofmacking']").val();
   // var fobperdz = parseFloat(totalcostdz) + parseFloat(costofmak);
   // if (!isNaN(fobperdz)) {
//        $("[id$='tCnfperdz']").val(fobperdz.toFixed(2));
//    }
}

function totalbblc() {
    var yrn = $("[id$='tLcyarn']").val();
    var knt = $("[id$='tLcknit']").val();
    var acc = $("[id$='tLCaccessories']").val();
    var dynin = $("[id$='tLCdyinginside']").val();
    var dynout = $("[id$='tLcdyingoutside']").val();
    var embd = $("[id$='tLCprintembdry']").val();
    var tstchrg = $("[id$='tLctstingcharge']").val();
    var cnf = $("[id$='tLCcnf']").val();
    var byrcom = $("[id$='tLcbuyercommission']").val();
    var combank = $("[id$='tLCcommercialbnk']").val();
    var fabric = $("[id$='tLcFabric']").val();

    var _yrn = 0;
    var _knt = 0;
    var _acc = 0;
    var _dynin = 0;
    var _dynout = 0;
    var _embd = 0;
    var _tstchrg = 0;
    var _cnf = 0;
    var _byrcom = 0;
    var _combank = 0;
    var _fabric = 0;
    
    if (yrn.length > 0) {
        _yrn = yrn;
    }
    if (knt.length > 0) {
        _knt = knt;
    }
    if (acc.length > 0) {
        _acc = acc;
    }
    if (dynin.length > 0) {
        _dynin = dynin;
    }
   //
    if (dynout.length > 0) {
        _dynout = dynout;
    }
    if (embd.length > 0) {
        _embd = embd;
    }
    if (tstchrg.length > 0) {
        _tstchrg = tstchrg;
    }
    
    if (cnf.length > 0) {
        _cnf = cnf;
    }
    if (byrcom.length > 0) {
        _byrcom = byrcom;
    }
    if (combank.length > 0) {
        _combank = combank;
    }
    if (fabric.length > 0) {
        _fabric = fabric;
    }

    var totalmlc = parseFloat(_yrn) + parseFloat(_knt) + parseFloat(_acc) + parseFloat(_dynin) + parseFloat(_dynout) + parseFloat(_embd) + parseFloat(_tstchrg) + parseFloat(_cnf) + parseFloat(_byrcom) + parseFloat(_combank)+parseFloat(_fabric);
    if (!isNaN(totalmlc)) {
        $("[id$='tbblcttlval']").val(totalmlc.toFixed(2));
    }
    var masterlcval=$("[id$='tMasterlcval']").val();
    var ttlinhandval = parseFloat(masterlcval) - parseFloat(totalmlc);
    if (!isNaN(ttlinhandval)) {
        $("[id$='tbblcinhand']").val(ttlinhandval.toFixed(2));        
    }
}

function totalbblcprcnt() {
    var yrn = $("[id$='tLcyarnprcnt']").val();
    var knt = $("[id$='tLcknitprcnt']").val();
    var acc = $("[id$='tLCaccessoriesprcnt']").val();
    var dynin = $("[id$='tLCdyinginsideprcnt']").val();
    var dynout = $("[id$='tLcdyingoutsideprcnt']").val();
    var embd = $("[id$='tLCprintembdryprcnt']").val();
    var tstchrg = $("[id$='tLctstingchargeprcnt']").val();
    var cnf = $("[id$='tLCcnfprcnt']").val();
    var byrcom = $("[id$='tLcbuyercommissionprcnt']").val();
    var combank = $("[id$='tLCcommercialbnkprcnt']").val();
    var Fabric = $("[id$='tLcFabricprcent']").val();
    var _yrn = 0;
    var _knt = 0;
    var _acc = 0;
    var _dynin = 0;
    var _dynout = 0;
    var _embd = 0;
    var _tstchrg = 0;
    var _cnf = 0;
    var _byrcom = 0;
    var _combank = 0;
    var _Fabric = 0;

    if (yrn.length > 0) {
        _yrn = yrn;
    }
    if (knt.length > 0) {
        _knt = knt;
    }
    if (acc.length > 0) {
        _acc = acc;
    }
    if (dynin.length > 0) {
        _dynin = dynin;
    }
    //
    if (dynout.length > 0) {
        _dynout = dynout;
    }
    if (embd.length > 0) {
        _embd = embd;
    }
    if (tstchrg.length > 0) {
        _tstchrg = tstchrg;
    }

    if (cnf.length > 0) {
        _cnf = cnf;
    }
    if (byrcom.length > 0) {
        _byrcom = byrcom;
    }
    if (combank.length > 0) {
        _combank = combank;
    }
    if (Fabric.length > 0) {
        _Fabric = Fabric;
    }



    var totalmlc = parseFloat(_yrn) + parseFloat(_knt) + parseFloat(_acc) + parseFloat(_dynin) + parseFloat(_dynout) + parseFloat(_embd) + parseFloat(_tstchrg) + parseFloat(_cnf) + parseFloat(_byrcom) + parseFloat(_combank) + parseFloat(_Fabric);
    if (!isNaN(totalmlc)) {
        $("[id$='tbblcttlvalprcnt']").val(totalmlc.toFixed(2));
    }
    var masterlcval = $("[id$='tMasterlcval']").val();
    var ttlinhandval = 100 - parseFloat(totalmlc);
    if (!isNaN(ttlinhandval)) {
        $("[id$='tbblcinhandprcnt']").val(ttlinhandval.toFixed(2));
    }
}

function other() {
    var ordqty = $("[id$='txtOrdqty']").val();
    var totalbblc = $("[id$='tbblcttlval']").val();
    var cstperdz = (parseFloat(totalbblc) / parseFloat(ordqty)) * 12;
    if (!isNaN(cstperdz)) {
        $("[id$='tcostperdz']").val(cstperdz.toFixed(2));
    }
    var upriceperdz=$("[id$='tUpriceperdz']").val();
    var cmperdz = parseFloat(upriceperdz) - parseFloat(cstperdz);
    if (!isNaN(cmperdz)) {
        $("[id$='tcmperdz']").val(cstperdz.toFixed(2));
        $("[id$='tCostofmacking']").val(cstperdz.toFixed(2));

        $("[id$='tCnfperdz']").val(cstperdz.toFixed(2));
    }
    var cmperset = parseFloat(cmperdz) / 12;
    if (!isNaN(cmperset)) {
        $("[id$='tcmperset']").val(cmperset.toFixed(2));
    }
    var tk = $("[id$='ttk']").val();
    if (tk.length > 0) {
        var ttk = parseFloat(cmperset) * parseFloat(tk);
        $("[id$='ttkttl']").val(ttk.toFixed(2));
    }
}

function cmperdz() {
    var upriceperdz = $("[id$='tUpriceperdz']").val();
    var cstperdz = $("[id$='tcostperdz']").val();
    var cmperdz=parseFloat(upriceperdz)-parseFloat(cstperdz);
    if(!isNaN(cmperdz))
    {
        $("[id$='tcmperdz']").val(cmperdz.toFixed(2));
    }
}
function tk() {
   $("[id$='ttkttl']").val('');
  var cmperset=  $("[id$='tcmperset']").val();
  var tk = $("[id$='ttk']").val();
  var ttk = parseFloat(cmperset) * parseFloat(tk);
    if (!isNaN(ttk)) {       
        $("[id$='ttkttl']").val(ttk.toFixed(2));
    }
}

function totalcostfinal() {
    var Yarn = $("[id$='tYarncostttl']").val();
    var Knit = $("[id$='tKnttl']").val();
    var Dyeing = $("[id$='tdynttl']").val();
    var Acces = $("[id$='taccttl']").val();
    var Emb = $("[id$='tembttl']").val();
    var Fab = $("[id$='tfabttl']").val();
    var combank = $("[id$='tCommercialbnkamtttl']").val();
    var Buyingcom = $("[id$='tBuyercommissionttl']").val();
    var Tstchrg = $("[id$='tTestingchargettl']").val();
    var Cnf = $("[id$='tCnfttl']").val();

    var _Yarn = 0;
    var _Knit = 0;
    var _Dyeing = 0;
    var _Acces = 0;
    var _Emb = 0;
    var _Fab = 0;
    var _combank = 0;
    var _Buyingcom = 0;
    var _Tstchrg = 0;
    var _Cnf = 0;
    if (Yarn.length > 0) {
        _Yarn = Yarn;
    }
    if (Knit.length > 0) {
        _Knit = Knit;
    }
    if (Dyeing.length > 0) {
        _Dyeing = Dyeing;
    }    
    if (Acces.length > 0) {
        _Acces = Acces;
    }
    if (Emb.length > 0) {
        _Emb = Emb;
    }
    if (Fab.length > 0) {
        _Fab = Fab;
    }
    if (combank.length > 0) {
        _combank = combank;
    }
    if (Buyingcom.length > 0) {
        _Buyingcom = Buyingcom;
    }
    if (Tstchrg.length > 0) {
        _Tstchrg = Tstchrg;
    }
    if (Cnf.length > 0) {
        _Cnf = Cnf;
    }    
     var Totalcostcc = parseFloat(_Yarn) + parseFloat(_Knit) + parseFloat(_Dyeing) + parseFloat(_Acces) + parseFloat(_Emb) + parseFloat(_Fab) + parseFloat(_combank) + parseFloat(_Buyingcom) + parseFloat(_Tstchrg) + parseFloat(_Cnf);
  
    if (!isNaN(Totalcostcc)) {
        $("[id$='Tfinaltotalcost']").val(Totalcostcc.toFixed(2));
    }
    var ordqt = $("[id$='txtOrdqty']").val();
    var finaldz = (parseFloat(Totalcostcc) / parseFloat(ordqt)) * 12;
    $("[id$='tTotalcostdz']").val(finaldz.toFixed(2));

}
function totalcostfinaldz() {
    var Yarn = $("[id$='tYarncostdz']").val();
    var Knit = $("[id$='tknDz']").val();
    var Dyeing = $("[id$='tdyndz']").val();
    var Acces = $("[id$='taccdz']").val();
    var Emb = $("[id$='tembdz']").val();
    var Fab = $("[id$='tfabdz']").val();
    var combank = $("[id$='tCommercialbnkamt']").val();
    var Buyingcom = $("[id$='tBuyercommission']").val();
    var Tstchrg = $("[id$='tTestingchargeamt']").val();
    var Cnf = $("[id$='tCnfamt']").val();
    var _Yarn = 0;
    var _Knit = 0;
    var _Dyeing = 0;
    var _Acces = 0;
    var _Emb = 0;
    var _Fab = 0;
    var _combank = 0;
    var _Buyingcom = 0;
    var _Tstchrg = 0;
    var _Cnf = 0;
    if (Yarn.length > 0) {
        _Yarn = Yarn;
    }
    if (Knit.length > 0) {
        _Knit = Knit;
    }
    if (Dyeing.length > 0) {
        _Dyeing = Dyeing;
    }
    if (Acces.length > 0) {
        _Acces = Acces;
    }
    if (Emb.length > 0) {
        _Emb = Emb;
    }
    if (Fab.length > 0) {
        _Fab = Fab;
    }
    if (combank.length > 0) {
        _combank = combank;
    }
    if (Buyingcom.length > 0) {
        _Buyingcom = Buyingcom;
    }
    if (Tstchrg.length > 0) {
        _Tstchrg = Tstchrg;
    }
    if (Cnf.length > 0) {
        _Cnf = Cnf;
    }
    var Totalcostds = parseFloat(_Yarn) + parseFloat(_Knit) + parseFloat(_Dyeing) + parseFloat(_Acces) + parseFloat(_Emb) + parseFloat(_Fab) + parseFloat(_combank) + parseFloat(_Buyingcom) + parseFloat(_Tstchrg) + parseFloat(_Cnf);
    var totalcostfinal = $("[id$='Tfinaltotalcost']").val();
    var totaldzfinal=parseFloat(totalcostfinal)/parseFloat(Totalcostds);

    if (!isNaN(totaldzfinal)) {
        $("[id$='tTotalcostdz']").val(totaldzfinal.toFixed(2));
    }
}

function dyedfabkg() {
    var dydfabdz = $("[id$='tdyedfabdz']").val();
    var fabconsm = $("[id$='tFabconsumption']").val();
    var dydfabkg = parseFloat(dydfabdz) / parseFloat(fabconsm);
    if (!isNaN(dydfabkg)) {
        $("[id$='tDyedfabkg']").val(dydfabkg.toFixed(2));
    }

}

function totaloutside() {
    var Yarn = $("[id$='tYarnoutside']").val();
    var Knit = $("[id$='tknoutside']").val();
    var Dyeing = $("[id$='tdynoutside']").val();
    var Acces = $("[id$='taccoutside']").val();
    var Emb = $("[id$='temboutside']").val();
    var Fab = $("[id$='tfabout']").val();
    var combank = $("[id$='tCommercialbnkamtttl']").val();
    var Buyingcom = $("[id$='tBuyercommissionttl']").val();
    var Tstchrg = $("[id$='tTestingchargettl']").val();
    var Cnf = $("[id$='tCnfttl']").val();

    var _Yarn = 0;
    var _Knit = 0;
    var _Dyeing = 0;
    var _Acces = 0;
    var _Emb = 0;
    var _Fab = 0;
    var _combank = 0;
    var _Buyingcom = 0;
    var _Tstchrg = 0;
    var _Cnf = 0;
    if (Yarn.length > 0) {
        _Yarn = Yarn;
    }
    if (Knit.length > 0) {
        _Knit = Knit;
    }
    if (Dyeing.length > 0) {
        _Dyeing = Dyeing;
    }
    if (Acces.length > 0) {
        _Acces = Acces;
    }
    if (Emb.length > 0) {
        _Emb = Emb;
    }
    if (Fab.length > 0) {
        _Fab = Fab;
    }
    if (combank.length > 0) {
        _combank = combank;
    }
    if (Buyingcom.length > 0) {
        _Buyingcom = Buyingcom;
    }
    if (Tstchrg.length > 0) {
        _Tstchrg = Tstchrg;
    }
    if (Cnf.length > 0) {
        _Cnf = Cnf;
    }
    var totaloutsideval = parseFloat(_Yarn) + parseFloat(_Knit) + parseFloat(_Dyeing) + parseFloat(_Acces) + parseFloat(_Emb) + parseFloat(_Fab) + parseFloat(_combank) + parseFloat(_Buyingcom) + parseFloat(_Tstchrg) + parseFloat(_Cnf);
    if (!isNaN(totaloutsideval)) {
        $("[id$='tTotaloutside']").val(totaloutsideval.toFixed(2));
    }
}
function totalInside() {
    var Yarn = $("[id$='tYarninside']").val();
    var Knit = $("[id$='tknInside']").val();
    var Dyeing = $("[id$='tdyninside']").val();
    var Acces = $("[id$='taccinside']").val();
    var Emb = $("[id$='tembinside']").val();
    var Fab = $("[id$='tfabinside']").val();  

    var _Yarn = 0;
    var _Knit = 0;
    var _Dyeing = 0;
    var _Acces = 0;
    var _Emb = 0;
    var _Fab = 0;
   
    if (Yarn.length > 0) {
        _Yarn = Yarn;
    }
    if (Knit.length > 0) {
        _Knit = Knit;
    }
    if (Dyeing.length > 0) {
        _Dyeing = Dyeing;
    }
    if (Acces.length > 0) {
        _Acces = Acces;
    }
    if (Emb.length > 0) {
        _Emb = Emb;
    }
    if (Fab.length > 0) {
        _Fab = Fab;
    }
    
    var totaloutinsideval = parseFloat(_Yarn) + parseFloat(_Knit) + parseFloat(_Dyeing) + parseFloat(_Acces) + parseFloat(_Emb) + parseFloat(_Fab);
    if (!isNaN(totaloutinsideval)) {
        $("[id$='tTotalinside']").val(totaloutinsideval.toFixed(2));
    }
}

function insideprcnt() {
    var outsd = $("[id$='tTotaloutside']").val();
    var insid = $("[id$='tTotalinside']").val();
    var ttlinout = parseFloat(outsd) + parseFloat(insid);
    var insideparcnt = (parseFloat(insid) / parseFloat(ttlinout)*100);
    var outsdprcnt = (parseFloat(outsd) / parseFloat(ttlinout)*100);
    if (!isNaN(insideparcnt)) {
        $("[id$='tTotalinsideprcnt']").val(insideparcnt.toFixed(2));
    }
    if (!isNaN(outsdprcnt)) {
        $("[id$='tTotaloutsideprcnt']").val(outsdprcnt.toFixed(2));
    }

}

function Mcs_addimg() {
//alert("test")"
    var val = $("[id*='drpStyle'] :selected").val();
    if (val.length > 0) {
        onunload();
        document.getElementById("txtchkjv").value = "3";
        var existimg = $("[id$='txtimgslno']").val();
        
        $("[id$='txtimgsrc1']").val(existimg);
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
        var ss = $("[id$='txtimgsrc1']").val();
       $("[id$='txtimgslno']").val(ss);
       $("[id$='imgStyle']").attr("src", "StyleFile/" + ss);
       //alert(ss);
        //$("#my_image").attr("src", "second.jpg");
        //document.getElementById("Image1").src = "images/ky.png";


    }
   onunload();
}

function podtlcalculate(gridview) {
    var gt = document.getElementById(gridview);
    var tval = 0;
    for (i = 1; i < gt.rows.length; i++) {
        var rowcell = gt.rows[i].cells;
        var cellvalue = rowcell[3].getElementsByTagName("input")[0].value;
        var cellvaluechk = rowcell[3].getElementsByTagName("input")[1];
        if (cellvaluechk.type == "checkbox" && cellvaluechk.checked) {
            tval = parseFloat(tval) + parseFloat(cellvalue);          
        }
    }
    $("[id$='txtGmtQty']").val(tval);
    Calculateamount1();
    
}

function hideLoading() {
    document.getElementById('divLoading').style.display = "none";
    document.getElementById('divFrameHolder').style.display = "block";
}
function onunload() {
    document.getElementById('divLoading').style.display = "block";
    document.getElementById('divFrameHolder').style.display = "none";
}