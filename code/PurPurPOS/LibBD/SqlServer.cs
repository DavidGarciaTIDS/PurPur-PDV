using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace LibBD
{
    public class SqlServer : BD
    {
        //Attributes of SQLServer

        SqlConnection con;
        SqlCommand com;
        //SqlDataReader dr;

        //ConectionString
        string connectionString;

        //Constructor
        public SqlServer(string server, string db, string user, string pwd, string port="1433") 
        {
            //initialize attributes
            this.SERVER = server;
            this.DBNAME = db;
            this.USER = user;
            this.PASSW = pwd;
            this.PORT = port;

            //
            this.connectionString = $"Server={this.SERVER},{this.PORT};Database={this.DBNAME};User Id={this.USER};Password={this.PASSW};";
            //instantiate the connection
            this.con = new SqlConnection(this.connectionString);
        }


        //BND actions
        public override bool Connect()
        {
            bool res = false;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                else if (con.State == ConnectionState.Broken)
                {
                    con.Close();
                    con.Open();
                }
                res = true;
            }
            catch (SqlException Sqlex) 
            {
                BD.ERROR = "SQL Error while opening Sql Server Connection " + Sqlex;
            }

            catch (Exception ex)
            {
                BD.ERROR = "Error while opening Sql Server Connection " + ex;
            }


            return res;
        }

        public override bool Disconnect()
        {
            bool res = false;
            try
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
                
                res = true;
            }
            catch (SqlException Sqlex)
            {
                BD.ERROR = "SQL Error while closing Sql Server Connection " + Sqlex;
            }

            catch (Exception ex)
            {
                BD.ERROR = "Error while closing Sql Server Connection " + ex;
            }


            return res;
        }

        public override bool Create(string table, List<DataCollection> data)
        {
            bool res = false;
            string query = "";

            try
            {
                //Connect to SQL DB
                this.Connect();

                //Initialize the Query text
                query = $" INSERT INTO {table} (";

                //Separate the data by comas ','
                foreach (DataCollection dato in data)
                {
                    query += dato.Name + ",";
                }
                //Removing the last coma from the text and add the start of the value section 
                query += query.Remove(query.Length - 1);
                query += " ) VALUES (";

                //Add Values in the list
                foreach (DataCollection dato in data)
                {
                    query += $"{dato.Value},";
                }
                //Removing the last coma from the text       
                query = query.Remove(query.Length - 1);
                query += " );";

                //Establish and execute the connection
                com = new SqlCommand(query, con);
                int rows = com.ExecuteNonQuery();

                if (rows == 1) res = true;

                else BD.ERROR = "ERROR UNKWOWN MALFUCTION INSERT QUERY";

            }
            catch (SqlException mysqlex)
            {
                BD.ERROR = $"SQL ERROR WHILE INSERT QUERY. {mysqlex.Message}";
            }
            catch (IOException ioex)
            {
                BD.ERROR = $"ERROR OF COMIUNICATION WHILE INSERTING. {ioex.Message}";
            }
            catch (Exception ex)
            {
                BD.ERROR = $"GENERAL ERROR OF INSERTION. {ex.Message}";
            }
            finally
            {
                //Closes Connection 
                this.Disconnect();
            }

            return res;
        }

        public override List<List<DataCollection>> Index(string table, OrderBy order, List<string> ListColumns)
        {
            // returns a dynamic list of RECORDS/ROWS, each of there are List<object>
            List<List<DataCollection>> res = new List<List<DataCollection>>();
            try
            {
                //Connect
                this.Connect();
                string Columns = "";
                foreach (string item in ListColumns)
                {
                    Columns += item + ",";
                }
                Columns.Remove(Columns.Length - 1);
                //Create and select query
                string query = $"SELECT {Columns} FROM {table} WHERE 1 ORDER BY {order.Name} {order.OrderCriteria}";
                //instantiate the SQL command
                com = new SqlCommand(query, con);

                //execute (READER) the query
                SqlDataReader dr = com.ExecuteReader();
                //parse the dataReader

                //Is there any Records/Rows from SELECT
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //Create a List<object> for each Record
                        List<DataCollection> row = new List<DataCollection>();
                        DataCollection item;
                        //Read every column of each of the rows 
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            item = new DataCollection(dr.GetName(i), Types.VARCHAR, dr.GetValue(i));
                            item.ThisFieldType(dr.GetDataTypeName(i));
                            row.Add(item);
                        }
                        //ADD this list to the res collection 

                        res.Add(row);


                    }
                }
                else 
                {
                    BD.ERROR = "EMPTY TABLE, THERE IS NO ROWS IN THE RESULT";
                }
            }
            catch (SqlException mysqlex)
            {
                BD.ERROR = $"SQL ERROR WHILE READING TABLE: -{table}- index. {mysqlex.Message}";
            }
            catch (IOException ioex)
            {
                BD.ERROR = $"ERROR OF COMIUNICATION WHILE READING TABLE: -{table}- index. {ioex.Message}";
            }
            catch (Exception ex)
            {
                BD.ERROR = $"GENERAL ERROR OF READING TABLE: -{table}- index. {ex.Message}";
            }
            finally
            {
                //Closes Connection 
                this.Disconnect();
            }

            //return the Records
            return res;
        }

        public override List<List<DataCollection>> Read(List<string> fields, string table, List<SearchCollection> search)
        {
            // returns a dynamic list of RECORDS/ROWS, each of there are List<object>
            List<List<DataCollection>> res = new List<List<DataCollection>>();
            try
            {
                //Connect
                this.Connect();
                //Parse the fields collections
                string parseFields="";
                foreach (string col in fields)
                {
                    parseFields += $"{col},";
                }

                //remove last comma
                parseFields = parseFields.Remove(parseFields.Length-1);

                //parse search collection
                string parseWhere = "";

                foreach (SearchCollection criteria in search)
                {
                    parseWhere += $"{criteria.Name} {criteria.ParseOperator(criteria.Operator)} {criteria.Value} {criteria.ParseLogicOperator(criteria.LogicOp)}";
                }

                //Create and select query
                string query = $"SELECT {parseFields} FROM {table} WHERE {parseWhere} ";
                //instantiate the SQL command
                com = new SqlCommand(query, con);

                //execute (READER) the query
                SqlDataReader dr = com.ExecuteReader();
                //parse the dataReader

                //Is there any Records/Rows from SELECT
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //Create a List<object> for each Record
                        List<DataCollection> row = new List<DataCollection>();
                        DataCollection item;
                        //Read every column of each of the rows 
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            item = new DataCollection(dr.GetName(i), Types.VARCHAR, dr.GetValue(i));
                            item.ThisFieldType(dr.GetDataTypeName(i));
                            row.Add(item);
                        }
                        //ADD this list to the res collection 

                        res.Add(row);


                    }
                }
                else
                {
                    BD.ERROR = "EMPTY TABLE, THERE IS NO ROWS IN THE RESULT";
                }
            }
            catch (SqlException mysqlex)
            {
                BD.ERROR = $"SQL ERROR WHILE READING TABLE: {table}. {mysqlex.Message}";
            }
            catch (IOException ioex)
            {
                BD.ERROR = $"ERROR OF COMIUNICATION WHILE READING TABLE: {table}. {ioex.Message}";
            }
            catch (Exception ex)
            {
                BD.ERROR = $"GENERAL ERROR OF READING TABLE: {table}. {ex.Message}";
            }
            finally
            {
                //Closes Connection 
                this.Disconnect();
            }

            //return the Records
            return res;
        }

        public override List<List<DataCollection>> Read(List<string> fields, string table1, string table2, List<string> onFields, List<SearchCollection> search)
        {


            // returns a dynamic list of RECORDS/ROWS, each of there are List<object>
            List<List<DataCollection>> res = new List<List<DataCollection>>();
            try
            {
                //Connect
                this.Connect();
                //Parse the fields collections
                string parseFields = "";
                foreach (string col in fields)
                {
                    parseFields += $"{col},";
                }

                //remove last comma
                parseFields = parseFields.Remove(parseFields.Length - 1);

                //parse search collection
                string parseWhere = "";

                foreach (SearchCollection criteria in search)
                {
                    parseWhere += $"{criteria.Name} {criteria.ParseOperator(criteria.Operator)} {criteria.Value} {criteria.ParseLogicOperator(criteria.LogicOp)}";
                }
               
                //Parse the onQuery
                
                //the Onstring
                string onInnerString = "";
                foreach (string col in onFields)
                {
                    onInnerString += $" {col}";
                }



                //Create and select query
                string query = $"SELECT {parseFields} FROM {table1} INNER JOIN {table2} ON {onInnerString} WHERE {parseWhere} ";
                //instantiate the SQL command
                com = new SqlCommand(query, con);

                //execute (READER) the query
                SqlDataReader dr = com.ExecuteReader();
                //parse the dataReader

                //Is there any Records/Rows from SELECT
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //Create a List<object> for each Record
                        List<DataCollection> row = new List<DataCollection>();
                        DataCollection item;
                        //Read every column of each of the rows 
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            item = new DataCollection(dr.GetName(i), Types.VARCHAR, dr.GetValue(i));
                            item.ThisFieldType(dr.GetDataTypeName(i));
                            row.Add(item);
                        }
                        //ADD this list to the res collection 

                        res.Add(row);


                    }
                }
                else
                {
                    BD.ERROR = "EMPTY TABLE, THERE IS NO ROWS IN THE RESULT ON INNER JOIN QUERY";
                }
            }
            catch (SqlException mysqlex)
            {
                BD.ERROR = $"SQL ERROR WHILE READING TABLES: {table1} , {table2}. {mysqlex.Message}";
            }
            catch (IOException ioex)
            {
                BD.ERROR = $"ERROR OF COMIUNICATION WHILE READING TABLES: {table1} , {table2}. {ioex.Message}";
            }
            catch (Exception ex)
            {
                BD.ERROR = $"GENERAL ERROR OF READING TABLES: {table1} , {table2}. {ex.Message}";
            }
            finally
            {
                //Closes Connection 
                this.Disconnect();
            }

            //return the Records
            return res;

        }

        public override bool Update(string table, List<DataCollection> data, int id)
        {
            bool res = false;
            string query = "";

            try
            {
                //Connect to SQL DB
                Connect();

                //Initialize the Query text
                query = $"UPDATE {table} SET ";

                //Add the new values to the correspondent field
                foreach (DataCollection dato in data)
                {
                    query += $"{dato.Name} = {dato.Value}, ";
                }
                //Removing the last coma from the text and the blank space 
                query += query.Remove(query.Length - 2);
                query += $" WHERE id={id} ";

                //Establish and execute the connection
                com = new SqlCommand(query, con);
                int rows = com.ExecuteNonQuery();

                if (rows == 1) res = true;

                else BD.ERROR = "ERROR UNKWOWN MALFUCTION UPDATE QUERY";

            }
            catch (SqlException mysqlex)
            {
                BD.ERROR = $"SQL ERROR WHILE UPDATE QUERY. {mysqlex.Message}";
            }
            catch (IOException ioex)
            {
                BD.ERROR = $"ERROR OF COMIUNICATION WHILE UPDATING. {ioex.Message}";
            }
            catch (Exception ex)
            {
                BD.ERROR = $"GENERAL ERROR OF UPDATING. {ex.Message}";
            }
            finally
            {
                //Closes Connection 
                Disconnect();
            }

            return res;
        }
        
        public override bool Delete(string table, int id)
        {
            bool res = false;
            string query = "";

            try
            {
                //Connect to SQL DB
                Connect();

                //Initialize the Query text
                query = $"DELETE FROM {table} WHERE id= {id} ";

                //Establish and execute the connection
                com = new SqlCommand(query, con);
                int rows = com.ExecuteNonQuery();

                if (rows == 1) res = true;

                else BD.ERROR = "ERROR UNKWOWN MALFUCTION DELETE QUERY";

            }
            catch (SqlException mysqlex)
            {
                BD.ERROR = $"SQL ERROR WHILE DELETE QUERY. {mysqlex.Message}";
            }
            catch (IOException ioex)
            {
                BD.ERROR = $"ERROR OF COMIUNICATION WHILE DELETING. {ioex.Message}";
            }
            catch (Exception ex)
            {
                BD.ERROR = $"GENERAL ERROR OF DELETING. {ex.Message}";
            }
            finally
            {
                //Closes Connection 
                Disconnect();
            }

            return res;
        }
    }
}
