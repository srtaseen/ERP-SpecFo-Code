using System;
using System.Data;
using System.Data.SqlClient;

public class MC
{
    public void MC_Save(string procdr, SqlConnection cn, string[] normalparam, string[] normalprmval, string[] dtmparam, string[] dtmparamval)
    {
        SqlCommand command = new SqlCommand(procdr, cn)
        {
            CommandType = CommandType.StoredProcedure
        };
        if (normalparam.Length > 0)
        {
            for (int i = 0; i < normalparam.Length; i++)
            {
                string parameterName = normalparam[i];
                string str2 = normalprmval[i];
                if (!string.IsNullOrEmpty(str2))
                {
                    command.Parameters.AddWithValue(parameterName, str2);
                }
                else
                {
                    command.Parameters.AddWithValue(parameterName, DBNull.Value);
                }
            }
        }
        if (dtmparam.Length > 0)
        {
            for (int j = 0; j < dtmparam.Length; j++)
            {
                string str3 = dtmparam[j];
                string str4 = dtmparamval[j];
                if (!string.IsNullOrEmpty(str4))
                {
                    command.Parameters.AddWithValue(str3, string.Format("{0:dd/MM/yyyy}", str4));
                }
                else
                {
                    command.Parameters.AddWithValue(str3, DBNull.Value);
                }
                command.Parameters[str3].SqlDbType = SqlDbType.SmallDateTime;
            }
        }
        command.ExecuteNonQuery();
    }

    public void MC_Save_nodt(string procdr, SqlConnection cn, string[] normalparam, string[] normalprmval)
    {
        SqlCommand command = new SqlCommand(procdr, cn)
        {
            CommandType = CommandType.StoredProcedure
        };
        if (normalparam.Length > 0)
        {
            for (int i = 0; i < normalparam.Length; i++)
            {
                string parameterName = normalparam[i];
                string str2 = normalprmval[i];
                if (!string.IsNullOrEmpty(str2))
                {
                    command.Parameters.AddWithValue(parameterName, str2);
                }
                else
                {
                    command.Parameters.AddWithValue(parameterName, DBNull.Value);
                }
            }
        }
        command.ExecuteNonQuery();
    }

    public void MC_Save_nodt_tr(string procdr, SqlConnection cn, SqlTransaction tr, string[] normalparam, string[] normalprmval)
    {
        SqlCommand command = new SqlCommand(procdr, cn, tr)
        {
            CommandType = CommandType.StoredProcedure
        };
        if (normalparam.Length > 0)
        {
            for (int i = 0; i < normalparam.Length; i++)
            {
                string parameterName = normalparam[i];
                string str2 = normalprmval[i];
                if (!string.IsNullOrEmpty(str2))
                {
                    command.Parameters.AddWithValue(parameterName, str2);
                }
                else
                {
                    command.Parameters.AddWithValue(parameterName, DBNull.Value);
                }
            }
        }
        command.ExecuteNonQuery();
    }

    public void MC_Save_tr(string procdr, SqlConnection cn, SqlTransaction tn, string[] normalparam, string[] normalprmval, string[] dtmparam, string[] dtmparamval)
    {
        SqlCommand command = new SqlCommand(procdr, cn, tn)
        {
            CommandType = CommandType.StoredProcedure
        };
        if (normalparam.Length > 0)
        {
            for (int i = 0; i < normalparam.Length; i++)
            {
                string parameterName = normalparam[i];
                string str2 = normalprmval[i];
                if (!string.IsNullOrEmpty(str2))
                {
                    command.Parameters.AddWithValue(parameterName, str2);
                }
                else
                {
                    command.Parameters.AddWithValue(parameterName, DBNull.Value);
                }
            }
        }
        if (dtmparam.Length > 0)
        {
            for (int j = 0; j < dtmparam.Length; j++)
            {
                string str3 = dtmparam[j];
                string str4 = dtmparamval[j];
                if (!string.IsNullOrEmpty(str4))
                {
                    command.Parameters.AddWithValue(str3, string.Format("{0:dd/MM/yyyy}", str4));
                }
                else
                {
                    command.Parameters.AddWithValue(str3, DBNull.Value);
                }
                command.Parameters[str3].SqlDbType = SqlDbType.SmallDateTime;
            }
        }
        command.ExecuteNonQuery();
    }
}
