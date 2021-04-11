using System;
using System.Collections.Generic;

namespace LibBD
{
    /// <summary>
    /// This Super Class Helps to define a CONCRETE class that will be execute a DB actions 
    /// employing this attributes to generate the ConectionString to each DBMS
    /// </summary>
    
    public abstract class  BD
    {
        //properties

        public static string ERROR;

        //db properties

        protected string SERVER { get; set; }
        protected string DBNAME { get; set; }
        protected string USER { get; set; }
        protected string PASSW { get; set; }
        protected string PORT { get; set; }

        //Abstract Methods

        /// <summary>
        /// Create a new row in the established table on the parameters
        /// </summary>
        /// <param name="table">The table in which the data will be added</param>
        /// <param name="data">Value that will be added to the table</param>
        /// <returns>True if the row is created. False if there's an Error</returns>
        public abstract bool Create(string table, List<DataCollection> data);
        /// <summary>
        /// Updates a Row with the ID and Date provided in the parameters, on the selected table
        /// </summary>
        /// <param name="table">The selected table to be updated</param>
        /// <param name="data">the new value to replace the old value</param>
        /// <param name="id">The ID of the row to be updated</param>
        /// <returns>True if the row is created. False if there's an Error</returns>
        public abstract bool Update(string table, List<DataCollection> data, int id);
        /// <summary>
        /// Deletes a Row with the ID and Date provided in the parameters, on the selected table
        /// </summary>
        /// <param name="table">the table from where the date is going to be deleted</param>
        /// <param name="id">the index of the field that is going to be deleted</param>
        /// <returns></returns>
        public abstract bool Delete(string table, int id);
        /// <summary>
        /// Selects a row set that will be a result of a query on the table establish, 
        /// with the search criteria on the input
        /// </summary>
        /// <param name="fields">The fields to be given on the row set</param>
        /// <param name="table">Selected table</param>
        /// <param name="search">The search criteria and their logic</param>
        /// <returns>a list of objects that will be represent a row each on of them , and every one is List<Object></returns>
        public abstract List<List<DataCollection>> Read(List<string> fields, string table, List<SearchCollection> search);
        /// <summary>
        /// Selects an inner join between two tables 
        /// </summary>
        /// <param name="fields">the fields that are going to be search for</param>
        /// <param name="table1">the table were some of the fields are</param>
        /// <param name="table2">the second table use to inner join the first one to </param>
        /// <param name="onFields">the field conditionals the will allow o generate and intersection</param>
        /// <param name="search">the field conditionals the will allow o generate and intersection</param>
        /// <returns></returns>
        public abstract List<List<DataCollection>> Read(List<string> fields, string table1, string table2, List<string> onFields, List<SearchCollection> search);
        /// <summary>
        /// Retrieves the complete row set of a table, order by the field in the input parameters
        /// </summary>
        /// <param name="table">Table from which the data will be retrieved</param>
        /// <param name="order">the field to be order by (ASC, DESC)</param>
        /// <returns>a list of objects that will be represent a row each on of them , and every one is List<Object></returns>
        public abstract List<List<DataCollection>> Index(string table, OrderBy order);
        /// <summary>
        /// Opens the connection to the SERVER established by the connectionString
        /// </summary>
        /// <returns></returns>
        public abstract bool Connect();
        /// <summary>
        /// Closes the connection to the SERVER established by the connectionString
        /// </summary>
        /// <returns></returns>
        public abstract bool Disconnect();
    }
}
