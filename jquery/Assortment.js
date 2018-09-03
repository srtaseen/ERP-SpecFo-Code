

//check duplicate size
function CheckSizeInformationDuplication(cellid) {
    rows = document.getElementById('ContentPlaceHolder1_C1TabControl1_C1TabPage1_tblsizeinfo').getElementsByTagName("TR");
    var j = 1;
    cellbelow = rows[3].getElementsByTagName("TD");
    cells = rows[j].getElementsByTagName("TD");
    var charchal = cells[cellid].getElementsByTagName("input")[0].value;
    for (var i = 1; i < cells.length; i++) {
        var loopcel = cells[i].getElementsByTagName("input")[0].value;
        //cellbelow[i].getElementsByTagName("input")[0].value = loopcel.toUpperCase();
        if (charchal.length > 0) {
            if (i != cellid) {
                if (loopcel.length > 0) {
                    if (charchal == loopcel) {
                        cells[i].getElementsByTagName("input")[0].style.background = '#E60000';
                        alert("Duplicate");
                        cells[i].getElementsByTagName("input")[0].style.background = '';
                        cells[cellid].getElementsByTagName("input")[0].value = '';
                        cells[cellid].getElementsByTagName("input")[0].focus();
                    }
                }
            }
        }
    }
}

function ColourQuantitytotal(rowid, gridview, cellid, ttl, txtpoqty, btnsave, PackQty) {
    var PackQuantity = document.getElementById(PackQty).value;    
    var poqty = document.getElementById(txtpoqty).value;    
    var gttl = 0;
    var gvDrv = document.getElementById(gridview);
    var s = parseInt(rowid);
    var cell1 = gvDrv.rows[s].cells;
    var T = 0;
    var grandtotal = 0; 
    var va = 0;
    var totalrow = gvDrv.rows[rowid].cells;   
    for (var x = 2; x < totalrow.length - 1; x++) {
        var val = totalrow[x].getElementsByTagName("input")[0].value;
        if (val.length > 0) {
            va = eval(val) + va;
        }
    }
    document.getElementById(ttl).value = va*eval(PackQuantity);   
   for (i =1; i < gvDrv.rows.length - 1; i++) {
        var l00pcell = gvDrv.rows[i].cells;
        var loopcellvalue = l00pcell[cellid].getElementsByTagName("input")[0].value;
        var looplastcellvalue = l00pcell[l00pcell.length - 1].getElementsByTagName("input")[0].value;
        if (loopcellvalue.length > 0) {
            T = eval(loopcellvalue) + T;
        }
        var looplast = gvDrv.rows[gvDrv.rows.length - 1].cells;
        looplast[cellid].innerText = T;
        if (looplastcellvalue.length > 0) {
            grandtotal = eval(looplastcellvalue) + grandtotal;
        }
        looplast[l00pcell.length - 1].innerText = grandtotal;
       // document.getElementById(txtpackttlqtynw).value = grandtotal;
       // var ctl = parseFloat(grandtotal) * parseFloat(ratqty);
        if (parseFloat(grandtotal) > parseFloat(poqty)) {
            document.getElementById(txtpoqty).style.border = '2px solid red';
            document.getElementById(btnsave).setAttribute('disabled', true);
            looplast[l00pcell.length - 1].style.border = '2px solid red';
            alert("Size Quantity Can't Exceed PO Quantity");
            gvDrv.rows[rowid].cells[cellid].getElementsByTagName("input")[0].focus();           
            var lst = gvDrv.rows[rowid].cells[cellid].getElementsByTagName("input")[0].value;
            var lstminus = parseFloat(grandtotal) - (parseFloat(lst)*eval(PackQuantity));
            document.getElementById(ttl).value = parseFloat(document.getElementById(ttl).value) - (parseFloat(lst) * eval(PackQuantity));
            looplast[cellid].innerText = parseFloat(looplast[cellid].innerText) - parseFloat(lst);
            gvDrv.rows[rowid].cells[cellid].getElementsByTagName("input")[0].value = '';
            looplast[l00pcell.length - 1].innerText = lstminus;
            document.getElementById(txtpoqty).style.border = '';
            looplast[l00pcell.length - 1].style.border = '';
            document.getElementById(btnsave).removeAttribute('disabled', false);
            break;
        }       
    }
}

function ColourQuantitytotal1(gridview, rto, blncttl) {
    var gvDrv = document.getElementById(gridview);    
   
    var blnc = document.getElementById(blncttl).value;
    if ((document.getElementById(rto).value).length == 0) {
        document.getElementById(rto).value = "1";
    }
    var Rat = document.getElementById(rto).value;
    var gttl = "0";
    var rttl = "0";  
    for (i = 1; i <gvDrv.rows.length-1; i++) {
        var Loopcell = gvDrv.rows[i].cells;
        for (j = 2; j < Loopcell.length - 1; j++) {
            var t = Loopcell[j].getElementsByTagName("input")[0].value;
            var mt = "0";
            if (t.length > 0) {
                mt = t;
            }
            rttl = parseFloat(rttl) + parseFloat(mt);
        }
        var collnth = gvDrv.rows[i].cells.length - 1;
        var actl = "0";
        actl = parseFloat(rttl) * parseFloat(Rat);
        if (!isNaN(actl)) {
            gvDrv.rows[i].cells[collnth].getElementsByTagName("input")[0].value = parseFloat(rttl) * parseFloat(Rat);
        }
        gttl = parseFloat(gttl) + (parseFloat(rttl) * parseFloat(Rat));
        rttl = "0";       
    }
   var grdrow = gvDrv.rows.length - 1;
   var lstclm = gvDrv.rows[grdrow].cells.length - 1;
   if (!isNaN(gttl)) {
       gvDrv.rows[grdrow].cells[lstclm].innerText = gttl;
   }
   if (parseFloat(gttl) > parseFloat(blnc)) {
       var grdtl = "0";
       document.getElementById(blncttl).style.border = '2px solid red';
       gvDrv.rows[grdrow].cells[lstclm].style.border = '2px solid red';
       alert("Size Quantity Can't Exceed PO Quantity");
       gttl = "0";
       document.getElementById(blncttl).style.border = '';
       gvDrv.rows[grdrow].cells[lstclm].style.border = '';
       document.getElementById(rto).value = "1";
       for (i = 1; i < gvDrv.rows.length - 1; i++) {
           var Loopcell = gvDrv.rows[i].cells;
           for (j = 2; j < Loopcell.length - 1; j++) {
               var t = Loopcell[j].getElementsByTagName("input")[0].value;
               var st = "0";
               if (t.length > 0) {
                   st = t;
               }
               rttl = parseFloat(rttl) + parseFloat(st);
               //alert(rttl);
           }
           var cll = gvDrv.rows[i].cells.length - 1;
           var bctl = "0";
           bctl = parseFloat(rttl) * 1;
           if (!isNaN(bctl)) {
               gvDrv.rows[i].cells[cll].getElementsByTagName("input")[0].value = parseFloat(rttl) * 1;
           }
           grdtl = parseFloat(grdtl) + (parseFloat(rttl) *1);
           rttl = "0";         
       }
       var gg = gvDrv.rows.length - 1;
       var cc = gvDrv.rows[gg].cells.length - 1;
       if (!isNaN(grdtl)) {
           gvDrv.rows[gg].cells[cc].innerText = grdtl;
       }
   }
}
function ColourQuantitytotal2(gridview, rto, blncttl,textboxval) {
    var gvDrv = document.getElementById(gridview);
    var Rat = document.getElementById(rto).value;
    var blnc = document.getElementById(blncttl).value;
    var gttl = "0";
    var rttl = "0";
    for (i = 1; i < gvDrv.rows.length - 1; i++) {
        var Loopcell = gvDrv.rows[i].cells;
        for (j = 2; j < Loopcell.length - 1; j++) {
            var t = Loopcell[j].getElementsByTagName("input")[0].value;
            var st = "0";
            if (t.length > 0) {
                st = t;
            }
            rttl = parseFloat(rttl) + parseFloat(st);
        }
        var collnth = gvDrv.rows[i].cells.length - 1;
        var rowttl = "0";
        rowttl = parseFloat(rttl) * parseFloat(Rat);
        if (!isNaN(rowttl)) {
            gvDrv.rows[i].cells[collnth].getElementsByTagName("input")[0].value = parseFloat(rttl) * parseFloat(Rat);
        }
        gttl = parseFloat(gttl) + (parseFloat(rttl) * parseFloat(Rat));
        rttl = "0";
    }
    var grdrow = gvDrv.rows.length - 1;
    var lstclm = gvDrv.rows[grdrow].cells.length - 1;
    if (!isNaN(gttl)) {
        gvDrv.rows[grdrow].cells[lstclm].innerText = gttl;
    }
    if (parseFloat(gttl) > parseFloat(blnc)) {
        var grdtl = "0";
        document.getElementById(blncttl).style.border = '2px solid red';
        gvDrv.rows[grdrow].cells[lstclm].style.border = '2px solid red';
        alert("Size Quantity Can't Exceed PO Quantity");
        gttl = "0";
        document.getElementById(blncttl).style.border = '';
        gvDrv.rows[grdrow].cells[lstclm].style.border = '';
        document.getElementById(textboxval).value = "0";
        for (i = 1; i < gvDrv.rows.length - 1; i++) {
            var Loopcell = gvDrv.rows[i].cells;
            for (j = 2; j < Loopcell.length - 1; j++) {
                var t = Loopcell[j].getElementsByTagName("input")[0].value;
                var gt = "0";
                if (t.length > 0) {
                    gt = t;
                }
                rttl = parseFloat(rttl) + parseFloat(gt);
                //alert(rttl);
            }
            var cll = gvDrv.rows[i].cells.length - 1;
            var grtdl = "0";
            grtdl = parseFloat(rttl) * parseFloat(Rat);
            if (!isNaN(grtdl)) {
                gvDrv.rows[i].cells[cll].getElementsByTagName("input")[0].value = parseFloat(rttl) * parseFloat(Rat);
            }
            grdtl = parseFloat(grdtl) + (parseFloat(rttl) * parseFloat(Rat));
            rttl = "0";
        }
        var gg = gvDrv.rows.length - 1;
        var cc = gvDrv.rows[gg].cells.length - 1;
        if (!isNaN(grdtl)) {
            gvDrv.rows[gg].cells[cc].innerText = grdtl;
        }
    }
}

function rattype(drp,txtrat,gridview,blnceqty) { 
    var ddl = document.getElementById(drp);
    var SelVal = ddl.options[ddl.selectedIndex].text;
    if (SelVal == "Ratio") {
        document.getElementById(txtrat).removeAttribute('disabled', false);
        document.getElementById(txtrat).value = "1";       
        }
        else
        {
            document.getElementById(txtrat).setAttribute('disabled', true);
            document.getElementById(txtrat).value = "1";
        }
    var gvDrv = document.getElementById(gridview);    
    var Rat = document.getElementById(txtrat).value;
    var blnc=document.getElementById(blnceqty).value;
    var gttl = "0";
    var rttl = "0";
    for (i = 1; i < gvDrv.rows.length-1; i++) {
        var Loopcell = gvDrv.rows[i].cells;
        for (j = 2; j < Loopcell.length - 1; j++) {
            var t = Loopcell[j].getElementsByTagName("input")[0].value;
            var st = "0";
            if (t.length > 0) {
                st = t;
            }
            rttl = parseFloat(rttl) + parseFloat(st);
            //alert(rttl);
        }      
        var collnth = gvDrv.rows[i].cells.length - 1;
        gttl = parseFloat(gttl) + (parseFloat(rttl) * parseFloat(Rat));
        var cctl = "0";
        cctl = parseFloat(rttl) * parseFloat(Rat);
        if (!isNaN(cctl)) {
            gvDrv.rows[i].cells[collnth].getElementsByTagName("input")[0].value = parseFloat(rttl) * parseFloat(Rat);
        }  
        //var gvtqty=gvDrv.rows[gvDrv.rows.length - 1].cells[collnth].innerText;
        rttl = "0";
    }
    //alert(gttl);
    var grdrow = gvDrv.rows.length - 1;
    var lstclm = gvDrv.rows[grdrow].cells.length - 1;
    // alert(lstclm);
    if (!isNaN(gttl)) {
        gvDrv.rows[grdrow].cells[lstclm].innerText = gttl;
    }
}

function gtrtqty(poqty, ttqty, gridview,rato) {
    var pqty = document.getElementById(poqty).value;
    var tqty = document.getElementById(ttqty).value;
    var rat=document.getElementById(rato).value;
    var gvDrv = document.getElementById(gridview);
    var looplast = gvDrv.rows[gvDrv.rows.length - 1].cells;
    var l00pcell = gvDrv.rows[gvDrv.rows.length - 1].cells;
    var val = looplast[l00pcell.length - 1].innerText;
    var tval = parseFloat(val) * parseFloat(rat);
    looplast[l00pcell.length - 1].innerText = tval;
    if (parseFloat(tqty) > parseFloat(pqty)) {
        document.getElementById(pqty).style.border = '2px solid red';
        alert("Size Quantity Can't Exceed PO Quantity");
        document.getElementById(pqty).style.border = '';          
        }
}
function ts(gridview) {
    var gvDrv = document.getElementById(gridview);  
    var grandtotal = 0; 
     for (i =1; i < gvDrv.rows.length - 1; i++) {
        var l00pcell = gvDrv.rows[i].cells;       
        gvDrv.rows[i].cells.innerText = "0";        
        }   
}
function printgridview(strid) {
    var prtContent = document.getElementById(strid);
    var WinPrint = window.open('', '', 'letf=0,top=0,width=700,height=500,toolbar=0,scrollbars=0,status=0');
    WinPrint.document.write(prtContent.innerHTML);
    WinPrint.document.close();
    WinPrint.focus();
    WinPrint.print();
    WinPrint.close();
}
//left arrow=37,right arrow=39,Delete Key=46,BackSpace=8,Enter=9,
function EnterOnlyNumericvaluetoTextbox() {
    if (event.which != 8 && event.which != 0 && event.which != 46 && event.which != 37 && event.which != 39 && event.which != 9 && event.which != 110 && (event.which < 48 || event.which > 57) && (event.which < 96 || event.which > 105)) {
        $("#lbltotalinfo").html("Digits Only").show().fadeOut("slow");
        return false;
    }
}
$(document).ready(function () {
    $(".btPOPUP").live("click", function () {
        $(".POPUPPanel").hide();
        var v = $(this).val();
        if (v == "Color") {
            $(".POPUPHeaderText").html("Create New Color");
            $("#POPUPIFrame").attr("src", "Master_Setup/frmColor.aspx");
        }
        if (v == "Shade") {
            $(".POPUPHeaderText").html("Create New Shade");
            $("#POPUPIFrame").attr("src", "Master_Setup/frmShade.aspx");
        }
        if (v == "Country") {
            $(".POPUPHeaderText").html("Create New Country");
            $("#POPUPIFrame").attr("src", "Master_Setup/frmCountry.aspx");
        }
        $(".POPUPPanel").toggle("slow");
        return false; 
    });
    $(".POPUPClose").click(function () {
        $(".POPUPPanel").toggle("slow");
    });
    //klj

});

function abctst(chk,gridview) {
    //alert(gridview);
    if (!(document.getElementById(chk).checked)) {
        //Tot = parseFloat(RowM) - parseFloat(Mcatvalue);
        alert("Unchecked");
    }
    else {
        var gvDrv = document.getElementById(gridview);
            for (i = 1; i < gvDrv.rows.length - 1; i++) {
                var loopcel = gvDrv.rows[i].cells;
                var loopcellvalue = loopcel[1].innerText;
                 alert(loopcellvalue);

        }
        //alert(gvDrv);
     }
}
function GetPackQty(TextBoxa, textboxb) {   
        document.getElementById(textboxb).value = document.getElementById(TextBoxa).value;
}