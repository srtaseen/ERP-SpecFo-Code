using System;
using System.Configuration;
using System.Data.SqlClient;

public class GetWay
{
    private static SqlConnection _ConIE;
    private static SqlConnection _ConInventory;
    private static SqlConnection _ConSpecFo;
    private static SqlConnection _smrtcode;

    public static SqlConnection SpecFo_IE
    {
        get
        {
            if (_ConIE == null)
            {
                _ConIE = new SqlConnection(ConfigurationManager.ConnectionStrings["Iecon"].ConnectionString);
            }
            return _ConIE;
        }
    }

    public static SqlConnection SpecFo_Inventorycon
    {
        get
        {
            if (_ConInventory == null)
            {
                _ConInventory = new SqlConnection(ConfigurationManager.ConnectionStrings["invcon"].ConnectionString);
            }
            return _ConInventory;
        }
    }

    public static SqlConnection SpecFo_Smartcode
    {
        get
        {
            if (_smrtcode == null)
            {
                _smrtcode = new SqlConnection(ConfigurationManager.ConnectionStrings["smartcon"].ConnectionString);
            }
            return _smrtcode;
        }
    }

    public static SqlConnection SpecFoCon
    {
        get
        {
            if (_ConSpecFo == null)
            {
                _ConSpecFo = new SqlConnection(ConfigurationManager.ConnectionStrings["SpecFocon"].ConnectionString);
            }
            return _ConSpecFo;
        }
    }
}