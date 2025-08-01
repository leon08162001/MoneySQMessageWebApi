﻿using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
//using Oracle.ManagedDataAccess.Client;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;

/// <summary>
/// 資料存取控制元件
/// </summary>
namespace DataAccess.DB
{
    [Serializable()]
    public class Dac : IDisposable
    {
        private dbtype Datatype;
        private IDbConnection DbCon;
        private IDbCommand Cmd;
        private IDbDataParameter Para;
        private IDataAdapter IDa;
        private int _CommandTimeOut = 600;
        private string _ConnectionConfigName = "Default";

        /// <summary>
        /// 執行SQL指令TimeOut的時間(秒)
        /// </summary>
        public int CommandTimeOut
        {
            get
            {
                return _CommandTimeOut;
            }
            set
            {
                _CommandTimeOut = value;
            }
        }
        /// <summary>
        /// 組態檔資料庫連線名稱
        /// </summary>
        public string ConnectionConfigName
        {
            get
            {
                return _ConnectionConfigName;
            }
            set
            {
                _ConnectionConfigName = value;
            }
        }

        public Dac(dbtype dbtype)
        {
            SetDBType(dbtype);
        }

        public Dac(dbtype dbtype, string ConnectionConfigName)
        {
            SetDBType(dbtype);
            this._ConnectionConfigName = ConnectionConfigName;
        }

        private void SetDBType(dbtype dbtype)
        {
            Datatype = dbtype;
            if (Datatype == dbtype.Access || Datatype == dbtype.Excel)
            {
                DbCon = new OleDbConnection();
                Cmd = new OleDbCommand();
                Para = new OleDbParameter();
                IDa = new OleDbDataAdapter();
            }
            else if (dbtype == dbtype.SQL_Server)
            {
                DbCon = new SqlConnection();
                Cmd = new SqlCommand();
                Para = new SqlParameter();
                IDa = new SqlDataAdapter();
            }
            else if (dbtype == dbtype.Oracle)
            {
                DbCon = new OracleConnection();
                Cmd = new OracleCommand();
                Para = new OracleParameter();
                IDa = new OracleDataAdapter();
            }
            else if (dbtype == dbtype.MySql)
            {
                DbCon = new MySqlConnection();
                Cmd = new MySqlCommand();
                Para = new MySqlParameter();
                IDa = new MySqlDataAdapter();
            }
        }
        /// <summary>
        /// 開啟資料庫
        /// </summary>
        /// <param name="ConnectionStr">取得connection string</param>
        private void Open(string ConnectionStr)
        {
            if (ConnectionStr == "") { ConnectionStr = ConfigurationManager.ConnectionStrings[this.ConnectionConfigName].ConnectionString; }
            DbCon.ConnectionString = ConnectionStr;
            DbCon.Open();
        }

        /// <summary>
        /// <see cref="Dac"/> class建構子
        /// </summary>
        /// <param name="UserInfo">The user info.</param>
        //public Dac(UserInformation UserInfo)
        //{
        //  userInfo=UserInfo;
        //}


        /// <summary>
        /// 關閉資料庫連線
        /// </summary>
        private void CloseDB()
        {
            if (DbCon.State == ConnectionState.Open)
            {
                DbCon.Close();
            }
        }

        /// <summary>
        /// 具體化Command物件,並加入整數型別的Return Value(主要用於執行預儲程序所影響的列數)
        /// </summary>
        /// <example>
        /// 以下為使用BuildIntCommand的範例程式：
        /// <code>
        /// // Create parameter array
        ///	SqlParameter[] parameters =
        ///	{
        ///		new SqlParameter( "@LOGIN_ID", SqlDbType.NVarChar, 50 ),	// 0
        ///		new SqlParameter( "@DOMAIN", SqlDbType.NVarChar, 50 ),	// 1
        ///	};
        ///	
        ///	// Set parameter values and directions
        ///	parameters[ 0 ].Value = LOGINID;
        ///	parameters[ 1 ].Value = DOMAIN;
        ///
        ///	SqlCommand cmd =BuildIntCommand("spCustomProcedure",parameters);
        /// </code>
        /// </example>
        /// <param name="StoredProcName">預存程序名稱</param>
        /// <param name="Parameters">預存程序的參數陣列</param>
        /// <returns></returns>
        private IDbCommand BuildIntCommand(string StoredProcName, IDataParameter[] Parameters)
        {
            IDbCommand command = BuildQueryCommand(StoredProcName, Parameters);
            IDbDataParameter Parameter = Para;
            Parameter.ParameterName = "ReturnValue";
            Parameter.DbType = DbType.Int32;
            Parameter.Size = 4;
            Parameter.Direction = ParameterDirection.ReturnValue;
            Parameter.Precision = 0;
            Parameter.Scale = 0;
            Parameter.SourceColumn = string.Empty;
            Parameter.SourceVersion = DataRowVersion.Default;
            Parameter.Value = null;
            command.Parameters.Add(Parameter);
            return command;
        }


        /// <summary>
        /// 具體化Command物件
        /// </summary>
        /// <example>
        /// 以下為使用BuildQueryCommand的範例程式：
        /// <code>
        /// // Create parameter array
        ///	SqlParameter[] parameters =
        ///	{
        ///		new SqlParameter( "@LOGIN_ID", SqlDbType.NVarChar, 50 ),	// 0
        ///		new SqlParameter( "@DOMAIN", SqlDbType.NVarChar, 50 ),	// 1
        ///	};
        ///	
        ///	// Set parameter values and directions
        ///	parameters[ 0 ].Value = LOGINID;
        ///	parameters[ 1 ].Value = DOMAIN;
        ///
        ///	SqlCommand cmd =BuildIntCommand("spQueryProcedure",parameters);
        /// </code>
        /// </example>
        /// <param name="StoredProcName">預存程序名稱</param>
        /// <param name="Parameters">預存程序參數陣列</param>
        /// <returns></returns>
        private IDbCommand BuildQueryCommand(string StoredProcName, IDataParameter[] Parameters)
        {
            IDbCommand command = Cmd;
            command.CommandText = StoredProcName;
            command.Connection = DbCon;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = CommandTimeOut;
            command.Parameters.Clear();
            if (Parameters != null)
            {
                foreach (IDataParameter Parameter in Parameters)
                {
                    command.Parameters.Add(Parameter);
                }
            }
            return command;
        }


        /// <summary>
        /// 執行預儲程序並傳回影響的列數
        /// </summary>
        /// <example>
        /// 以下為使用RunProcedure的範例程式：
        /// <code>
        /// // Create parameter array
        ///	SqlParameter[] parameters =
        ///	{
        ///		new SqlParameter( "@LOGIN_ID", SqlDbType.NVarChar, 50 ),	// 0
        ///		new SqlParameter( "@DOMAIN", SqlDbType.NVarChar, 50 ),	// 1
        ///	};
        ///	
        ///	// Set parameter values and directions
        ///	parameters[ 0 ].Value = LOGINID;
        ///	parameters[ 1 ].Value = DOMAIN;
        ///
        ///int rowsAffected=0; 
        ///BuildIntCommand("spUpdateProcedure",parameters,"Default",rowsAffected);
        ///if(rowsAffected==0)
        ///		ShowErrorMessage("執行失敗");
        ///	else 
        ///		ShowErrorMessage("執行成功");
        /// </code>
        /// </example>
        /// <param name="StoredProcName">預存程序名稱</param>
        /// <param name="Parameters">預存程序參數陣列</param>
        /// <param name="Connection">Conncetion名稱</param>
        /// <param name="rowsAffected">影響的列數</param>
        public void RunProcedure(string StoredProcName, IDataParameter[] Parameters, string Connection, out int rowsAffected)
        {
            IDbCommand command = BuildIntCommand(StoredProcName, Parameters);
            try
            {
                Open(Connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                rowsAffected = (int)command.Parameters["ReturnValue"];
                CloseDB();
            }
        }

        public void RunProcedure(string StoredProcName, IDataParameter[] Parameters, string Connection, out int rowsAffected, bool IsUseTransaction)
        {
            IDbCommand command = BuildIntCommand(StoredProcName, Parameters);
            IDbTransaction trans; 
            try
            {
                Open(Connection);
                if (IsUseTransaction)
                {
                    trans = DbCon.BeginTransaction();
                    try
                    {
                        command.ExecuteNonQuery();
                        trans.Commit();
                    }
                    catch (Exception iex)
                    {
                        trans.Rollback();
                        throw iex;
                    }
                }
                else
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                rowsAffected = (int)command.Parameters["ReturnValue"];
                CloseDB();
            }
        }

        /// <summary>
        /// 執行預儲程序並傳回DataReaader物件
        /// </summary>
        /// <example>
        /// 以下為使用RunProcedure的範例程式：
        /// <code>
        /// // Create parameter array
        ///	SqlParameter[] parameters =
        ///	{
        ///		new SqlParameter( "@LOGIN_ID", SqlDbType.NVarChar, 50 ),	// 0
        ///		new SqlParameter( "@DOMAIN", SqlDbType.NVarChar, 50 ),	// 1
        ///	};
        ///	
        ///	// Set parameter values and directions
        ///	parameters[ 0 ].Value = LOGINID;
        ///	parameters[ 1 ].Value = DOMAIN;
        ///
        ///	SqlDataReader cmd =RunProcedure("spQueryProcedure",parameters,"Default");
        /// </code>
        /// </example>
        /// <param name="StoredProcName">預存程序名稱</param>
        /// <param name="Parameters">預存程序參數陣列</param>
        /// <param name="Connection">Connection名稱</param>
        /// <returns></returns>
        public IDataReader RunProcedure(string StoredProcName, IDataParameter[] Parameters, string Connection)
        {
            IDbCommand command = BuildIntCommand(StoredProcName, Parameters);
            command.CommandType = CommandType.StoredProcedure;
            IDataReader sdr;
            try
            {
                Open(Connection);
                sdr = command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                CloseDB();
            }
            return sdr;
        }

        /// <summary>
        /// 執行預儲程序並傳回DataTable物件
        /// </summary>
        /// <example>
        /// 以下為使用RunProcedure的範例程式：
        /// <code>
        /// // Create parameter array
        ///	SqlParameter[] parameters =
        ///	{
        ///		new SqlParameter( "@LOGIN_ID", SqlDbType.NVarChar, 50 ),	// 0
        ///		new SqlParameter( "@DOMAIN", SqlDbType.NVarChar, 50 ),	// 1
        ///	};
        ///	
        ///	// Set parameter values and directions
        ///	parameters[ 0 ].Value = LOGINID;
        ///	parameters[ 1 ].Value = DOMAIN;
        ///
        ///	DataTable cmd =RunProcedure("spQueryProcedure",parameters,"Default");
        /// </code>
        /// </example>
        /// <param name="StoredProcName">預存程序名稱</param>
        /// <param name="Parameters">預存程序參數陣列</param>
        /// <param name="TableName">DataTable名稱</param>
        /// <param name="Connection">Connection名稱</param>
        /// <returns></returns>
        public DataTable RunProcedure(string StoredProcName, IDataParameter[] Parameters, string TableName, string Connection)
        {
            DataTable dt = new DataTable(TableName);
            DbDataAdapter Da;
            try
            {
                Open(Connection);
                if (Datatype == dbtype.Access || Datatype == dbtype.Excel)
                {
                    Da = (OleDbDataAdapter)IDa;
                    Da.SelectCommand = (OleDbCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(dt);
                }
                else if (Datatype == dbtype.SQL_Server)
                {
                    Da = (SqlDataAdapter)IDa;
                    Da.SelectCommand = (SqlCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(dt);
                }
                else if (Datatype == dbtype.Oracle)
                {
                    Da = (OracleDataAdapter)IDa;
                    Da.SelectCommand = (OracleCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(dt);
                }
                else if (Datatype == dbtype.MySql)
                {
                    Da = (MySqlDataAdapter)IDa;
                    Da.SelectCommand = (MySqlCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(dt);
                }   
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                CloseDB();
            }
            return dt;
        }

        public DataTable RunProcedure(string StoredProcName, IDataParameter[] Parameters, string TableName, string Connection, bool IsUseTransaction)
        {
            DataTable dt = new DataTable(TableName);
            DbDataAdapter Da;
            IDbTransaction trans;
            try
            {
                Open(Connection);
                if (Datatype == dbtype.Access || Datatype == dbtype.Excel)
                {
                    Da = (OleDbDataAdapter)IDa;
                    Da.SelectCommand = (OleDbCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(dt);
                }
                else if (Datatype == dbtype.SQL_Server)
                {
                    Da = (SqlDataAdapter)IDa;
                    Da.SelectCommand = (SqlCommand)BuildQueryCommand(StoredProcName, Parameters);
                    if (IsUseTransaction)
                    {
                        trans = DbCon.BeginTransaction();
                        Da.SelectCommand.Transaction = (DbTransaction)trans;
                        try
                        {
                            Da.Fill(dt);
                            trans.Commit();
                        }
                        catch (Exception iex)
                        {
                            trans.Rollback();
                            throw iex;
                        }
                    }
                    else
                    {
                        Da.Fill(dt);
                    }
                }
                else if (Datatype == dbtype.Oracle)
                {
                    Da = (OracleDataAdapter)IDa;
                    Da.SelectCommand = (OracleCommand)BuildQueryCommand(StoredProcName, Parameters);
                    if (IsUseTransaction)
                    {
                        trans = DbCon.BeginTransaction();
                        Da.SelectCommand.Transaction = (DbTransaction)trans;
                        try
                        {
                            Da.Fill(dt);
                            trans.Commit();
                        }
                        catch (Exception iex)
                        {
                            trans.Rollback();
                            throw iex;
                        }
                    }
                    else
                    {
                        Da.Fill(dt);
                    }
                }
                else if (Datatype == dbtype.MySql)
                {
                    Da = (MySqlDataAdapter)IDa;
                    Da.SelectCommand = (MySqlCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                CloseDB();
            }
            return dt;
        }

        /// <summary>
        /// 執行預儲程序並將結果加入現有的Dataset中
        /// </summary>
        /// <example>
        /// 以下為使用RunProcedure的範例程式：
        /// <code>
        /// // Create parameter array
        ///	SqlParameter[] parameters =
        ///	{
        ///		new SqlParameter( "@LOGIN_ID", SqlDbType.NVarChar, 50 ),	// 0
        ///		new SqlParameter( "@DOMAIN", SqlDbType.NVarChar, 50 ),	// 1
        ///	};
        ///	
        ///	// Set parameter values and directions
        ///	parameters[ 0 ].Value = LOGINID;
        ///	parameters[ 1 ].Value = DOMAIN;
        ///
        ///	DataSet Ds = new DataSet();
        ///	RunProcedure("spQueryProcedure",parameters,Ds,"Table1","Default");
        /// </code>
        /// </example>
        /// <param name="StoredProcName">預存程序名稱</param>
        /// <param name="Parameters">預存程序參數陣列</param>
        /// <param name="Ds">DataSet物件</param>
        /// <param name="TableName">DataTable名稱</param>
        /// <param name="Connection">Connection名稱</param>
        public void RunProcedure(string StoredProcName, IDataParameter[] Parameters, ref DataSet Ds, string TableName, string Connection)
        {
            DbDataAdapter Da;
            try
            {
                Open(Connection);
                if (Datatype == dbtype.Access || Datatype == dbtype.Excel)
                {
                    Da = new OleDbDataAdapter();
                    Da.SelectCommand = (OleDbCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(Ds, TableName);
                }
                else if (Datatype == dbtype.SQL_Server)
                {
                    Da = new SqlDataAdapter();
                    Da.SelectCommand = (SqlCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(Ds, TableName);
                }
                else if (Datatype == dbtype.Oracle)
                {
                    Da = new OracleDataAdapter();
                    Da.SelectCommand = (OracleCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(Ds, TableName);
                }
                else if (Datatype == dbtype.MySql)
                {
                    Da = new MySqlDataAdapter();
                    Da.SelectCommand = (MySqlCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(Ds, TableName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                CloseDB();
            }
        }

        public void RunProcedure(string StoredProcName, IDataParameter[] Parameters, ref DataSet Ds, string TableName, string Connection, bool IsUseTransaction)
        {
            DbDataAdapter Da;
            IDbTransaction trans; 
            try
            {
                Open(Connection);
                if (Datatype == dbtype.Access || Datatype == dbtype.Excel)
                {
                    Da = new OleDbDataAdapter();
                    Da.SelectCommand = (OleDbCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(Ds, TableName);
                }
                else if (Datatype == dbtype.SQL_Server)
                {
                    Da = new SqlDataAdapter();
                    Da.SelectCommand = (SqlCommand)BuildQueryCommand(StoredProcName, Parameters);
                    if (IsUseTransaction)
                    {
                        trans = DbCon.BeginTransaction();
                        Da.SelectCommand.Transaction = (DbTransaction)trans;
                        try
                        {
                            Da.Fill(Ds, TableName);
                            trans.Commit();
                        }
                        catch (Exception iex)
                        {
                            trans.Rollback();
                            throw iex;
                        }
                    }
                    else
                    {
                        Da.Fill(Ds, TableName);
                    }
                }
                else if (Datatype == dbtype.Oracle)
                {
                    Da = new OracleDataAdapter();
                    Da.SelectCommand = (OracleCommand)BuildQueryCommand(StoredProcName, Parameters);
                    if (IsUseTransaction)
                    {
                        trans = DbCon.BeginTransaction();
                        Da.SelectCommand.Transaction = (DbTransaction)trans;
                        try
                        {
                            Da.Fill(Ds, TableName);
                            trans.Commit();
                        }
                        catch (Exception iex)
                        {
                            trans.Rollback();
                            throw iex;
                        }
                    }
                    else
                    {
                        Da.Fill(Ds, TableName);
                    }
                }
                else if (Datatype == dbtype.MySql)
                {
                    Da = new MySqlDataAdapter();
                    Da.SelectCommand = (MySqlCommand)BuildQueryCommand(StoredProcName, Parameters);
                    Da.Fill(Ds, TableName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                CloseDB();
            }
        }

        /// <summary>
        /// 執行查詢，並傳回查詢所傳回的結果集第一個資料列的第一個資料行。會忽略其他的資料行或資料列。 
        /// </summary>
        /// <example>
        ///	一般的 RunSQL 查詢可以如下列的範例格式化： 
        /// <code>
        /// string strSQL = "SELECT COUNT(*) FROM dbo.region";
        /// Int32 count = 0 ; //取得資料筆數
        /// RunSQL(strSQL,"Default",count);
        /// </code>
        /// </example>
        /// <param name="strSQL">SQL 語法</param>
        /// <param name="Connection">Connection名稱</param>
        /// <param name="Returnobj">回傳結果物件</param>
        public void RunSQL(string strSQL, string Connection, out object Returnobj)
        {
            IDbCommand command = Cmd;
            Cmd.CommandText = strSQL;
            Cmd.Connection = DbCon;
            try
            {
                Open(Connection);
                Returnobj = command.ExecuteScalar();
            }
            catch (MySqlException ex) { Returnobj = null; throw new Exception(ex.Message, ex); }
            catch (OracleException ex) { Returnobj = null; throw new Exception(ex.Message, ex); }
            catch (SqlException ex) { Returnobj = null; throw new Exception(ex.Message, ex); }
            catch (Exception ex) { Returnobj = null; throw new Exception(ex.Message, ex); }
            finally
            {
                CloseDB();
            }
        }


        /// <summary>
        /// 執行SQL Command並傳回DataTable
        /// </summary>
        ///<example>
        ///	一般的 RunSQL 的範例：
        ///<code>
        ///		string strSQL = "SELECT * FROM dbo.region";
        ///		DataTable dt = RunSQL(strSQL,"region");
        ///</code>
        ///</example>
        /// <param name="strSQL">SQL語法</param>
        /// <param name="TableName">DataTable名稱</param>
        /// <returns></returns>
        public DataTable RunSQL(string strSQL, string TableName, string Connection)
        {
            DataTable dt = new DataTable(TableName);
            DbDataAdapter Da;
            try
            {
                Open(Connection);
                if (Datatype == dbtype.Access || Datatype == dbtype.Excel)
                {
                    Da = new OleDbDataAdapter(strSQL, (OleDbConnection)DbCon);
                    Da.Fill(dt);
                }
                else if (Datatype == dbtype.SQL_Server)
                {
                    Da = new SqlDataAdapter(strSQL, (SqlConnection)DbCon);
                    Da.Fill(dt);
                }
                else if (Datatype == dbtype.Oracle)
                {
                    Da = new OracleDataAdapter(strSQL, (OracleConnection)DbCon);
                    Da.Fill(dt);
                }
                else if (Datatype == dbtype.MySql)
                {
                    Da = new MySqlDataAdapter(strSQL, (MySqlConnection)DbCon);
                    Da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                CloseDB();
            }
            return dt;
        }

        /// <summary>
        /// 執行SQL Command並將DataTable加入到現有的DataSet
        /// </summary>
        ///<example>
        ///	一般的 RunSQL 的範例：
        ///<code>
        ///		string strSQL = "SELECT * FROM dbo.region";
        ///		DataSet Ds= DataSet();
        ///		RunSQL(strSQL,Ds,"region","Default");
        ///</code>
        ///</example>
        /// <param name="strSQL">SQL語法</param>
        /// <param name="Ds">DataSet物件</param>
        /// <param name="TableName">DataTable名稱</param>
        /// <param name="Connection">Connection名稱</param>
        public void RunSQL(string strSQL, ref DataSet Ds, string TableName, string Connection)
        {
            try
            {
                Open(Connection);
                DbDataAdapter Da;
                if (Datatype == dbtype.Access || Datatype == dbtype.Excel)
                {
                    Da = new OleDbDataAdapter(strSQL, (OleDbConnection)DbCon);
                    Da.Fill(Ds, TableName);
                }
                else if (Datatype == dbtype.SQL_Server)
                {
                    Da = new SqlDataAdapter(strSQL, (SqlConnection)DbCon);
                    Da.Fill(Ds, TableName);
                }
                else if (Datatype == dbtype.Oracle)
                {
                    Da = new OracleDataAdapter(strSQL, (OracleConnection)DbCon);
                    Da.Fill(Ds, TableName);
                }
                else if (Datatype == dbtype.MySql)
                {
                    Da = new MySqlDataAdapter(strSQL, (MySqlConnection)DbCon);
                    Da.Fill(Ds, TableName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                CloseDB();
            }
        }

        /// <summary>
        /// 執行SQL Command並傳回影響的列數
        /// </summary>
        ///<example>
        ///	一般的 RunSQL 的範例：
        ///<code>
        ///		string strSQL = "Delete FROM dbo.region where regionid=1";
        ///		int RowsAffected=0;
        ///		RunSQL(strSQL,RowsAffected,"Default");
        ///</code>
        ///</example>
        /// <param name="strSQL">T-SQL語法</param>
        /// <param name="RowsAffected">受影響的列數</param>
        /// <param name="Connection">連線字串</param>
        public void RunSQL(string strSQL, out int RowsAffected, string Connection)
        {
            RowsAffected = 0;
            try
            {
                Open(Connection);
                if (Datatype == dbtype.Access || Datatype == dbtype.Excel)
                {
                    OleDbCommand command = new OleDbCommand(strSQL, (OleDbConnection)DbCon);
                    RowsAffected = command.ExecuteNonQuery();
                }
                else if (Datatype == dbtype.SQL_Server)
                {
                    SqlCommand command = new SqlCommand(strSQL, (SqlConnection)DbCon);
                    RowsAffected = command.ExecuteNonQuery();
                }
                else if (Datatype == dbtype.Oracle)
                {
                    OracleCommand command = new OracleCommand(strSQL, (OracleConnection)DbCon);
                    RowsAffected = command.ExecuteNonQuery();
                }
                else if (Datatype == dbtype.MySql)
                {
                    MySqlCommand command = new MySqlCommand(strSQL, (MySqlConnection)DbCon);
                    RowsAffected = command.ExecuteNonQuery();
                }
                if (RowsAffected == 0) RowsAffected = 1;
            }
            catch (MySqlException ex) { RowsAffected = 0; throw new Exception(ex.Message, ex); }
            catch (OracleException ex) { RowsAffected = 0; throw new Exception(ex.Message, ex); }
            catch (SqlException ex) { RowsAffected = 0; throw new Exception(ex.Message,ex); }
            catch (Exception ex) { RowsAffected = 0; throw new Exception(ex.Message, ex); }
            finally
            {
                CloseDB();
            }
        }


        /// <summary>
        /// 執行SQL Command並傳回成功或失敗
        /// </summary>
        ///<example>
        ///	一般的 RunSQL 的範例：
        ///<code>
        ///		string strSQL = "Delete FROM dbo.region where regionid=1";
        ///		
        ///		if(RunSQL(strSQL))
        ///			ShowErrorMessage("執行成功");
        ///		else 
        ///			ShowErrorMessage("執行失敗");
        ///</code>
        ///</example>
        /// <param name="strSQL">The STR SQL.</param>
        /// <param name="Connection">連線字串</param>
        /// <returns></returns>
        public bool RunSQL(string strSQL, string Connection)
        {
            int i = 0;
            RunSQL(strSQL, out i, Connection);
            return (i > 0);
        }

        /// <summary>
        /// 執行SQL Command並傳回成功或失敗
        /// </summary>
        ///<example>
        ///	一般的 RunSQL 的範例：
        ///<code>
        ///		string strSQL = "Delete FROM dbo.region where regionid=1";
        ///		
        ///		if(RunSQL(strSQL,"Default"))
        ///			ShowErrorMessage("執行成功");
        ///		else 
        ///			ShowErrorMessage("執行失敗");
        ///</code>
        ///</example>
        /// <param name="strSQL">The STR SQL.</param>
        /// <param name="strConnectionKey">The connectionstring.</param>
        /// <returns></returns>
        public bool ExecuteSQL(string strSQL, string strConnection)
        {
            int i = 0;
            RunSQL(strSQL, out i, strConnection);
            return (i > 0);
        }

        /// <summary>
        /// Generates the condition.
        /// </summary>
        /// <example>
        /// GenerateCondition範例：
        ///	<code>
        ///		DataTable dt = RunSQL("select * from dbo.region","region");
        ///		strSQL = "select * from dbo.employee where " + 
        ///		GenerateCondition("regionid",FilterCollection.FilterType.Equal,"en",true); 
        ///	</code>
        /// </example>
        /// <param name="FieldName">欄位名稱</param>
        /// <param name="Filter">篩選方式</param>
        /// <param name="KeyWord">值</param>
        /// <param name="AddQuote">值是否使用單引號</param>
        /// <returns></returns>
        public string GenerateCondition(string FieldName, FilterCollection.FilterType Filter, string KeyWord, bool AddQuote)
        {
            string FileType = "=";
            switch (Filter.ToString())
            {
                case "LessEqual":
                    FileType = "<=";
                    break;
                case "EqualThan":
                    FileType = ">=";
                    break;
                case "NotEqual":
                    FileType = "<>";
                    break;
                case "Less":
                    FileType = "<";
                    break;
                case "Than":
                    FileType = ">";
                    break;
                case "Like":
                    FileType = "like";
                    break;
            }

            if (!AddQuote)
                return string.Format("{0} {1} {2}", FieldName, FileType, KeyWord);
            else
            {
                if (FileType == "like")
                    return string.Format("{0} {1} '%{2}%'", FieldName, FileType, KeyWord);
                else
                    return string.Format("{0} {1} '{2}'", FieldName, FileType, KeyWord);
            }

        }

        /// <summary>
        /// 執行 Transact-SQL 交易
        /// </summary>
        /// <example>
        /// Transaction範例：
        ///	<code>
        ///		if(Transaction("insert into region('1','en')"
        ///							,"delete from region where regionid=2"))
        ///			ShowErrorMessage("執行成功");
        ///		else 
        ///			ShowErrorMessage("執行失敗");
        ///	</code>
        /// </example>
        /// <param name="strSQLS">The STR SQLS.</param>
        /// <returns></returns>
        public bool Transaction(string ConnectionStr, params string[] strSQLS)
        {
            IDbTransaction transaction = null;
            try
            {
                Open(ConnectionStr);
                transaction = DbCon.BeginTransaction();
                foreach (string strSQL in strSQLS)
                {
                    if (strSQL != "" && strSQL != null)
                    {
                        if (Datatype == dbtype.Access || Datatype == dbtype.Excel)
                            new OleDbCommand(strSQL, (OleDbConnection)DbCon, (OleDbTransaction)transaction).ExecuteNonQuery();
                        else if (Datatype == dbtype.SQL_Server)
                            new SqlCommand(strSQL, (SqlConnection)DbCon, (SqlTransaction)transaction).ExecuteNonQuery();
                        else if (Datatype == dbtype.Oracle)
                        {
                            transaction = ((OracleConnection)DbCon).BeginTransaction();
                            new OracleCommand(strSQL, (OracleConnection)DbCon).ExecuteNonQuery();
                        }
                        else if (Datatype == dbtype.MySql)
                            new MySqlCommand(strSQL, (MySqlConnection)DbCon, (MySqlTransaction)transaction).ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                return true;
            }
            catch (OracleException ex)
            {
                if (transaction != null)transaction.Rollback();
                return false;
                throw new Exception(ex.Message, ex);
            }
            catch (SqlException ex)
            {
                if (transaction != null) transaction.Rollback();
                return false;
                throw new Exception(ex.Message, ex);

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
                throw new Exception(ex.Message, ex.GetBaseException());
            }
            finally
            {
                CloseDB();
            }
        }

        /// <summary>
        /// Inserts the access log.
        /// </summary>
        /// <param name="strSQL">The STR SQL.</param>
        /// <returns></returns>
        private string InsertAccessLog(string strSQL)
        {
            return "true";
            //return(userInfo.CurrentPath!=null 
            //  && (userInfo.CurrentPath.ToLower()!="default.aspx" 
            //  || userInfo.CurrentPath.ToLower()!="banner.aspx" 
            //  || userInfo.CurrentPath.ToLower()!="middle.aspx" 
            //  || userInfo.CurrentPath.ToLower()!="treeview.aspx"
            //  || userInfo.CurrentPath.ToLower()!="basepage.cs"))?(string.Format(@"INSERT INTO [AccessLog]" + "\r\n" +
            //  @"           ([UserId]" + "\r\n" +
            //  @"           ,[SQLCmd]" + "\r\n" +
            //  @"           ,[AppPath]" + "\r\n" +
            //  @"           ,[LoginId]" + "\r\n" +
            //  @"           ,[Createdate])" + "\r\n" +
            //  @"     VALUES(" + "\r\n" +
            //  @"           '{0}'" + "\r\n" +
            //  @"           ,'{1}'" + "\r\n" +
            //  @"           ,'{2}'" + "\r\n" +
            //  @"           ,'{3}'" + "\r\n" +
            //  @"           ,getdate())",userInfo.UserID,strSQL.Replace("'","''"),userInfo.CurrentPath,userInfo.PageLoginId)):"";
        }
        #region IDisposable 成員

        public void Dispose()
        {
            if (DbCon != null)
            {
                DbCon.Close();
                DbCon.Dispose();
                DbCon = null;  
            }
        }

        #endregion
    }
}
