using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.CSV
{
    public static class CSVLoader
    {
        /// <summary>
        /// Csv configuration initialization with delimiter and csv objects
        /// </summary>
        /// <param name="delimiter">Object's delimiter</param>
        /// <param name="configuration">Object's csv configuration action</param>
        /// <returns></returns>
        public static CsvConfiguration InitializeConfiguration( string delimiter, Action<CsvConfiguration> configuration )
        {
            var csvConfiguration = new CsvConfiguration( CultureInfo.InvariantCulture )
            {
                Delimiter = delimiter,
                TrimOptions = TrimOptions.Trim,
                HasHeaderRecord = false
            };

            configuration( csvConfiguration );
            return csvConfiguration;
        }

        /// <summary>
        /// Read and translate csv file from source
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="dataFolder">Data folder which contains csv file</param>
        /// <param name="fileName">CSV file's name</param>
        /// <param name="configuration">CSV configuration</param>
        /// <returns>Enumerable contains all the converted object specifics</returns>
        public static IEnumerable<T> ReadCsv<T>( string dataFolder, string fileName, CsvConfiguration configuration )
        {
            var filePath = Path.Combine( dataFolder, fileName );
            if( !File.Exists( filePath ) ) throw new InvalidOperationException( "File does not exist" );

            using var streamReader = new StreamReader( filePath );
            using var csvReader = new CsvReader( streamReader, configuration );

            return csvReader.GetRecords<T>().ToList();
        }
    }
}
