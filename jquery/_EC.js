function Rowmaterial(txtRow, txtEmbroidery, txtPrinting, txtWashing, txtOther, txtSubttlpcs, txtSubttldz, txtsubttl, txtOrdqty, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobPer, txtMarginPer, txtFobpc, txtMarginPc, txtFobdz, txtMarginDz, txtFobttl, txtMarginttl) {
    var Row = 0;
    var emb = 0;
    var prnt = 0;
    var wash = 0;
    var other = 0;
    var RowM = document.getElementById(txtRow).value;
    var Embdry = document.getElementById(txtEmbroidery).value;
    var Prnting = document.getElementById(txtPrinting).value;
    var Wsing = document.getElementById(txtWashing).value;
    var Others = document.getElementById(txtOther).value;
    if (RowM.length > 0) {
        Row = RowM;
    }
    if (Embdry.length > 0) {
        emb = Embdry;
    }
    if (Prnting.length > 0) {
        prnt = Prnting;
    }
    if (Wsing.length > 0) {
        wash = Wsing;
    }
    if (Others.length > 0) {
        other = Others;
    }
    var ttDoz = 0;
    ttDoz = parseFloat(Row) + parseFloat(emb) + parseFloat(prnt) + parseFloat(wash) + parseFloat(other);
    if (!isNaN(ttDoz)) {
        document.getElementById(txtSubttldz).value = ttDoz.toFixed(2);
    }
    var ttpcs = 0;
    ttpcs = parseFloat(ttDoz) / 12;
    if (!isNaN(ttpcs)) {
        document.getElementById(txtSubttlpcs).value = ttpcs.toFixed(2);
    }
    var _ordQty = 0;
    var OrdQty = document.getElementById(txtOrdqty).value;
    if (OrdQty.length > 0) {
        _ordQty = OrdQty;
    }
    var Subttl = 0;
    Subttl = parseFloat(ttpcs) * parseFloat(_ordQty);
    if (!isNaN(Subttl)) {
        document.getElementById(txtsubttl).value = Subttl.toFixed(2);
    }
    //Calculate FOB
    var Perpcs = document.getElementById(txtFobpc).value;
    var ordQty = document.getElementById(txtOrdqty).value;
    var Subttl = document.getElementById(txtSubttltt).value;
    var Perdz = 0;
    if (Perpcs.length > 0) {
        if (parseFloat(Perpcs) > 0) {
            Perdz = parseFloat(Perpcs) * 12;
            if (!isNaN(Perdz)) {
                document.getElementById(txtFobdz).value = Perdz.toFixed(0);
            }
            var ttl = parseFloat(ordQty) * parseFloat(Perpcs);
            if (!isNaN(ttl)) {
                document.getElementById(txtFobttl).value = ttl.toFixed(2);
            }
            var SubtPercnt = eval((parseFloat(Subttl) / parseFloat(ttl)) * 100);
            if (!isNaN(SubtPercnt)) {
                document.getElementById(txtSubttlPer).value = SubtPercnt.toFixed(2);
            }
        }
    }     
    TotalCost(txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlpcs, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt)
    CalculateProfitMargin(txtFobPer, txttotalPer, txtMarginPer, txtFobpc, txttotalPc, txtMarginPc, txtFobdz, txttotaldz, txtMarginDz, txtFobttl, txttotaltt, txtMarginttl);
}
function CalculateFOB(txtpcs, txtperdz, txtOrdQty, txtttl, txtSubttl, txtsubpercntg, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobPer, txtMarginPer, txtMarginPc, txtMarginDz, txtMarginttl) {
    document.getElementById(txtperdz).value = "0";
    document.getElementById(txtttl).value = "0";
    document.getElementById(txtsubpercntg).value = "0";    
    var Perpcs = document.getElementById(txtpcs).value;
    var ordQty = document.getElementById(txtOrdQty).value;
    var Subttl = document.getElementById(txtSubttl).value;
    var Perdz = 0;
    if (Perpcs.length > 0) {
        if (parseFloat(Perpcs) > 0) {
            Perdz = parseFloat(Perpcs) * 12;
            if (!isNaN(Perdz)) {
                document.getElementById(txtperdz).value = Perdz.toFixed(0);
            }
            var ttl = parseFloat(ordQty) * parseFloat(Perpcs);
            if (!isNaN(ttl)) {
                document.getElementById(txtttl).value = ttl.toFixed(2);
            }
            var SubtPercnt = eval((parseFloat(Subttl) / parseFloat(ttl)) * 100);
            if (!isNaN(SubtPercnt)) {
                document.getElementById(txtsubpercntg).value = SubtPercnt.toFixed(2);
            }
            //OverHeadCalculate
            var _pc = document.getElementById(txtoverheadPc).value;
            var _OrdQty = document.getElementById(txtOrdQty).value;
            var _fobttl = document.getElementById(txtttl).value;
            var _ovttl = 0;
            var _pcs = 0;
            var _dz = 0;
            if (_pc.length > 0) {
                _pcs = _pc;
                _dz = parseFloat(_pc) * 12;
                if (!isNaN(_dz)) {
                    document.getElementById(txtoverheaddz).value = _dz.toFixed(2);
                }
                _ovttl = parseFloat(_pcs) * parseFloat(_OrdQty);
                if (!isNaN(_ovttl)) {
                    document.getElementById(txtoverheadtt).value = _ovttl.toFixed(2);
                }
                var OvPercnt = eval((parseFloat(_ovttl) / parseFloat(_fobttl)) * 100);
                if (!isNaN(OvPercnt)) {
                    document.getElementById(txtoverheadPer).value = OvPercnt.toFixed(2);
                }
            }
            //Calculate ManufCost
            var _mfdz = document.getElementById(txtmcostdz).value;
            var _OrdQty = document.getElementById(txtOrdQty).value;
            var _fobttl = document.getElementById(txtttl).value;
            var _Mfcostdz = 0;
            var _MfPC = 0;
            var _mfTtl = 0;
                if (_mfdz.length > 0) {
                    _Mfcostdz = _mfdz;
                    _MfPC = parseFloat(_Mfcostdz) / 12;
                    if (!isNaN(_MfPC)) {
                        document.getElementById(txtmcostPc).value = _MfPC.toFixed(2);
                    }
                    _mfTtl = parseFloat(_MfPC) * parseFloat(_OrdQty);
                    if (!isNaN(_mfTtl)) {
                        document.getElementById(txtmcosttt).value = _mfTtl.toFixed(2);
                    }
                    var OvPercnt = eval((parseFloat(_mfTtl) / parseFloat(_fobttl)) * 100);
                    if (!isNaN(OvPercnt)) {
                        document.getElementById(txtmcostPer).value = OvPercnt.toFixed(2);
                    }
                }
            //

            }
        }
        TotalCost(txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt)
        CalculateProfitMargin(txtFobPer, txttotalPer, txtMarginPer, txtpcs, txttotalPc, txtMarginPc, txtperdz, txttotaldz, txtMarginDz, txtttl, txttotaltt, txtMarginttl);
}
function TotalCost(txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt) {
   //document.getElementById(txttotalPer).value = "0";
    var sbbttlpr = document.getElementById(txtSubttlPer).value;
    var Costpr = document.getElementById(txtmcostPer).value;
    var overhedpr = document.getElementById(txtoverheadPer).value;
    var tCompr = document.getElementById(txtcomissionPer).value;
    var _Sbttlpr = "0";
    var _Cstpr = "0";
    var _Ovheadpr ="0";
    var _tCompr ="0";
    var _ttlpr = "0";
    if (sbbttlpr.length > 0) {
        _Sbttlpr = sbbttlpr;
    }
    if (Costpr.length > 0) {
        _Cstpr = Costpr;
    }
    if (overhedpr.length > 0) {
        _Ovheadpr = overhedpr;
    }
    if (tCompr.length > 0) {
        _tCompr = tCompr;
    }
    var compercntg ="0";

    _ttlpr = parseFloat(_Sbttlpr) + parseFloat(_Cstpr) + parseFloat(_Ovheadpr) + parseFloat(_tCompr);
    if (!isNaN(_ttlpr)) {
        compercntg = _ttlpr;
    }
    //document.getElementById(txttotalPer).value ="0";
    if (!isNaN(_ttlpr)) {
        document.getElementById(txttotalPer).value = compercntg.toFixed(2);
    }
    //Pcs
    var sbbttlpc = document.getElementById(txtSubttlPc).value;
    var Costpc = document.getElementById(txtmcostPc).value;
    var overhedpc = document.getElementById(txtoverheadPc).value;
    var tCompc = document.getElementById(txtcomissionPc).value;
    var _Sbttlpc = "0";
    var _Cstpc ="0";
    var _Ovheadpc = "0";
    var _tCompc = "0";
    var _ttlpc = "0";
    if (sbbttlpc.length > 0) {
        _Sbttlpc = sbbttlpc;
    }
    if (Costpc.length > 0) {
        _Cstpc = Costpc;
    }
    if (overhedpc.length > 0) {
        _Ovheadpc = overhedpc;
    }
    if (tCompc.length > 0) {
        _tCompc = tCompc;
    }
   
    _ttlpc = parseFloat(_Sbttlpc) + parseFloat(_Cstpc) + parseFloat(_Ovheadpc) + parseFloat(_tCompc);
    //document.getElementById(txttotalPc).value = "0";
    if (!isNaN(_ttlpc)) {
        document.getElementById(txttotalPc).value = _ttlpc.toFixed(2);
    }
    //Dz
    var sbbttldz = document.getElementById(txtSubttldz).value;
    var Costdz = document.getElementById(txtmcostdz).value;
    var overheddz = document.getElementById(txtoverheaddz).value;
    var tComdz = document.getElementById(txtcomissiondz).value;
    var _Sbttldz = "0";
    var _Cstdz = "0";
    var _Ovheaddz = "0";
    var _tComdz = "0";
    var _ttldz = "0";
    if (sbbttldz.length > 0) {
        _Sbttldz = sbbttldz;
    }
    if (Costdz.length > 0) {
        _Cstdz = Costdz;
    }
    if (overheddz.length > 0) {
        _Ovheaddz = overheddz;
    }
    if (tComdz.length > 0) {
        _tComdz = tComdz;
    }
    _ttldz = parseFloat(_Sbttldz) + parseFloat(_Cstdz) + parseFloat(_Ovheaddz) + parseFloat(_tComdz);
    //document.getElementById(txttotaldz).value = "0";
    if (!isNaN(_ttldz)) {
        document.getElementById(txttotaldz).value = _ttldz.toFixed(2);
    }
    //Total
    var sbbttltt = document.getElementById(txtSubttltt).value;
    var Costtt = document.getElementById(txtmcosttt).value;
    var overhedtt = document.getElementById(txtoverheadtt).value;
    var tComtt = document.getElementById(txtcomissiontt).value;
    var _Sbttltt = "0";
    var _Csttt = "0";
    var _Ovheadtt = "0";
    var _tComtt = "0";
    var _ttltt = "0";
    if (sbbttltt.length > 0) {
        _Sbttltt = sbbttltt;
    }
    if (Costtt.length > 0) {
        _Csttt = Costtt;
    }
    if (overhedtt.length > 0) {
        _Ovheadtt = overhedtt;
    }
    if (tComtt.length > 0) {
        _tComtt = tComtt;
    }
    _ttltt = parseFloat(_Sbttltt) + parseFloat(_Csttt) + parseFloat(_Ovheadtt) + parseFloat(_tComtt);
    //document.getElementById(txttotaltt).value = "0";
    if (!isNaN(_ttltt)) {
        document.getElementById(txttotaltt).value = _ttltt.toFixed(2);
    }
}
function MasterCatselect(chkb, lblvalue, txtRowmat, txtEmbroidery, txtPrinting, txtWashing, txtOther, txtSubttlpcs, txtSubttldz, txtsubttl, txtOrdqty, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobPer, txtMarginPer, txtFobpc, txtMarginPc, txtFobdz, txtMarginDz, txtFobttl, txtMarginttl, txtrowMat) {
    var Mcatvalue = document.getElementById(lblvalue).innerText;
    var ordqty = document.getElementById(txtOrdqty).value;
    var RowM = 0;

    var Rowmat = document.getElementById(txtrowMat).value;
        if(Rowmat.length>0)
        {
            RowM=Rowmat;
        }
        var Tot = 0;
        if (!(document.getElementById(chkb).checked)) {       
            Tot = parseFloat(RowM) - parseFloat(Mcatvalue);
        }
        else {
            if (Mcatvalue.length > 0) {
                Tot = parseFloat(RowM) + parseFloat(Mcatvalue);           
            }
        }
        var RowDz = (parseFloat(Tot) / parseFloat(ordqty)) * 12;
        if (!isNaN(Tot)) {
            document.getElementById(txtrowMat).value = Tot.toFixed(2);
        }
        if (!isNaN(RowDz)) {
            document.getElementById(txtRowmat).value = RowDz.toFixed(2);
        }
        Rowmaterial(txtRowmat, txtEmbroidery, txtPrinting, txtWashing, txtOther, txtSubttlpcs, txtSubttldz, txtsubttl, txtOrdqty, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobPer, txtMarginPer, txtFobpc, txtMarginPc, txtFobdz, txtMarginDz, txtFobttl, txtMarginttl);
    }


    function CmFirstmethod() {
        var costmintprcnt = $("[id$='txtCostPerminutesPrcnt']").val();
        var costmintdlr = $("[id$='txtCostPerminutesDollar']").val();
        var styleffprcnt = $("[id$='txtPlaneffPercnt']").val();
        var stlplaneffdollar = "0.000";
        if (costmintprcnt.length > 0 && costmintdlr.length > 0 && styleffprcnt.length > 0) {
            stlplaneffdollar = (parseFloat(costmintprcnt) / parseFloat(styleffprcnt)) * parseFloat(costmintdlr);
        }
        if (!isNaN(stlplaneffdollar)) {
            $("[id$='txtPlaneffDollar']").val(parseFloat(stlplaneffdollar).toFixed(3));
        }
        var _pln = 1;
        var _smv = "1";
        var SMV = $("[id$='txtSmv']").val();
        if (SMV.length > 0) {
            _smv = SMV;
        }        
        if (parseFloat(stlplaneffdollar) > 0) {
            _pln = stlplaneffdollar;
        }
        else {
            if (costmintdlr.length > 0) {
                _pln = costmintdlr;
            }
        }
        var costofmanufdz = parseFloat(_smv) * parseFloat(_pln) * 12;
        if (!isNaN(costofmanufdz)) {
            $("[id$='txtCMDz']").val(costofmanufdz.toFixed(3));
        }
        //profit dz
        var profitmargin=1;
        var pmargin = $("[id$='txtProfitMargin']").val();
        if (pmargin.length > 0) {
            if (parseFloat(pmargin) > 0) {
                profitmargin = pmargin;
            }
        }
        var profitdz = (parseFloat(costofmanufdz) / 100) * parseFloat(profitmargin);
        if (!isNaN(profitdz)) {
            $("[id$='txtProfitDz']").val(profitdz.toFixed(3));
        }
        var totalcm = parseFloat(profitdz) + parseFloat(costofmanufdz);
        if (!isNaN(totalcm)) {
            $("[id$='txtCMwithProfit']").val(totalcm.toFixed(3));
        }
    }


function PlanStyleEff(txtCostperminPerc, txtCostperinDoll, txtPlneffPer, txtPlaneffDoll, txtSmv, txtPlaneff, txtCostofManDz, txtcostPermDz, txtManuCost, txtProfitMartin, txtProfitDz, txtCM) {
    var _CostPerMinutePrcntg = document.getElementById(txtCostperminPerc).value;
    var _CostPerMinuteDz = document.getElementById(txtCostperinDoll).value;
    var _StylePlnEffPrcntg = document.getElementById(txtPlneffPer).value;
    if (_CostPerMinutePrcntg.length > 0 && _CostPerMinuteDz.length > 0 && _StylePlnEffPrcntg.length > 0) {
        var _PlneddDlr = (parseFloat(_CostPerMinutePrcntg) / parseFloat(_StylePlnEffPrcntg)) * parseFloat(_CostPerMinuteDz);
        if (!isNaN(_PlneddDlr)) {
            document.getElementById(txtPlaneffDoll).value = _PlneddDlr.toFixed(4);
        }
        CMDz(txtSmv, txtPlaneff, txtCostofManDz, txtcostPermDz, txtManuCost, txtProfitMartin, txtProfitDz, txtCM);
    }    
}
function CMDz(txtSmv, txtPlaneff, txtCostofManDz, txtcostPermDz, txtManuCost, txtProfitMartin, txtProfitDz, txtCM) {
    document.getElementById(txtCostofManDz).value = 0;
    var _SMV = document.getElementById(txtSmv).value;
    var _Plneff = document.getElementById(txtPlaneff).value;
    var _CostperMinuteDlr = document.getElementById(txtcostPermDz).value;
    var _pln = 1;
    if (_Plneff.length > 0) {
        if (parseFloat(_Plneff) > 0) {
            _pln = _Plneff
        }
        else {
            _pln = _CostperMinuteDlr;
        }
    }
    else {
        _pln = _CostperMinuteDlr;
    }
    if (_SMV.length > 0) {
        var _PlneddDlr = parseFloat(_SMV) * parseFloat(_pln) * 12;
        if (!isNaN(_PlneddDlr)) {
            document.getElementById(txtCostofManDz).value = _PlneddDlr.toFixed(4);
        }
            ProfitDz(txtManuCost, txtProfitMartin, txtProfitDz, txtCM);
      
    }
}
function ProfitDz(txtManuCost, txtProfitMartin, txtProfitDz, txtCM) {
    //document.getElementById(txtProfitDz).value = 0;
    var _MnuCst = document.getElementById(txtManuCost).value;
    var _PMargin = document.getElementById(txtProfitMartin).value;
    var _ProfitDz = document.getElementById(txtProfitDz).value;
    var ProfitDz = 0;
    if (_MnuCst.length > 0 && _PMargin.length > 0) {
        ProfitDz = (parseFloat(_MnuCst) / 100) * parseFloat(_PMargin);
        if (!isNaN(ProfitDz)) {
            document.getElementById(txtProfitDz).value = ProfitDz.toFixed(4);
        }
        CMwithProfit(txtManuCost, txtProfitDz, txtCM);
    }
}
function CMwithProfit(txtCstMan, txtProfitDz, txtCM) {
    var _MnuCst = document.getElementById(txtCstMan).value;
    var _PMargin = document.getElementById(txtProfitDz).value;
    var tt = 0;
    if (_MnuCst.length > 0 && _PMargin.length > 0) {
        tt = parseFloat(_MnuCst) + parseFloat(_PMargin);
        if (!isNaN(tt)) {
            document.getElementById(txtCM).value = tt.toFixed(4);
        }
    }
}
function SecondMC(txtProd, txtMachine, txtMCostHr, txtMCDz,txtordQty, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobttl, txtFobPer, txtMarginPer, txtFobPC, txtMarginPc, txtFobdz, txtMarginDz, txtMarginttl) {

    var Prod = document.getElementById(txtProd).value;
    var Nomachine = document.getElementById(txtMachine).value;
    var costPc = document.getElementById(txtMCostHr).value;
    var CostDz = 0;
        if (Prod.length > 0 && Nomachine.length > 0 && costPc.length > 0) {
            CostDz = (parseFloat(Nomachine) * parseFloat(costPc)) / parseFloat(Prod);
            var cstdzn = parseFloat(CostDz) * 12;
            if (!isNaN(CostDz)) {
                document.getElementById(txtMCDz).value = cstdzn.toFixed(2);
            }
                if (parseFloat(CostDz) > 0) {
                    CMTransfer(txtMCDz, txtordQty, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobttl, txtFobPer, txtMarginPer, txtFobPC, txtMarginPc, txtFobdz, txtMarginDz, txtMarginttl);
                }
        }
}
function CMTransfer(txtCmValue, txtordQty, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobttl, txtFobPer, txtMarginPer, txtFobPC, txtMarginPc, txtFobdz, txtMarginDz, txtMarginttl) {
    var _CMValue = document.getElementById(txtCmValue).value;
    var ManufPc = 0;
    if (_CMValue.length > 0) {
        if (!isNaN(_CMValue)) {
            document.getElementById(txtmcostdz).value = _CMValue;
        }
        ManufPc = parseFloat(_CMValue) / 12;
        if (!isNaN(ManufPc)) {
            document.getElementById(txtmcostPc).value = ManufPc.toFixed(2);
        }
        var _OrdQty = document.getElementById(txtordQty).value;
        var ttl = parseFloat(_OrdQty) * parseFloat(ManufPc);
        if (!isNaN(ttl)) {
            document.getElementById(txtmcosttt).value = ttl.toFixed(2);
        }
        var fobttl = document.getElementById(txtFobttl).value;
        var SubtPercnt = eval((parseFloat(ttl) / parseFloat(fobttl)) * 100);
        if (!isNaN(SubtPercnt)) {
            document.getElementById(txtmcostPer).value = SubtPercnt.toFixed(2);
        }
        //----------
        TotalCost(txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt);
        CalculateProfitMargin(txtFobPer, txttotalPer, txtMarginPer, txtFobPC, txttotalPc, txtMarginPc, txtFobdz, txttotaldz, txtMarginDz, txtFobttl, txttotaltt, txtMarginttl);
    }
}
function OverHeadCalculate(txtOrdqty, txtFobttl, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobPer, txtMarginPer, txtFobPC, txtMarginPc, txtFobdz, txtMarginDz, txtMarginttl) {
    document.getElementById(txtoverheaddz).value = "0";
    document.getElementById(txtoverheadtt).value = "0";
    document.getElementById(txtoverheadPer).value = "0";
    var _pc = document.getElementById(txtoverheadPc).value;
    var _OrdQty = document.getElementById(txtOrdqty).value;
    var _fobttl = document.getElementById(txtFobttl).value;
    var _ovttl = 0;
    var _pcs = 0;
    var _dz = 0;
    if (_pc.length > 0) {
        _pcs = _pc;
    }
    if (_pc.length > 0) {
        _dz = 0;
        _dz = parseFloat(_pc) * 12;
        if (!isNaN(_dz)) {
            document.getElementById(txtoverheaddz).value = _dz.toFixed(2);
        }       
        _ovttl = parseFloat(_pcs) * parseFloat(_OrdQty);
        //document.getElementById(txtoverheadtt).value = "0";
        if (!isNaN(_ovttl)) {
            document.getElementById(txtoverheadtt).value = _ovttl.toFixed(2);
        }
        var OvPercnt =0;
        OvPercnt = eval((parseFloat(_ovttl) / parseFloat(_fobttl)) * 100);
        //OvPercnt = eval((parseFloat(_ovttl) / parseFloat(_fobttl)) * 100);
        if (!isNaN(OvPercnt)) {
            document.getElementById(txtoverheadPer).value = OvPercnt.toFixed(2);
        }
    }
    TotalCost(txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt);
    CalculateProfitMargin(txtFobPer, txttotalPer, txtMarginPer, txtFobPC, txttotalPc, txtMarginPc, txtFobdz, txttotaldz, txtMarginDz, txtFobttl, txttotaltt, txtMarginttl);
}
function MFCost(txtOrdQty, txtFobttl, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobPer, txtMarginPer, txtFobPC, txtMarginPc, txtFobdz, txtMarginDz, txtMarginttl) {
    document.getElementById(txtmcostPc).value = "0";
    document.getElementById(txtmcosttt).value = "0";
    document.getElementById(txtmcostPer).value = "0";
    var _mfdz = document.getElementById(txtmcostdz).value;
    var _OrdQty = document.getElementById(txtOrdQty).value;
    var _fobttl = document.getElementById(txtFobttl).value;
    var _Mfcostdz = 0;
    var _MfPC = 0;
    var _mfTtl = 0;
    if (_mfdz.length > 0) {
        _Mfcostdz = _mfdz;
        _MfPC = parseFloat(_Mfcostdz) / 12;
        if (!isNaN(_MfPC)) {
            document.getElementById(txtmcostPc).value = _MfPC.toFixed(2);
        }
        _mfTtl = parseFloat(_MfPC) * parseFloat(_OrdQty);
        if (!isNaN(_mfTtl)) {
            document.getElementById(txtmcosttt).value = _mfTtl.toFixed(2);
        }
        var OvPercnt = eval((parseFloat(_mfTtl) / parseFloat(_fobttl)) * 100);
        if (!isNaN(OvPercnt)) {
            document.getElementById(txtmcostPer).value = OvPercnt.toFixed(2);
        }
    }
    TotalCost(txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt);
    CalculateProfitMargin(txtFobPer, txttotalPer, txtMarginPer, txtFobPC, txttotalPc, txtMarginPc, txtFobdz, txttotaldz, txtMarginDz, txtFobttl, txttotaltt, txtMarginttl);
}
function CommissionCalculate(txtFob, txtOrdQty, txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt, txtFobPer, txtMarginPer, txtFobPC, txtMarginPc, txtFobdz, txtMarginDz, txtFobttl, txtMarginttl) {
    document.getElementById(txtcomissiontt).value = "0";
    document.getElementById(txtcomissionPc).value = "0";
    document.getElementById(txtcomissiondz).value = "0";
    var _comPercent = document.getElementById(txtcomissionPer).value;
    var _Fob = document.getElementById(txtFob).value;
    var _OrdQty = document.getElementById(txtOrdQty).value;
    var compr = 0;
    var _PC = 0;
    var _Dz = 0;
    var fb = 0;
    if (_Fob.length > 0) {
        fb = _Fob;
    }
    var Ttl = 0;
    if (_comPercent.length > 0) {
        compr = _comPercent;
        //_PC = parseFloat(_Fob) * (parseFloat(_comPercent) / 100);
        _PC = (parseFloat(fb) / 100) * parseFloat(_comPercent);
       // document.getElementById(txtcomissionPc).value = "0";
        if (!isNaN(_PC)) {
            document.getElementById(txtcomissionPc).value = _PC.toFixed(2);
           // document.getElementById(txtcomissionPc).value = "100";
        }
        _Dz = 0;
        _Dz = parseFloat(_PC) * 12;
        //document.getElementById(txtcomissiondz).value = "0";
        if (!isNaN(_Dz)) {
            document.getElementById(txtcomissiondz).value = _Dz.toFixed(2);
        }
        Ttl = parseFloat(_PC) * parseFloat(_OrdQty);
       // document.getElementById(txtcomissiontt).value = "0";
        if (!isNaN(Ttl)) {
            document.getElementById(txtcomissiontt).value = Ttl.toFixed(2);
        }      
        
    }
    TotalCost(txtSubttlPer, txtmcostPer, txtoverheadPer, txtcomissionPer, txttotalPer, txtSubttlPc, txtmcostPc, txtoverheadPc, txtcomissionPc, txttotalPc, txtSubttldz, txtmcostdz, txtoverheaddz, txtcomissiondz, txttotaldz, txtSubttltt, txtmcosttt, txtoverheadtt, txtcomissiontt, txttotaltt);
    CalculateProfitMargin(txtFobPer, txttotalPer, txtMarginPer, txtFobPC, txttotalPc, txtMarginPc, txtFobdz, txttotaldz, txtMarginDz, txtFobttl, txttotaltt, txtMarginttl);
}
function CalculateProfitMargin(txtFobPer, txtTotalcostPer, txtMarginPer, txtFobPC, txtttlcostPc, txtMarginPc, txtFobdz, txttotaldz, txtMarginDz,txtFobttl,txttotalcostttl,txtMarginttl) {



    //document.getElementById(txtMarginPer).value = "0";
    //document.getElementById(txtMarginPc).value = "0";
    //document.getElementById(txtMarginDz).value = "0";
    //document.getElementById(txtMarginttl).value = "0";
    document.getElementById(txtMarginPer).value = "0";
    document.getElementById(txtMarginPc).value = "0";
    document.getElementById(txtMarginDz).value = "0";
    document.getElementById(txtMarginttl).value = "0";
    

    var _FbPr = document.getElementById(txtFobPer).value;
    var _TCostPer = document.getElementById(txtTotalcostPer).value;
    var Pmargn = parseFloat(_FbPr) - parseFloat(_TCostPer);
    if (!isNaN(Pmargn)) {
        document.getElementById(txtMarginPer).value = Pmargn.toFixed(2);
    }   
    //Pc
    var _Fbpc = document.getElementById(txtFobPC).value;
    var _TCostPc = document.getElementById(txtttlcostPc).value;
    var PmargnPc = parseFloat(_Fbpc) - parseFloat(_TCostPc);
    if (!isNaN(PmargnPc)) {
        document.getElementById(txtMarginPc).value = PmargnPc.toFixed(2);
    }   
    //Dozon
    var _Fbdz = document.getElementById(txtFobdz).value;
    var _TCostdz = document.getElementById(txttotaldz).value;
    var Pmargndz = parseFloat(_Fbdz) - parseFloat(_TCostdz);
    if (!isNaN(Pmargndz)) {
        document.getElementById(txtMarginDz).value = Pmargndz.toFixed(2);
    }
    //Ttl
    var _Fbttl = document.getElementById(txtFobttl).value;
    var _TCostttl = document.getElementById(txttotalcostttl).value;
    var Pmargnttl = parseFloat(_Fbttl) - parseFloat(_TCostttl);
    if (!isNaN(Pmargnttl)) {
        document.getElementById(txtMarginttl).value = Pmargnttl.toFixed(2);
    }
}

//Materialcostsheet


//bblcpercent
function prcnt() {
var mstrlc=$("[id$='tmstrlcvalue']").val();
var yrn = $("[id$='tbbyrn']").val();
var _yrn = 1;
    if(mstrlc.length>0)
    {
        if (yrn.length > 0) {
            _yrn = yrn;
        }
        var yrnprcnt = (parseFloat(_yrn) / parseFloat(mstrlc))*100;
        $("[id$='tbbyrnprc']").val(yrnprcnt.toFixed(3));

        //------
        var knt = $("[id$='tbbknit']").val();
        var _knt = 0;
        if (knt.length > 0) {
            _knt = knt;
        }
        var kntprcnt = (parseFloat(_knt) / parseFloat(mstrlc)) * 100;
        $("[id$='tbbknitprc']").val(kntprcnt.toFixed(3));
       // ------------
        var ac = $("[id$='tbbacc']").val();
        var _ac = 0;
        if (ac.length > 0) {
            _ac = ac;
        }
        var acprcnt = (parseFloat(_ac) / parseFloat(mstrlc)) * 100;

        $("[id$='tbbaccprc']").val(acprcnt.toFixed(3));
        //-----------------
        var ch = $("[id$='tbbdynchmicl']").val();
        var _ch = 0;
        if (ch.length > 0) {
            _ch = ch;
        }
        var chprcnt = (parseFloat(_ch) / parseFloat(mstrlc)) * 100;
        //if (ch.length > 0) {
            $("[id$='tbbdynchmiclprc']").val(chprcnt.toFixed(3));        
       // }
        
        //----------------
        var d = $("[id$='tbbyrnding']").val();
        var _d = 0;
        if (d.length > 0) {
            _d = d;
        }
        var dprcnt = (parseFloat(_d) / parseFloat(mstrlc)) * 100;
        $("[id$='tbbyrndingprc']").val(dprcnt.toFixed(3));
        //----------------------
        var o = $("[id$='tbballover']").val();
        var _o = 0;
        if (o.length > 0) {
            _o = o;
        }
        var oprcnt = (parseFloat(_o) / parseFloat(mstrlc)) * 100;
        $("[id$='tbballoverprc']").val(oprcnt.toFixed(3));
        //--------------
        var t = $("[id$='tbbttl']").val();
        var _t = 0;
        if (t.length > 0) {
            _t = t;
        }
        var tprcnt = (parseFloat(_t) / parseFloat(mstrlc)) * 100;
        $("[id$='tbbttlprc']").val(tprcnt.toFixed(3));
        //------------
    } 
}


function edit(lbltype, txtdesc, txtfabcon, txtprcnt, txtcons, txtunit, txtunitprice, txtamount, lblttlcost, txtsuptype, txtunitparam,lblsl) {

    $("[id$='drpConsunit']").val("0");
    $("[id$='drpSuppliertype']").val("0");
    $("[id$='drpConsunit']").attr("disabled", "disabled");
    $("[id$='txtpercent']").attr("disabled", "disabled");
    $("[id$='txtpercent']").val('');
    $("[id$='txtFabconsm']").attr("disabled", "disabled");
    $("[id$='txtConsumption']").attr("disabled", "disabled");
    $("[id$='txtuprice']").attr("disabled", "disabled");
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
        if (SID.length > 0) {
            if (SID == 'YARN') {
                $("[id$='txtpercent']").removeAttr("disabled");
                $("[id$='txtFabconsm']").removeAttr("disabled");
                $("[id$='txtConsumption']").attr("disabled", "disabled");                        
                
            }
            ///yarn
            if (SID == 'KNITTING') {
                $("[id$='txtConsumption']").attr("disabled", "disabled");
                $("[id$='txtpercent']").attr("disabled", "disabled");
                $("[id$='txtFabconsm']").removeAttr("disabled");                
            }

            if (SID == 'FABRIC') {
                $("[id$='txtConsumption']").removeAttr("disabled");
                $("[id$='drpConsunit']").attr("disabled", "disabled");
                $("[id$='drpSuppliertype']").attr("disabled", "disabled");
                $("[id$='txtpercent']").attr("disabled", "disabled");
                $("[id$='txtFabconsm']").attr("disabled", "disabled");
            }
            if (SID == 'ACCESSORIES') {
                $("[id$='drpConsunit']").removeAttr("disabled");
                $("[id$='txtConsumption']").removeAttr("disabled");
                $("[id$='drpSuppliertype']").removeAttr("disabled");
            }
            $("[id$='txtuprice']").removeAttr("disabled");
        }


        
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
     

    function hideLoading() {
        document.getElementById('divLoading').style.display = "none";
        document.getElementById('divFrameHolder').style.display = "block";
    }
    function onunload() {
        document.getElementById('divLoading').style.display = "block";
        document.getElementById('divFrameHolder').style.display = "none";
    }
        function calculateamount(txtconsumption,txtunitprce,txtamount,txtunitparam) {
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
                    ttl = parseFloat(cons)* parseFloat(upc);
                    if (!isNaN(ttl)) {
                        $("[id$='" + txtamount + "']").val(ttl.toFixed(2));
                        var ordqty= $("[id$='txtordqty']").val();
                        var ttcost = (parseFloat(ordqty) / 12) * parseFloat(ttl) * 1.05;
                        $("[id$='txtTotalcost']").val(ttcost.toFixed(2));
                       // txtTotalcost
                    }
                }          
            }
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
                $("[id$='" + txtamount + "']").val(ttl.toFixed(2));  
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
                            document.getElementById(cnsom).value = prcent.toFixed(2);
                        }
                    }
                    else {
                        var tot = (parseFloat(ordqty) / 12) * parseFloat(fabriccons);
                        document.getElementById(cnsom).value = tot.toFixed(2);
                    }
                    ttlcal(cnsom, txtuprice, txtamount);
                   
                }
                ///yarn
                if (SID == 'KNITTING') {                  
                    var prcent = (parseFloat(ordqty)/12) * parseFloat(fabriccons);
                    document.getElementById(cnsom).value = prcent.toFixed(2);
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
                    var tl = parseFloat(cns) *parseFloat(upr);
                    $("[id$='" + txtamount + "']").val(tl.toFixed(2));

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
                        ttl = parseFloat(cons)* parseFloat(upc);
                        if (!isNaN(ttl)) {
                            $("[id$='" + txtamount + "']").val(ttl.toFixed(2));
                            var ordqty = $("[id$='txtordqty']").val();
                            var ttcost = (parseFloat(ordqty) / 12) * parseFloat(ttl) * 1.05;
                            $("[id$='txtTotalcost']").val(ttcost.toFixed(2));
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
            $("[id$='drpConsunit']").attr("disabled", "disabled");
            $("[id$='" + prcnt + "']").attr("disabled", "disabled");
            $("[id$='" + prcnt + "']").val('');
            $("[id$='" + fabcons + "']").attr("disabled", "disabled");
            $("[id$='" + cnsom + "']").attr("disabled", "disabled");
            $("[id$='" + txtuprice + "']").attr("disabled", "disabled");
            $("[id$='" + fabcons + "']").val('');
            $("[id$='" + cnsom + "']").val('');
            $("[id$='" + txtuprice + "']").val('');
            $("[id$='" + txtamount + "']").val('');
            $("[id$='" + totqty + "']").val('');
            $("[id$='txtunitparam']").val('');
            var qty = $("[id$='txtordqty']").val();
            if (qty.length > 0) {
                var SID = $("[id*='drpType'] :selected").val();
               
                if (SID.length > 0) {
                    if (SID == 'YARN') {
                        $("[id$='" + prcnt + "']").removeAttr("disabled");
                        $("[id$='" + fabcons + "']").removeAttr("disabled");
                       
                        $("[id$='" + cnsom + "']").attr("disabled", "disabled");
                    }
                    ///yarn
                    if (SID == 'KNITTING') {
                        $("[id$='" + cnsom + "']").attr("disabled", "disabled");
                        $("[id$='" + prcnt + "']").attr("disabled", "disabled");
                        $("[id$='" + fabcons + "']").removeAttr("disabled");
                    }

                    if (SID == 'FABRIC') {
                        $("[id$='" + cnsom + "']").removeAttr("disabled");
                        $("[id$='drpConsunit']").attr("disabled", "disabled");
                        $("[id$='drpSuppliertype']").attr("disabled", "disabled");
                        $("[id$='" + prcnt + "']").attr("disabled", "disabled");
                        $("[id$='" + fabcons + "']").attr("disabled", "disabled");
                    }
                    if (SID == 'ACCESSORIES') {
                        $("[id$='drpConsunit']").removeAttr("disabled");
                        $("[id$='" + cnsom + "']").removeAttr("disabled");
                        $("[id$='drpSuppliertype']").removeAttr("disabled");
                    }
                    $("[id$='" + txtuprice + "']").removeAttr("disabled");
                }
            }
            else {
                alert("First Enter Qty");
                $("[id$='drpType']").val("0");
            }
        }

        function calcmasterlcvalue() {
            $("[id$='tbbunitpricedz']").val('0');
            var qty = $("[id$='txtordqty']").val();
            var uprice = $("[id$='txtUpriceset']").val();
            var qt = 0;
            var up = 0;
            if (qty.length > 0) {
                qt = qty;
            }
            if (uprice.length > 0) {
                up = uprice;
            }
            var tt = qt * up;
            var ttl = $("[id$='tmstrlcvalue']").val(tt.toFixed(2));
            var updz = parseFloat(up) * 12;
            $("[id$='tbbunitpricedz']").val(updz.toFixed(2));
            //calculatecstdz();
            //totaldying();
        }
        function calculatecstdz() {
            var pnt = 0;
            var wsh = 0;
            var acs = 0;
            var _pnt = $("[id$='tPrnt']").val();
            var _wsh = $("[id$='tWsh']").val();
            var _acs = $("[id$='txtGrandtotal']").val();
            if (_pnt.length > 0) {
                pnt = _pnt;
            }
            if (_wsh.length > 0) {
                wsh = _wsh;
            }
            if (_acs.length > 0) {
                acs = _acs;
            }
            var ttl = parseFloat(pnt) + parseFloat(wsh) + parseFloat(acs);
            $("[id$='tcostdz']").val(ttl.toFixed(3));
            var qty = $("[id$='txtordqty']").val();
            
           // $("[id$='tcmperdz']").val(cmdz.toFixed(2));
            //$("[id$='tCm']").val(cmdz.toFixed(2));            

            var up = $("[id$='tbbunitpricedz']").val();
            var uppdz = 0;
            if (up.length > 0) {
                uppdz = up;
            }
            var cmbpedzbblc = parseFloat(uppdz) - parseFloat(ttl);
            //alert(cmbpedzbblc);
            $("[id$='tcmperdzprcnt']").val(cmbpedzbblc.toFixed(3));
            $("[id$='tCm']").val(cmbpedzbblc.toFixed(3));
            var cmdz = (parseFloat(qty) / 12) * parseFloat(cmbpedzbblc);
            if (!isNaN(cmdz)) {
                $("[id$='tcmperdz']").val(cmdz.toFixed(3));
            }
            else {
                $("[id$='tcmperdz']").val('0.0');
            }

            var dz=parseFloat(cmbpedzbblc) / 12;
            $("[id$='tcostset']").val(dz.toFixed(3));

            var cmtk = "1";
            var _cmtk = $("[id$='cmtk']").val();
            if (_cmtk.length > 0) {
                cmtk = _cmtk;
            }
            var settk=parseFloat(dz)*parseFloat(cmtk);
            $("[id$='tcostsettk']").val(settk.toFixed(3));

          
            //$("[id$='tFob']").val(settk.toFixed(2));
            //Fob calculation
            var exfabcost=0;
            var _exfabcost = $("[id$='txtExtrafabcost']").val();
            if (_exfabcost.length > 0) {
                exfabcost = _exfabcost;
            }
            var exacc = 0;
            var _exacc = $("[id$='texacccost']").val();
            if (_exacc.length > 0) {
                exacc = _exacc;
            }
            var em = 0;
            var _em = $("[id$='tEmbdry']").val();
            if (_em.length > 0) {
                em = _em;
            }
            var fbttl = parseFloat(acs) + parseFloat(exfabcost) + parseFloat(exacc) + parseFloat(cmbpedzbblc) + parseFloat(wsh) + parseFloat(pnt) + parseFloat(em);
           // alert(fbttl);
            $("[id$='tFob']").val(fbttl.toFixed(3));    
           
        }

        function calculatedying(consumption,uprice,totalamnt) {
            $("[id$='" + totalamnt + "']").val('');
            var cons = $("[id$='" + consumption + "']").val();
            var upr = $("[id$='" + uprice + "']").val();
            var cn = 0;
            var uprc = 0;
            if (cons.length > 0) {
                cn = cons;
            }
            if (upr.length > 0) {
                uprc = upr;
            }
            var tt = parseFloat(cn) * parseFloat(uprc);
            $("[id$='" + totalamnt + "']").val(tt.toFixed(2));
            totaldying();
            calculatecstdz();
            prcnt();
        }
        function totaldying() {
            var dtl = 0;
            var wstl = 0;
            var yntl = 0;
            var d = $("[id$='txtDyingamnt']").val();
            var w = $("[id$='txtwashfinishamt']").val();
            var y = $("[id$='txtYrndyingamt']").val();
            if (d.length > 0) {
                dtl = d;
            }
            if (w.length > 0) {
                wstl = w;
            }
            if (y.length > 0) {
                yntl = y;
            }
            var chml = parseFloat(dtl) + parseFloat(wstl);
            $("[id$='tbbdynchmicl']").val(chml.toFixed(3));
            $("[id$='tbbyrnding']").val(yntl);
            var mlcttl = $("[id$='tmstrlcvalue']").val();
            var chmcl = parseFloat(mlcttl) / parseFloat(chml);
            if (parseFloat(chml) > 0) {             
             $("[id$='tbbdynchmiclprc']").val(chmcl.toFixed(3));          
            }
                  
            var yrndn = parseFloat(mlcttl) / parseFloat(yntl);
            if (yrndn.length > 0) {
                $("[id$='tbbyrndingprc']").val(yrndn.toFixed(3));
            }
            else {
                $("[id$='tbbyrndingprc']").val('0.0');
            }       
                      
            
            //bblcttl

            var _yr = 0;
            var _acs = 0;
            var _dyn = 0;
            var _knitn = 0;
            var _chm = 0;
            var olovr = 0;

            var _yr1 = $("[id$='tbbyrn']").val();
            var _acs1 =$("[id$='tbbacc']").val();
            var _dyn1 = $("[id$='tbbyrnding']").val();
            var _knitn1 =$("[id$='tbbknit']").val();
            var _chm1 =$("[id$='tbbdynchmicl']").val();
            var olovr1 =$("[id$='tbballover']").val();

            if (_yr1.length > 0) {
                _yr = _yr1
            }
            if (_acs1.length > 0) {
                _acs = _acs1
            }
            
            if (_dyn1.length > 0) {
                _dyn = _dyn1
            }
            if (_knitn1.length > 0) {
                _knitn = _knitn1
            }
            if (_chm1.length > 0) {
                _chm = _chm1
            }
            if (olovr1.length > 0) {
                olovr = olovr1
            }
            var bbcttl = parseFloat(_yr) + parseFloat(_acs) + parseFloat(_dyn) + parseFloat(_knitn) + parseFloat(_chm) + parseFloat(olovr);
            $("[id$='tbbttl']").val(bbcttl.toFixed(2));
            //--------            
                        
            var ttl = parseFloat(dtl) + parseFloat(wstl) + parseFloat(yntl);
            $("[id$='txtTotaldyingcharge']").val(ttl.toFixed(3));
            //totaldying fabric

            var grayttl = $("[id$='txtyarnknitting']").val();
            var gr = 0;
            if (grayttl.length > 0) {
                gr = grayttl;
            }
            var ttldyn = parseFloat(ttl) + parseFloat(gr);
            $("[id$='txttotaldyingfabric']").val(ttldyn.toFixed(3));         
            //Cost Of Dyed Fabric Per Dz          
            var ordqty=$("[id$='txtordqty']").val();
            var dzttl = parseFloat(ttldyn) / parseFloat(ordqty) * 12;
            if (!isNaN(dzttl)) {
                $("[id$='txtdcostdz']").val(dzttl.toFixed(2));
            }
            else {
                $("[id$='txtdcostdz']").val('0.0');
            }
            //--------

            //cost of dyed fabric per kg
            var fabkg = $("[id$='txtFabrictotal']").val();
            var _kg = 1;
            if (fabkg.length > 0) {
                _kg = fabkg;
            }
            var ktcalc = parseFloat(dzttl) / parseFloat(_kg);
            if (!isNaN(ktcalc)) {
                $("[id$='txtCostdynkg']").val(ktcalc.toFixed(2));
            }
            else {
                $("[id$='txtCostdynkg']").val('0.0');
            }
           
            //TOTAL COST
            var grfb = $("[id$='txtdcostdz']").val();
            var fab = $("[id$='txtFabrictotal']").val();
            var accs = $("[id$='txtAccess5percent']").val();
            var _gr = 0;
            var _fb = 0;
            var _ac = 0;
            if (grfb.length > 0) {
                _gr = grfb;
            }
            if (fab.length > 0) {
                _fb = fab;
            }
            if (accs.length > 0) {
                _ac = accs;
            }
            //var t_tl = parseFloat(_gr) + parseFloat(_fb) + parseFloat(_ac);
            var t_tl = parseFloat(_gr) + parseFloat(_ac);
            $("[id$='txtGrandtotal']").val(t_tl.toFixed(2));
            //prcentttl
           // $("[id$='txtGrandtotal']").val();
           // $("[id$='txtGrandtotal']").val();
           // //$("[id$='txtGrandtotal']").val();
           // $("[id$='txtGrandtotal']").val();
           // $("[id$='txtGrandtotal']").val();

        }

        function gangnumstyle() {
            var mstrlcval = $("[id$='tmstrlcvalue']").val();
            var mstrlc = 1;
            if (mstrlcval.length > 0) {
                mstrlc = mstrlcval;
            }
            //var consm= $("[id$='txtconsprocessloss']").val();
            var prevprclossttl = 0;
            var prcsttl = $("[id$='txtamntporcessloss']").val();
            if (prcsttl.length > 0) {
                prevprclossttl = prcsttl;
                $("[id$='txtamntporcessloss']").val('0');
            }
            var ttl = $("[id$='tPlossconsttl']").val();
            var _ttl = 0;
            if (ttl.length > 0) {
                _ttl = ttl;
            }
            var up = $("[id$='txtupporcessloss']").val();
            var _up = 0;
            if (up.length > 0) {
                _up = up;
            }
            var _yrt=$("[id$='txtyearntotal']").val();
            var yrt = 0;
            if (_yrt.length > 0) {
                yrt = _yrt;
            }

            var _prcnt = $("[id$='txtupporcesslossprcnt']").val();
            var prcnt = 0;
            if (_prcnt.length > 0) {
                prcnt = _prcnt
            }
          // if (prcnt.length > 0) {
               var calc = (parseFloat(_ttl) / 100) * parseFloat(prcnt);
               $("[id$='txtconsprocessloss']").val(calc.toFixed(3));
               var amnt = parseFloat(calc) * parseFloat(_up);
               var prlosscalcamt = parseFloat(_yrt) - parseFloat(prevprclossttl);
               $("[id$='txtamntporcessloss']").val(amnt.toFixed(3));
               var yrnttl = parseFloat(amnt) + parseFloat(prlosscalcamt);
               $("[id$='txtyearntotal']").val(yrnttl.toFixed(3));
               $("[id$='tbbyrn']").val(yrnttl.toFixed(3));              
               var tbyrnprc = ((parseFloat(yrnttl) / parseFloat(mstrlc)) * 100);
               $("[id$='tbbyrnprc']").val(tbyrnprc.toFixed(3));
               //knitting
               var knitttl = $("[id$='txtTotalknitting']").val();
               var _ntttl = 0;
               if (knitttl.length > 0) {
                   _ntttl = knitttl;
               }
               //YARN KNIT TOTAL
               var _yrnknit = parseFloat(yrnttl) + parseFloat(_ntttl);
               $("[id$='txtyarnknitting']").val(_yrnknit.toFixed(3));

               //KNIT
               $("[id$='tbbknit']").val(_ntttl.toFixed(3));
               var kntprcent = ((parseFloat(_yrnknit) / parseFloat(mstrlc)) * 100);
               $("[id$='tbbknitprc']").val(kntprcent.toFixed(3));

               //DYEING
               //dying finishing
               var dynfinishcon = 0;
               var dynfinishprce = 0;
               var dynfinishttl = 0;
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

               //washfinishing
//               var wshfinishcon = 0;
//               var washfinishup = 0;
//               var washfinishttl = 0;
//               var _wshfinishcon = $("[id$='txtWashconsm']").val();
//               if (_wshfinishcon.length > 0) {
//                   wshfinishcon = _wshfinishcon;
//               }

//               var _washfinishup = $("[id$='txtwashuprice']").val();
//               if (_washfinishup.length > 0) {
//                   washfinishup = _washfinishup;
//               }
//               washfinishttl = parseFloat(wshfinishcon) * parseFloat(washfinishup);
//               $("[id$='txtwashfinishamt']").val(washfinishttl.toFixed(3));

//               //yarndying charge
//               var yrndyingcon = 0;
//               var yrndyingup = 0;
//               var yrndyingttl = 0;
//               var _yrndyingcon = $("[id$='txtyarnconsm']").val();
//               if (_yrndyingcon.length > 0) {
//                   yrndyingcon = _yrndyingcon;
//               }

//               var _yrndyingup = $("[id$='txtyarnuprice']").val();
//               if (_yrndyingup.length > 0) {
//                   yrndyingup = _yrndyingup;
//               }
//               yrndyingttl = parseFloat(yrndyingcon) * parseFloat(yrndyingup);
//               $("[id$='txtYrndyingamt']").val(yrndyingttl.toFixed(3));

              // var totaldyingcharge = parseFloat(dynfinishttl) + parseFloat(washfinishttl) + parseFloat(yrndyingttl);
              // $("[id$='txtTotaldyingcharge']").val(totaldyingcharge.toFixed(3));

//               var TOTALCOSTOFDYEDFAB = 0;
//               TOTALCOSTOFDYEDFAB = parseFloat(_yrnknit) + parseFloat(totaldyingcharge);

//               $("[id$='txttotaldyingfabric']").val(TOTALCOSTOFDYEDFAB.toFixed(3));
//              

               

                          
               
            
           //}          
        

       }


      






        
            function tsttr() {
            var SID = $("[id*='drpConsunit'] :selected").text();
            alert(SID);
        }

        function totalcosting() {
            var _MAINYARN = 0;
            var _YARNPERCENT = 0;
            var _MAINKNITTING = 0;
            var _MAINYRNKNIT = 0;
            var _MASTERLCVAL = 1;
            var _LOSSPERCENT = 0;
            var _LOSSAMNT=0;


            var mstrlcval = $("[id$='tmstrlcvalue']").val();
            if (mstrlcval.length > 0) {
                _MASTERLCVAL = mstrlcval;
            }

            var prevprclossttl = 0;
            var prcsttl = $("[id$='txtamntporcessloss']").val();
            if (prcsttl.length > 0) {
                prevprclossttl = prcsttl;
                $("[id$='txtamntporcessloss']").val('0');
            }

            var ttl = $("[id$='tPlossconsttl']").val();
            var _ttl = 0;
            if (ttl.length > 0) {
                _ttl = ttl;
            }
            var up = $("[id$='txtupporcessloss']").val();
            var _up = 0;
            if (up.length > 0) {
                _up = up;
            }
            var _yrt = $("[id$='txtyearntotal']").val();
            var yrt = 0;
            if (_yrt.length > 0) {
                yrt = _yrt;
            }

            var prcnt = $("[id$='txtupporcesslossprcnt']").val();
            
            if (prcnt.length > 0) {
                _LOSSPERCENT = prcnt;
            }

             var calc = (parseFloat(_ttl) / 100) * parseFloat(_LOSSPERCENT);
             $("[id$='txtconsprocessloss']").val(calc.toFixed(3));
              var amnt = parseFloat(calc) * parseFloat(_up);

       
               
               
                var prlosscalcamt = parseFloat(_yrt) - parseFloat(prevprclossttl);
                $("[id$='txtamntporcessloss']").val(amnt.toFixed(3));
                _MAINYARN = parseFloat(amnt) + parseFloat(prlosscalcamt);
                $("[id$='txtyearntotal']").val(_MAINYARN.toFixed(3));
                $("[id$='tbbyrn']").val(_MAINYARN.toFixed(3));


                _YARNPERCENT = ((parseFloat(_MAINYARN) / parseFloat(_MASTERLCVAL)) * 100);
                $("[id$='tbbyrnprc']").val(_YARNPERCENT.toFixed(3));

//                //knitting
//                var knitttl = $("[id$='txtTotalknitting']").val();
//                var _ntttl = 0;
//                if (knitttl.length > 0) {
//                    _ntttl = knitttl;
//                }
//                var _yrnknit = parseFloat(yrnttl) + parseFloat(_ntttl);
//                $("[id$='txtyarnknitting']").val(_yrnknit.toFixed(3));


//                tbbknit



            }

            //kniting









            function calcmasterlcvalue1() {
                $("[id$='tbbunitpricedz']").val('0');
                var qty = $("[id$='txtordqty']").val();
                var uprice = $("[id$='txtUpriceset']").val();
                var qt = 0;
                var up = 0;
                if (qty.length > 0) {
                    qt = qty;
                }
                if (uprice.length > 0) {
                    up = uprice;
                }
                var tt = qt * up;
                var ttl = $("[id$='tmstrlcvalue']").val(tt.toFixed(2));
                var updz = parseFloat(up) * 12;
                $("[id$='tbbunitpricedz']").val(updz.toFixed(2));
                //calculatecstdz();
                //totaldying();
            }

            function calculatedying1() {
                var dynfinishcon = 0;
                var dynfinishprce = 0;
                var dynfinishttl = 0;
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
                               var wshfinishcon = 0;
                               var washfinishup = 0;
                               var washfinishttl = 0;
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
                               var yrndyingcon = 0;
                               var yrndyingup = 0;
                               var yrndyingttl = 0;
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

                 var yrnknig = 0;
                 var _yrnknit = $("[id$='txtyarnknitting']").val();
                 if (_yrnknit.length > 0) {
                     yrnknig = _yrnknit;
                 }


                               var TOTALCOSTOFDYEDFAB = 0;
                               TOTALCOSTOFDYEDFAB = parseFloat(yrnknig) + parseFloat(totaldyingcharge);

                               $("[id$='txttotaldyingfabric']").val(TOTALCOSTOFDYEDFAB.toFixed(3));
                               var qty=0;
                               var _qty = $("[id$='txtordqty']").val();
                               if (_qty > 0)
                               {
                                   qty = _qty;
                               }

                               var dyinnDZ = 0;
                               dyinnDZ = (parseFloat(TOTALCOSTOFDYEDFAB) / parseFloat(qty)) * 12;
                               $("[id$='txtdcostdz']").val(dyinnDZ.toFixed(3));
                           }

                           function Accris() {
                               var Acris = 0;
                               var _acris = $("[id$='txtAccess5percent']").val();
                               if (_acris.length > 0) {
                                   Acris = _acris;
                               }

                               var grfac = 0;
                               var _grfac = $("[id$='txtdcostdz']").val();
                               if (_grfac.length > 0) {
                                   grfac = _grfac;
                               }
                               var ttlacs = parseFloat(Acris) + parseFloat(grfac);
                               $("[id$='txtGrandtotal']").val(ttlacs.toFixed(3));
                           }

                           function bblc() {
                               var masterlcttl=0;
                               var _masterlc= $("[id$='tmstrlcvalue']").val();
                               if(_masterlc.length>0)
                               {
                                   masterlcttl = _masterlc;
                               }
                               var yrn = 0;
                               var _yrn = $("[id$='txtyearntotal']").val();
                               if (_yrn.length > 0) {
                                     yrn = _yrn
                                }
                               $("[id$='tbbyrn']").val(yrn.toFixed(3));
                               var yrnprcnt = 0;
                               yrnprcnt = (parseFloat(yrn) / parseFloat(masterlcttl)) * 100;
                               if (!isNaN(yrnprcnt)) {
                                   $("[id$='tbbyrnprc']").val(yrnprcnt.toFixed(3));
                               }
                               //knit
                               var knitval = $("[id$='txtTotalknitting']").val();
                               var _knitval = 0;
                               if (knitval.length > 0) {
                                   _knitval = knitval
                               }
                               $("[id$='tbbknit']").val(_knitval.toFixed(3));
                               var knitprnct = 0;
                               if (parseFloat(knitval) > 0) {
                                   knitprnct = (parseFloat(_knitval) / parseFloat(masterlcttl)) * 100;
                               }
                               $("[id$='tbbknitprc']").val(knitprnct.toFixed(3));

                               //Accris
                               var acrs = $("[id$='txtTtlaccesrs']").val();
                               var _acrs = 0;
                               if (acrs.length > 0) {
                                   _acrs = acrs;
                               }
                               $("[id$='tbbacc']").val(_acrs.toFixed(3));
                               var acrsprcnt = 0;
                               if (parseFloat(acrs) > 0) {
                                   acrsprcnt = (parseFloat(_acrs) / parseFloat(masterlcttl)) * 100;
                               }
                               $("[id$='tbbaccprc']").val(acrsprcnt.toFixed(3));
                               //chemical and ete
                               var dyfinish = 0;
                               var _dyfinish = $("[id$='txtDyingamnt']").val();
                               if (_dyfinish.length > 0) {
                                   dyfinish = _dyfinish;
                               }
                               var wfinish = 0;
                               var _wfinish = $("[id$='txtwashfinishamt']").val();
                               if (_wfinish.length > 0) {
                                   wfinish = _wfinish;
                               }
                               var chmcl = parseFloat(dyfinish) + parseFloat(wfinish);
                               $("[id$='tbbdynchmicl']").val(chmcl.toFixed(3));
                               var chmclprc = 0;
                               if (parseFloat(chmcl) > 0) {
                                   chmclprc = (parseFloat(chmcl) / parseFloat(masterlcttl)) * 100;
                               }
                               $("[id$='tbbdynchmiclprc']").val(chmclprc.toFixed(3));
                               //yrndying
//                               var yrndying = 0;
//                               var _yrndying = $("[id$='txtYrndyingamt']").val();
//                               if (_yrndying.length > 0) {
//                                   yrndying = _yrndying;
//                               }
//                               $("[id$='tbbyrnding']").val(yrndying);
//                               var yrndyingprc = 0;
//                               if (parseFloat(yrndying) > 0) {
//                                   yrndyingprc = (parseFloat(yrndying) / parseFloat(masterlcttl)) * 100;
//                               }
//                               $("[id$='tbbyrndingprc']").val(yrndyingprc.toFixed(3));



                           }

                           function Callttl() {
                               calcmasterlcvalue1();
                               calculatedying1();
                               Accris();
                               bblc();
                           
                           }