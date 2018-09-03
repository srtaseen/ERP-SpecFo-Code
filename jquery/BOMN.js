
        $(document).ready(function () {
            var ht = $(window).height();
            var wt = $(window).width();
            if (parseFloat(wt) < 1050) {
                $("#dvedt").toggle("medium");
            }
        });

        function rfsh() {
            var x = $("[id$='txtchkjv']").val();
            if (x.length > 0) {
                if (x = "1") {
                    $("[id$='btnStyleref']").click();
                }
            }
        }
        function itmedt() {         
            $("#dvedt").toggle("slow");           
        }

        function AddItem() {
            $("[id$='txtchkjv']").val('');    
           var stl = $("[id*='drpstyle'] :selected").val();
           if (stl.length > 0) {
               onunload();              
               $("#hdrtxt").html("Add New Item");
               $("#ifupldfile").attr("src", "Merchandising/BOM/AddItem.aspx?x=" + stl + "");
               var bid = $find('ppadditm');
               bid.show();
           }
           else {
               alert("Select Style First");
           }
                }
                function addpo() {
                    $("[id$='txtchkjv']").val('');    
                    var stl = $("[id*='drpstyle'] :selected").val();
                    if (stl.length > 0) {
                        onunload();
                        document.getElementById("txtchkjv").value = "1";
                        $("#hdrtxt").html("PO Sensitivity");
                        $("#ifupldfile").attr("src", "Merchandising/BOM/POSen.aspx?x=" + stl + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select Style First");
                    }
                }
                function countrysen() {
                    $("[id$='txtchkjv']").val('');    
                    var stl = $("[id*='drpstyle'] :selected").val();
                    if (stl.length > 0) {
                        onunload();                        
                        $("#hdrtxt").html("Country Sensitivity");
                        $("#ifupldfile").attr("src", "Merchandising/BOM/Countrysen.aspx?x=" + stl + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select Style First");
                    }
                }



                function datagenerate() {
                    var stl = $("[id*='drpstyle'] :selected").val();                                    
                        $("#hdrtxt").html("Data Generate");
                        $("#ifupldfile").attr("src", "Merchandising/BOM/Datagenerate.aspx?x=" + stl + "");
                        var bid = $find('ppadditm');
                        bid.show();                  
                  
                }


                function Colsen() {
                    $("[id$='txtchkjv']").val('');    
                    var stl = $("[id*='drpstyle'] :selected").val();
                    if (stl.length > 0) {
                        onunload();
                        
                        $("#hdrtxt").html("Color Sensintivity");
                        $("#ifupldfile").attr("src", "Merchandising/BOM/ColorSen.aspx?x=" + stl + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select Style First");
                    }
                }
                function SizeSen() {
                    $("[id$='txtchkjv']").val('');    
                    var stl = $("[id*='drpstyle'] :selected").val();
                    if (stl.length > 0) {
                        onunload();
                       
                        $("#hdrtxt").html("Size Sensitivity");
                        $("#ifupldfile").attr("src", "Merchandising/BOM/Sizesen.aspx?x=" + stl + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select Style First");
                    }
                }


                function stylestatus() {
                    $("[id$='txtchkjv']").val('');    
                    var stl = $("[id*='drpstyle'] :selected").val();
                    if (stl.length > 0) {
                        onunload();                        
                        $("#hdrtxt").html("Style PO Status");
                        $("#ifupldfile").attr("src", "Merchandising/BOM/Stylestatus.aspx?x=" + stl + "");
                        var bid = $find('ppadditm');
                        bid.show();
                    }
                    else {
                        alert("Select Style First");
                    }

        }
        function stylestatusrpt() {
            $("[id$='txtchkjv']").val('');    
            var stl = $("[id*='drpstyle'] :selected").val();
            if (stl.length > 0) {
                onunload();                
                $("#hdrtxt").html("Style Status Report");
                $("#ifupldfile").attr("src", "Merchandising/BOM/Report.aspx?x=" + stl + "");
                var bid = $find('ppadditm');
                bid.show();
            }
            else {
                alert("Select Style First");
            }
        }

        function maincat() {
            onunload();
           // document.getElementById("txtchkjv").value = "1";
            $("#hdrtxt").html("Add Main Category");
            $("#ifupldfile").attr("src", "Master_Setup/frmMainCategory.aspx");
            var bid = $find('ppadditm');
            bid.show();
        }
        function Subcat() {
            onunload();
           // document.getElementById("txtchkjv").value = "1";
            $("#hdrtxt").html("Add Sub Category");
            $("#ifupldfile").attr("src", "Master_Setup/frmSupCategory.aspx");
            var bid = $find('ppadditm');
            bid.show();
        }
        function Construction() {
            onunload();
           // document.getElementById("txtchkjv").value = "1";
            $("#hdrtxt").html("Add Construction");
            $("#ifupldfile").attr("src", "Master_Setup/frmArticle.aspx");
            var bid = $find('ppadditm');
            bid.show();
        }
        function Dimension() {
            onunload();
           // document.getElementById("txtchkjv").value = "1";
            $("#hdrtxt").html("Add Dimension");
            $("#ifupldfile").attr("src", "Master_Setup/frmDimension.aspx");
            var bid = $find('ppadditm');
            bid.show();
        }
        function Supplier() {
            onunload();
           // document.getElementById("txtchkjv").value = "1";
            $("#hdrtxt").html("Add Supplier");
            $("#ifupldfile").attr("src", "Master_Setup/frmSupplier.aspx");
            var bid = $find('ppadditm');
            bid.show();
        }

        function hideLoading() {
            document.getElementById('divLoading').style.display = "none";
            document.getElementById('divFrameHolder').style.display = "block";
        }
        function onunload() {
            document.getElementById('divLoading').style.display = "block";
            document.getElementById('divFrameHolder').style.display = "none";
        }

        function bomreqment() {
            var SelVal = $("[id*='drpconsmunit'] :selected").val();
            var param = "1";
            if (SelVal == "DOZ") {
               param = "12";
            }
           var UnitParam = $("[id$='txtUnitparam']").val();
           var com = $("[id$='txtConsumption']").val();
           var ordqty = $("[id$='txtordQty']").val();
           var wast = $("[id$='txtWstg']").val();
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
                $("[id$='txtRequirement']").val(roundtotal);               
            }
            var rate = $("[id$='txtRate']").val();
            var _Uprice = 0;
            if (rate.length > 0) {
                _Uprice = rate;
            }
            var req = $("[id$='txtRequirement']").val();
            var WithoutFixed = (eval(totalReq) * eval(_Uprice));
            var val = WithoutFixed.toFixed(2);
            if (!isNaN(val)) {
                $("[id$='txtValue']").val(val);
            }
        }

        function CheckOtherIsCheckedByGVID(spanChk) {
            var IsChecked = spanChk.checked;
            var CurrentRdbID = spanChk.id;
            var Chk = spanChk;
            Parent = document.getElementById("<%=grdBOMitm.ClientID%>");
            var items = Parent.getElementsByTagName('input');
            for (i = 0; i < items.length; i++) {
                if (items[i].id != CurrentRdbID && items[i].type == "radio") {
                    if (items[i].checked) {
                        items[i].checked = false;

                    }
                }
            }
            var gt = document.getElementById('<%= grdBOMitm.ClientID %>');
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
    