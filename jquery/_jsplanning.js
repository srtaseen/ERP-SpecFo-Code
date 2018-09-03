function Calculate10Hour (txthour, txt10hour) {
    var _Perhour = document.getElementById(txthour).value;
    document.getElementById(txt10hour).value="0";
    if (_Perhour.length > 0) {
        var _Total = parseFloat(_Perhour * 10);
        if (!isNaN(_Total)) {
            document.getElementById(txt10hour).value = _Total;
        }
    }
}


//function CalculateDQty(txtStartdt,txtthour,txtfactdt,txtT10,lbl) { 

//var txtStartdt=document.getElementById(txtStartdt).value;
//var txtthour=document.getElementById(txtthour).value;
//var txtfactdt=document.getElementById(txtfactdt).value;       
//var txtT10=document.getElementById(txtT10).value;
//var txtDevQty=document.getElementById(txtDevQty).value;        
// if(txtStartdt.length<1)
// {
//    alert("Enter Start Date First");
// }
// else
// {
// if(txtthour.length>0)
// {
//        var dtStart=txtStartdt;
//        var    dtFx=txtfactdt;
//        var startdt=dtStart;    
//        var DevQty = 0;
//        var _loop = 0;               
//        var Actualqty = parseFloat(txtDevQty);
//        var IncreaseQty = 0;
//        if(txtT10.length>0)
//        {
//               DevQty =parseFloat(txtT10);
//        } 
//        while (startdt <= dtFx)
//          {
//                   
//                        var _day = startdt.Day;
//                        var Fcontrol = "txtD" + _day;
//                        TextBox txtfdt = (TextBox)ro.FindControl(Fcontrol);
//                        string dayname = (startdt.DayOfWeek).ToString();
//                        if (dayname.ToUpper() != "SUNDAY")
//                        {
//                        if (_loop == 0)
//                        {
//                            int Totalqty = (DevQty / 100) * 60;
//                            if (IncreaseQty <= Actualqty)
//                            {
//                                int x = (Actualqty - IncreaseQty);
//                                if (x < Totalqty)
//                                {
//                                    txtfdt.Text = x.ToString();
//                                    IncreaseQty = IncreaseQty + Totalqty;
//                                }
//                                else
//                                {
//                                    txtfdt.Text = Totalqty.ToString();
//                                    IncreaseQty = IncreaseQty + Totalqty;
//                                }
//                            }
//                            else
//                            {
//                                txtfdt.Text = "0";
//                            }
//                        }
//                        else if (_loop == 1)
//                        {
//                            int Totalqty = (DevQty / 100) * 80;
//                            if (IncreaseQty <= Actualqty)
//                            {
//                                int x = (Actualqty - IncreaseQty);
//                                if (x < Totalqty)
//                                {
//                                    txtfdt.Text = x.ToString();
//                                    IncreaseQty = IncreaseQty + Totalqty;
//                                }
//                                else
//                                {
//                                    txtfdt.Text = Totalqty.ToString();
//                                    IncreaseQty = IncreaseQty + Totalqty;
//                                }
//                            }
//                            else
//                            {
//                                txtfdt.Text = "0";
//                            }

//                        }
//                        else
//                        {
//                            int Totalqty = (DevQty / 100) * 100;
//                            if (IncreaseQty <= Actualqty)
//                            {
//                                int x = (Actualqty - IncreaseQty);
//                                if (x < Totalqty)
//                                {
//                                    txtfdt.Text = x.ToString();
//                                    IncreaseQty = IncreaseQty + Totalqty;
//                                }
//                                else
//                                {
//                                    txtfdt.Text = Totalqty.ToString();
//                                    IncreaseQty = IncreaseQty + Totalqty;
//                                }
//                            }
//                            else
//                            {
//                                txtfdt.Text = "0";
//                            }

//                        }
//                        _loop = _loop + 1;
//                        startdt = startdt.AddDays(1);
//                    }
//                    else
//                    {
//                        txtfdt.Text = "0";
//                        txtfdt.BackColor = System.Drawing.Color.Pink;
//                        txtfdt.ToolTip = "Sunday";
//                        _loop = _loop + 1;
//                        startdt = startdt.AddDays(1);
//                    }


//                    //
//                }                           

//            }
//        }
//            ro.BackColor = System.Drawing.Color.FromName("#0FB1FF");



//}