

        function itmedt() {
            var stl = $("[id*='drpstyle'] :selected").val();
            $("#ifrmst").attr("src", "Merchandising/StyleMaster/Viewdtl.aspx?x=" + stl + "");
            $("#dvstldtl").toggle("slow");
        }
       
        


        function addcolor() {
            var stl = $("[id*='drpstyle'] :selected").val();
            var lot = $("[id$='txtLot']").val();            
            if (stl.length > 0) {
                if (lot.length > 0) {
                    onunload();
                    document.getElementById("txtchkjv").value = "1";
                    $("#hdrtxt").html("Add/Edit Color");
                    $("#ifupldfile").attr("src", "Merchandising/Assortment/Addcolor.aspx?x=" + stl + "&y=" + lot + "");
                    var bid = $find('ppadditm');
                    bid.show();
                }
                else {
                    alert("Select PO No");
                }
            }
            else {
                alert("First Select Style");
            }
            }
            function Addsize() {
                var stl = $("[id*='drpstyle'] :selected").val();
                var lot = $("[id$='txtLot']").val();            
                if (stl.length > 0) {
                    if (lot.length > 0) {
                onunload();
                document.getElementById("txtchkjv").value = "1";
                $("#hdrtxt").html("Add/Edit Size");
                $("#ifupldfile").attr("src", "Merchandising/Assortment/Addsize.aspx?x=" + stl + "&y=" + lot + "");
                var bid = $find('ppadditm');
                bid.show();
                }
                    else {
                        alert("Select PO No");
                    }
                }
                else {
                    alert("First Select Style");
                }
            }
            function addqty() {
            var stl = $("[id*='drpstyle'] :selected").val();
                var lot = $("[id$='txtLot']").val();            
                if (stl.length > 0) {
                    if (lot.length > 0) {
                onunload();
                document.getElementById("txtchkjv").value = "1";
                $("#hdrtxt").html("Add/Edit Quantity");
                $("#ifupldfile").attr("src", "Merchandising/Assortment/AddQty.aspx?x=" + stl + "&y=" + lot + "");
                var bid = $find('ppadditm');
                bid.show();
            }
            else {
                alert("Select PO No");
            }
        }
        else {
            alert("First Select Style");
        }
    }
    function addinseamsize() {
        var stl = $("[id*='drpstyle'] :selected").val();
        var lot = $("[id$='txtLot']").val();
        if (stl.length > 0) {
            if (lot.length > 0) {
                onunload();
                document.getElementById("txtchkjv").value = "1";
                $("#hdrtxt").html("Add/Edit Inseam Size");
                $("#ifupldfile").attr("src", "Merchandising/Assortment/Inseam.aspx?x=" + stl + "&y=" + lot + "");
                var bid = $find('ppadditm');
                bid.show();
            }
            else {
                alert("Select PO No");
            }
        }
        else {
            alert("First Select Style");
        }
    }
    function insmqty() {
        var stl = $("[id*='drpstyle'] :selected").val();
        var lot = $("[id$='txtLot']").val();
        if (stl.length > 0) {
            if (lot.length > 0) {
                onunload();
                document.getElementById("txtchkjv").value = "1";
                $("#hdrtxt").html("Add/Edit Inseam Quantity");
                $("#ifupldfile").attr("src", "Merchandising/Assortment/Inseamqty.aspx?x=" + stl + "&y=" + lot + "");
                var bid = $find('ppadditm');
                bid.show();
            }
            else {
                alert("Select PO No");
            }
        }
        else {
            alert("First Select Style");
        }
    }
    function insmrpt() {
        var stl = $("[id*='drpstyle'] :selected").val();
        var lot = $("[id$='txtLot']").val();
        if (stl.length > 0) {
            if (lot.length > 0) {
                onunload();
                document.getElementById("txtchkjv").value = "1";
                $("#hdrtxt").html("Inseam Report");
                $("#ifupldfile").attr("src", "Merchandising/Assortment/Inseamrpt.aspx?x=" + stl + "&y=" + lot + "");
                var bid = $find('ppadditm');
                bid.show();
            }
            else {
                alert("Select PO No");
            }
        }
        else {
            alert("First Select Style");
        }
    }

    

            function viewpackwise() {
            var stl = $("[id*='drpstyle'] :selected").val();
            var lot = $("[id$='txtLot']").val();            
            if (stl.length > 0) {
                if (lot.length > 0) {
                onunload();
                document.getElementById("txtchkjv").value = "1";
                $("#hdrtxt").html("View Pack Wise Qty");
                $("#ifupldfile").attr("src", "Merchandising/Assortment/Vwqtypackwise.aspx?x=" + stl + "&y=" + lot + "");
                var bid = $find('ppadditm');
                bid.show();
            }
            else {
                alert("Select PO No");
            }
                }
                else {
                    alert("First Select Style");
                }
            }
            function packwiserpt() {
                var stl = $("[id*='drpstyle'] :selected").val();
                var lot = $("[id$='txtLot']").val();
                if (stl.length > 0) {
                    if (lot.length > 0) {
                        onunload();
                        document.getElementById("txtchkjv").value = "1";
                        $("#hdrtxt").html("View Pack Wise Qty");
                        $("#ifupldfile").attr("src", "Merchandising/Assortment/packwiserpt.aspx?x=" + stl + "&y=" + lot + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select PO No");
                    }
                }
                else {
                    alert("First Select Style");
                }



            }

            function countrywiserpt() {
                var stl = $("[id*='drpstyle'] :selected").val();
                var lot = $("[id$='txtLot']").val();
                if (stl.length > 0) {
                    if (lot.length > 0) {
                        onunload();
                        document.getElementById("txtchkjv").value = "1";
                        $("#hdrtxt").html("Country Wise Report");
                        $("#ifupldfile").attr("src", "Merchandising/Assortment/Countrywiserpt.aspx?x=" + stl + "&y=" + lot + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select PO No");
                    }
                }
                else {
                    alert("First Select Style");
                }
            }      

            function breakdown() {
             var stl = $("[id*='drpstyle'] :selected").val();
            var lot = $("[id$='txtLot']").val();            
            if (stl.length > 0) {
                if (lot.length > 0) {
                onunload();
                document.getElementById("txtchkjv").value = "1";
                $("#hdrtxt").html("Quantity Breakdown");
                $("#ifupldfile").attr("src", "Merchandising/Assortment/vwbreakdown.aspx?x=" + stl + "&y=" + lot + "");
                var bid = $find('ppadditm');
                bid.show();
                }
            else {
                alert("Select PO No");
            }
                }
                else {
                    alert("First Select Style");
                }
            
            }
            function breakdwonrpt() {
                var stl = $("[id*='drpstyle'] :selected").val();
                var lot = $("[id$='txtLot']").val();
                if (stl.length > 0) {
                    if (lot.length > 0) {
                        onunload();
                        document.getElementById("txtchkjv").value = "1";
                        $("#hdrtxt").html("Quantity Breakdown report");
                        $("#ifupldfile").attr("src", "Merchandising/Assortment/breakdownrpt.aspx?x=" + stl + "&y=" + lot + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select PO No");
                    }
                }
                else {
                    alert("First Select Style");
                }

            }
            function colsizewiseprice() {

                var stl = $("[id*='drpstyle'] :selected").val();
                var lot = $("[id$='txtLot']").val();
                if (stl.length > 0) {
                    if (lot.length > 0) {
                        onunload();
                        document.getElementById("txtchkjv").value = "1";
                        $("#hdrtxt").html("Color/Size Wise Price");
                        $("#ifupldfile").attr("src", "Merchandising/Assortment/colsizewiseprice.aspx?x=" + stl + "&y=" + lot + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select PO No");
                    }
                }
                else {
                    alert("First Select Style");
                }
            }
            function colsizewisepricerpt() {
                var stl = $("[id*='drpstyle'] :selected").val();
                var lot = $("[id$='txtLot']").val();
                if (stl.length > 0) {
                    if (lot.length > 0) {
                        onunload();
                        document.getElementById("txtchkjv").value = "1";
                        $("#hdrtxt").html("Color/Size Wise Price Report");
                        $("#ifupldfile").attr("src", "Merchandising/Assortment/colsizewisepricerpt.aspx?x=" + stl + "&y=" + lot + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select PO No");
                    }
                }
                else {
                    alert("First Select Style");
                }
            }

            function stylestatus() {
                var stl = $("[id*='drpstyle'] :selected").val();              
                if (stl.length > 0) {               
                        onunload();
                        document.getElementById("txtchkjv").value = "1";
                        $("#hdrtxt").html("Style Status Details");
                        $("#ifupldfile").attr("src", "Merchandising/Assortment/vwstylestatus.aspx?x=" + stl + "");
                        var bid = $find('ppadditm');
                        bid.show();                  
                }
                else {
                    alert("First Select Style");
                }            
            }
            function stylestatusrpt() {
                var stl = $("[id*='drpstyle'] :selected").val();
                if (stl.length > 0) {
                    onunload();
                    document.getElementById("txtchkjv").value = "1";
                    $("#hdrtxt").html("Style Status Report");
                    $("#ifupldfile").attr("src", "Merchandising/Assortment/stylestatusrpt.aspx?x=" + stl + "");
                    var bid = $find('ppadditm');
                    bid.show();
                }
                else {
                    alert("First Select Style");
                }
            }
            function addnewpo() {
                var stl = $("[id*='drpstyle'] :selected").text();
                window.location.replace("Smt_Mer_Stylemaster.aspx?x="+stl+"");
            }
            function viewstyledtl() {
                var stl = $("[id*='drpstyle'] :selected").val();
                if (stl.length > 0) {
                    onunload();
                    document.getElementById("txtchkjv").value = "1";
                    $("#hdrtxt").html("View Style Details");
                    $("#ifupldfile").attr("src", "Merchandising/StyleMaster/Viewdtl.aspx?x=" + stl + "");
                    var bid = $find('ppadditm');
                    bid.show();
                }
                else {
                    alert("First Select Style");
                }
            }
            function stlsum() {
                var stl = $("[id*='drpstyle'] :selected").val();
                if (stl.length > 0) {
                    onunload();
                    document.getElementById("txtchkjv").value = "1";
                    $("#hdrtxt").html("View Style Details");
                    $("#ifupldfile").attr("src", "Merchandising/Assortment/stylesummery.aspx?x=" + stl + "");
                    var bid = $find('ppadditm');
                    bid.show();
                }
                else {
                    alert("First Select Style");
                }
            }
            function hideLoading() {
                document.getElementById('divLoading').style.display = "none";
                document.getElementById('divFrameHolder').style.display = "block";
            }
            function onunload() {
                document.getElementById('divLoading').style.display = "block";
                document.getElementById('divFrameHolder').style.display = "none";
            }
            function CheckOtherIsCheckedByGVID(spanChk) {
                var IsChecked = spanChk.checked;
                var CurrentRdbID = spanChk.id;
                var Chk = spanChk;
                Parent = document.getElementById("<%=grdpodtl.ClientID%>");
                var items = Parent.getElementsByTagName('input');
                for (i = 0; i < items.length; i++) {
                    if (items[i].id != CurrentRdbID && items[i].type == "radio") {
                        if (items[i].checked) {
                            items[i].checked = false;
                            
                        }
                    }
                }
                var gt = document.getElementById('<%= grdpodtl.ClientID %>');
                var tval = "";
                for (i = 1; i < gt.rows.length; i++) {
                    gt.rows[i].style.background = '';
                    gt.rows[i].style.color = 'black';
                    var l00pcell = gt.rows[i].cells;
                    var loopcellvalue = l00pcell[0].getElementsByTagName("input")[0];
                    var slnoval = l00pcell[0].getElementsByTagName("input")[1].value;
                    if (loopcellvalue.type == "radio" && loopcellvalue.checked) {
                        tval = l00pcell[1].innerText;
                        $("[id$='txtLot']").val(slnoval);
                        gt.rows[i].style.background = '#23A9BF';
                        gt.rows[i].style.color = 'white';
                    }
                }
            }        
           