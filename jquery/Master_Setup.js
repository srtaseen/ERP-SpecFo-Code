$(document).ready(function () {
    $(".MasterSetupBTN").live("click",function () {
        $(".POPUPPanel").hide();
        var btntxt = $(this).val();
        if (btntxt == "Buyer") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmBuyer.aspx");
            $(".POPUPHeaderText").html("Create Buyer");
        }
        if (btntxt == "Brand") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmBrand.aspx");
            $(".POPUPHeaderText").html("Create Brand");
        }
        if (btntxt == "Store") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmStore.aspx");
            $(".POPUPHeaderText").html("Create Store");
        }
        if (btntxt == "Season") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmSeason.aspx");
            $(".POPUPHeaderText").html("Create Season");
        }
        if (btntxt == "Color") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmColor.aspx");
            $(".POPUPHeaderText").html("Create Color");
        }
        if (btntxt == "Company") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmCompany.aspx");
            $(".POPUPHeaderText").html("Create Company");
        }
        if (btntxt == "Department") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmDepartment.aspx");
            $(".POPUPHeaderText").html("Create Department");
        }
        if (btntxt == "Section") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmSection.aspx");
            $(".POPUPHeaderText").html("Create Section");
        }
        if (btntxt == "Floor") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmFloor.aspx");
            $(".POPUPHeaderText").html("Create Floor");
        }
        if (btntxt == "Shade") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmShade.aspx");
            $(".POPUPHeaderText").html("Create Shade");
        }

        if (btntxt == "Color Group") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmColorgroup.aspx");
            $(".POPUPHeaderText").html("Create Section");
        }
        if (btntxt == "Country") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmCountry.aspx");
            $(".POPUPHeaderText").html("Create Country");
        }
        if (btntxt == "Designation") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmDesignation.aspx");
            $(".POPUPHeaderText").html("Create Designation");
        }
        if (btntxt == "Garment Type") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmGmttype.aspx");
            $(".POPUPHeaderText").html("Create Garment Type");
        }
        if (btntxt == "Gmt. Department") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmGmtDept.aspx");
            $(".POPUPHeaderText").html("Create Garment Department");
        }
        if (btntxt == "Master Category") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmMasterCategory.aspx");
            $(".POPUPHeaderText").html("Create Master Category");
        }
        if (btntxt == "Main Category") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmMainCategory.aspx");
            $(".POPUPHeaderText").html("Create Main Category");
        }
        if (btntxt == "Sub Category") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmSupCategory.aspx");
            $(".POPUPHeaderText").html("Create Sub Category");
        }
        if (btntxt == "Style Type") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmStyleType.aspx");
            $(".POPUPHeaderText").html("Create Style Type");
        }
        if (btntxt == "Unit") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmUnit.aspx");
            $(".POPUPHeaderText").html("Create Unit");
        }
        if (btntxt == "Article") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmArticle.aspx");
            $(".POPUPHeaderText").html("Create Article");
        }
        if (btntxt == "Dimension") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmDimension.aspx");
            $(".POPUPHeaderText").html("Create Dimension");
        }
        if (btntxt == "Supplier Type") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmSupplierType.aspx");
            $(".POPUPHeaderText").html("Create Supplier Type");
        }
        if (btntxt == "Supplier") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmSupplier.aspx");
            $(".POPUPHeaderText").html("Create Supplier");
        }
        if (btntxt == "Currency Type") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmCurrencyType.aspx");
            $(".POPUPHeaderText").html("Create Currency Type");
        }
        if (btntxt == "User Group") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmUserGroup.aspx");
            $(".POPUPHeaderText").html("Create User Group");
        }
        if (btntxt == "User Level") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmUserLebel.aspx");
            $(".POPUPHeaderText").html("Create User Level");
        }
        if (btntxt == "New User") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmNewUser.aspx");
            $(".POPUPHeaderText").html("Create New User");
        }
        if (btntxt == "Factory") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmCompany.aspx");
            $(".POPUPHeaderText").html("Create Factory");
        }
        if (btntxt == "Bank Info") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmBankInfo.aspx");
            $(".POPUPHeaderText").html("Create New Bank");
        }
        if (btntxt == "Payment Mode") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmPaymentMode.aspx");
            $(".POPUPHeaderText").html("Create Payment Mode");
        }
        if (btntxt == "Payment Term") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmPaymentTerm.aspx");
            $(".POPUPHeaderText").html("Create Payment Term");
        }
        if (btntxt == "Storage Plan") {
            $("#POPUPIFrame").attr("src", "Master_Setup/Smt_Storage.aspx");
            $(".POPUPHeaderText").html("Create New Storage Plan");
        }
        if (btntxt == "Button Permission") {
            $("#POPUPIFrame").attr("src", "Master_Setup/bt.aspx");
            $(".POPUPHeaderText").html("Create New Security Plan");
        }
        if (btntxt == "User Log") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmuserlog.aspx");
            $(".POPUPHeaderText").html("User Login Details");
        }
        if (btntxt == "Line") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmLine.aspx");
            $(".POPUPHeaderText").html("Define Line");
        }
        if (btntxt == "Building Unit") {
            $("#POPUPIFrame").attr("src", "Master_Setup/Smt_Buildingunit.aspx");
            $(".POPUPHeaderText").html("Define Building Unit");
        }
        if (btntxt == "Learning Curve") {
            $("#POPUPIFrame").attr("src", "Master_Setup/frmLearningcurve.aspx");
            $(".POPUPHeaderText").html("Define Learning Curve");
        }
        if (btntxt == "Buyer Account") {
            $("#POPUPIFrame").attr("src", "Master_Setup/BuyerAccount.aspx");
            $(".POPUPHeaderText").html("Create Buyer Account");
        }
        if (btntxt == "Unit Group") {
            $("#POPUPIFrame").attr("src", "Master_Setup/UnitGroup.aspx");
            $(".POPUPHeaderText").html("Unit Group");
        }                
        
        $(".POPUPPanel").toggle("slow");       
        return false;
    });
    $(".POPUPClose").click(function () {
      $(".POPUPPanel").toggle("slow");
    });
});