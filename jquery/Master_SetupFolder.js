$(document).ready(function () {
    $(document).bind("contextmenu", function (e) {
        //alert("Sorry");
        return false;

    });
});
//clear errormessage on focus
function clearlabel(labelid) {
    document.getElementById(labelid).innerHTML = '';
}
function blinkColor() {
    document.getElementById('lblErrormsg').style.background = ""
    document.getElementById('lblErrormsg').style.color = "transparent"
    setTimeout("setblinkColor()", 500)
}
function setblinkColor() {
    document.getElementById('lblErrormsg').style.background = "#0099FF"
    document.getElementById('lblErrormsg').style.color = "white"
    setTimeout("blinkColor()", 1000)
}


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
        else
      {
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